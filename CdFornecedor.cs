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
    public partial class CdFornecedor : UserControl
    {
        public CdFornecedor()
        {
            InitializeComponent();
            FORNECEDORESTableAdapter Fornecedor = new FORNECEDORESTableAdapter();
            var obterFornecedor = from linha in Fornecedor.GetData()
                                  select linha;
            foreach (var fornecedor in obterFornecedor) lboForncedor.Items.Add(fornecedor);
        }

        private void LimparElementos()
        {
            txtNome.Text = "";
            txtCNPJ.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";
         
        }
        private void AtualizarLista()
        {
            lboForncedor.Items.Clear();
            FORNECEDORESTableAdapter fornecedor = new FORNECEDORESTableAdapter();
            var dados = from linha in fornecedor.GetData()
                        select linha;
            foreach (FORNECEDORESRow dado in dados) lboForncedor.Items.Add(dado);
        }



        private void btnCadrastro_Click(object sender, EventArgs e)
        {
            string nome_fornecedor = txtNome.Text;
            string cnpj = txtCNPJ.Text;
            string email = txtEmail.Text;
            string endereco = txtEndereco.Text;
            string telefone = txtTelefone.Text;

            FORNECEDORESTableAdapter fornecedores = new FORNECEDORESTableAdapter();
            fornecedores.Insert(nome_fornecedor, cnpj, email, telefone, endereco);
            LimparElementos();
            AtualizarLista();


        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FORNECEDORESRow fornecedor = lboForncedor.SelectedItem as FORNECEDORESRow;
            fornecedor.nome_fornecedor = txtNome.Text;
            fornecedor.cnpj = txtCNPJ.Text;
            fornecedor.email = txtEmail.Text;
            fornecedor.endereco = txtEndereco.Text;
            fornecedor.telefone = txtTelefone.Text;
            FORNECEDORESTableAdapter fornecedores = new FORNECEDORESTableAdapter();
            fornecedores.Update(fornecedor.ID_Fornecedor, fornecedor.nome_fornecedor, fornecedor.cnpj, fornecedor.email, fornecedor.telefone, fornecedor.endereco);
            LimparElementos();
            AtualizarLista();


        }

        private void Limpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = "";
            txtCNPJ.Text = "";
            txtEmail.Text = "";
            txtEndereco.Text = "";
            txtTelefone.Text = "";

        }

        private void lboForncedor_SelectedIndexChanged(object sender, EventArgs e)
        {

            FORNECEDORESRow fornecedor = lboForncedor.SelectedItem as FORNECEDORESRow;
            txtCNPJ.Text = fornecedor.cnpj;
            txtEmail.Text = fornecedor.email;
            txtEndereco.Text = fornecedor.endereco;
            txtTelefone.Text = fornecedor.telefone;
            txtNome.Text =  fornecedor.nome_fornecedor;
           


        }
    }
}
