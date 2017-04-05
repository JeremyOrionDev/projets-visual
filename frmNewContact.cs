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
       // frmUpdClient is Par
        public frmNewContact()
        {
            InitializeComponent();
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
            dt.Columns.Add(new DataColumn("Téléphone portable", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Téléphone pro", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Client référent", typeof(String)));
            for(i=0;i< ListContact.ArrayStag.Count;i++)
            {
                String ClientTrouvé;
                dr = dt.NewRow();
                dr[0] = ListContact.ArrayStag[i].ContactNomPrenom;
                dr[1] = ListContact.ArrayStag[i].ContactFonction;
                dr[2] = ListContact.ArrayStag[i].ContactTelephonePortable;
                dr[3] = ListContact.ArrayStag[i].ContactTelephonePro;
                int c = ListContact.ArrayStag[i].IClient;
                for(i=0;i<DonneesClients.ArrayStag.Count;i++)
                {
                    if(DonneesClients.ArrayStag[i].NumeroClient==c)
                    { dr[4] = DonneesClients.ArrayStag[i].NomClient; }
                }
                
               // dr[4] = DonneesClients.ArrayStag[ListContact.ArrayStag[i].IClient].NomClient;
                dt.Rows.Add(dr);
            }
            dGvContact.DataSource = dt;
            
        }
        
        private void contactAfficherTest()
        {
            Contact testContact = new Contact();
            testContact.ContactFonction = "aucune";
            testContact.ContactNomPrenom = "Nom prenom";
            testContact.ContactTelephonePortable = 066885621;
            testContact.ContactTelephonePro = 054854251;
            testContact.IClient = 1;
            ListContact.ArrayStag.Add(testContact);
            ListContact.nContact++;
            Contact testContact2 = new Contact();
            testContact2.ContactFonction = "test";
            testContact2.ContactNomPrenom = "test";
            testContact2.ContactTelephonePortable = 06;
            testContact2.ContactTelephonePro = 04;
            testContact2.IClient = 2;
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

            nouveauContact.ContactFonction = tBxFicheContactFonction.Text;
            nouveauContact.ContactNomPrenom = tBxFicheContactNomPrenom.Text;
            nouveauContact.ContactTelephonePortable = Int32.Parse(tBxFicheContactPortable.Text.Trim());
            nouveauContact.ContactTelephonePro = Int32.Parse(tBxFicheContactProfessionel.Text.Trim());
            nouveauContact.IClient=Parent.Container
            gBxFicheContact.Enabled = false;
            ListContact.ArrayStag.Add(nouveauContact);
            ListContact.nContact++;
            this.DialogResult = DialogResult.OK;
            afficheContact();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {

        }

        private void frmNewClientSupprimerContact_Click(object sender, EventArgs e)
        {
            
            ListContact.ArrayStag.RemoveAt(dGvContact.CurrentRow.Index);
            afficheContact();
        }
    }
}

