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
        }
        private void AtualizarLista()
        {

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

        private void btnAjustess_Click(object sender, EventArgs e)
        {
            // Verifica se o botão está no modo "Cadastrar"
            if (btnAjustess.Text == "Cadastrar")
            {
                string nome = txtNomeProduto.Text;
                string valor = Convert.ToString( txtValor.Text);
                string quantidade = txtQuantidade.Text;
                string tamanho = txtTamanho.Text;
                string cor = txtCor.Text;
                string descricao = txtDescricao.Text;
                 PRODUTOSTableAdapter produtos = new PRODUTOSTableAdapter();
                produtos.Insert(nome, descricao, valor, quantidade, tamanho, cor);
                LimparElementos();
                AtualizarLista();


            }
            // Caso não seja cadastro, então é atualização
            else
            {
                if (lboProduto.SelectedItem == null)
                {
                    LimparElementos();
                    lboProduto.ClearSelected();
                    return;
                }
                FUNCIONARIOSRow funcionario = lboProduto.SelectedItem as FUNCIONARIOSRow;
                if (funcionario == null) return;
                funcionario.nome = btnNomeFuncionario.Text;
                funcionario.cpf = txtCPF.Text;
                funcionario.email = txtEmail.Text;
                funcionario.senha = txtSenha.Text;
                funcionario.cargo = cboCargo.Text;
                funcionario.Genero = cboGenero.Text;
                funcionario.status_funcionario = cxoAtivo.Checked.ToString();

                FUNCIONARIOSTableAdapter funcionarios = new FUNCIONARIOSTableAdapter();
                funcionario.Update(funcionario.ID_Funcionario, funcionario.nome, funcionario.cpf, funcionario.email, funcionario.senha, funcionario.cargo, funcionario.Genero, funcionario.status_funcionario);
                // Volta os botões para o estado padrão
                btnAcoes.Text = "Cadastrar";
                btnAjustess.Text = "Atulizar Lista";
                LimparElementos();

            }
        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            if (btnAcoes.Text == "Excluir") // Só faz alguma coisa se o texto do botão for "Excluir"
            {
                if (lboProduto.SelectedItem == null) return;
                FUNCIONARIOSRow funcionario = lboProduto.SelectedItem as FUNCIONARIOSRow;
                if (funcionario == null) return;
                // Conecta com o banco de dados e apaga o usuarios usando o ID dele
                FUNCIONARIOSTableAdapter funcionarios = new FUNCIONARIOSTableAdapter();
                funcionarios.Delete(funcionario.ID_Funcionario);

                LimparElementos();
                AtualizarLista();


                // Volta os botões para o estado normal (Cadastrar e Atualizar Lista)
                btnAcoes.Text = "Atulizar Lista";
                btnAjustess.Text = "Cadastrar";


            }
        }

        private void bntLLimpar_Click(object sender, EventArgs e)
        {
            lboProduto.ClearSelected();
            AtualizarLista();
            LimparElementos();
        }
    }
}
