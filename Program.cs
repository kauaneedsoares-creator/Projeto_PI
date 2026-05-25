using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCapeCode
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int saida = 1;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login entrado = new Login();
            //entrado.saida = false;
            Application.Run(entrado);
           // if (entrado.saida)
            {
                entrado.Dispose();
                entrado.Close();
                Application.Run(new Form1());

            }
        }
    }
}
