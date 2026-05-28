using ProjetoCapeCode.Projeto_IntegradorDataSetTableAdapters;

namespace ProjetoCapeCode
{


    partial class Projeto_IntegradorDataSet
    {
        partial class FUNCIONARIOSRow
        {
            public override string ToString()
            {
                return nome.ToString();
            }
        }
        partial class PRODUTOSRow
        {
            public override string ToString()
            {
                return nome.ToString();
            }
        }

        partial class FORNECEDORESRow
        {
            public override string ToString()
            {
                return nome_fornecedor.ToString();
            }
        }

        partial class ENVIODataTable
        {
            public override string ToString()
            {
                return ID_EnvioColumn.ToString();
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

namespace ProjetoCapeCode.Projeto_IntegradorDataSetTableAdapters {
    
    
    public partial class ITENS_PEDIDOTableAdapter {
    }
}
