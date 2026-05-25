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
    public partial class EsControleEstoque : UserControl
    {
        public EsControleEstoque()
        {
            InitializeComponent();
            PRODUTOSTableAdapter ProdutoDados = new PRODUTOSTableAdapter();
            var dados = from linha in ProdutoDados.GetData()
                        select linha;
            foreach (PRODUTOSRow dado in dados) cboProdutos.Items.Add(dado);
        }

        private void lboEstoque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
