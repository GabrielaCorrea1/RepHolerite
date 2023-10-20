namespace RepHolerite
{
    partial class Consultar_Hora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consultar_Hora));
            dataGrid_consultahora = new DataGridView();
            btn_consulhora = new Button();
            cbbx_funconsultahora = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGrid_consultahora).BeginInit();
            SuspendLayout();
            // 
            // dataGrid_consultahora
            // 
            dataGrid_consultahora.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_consultahora.Location = new Point(233, 230);
            dataGrid_consultahora.Name = "dataGrid_consultahora";
            dataGrid_consultahora.RowHeadersWidth = 51;
            dataGrid_consultahora.RowTemplate.Height = 29;
            dataGrid_consultahora.Size = new Size(674, 311);
            dataGrid_consultahora.TabIndex = 22;
            // 
            // btn_consulhora
            // 
            btn_consulhora.FlatAppearance.BorderSize = 0;
            btn_consulhora.FlatStyle = FlatStyle.Flat;
            btn_consulhora.Image = (Image)resources.GetObject("btn_consulhora.Image");
            btn_consulhora.Location = new Point(771, 87);
            btn_consulhora.Name = "btn_consulhora";
            btn_consulhora.Size = new Size(101, 48);
            btn_consulhora.TabIndex = 21;
            btn_consulhora.UseVisualStyleBackColor = true;
            btn_consulhora.Click += btn_consulhora_Click;
            // 
            // cbbx_funconsultahora
            // 
            cbbx_funconsultahora.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbx_funconsultahora.FormattingEnabled = true;
            cbbx_funconsultahora.Location = new Point(366, 101);
            cbbx_funconsultahora.Name = "cbbx_funconsultahora";
            cbbx_funconsultahora.Size = new Size(399, 28);
            cbbx_funconsultahora.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(271, 101);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 18;
            label1.Text = "Funcionário:";
            // 
            // Consultar_Hora
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1294, 634);
            Controls.Add(dataGrid_consultahora);
            Controls.Add(btn_consulhora);
            Controls.Add(cbbx_funconsultahora);
            Controls.Add(label1);
            Name = "Consultar_Hora";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar_Hora";
            Load += Consultar_Hora_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_consultahora).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGrid_consultahora;
        private Button btn_consulhora;
        private ComboBox cbbx_funconsultahora;
        private Label label1;
    }
}