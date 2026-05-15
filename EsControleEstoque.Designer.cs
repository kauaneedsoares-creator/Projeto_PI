namespace ProjetoCapeCode
{
    partial class EsControleEstoque
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboTamanho = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.cboCor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lboEstoque = new System.Windows.Forms.ListBox();
            this.btnVolta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(138, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Controle Estoque";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 66);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(383, 285);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(181, 31);
            this.btnLimpar.TabIndex = 16;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Os produtos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tamanho";
            // 
            // cboTamanho
            // 
            this.cboTamanho.FormattingEnabled = true;
            this.cboTamanho.Items.AddRange(new object[] {
            "entrada",
            "saída"});
            this.cboTamanho.Location = new System.Drawing.Point(23, 204);
            this.cboTamanho.Name = "cboTamanho";
            this.cboTamanho.Size = new System.Drawing.Size(121, 21);
            this.cboTamanho.TabIndex = 23;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "entrada",
            "saída"});
            this.comboBox1.Location = new System.Drawing.Point(23, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(503, 21);
            this.comboBox1.TabIndex = 24;
            // 
            // cboCor
            // 
            this.cboCor.FormattingEnabled = true;
            this.cboCor.Items.AddRange(new object[] {
            "entrada",
            "saída"});
            this.cboCor.Location = new System.Drawing.Point(405, 204);
            this.cboCor.Name = "cboCor";
            this.cboCor.Size = new System.Drawing.Size(121, 21);
            this.cboCor.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(402, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Cor";
            // 
            // lboEstoque
            // 
            this.lboEstoque.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lboEstoque.FormattingEnabled = true;
            this.lboEstoque.Location = new System.Drawing.Point(0, 322);
            this.lboEstoque.Name = "lboEstoque";
            this.lboEstoque.Size = new System.Drawing.Size(564, 212);
            this.lboEstoque.TabIndex = 27;
            // 
            // btnVolta
            // 
            this.btnVolta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.btnVolta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVolta.ForeColor = System.Drawing.Color.White;
            this.btnVolta.Location = new System.Drawing.Point(486, 72);
            this.btnVolta.Name = "btnVolta";
            this.btnVolta.Size = new System.Drawing.Size(78, 44);
            this.btnVolta.TabIndex = 28;
            this.btnVolta.Text = "Volta";
            this.btnVolta.UseVisualStyleBackColor = false;
            // 
            // EsControleEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.btnVolta);
            this.Controls.Add(this.lboEstoque);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboCor);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cboTamanho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EsControleEstoque";
            this.Size = new System.Drawing.Size(564, 534);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboTamanho;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cboCor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lboEstoque;
        private System.Windows.Forms.Button btnVolta;
    }
}
