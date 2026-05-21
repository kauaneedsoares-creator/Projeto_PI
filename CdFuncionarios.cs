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
    public partial class CdFuncionarios : UserControl
    {
        public CdFuncionarios()
        {
            InitializeComponent();
            FUNCIONARIOSTableAdapter FuncionarioDados = new FUNCIONARIOSTableAdapter();
            var dados = from linha in FuncionarioDados.GetData()
                        select linha;
            foreach (FUNCIONARIOSRow dado in dados) lboFuncionarios.Items.Add(dado);
        }
        private void AtualizarLista()
        {

        }
        private void LimparElementos()
        {
            btnNomeFuncionario.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            cboCargo.Text = "";
            cboGenero.Text = "";
            cxoAtivo.Text = " ";

        }

        private void btnAjustess_Click(object sender, EventArgs e)
        {

            string nome = btnNomeFuncionario.Text;
            string cpf = txtCPF.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string cargo = cboCargo.Text;
            string genero = cboGenero.Text;
            string status_funcionario = cxoAtivo.Checked.ToString();
            FUNCIONARIOSTableAdapter funcionario = new FUNCIONARIOSTableAdapter();
            funcionario.Insert(nome, email, senha, cpf, cargo, status_funcionario, genero); 
            LimparElementos();
            AtualizarLista();

        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            FUNCIONARIOSRow funcionario = lboFuncionarios.SelectedItem as FUNCIONARIOSRow;
            if (funcionario == null) return;
            funcionario.nome = btnNomeFuncionario.Text;
            funcionario.cpf = txtCPF.Text;
            funcionario.email = txtEmail.Text;
            funcionario.senha = txtSenha.Text;
            funcionario.cargo = cboCargo.Text;
            funcionario.Genero = cboGenero.Text;
            funcionario.status_funcionario = cxoAtivo.Checked.ToString();

            FUNCIONARIOSTableAdapter funcionarios = new FUNCIONARIOSTableAdapter();
            funcionarios.Update(funcionario.ID_Funcionario, funcionario.nome, funcionario.cpf, funcionario.email, funcionario.senha, funcionario.cargo, funcionario.Genero, funcionario.status_funcionario);

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            lboFuncionarios.ClearSelected();
            AtualizarLista();
            LimparElementos();
        }
    }
}
