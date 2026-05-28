using ProjetoCapeCode.Projeto_IntegradorDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ProjetoCapeCode.Projeto_IntegradorDataSet;

namespace ProjetoCapeCode
{
    public partial class CdProduto : UserControl
    {
        public CdProduto()
        {
            InitializeComponent();
            AtualizarLista();
            FORNECEDORESTableAdapter Fornecedor = new FORNECEDORESTableAdapter();
            var obterFornecedor = from linha in Fornecedor.GetData()
                              select linha;
            foreach (var fornecedor in obterFornecedor) cboFornecedor.Items.Add(fornecedor);

            PRODUTOSTableAdapter Produto= new PRODUTOSTableAdapter();
            var obterPRODUTOS = from linha in Produto.GetData()
                                  select linha;
            foreach (var produto in obterPRODUTOS) lboProduto.Items.Add(Produto);
        }
        private void AtualizarLista()
        {
            lboProduto.Items.Clear();
            PRODUTOSTableAdapter Produto = new PRODUTOSTableAdapter();
            var dados = from linha in Produto.GetData()
                                select linha;
            foreach (PRODUTOSRow dado in dados) lboProduto.Items.Add(dado);
        }
        private void LimparElementos()
        {
            txtNomeProduto.Text = "";
            txtValor.Text = "";
            txtQuantidade.Text = "";
            txtTamanho.Text = "";
            txtCor.Text = "";
            txtDescricao.Text = "";


        }

        private void SeuFormulario_Load(object sender, EventArgs e)
        {
            // Carregue a lista de fornecedores aqui para garantir que o SelectedValue exista
            FORNECEDORESTableAdapter taFornecedor = new FORNECEDORESTableAdapter();
            cboFornecedor.DataSource = taFornecedor.GetData();
            cboFornecedor.DisplayMember = "nome_fornecedor";
            cboFornecedor.ValueMember = "ID_Fornecedor"; // Este valor deve bater com o banco!
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            string nome = txtNomeProduto.Text;
            decimal valor = Convert.ToDecimal(txtValor.Text);
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            string tamanho = txtTamanho.Text;
            string cor = txtCor.Text;
            string descricao = txtDescricao.Text;
            int altura = Convert.ToInt32(txtAltura.Text);
            decimal peso = Convert.ToDecimal(txtPeso.Text);
            int ID_Fornecedor = Convert.ToInt32(cboFornecedor.SelectedValue);
            PRODUTOSTableAdapter produtos = new PRODUTOSTableAdapter();
            produtos.Insert(nome, descricao, valor, quantidade, tamanho, cor, altura,peso, ID_Fornecedor);
            LimparElementos();
            AtualizarLista();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            PRODUTOSRow produto = lboProduto.SelectedItem as PRODUTOSRow;
            if (produto == null) return;
            produto.nome = txtNomeProduto.Text;
            produto.valor = Convert.ToDecimal(txtValor.Text);
            produto.quantidade = Convert.ToInt32(txtQuantidade.Text);
            produto.cor = txtCor.Text;
            produto.altura = Convert.ToDecimal(txtAltura.Text);
            produto.descricao = txtDescricao.Text;
            produto.peso = Convert.ToDecimal(txtPeso.Text);
            produto.ID_Fornecedor = Convert.ToInt32(cboFornecedor);

            PRODUTOSTableAdapter produtos = new PRODUTOSTableAdapter();
            produtos.Update(produto.ID_Produto, produto.nome, produto.descricao, produto.valor, produto.quantidade, produto.tamanho, produto.cor,produto.ID_Fornecedor, produto.altura, produto.peso);
            LimparElementos();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Text = "";
            txtValor.Text = "";
            txtQuantidade.Text = "";
            txtTamanho.Text = "";
            txtCor.Text = "";
            txtDescricao.Text = "";

        }

        private void lboProduto_SelectedIndexChanged(object sender, EventArgs e)
        {
            PRODUTOSRow produto = lboProduto.SelectedItem as PRODUTOSRow;
            txtNomeProduto.Text = produto.nome;
            txtValor.Text = produto.valor.ToString("F2"); // "F2" formata com 2 casas decimais
            txtQuantidade.Text = produto.quantidade.ToString();
            txtTamanho.Text = produto.tamanho;
            txtCor.Text = produto.cor;
            txtDescricao.Text = produto.descricao;
            txtAltura.Text = produto.altura.ToString();
            txtPeso.Text = produto.peso.ToString();

            // Para o ComboBox, definimos o valor real (ID)
            cboFornecedor.SelectedValue = produto.ID_Fornecedor;

        }
    }
}
