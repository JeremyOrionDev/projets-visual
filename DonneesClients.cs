using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ABI.DataSetAbiTableAdapters;

namespace ABI
{
    public class DonneesClients
    {
        public static List<Client> ArrayClient = new List<Client>();
        public static Int32 NClient;
        public static DataSetAbi DataSetClient = new DataSetAbi();
        public static Int32 nbreClient = 0;
        
        public static ClientBDDTableAdapter taClient = new ClientBDDTableAdapter();


    }
}
