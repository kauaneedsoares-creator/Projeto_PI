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
            FUNCIONARIOSTableAdapter funcionarios = new FUNCIONARIOSTableAdapter();
            var obterfuncionarios = from linha in funcionarios.GetData()
                        select linha;
            foreach (var funcionario in obterfuncionarios) lboFuncionarios.Items.Add(funcionario);
        }
        private void AtualizarLista()
        {
            lboFuncionarios.Items.Clear();
            FUNCIONARIOSTableAdapter FuncionarioDados = new FUNCIONARIOSTableAdapter();
            var dados = from linha in FuncionarioDados.GetData()
                        select linha;
            foreach (FUNCIONARIOSRow dado in dados) lboFuncionarios.Items.Add(dado);

        }
        private void LimparElementos()
        {
            btnNomeFuncionario.Text = "";
            txtCPF.Text = "";
            txtEmail.Text = "";
            txtSenha.Text = "";
            cboCargo.Text = "";
            cboGenero.Text = "";
            cboStatus.Text = " ";

        }

        private void btnAjustess_Click(object sender, EventArgs e)
        {

            string nome = btnNomeFuncionario.Text;
            string cpf = txtCPF.Text;
            string email = txtEmail.Text;
            string senha = txtSenha.Text;
            string cargo = cboCargo.Text;
            string genero = cboGenero.Text;
            string status_funcionario = cboStatus.Text;
                byte[] senhaBytes = System.Text.Encoding.UTF8.GetBytes(senha); ;
            FUNCIONARIOSTableAdapter funcionario = new FUNCIONARIOSTableAdapter();
            funcionario.Insert(nome, email, senhaBytes, cpf, cargo, status_funcionario, genero); 
            LimparElementos();
            AtualizarLista();

        }

        private void btnAcoes_Click(object sender, EventArgs e)
        {
            FUNCIONARIOSRow funcionario = lboFuncionarios.SelectedItem as FUNCIONARIOSRow;
            if (funcionario == null) return;
            funcionario.nome = btnNomeFuncionario.Text;
            funcionario.email = txtEmail.Text;
            funcionario.cpf = txtCPF.Text;
            funcionario.cargo = cboCargo.Text;
            funcionario.genero = cboGenero.Text;
            funcionario.status_funcionario = cboStatus.Text;
            byte[] senhaBytes = System.Text.Encoding.UTF8.GetBytes(txtSenha.Text); ;


            FUNCIONARIOSTableAdapter funcionarios = new FUNCIONARIOSTableAdapter();
            funcionarios.Update(funcionario.ID_Funcionario, funcionario.nome, funcionario.email, funcionario.senha, funcionario.cpf, funcionario.cargo, funcionario.genero, funcionario.status_funcionario);
            LimparElementos();
            AtualizarLista();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            lboFuncionarios.ClearSelected();
            AtualizarLista();
            LimparElementos();
        }

        private void lboFuncionarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            FUNCIONARIOSRow funcionario = lboFuncionarios.SelectedItem as FUNCIONARIOSRow;
            btnNomeFuncionario.Text = funcionario.nome;
            txtCPF.Text = funcionario.cpf;
            txtEmail.Text = funcionario.email;
            cboCargo.Text = funcionario.cargo;
            cboGenero.Text = funcionario.genero;
            cboStatus.Text = funcionario.status_funcionario;

        }
    }
}
