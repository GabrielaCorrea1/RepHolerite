namespace RepHolerite
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btn_mensal_Click(object sender, EventArgs e)
        {
            Mensal mensal = new Mensal();
            mensal.ShowDialog();
        }

        private void btn_ferias_Click(object sender, EventArgs e)
        {
            Ferias ferias = new Ferias();
            ferias.ShowDialog();
        }

        private void btn_13_Click(object sender, EventArgs e)
        {
            _13 decimo = new _13();
            decimo.ShowDialog();
        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.ShowDialog();
        }

        private void horaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultar_Hora consultar_Hora = new Consultar_Hora();
            consultar_Hora.ShowDialog();
        }

        private void cadastrarFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Cadastrar cadastrar = new Cadastrar();
            cadastrar.ShowDialog();
        }

        private void excluirFuncionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Excluir excluir = new Excluir();
            excluir.ShowDialog();
        }

        private void nomeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar_Nome alterar_Nome = new Alterar_Nome();
            alterar_Nome.ShowDialog();
        }

        private void salárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar_Salario alterar_ = new Alterar_Salario();
            alterar_.ShowDialog();
        }

        private void adicionalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alterar_Adicional alterar_Adicional = new Alterar_Adicional();
            alterar_Adicional.ShowDialog();
        }

        private void disidioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dissidio dissidio = new Dissidio();
            dissidio.ShowDialog();
        }
    }
}