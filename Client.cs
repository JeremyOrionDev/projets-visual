﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    public class Client
    {
        private Int32 numeroClient =0;
        private String nomClient;
        private String clientRaisonSociale;
        private String typeActivité;
        private String clientDomaineActivite;
        private String adresseClientNumeroRue;
        private String adresseClientRue;
        private Int32 adresseClientCodePostal;
        private String adresseClientVille;
        private String adresseClientPays;
        private String clientTypeTelephone;
        private String clientTelephoneNumero;
        private String clientCA;
        private int clientEffectif;
        private int idClient;
        private String clientCommentaire;
        private String clientNature;


        public Int32 NumeroClient
        {
            get
            {
                return numeroClient;
            }

            set
            {
                if(value!=0)
                {
                    numeroClient = value;
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("le numéro ne peut être vide", "Erreur Classe Client", System.Windows.Forms.MessageBoxButtons.OK);
                }
                
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

        public String AdresseClientNumeroRue
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

        public Int32 AdresseClientCodePostal
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

        public String ClientTelephoneNumero
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

        public String ClientCA
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

        public int IdClient
        {
            get
            {
                return idClient;
            }

            set
            {
                idClient = value;
            }
        }

        public string NomClient
        {
            get
            {
                return nomClient;
            }

            set
            {
                nomClient = value;
            }
        }
    }
}
