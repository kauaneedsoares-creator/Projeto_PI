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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            {
                //verificarAcessoTableAdapter consuta = new verificarAcessoTableAdapter();
                // var usuario = (from linha in consuta.GetData(txtEmail.Text, txtSenha.Text)
                //                select linha).FirstOrDefault();
              //  if (usuario == null)
                {
                    //MessageBox.Show("O login esta errado ou não existe. \nVericar com o suporte");
                    //return; 
                }
               // saida = true;
                Close();
            }
        }

        
    }
}
