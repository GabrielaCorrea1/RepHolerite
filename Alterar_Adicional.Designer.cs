namespace RepHolerite
{
    partial class Alterar_Adicional
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
            btn_salvaradicional = new Button();
            txt_novoadicional = new TextBox();
            label2 = new Label();
            cbbx_nomefun = new ComboBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_salvaradicional
            // 
            btn_salvaradicional.Location = new Point(437, 223);
            btn_salvaradicional.Name = "btn_salvaradicional";
            btn_salvaradicional.Size = new Size(147, 37);
            btn_salvaradicional.TabIndex = 20;
            btn_salvaradicional.Text = "Salvar";
            btn_salvaradicional.UseVisualStyleBackColor = true;
            btn_salvaradicional.Click += btn_salvaradicional_Click;
            // 
            // txt_novoadicional
            // 
            txt_novoadicional.Location = new Point(162, 169);
            txt_novoadicional.Name = "txt_novoadicional";
            txt_novoadicional.Size = new Size(138, 27);
            txt_novoadicional.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 172);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 18;
            label2.Text = "Novo adicional:";
            // 
            // cbbx_nomefun
            // 
            cbbx_nomefun.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbx_nomefun.FormattingEnabled = true;
            cbbx_nomefun.Location = new Point(162, 79);
            cbbx_nomefun.Name = "cbbx_nomefun";
            cbbx_nomefun.Size = new Size(422, 28);
            cbbx_nomefun.TabIndex = 17;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 82);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 16;
            label1.Text = "Funcionário:";
            // 
            // Alterar_Adicional
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 500);
            Controls.Add(btn_salvaradicional);
            Controls.Add(txt_novoadicional);
            Controls.Add(label2);
            Controls.Add(cbbx_nomefun);
            Controls.Add(label1);
            Name = "Alterar_Adicional";
            Text = "Alterar Adicional";
            Load += Alterar_Adicional_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_salvaradicional;
        private TextBox txt_novoadicional;
        private Label label2;
        private ComboBox cbbx_nomefun;
        private Label label1;
    }
}