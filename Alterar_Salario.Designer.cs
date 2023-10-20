namespace RepHolerite
{
    partial class Alterar_Salario
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
            btn_salvarsalario = new Button();
            txt_novosalario = new TextBox();
            label2 = new Label();
            cbbx_nomefun = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_salvarsalario
            // 
            btn_salvarsalario.Location = new Point(433, 265);
            btn_salvarsalario.Name = "btn_salvarsalario";
            btn_salvarsalario.Size = new Size(147, 37);
            btn_salvarsalario.TabIndex = 20;
            btn_salvarsalario.Text = "Salvar";
            btn_salvarsalario.UseVisualStyleBackColor = true;
            btn_salvarsalario.Click += btn_salvarsalario_Click;
            // 
            // txt_novosalario
            // 
            txt_novosalario.Location = new Point(158, 216);
            txt_novosalario.Name = "txt_novosalario";
            txt_novosalario.Size = new Size(173, 27);
            txt_novosalario.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(62, 216);
            label2.Name = "label2";
            label2.Size = new Size(96, 20);
            label2.TabIndex = 18;
            label2.Text = "Novo salário:";
            // 
            // cbbx_nomefun
            // 
            cbbx_nomefun.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbx_nomefun.FormattingEnabled = true;
            cbbx_nomefun.Location = new Point(158, 123);
            cbbx_nomefun.Name = "cbbx_nomefun";
            cbbx_nomefun.Size = new Size(422, 28);
            cbbx_nomefun.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 126);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 16;
            label1.Text = "Funcionário:";
            // 
            // Alterar_Salario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 504);
            Controls.Add(btn_salvarsalario);
            Controls.Add(txt_novosalario);
            Controls.Add(label2);
            Controls.Add(cbbx_nomefun);
            Controls.Add(label1);
            Name = "Alterar_Salario";
            Text = "Alterar Salario";
            Load += Alterar_Salario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvarsalario;
        private TextBox txt_novosalario;
        private Label label2;
        private ComboBox cbbx_nomefun;
        private Label label1;
    }
}