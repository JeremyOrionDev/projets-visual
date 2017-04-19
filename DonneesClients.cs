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
        public SqlDataAdapter ClientSqlAdapt = new SqlDataAdapter();
        public static ABI.DataSetABI DataSetClient = new DataSetABI();
        
        public static ABI.DataSetABITableAdapters.ClientBDDTableAdapter taClient = new DataSetABITableAdapters.ClientBDDTableAdapter();


    }
}
