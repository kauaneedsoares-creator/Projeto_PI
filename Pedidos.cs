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

namespace ProjetoCapeCode
{
    public partial class Pedidos : UserControl
    {
        public Pedidos()
        {
            InitializeComponent();
            PEDIDOSTableAdapter pedidos = new PEDIDOSTableAdapter();
            var obterPedido = from linha in pedidos.GetData()
                              select linha;
            foreach ( var Pedidos in obterPedido ) lboPedidos.Items.Add( Pedidos );

            PRODUTOSTableAdapter Produto = new PRODUTOSTableAdapter();
            var obterProduto = from linha in Produto.GetData()
                              select linha;
            foreach (var produto in obterProduto) cboProtudos.Items.Add(produto);


        }
       private void  LimparElementos()
       {
        
       }
        private void AtualizarLista()
        {

        }


        private void btnNumeroSeria_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string codigo =
                "CAP-" +
                DateTime.Now.Year + "-" +
                random.Next(100000, 999999);

            txtNumeroSerie.Text = codigo;
        }

        private void btnCadatros_Click(object sender, EventArgs e)
        {

            try
            {
                // Instancia a classe de queries do seu DataSet
                var ta = new Projeto_IntegradorDataSetTableAdapters.QueriesTableAdapter();

                // Executa a procedure passando os dados dos seus campos
                ta.sp_CadastrarPedidoCompleto(
                    txtCliente.Text,
                    txtCPF.Text,
                    txtTelefone.Text,
                    txtEndereço.Text,
                    cboStatus.Text,
                    (int)cboProtudos.SelectedValue,
                    int.Parse(txtQdt.Text),
                    0.00m // Defina o valor unitário aqui
                );

                MessageBox.Show("Cadastro realizado com sucesso!");
                LimparElementos();
                AtualizarLista();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar: " + ex.Message);
            }

        }
    }
}
