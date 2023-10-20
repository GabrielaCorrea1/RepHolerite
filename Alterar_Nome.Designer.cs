namespace RepHolerite
{
    partial class Alterar_Nome
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
            cbbx_nomefun = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            txt_novonome = new TextBox();
            btn_salvarnome = new Button();
            SuspendLayout();
            // 
            // cbbx_nomefun
            // 
            cbbx_nomefun.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbx_nomefun.FormattingEnabled = true;
            cbbx_nomefun.Location = new Point(172, 84);
            cbbx_nomefun.Name = "cbbx_nomefun";
            cbbx_nomefun.Size = new Size(422, 28);
            cbbx_nomefun.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(77, 87);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 10;
            label1.Text = "Funcionário:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(76, 177);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 12;
            label2.Text = "Novo nome:";
            // 
            // txt_novonome
            // 
            txt_novonome.Location = new Point(172, 174);
            txt_novonome.Name = "txt_novonome";
            txt_novonome.Size = new Size(422, 27);
            txt_novonome.TabIndex = 13;
            // 
            // btn_salvarnome
            // 
            btn_salvarnome.Location = new Point(447, 275);
            btn_salvarnome.Name = "btn_salvarnome";
            btn_salvarnome.Size = new Size(147, 37);
            btn_salvarnome.TabIndex = 14;
            btn_salvarnome.Text = "Salvar";
            btn_salvarnome.UseVisualStyleBackColor = true;
            btn_salvarnome.Click += btn_salvarnome_Click;
            // 
            // Alterar_Nome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(901, 511);
            Controls.Add(btn_salvarnome);
            Controls.Add(txt_novonome);
            Controls.Add(label2);
            Controls.Add(cbbx_nomefun);
            Controls.Add(label1);
            Name = "Alterar_Nome";
            Text = "Alterar Nome";
            Load += Alterar_Nome_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbbx_nomefun;
        private Label label1;
        private Label label2;
        private TextBox txt_novonome;
        private Button btn_salvarnome;
    }
}