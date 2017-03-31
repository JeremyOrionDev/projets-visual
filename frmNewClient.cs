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
    public partial class frmNewClient : Form
    {
        public frmNewClient()
        {
            InitializeComponent();
            
        }

      

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void rbtnPublic_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }



        private void rbtnPrivé_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblRaisonSociale_Click(object sender, EventArgs e)
        {

        }

        private void tbxDomaineActivité_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxAdresse_Enter(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void btnParcourir_Click(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest_1(object sender, EventArgs e)
        {

        }

        private void tBxNumero_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            Client nouveauClient = new Client();

            nouveauClient.NumeroClient = Int32.Parse(tBxAjoutClientNumero.Text.Trim());
            nouveauClient.AdresseClientCodePostal = Int32.Parse(tBxAjoutClientAdresseCodePostal.Text.Trim());
            nouveauClient.AdresseClientNumeroRue = Int32.Parse(tBxAjoutClientAdresseNumero.Text.Trim());
            nouveauClient.ClientCA = Int32.Parse(tBxChiffreAffaire.Text.Trim());
            nouveauClient.ClientTelephoneNumero = Int32.Parse(tBxClientTelephone.Text.Trim());
            nouveauClient.ClientEffectif = Int32.Parse(tBxClientEffectif.Text.Trim());
            nouveauClient.AdresseClientRue = tBxAjoutClientAdresseTypeNom.Text;
            nouveauClient.AdresseClientVille = tBxAjoutClientAdresseVille.Text;
            nouveauClient.ClientCommentaire = tBxCommentaire.Text;
            nouveauClient.ContactFonction = tBxFicheContactFonction.Text;
            nouveauClient.ContactNomPrenom = tBxFicheContactNomPrenom.Text;
            nouveauClient.ContactTelephonePortable = Int32.Parse(tBxFicheContactPortable.Text.Trim());
            nouveauClient.ContactTelephonePro = Int32.Parse(tBxFicheContactProfessionel.Text.Trim());
            nouveauClient.ClientNature = tBxNature.Text;
            if (rbtnAjoutClientTypePrivé.Checked)
            {
            nouveauClient.TypeActivité = "privé";
            }
            if(rBtnAjoutClientTypePublic.Checked)
            {
                nouveauClient.TypeActivité = "public";
            }
            nouveauClient.ClientRaisonSociale = tBxClientRaisonSociale.Text;
            DonneesClients.ArrayStag.Add(nouveauClient);
            DonneesClients.NClient += 1;
            this.DialogResult = DialogResult.OK;

        }

        private void tBxChiffreAffaire_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
