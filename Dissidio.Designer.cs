namespace RepHolerite
{
    partial class Dissidio
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
            txt_dissidio = new TextBox();
            btn_confirmar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(242, 182);
            label1.Name = "label1";
            label1.Size = new Size(108, 20);
            label1.TabIndex = 17;
            label1.Text = "% de aumento:";
            // 
            // txt_dissidio
            // 
            txt_dissidio.Location = new Point(356, 175);
            txt_dissidio.Name = "txt_dissidio";
            txt_dissidio.Size = new Size(143, 27);
            txt_dissidio.TabIndex = 18;
            // 
            // btn_confirmar
            // 
            btn_confirmar.Location = new Point(426, 233);
            btn_confirmar.Name = "btn_confirmar";
            btn_confirmar.Size = new Size(126, 45);
            btn_confirmar.TabIndex = 19;
            btn_confirmar.Text = "Confirmar";
            btn_confirmar.UseVisualStyleBackColor = true;
            btn_confirmar.Click += btn_confirmar_Click;
            // 
            // Dissidio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 504);
            Controls.Add(btn_confirmar);
            Controls.Add(txt_dissidio);
            Controls.Add(label1);
            Name = "Dissidio";
            Text = "Dissidio";
            Load += Dissidio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txt_dissidio;
        private Button btn_confirmar;
    }
}