using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    class ListContact
    {
        
        public static List<Contact> ArrayStag = new List<Contact>();
        public static Int32 nContact;
        public static DataSetABI DataSetContact = new DataSetABI();
        public static DataSetABITableAdapters.ContactsBDDTableAdapter taContact = new DataSetABITableAdapters.ContactsBDDTableAdapter();
    }
}
