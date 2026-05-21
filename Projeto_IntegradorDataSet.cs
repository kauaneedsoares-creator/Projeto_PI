using ProjetoCapeCode.Projeto_IntegradorDataSetTableAdapters;
using System.Linq;


namespace ProjetoCapeCode
{


    partial class Projeto_IntegradorDataSet
    {
        partial class ENVIODataTable
        {
        }

        partial class ENVIORow
        {
            public override string ToString()
            {
                return ID_Funcionario.ToString();
            }
        }

        partial class FUNCIONARIOSRow
        {
            public override string ToString()
            {
                return nome.ToString();
            }
        }

        partial class CLIENTESRow
        {
            public override string ToString()
            {
                return nome.ToString();
            }
        }

        partial class PEDIDOSRow
        {
            public override string ToString()
            {
                return ID_Pedido.ToString();
            }
        }
    }
}


