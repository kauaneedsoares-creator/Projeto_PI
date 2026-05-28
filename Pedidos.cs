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

        private void lboPedidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            PEDIDOSRow pedido = lboPedidos.SelectedItem as PEDIDOSRow;

            if (pedido != null)
            {
                // 1. Acessar os campos do PEDIDO
                cboStatus.Text = pedido.status_pedido;

                // 2. Para buscar os dados do CLIENTE (relacionado ao pedido):
                // Como o 'pedido' tem o ID_Cliente, precisamos buscar os dados do cliente
                CLIENTESTableAdapter taClientes = new CLIENTESTableAdapter();
                var listaClientes = taClientes.GetData();
                var cliente = listaClientes.FirstOrDefault(c => c.ID_Cliente == pedido.ID_Cliente);

                if (cliente != null)
                {
                    txtCliente.Text = cliente.nome;
                    txtCPF.Text = cliente.cpf;
                    txtTelefone.Text = cliente.telefone;
                    txtEndereço.Text = cliente.endereco;
                }

                // 3. Para os itens (Produto e Quantidade)
                // Isso assume que você tem uma forma de buscar o item do pedido
                ITENS_PEDIDOTableAdapter taItens = new ITENS_PEDIDOTableAdapter();
                var item = taItens.GetDataByPedido(pedido.ID_Pedido).FirstOrDefault();

                if (item != null)
                {
                    cboProtudos.SelectedValue = item.ID_Produto;
                    txtQdt.Text = item.quantidade.ToString();
                }
            }
        }
    }
}
