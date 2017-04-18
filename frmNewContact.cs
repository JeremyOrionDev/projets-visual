using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI
{
    public partial class frmNewContact : Form
    {
        private frmNewClient parent;
        
        private Int32 Iclient;
        private String mbText;

        public int Iclient1
        {
            get
            {
                return Iclient;
            }

            set
            {
                Iclient = value;
            }
        }

        public frmNewContact(frmNewClient parent)
        {
            InitializeComponent();
            this.parent = parent;
            btnImportContact.Visible = false;
            Iclient1 = parent.referenceClient;
            gBxFicheContact.Enabled = false;
            contactAfficherTest();
            afficheContact();
        }
        public void afficheContact()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            Int32 i;
            dt.Columns.Add(new DataColumn("Nom prénom", typeof(String)));
            dt.Columns.Add(new DataColumn("Fonction ", typeof(String)));
            dt.Columns.Add(new DataColumn("Téléphone portable", typeof(String)));
            dt.Columns.Add(new DataColumn("Téléphone pro", typeof(String)));
            dt.Columns.Add(new DataColumn("Client référent", typeof(String)));
            for(i=0;i< ListContact.ArrayStag.Count;i++)
            {
                dr = dt.NewRow();
                dr[0] = ListContact.ArrayStag[i].ContactNomPrenom;
                dr[1] = ListContact.ArrayStag[i].ContactFonction;
                dr[2] = ListContact.ArrayStag[i].ContactTelephonePortable;
                dr[3] = ListContact.ArrayStag[i].ContactTelephonePro;
                dr[4] = DonneesClients.ArrayClient[Iclient1].NomClient;
                dt.Rows.Add(dr);
            }
            dGvContact.DataSource = dt;
            
        }
        
        private void contactAfficherTest()
        {
            Contact testContact = new Contact();
            testContact.ContactFonction = "aucune";
            testContact.ContactNomPrenom = "Nom prenom";
            testContact.ContactTelephonePortable = "066885621";
            testContact.ContactTelephonePro = "054854251";
            testContact.IClient =  Iclient1;
            ListContact.ArrayStag.Add(testContact);
            ListContact.nContact++;
            Contact testContact2 = new Contact();
            testContact2.ContactFonction = "test";
            testContact2.ContactNomPrenom = "test";
            testContact2.ContactTelephonePortable = "06";
            testContact2.ContactTelephonePro = "04";
            testContact2.IClient = Iclient1;
            ListContact.ArrayStag.Add(testContact2);
            ListContact.nContact++;
        }


        private void btnNouveauContact_Click(object sender, EventArgs e)
        {
            gBxFicheContact.Enabled = true;
            
        }
        
        private void frmNewClientBtnEnregistrerContact_Click(object sender, EventArgs e)
        {
            Contact nouveauContact = new Contact();
        
            if(tBxFicheContactPortable.Text.Length==10)
            {
                nouveauContact.ContactTelephonePortable = tBxFicheContactPortable.Text;
            }
            else
            {
                mbText += "Attention le numero de Portable doit avoir 10 chiffres pas plus pas moins \n ";
            }
            if(tBxFicheContactFonction.Text!="")
            {
                nouveauContact.ContactFonction = tBxFicheContactFonction.Text;
            }
            else
            {
                mbText += "Attention la fonction de votre contact est vide";
            }
            if(tBxFicheContactNomPrenom.Text!="")
            {
                nouveauContact.ContactNomPrenom = tBxFicheContactNomPrenom.Text;
            }
            else
            {
                mbText = "Attention le Nom et Prénom de votre contact est vide";

            }
            if(tBxFicheContactProfessionel.Text!="")
            {
                nouveauContact.ContactTelephonePro = tBxFicheContactProfessionel.Text;
            }
            if(mbText==null)
            {
                nouveauContact.IClient =Iclient1;
                gBxFicheContact.Enabled = false;
                ListContact.ArrayStag.Add(nouveauContact);
                ListContact.nContact++;
                //this.DialogResult = DialogResult.OK;
                afficheContact();
            }
            else
            {
                MessageBox.Show(mbText, "Erreur dans le formulaire contact", MessageBoxButtons.OK);

            }
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void frmNewClientSupprimerContact_Click(object sender, EventArgs e)
        {
            
            ListContact.ArrayStag.RemoveAt(dGvContact.CurrentRow.Index);
            afficheContact();
        }
        
        
        private void btnImportContact_Click(object sender, EventArgs e)
        {
            ImportContact IC;
            IC = new ImportContact(this);
            IC.Show();

        }
    }
}

