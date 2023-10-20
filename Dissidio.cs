using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RepHolerite
{
    public partial class Dissidio : Form
    {
        private string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";

        public Dissidio()
        {
            InitializeComponent();
        }

        private void Dissidio_Load(object sender, EventArgs e)
        {

        }

        private void btn_confirmar_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txt_dissidio.Text, out decimal dissidio))
            {
                DialogResult result = MessageBox.Show("Tem certeza que deseja atualizar os salários de todos os funcionários?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UpdateSalariosFuncionarios(dissidio);
                    MessageBox.Show("Salários atualizados com sucesso.");
                }
            }
            else
            {
                MessageBox.Show("Digite um valor válido para o dissídio.");
            }
        }
        private void UpdateSalariosFuncionarios(decimal dissidio)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE funcionario SET salario = salario * @dissidio";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@dissidio", 1 + (dissidio / 100)); // Convertendo a porcentagem para fator multiplicativo
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar os salários dos funcionários: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
