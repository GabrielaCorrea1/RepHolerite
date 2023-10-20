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
    public partial class Alterar_Nome : Form
    {

        private string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";
        public Alterar_Nome()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        private void PopulateComboBox()
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT codigo_funcionario, nome FROM funcionario";
                    NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(query, connection);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    cbbx_nomefun.DataSource = table;
                    cbbx_nomefun.DisplayMember = "nome";
                    cbbx_nomefun.ValueMember = "codigo_funcionario"; // Define a coluna "codigo_funcionario" como valor para cada item do combobox

                    // Define SelectedIndex para -1 para que nenhum item seja selecionado inicialmente
                    cbbx_nomefun.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }
        private void Alterar_Nome_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvarnome_Click(object sender, EventArgs e)
        {
            if (cbbx_nomefun.SelectedIndex != -1 && Convert.ToInt32(cbbx_nomefun.SelectedValue) != -1)
            {
                int funcionarioId = Convert.ToInt32(cbbx_nomefun.SelectedValue);
                string novoNome = txt_novonome.Text;

                DialogResult result = MessageBox.Show("Tem certeza que deseja alterar o nome do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    UpdateNomeFuncionario(funcionarioId, novoNome);
                    MessageBox.Show("Nome do funcionário atualizado com sucesso.");
                    PopulateComboBox();
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para alterar o nome.");
            }
        }
        private void UpdateNomeFuncionario(int funcionarioId, string novoNome)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE funcionario SET nome = @novoNome WHERE codigo_funcionario = @funcionarioId";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@novoNome", novoNome);
                    command.Parameters.AddWithValue("@funcionarioId", funcionarioId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o nome do funcionário: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
