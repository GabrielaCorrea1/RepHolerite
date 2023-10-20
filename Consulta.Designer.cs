namespace RepHolerite
{
    partial class Consulta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Consulta));
            cbbx_funconsulta = new ComboBox();
            label1 = new Label();
            btn_consul = new Button();
            dataGrid_consulta = new DataGridView();
            btn_consultarhora = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGrid_consulta).BeginInit();
            SuspendLayout();
            // 
            // cbbx_funconsulta
            // 
            cbbx_funconsulta.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbx_funconsulta.FormattingEnabled = true;
            cbbx_funconsulta.Location = new Point(361, 125);
            cbbx_funconsulta.Name = "cbbx_funconsulta";
            cbbx_funconsulta.Size = new Size(399, 28);
            cbbx_funconsulta.TabIndex = 13;
            cbbx_funconsulta.SelectedIndexChanged += cbbx_funconsulta_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(266, 125);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 12;
            label1.Text = "Funcionário:";
            // 
            // btn_consul
            // 
            btn_consul.FlatAppearance.BorderSize = 0;
            btn_consul.FlatStyle = FlatStyle.Flat;
            btn_consul.Image = (Image)resources.GetObject("btn_consul.Image");
            btn_consul.Location = new Point(766, 114);
            btn_consul.Name = "btn_consul";
            btn_consul.Size = new Size(101, 48);
            btn_consul.TabIndex = 15;
            btn_consul.UseVisualStyleBackColor = true;
            btn_consul.Click += btn_consul_Click;
            // 
            // dataGrid_consulta
            // 
            dataGrid_consulta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_consulta.Location = new Point(220, 223);
            dataGrid_consulta.Name = "dataGrid_consulta";
            dataGrid_consulta.RowHeadersWidth = 51;
            dataGrid_consulta.RowTemplate.Height = 29;
            dataGrid_consulta.Size = new Size(674, 311);
            dataGrid_consulta.TabIndex = 16;
            dataGrid_consulta.CellContentClick += dataGrid_consulta_CellContentClick;
            // 
            // btn_consultarhora
            // 
            btn_consultarhora.Location = new Point(1094, 613);
            btn_consultarhora.Name = "btn_consultarhora";
            btn_consultarhora.Size = new Size(141, 48);
            btn_consultarhora.TabIndex = 17;
            btn_consultarhora.Text = "Hora";
            btn_consultarhora.UseVisualStyleBackColor = true;
            btn_consultarhora.Click += btn_consultarhora_Click;
            // 
            // Consulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 673);
            Controls.Add(btn_consultarhora);
            Controls.Add(dataGrid_consulta);
            Controls.Add(btn_consul);
            Controls.Add(cbbx_funconsulta);
            Controls.Add(label1);
            Name = "Consulta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consulta";
            Load += Consulta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_consulta).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox cbbx_funconsulta;
        private Label label1;
        private Button btn_consul;
        private DataGridView dataGrid_consulta;
        private Button btn_consultarhora;
    }
}