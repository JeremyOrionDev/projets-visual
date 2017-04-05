using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    class Contact
    {
        
        
        private String contactnomPrenom;
        private String contactFonction;
        private String contactTelephonePro;
        private String contactTelephonePortable;
        private String contactNumeroClientLier;
        private Int32 iClient;
        
        public string ContactNomPrenom
        {
            get
            {
                return contactnomPrenom;
            }

            set
            {
                contactnomPrenom = value;
            }
        }

        public string ContactFonction
        {
            get
            {
                return contactFonction;
            }

            set
            {
                contactFonction = value;
            }
        }

        public String ContactTelephonePro
        {
            get
            {
                return contactTelephonePro;
            }

            set
            {
                contactTelephonePro = value;
            }
        }

        public String ContactTelephonePortable
        {
            get
            {
                return contactTelephonePortable;
            }

            set
            {
                contactTelephonePortable = value;
            }
        }

        public string ContactNumeroClientLier
        {
            get
            {
                return contactNumeroClientLier;
            }

            set
            {
                contactNumeroClientLier = value;
            }
        }

        public  int IClient
        {
            get
            {
                return iClient;
            }

            set
            {
                iClient = value;
            }
        }
    }
}
