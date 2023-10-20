using Npgsql;
using OfficeOpenXml;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace RepHolerite
{
    public partial class Mensal : Form
    {
        private string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";

        public Mensal()
        {
            // Define a propriedade LicenseContext para fins não comerciais
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            // Popula o combobox com os nomes dos funcionários
            string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT codigo_funcionario, nome FROM funcionario";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbx_funmensal.DataSource = table;
            cbbx_funmensal.DisplayMember = "nome";
            cbbx_funmensal.ValueMember = "codigo_funcionario"; // Define a coluna de valor do combobox
            connection.Close();

            // Define SelectedIndex para -1 para que nenhum item seja selecionado inicialmente
            cbbx_funmensal.SelectedIndex = -1;
        }

        private void cbbx_funmensal_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recupera o nome selecionado no combobox
            string nome = cbbx_funmensal.GetItemText(cbbx_funmensal.SelectedItem);

            // Executa uma consulta SQL para recuperar o salário e a insalubridade correspondente
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT salario, adicional FROM funcionario WHERE nome = @nome";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", nome);
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Exibe o resultado na txt_salmensal e txt_insalubridade
                        if (reader.Read())
                        {
                            txt_salmensal.Text = reader["salario"].ToString();
                            txt_adcmensal.Text = reader["adicional"].ToString();
                        }
                        else
                        {
                            txt_salmensal.Text = "";
                            txt_adcmensal.Text = "";
                        }
                    }
                }
            }
        }

        private void btn_salvarmensal_Click(object sender, EventArgs e)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                // Obtém o código do funcionário selecionado na combobox
                DataRowView selectedRow = (DataRowView)cbbx_funmensal.SelectedItem;
                int codigoFuncionario = Convert.ToInt32(selectedRow.Row["codigo_funcionario"]);

                string queryCodigo = "SELECT codigo_funcionario, nome FROM funcionario WHERE codigo_funcionario = @codigo";
                using (NpgsqlCommand commandCodigo = new NpgsqlCommand(queryCodigo, connection))
                {
                    commandCodigo.Parameters.AddWithValue("@codigo", codigoFuncionario);
                    using (NpgsqlDataReader reader = commandCodigo.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            string nomeFuncionario = reader["nome"].ToString();

                            // Fecha o reader antes de executar a próxima consulta
                            reader.Close();

                            // Verifica se já existe um registro para o mês informado com o mesmo código de funcionário e valor de hora extra
                            string queryVerificaMes = "SELECT COUNT(*) FROM hora WHERE codigo_funcionario = @codigo_funcionario AND referencia = @referencia AND hora_total = @hora_extra::numeric";
                            using (NpgsqlCommand commandVerificaMes = new NpgsqlCommand(queryVerificaMes, connection))
                            {
                                commandVerificaMes.Parameters.AddWithValue("@codigo_funcionario", codigoFuncionario);
                                commandVerificaMes.Parameters.AddWithValue("@referencia", txt_mesmensal.Text);
                                decimal horaExtraMensal;

                                // Verifica se a caixa de texto txt_horaextramensal está vazia
                                if (string.IsNullOrEmpty(txt_horaextramensal.Text))
                                {
                                    horaExtraMensal = 0; // Define como 0 se estiver vazio
                                }
                                else
                                {
                                    decimal.TryParse(txt_horaextramensal.Text, out horaExtraMensal);
                                }

                                commandVerificaMes.Parameters.AddWithValue("@hora_extra", horaExtraMensal);

                                int count = Convert.ToInt32(commandVerificaMes.ExecuteScalar());

                                // Atualiza a coluna hora_total na tabela hora para o funcionário selecionado
                                string queryHora;
                                NpgsqlCommand commandHora;
                                if (count > 0)
                                {
                                    // Já existe um registro para o mês informado, atualiza a hora_total
                                    queryHora = "UPDATE hora SET hora_total = @hora WHERE codigo_funcionario = @codigo_funcionario AND referencia = @referencia";
                                    commandHora = new NpgsqlCommand(queryHora, connection);
                                    commandHora.Parameters.AddWithValue("@hora", horaExtraMensal);
                                    commandHora.Parameters.AddWithValue("@codigo_funcionario", codigoFuncionario);
                                    commandHora.Parameters.AddWithValue("@referencia", txt_mesmensal.Text);
                                }
                                else
                                {
                                    // Não existe um registro para o mês informado, insere um novo registro
                                    queryHora = "INSERT INTO hora (codigo_funcionario, nome, referencia, hora_total) VALUES (@codigo, @nome, @referencia, @hora)";
                                    commandHora = new NpgsqlCommand(queryHora, connection);
                                    commandHora.Parameters.AddWithValue("@codigo", codigoFuncionario);
                                    commandHora.Parameters.AddWithValue("@nome", nomeFuncionario);
                                    commandHora.Parameters.AddWithValue("@referencia", txt_mesmensal.Text);
                                    commandHora.Parameters.AddWithValue("@hora", horaExtraMensal);
                                }

                                // Prepara o comando SQL para execução
                                commandHora.Prepare();

                                // Executa o comando SQL preparado
                                commandHora.ExecuteNonQuery();
                            }

                            // Caminho da pasta principal
                            var pastaPrincipal = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Planilhas");

                            // Cria a pasta principal se ela não existe
                            if (!Directory.Exists(pastaPrincipal))
                            {
                                Directory.CreateDirectory(pastaPrincipal);
                            }

                            // Cria as pastas dentro da pasta principal
                            var pastaPlanilha13 = Path.Combine(pastaPrincipal, "Planilha_13");
                            var pastaPlanilhaFerias = Path.Combine(pastaPrincipal, "Planilha_Ferias");
                            var pastaPlanilhaMensal = Path.Combine(pastaPrincipal, "Planilha_Mensal");

                            Directory.CreateDirectory(pastaPlanilha13);
                            Directory.CreateDirectory(pastaPlanilhaFerias);
                            Directory.CreateDirectory(pastaPlanilhaMensal);

                            // Salvando no Excel
                            string nomeArquivo = $"{nomeFuncionario}_Mensal.xlsx";
                            string pastaPrincipalDiretorio = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Planilhas");
                            string modeloFilePath = Path.Combine(pastaPrincipalDiretorio, "Modelo_Mensal.xlsx");
                            string filePath = Path.Combine(pastaPrincipalDiretorio, "Planilha_Mensal", nomeArquivo);

                            // Faz uma cópia do modelo para o arquivo final com o nome do funcionário
                            File.Copy(modeloFilePath, filePath, true);

                            using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                            {
                                ExcelWorksheet worksheet = package.Workbook.Worksheets["Folha1"];
                                worksheet.Cells["L8"].Value = txt_salmensal.Text;

                                // Verifica se a caixa de texto txt_adcmensal está vazia
                                if (string.IsNullOrEmpty(txt_adcmensal.Text))
                                {
                                    worksheet.Cells["K8"].Value = "0"; // Define como 0 na planilha se estiver vazio
                                }
                                else
                                {
                                    worksheet.Cells["K8"].Value = txt_adcmensal.Text;
                                }

                                // Verifica se a caixa de texto txt_horaextramensal está vazia
                                if (string.IsNullOrEmpty(txt_horaextramensal.Text))
                                {
                                    worksheet.Cells["F13"].Value = "0"; // Define como 0 na planilha se estiver vazio
                                }
                                else
                                {
                                    worksheet.Cells["F13"].Value = txt_horaextramensal.Text;
                                }

                                // Verifica se a caixa de texto txt_faltahoramensal está vazia
                                if (string.IsNullOrEmpty(txt_faltahoramensal.Text))
                                {
                                    worksheet.Cells["F15"].Value = "0"; // Define como 0 na planilha se estiver vazio
                                }
                                else
                                {
                                    worksheet.Cells["F15"].Value = txt_faltahoramensal.Text;
                                }

                                // Verifica se a caixa de texto txt_faltadiamensal está vazia
                                if (string.IsNullOrEmpty(txt_faltadiamensal.Text))
                                {
                                    worksheet.Cells["F16"].Value = "0"; // Define como 0 na planilha se estiver vazio
                                }
                                else
                                {
                                    worksheet.Cells["F16"].Value = txt_faltadiamensal.Text;
                                }

                                // Verifica se a caixa de texto txt_dsrmensal está vazia
                                if (string.IsNullOrEmpty(txt_dsrmensal.Text))
                                {
                                    worksheet.Cells["F17"].Value = "0"; // Define como 0 na planilha se estiver vazio
                                }
                                else
                                {
                                    worksheet.Cells["F17"].Value = txt_dsrmensal.Text;
                                }
                                worksheet.Cells["C8"].Value = cbbx_funmensal.Text;
                                worksheet.Cells["C47"].Value = cbbx_funmensal.Text;
                                worksheet.Cells["F11"].Value = txt_diastrabalhados.Text;
                                worksheet.Cells["L7"].Value = txt_mesmensal.Text;
                                worksheet.Cells["D11"].Value = txt_diasmensal.Text;

                                // Verifica se a caixa de texto txt_diasuteis está vazia
                                if (string.IsNullOrEmpty(txt_diasuteis.Text))
                                {
                                    worksheet.Cells["D76"].Value = "1"; // Define como 1 na planilha se estiver vazio
                                }
                                else
                                {
                                    worksheet.Cells["D76"].Value = txt_diasuteis.Text;
                                }

                                // Verifica se a caixa de texto txt_domingomensal está vazia
                                if (string.IsNullOrEmpty(txt_domingomensal.Text))
                                {
                                    worksheet.Cells["D77"].Value = "1"; // Define como 1 na planilha se estiver vazio
                                }
                                else
                                {
                                    worksheet.Cells["D77"].Value = txt_domingomensal.Text;
                                }

                                // Verifica se a caixa de texto txt_horaextra100 está vazia
                                if (string.IsNullOrEmpty(txt_horaextra100.Text))
                                {
                                    worksheet.Cells["F18"].Value = "0"; // Define como 0 na planilha se estiver vazio
                                }
                                else
                                {
                                    worksheet.Cells["F18"].Value = txt_horaextra100.Text;
                                }

                                package.Save();
                            }

                            MessageBox.Show("Planilha gerada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Funcionário não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void Mensal_Load(object sender, EventArgs e)
        {

        }
    }
}