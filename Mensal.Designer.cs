namespace RepHolerite
{
    partial class Mensal
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
            cbbx_funmensal = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            txt_salmensal = new TextBox();
            txt_adcmensal = new TextBox();
            label4 = new Label();
            label5 = new Label();
            txt_mesmensal = new TextBox();
            txt_diasmensal = new TextBox();
            btn_salvarmensal = new Button();
            label6 = new Label();
            txt_horaextramensal = new TextBox();
            label7 = new Label();
            txt_faltahoramensal = new TextBox();
            label8 = new Label();
            txt_faltadiamensal = new TextBox();
            label9 = new Label();
            txt_domingomensal = new TextBox();
            txt_diasuteis = new TextBox();
            label10 = new Label();
            txt_dsrmensal = new TextBox();
            label11 = new Label();
            txt_diastrabalhados = new TextBox();
            label12 = new Label();
            txt_horaextra100 = new TextBox();
            label13 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 68);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 1;
            label1.Text = "Funcionário:";
            // 
            // cbbx_funmensal
            // 
            cbbx_funmensal.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbx_funmensal.FormattingEnabled = true;
            cbbx_funmensal.Location = new Point(124, 68);
            cbbx_funmensal.Name = "cbbx_funmensal";
            cbbx_funmensal.Size = new Size(399, 28);
            cbbx_funmensal.TabIndex = 2;
            cbbx_funmensal.SelectedIndexChanged += cbbx_funmensal_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 152);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 3;
            label2.Text = "Salário:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 221);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "Adicional:";
            // 
            // txt_salmensal
            // 
            txt_salmensal.Location = new Point(124, 145);
            txt_salmensal.Name = "txt_salmensal";
            txt_salmensal.Size = new Size(227, 27);
            txt_salmensal.TabIndex = 6;
            // 
            // txt_adcmensal
            // 
            txt_adcmensal.Location = new Point(179, 218);
            txt_adcmensal.Name = "txt_adcmensal";
            txt_adcmensal.Size = new Size(87, 27);
            txt_adcmensal.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(616, 80);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 8;
            label4.Text = "Mês/Ano:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(595, 145);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 9;
            label5.Text = "Dias no Mês:";
            // 
            // txt_mesmensal
            // 
            txt_mesmensal.Location = new Point(694, 77);
            txt_mesmensal.Name = "txt_mesmensal";
            txt_mesmensal.Size = new Size(227, 27);
            txt_mesmensal.TabIndex = 10;
            // 
            // txt_diasmensal
            // 
            txt_diasmensal.Location = new Point(694, 145);
            txt_diasmensal.Name = "txt_diasmensal";
            txt_diasmensal.Size = new Size(87, 27);
            txt_diasmensal.TabIndex = 11;
            // 
            // btn_salvarmensal
            // 
            btn_salvarmensal.Location = new Point(1149, 655);
            btn_salvarmensal.Name = "btn_salvarmensal";
            btn_salvarmensal.Size = new Size(134, 43);
            btn_salvarmensal.TabIndex = 12;
            btn_salvarmensal.Text = "Gerar";
            btn_salvarmensal.UseVisualStyleBackColor = true;
            btn_salvarmensal.Click += btn_salvarmensal_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 303);
            label6.Name = "label6";
            label6.Size = new Size(114, 20);
            label6.TabIndex = 14;
            label6.Text = "Hora Extra 50%:";
            // 
            // txt_horaextramensal
            // 
            txt_horaextramensal.Location = new Point(179, 296);
            txt_horaextramensal.Name = "txt_horaextramensal";
            txt_horaextramensal.Size = new Size(87, 27);
            txt_horaextramensal.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(71, 420);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 16;
            label7.Text = "Falta em hora:";
            // 
            // txt_faltahoramensal
            // 
            txt_faltahoramensal.Location = new Point(179, 420);
            txt_faltahoramensal.Name = "txt_faltahoramensal";
            txt_faltahoramensal.Size = new Size(87, 27);
            txt_faltahoramensal.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(80, 484);
            label8.Name = "label8";
            label8.Size = new Size(93, 20);
            label8.TabIndex = 18;
            label8.Text = "Falta em dia:";
            // 
            // txt_faltadiamensal
            // 
            txt_faltadiamensal.Location = new Point(179, 481);
            txt_faltadiamensal.Name = "txt_faltadiamensal";
            txt_faltadiamensal.Size = new Size(87, 27);
            txt_faltadiamensal.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(514, 277);
            label9.Name = "label9";
            label9.Size = new Size(139, 20);
            label9.TabIndex = 20;
            label9.Text = "Domingo e feriado:";
            // 
            // txt_domingomensal
            // 
            txt_domingomensal.Location = new Point(659, 270);
            txt_domingomensal.Name = "txt_domingomensal";
            txt_domingomensal.Size = new Size(87, 27);
            txt_domingomensal.TabIndex = 21;
            // 
            // txt_diasuteis
            // 
            txt_diasuteis.Location = new Point(850, 270);
            txt_diasuteis.Name = "txt_diasuteis";
            txt_diasuteis.Size = new Size(87, 27);
            txt_diasuteis.TabIndex = 23;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(764, 277);
            label10.Name = "label10";
            label10.Size = new Size(80, 20);
            label10.TabIndex = 22;
            label10.Text = "Dias uteis: ";
            // 
            // txt_dsrmensal
            // 
            txt_dsrmensal.Location = new Point(179, 536);
            txt_dsrmensal.Name = "txt_dsrmensal";
            txt_dsrmensal.Size = new Size(87, 27);
            txt_dsrmensal.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(127, 543);
            label11.Name = "label11";
            label11.Size = new Size(46, 20);
            label11.TabIndex = 24;
            label11.Text = "D.S.R:";
            // 
            // txt_diastrabalhados
            // 
            txt_diastrabalhados.Location = new Point(179, 594);
            txt_diastrabalhados.Name = "txt_diastrabalhados";
            txt_diastrabalhados.Size = new Size(87, 27);
            txt_diastrabalhados.TabIndex = 27;
            txt_diastrabalhados.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(47, 601);
            label12.Name = "label12";
            label12.Size = new Size(126, 20);
            label12.TabIndex = 26;
            label12.Text = "Dias Trabalhados:";
            // 
            // txt_horaextra100
            // 
            txt_horaextra100.Location = new Point(179, 362);
            txt_horaextra100.Name = "txt_horaextra100";
            txt_horaextra100.Size = new Size(87, 27);
            txt_horaextra100.TabIndex = 29;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(47, 369);
            label13.Name = "label13";
            label13.Size = new Size(122, 20);
            label13.TabIndex = 28;
            label13.Text = "Hora Extra 100%:";
            // 
            // Mensal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1295, 710);
            Controls.Add(txt_horaextra100);
            Controls.Add(label13);
            Controls.Add(txt_diastrabalhados);
            Controls.Add(label12);
            Controls.Add(txt_dsrmensal);
            Controls.Add(label11);
            Controls.Add(txt_diasuteis);
            Controls.Add(label10);
            Controls.Add(txt_domingomensal);
            Controls.Add(label9);
            Controls.Add(txt_faltadiamensal);
            Controls.Add(label8);
            Controls.Add(txt_faltahoramensal);
            Controls.Add(label7);
            Controls.Add(txt_horaextramensal);
            Controls.Add(label6);
            Controls.Add(btn_salvarmensal);
            Controls.Add(txt_diasmensal);
            Controls.Add(txt_mesmensal);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txt_adcmensal);
            Controls.Add(txt_salmensal);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(cbbx_funmensal);
            Controls.Add(label1);
            Name = "Mensal";
            Text = "Mensal";
            Load += Mensal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private ComboBox cbbx_funmensal;
        private Label label2;
        private Label label3;
        private TextBox txt_salmensal;
        private TextBox txt_adcmensal;
        private Label label4;
        private Label label5;
        private TextBox txt_mesmensal;
        private TextBox txt_diasmensal;
        private Button btn_salvarmensal;
        private Label label6;
        private TextBox txt_horaextramensal;
        private Label label7;
        private TextBox txt_faltahoramensal;
        private Label label8;
        private TextBox txt_faltadiamensal;
        private Label label9;
        private TextBox txt_domingomensal;
        private TextBox txt_diasuteis;
        private Label label10;
        private TextBox txt_dsrmensal;
        private Label label11;
        private TextBox txt_diastrabalhados;
        private Label label12;
        private TextBox txt_horaextra100;
        private Label label13;
    }
}