using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ABI.DataSetAbi;

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
        private ClientBDDRow leClient;
        
        /// <summary>
        /// charge le form Update client pour le client choisi
        /// </summary>
        /// <param name="unClient">le client dont on récupère les données</param>
        public frmUpdClient(ClientBDDRow client)
        {
            this.leClient = client;
            InitializeComponent();
            afficheUnClient(leClient);           
            //le bouton ajout contact devient modifier contact
            btnAjouterContact.Text = "Modifier Contact";
            
        }
        /// <summary>
        /// fonction affichage client rempli les textBox avec les valeurs 
        /// correspondantes enregistrées dans la liste de clients
        /// </summary>
        private void afficheUnClient(ClientBDDRow leClient)
        {
            tBxClientTelephone.Text = leClient.numero_telephone.ToString();
            tBxIdClient.Text = leClient.idClient.ToString();
            tBxNomClient.Text = leClient.nom;
            tBxClientRaisonSociale.Text = leClient.raison_sociale;
            if (leClient._type_d_activité == "privé") rbtnAjoutClientTypePrivé.Checked = true;
            if (leClient._type_d_activité == "public") rBtnAjoutClientTypePublic.Checked = true;
            tbxDomaineActivité.Text = leClient._domaine_d_activité;
            tBxAjoutClientAdresseNumero.Text = leClient.adresse_numéro.ToString();
            tBxAjoutClientAdresseTypeNom.Text = leClient.adresse_rue;
            tBxAjoutClientAdresseVille.Text = leClient.adresse_ville;
            tBxAjoutClientAdresseCodePostal.Text = leClient.adresse_code_postal;
            cbxAjoutClientPays.SelectedItem = leClient.adresse_pays;
            cBxClientTypeTelephone.SelectedItem = leClient.type_tel;
            tBxClientEffectif.Text = leClient.effectif.ToString();
            tBxChiffreAffaire.Text = leClient._chiffre_d_affaire.ToString();
            this.tBxClientRaisonSociale.Text = leClient.raison_sociale.ToString();
            tBxNature.Text = leClient.nature;
            tBxCommentaire.Text = leClient.Commentaires;
        }
        public int indexRow;
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
            referenceClient =this.leClient.idClient;

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
            if (tBxAjoutClientAdresseCodePostal.Text != leClient.adresse_code_postal)
            {
                mbText = "Le code postal " + "0" + leClient.adresse_code_postal.ToString() + " devient --> " + tBxAjoutClientAdresseCodePostal.Text;
            }
            if (tBxAjoutClientAdresseNumero.Text != leClient.adresse_numéro)
            {
                mbText += "\n" + " le numero de rue : " + leClient.adresse_numéro + " devient --> " + tBxAjoutClientAdresseNumero.Text;
            }
            if (tBxAjoutClientAdresseVille.Text != leClient.adresse_ville)
            {
                mbText += "\n" + " la ville : " + leClient.adresse_ville + " devient --> " + tBxAjoutClientAdresseVille.Text;
            }
            if (tBxAjoutClientAdresseTypeNom.Text != leClient.adresse_rue)
            {
                mbText += "\n" + " l'adresse  : " + leClient.adresse_rue + " devient --> " + tBxAjoutClientAdresseTypeNom.Text;
            }
            if (tBxChiffreAffaire.Text != leClient._chiffre_d_affaire.ToString())
            {
                mbText += "\n" + " le Chiffre d'affaire : " + leClient._chiffre_d_affaire.ToString() + " devient --> " + tBxChiffreAffaire.Text;
            }
            if (tBxClientEffectif.Text != leClient.effectif.ToString())
            {
                mbText += "\n" + " l'effectif : " + leClient.effectif.ToString() + " devient --> " + tBxClientEffectif.Text;
            }
            if (tBxClientRaisonSociale.Text != leClient.raison_sociale)
            {
                mbText += "\n" + " la raison sociale : " + leClient.raison_sociale + " devient --> " + tBxClientRaisonSociale.Text;
            }
            if (tBxClientTelephone.Text != leClient.numero_telephone.ToString())
            {
                mbText += "\n" + " le telephone: " + leClient.numero_telephone.ToString() + " devient --> " + tBxClientTelephone.Text;
            }
            if (tbxDomaineActivité.Text != leClient._domaine_d_activité)
            {
                mbText += "\n" + " le domaine d'activité : " + leClient._domaine_d_activité + " devient --> " + tbxDomaineActivité.Text;
            }
            if (tBxNature.Text != leClient.nature)
            {
                mbText += "\n" + " la nature du client : " + leClient.nature + " devient --> " + tBxNature.Text;
            }
            if (cbxAjoutClientPays.Text != leClient.adresse_pays)
            {
                mbText += "\n" + " le pays : " + leClient.adresse_pays + " devient --> " + cbxAjoutClientPays.Text;
            }

            if (mbText != "") MessageBox.Show("Validation des modifications éffectuées :" + "\n" + mbText, "Valider ?", MessageBoxButtons.OKCancel);

            if (DialogResult == DialogResult.OK)
            {

                leClient.adresse_code_postal = tBxAjoutClientAdresseCodePostal.Text;
                leClient.nom = tBxNomClient.Text;
                leClient._domaine_d_activité = tbxDomaineActivité.Text;
                leClient.adresse_numéro = tBxAjoutClientAdresseNumero.Text;
                int tel;
                Boolean b = Int32.TryParse(tBxClientTelephone.Text, out tel);
                if (b)
                {
                    leClient.numero_telephone = tel;
                }
                leClient.type_tel = cBxClientTypeTelephone.SelectedText;
                int eff;
                b = Int32.TryParse(tBxClientEffectif.Text, out eff);
                if (b)
                {
                    leClient.effectif = eff;
                }
                
                leClient._chiffre_d_affaire = tBxChiffreAffaire.Text;
                leClient.raison_sociale = tBxClientRaisonSociale.Text;
                if (rbtnAjoutClientTypePrivé.Checked)
                {
                    leClient._type_d_activité = "privé";
                }
                if (rBtnAjoutClientTypePublic.Checked)
                {
                    leClient._type_d_activité = "public";

                }
                leClient.adresse_ville = tBxAjoutClientAdresseVille.Text;
                leClient.adresse_rue = tBxAjoutClientAdresseTypeNom.Text;
                leClient.adresse_pays = cbxAjoutClientPays.SelectedItem.ToString();
                leClient.Commentaires = tBxCommentaire.Text;
                leClient.nature = tBxNature.Text;

                DonneesClients.taClient.Update(DonneesClients.DataSetClient.ClientBDD);
                this.DialogResult = DialogResult.OK;
            }
            else DialogResult = DialogResult.Cancel;
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
