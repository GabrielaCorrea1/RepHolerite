namespace RepHolerite
{
    partial class Ferias
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
            label2 = new Label();
            cbbx_funferias = new ComboBox();
            label1 = new Label();
            txt_horaextraferias = new TextBox();
            label6 = new Label();
            txt_mesferias = new TextBox();
            label4 = new Label();
            btn_salvarferias = new Button();
            txt_salferias = new TextBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(333, 179);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 9;
            label2.Text = "Salário:";
            // 
            // cbbx_funferias
            // 
            cbbx_funferias.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbx_funferias.FormattingEnabled = true;
            cbbx_funferias.Location = new Point(397, 110);
            cbbx_funferias.Name = "cbbx_funferias";
            cbbx_funferias.Size = new Size(399, 28);
            cbbx_funferias.TabIndex = 8;
            cbbx_funferias.SelectedIndexChanged += cbbx_funferias_SelectedIndexChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(302, 110);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 7;
            label1.Text = "Funcionário:";
            // 
            // txt_horaextraferias
            // 
            txt_horaextraferias.Location = new Point(397, 251);
            txt_horaextraferias.Name = "txt_horaextraferias";
            txt_horaextraferias.Size = new Size(227, 27);
            txt_horaextraferias.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(309, 258);
            label6.Name = "label6";
            label6.Size = new Size(82, 20);
            label6.TabIndex = 16;
            label6.Text = "Hora Extra:";
            // 
            // txt_mesferias
            // 
            txt_mesferias.Location = new Point(406, 323);
            txt_mesferias.Name = "txt_mesferias";
            txt_mesferias.Size = new Size(227, 27);
            txt_mesferias.TabIndex = 19;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(328, 330);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 18;
            label4.Text = "Mês/Ano:";
            label4.Click += label4_Click;
            // 
            // btn_salvarferias
            // 
            btn_salvarferias.Location = new Point(1044, 603);
            btn_salvarferias.Name = "btn_salvarferias";
            btn_salvarferias.Size = new Size(134, 43);
            btn_salvarferias.TabIndex = 20;
            btn_salvarferias.Text = "Gerar";
            btn_salvarferias.UseVisualStyleBackColor = true;
            btn_salvarferias.Click += btn_salvarferias_Click;
            // 
            // txt_salferias
            // 
            txt_salferias.Location = new Point(397, 179);
            txt_salferias.Name = "txt_salferias";
            txt_salferias.Size = new Size(227, 27);
            txt_salferias.TabIndex = 21;
            // 
            // Ferias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1190, 658);
            Controls.Add(txt_salferias);
            Controls.Add(btn_salvarferias);
            Controls.Add(txt_mesferias);
            Controls.Add(label4);
            Controls.Add(txt_horaextraferias);
            Controls.Add(label6);
            Controls.Add(label2);
            Controls.Add(cbbx_funferias);
            Controls.Add(label1);
            Name = "Ferias";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ferias";
            Load += Ferias_Load_1;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private ComboBox cbbx_funferias;
        private Label label1;
        private TextBox txt_horaextraferias;
        private Label label6;
        private TextBox txt_mesferias;
        private Label label4;
        private Button btn_salvarferias;
        private TextBox txt_salferias;
    }
}