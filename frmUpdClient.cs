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
    public partial class frmUpdClient : frmNewClient
    {
        //private
        private Client leClient;
        public frmUpdClient(Client unClient)
        {
            this.leClient = unClient;
            InitializeComponent();
            afficheUnClient();
            this.btnAjoutClientValider.Visible = false;
            this.btnAjouterContact.Text = "Modifier Contact";
            
        }
        private void afficheUnClient()
        {
            tBxIdClient.Text = leClient.NumeroClient.ToString();
            tBxNomClient.Text = leClient.NomClient.ToString();
            tBxClientRaisonSociale.Text = leClient.ClientRaisonSociale;
            if (leClient.TypeActivité == "privé") rbtnAjoutClientTypePrivé.Checked = true;
            if (leClient.TypeActivité == "public") rBtnAjoutClientTypePublic.Checked = true;
            tbxDomaineActivité.Text = leClient.ClientDomaineActivite;
            tBxAjoutClientAdresseNumero.Text = leClient.AdresseClientNumeroRue.ToString();
            tBxAjoutClientAdresseTypeNom.Text = leClient.AdresseClientRue;
            tBxAjoutClientAdresseVille.Text = leClient.AdresseClientVille;
            if (leClient.AdresseClientCodePostal.ToString().Length == 5)
            {
                tBxAjoutClientAdresseCodePostal.Text = leClient.AdresseClientCodePostal.ToString();
            }
            else tBxAjoutClientAdresseCodePostal.Text = "0" + leClient.AdresseClientCodePostal;
            cbxAjoutClientPays.SelectedItem = leClient.AdresseClientPays;
            cBxClientTypeTelephone.SelectedItem = leClient.ClientTypeTelephone;
            tBxClientEffectif.Text = leClient.ClientEffectif.ToString();
           
            tBxChiffreAffaire.Text = leClient.ClientCA.ToString();



            this.tBxClientRaisonSociale.Text = leClient.ClientRaisonSociale.ToString();
        }


        

        
        private void frmUpdClient_Load(object sender, EventArgs e)
        {

        }

        String mbText;
        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
             
            if (tBxAjoutClientAdresseCodePostal.Text != leClient.AdresseClientCodePostal.ToString())
            {
               mbText  = "Le code postal " + "0"+ leClient.AdresseClientCodePostal.ToString() + " devient --> " + tBxAjoutClientAdresseCodePostal.Text;
            }
            if (tBxAjoutClientAdresseNumero.Text!=leClient.AdresseClientNumeroRue.ToString())
            {
                mbText += "\n" +" le numero de rue : " + leClient.AdresseClientNumeroRue.ToString() + " devient --> " + tBxAjoutClientAdresseNumero.Text;
            }
            if (tBxAjoutClientAdresseVille.Text != leClient.AdresseClientVille)
            {
                mbText += "\n" + " la ville : " + leClient.AdresseClientVille + " devient --> " + tBxAjoutClientAdresseVille.Text;
            }
            if (tBxAjoutClientAdresseTypeNom.Text != leClient.AdresseClientRue)
            {
                mbText += "\n" + " l'adresse  : " + leClient.AdresseClientRue + " devient --> " + tBxAjoutClientAdresseTypeNom.Text;
            }
            if (tBxChiffreAffaire.Text != leClient.ClientCA.ToString())
            {
                mbText += "\n" + " le Chiffre d'affaire : " + leClient.ClientCA.ToString() + " devient --> " + tBxChiffreAffaire.Text;
            }
            if (tBxClientEffectif.Text != leClient.ClientEffectif.ToString())
            {
                mbText += "\n" + " l'effectif : " + leClient.ClientEffectif.ToString() + " devient --> " + tBxClientEffectif.Text;
            }
            if (tBxClientRaisonSociale.Text != leClient.ClientRaisonSociale)
            {
                mbText += "\n" + " la raison sociale : " + leClient.ClientRaisonSociale + " devient --> " + tBxClientRaisonSociale.Text;
            }
            if (tBxClientTelephone.Text != leClient.ClientTelephoneNumero.ToString())
            {
                mbText += "\n" + " le telephone: " + leClient.ClientTelephoneNumero.ToString() + " devient --> " + tBxClientTelephone.Text;
            }
            if (tbxDomaineActivité.Text != leClient.ClientDomaineActivite)
            {
                mbText += "\n" + " le domaine d'activité : " + leClient.ClientDomaineActivite.ToString() + " devient --> " + tbxDomaineActivité.Text;
            }
            if (tBxNature.Text != leClient.ClientNature)
            {
                mbText += "\n" + " la nature du client : " + leClient.ClientNature + " devient --> " + tBxNature.Text;
            }
            if (cbxAjoutClientPays.Text != leClient.AdresseClientPays)
            {
                mbText += "\n" + " le pays : " + leClient.AdresseClientPays + " devient --> " + cbxAjoutClientPays.Text;
            }


            MessageBox.Show("Validation des modifications éffectuées :" + "\n"+ mbText , "Valider ?", MessageBoxButtons.OKCancel);
            if (tBxAjoutClientAdresseCodePostal.Text != leClient.AdresseClientCodePostal.ToString()) leClient.AdresseClientCodePostal = Convert.ToInt32(tBxAjoutClientAdresseCodePostal.Text);
            if (DialogResult == DialogResult.OK)
            {
                leClient.NumeroClient = Convert.ToInt32(tBxIdClient.Text);
                leClient.AdresseClientCodePostal = Convert.ToInt32(tBxAjoutClientAdresseCodePostal.Text);
                leClient.AdresseClientNumeroRue = Convert.ToInt32(tBxAjoutClientAdresseNumero.Text);
                leClient.ClientTelephoneNumero = Convert.ToInt32(tBxClientTelephone.Text);
                leClient.ClientEffectif = Convert.ToInt32(tBxClientEffectif.Text);
                leClient.ClientCA = Convert.ToInt32(tBxChiffreAffaire.Text);
                leClient.ClientRaisonSociale = tBxClientRaisonSociale.Text;
                if (rbtnAjoutClientTypePrivé.Checked)
                {
                    leClient.TypeActivité = "privé";
                }
                if (rBtnAjoutClientTypePublic.Checked)
                {
                    leClient.TypeActivité = "public";
                }
                leClient.AdresseClientRue = tBxAjoutClientAdresseVille.Text;
                leClient.AdresseClientPays = cbxAjoutClientPays.SelectedItem.ToString();
                leClient.ClientNature = tBxNature.Text;
                //frmDspClient.dg
                //this.Close();

            }
            else DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void btnAjoutClientValider_Click(object sender, EventArgs e)
        {

        }


    }
}
