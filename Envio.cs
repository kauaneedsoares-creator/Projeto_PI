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
using static System.Windows.Forms.LinkLabel;

namespace ProjetoCapeCode
{
    public partial class Envio : UserControl
    {
        public Envio()
        {
            InitializeComponent();
            PEDIDOSTableAdapter PedidoDados = new PEDIDOSTableAdapter();
            var dados = from linha in PedidoDados.GetData()
                        select linha;
            foreach (PEDIDOSRow dado in dados) lboEnvio.Items.Add(dado);

            FUNCIONARIOSTableAdapter funcionarios = new FUNCIONARIOSTableAdapter(); 
            var obterfuncionarios = from linha in funcionarios.GetData() select linha;
            foreach(var Funcionarios in obterfuncionarios) cboFuncionario.Items.Add(Funcionarios);
            cboFuncionario.SelectedIndex = 0;
        }
        private void AtualizarLista()
        {

        }
        private void LimparElementos()
        {
           
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            int ID_Pedido = Convert.ToInt32(lboIDPedido.Text);
            string transportadora = cboTransportadora.Text;
            string codigo_rastreio = cboCodigoRastreio.Text;
            DateTime data_envio = Convert.ToDateTime(dtpDataEnvio.Text);
            int ID_Funcionario = Convert.ToInt32(cboFuncionario.Text);
            string status_envio = cboStatus.Text;
            ENVIOTableAdapter envios = new ENVIOTableAdapter();
            envios.Insert(ID_Pedido, transportadora, codigo_rastreio, data_envio, status_envio, ID_Funcionario);
            LimparElementos();
            AtualizarLista();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            ENVIORow envio = lboEnvio.SelectedItem as ENVIORow;
            if (envio == null) return;
            envio.transportadora = cboTransportadora.Text;
            envio.codigo_rastreio = cboCodigoRastreio.Text;
            envio.ID_Funcionario = Convert.ToInt32(cboFuncionario.Text);
            envio.status_envio = cboStatus.Text;


            ENVIOTableAdapter envios = new ENVIOTableAdapter();
            envios.Update(envio);
            LimparElementos();
            lboEnvio.ClearSelected();
            return;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

        }

        private void lboEnvio_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Verifica se tem algo selecionado para evitar erro
            if (lboEnvio.SelectedItem == null) return;

            try
            {
                // 1. Pega a linha que foi selecionada no ListBox
                var pedidoSelecionado = lboEnvio.SelectedItem as DetalhesParaEnvioRow;

                // 2. Instancia o adaptador
                DetalhesParaEnvioTableAdapter adaptadorDetalhes = new DetalhesParaEnvioTableAdapter();

                // 3. Executa a busca passando o ID da linha selecionada
                var tabelaResultado = adaptadorDetalhes.GetData(pedidoSelecionado.ID_Pedido);

                if (tabelaResultado.Rows.Count > 0)
                {
                    var linha = tabelaResultado[0];

                    // 4. Preenche as caixas de texto
                    lblNomeCliente.Text = linha.NomeCliente;
                    lblEnderecoEntrega.Text = linha.EnderecoEntrega;
                    lblProduto.Text = linha.NomeProduto;
                    lblQuantidade.Text = linha.QuantidadeComprada.ToString();
                    lblPeso.Text = linha.PesoTotalDesteItem.ToString();
                    lblAltura.Text = linha.AlturaProduto.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes: " + ex.Message);
            }



        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
          
        }

        
    }
}
