namespace RepHolerite
{
    partial class Cadastrar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_funcadastrar = new TextBox();
            label2 = new Label();
            txt_salcadastrar = new TextBox();
            label3 = new Label();
            txt_adccadastrar = new TextBox();
            btn_salvarcadastrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 51);
            label1.Name = "label1";
            label1.Size = new Size(53, 20);
            label1.TabIndex = 0;
            label1.Text = "Nome:";
            // 
            // txt_funcadastrar
            // 
            txt_funcadastrar.Location = new Point(133, 44);
            txt_funcadastrar.Name = "txt_funcadastrar";
            txt_funcadastrar.Size = new Size(351, 27);
            txt_funcadastrar.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(59, 115);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 2;
            label2.Text = "Salário:";
            // 
            // txt_salcadastrar
            // 
            txt_salcadastrar.Location = new Point(133, 108);
            txt_salcadastrar.Name = "txt_salcadastrar";
            txt_salcadastrar.Size = new Size(210, 27);
            txt_salcadastrar.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 184);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 4;
            label3.Text = "Adicional:";
            // 
            // txt_adccadastrar
            // 
            txt_adccadastrar.Location = new Point(133, 181);
            txt_adccadastrar.Name = "txt_adccadastrar";
            txt_adccadastrar.Size = new Size(210, 27);
            txt_adccadastrar.TabIndex = 5;
            // 
            // btn_salvarcadastrar
            // 
            btn_salvarcadastrar.Location = new Point(882, 548);
            btn_salvarcadastrar.Name = "btn_salvarcadastrar";
            btn_salvarcadastrar.Size = new Size(134, 43);
            btn_salvarcadastrar.TabIndex = 36;
            btn_salvarcadastrar.Text = "Salvar";
            btn_salvarcadastrar.UseVisualStyleBackColor = true;
            btn_salvarcadastrar.Click += btn_salvarcadastrar_Click;
            // 
            // Cadastrar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1028, 603);
            Controls.Add(btn_salvarcadastrar);
            Controls.Add(txt_adccadastrar);
            Controls.Add(label3);
            Controls.Add(txt_salcadastrar);
            Controls.Add(label2);
            Controls.Add(txt_funcadastrar);
            Controls.Add(label1);
            Name = "Cadastrar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar";
            Load += Cadastrar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_funcadastrar;
        private Label label2;
        private TextBox txt_salcadastrar;
        private Label label3;
        private TextBox txt_adccadastrar;
        private Button btn_salvarcadastrar;
    }
}