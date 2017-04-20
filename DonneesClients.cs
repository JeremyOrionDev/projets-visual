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
        /// <summary>
        /// Collection de Clients
        /// </summary>
        public static List<Client> ArrayClient = new List<Client>();
        public static Int32 NClient;
        /// <summary>
        /// Creation du DataSet pour les clients
        /// </summary>
        public static DataSetAbi DataSetClient = new DataSetAbi();
        public static Int32 nbreClient = 0;
        /// <summary>
        /// Création de la tableAdapter liée au client
        /// </summary>
        public static ClientBDDTableAdapter taClient = new ClientBDDTableAdapter();


    }
}
