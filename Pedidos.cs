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
    }
}
