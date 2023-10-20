namespace RepHolerite
{
    partial class _13
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
            txt_horaextra13 = new TextBox();
            label6 = new Label();
            btn_salvar13 = new Button();
            txt_dias13 = new TextBox();
            txt_mes13 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            txt_sal13 = new TextBox();
            label2 = new Label();
            cbbx_fun13 = new ComboBox();
            label1 = new Label();
            label3 = new Label();
            txt_mesestrabalhados13 = new TextBox();
            btn_limpar13 = new Button();
            SuspendLayout();
            // 
            // txt_horaextra13
            // 
            txt_horaextra13.Location = new Point(145, 212);
            txt_horaextra13.Name = "txt_horaextra13";
            txt_horaextra13.Size = new Size(227, 27);
            txt_horaextra13.TabIndex = 36;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 219);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 35;
            label6.Text = "Hora Extra:";
            // 
            // btn_salvar13
            // 
            btn_salvar13.Location = new Point(1185, 449);
            btn_salvar13.Name = "btn_salvar13";
            btn_salvar13.Size = new Size(134, 43);
            btn_salvar13.TabIndex = 33;
            btn_salvar13.Text = "Gerar";
            btn_salvar13.UseVisualStyleBackColor = true;
            btn_salvar13.Click += btn_salvar13_Click;
            // 
            // txt_dias13
            // 
            txt_dias13.Location = new Point(715, 143);
            txt_dias13.Name = "txt_dias13";
            txt_dias13.Size = new Size(81, 27);
            txt_dias13.TabIndex = 32;
            // 
            // txt_mes13
            // 
            txt_mes13.Location = new Point(715, 70);
            txt_mes13.Name = "txt_mes13";
            txt_mes13.Size = new Size(227, 27);
            txt_mes13.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(616, 146);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 30;
            label5.Text = "Dias no Mês:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(637, 77);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 29;
            label4.Text = "Mês/Ano:";
            // 
            // txt_sal13
            // 
            txt_sal13.Location = new Point(145, 139);
            txt_sal13.Name = "txt_sal13";
            txt_sal13.Size = new Size(227, 27);
            txt_sal13.TabIndex = 27;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 146);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 25;
            label2.Text = "Salário:";
            // 
            // cbbx_fun13
            // 
            cbbx_fun13.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbx_fun13.FormattingEnabled = true;
            cbbx_fun13.Location = new Point(145, 59);
            cbbx_fun13.Name = "cbbx_fun13";
            cbbx_fun13.Size = new Size(399, 28);
            cbbx_fun13.TabIndex = 24;
            cbbx_fun13.SelectedIndexChanged += cbbx_fun13_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 62);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 23;
            label1.Text = "Funcionário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 292);
            label3.Name = "label3";
            label3.Size = new Size(136, 20);
            label3.TabIndex = 37;
            label3.Text = "Meses trabalhados:";
            // 
            // txt_mesestrabalhados13
            // 
            txt_mesestrabalhados13.Location = new Point(145, 289);
            txt_mesestrabalhados13.Name = "txt_mesestrabalhados13";
            txt_mesestrabalhados13.Size = new Size(81, 27);
            txt_mesestrabalhados13.TabIndex = 38;
            // 
            // btn_limpar13
            // 
            btn_limpar13.Location = new Point(12, 449);
            btn_limpar13.Name = "btn_limpar13";
            btn_limpar13.Size = new Size(134, 43);
            btn_limpar13.TabIndex = 39;
            btn_limpar13.Text = "Limpar";
            btn_limpar13.UseVisualStyleBackColor = true;
            btn_limpar13.Click += btn_limpar13_Click;
            // 
            // _13
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 504);
            Controls.Add(btn_limpar13);
            Controls.Add(txt_mesestrabalhados13);
            Controls.Add(label3);
            Controls.Add(txt_horaextra13);
            Controls.Add(label6);
            Controls.Add(btn_salvar13);
            Controls.Add(txt_dias13);
            Controls.Add(txt_mes13);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_sal13);
            Controls.Add(label2);
            Controls.Add(cbbx_fun13);
            Controls.Add(label1);
            Name = "_13";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "13";
            Load += _13_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_horaextra13;
        private Label label6;
        private Button btn_salvar13;
        private TextBox txt_dias13;
        private TextBox txt_mes13;
        private Label label5;
        private Label label4;
        private TextBox txt_sal13;
        private Label label2;
        private ComboBox cbbx_fun13;
        private Label label1;
        private Label label3;
        private TextBox txt_mesestrabalhados13;
        private Button btn_limpar13;
    }
}