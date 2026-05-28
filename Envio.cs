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
            PRODUTOSTableAdapter Produto = new PRODUTOSTableAdapter();
            var obterPRODUTOS = from linha in Produto.GetData()
                                select linha;
            foreach (var produto in obterPRODUTOS) lboEnvio.Items.Add(Produto);

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
            string codigo_rastreio = txtCodigoRastreio.Text;
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
            envio.codigo_rastreio = txtCodigoRastreio.Text;
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
            try
            {
                // Pega a linha selecionada
                PesquisaENVIORow pedidoSelecionado =
                    lboEnvio.SelectedItem as PesquisaENVIORow;

                if (pedidoSelecionado == null)
                    return;

                // Adaptador
                PesquisaENVIOTableAdapter adaptador =
                    new PesquisaENVIOTableAdapter();

                // Busca os dados
                var tabelaResultado =
                    adaptador.GetData(txtPesquisa.Text);

                if (tabelaResultado.Rows.Count > 0)
                {
                    var linha = tabelaResultado[0];

                    // Preenche labels
                    lblNomeCliente.Text = linha.Cliente;
                    lblProduto.Text = linha.transportadora;
                    lblQuantidade.Text = linha.ID_Pedido.ToString();
                    lblPeso.Text = linha.codigo_rastreio;
                    lblAltura.Text = linha.status_envio;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar detalhes: " + ex.Message);
            }
        }


        private void btnCodigoRastreio_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            string codigo =
                "BR" +
                random.Next(100000, 999999).ToString() +
                "SP";

            txtCodigoRastreio.Text = codigo;
        }
    }
}
