using Npgsql;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepHolerite
{
    public partial class _13 : Form
    {
        public _13()
        {
            // Define a propriedade LicenseContext para fins não comerciais

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;



            InitializeComponent();

            // Popula o combobox com os nomes dos funcionários
            string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT nome FROM funcionario";
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
            DataTable table = new DataTable();
            adapter.Fill(table);
            cbbx_fun13.DataSource = table;
            cbbx_fun13.DisplayMember = "nome";
            connection.Close();

            // Define SelectedIndex para -1 para que nenhum item seja selecionado inicialmente
            cbbx_fun13.SelectedIndex = -1;
        }

        private void cbbx_fun13_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Recupera o nome selecionado no combobox
            string nome = cbbx_fun13.GetItemText(cbbx_fun13.SelectedItem);

            // Executa uma consulta SQL para recuperar o salário correspondente
            string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";
            NpgsqlConnection connection = new NpgsqlConnection(connectionString);
            connection.Open();
            string query = "SELECT salario FROM funcionario WHERE nome = @nome";
            NpgsqlCommand command = new NpgsqlCommand(query, connection);
            command.Parameters.AddWithValue("@nome", nome);
            NpgsqlDataReader reader = command.ExecuteReader();

            // Exibe o resultado na txt_sal13
            if (reader.Read())
            {
                txt_sal13.Text = reader["salario"].ToString();
            }
            else
            {
                txt_sal13.Text = "";
            }

            connection.Close();
        }

        private void btn_salvar13_Click(object sender, EventArgs e)
        {
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

            // Verifica se a caixa de texto txt_horaextra13 está vazia
            decimal hora13 = 0;
            if (!string.IsNullOrEmpty(txt_horaextra13.Text))
            {


                // Converte o valor da caixa de texto "txt_horaextra13" para o tipo numérico
                if (!decimal.TryParse(txt_horaextra13.Text, out hora13))
                {
                    // Se a conversão falhar, exibe uma mensagem de erro e sai da função
                    MessageBox.Show("Valor da hora extra inválido!");
                    return;
                }
            }
            else
            {
                txt_horaextra13.Text = "0";
            }

            // Cria um objeto ExcelPackage apontando para o arquivo "Modelo_13.xlsx"
            var fileInfo = new FileInfo(Path.Combine(pastaPrincipal, "Modelo_13.xlsx"));
            var package = new ExcelPackage(fileInfo);

            // Acessa a planilha "Folha1" e insere o conteúdo nas células 
            var planilha = package.Workbook.Worksheets["Folha1"];
            string nome = cbbx_fun13.GetItemText(cbbx_fun13.SelectedItem);
            planilha.Cells["C8"].Value = nome;
            planilha.Cells["C47"].Value = nome;
            planilha.Cells["J7"].Value = txt_mes13.Text;
            planilha.Cells["J46"].Value = txt_mes13.Text;
            planilha.Cells["L8"].Value = txt_sal13.Text;
            planilha.Cells["D11"].Value = txt_dias13.Text;
            planilha.Cells["F11"].Value = txt_mesestrabalhados13.Text;
            planilha.Cells["F12"].Value = txt_horaextra13.Text;

            // Salva as alterações no arquivo com um novo nome
            var novoNome = nome + "_13.xlsx";
            var novoCaminho = Path.Combine(pastaPlanilha13, novoNome);
            package.SaveAs(new FileInfo(novoCaminho));

            // Exibe mensagem informando que a planilha foi criada com sucesso
            MessageBox.Show("Planilha criada com sucesso!");

            // Fecha o objeto ExcelPackage
            package.Dispose();
        }


        private void _13_Load(object sender, EventArgs e)
        {

        }

        private void btn_limpar13_Click(object sender, EventArgs e)
        {
            txt_sal13.Clear();
            txt_horaextra13.Clear();
            txt_mes13.Clear();
            txt_mesestrabalhados13.Clear();
            txt_dias13.Clear();
        }
    }
}