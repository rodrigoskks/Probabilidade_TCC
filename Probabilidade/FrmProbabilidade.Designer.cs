namespace Probabilidade
{
    partial class FrmProbabilidade
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
            this.cbMandante = new System.Windows.Forms.ComboBox();
            this.cbVisitante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dtgMandante = new System.Windows.Forms.DataGridView();
            this.dtgVisitante = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMandante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitante)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMandante
            // 
            this.cbMandante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMandante.FormattingEnabled = true;
            this.cbMandante.Location = new System.Drawing.Point(102, 44);
            this.cbMandante.Name = "cbMandante";
            this.cbMandante.Size = new System.Drawing.Size(195, 21);
            this.cbMandante.TabIndex = 0;
            // 
            // cbVisitante
            // 
            this.cbVisitante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbVisitante.FormattingEnabled = true;
            this.cbVisitante.Location = new System.Drawing.Point(667, 44);
            this.cbVisitante.Name = "cbVisitante";
            this.cbVisitante.Size = new System.Drawing.Size(195, 21);
            this.cbVisitante.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Time Mandante:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(577, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Time Visitante:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1019, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dtgMandante
            // 
            this.dtgMandante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMandante.Location = new System.Drawing.Point(15, 96);
            this.dtgMandante.Name = "dtgMandante";
            this.dtgMandante.Size = new System.Drawing.Size(529, 259);
            this.dtgMandante.TabIndex = 5;
            // 
            // dtgVisitante
            // 
            this.dtgVisitante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgVisitante.Location = new System.Drawing.Point(580, 96);
            this.dtgVisitante.Name = "dtgVisitante";
            this.dtgVisitante.Size = new System.Drawing.Size(528, 259);
            this.dtgVisitante.TabIndex = 6;
            // 
            // FrmProbabilidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 424);
            this.Controls.Add(this.dtgVisitante);
            this.Controls.Add(this.dtgMandante);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbVisitante);
            this.Controls.Add(this.cbMandante);
            this.Name = "FrmProbabilidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Probabilidade";
            this.Load += new System.EventHandler(this.FrmProbabilidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMandante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVisitante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbMandante;
        private System.Windows.Forms.ComboBox cbVisitante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dtgMandante;
        private System.Windows.Forms.DataGridView dtgVisitante;
    }
}

