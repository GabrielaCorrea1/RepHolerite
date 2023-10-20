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
    public partial class Excluir : Form
    {
        private string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";

        public Excluir()
        {
            InitializeComponent();

            // Popula o combobox com os nomes dos funcionários
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
                    cbbx_excluirfun.DataSource = table;
                    cbbx_excluirfun.DisplayMember = "nome";
                    cbbx_excluirfun.ValueMember = "codigo_funcionario"; // Define a coluna "codigo_funcionario" como valor para cada item do combobox

                    // Define SelectedIndex para -1 para que nenhum item seja selecionado inicialmente
                    cbbx_excluirfun.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao carregar os dados: " + ex.Message);
                }
            }
        }

        private void btn_excluirfun_Click(object sender, EventArgs e)
        {
            btn_excluirfun_Click_1(sender, e);
        }

        private int GetFuncionarioId(string nomeFuncionario)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT codigo_funcionario FROM funcionario WHERE nome = @nome";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nome", nomeFuncionario);
                    object result = command.ExecuteScalar();

                    if (result != null && result != DBNull.Value)
                    {
                        int funcionarioId = Convert.ToInt32(result);
                        return funcionarioId;
                    }
                    else
                    {
                        MessageBox.Show("Funcionário não encontrado.");
                        return -1;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao obter o ID do funcionário: " + ex.Message);
                    return -1;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void DeleteFromHora(int funcionarioId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM hora WHERE codigo_funcionario = @funcionarioId";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@funcionarioId", funcionarioId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir os dados da tabela hora: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DeleteFromFuncionario(int funcionarioId)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM funcionario WHERE codigo_funcionario = @funcionarioId";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@funcionarioId", funcionarioId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao excluir os dados da tabela funcionario: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void btn_excluirfun_Click_1(object sender, EventArgs e)
        {
            if (cbbx_excluirfun.SelectedIndex != -1 && Convert.ToInt32(cbbx_excluirfun.SelectedValue) != -1)
            {
                int funcionarioId = Convert.ToInt32(cbbx_excluirfun.SelectedValue);

                // Obtém o nome do funcionário selecionado
                string nomeFuncionario = cbbx_excluirfun.Text;

                DialogResult result = MessageBox.Show("Tem certeza que deseja excluir o funcionário selecionado?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteFromHora(funcionarioId);
                    DeleteFromFuncionario(funcionarioId);
                    MessageBox.Show("Funcionário excluído com sucesso.");
                    PopulateComboBox();
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para excluir.");
            }
        }

        private void Excluir_Load(object sender, EventArgs e)
        {

        }
    }
}
