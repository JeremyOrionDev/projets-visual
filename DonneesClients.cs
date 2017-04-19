using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ABI
{
    public class DonneesClients
    {
        public static List<Client> ArrayClient = new List<Client>();
        public static Int32 NClient;
        public static ABI.DataSetAbi DataSetClient = new DataSetAbi();
        
        public static ABI.DataSetAbiTableAdapters.ClientBDDTableAdapter taClient = new DataSetAbiTableAdapters.ClientBDDTableAdapter();


    }
}
