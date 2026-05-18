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
    public partial class Envio : UserControl
    {
        public Envio()
        {
            InitializeComponent();
        }
        private void AtualizarLista()
        {

        }
        private void LimparElementos()
        {
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int ID_Pedido =Convert.ToInt32(txtPedido.Text);
            string transportadora = cboTransportadora.Text;
            string codigo_rastreio = cboCodigoRastreio.Text;
            DateTime data_envio = Convert.ToDateTime(dtpDataEnvio.Text);
            int ID_Funcionario = Convert.ToInt32(cboFuncionario.Text);
            string status_envio =cboStatus.Text;
            ENVIOTableAdapter envios = new ENVIOTableAdapter();
            envios.Insert(ID_Pedido, transportadora, codigo_rastreio, data_envio, status_envio, ID_Funcionario);
            LimparElementos();
            AtualizarLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
           
                ENVIORow envio = lboFuncionarios.SelectedItem as ENVIORow;
                if (produto == null) return;
            envio.nome = btnNomeFuncionario.Text;
            envio.cpf = txtCPF.Text;
            envio.email = txtEmail.Text;
            envio.senha = txtSenha.Text;
            envio.cargo = cboCargo.Text;
            envio.Genero = cboGenero.Text;
            envio.status_funcionario = cxoAtivo.Checked.ToString();

                FUNCIONARIOSTableAdapter envios = new FUNCIONARIOSTableAdapter();
            envio.Update(envio.ID_Funcionario, envio.nome, envio.cpf, envio.email, envio.senha, envio.cargo, envio.Genero, envio.status_funcionario);
            LimparElementos();
            lboEnvio.ClearSelected();
            return
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }
    }
}
