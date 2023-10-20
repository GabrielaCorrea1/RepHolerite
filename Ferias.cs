using Npgsql;
using System.Diagnostics;
using OfficeOpenXml;
using System.IO;


namespace RepHolerite
{
    public partial class Ferias : Form
    {
        private NpgsqlConnection connection;
        private NpgsqlCommand command;
        private NpgsqlParameter parameter;
        private NpgsqlDataReader reader; // declara a variável reader em um escopo maior

        public Ferias()
        {

            // Define a propriedade LicenseContext para fins não comerciais

            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            InitializeComponent();

            // Configura a conexão com o banco de dados
            string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";
            connection = new NpgsqlConnection(connectionString);
            command = new NpgsqlCommand();
            parameter = new NpgsqlParameter("@nome", NpgsqlTypes.NpgsqlDbType.Varchar);

            // Registra o evento Load para chamar o método Ferias_Load
            this.Load += Ferias_Load;
        }

        private void Ferias_Load(object sender, EventArgs e)
        {
            // Executa a consulta SQL para obter os nomes dos funcionários
            string query = "SELECT nome FROM funcionario";
            command.Connection = connection;
            command.CommandText = query;
            connection.Open();
            reader = command.ExecuteReader(); // atribui o valor de reader ao método ExecuteReader()

            // Preenche a combobox com os nomes dos funcionários
            while (reader.Read())
            {
                cbbx_funferias.Items.Add(reader.GetString(0));
            }
            cbbx_funferias.SelectedIndexChanged += cbbx_funferias_SelectedIndexChanged;

            // Fecha o leitor e a conexão com o banco de dados
            reader.Close();
            connection.Close();


        }

        private decimal ObterSalarioFuncionario()
        {
            // Obtém o nome do funcionário selecionado na combobox
            string nome = cbbx_funferias.SelectedItem.ToString();

            // Configura a consulta SQL para obter o nome e o salário do funcionário selecionado
            string sql = "SELECT nome, salario FROM funcionario WHERE nome = @nome";
            command.Connection = connection;
            command.CommandText = sql;
            parameter.Value = nome;
            command.Parameters.Clear();
            command.Parameters.Add(parameter);

            Debug.WriteLine("Consulta SQL: " + command.CommandText);

            // Abre a conexão com o banco de dados, executa a consulta e recupera os valores do nome e do salário
            connection.Open();
            reader = command.ExecuteReader(); // atribui o valor de reader ao método ExecuteReader()
            decimal salario = 0;

            // Verifica se a consulta retornou alguma linha e, se sim, recupera o valor do salário
            if (reader.HasRows)
            {
                reader.Read();
                salario = reader.GetDecimal(1);
            }

            Debug.WriteLine("Salário: " + salario);

            reader.Close();
            connection.Close();

            // Retorna o valor do salário
            return salario;
        }
        private void cbbx_funferias_SelectedIndexChanged(object sender, EventArgs e)
        {
            decimal salario = ObterSalarioFuncionario();
            txt_salferias.Text = salario.ToString("C");


        }

        private void cbbx_funferias_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btn_salvarferias_Click(object sender, EventArgs e)
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

            // Verifica se a caixa de texto txt_horaextraferias está vazia
            decimal HoraFerias = 0;
            if (!string.IsNullOrEmpty(txt_horaextraferias.Text))
            {


                // Converte o valor da caixa de texto "txt_horaextraferias" para o tipo numérico
                if (!decimal.TryParse(txt_horaextraferias.Text, out HoraFerias))
                {
                    // Se a conversão falhar, exibe uma mensagem de erro e sai da função
                    MessageBox.Show("Valor da hora extra inválido!");
                    return;
                }
            }
            else
            {
                txt_horaextraferias.Text = "0";
            }

            // Cria um objeto ExcelPackage apontando para o arquivo "Modelo_Ferias.xlsx"
            var fileInfo = new FileInfo(Path.Combine(pastaPrincipal, "Modelo_Ferias.xlsx"));
            var package = new ExcelPackage(fileInfo);


            // Acessa a planilha "Folha1" e insere o conteúdo nas células 
            var planilha = package.Workbook.Worksheets["Folha1"];
            planilha.Cells["C8"].Value = cbbx_funferias.SelectedItem.ToString();
            planilha.Cells["C47"].Value = cbbx_funferias.SelectedItem.ToString();
            planilha.Cells["J7"].Value = txt_mesferias.Text;
            planilha.Cells["J46"].Value = txt_mesferias.Text;
            planilha.Cells["L8"].Value = txt_salferias.Text;
            planilha.Cells["F12"].Value = txt_horaextraferias.Text;


            // Salva as alterações no arquivo com um novo nome
            var novoNome = cbbx_funferias.SelectedItem.ToString() + "_Ferias.xlsx";
            var novoCaminho = Path.Combine(pastaPlanilhaFerias, novoNome);
            package.SaveAs(new FileInfo(novoCaminho));

            // Exibe mensagem informando que a planilha foi criada com sucesso
            MessageBox.Show("Planilha criada com sucesso!");

            // Fecha o objeto ExcelPackage
            package.Dispose();

        }

        private void Ferias_Load_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }


}
