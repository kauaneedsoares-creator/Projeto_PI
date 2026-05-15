namespace ProjetoCapeCode
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
            System.Windows.Forms.Button btnProduto;
            System.Windows.Forms.Button btnFornecedor;
            System.Windows.Forms.Button btnFuncionario;
            System.Windows.Forms.Button btnConsulta;
            System.Windows.Forms.Button btnPedidos;
            System.Windows.Forms.Button btnPedido;
            System.Windows.Forms.Button btnEnvio;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnInicio = new System.Windows.Forms.Button();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnCadatros = new System.Windows.Forms.Button();
            this.tcControle = new MaterialSkin.Controls.MaterialTabControl();
            this.tpInicio = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.tpEstoque = new System.Windows.Forms.TabPage();
            this.tpFucionario = new System.Windows.Forms.TabPage();
            this.tpPedido = new System.Windows.Forms.TabPage();
            this.tpConsulta = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tpProduto = new System.Windows.Forms.TabPage();
            this.tpFornecedors = new System.Windows.Forms.TabPage();
            this.tpEnvios = new System.Windows.Forms.TabPage();
            this.panelMenuPedidos = new System.Windows.Forms.Panel();
            this.panelMenuCadatros = new System.Windows.Forms.Panel();
            this.paneMenuPrinpal = new System.Windows.Forms.FlowLayoutPanel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            btnProduto = new System.Windows.Forms.Button();
            btnFornecedor = new System.Windows.Forms.Button();
            btnFuncionario = new System.Windows.Forms.Button();
            btnConsulta = new System.Windows.Forms.Button();
            btnPedidos = new System.Windows.Forms.Button();
            btnPedido = new System.Windows.Forms.Button();
            btnEnvio = new System.Windows.Forms.Button();
            this.tcControle.SuspendLayout();
            this.tpInicio.SuspendLayout();
            this.tpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelMenuPedidos.SuspendLayout();
            this.panelMenuCadatros.SuspendLayout();
            this.paneMenuPrinpal.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnProduto
            // 
            btnProduto.AutoEllipsis = true;
            btnProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            btnProduto.FlatAppearance.BorderSize = 0;
            btnProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnProduto.ForeColor = System.Drawing.Color.White;
            btnProduto.Location = new System.Drawing.Point(-3, 0);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new System.Drawing.Size(155, 44);
            btnProduto.TabIndex = 5;
            btnProduto.Text = "Produto";
            btnProduto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += new System.EventHandler(this.btnProduto_Click);
            // 
            // btnFornecedor
            // 
            btnFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            btnFornecedor.FlatAppearance.BorderSize = 0;
            btnFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFornecedor.ForeColor = System.Drawing.Color.White;
            btnFornecedor.Location = new System.Drawing.Point(0, 41);
            btnFornecedor.Name = "btnFornecedor";
            btnFornecedor.Size = new System.Drawing.Size(159, 44);
            btnFornecedor.TabIndex = 6;
            btnFornecedor.Text = "Fornecedor";
            btnFornecedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnFornecedor.UseVisualStyleBackColor = false;
            btnFornecedor.Click += new System.EventHandler(this.btnFornecedor_Click);
            // 
            // btnFuncionario
            // 
            btnFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            btnFuncionario.Dock = System.Windows.Forms.DockStyle.Top;
            btnFuncionario.FlatAppearance.BorderSize = 0;
            btnFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnFuncionario.ForeColor = System.Drawing.Color.White;
            btnFuncionario.Location = new System.Drawing.Point(3, 463);
            btnFuncionario.Name = "btnFuncionario";
            btnFuncionario.Size = new System.Drawing.Size(153, 44);
            btnFuncionario.TabIndex = 7;
            btnFuncionario.Text = "Funcionario";
            btnFuncionario.UseVisualStyleBackColor = false;
            btnFuncionario.Click += new System.EventHandler(this.btnFuncionario_Click);
            // 
            // btnConsulta
            // 
            btnConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            btnConsulta.Dock = System.Windows.Forms.DockStyle.Top;
            btnConsulta.FlatAppearance.BorderSize = 0;
            btnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnConsulta.ForeColor = System.Drawing.Color.White;
            btnConsulta.Location = new System.Drawing.Point(3, 413);
            btnConsulta.Name = "btnConsulta";
            btnConsulta.Size = new System.Drawing.Size(153, 44);
            btnConsulta.TabIndex = 3;
            btnConsulta.Text = "Consulta";
            btnConsulta.UseVisualStyleBackColor = false;
            btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // btnPedidos
            // 
            btnPedidos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            btnPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPedidos.ForeColor = System.Drawing.Color.White;
            btnPedidos.Location = new System.Drawing.Point(3, 225);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new System.Drawing.Size(155, 39);
            btnPedidos.TabIndex = 8;
            btnPedidos.Text = "Pedidos";
            btnPedidos.UseVisualStyleBackColor = false;
            btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnPedido
            // 
            btnPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            btnPedido.FlatAppearance.BorderSize = 0;
            btnPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnPedido.ForeColor = System.Drawing.Color.White;
            btnPedido.Location = new System.Drawing.Point(0, 0);
            btnPedido.Name = "btnPedido";
            btnPedido.Size = new System.Drawing.Size(159, 44);
            btnPedido.TabIndex = 9;
            btnPedido.Text = "Pedido";
            btnPedido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnPedido.UseVisualStyleBackColor = false;
            btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnEnvio
            // 
            btnEnvio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            btnEnvio.FlatAppearance.BorderSize = 0;
            btnEnvio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnEnvio.ForeColor = System.Drawing.Color.White;
            btnEnvio.Location = new System.Drawing.Point(-4, 41);
            btnEnvio.Name = "btnEnvio";
            btnEnvio.Size = new System.Drawing.Size(159, 46);
            btnEnvio.TabIndex = 10;
            btnEnvio.Text = "Envio";
            btnEnvio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnEnvio.UseVisualStyleBackColor = false;
            btnEnvio.Click += new System.EventHandler(this.btnEnvio_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnInicio.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInicio.FlatAppearance.BorderSize = 0;
            this.btnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Location = new System.Drawing.Point(3, 513);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(155, 44);
            this.btnInicio.TabIndex = 4;
            this.btnInicio.Text = "Inicio";
            this.btnInicio.UseVisualStyleBackColor = false;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnEstoque.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEstoque.FlatAppearance.BorderSize = 0;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEstoque.ForeColor = System.Drawing.Color.White;
            this.btnEstoque.Location = new System.Drawing.Point(3, 363);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(155, 44);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnCadatros
            // 
            this.btnCadatros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.btnCadatros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadatros.FlatAppearance.BorderSize = 0;
            this.btnCadatros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadatros.ForeColor = System.Drawing.Color.White;
            this.btnCadatros.Location = new System.Drawing.Point(3, 84);
            this.btnCadatros.Name = "btnCadatros";
            this.btnCadatros.Size = new System.Drawing.Size(155, 44);
            this.btnCadatros.TabIndex = 1;
            this.btnCadatros.Text = "Cadatros";
            this.btnCadatros.UseVisualStyleBackColor = false;
            this.btnCadatros.Click += new System.EventHandler(this.btnCadatros_Click);
            // 
            // tcControle
            // 
            this.tcControle.AllowDrop = true;
            this.tcControle.Controls.Add(this.tpInicio);
            this.tcControle.Controls.Add(this.tpEstoque);
            this.tcControle.Controls.Add(this.tpFucionario);
            this.tcControle.Controls.Add(this.tpPedido);
            this.tcControle.Controls.Add(this.tpConsulta);
            this.tcControle.Controls.Add(this.tpProduto);
            this.tcControle.Controls.Add(this.tpFornecedors);
            this.tcControle.Controls.Add(this.tpEnvios);
            this.tcControle.Depth = 0;
            this.tcControle.Location = new System.Drawing.Point(155, 0);
            this.tcControle.MouseState = MaterialSkin.MouseState.HOVER;
            this.tcControle.Name = "tcControle";
            this.tcControle.SelectedIndex = 0;
            this.tcControle.Size = new System.Drawing.Size(572, 563);
            this.tcControle.TabIndex = 1;
            // 
            // tpInicio
            // 
            this.tpInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.tpInicio.Controls.Add(this.label3);
            this.tpInicio.ForeColor = System.Drawing.Color.White;
            this.tpInicio.Location = new System.Drawing.Point(4, 22);
            this.tpInicio.Name = "tpInicio";
            this.tpInicio.Padding = new System.Windows.Forms.Padding(3);
            this.tpInicio.Size = new System.Drawing.Size(564, 537);
            this.tpInicio.TabIndex = 4;
            this.tpInicio.Text = "Inicio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(226, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inicio";
            // 
            // tpEstoque
            // 
            this.tpEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.tpEstoque.Location = new System.Drawing.Point(4, 22);
            this.tpEstoque.Name = "tpEstoque";
            this.tpEstoque.Padding = new System.Windows.Forms.Padding(3);
            this.tpEstoque.Size = new System.Drawing.Size(564, 537);
            this.tpEstoque.TabIndex = 6;
            this.tpEstoque.Text = "Estoque";
            // 
            // tpFucionario
            // 
            this.tpFucionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.tpFucionario.Location = new System.Drawing.Point(4, 22);
            this.tpFucionario.Name = "tpFucionario";
            this.tpFucionario.Padding = new System.Windows.Forms.Padding(3);
            this.tpFucionario.Size = new System.Drawing.Size(564, 537);
            this.tpFucionario.TabIndex = 8;
            this.tpFucionario.Text = "Fucionario";
            // 
            // tpPedido
            // 
            this.tpPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.tpPedido.Location = new System.Drawing.Point(4, 22);
            this.tpPedido.Name = "tpPedido";
            this.tpPedido.Padding = new System.Windows.Forms.Padding(3);
            this.tpPedido.Size = new System.Drawing.Size(564, 537);
            this.tpPedido.TabIndex = 9;
            this.tpPedido.Text = "Pedidos";
            // 
            // tpConsulta
            // 
            this.tpConsulta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.tpConsulta.Controls.Add(this.label2);
            this.tpConsulta.Controls.Add(this.label1);
            this.tpConsulta.Controls.Add(this.txtPesquisa);
            this.tpConsulta.Controls.Add(this.listBox1);
            this.tpConsulta.Controls.Add(this.pictureBox2);
            this.tpConsulta.Location = new System.Drawing.Point(4, 22);
            this.tpConsulta.Name = "tpConsulta";
            this.tpConsulta.Padding = new System.Windows.Forms.Padding(3);
            this.tpConsulta.Size = new System.Drawing.Size(564, 537);
            this.tpConsulta.TabIndex = 10;
            this.tpConsulta.Text = "Consuta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(214, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 31);
            this.label2.TabIndex = 17;
            this.label2.Text = "Consuta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Digite Consuta";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(20, 117);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(159, 20);
            this.txtPesquisa.TabIndex = 15;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 296);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(558, 238);
            this.listBox1.TabIndex = 14;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(24)))), ((int)(((byte)(80)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(558, 66);
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // tpProduto
            // 
            this.tpProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.tpProduto.Location = new System.Drawing.Point(4, 22);
            this.tpProduto.Name = "tpProduto";
            this.tpProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tpProduto.Size = new System.Drawing.Size(564, 537);
            this.tpProduto.TabIndex = 11;
            this.tpProduto.Text = "Produto";
            // 
            // tpFornecedors
            // 
            this.tpFornecedors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.tpFornecedors.Location = new System.Drawing.Point(4, 22);
            this.tpFornecedors.Name = "tpFornecedors";
            this.tpFornecedors.Padding = new System.Windows.Forms.Padding(3);
            this.tpFornecedors.Size = new System.Drawing.Size(564, 537);
            this.tpFornecedors.TabIndex = 12;
            this.tpFornecedors.Text = "Fornecedor";
            // 
            // tpEnvios
            // 
            this.tpEnvios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.tpEnvios.Location = new System.Drawing.Point(4, 22);
            this.tpEnvios.Name = "tpEnvios";
            this.tpEnvios.Padding = new System.Windows.Forms.Padding(3);
            this.tpEnvios.Size = new System.Drawing.Size(564, 537);
            this.tpEnvios.TabIndex = 13;
            this.tpEnvios.Text = "Envios";
            // 
            // panelMenuPedidos
            // 
            this.panelMenuPedidos.Controls.Add(btnEnvio);
            this.panelMenuPedidos.Controls.Add(btnPedido);
            this.panelMenuPedidos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenuPedidos.Location = new System.Drawing.Point(3, 270);
            this.panelMenuPedidos.Name = "panelMenuPedidos";
            this.panelMenuPedidos.Size = new System.Drawing.Size(155, 87);
            this.panelMenuPedidos.TabIndex = 11;
            this.panelMenuPedidos.Visible = false;
            // 
            // panelMenuCadatros
            // 
            this.panelMenuCadatros.Controls.Add(btnFornecedor);
            this.panelMenuCadatros.Controls.Add(btnProduto);
            this.panelMenuCadatros.Location = new System.Drawing.Point(3, 134);
            this.panelMenuCadatros.Name = "panelMenuCadatros";
            this.panelMenuCadatros.Size = new System.Drawing.Size(152, 85);
            this.panelMenuCadatros.TabIndex = 10;
            this.panelMenuCadatros.Visible = false;
            // 
            // paneMenuPrinpal
            // 
            this.paneMenuPrinpal.Controls.Add(this.panelLogo);
            this.paneMenuPrinpal.Controls.Add(this.btnCadatros);
            this.paneMenuPrinpal.Controls.Add(this.panelMenuCadatros);
            this.paneMenuPrinpal.Controls.Add(btnPedidos);
            this.paneMenuPrinpal.Controls.Add(this.panelMenuPedidos);
            this.paneMenuPrinpal.Controls.Add(this.btnEstoque);
            this.paneMenuPrinpal.Controls.Add(btnConsulta);
            this.paneMenuPrinpal.Controls.Add(btnFuncionario);
            this.paneMenuPrinpal.Controls.Add(this.btnInicio);
            this.paneMenuPrinpal.Dock = System.Windows.Forms.DockStyle.Left;
            this.paneMenuPrinpal.Location = new System.Drawing.Point(0, 0);
            this.paneMenuPrinpal.Name = "paneMenuPrinpal";
            this.paneMenuPrinpal.Size = new System.Drawing.Size(158, 563);
            this.paneMenuPrinpal.TabIndex = 2;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.panelLogo.Location = new System.Drawing.Point(3, 3);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(159, 75);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(159, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(15)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(728, 563);
            this.Controls.Add(this.paneMenuPrinpal);
            this.Controls.Add(this.tcControle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tcControle.ResumeLayout(false);
            this.tpInicio.ResumeLayout(false);
            this.tpInicio.PerformLayout();
            this.tpConsulta.ResumeLayout(false);
            this.tpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelMenuPedidos.ResumeLayout(false);
            this.panelMenuCadatros.ResumeLayout(false);
            this.paneMenuPrinpal.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tpEstoque;
        private System.Windows.Forms.TabPage tpFucionario;
        private System.Windows.Forms.Button btnInicio;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnCadatros;
        private System.Windows.Forms.Panel panelMenuCadatros;
        private System.Windows.Forms.Panel panelMenuPedidos;
        private System.Windows.Forms.TabPage tpInicio;
        private System.Windows.Forms.TabPage tpConsulta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel paneMenuPrinpal;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MaterialSkin.Controls.MaterialTabControl tcControle;
        private System.Windows.Forms.TabPage tpProduto;
        private System.Windows.Forms.TabPage tpFornecedors;
        private System.Windows.Forms.TabPage tpEnvios;
        private System.Windows.Forms.TabPage tpPedido;
    }
}

