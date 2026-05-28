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

            cboProtudos.DisplayMember = "nome";      
            cboProtudos.ValueMember = "ID_Produto"; 


        }
       private void  LimparElementos()
       {

        }
        private void AtualizarLista()
        {
            lboPedidos.Items.Clear();
            PEDIDOSTableAdapter dadospedidos = new PEDIDOSTableAdapter();
            var dados = from linha in dadospedidos.GetData()
                        select linha;
            foreach (PEDIDOSRow dado in dados) lboPedidos.Items.Add(dado);

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
            QueriesTableAdapter ta = new QueriesTableAdapter();

            try
            {
                // 2. Validação para evitar o erro de NullReferenceException
                if (cboProtudos.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecione um produto antes de cadastrar.");
                    return;
                }

                // 3. Converter com segurança
                int idProduto = Convert.ToInt32(cboProtudos.SelectedValue);
                int quantidade = 0;
                int.TryParse(txtQdt.Text, out quantidade); // Forma segura de converter

                // 4. Executa a procedure
                ta.sp_CadastrarPedidoCompleto(
                    txtCliente.Text,
                    txtCPF.Text,
                    txtTelefone.Text,
                    txtEndereço.Text,
                    cboStatus.Text,
                    idProduto,
                    quantidade,
                    0.00m
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

        private void lboPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
