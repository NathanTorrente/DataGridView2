namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboVeiculos = new System.Windows.Forms.ComboBox();
            this.data_GridView = new System.Windows.Forms.DataGridView();
            this.txtResultado = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_NomeGrid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_GridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cboVeiculos
            // 
            this.cboVeiculos.FormattingEnabled = true;
            this.cboVeiculos.Items.AddRange(new object[] {
            "Corsa",
            "Maverick",
            "Supra",
            "Dodge Viper"});
            this.cboVeiculos.Location = new System.Drawing.Point(69, 83);
            this.cboVeiculos.Name = "cboVeiculos";
            this.cboVeiculos.Size = new System.Drawing.Size(181, 21);
            this.cboVeiculos.TabIndex = 4;
            this.cboVeiculos.Text = "[Selecione]";
            this.cboVeiculos.SelectedIndexChanged += new System.EventHandler(this.cboVeiculos_SelectedIndexChanged);
            // 
            // data_GridView
            // 
            this.data_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_GridView.Location = new System.Drawing.Point(430, 134);
            this.data_GridView.Name = "data_GridView";
            this.data_GridView.Size = new System.Drawing.Size(240, 150);
            this.data_GridView.TabIndex = 5;
            this.data_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_GridView_CellContentClick);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(69, 253);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(206, 63);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.Text = "OK";
            this.txtResultado.UseVisualStyleBackColor = true;
            this.txtResultado.Click += new System.EventHandler(this.txtResultado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Veículos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Pressione Ok para apresentar os dados";
            // 
            // lbl_NomeGrid
            // 
            this.lbl_NomeGrid.AutoSize = true;
            this.lbl_NomeGrid.Location = new System.Drawing.Point(468, 100);
            this.lbl_NomeGrid.Name = "lbl_NomeGrid";
            this.lbl_NomeGrid.Size = new System.Drawing.Size(139, 13);
            this.lbl_NomeGrid.TabIndex = 9;
            this.lbl_NomeGrid.Text = "Dados da coleção Veículos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_NomeGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.data_GridView);
            this.Controls.Add(this.cboVeiculos);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.data_GridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboVeiculos;
        private System.Windows.Forms.DataGridView data_GridView;
        private System.Windows.Forms.Button txtResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_NomeGrid;
    }
}

