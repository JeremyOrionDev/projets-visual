using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    class ListProjets
    {
        public static List<Projet> ArrayStag = new List<Projet>();
        public static Int32 iProjet;
        public static DataSetABI DataSetProjet = new DataSetABI();
        public static DataSetABITableAdapters.ProjetBDTableAdapter taProjet = new DataSetABITableAdapters.ProjetBDTableAdapter();
    }
}
