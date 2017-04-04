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
            gBxFicheContact.Enabled = false;
            //this.frmNewClientBtnEnregistrer.Visible = false;
            this.btnAjoutClientValider.Visible = true;
            this.cBxClientTypeTelephone.Items.AddRange(new String[]
                { "Société","Portable","Privé"});
            this.cbxAjoutClientPays.Items.AddRange(new String[]
                { "Afghanistan","Afrique du Sud","Albanie","Algérie","Allemagne","Andorre",
                    "Angola","Antigua et Barbuda","Arabie saoudite","Argentine","Arménie",
                    "Australie","Autriche","Azerbaïdjan","Bahamas","Bahrein","Bangladesh",
                    "Barbade","Belgique","Bélize","Benin","Bhoutan","Biélorussie","Bolivie",
                    "Bosnie-Herzégovine","Botswana","Brésil","Brunei","Bulgarie","Burkina Faso",
                    "Burundi","Cambodge","Cameroun","Canada","Cap Vert","Centrafrique","Chili",
                    "Chine","Chypre","Colombie","Comores","Congo démocratique","Congo","Corée du Nord",
                    "Corée du Sud","Costa Rica","Côte d'Ivoire","Croatie","Cuba","Danemark",
                    "Djibouti","Dominique","République Dominicaine","Egypte","Emirats Arabes Unis",
                    "Equateur","Erythrée","Espagne","Estonie","Etats-Unis","Ethiopie","Fidji","Finlande",
                    "France","Gabon","Gambie","Géorgie","Ghana","Grèce","Grenade","Groenland","Guatémala",
                    "Guinée","Guinée Bissau","Guinée équatoriale","Guyana","Haïti","Honduras","Hong Kong",
                    "Hongrie","Inde","Indonésie","Irak","Iran","Irlande","Islande","Israël","Italie",
                    "Jamaïque","Japon","Jordanie","Kazakhstan","Kenya","Kirghizstan","Kiribati","Koweït",
                    "Laos","Lesotho","Lettonie","Liban","Liberia","Libye","Liechtenstein","Lituanie",
                    "Luxembourg","Macédoine","Madagascar","Malaisie","Malawi","Maldives","Mali","Malte",
                    "Maroc","Marshall","Maurice","Mauritanie","Mexique","Micronésie","Moldavie","Monaco",
                    "Mongolie","Mozambique","Myanmar","Namibie","Népal","Nicaragua","Niger","Nigeria",
                    "Norvège","Nouvelle Zélande","Oman","Ouganda","Ouzbekistan","Pakistan","Palau",
                    "Palestine","Panama","Papouasie - Nouvelle Guinée","Paraguay","Pays-Bas","Pérou",
                    "Philippines","Pologne","Porto Rico","Portugal","Qatar","Roumanie","Royaume-Uni",
                    "Russie","Rwanda","Saint Christophe et Nevis","Saint Vincent et les Grenadines",
                    "Sainte Lucie","Salomon","Salvador","Samoa","São Tomé et Príncipe","Sénégal",
                    "Seychelles","Sierra Leone","Singapour","Slovaquie","Slovénie","Somalie",
                    "Somaliland","Soudan","Sri Lanka","Suède","Suisse","Surinam","Syrie","Swaziland",
                    "Tadjikistan","Taïwan","Tanzanie","Tchad","Tchéquie","Thaïlande","Tibet",
                    "Timor Oriental","Togo","Tonga","Trinité et Tobago","Tunisie","Turkmenistan",
                    "Turquie","Tuvalu","Ukraine","Uruguay","Vanuatu","Vatican","Vénézuéla","Vietnam",
                    "Yémen","Yougoslavie","Zambie","Zimbabwe" });
        }




        private void btnQuitter_Click(object sender, EventArgs e)
        {
           // this.DialogResult = DialogResult.Cancel;
            this.Close();
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

            if (tBxAjoutClientNumero.Text != "")
            {
                nouveauClient.NumeroClient = Int32.Parse(tBxAjoutClientNumero.Text.Trim());
            }
            else
            {
                MessageBox.Show("Attention le numero de client ne peut être vide", "Erreur Numero client", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(tBxClientRaisonSociale.Text!="")
            {
                nouveauClient.ClientRaisonSociale = tBxClientRaisonSociale.Text;
            }
            else
            {
                MessageBox.Show("Attention la raison sociale ne peut être vide", "Erreur Raison sociale", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if (rbtnAjoutClientTypePrivé.Checked)
            {
                nouveauClient.TypeActivité = "privé";
            }
            if (rBtnAjoutClientTypePublic.Checked)
            {
                nouveauClient.TypeActivité = "public";
            }
            if(!rbtnAjoutClientTypePrivé.Checked&&!rBtnAjoutClientTypePublic.Checked)
            {
                MessageBox.Show("Attention vous devez choisir le type de client à ajouter", "Erreur type client",  MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if (tbxDomaineActivité.Text != "")
            {
                nouveauClient.ClientDomaineActivite = tbxDomaineActivité.Text;
            }
            else
            {
                MessageBox.Show("Attention le domaine d'activité du client ne peut être vide", "Erreur domaine d'activité", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(tBxAjoutClientAdresseNumero.Text!="")
            {
                nouveauClient.AdresseClientNumeroRue = Int32.Parse(tBxAjoutClientAdresseNumero.Text.Trim());
            }
            else
            {
                MessageBox.Show("Attention le numéro de rue est vide", "Erreur Numéro de rue", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(tBxAjoutClientAdresseTypeNom.Text!="")
            {
                nouveauClient.AdresseClientRue = tBxAjoutClientAdresseTypeNom.Text;
            }
            else
            {
                MessageBox.Show("Attention le nom de la rue est vide", "Erreur de voie", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(tBxAjoutClientAdresseCodePostal.Text!="")
            {
                nouveauClient.AdresseClientCodePostal = Int32.Parse(tBxAjoutClientAdresseCodePostal.Text.Trim());
            }
            else
            {
                MessageBox.Show("Attention le code postal est vide", "Erreur Code Postal", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(tBxAjoutClientAdresseVille.Text!="")
            {
                nouveauClient.AdresseClientVille = tBxAjoutClientAdresseVille.Text;
            }
            else
            {
                MessageBox.Show("Attention la ville est vide", "Erreur de ville",  MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if (cbxAjoutClientPays.SelectedItem != null)
            {
                nouveauClient.AdresseClientPays = cbxAjoutClientPays.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Attention le pays n'a pas été selectionné", "Erreur Pays", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(cBxClientTypeTelephone.SelectedItem!=null)
            {
                nouveauClient.ClientTypeTelephone = cBxClientTypeTelephone.SelectedItem.ToString();
            }
            else
            {
                MessageBox.Show("Attention le type de téléphone n'a pas été selectionné", "Erreur Type téléphone", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(tBxClientTelephone.Text.ToString()!="")
            {
                nouveauClient.ClientTelephoneNumero = Int32.Parse(tBxClientTelephone.Text.Trim());
            }
            else
            {
                MessageBox.Show("Attention le numéro de téléphone est vide", "Erreur Type téléphone", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(tBxChiffreAffaire.Text.ToString()!="")
            {
                nouveauClient.ClientCA = Convert.ToDouble(tBxChiffreAffaire.Text.ToString());
            }
            else
            {
                MessageBox.Show("Attention le chiffre d'affaire est vide", "Erreur Chiffre d'affaire", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(tBxClientEffectif.Text.ToString()!="")
            {
                nouveauClient.ClientEffectif = Int32.Parse(tBxClientEffectif.Text.Trim());
            }
            else
            {
                MessageBox.Show("Attention l'effectif du client n'a pas été entré", "Erreur Effectif client", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            nouveauClient.ClientCommentaire = tBxCommentaire.Text;
            if(tBxNature.Text!="")
            {
            nouveauClient.ClientNature = tBxNature.Text;
            }
            else
            {
                MessageBox.Show("Attention la nature du client est vide", "Erreur nature client", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            DonneesClients.ArrayStag.Add(nouveauClient);
            DonneesClients.NClient++;
            this.DialogResult = DialogResult.OK;

        }

        private void tBxChiffreAffaire_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmNewClient_Load(object sender, EventArgs e)
        {

        }

        private void frmNewClientBtnAjoutContact_Click(object sender, EventArgs e)
        {
            gBxFicheContact.Enabled = true;
        }

        private void frmNewClientBtnEnregistrerContact_Click(object sender, EventArgs e)
        {
            Contacts nouveauContact = new Contacts();
            nouveauContact.ContactFonction = tBxFicheContactFonction.Text;
            nouveauContact.ContactNomPrenom = tBxFicheContactNomPrenom.Text;
            nouveauContact.ContactTelephonePortable = Int32.Parse(tBxFicheContactPortable.Text.Trim());
            nouveauContact.ContactTelephonePro = Int32.Parse(tBxFicheContactProfessionel.Text.Trim());
            nouveauContact.ContactNumeroClientLier = this.tBxAjoutClientNumero.Text;
            gBxFicheContact.Enabled = false;
        }
    }
}
