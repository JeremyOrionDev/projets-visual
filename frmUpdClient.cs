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
        /// variable de texte pour la messageBox
        /// </summary>
        String mbText;
        
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
            this.leClient = unClient;
            InitializeComponent();
            afficheUnClient(leClient);           
            //le bouton ajout contact devient modifier contact
            btnAjouterContact.Text = "Modifier Contact";
            
        }
        /// <summary>
        /// fonction affichage client rempli les textBox avec les valeurs 
        /// correspondantes enregistrées dans la liste de clients
        /// </summary>
        private void afficheUnClient(Client leClient)
        {
            tBxClientTelephone.Text = leClient.ClientTelephoneNumero;
            tBxIdClient.Text = leClient.NumeroClient.ToString();
            tBxNomClient.Text = leClient.NomClient.ToString();
            tBxClientRaisonSociale.Text = leClient.ClientRaisonSociale;
            //en fonction du radiobouton selectionné le typeclient est choisi
            if (leClient.TypeActivité == "privé") rbtnAjoutClientTypePrivé.Checked = true;
            if (leClient.TypeActivité == "public") rBtnAjoutClientTypePublic.Checked = true;
            tbxDomaineActivité.Text = leClient.ClientDomaineActivite;
            tBxAjoutClientAdresseNumero.Text = leClient.AdresseClientNumeroRue.ToString();
            tBxAjoutClientAdresseTypeNom.Text = leClient.AdresseClientRue;
            tBxAjoutClientAdresseVille.Text = leClient.AdresseClientVille;
            //on vérifie que le code postal contient 5 charactères
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
            tBxNature.Text = leClient.ClientNature;
            tBxCommentaire.Text = leClient.ClientCommentaire;
        }
        
        private void frmUpdClient_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// On récupère l'idclient auquel on veut ajouter un contact
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            referenceClient =this.leClient.IdClient;

        }
        


        /// <summary>
        /// Ajoute le client dans la Liste de clients et l'affiche dans le form DspClient 
        /// après avoir validé tous les tests
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEnregistrer_Click_1(object sender, EventArgs e)
        {
            //on enregistre les modifications effectuées en rappelant la valeur avant et après modification
            if (Int32.Parse( tBxAjoutClientAdresseCodePostal.Text) != leClient.AdresseClientCodePostal)
            {
               mbText  = "Le code postal " + "0"+ leClient.AdresseClientCodePostal.ToString() + " devient --> " + tBxAjoutClientAdresseCodePostal.Text;
            }
            if (tBxAjoutClientAdresseNumero.Text!= leClient.AdresseClientNumeroRue.ToString())
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

            if (mbText != "") MessageBox.Show("Validation des modifications éffectuées :" + "\n" + mbText, "Valider ?", MessageBoxButtons.OKCancel);

            if (DialogResult == DialogResult.OK)
            {
                leClient.NumeroClient = Convert.ToInt32(tBxIdClient.Text);
                DonneesClients.DataSetClient.Tables[0].Rows[referenceClient].ItemArray[0]= Convert.ToInt32(tBxIdClient.Text);
                leClient.AdresseClientCodePostal = Convert.ToInt32(tBxAjoutClientAdresseCodePostal.Text);
                DonneesClients.DataSetClient.Tables[0].Rows[referenceClient].ItemArray[5] = tBxAjoutClientAdresseNumero.Text + tBxAjoutClientAdresseTypeNom.Text + tBxAjoutClientAdresseCodePostal.Text + tBxAjoutClientAdresseVille.Text;
                
                leClient.AdresseClientNumeroRue = tBxAjoutClientAdresseNumero.Text;
                leClient.ClientTelephoneNumero = tBxClientTelephone.Text;
                DonneesClients.DataSetClient.Tables[0].Rows[referenceClient].ItemArray[10]= Convert.ToInt32(tBxClientTelephone.Text);
                //DonneesClients.taClient.Update(referenceClient, DonneesClients.DataSetClient.Tables[0].Rows[referenceClient].ItemArray[5].ToString(),referenceClient, tBxClientTelephone.Text);
                leClient.ClientEffectif = Convert.ToInt32(tBxClientEffectif.Text);
                DonneesClients.DataSetClient.Tables[0].Rows[referenceClient].ItemArray[8] = Convert.ToInt32(tBxClientEffectif.Text);

                leClient.ClientCA = tBxChiffreAffaire.Text;
                DonneesClients.DataSetClient.Tables[0].Rows[referenceClient].ItemArray[7] = Convert.ToInt32(tBxChiffreAffaire.Text);

                leClient.ClientRaisonSociale = tBxClientRaisonSociale.Text;
                if (rbtnAjoutClientTypePrivé.Checked)
                {
                    leClient.TypeActivité = "privé";
                    DonneesClients.DataSetClient.Tables[0].Rows[referenceClient].ItemArray[3] = "privé";

                }
                if (rBtnAjoutClientTypePublic.Checked)
                {
                    leClient.TypeActivité = "public";
                    DonneesClients.DataSetClient.Tables[0].Rows[referenceClient].ItemArray[3]="public";

                }
                leClient.AdresseClientRue = tBxAjoutClientAdresseVille.Text;

                leClient.AdresseClientPays = cbxAjoutClientPays.SelectedItem.ToString();
                

                leClient.ClientNature = tBxNature.Text;
                
                DonneesClients.taClient.Update(DonneesClients.DataSetClient);
               // DonneesClients.taClient.Update(DonneesClients.DataSetClient.Tables[0].Rows[referenceClient]);
                DonneesClients.DataSetClient.ClientBDD.AcceptChanges();
                
                //DonneesClients.DataSetClient.
              
                
                this.DialogResult = DialogResult.OK;



            }
            else DialogResult = DialogResult.Cancel;
            this.Close();
        }


        /// <summary>
        /// Si on ne veut pas enregistrer les modifications
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutClientAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
