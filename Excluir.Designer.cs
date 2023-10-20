namespace RepHolerite
{
    partial class Excluir
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
            cbbx_excluirfun = new ComboBox();
            btn_excluirfun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 171);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 7;
            label1.Text = "Funcionário:";
            // 
            // cbbx_excluirfun
            // 
            cbbx_excluirfun.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbx_excluirfun.FormattingEnabled = true;
            cbbx_excluirfun.Location = new Point(186, 168);
            cbbx_excluirfun.Name = "cbbx_excluirfun";
            cbbx_excluirfun.Size = new Size(422, 28);
            cbbx_excluirfun.TabIndex = 8;
            // 
            // btn_excluirfun
            // 
            btn_excluirfun.Location = new Point(461, 241);
            btn_excluirfun.Name = "btn_excluirfun";
            btn_excluirfun.Size = new Size(147, 37);
            btn_excluirfun.TabIndex = 9;
            btn_excluirfun.Text = "Excluir";
            btn_excluirfun.UseVisualStyleBackColor = true;
            btn_excluirfun.Click += btn_excluirfun_Click_1;
            // 
            // Excluir
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 555);
            Controls.Add(btn_excluirfun);
            Controls.Add(cbbx_excluirfun);
            Controls.Add(label1);
            Name = "Excluir";
            Text = "Excluir";
            Load += Excluir_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private ComboBox cbbx_excluirfun;
        private Button btn_excluirfun;
    }
}