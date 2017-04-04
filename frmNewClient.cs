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
                MessageBox.Show("Erreur Numero client", "Attention le numero de client ne peut être vide", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(tBxClientRaisonSociale.Text!="")
            {
                nouveauClient.ClientRaisonSociale = tBxClientRaisonSociale.Text;
            }
            else
            {
                MessageBox.Show("Erreur Raison sociale", "Attention la raison sociale ne peut être vide", MessageBoxButtons.OK);
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
                MessageBox.Show("Erreur type client", "Attention vous devez choisir le type de client à ajouter", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if (tbxDomaineActivité.Text != null)
            {
                nouveauClient.ClientDomaineActivite = tbxDomaineActivité.Text;
            }
            else
            {
                MessageBox.Show("Erreur domaine d'activité", "Attention le domaine d'activité du client ne peut être vide", MessageBoxButtons.OK);
                DialogResult = DialogResult.Cancel;
            }
            if(tbxDomaineActivité.Text == "")
            {
                MessageBox.Show("Erreur domaine activité", "le domaine d'activité ne doit pas etre vide", MessageBoxButtons.OK);
            }
            nouveauClient.AdresseClientNumeroRue = Int32.Parse(tBxAjoutClientAdresseNumero.Text.Trim());
            nouveauClient.AdresseClientRue = tBxAjoutClientAdresseTypeNom.Text;
            nouveauClient.AdresseClientCodePostal = Int32.Parse(tBxAjoutClientAdresseCodePostal.Text.Trim());
            nouveauClient.AdresseClientVille = tBxAjoutClientAdresseVille.Text;
            if(cbxAjoutClientPays.SelectedItem!=null) nouveauClient.AdresseClientPays = cbxAjoutClientPays.SelectedItem.ToString();
            nouveauClient.ClientTypeTelephone = cBxClientTypeTelephone.SelectedItem.ToString();
            nouveauClient.ClientTelephoneNumero = Int32.Parse(tBxClientTelephone.Text.Trim());
            nouveauClient.ClientCA = Convert.ToDouble(tBxChiffreAffaire.Text.ToString());
            nouveauClient.ClientEffectif = Int32.Parse(tBxClientEffectif.Text.Trim());
            nouveauClient.ClientCommentaire = tBxCommentaire.Text;
            nouveauClient.ClientNature = tBxNature.Text;
            nouveauClient.ClientCommentaire = tBxCommentaire.Text;
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
