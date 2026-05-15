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
    public partial class Form1 : Form
    {
        private CdFornecedor cdFornecedor;
        private CdFuncionarios cdFuncionarios;
        private CdProduto cdProduto;
        private EsControleEstoque esControleEstoque;
       private Pedidos pedidos;
        private Envio envio;

        public Form1()
        {
            InitializeComponent();
            OcultarSubMenus(); // Inicializa tudo fechado
                               // Define a largura (Width) e a altura (Height)
            
        }

        //  Este método serve apenas para FECHAR todos os painéis
        private void OcultarSubMenus()
        {
            if (panelMenuCadatros.Visible == true)
                panelMenuCadatros.Visible = false;

            if (panelMenuPedidos.Visible == true)
                panelMenuPedidos.Visible = false;
        }

        // Este método gerencia a abertura e fechamento (o efeito sanfona)
        private void MostrarSubMenu(Panel subMenuEscolhido)
        {
            if (subMenuEscolhido.Visible == false)
            {
                OcultarSubMenus(); // Fecha os outros antes de abrir o novo
                subMenuEscolhido.Visible = true;
            }
            else
            {
                // Se já estava aberto e clicou de novo, ele fecha
                subMenuEscolhido.Visible = false;
            }
        }


        private void btnCadatros_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelMenuCadatros); 
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpEstoque);
            esControleEstoque = new EsControleEstoque();
            esControleEstoque.Dock = DockStyle.Fill;
            tpEstoque.Controls.Clear();
            tpEstoque.Controls.Add(esControleEstoque);
            tpEstoque.Show();
        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpConsulta);
        }

        private void btnFuncionario_Click(object sender, EventArgs e)
        {
       
             tcControle.SelectTab(tpFucionario);
            //Cria a instância do formulário/controle
            cdFuncionarios = new CdFuncionarios();
            //  Define para preencher todo o espaço da aba
            cdFuncionarios.Dock = DockStyle.Fill;
            //  Limpa a aba antes para não colocar um controle em cima do outro
            tpFucionario.Controls.Clear();
            //  ADICIONA o objeto certo (cdFuncionarios)
            tpFucionario.Controls.Add(cdFuncionarios);
            //  Mostra o controle
            cdFuncionarios.Show();
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {
            MostrarSubMenu(panelMenuPedidos);
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpProduto);
            cdProduto = new CdProduto();
            cdProduto.Dock = DockStyle.Fill;
            tpProduto.Controls.Clear();
            tpProduto.Controls.Add(cdProduto);
            tpProduto.Show();
        }
        

        private void btnEnvio_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpEnvios);
            envio = new Envio();
            envio.Dock = DockStyle.Fill;
            tpEnvios.Controls.Clear();
            tpEnvios.Controls.Add(envio);
            tpEnvios.Show();
        }
           
        
        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpFornecedors);
            cdFornecedor = new CdFornecedor();
            cdFornecedor.Dock = DockStyle.Fill;
            tpFornecedors.Controls.Clear();
            tpFornecedors.Controls.Add(cdFornecedor);
            tpFornecedors.Show();
        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpInicio);
        }

        private void btnPedido_Click(object sender, EventArgs e)
        {
            tcControle.SelectTab(tpPedido);
            pedidos = new Pedidos();
            pedidos.Dock = DockStyle.Fill;
            tpPedido.Controls.Clear();
            tpPedido.Controls.Add(pedidos);
            tpPedido.Show();
        }
    }  
}
