using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace RepHolerite
{
    public partial class Cadastrar : Form
    {
        public Cadastrar()
        {
            InitializeComponent();
        }

        private void btn_salvarcadastrar_Click(object sender, EventArgs e)
        {
            string nome = txt_funcadastrar.Text;
            decimal salario = Convert.ToDecimal(txt_salcadastrar.Text);
            decimal adicional = Convert.ToDecimal(txt_adccadastrar.Text);

            string query = "INSERT INTO funcionario (nome, salario, adicional) VALUES (@nome, @salario, @adicional)";

            // Cria a conexão com o banco de dados
            string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    // Abre a conexão com o banco de dados
                    connection.Open();

                    // Cria o comando SQL
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@salario", salario);
                    command.Parameters.AddWithValue("@adicional", adicional);

                    // Executa o comando SQL
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Funcionário cadastrado com sucesso!");
                    }
                    else
                    {
                        MessageBox.Show("Não foi possível cadastrar o funcionário.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o funcionário: " + ex.Message);
                }
            }
        }

        private void Cadastrar_Load(object sender, EventArgs e)
        {

        }
    }
}
