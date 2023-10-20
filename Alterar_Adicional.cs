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
    public partial class Alterar_Adicional : Form
    {
        private string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";

        private void cbbx_nomefun_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbx_nomefun.SelectedIndex != -1 && Convert.ToInt32(cbbx_nomefun.SelectedValue) != -1)
            {
                int funcionarioId = Convert.ToInt32(cbbx_nomefun.SelectedValue);

                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "SELECT adicional FROM funcionario WHERE codigo_funcionario = @funcionarioId";
                        NpgsqlCommand command = new NpgsqlCommand(query, connection);
                        command.Parameters.AddWithValue("@funcionarioId", funcionarioId);
                        object result = command.ExecuteScalar();

                        if (result != null && result != DBNull.Value)
                        {
                            decimal salario = Convert.ToDecimal(result);
                            txt_novoadicional.Text = salario.ToString();
                        }
                        else
                        {
                            txt_novoadicional.Text = string.Empty;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao obter o adicional do funcionário: " + ex.Message);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
        public Alterar_Adicional()
        {
            InitializeComponent();
            PopulateComboBox();


            // Associa o manipulador de evento ao evento SelectedIndexChanged da combobox
            cbbx_nomefun.SelectedIndexChanged += cbbx_nomefun_SelectedIndexChanged;
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

        private void Alterar_Adicional_Load(object sender, EventArgs e)
        {

        }

        private void btn_salvaradicional_Click(object sender, EventArgs e)
        {
            if (cbbx_nomefun.SelectedIndex != -1 && Convert.ToInt32(cbbx_nomefun.SelectedValue) != -1)
            {
                int funcionarioId = Convert.ToInt32(cbbx_nomefun.SelectedValue);
                string novoAdicionalStr = txt_novoadicional.Text;

                if (decimal.TryParse(novoAdicionalStr, out decimal novoSalario))
                {
                    DialogResult result = MessageBox.Show("Tem certeza que deseja alterar o adicional do funcionário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        UpdateAdicionalFuncionario(funcionarioId, novoSalario);
                        MessageBox.Show("Adicional do funcionário atualizado com sucesso.");
                        PopulateComboBox();
                    }
                }
                else
                {
                    MessageBox.Show("Digite um valor válido para o novo salário.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um funcionário para alterar o salário.");
            }
        }

        private void UpdateAdicionalFuncionario(int funcionarioId, decimal novoSalario)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE funcionario SET adicional = @novoSalario WHERE codigo_funcionario = @funcionarioId";
                    NpgsqlCommand command = new NpgsqlCommand(query, connection);
                    command.Parameters.AddWithValue("@novoSalario", novoSalario);
                    command.Parameters.AddWithValue("@funcionarioId", funcionarioId);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao atualizar o adiconal do funcionário: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
