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
    public partial class Consultar_Hora : Form
    {
        public Consultar_Hora()
        {
            InitializeComponent();
        }

        private void Consultar_Hora_Load(object sender, EventArgs e)
        {
            // Conectar-se à base de dados
            string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                // Abrir conexão
                connection.Open();

                // Query para obter os nomes dos funcionários
                string query = "SELECT nome FROM funcionario";
                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Executar query e ler resultados
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Preencher combobox com nomes dos funcionários
                        while (reader.Read())
                        {
                            cbbx_funconsultahora.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
        }

        private void btn_consulhora_Click(object sender, EventArgs e)
        {
            // Limpar o datagridview antes de carregar novos dados
            dataGrid_consultahora.Rows.Clear();
            dataGrid_consultahora.Columns.Clear();

            // Conectar-se à base de dados
            string connectionString = "Server=localhost;Port=****;Database=nomeDB;User Id=nomeID;Password=****";
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                // Abrir conexão
                connection.Open();

                // Query para obter os dados do funcionário selecionado
                string query = "SELECT nome, hora_total, referencia FROM hora WHERE nome = @nome";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    // Passar o parâmetro nome para a consulta
                    command.Parameters.AddWithValue("@nome", cbbx_funconsultahora.SelectedItem.ToString());

                    // Executar query e ler resultados
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Adicionar as colunas do datagridview
                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            dataGrid_consultahora.Columns.Add(reader.GetName(i), reader.GetName(i));
                        }

                        // Adicionar as linhas do datagridview
                        while (reader.Read())
                        {
                            object[] row = new object[reader.FieldCount];
                            reader.GetValues(row);
                            dataGrid_consultahora.Rows.Add(row);
                        }
                    }
                }
            }
        }
    }
}
