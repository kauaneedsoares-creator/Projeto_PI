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
    public partial class Login : Form
    {
        public bool saida;
        public Login()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            {
                byte[] senhaBytes = System.Text.Encoding.UTF8.GetBytes(txtSenha.Text);
                VerificarAcessoTableAdapter consuta = new VerificarAcessoTableAdapter ();
                var usuario = (from linha in consuta.GetData(txtEmail.Text, senhaBytes)
                                select linha).FirstOrDefault();
                if (usuario == null)
                {
                   MessageBox.Show("O login esta errado ou não existe. \nVericar com o suporte");
                   return; 
                }
                saida = true;
                Close();
            }
        }

        
    }
}
