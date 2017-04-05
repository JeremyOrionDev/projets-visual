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
    /// <summary>
    /// classe partielle de modifications client
    /// </summary>
    public  partial class frmUpdClient : frmNewClient
    {
        /// <summary>
        /// la réference du client pour lier les contacts
        /// </summary>
        new Int32 referenceClient;
        /// <summary>
        /// le client a modifier
        /// </summary>
        private Client leClient;
        /// <summary>
        /// charge le form Update client pour le client choisi
        /// </summary>
        /// <param name="unClient">le client dont on récupère les données</param>
        public frmUpdClient(Client unClient)
        {
            this.LeClient = unClient;
            InitializeComponent();
            afficheUnClient();           
            //le bouton ajout contact devient modifier contact
            btnAjouterContact.Text = "Modifier Contact";
            
        }
        /// <summary>
        /// fonction affichage client rempli les textBox avec les valeurs 
        /// correspondantes enregistrées dans la liste de clients
        /// </summary>
        private void afficheUnClient()
        {
            tBxIdClient.Text = LeClient.NumeroClient.ToString();
            tBxNomClient.Text = LeClient.NomClient.ToString();
            tBxClientRaisonSociale.Text = LeClient.ClientRaisonSociale;
            //en fonction du radiobouton selectionné le typeclient est choisi
            if (LeClient.TypeActivité == "privé") rbtnAjoutClientTypePrivé.Checked = true;
            if (LeClient.TypeActivité == "public") rBtnAjoutClientTypePublic.Checked = true;
            tbxDomaineActivité.Text = LeClient.ClientDomaineActivite;
            tBxAjoutClientAdresseNumero.Text = LeClient.AdresseClientNumeroRue.ToString();
            tBxAjoutClientAdresseTypeNom.Text = LeClient.AdresseClientRue;
            tBxAjoutClientAdresseVille.Text = LeClient.AdresseClientVille;
            //on vérifie que le code postal contient 5 charactères
            if (LeClient.AdresseClientCodePostal.ToString().Length == 5)
            {
                tBxAjoutClientAdresseCodePostal.Text = LeClient.AdresseClientCodePostal.ToString();
            }            
            else tBxAjoutClientAdresseCodePostal.Text = "0" + LeClient.AdresseClientCodePostal;
            cbxAjoutClientPays.SelectedItem = LeClient.AdresseClientPays;
            cBxClientTypeTelephone.SelectedItem = LeClient.ClientTypeTelephone;
            tBxClientEffectif.Text = LeClient.ClientEffectif.ToString();           
            tBxChiffreAffaire.Text = LeClient.ClientCA.ToString();
            this.tBxClientRaisonSociale.Text = LeClient.ClientRaisonSociale.ToString();
        }
        
        private void frmUpdClient_Load(object sender, EventArgs e)
        {

        }
        
        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            referenceClient = Convert.ToInt32(tBxIdClient.Text);

        }
        String mbText;

        public Client LeClient
        {
            get
            {
                return leClient;
            }

            set
            {
                leClient = value;
            }
        }

        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
             
            if (tBxAjoutClientAdresseCodePostal.Text != LeClient.AdresseClientCodePostal.ToString())
            {
               mbText  = "Le code postal " + "0"+ LeClient.AdresseClientCodePostal.ToString() + " devient --> " + tBxAjoutClientAdresseCodePostal.Text;
            }
            if (tBxAjoutClientAdresseNumero.Text!=LeClient.AdresseClientNumeroRue.ToString())
            {
                mbText += "\n" +" le numero de rue : " + LeClient.AdresseClientNumeroRue.ToString() + " devient --> " + tBxAjoutClientAdresseNumero.Text;
            }
            if (tBxAjoutClientAdresseVille.Text != LeClient.AdresseClientVille)
            {
                mbText += "\n" + " la ville : " + LeClient.AdresseClientVille + " devient --> " + tBxAjoutClientAdresseVille.Text;
            }
            if (tBxAjoutClientAdresseTypeNom.Text != LeClient.AdresseClientRue)
            {
                mbText += "\n" + " l'adresse  : " + LeClient.AdresseClientRue + " devient --> " + tBxAjoutClientAdresseTypeNom.Text;
            }
            if (tBxChiffreAffaire.Text != LeClient.ClientCA.ToString())
            {
                mbText += "\n" + " le Chiffre d'affaire : " + LeClient.ClientCA.ToString() + " devient --> " + tBxChiffreAffaire.Text;
            }
            if (tBxClientEffectif.Text != LeClient.ClientEffectif.ToString())
            {
                mbText += "\n" + " l'effectif : " + LeClient.ClientEffectif.ToString() + " devient --> " + tBxClientEffectif.Text;
            }
            if (tBxClientRaisonSociale.Text != LeClient.ClientRaisonSociale)
            {
                mbText += "\n" + " la raison sociale : " + LeClient.ClientRaisonSociale + " devient --> " + tBxClientRaisonSociale.Text;
            }
            if (tBxClientTelephone.Text != LeClient.ClientTelephoneNumero.ToString())
            {
                mbText += "\n" + " le telephone: " + LeClient.ClientTelephoneNumero.ToString() + " devient --> " + tBxClientTelephone.Text;
            }
            if (tbxDomaineActivité.Text != LeClient.ClientDomaineActivite)
            {
                mbText += "\n" + " le domaine d'activité : " + LeClient.ClientDomaineActivite.ToString() + " devient --> " + tbxDomaineActivité.Text;
            }
            if (tBxNature.Text != LeClient.ClientNature)
            {
                mbText += "\n" + " la nature du client : " + LeClient.ClientNature + " devient --> " + tBxNature.Text;
            }
            if (cbxAjoutClientPays.Text != LeClient.AdresseClientPays)
            {
                mbText += "\n" + " le pays : " + LeClient.AdresseClientPays + " devient --> " + cbxAjoutClientPays.Text;
            }


            MessageBox.Show("Validation des modifications éffectuées :" + "\n"+ mbText , "Valider ?", MessageBoxButtons.OKCancel);
            if (tBxAjoutClientAdresseCodePostal.Text != LeClient.AdresseClientCodePostal.ToString()) LeClient.AdresseClientCodePostal = Convert.ToInt32(tBxAjoutClientAdresseCodePostal.Text);
            if (DialogResult == DialogResult.OK)
            {
                LeClient.NumeroClient = Convert.ToInt32(tBxIdClient.Text);
                LeClient.AdresseClientCodePostal = Convert.ToInt32(tBxAjoutClientAdresseCodePostal.Text);
                LeClient.AdresseClientNumeroRue = Convert.ToInt32(tBxAjoutClientAdresseNumero.Text);
                LeClient.ClientTelephoneNumero = tBxClientTelephone.Text;
                LeClient.ClientEffectif = Convert.ToInt32(tBxClientEffectif.Text);
                LeClient.ClientCA = Convert.ToInt32(tBxChiffreAffaire.Text);
                LeClient.ClientRaisonSociale = tBxClientRaisonSociale.Text;
                if (rbtnAjoutClientTypePrivé.Checked)
                {
                    LeClient.TypeActivité = "privé";
                }
                if (rBtnAjoutClientTypePublic.Checked)
                {
                    LeClient.TypeActivité = "public";
                }
                LeClient.AdresseClientRue = tBxAjoutClientAdresseVille.Text;
                LeClient.AdresseClientPays = cbxAjoutClientPays.SelectedItem.ToString();
                LeClient.ClientNature = tBxNature.Text;
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

        private void btnAjoutClientAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
