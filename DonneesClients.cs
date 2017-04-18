using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    public class DonneesClients
    {
        public static List<Client> ArrayStag = new List<Client>();
        public static Int32 NClient;
        
        public static DataSetABI DataSetClient = new DataSetABI() ;
        public static DataSetABITableAdapters.ClientBDDTableAdapter taClient = new DataSetABITableAdapters.ClientBDDTableAdapter();


    }
}
