using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    public class Client
    {
        private static Int32 nClient;
        private Int32 numeroClient;
        private String clientRaisonSociale;
        private String typeActivité;
        private String clientDomaineActivite;
        private Int32 adresseClientNumeroRue;
        private String adresseClientRue;
        private Int32 adresseClientCodePostal;
        private String adresseClientVille;
        private String adresseClientPays;
        private String clientTypeTelephone;
        private Int32 clientTelephoneNumero;
        private Int32 clientCA;
        private Int32 clientEffectif;
        private String contactnomPrenom;
        private String contactFonction;
        private Int32 contactTelephonePro;
        private Int32 contactTelephonePortable;
        private String clientCommentaire;
        private String clientNature;


        public int NumeroClient
        {
            get
            {
                return numeroClient;
            }

            set
            {
                numeroClient = value;
            }
        }

        public string ClientRaisonSociale
        {
            get
            {
                return clientRaisonSociale;
            }

            set
            {
                clientRaisonSociale = value;
            }
        }

        public string TypeActivité
        {
            get
            {
                return typeActivité;
            }

            set
            {
                typeActivité = value;
            }
        }

        public string ClientDomaineActivite
        {
            get
            {
                return clientDomaineActivite;
            }

            set
            {
                clientDomaineActivite = value;
            }
        }

        public int AdresseClientNumeroRue
        {
            get
            {
                return adresseClientNumeroRue;
            }

            set
            {
                adresseClientNumeroRue = value;
            }
        }

        public string AdresseClientRue
        {
            get
            {
                return adresseClientRue;
            }

            set
            {
                adresseClientRue = value;
            }
        }

        public int AdresseClientCodePostal
        {
            get
            {
                return adresseClientCodePostal;
            }

            set
            {
                adresseClientCodePostal = value;
            }
        }

        public string AdresseClientVille
        {
            get
            {
                return adresseClientVille;
            }

            set
            {
                adresseClientVille = value;
            }
        }

        public string AdresseClientPays
        {
            get
            {
                return adresseClientPays;
            }

            set
            {
                adresseClientPays = value;
            }
        }

        public string ClientTypeTelephone
        {
            get
            {
                return clientTypeTelephone;
            }

            set
            {
                clientTypeTelephone = value;
            }
        }

        public int ClientTelephoneNumero
        {
            get
            {
                return clientTelephoneNumero;
            }

            set
            {
                clientTelephoneNumero = value;
            }
        }

        public int ClientCA
        {
            get
            {
                return clientCA;
            }

            set
            {
                clientCA = value;
            }
        }

        public int ClientEffectif
        {
            get
            {
                return clientEffectif;
            }

            set
            {
                clientEffectif = value;
            }
        }

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

        public int ContactTelephonePro
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

        public int ContactTelephonePortable
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

        public string ClientCommentaire
        {
            get
            {
                return clientCommentaire;
            }

            set
            {
                clientCommentaire = value;
            }
        }

        public string ClientNature
        {
            get
            {
                return clientNature;
            }

            set
            {
                clientNature = value;
            }
        }

    }
}
