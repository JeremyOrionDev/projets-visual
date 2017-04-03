using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABI
{
    public class Projet
    {
        public Int32 codeProjet;
        public String libelleProjetCourt;
        public String libelleProjetLong;
        public String typeProjet;
        public String secteurActiviteprojet;
        public String etapeCycleProjet;
        public DateTime datePrevue;
        public DateTime dateReelle;
        public Int32 chargeInit;
        public Int32 chargeProduc;
        public Int32 chargeValid;
        public String remarqueProjet;
        public Int32 tailleEquipe;
        public String informationsProjet;
        public String collaborateursProjet;

        public int CodeProjet
        {
            get
            {
                return CodeProjet1;
            }

            set
            {
                CodeProjet1 = value;
            }
        }

        public int CodeProjet1
        {
            get
            {
                return codeProjet;
            }

            set
            {
                codeProjet = value;
            }
        }

        public string LibelleProjetCourt
        {
            get
            {
                return libelleProjetCourt;
            }

            set
            {
                libelleProjetCourt = value;
            }
        }

        public string LibelleProjetLong
        {
            get
            {
                return libelleProjetLong;
            }

            set
            {
                libelleProjetLong = value;
            }
        }

        public string TypeProjet
        {
            get
            {
                return typeProjet;
            }

            set
            {
                typeProjet = value;
            }
        }

        public string SecteurActiviteprojet
        {
            get
            {
                return secteurActiviteprojet;
            }

            set
            {
                secteurActiviteprojet = value;
            }
        }

        public string EtapeCycleProjet
        {
            get
            {
                return etapeCycleProjet;
            }

            set
            {
                etapeCycleProjet = value;
            }
        }

        public DateTime DatePrevue
        {
            get
            {
                return datePrevue;
            }

            set
            {
                datePrevue = value;
            }
        }

        public DateTime DateReelle
        {
            get
            {
                return dateReelle;
            }

            set
            {
                dateReelle = value;
            }
        }

        public int ChargeInit
        {
            get
            {
                return chargeInit;
            }

            set
            {
                chargeInit = value;
            }
        }

        public int ChargeProduc
        {
            get
            {
                return chargeProduc;
            }

            set
            {
                chargeProduc = value;
            }
        }

        public int ChargeValid
        {
            get
            {
                return chargeValid;
            }

            set
            {
                chargeValid = value;
            }
        }

        public string RemarqueProjet
        {
            get
            {
                return remarqueProjet;
            }

            set
            {
                remarqueProjet = value;
            }
        }

        public int TailleEquipe
        {
            get
            {
                return tailleEquipe;
            }

            set
            {
                tailleEquipe = value;
            }
        }

        public string InformationsProjet
        {
            get
            {
                return informationsProjet;
            }

            set
            {
                informationsProjet = value;
            }
        }

        public string CollaborateursProjet
        {
            get
            {
                return collaborateursProjet;
            }

            set
            {
                collaborateursProjet = value;
            }
        }
    }
}
