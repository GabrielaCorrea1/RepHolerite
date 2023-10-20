namespace RepHolerite
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            btn_mensal = new Button();
            btn_ferias = new Button();
            btn_13 = new Button();
            menuStrip1 = new MenuStrip();
            consultaToolStripMenuItem = new ToolStripMenuItem();
            funcionárioToolStripMenuItem = new ToolStripMenuItem();
            horaToolStripMenuItem = new ToolStripMenuItem();
            cadastrarToolStripMenuItem = new ToolStripMenuItem();
            cadastrarFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            excluirFuncionárioToolStripMenuItem = new ToolStripMenuItem();
            alterarToolStripMenuItem = new ToolStripMenuItem();
            nomeToolStripMenuItem = new ToolStripMenuItem();
            salárioToolStripMenuItem = new ToolStripMenuItem();
            adicionalToolStripMenuItem = new ToolStripMenuItem();
            atualizarToolStripMenuItem = new ToolStripMenuItem();
            disidioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btn_mensal
            // 
            btn_mensal.Location = new Point(329, 338);
            btn_mensal.Name = "btn_mensal";
            btn_mensal.Size = new Size(146, 49);
            btn_mensal.TabIndex = 0;
            btn_mensal.Text = "Mensal";
            btn_mensal.UseVisualStyleBackColor = true;
            btn_mensal.Click += btn_mensal_Click;
            // 
            // btn_ferias
            // 
            btn_ferias.Location = new Point(560, 338);
            btn_ferias.Name = "btn_ferias";
            btn_ferias.Size = new Size(146, 49);
            btn_ferias.TabIndex = 1;
            btn_ferias.Text = "Férias";
            btn_ferias.UseVisualStyleBackColor = true;
            btn_ferias.Click += btn_ferias_Click;
            // 
            // btn_13
            // 
            btn_13.Location = new Point(786, 338);
            btn_13.Name = "btn_13";
            btn_13.Size = new Size(146, 49);
            btn_13.TabIndex = 2;
            btn_13.Text = "13°";
            btn_13.UseVisualStyleBackColor = true;
            btn_13.Click += btn_13_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { consultaToolStripMenuItem, cadastrarToolStripMenuItem, excluirToolStripMenuItem, alterarToolStripMenuItem, atualizarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1308, 28);
            menuStrip1.TabIndex = 8;
            menuStrip1.Text = "menuStrip1";
            // 
            // consultaToolStripMenuItem
            // 
            consultaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { funcionárioToolStripMenuItem, horaToolStripMenuItem });
            consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            consultaToolStripMenuItem.Size = new Size(80, 24);
            consultaToolStripMenuItem.Text = "Consulta";
            // 
            // funcionárioToolStripMenuItem
            // 
            funcionárioToolStripMenuItem.Image = (Image)resources.GetObject("funcionárioToolStripMenuItem.Image");
            funcionárioToolStripMenuItem.Name = "funcionárioToolStripMenuItem";
            funcionárioToolStripMenuItem.Size = new Size(169, 26);
            funcionárioToolStripMenuItem.Text = "Funcionário";
            funcionárioToolStripMenuItem.Click += funcionárioToolStripMenuItem_Click;
            // 
            // horaToolStripMenuItem
            // 
            horaToolStripMenuItem.Image = (Image)resources.GetObject("horaToolStripMenuItem.Image");
            horaToolStripMenuItem.Name = "horaToolStripMenuItem";
            horaToolStripMenuItem.Size = new Size(169, 26);
            horaToolStripMenuItem.Text = "Hora";
            horaToolStripMenuItem.Click += horaToolStripMenuItem_Click;
            // 
            // cadastrarToolStripMenuItem
            // 
            cadastrarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { cadastrarFuncionárioToolStripMenuItem });
            cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            cadastrarToolStripMenuItem.Size = new Size(86, 24);
            cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // cadastrarFuncionárioToolStripMenuItem
            // 
            cadastrarFuncionárioToolStripMenuItem.Image = (Image)resources.GetObject("cadastrarFuncionárioToolStripMenuItem.Image");
            cadastrarFuncionárioToolStripMenuItem.Name = "cadastrarFuncionárioToolStripMenuItem";
            cadastrarFuncionárioToolStripMenuItem.Size = new Size(236, 26);
            cadastrarFuncionárioToolStripMenuItem.Text = "Cadastrar Funcionário";
            cadastrarFuncionárioToolStripMenuItem.Click += cadastrarFuncionárioToolStripMenuItem_Click;
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { excluirFuncionárioToolStripMenuItem });
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(66, 24);
            excluirToolStripMenuItem.Text = "Excluir";
            // 
            // excluirFuncionárioToolStripMenuItem
            // 
            excluirFuncionárioToolStripMenuItem.Image = (Image)resources.GetObject("excluirFuncionárioToolStripMenuItem.Image");
            excluirFuncionárioToolStripMenuItem.Name = "excluirFuncionárioToolStripMenuItem";
            excluirFuncionárioToolStripMenuItem.Size = new Size(216, 26);
            excluirFuncionárioToolStripMenuItem.Text = "Excluir Funcionário";
            excluirFuncionárioToolStripMenuItem.Click += excluirFuncionárioToolStripMenuItem_Click;
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nomeToolStripMenuItem, salárioToolStripMenuItem, adicionalToolStripMenuItem });
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(68, 24);
            alterarToolStripMenuItem.Text = "Alterar";
            // 
            // nomeToolStripMenuItem
            // 
            nomeToolStripMenuItem.Image = (Image)resources.GetObject("nomeToolStripMenuItem.Image");
            nomeToolStripMenuItem.Name = "nomeToolStripMenuItem";
            nomeToolStripMenuItem.Size = new Size(155, 26);
            nomeToolStripMenuItem.Text = "Nome";
            nomeToolStripMenuItem.Click += nomeToolStripMenuItem_Click;
            // 
            // salárioToolStripMenuItem
            // 
            salárioToolStripMenuItem.Image = (Image)resources.GetObject("salárioToolStripMenuItem.Image");
            salárioToolStripMenuItem.Name = "salárioToolStripMenuItem";
            salárioToolStripMenuItem.Size = new Size(155, 26);
            salárioToolStripMenuItem.Text = "Salário";
            salárioToolStripMenuItem.Click += salárioToolStripMenuItem_Click;
            // 
            // adicionalToolStripMenuItem
            // 
            adicionalToolStripMenuItem.Image = (Image)resources.GetObject("adicionalToolStripMenuItem.Image");
            adicionalToolStripMenuItem.Name = "adicionalToolStripMenuItem";
            adicionalToolStripMenuItem.Size = new Size(155, 26);
            adicionalToolStripMenuItem.Text = "Adicional";
            adicionalToolStripMenuItem.Click += adicionalToolStripMenuItem_Click;
            // 
            // atualizarToolStripMenuItem
            // 
            atualizarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { disidioToolStripMenuItem });
            atualizarToolStripMenuItem.Name = "atualizarToolStripMenuItem";
            atualizarToolStripMenuItem.Size = new Size(82, 24);
            atualizarToolStripMenuItem.Text = "Atualizar";
            // 
            // disidioToolStripMenuItem
            // 
            disidioToolStripMenuItem.Image = (Image)resources.GetObject("disidioToolStripMenuItem.Image");
            disidioToolStripMenuItem.Name = "disidioToolStripMenuItem";
            disidioToolStripMenuItem.Size = new Size(145, 26);
            disidioToolStripMenuItem.Text = "Dissídio";
            disidioToolStripMenuItem.Click += disidioToolStripMenuItem_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1308, 584);
            Controls.Add(btn_13);
            Controls.Add(btn_ferias);
            Controls.Add(btn_mensal);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_mensal;
        private Button btn_ferias;
        private Button btn_13;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem consultaToolStripMenuItem;
        private ToolStripMenuItem funcionárioToolStripMenuItem;
        private ToolStripMenuItem horaToolStripMenuItem;
        private ToolStripMenuItem cadastrarToolStripMenuItem;
        private ToolStripMenuItem cadastrarFuncionárioToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem excluirFuncionárioToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem nomeToolStripMenuItem;
        private ToolStripMenuItem salárioToolStripMenuItem;
        private ToolStripMenuItem adicionalToolStripMenuItem;
        private ToolStripMenuItem atualizarToolStripMenuItem;
        private ToolStripMenuItem disidioToolStripMenuItem;
    }
}