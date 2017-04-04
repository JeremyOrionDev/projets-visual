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


        String mbText;
        private void btnValider_Click(object sender, EventArgs e)
        {
            Client nouveauClient = new Client();

            if (tBxAjoutClientNumero.Text != "")
            {
                nouveauClient.NumeroClient = Int32.Parse(tBxAjoutClientNumero.Text.Trim());
            }
            else
            {
                mbText += "Attention le numero de client ne peut être vide \n";
            }
            if(tBxClientRaisonSociale.Text!="")
            {
                nouveauClient.ClientRaisonSociale = tBxClientRaisonSociale.Text;
            }
            else
            {
                mbText += "Attention la raison sociale ne peut être vide \n";
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
                mbText += "Attention le type du client ne peut être vide \n";
            }
            if (tbxDomaineActivité.Text != "")
            {
                nouveauClient.ClientDomaineActivite = tbxDomaineActivité.Text;
            }
            else
            {
                mbText += "Attention le domaine d'activité ne peut être vide \n";
            }
            if(tBxAjoutClientAdresseNumero.Text!="")
            {
                nouveauClient.AdresseClientNumeroRue = Int32.Parse(tBxAjoutClientAdresseNumero.Text.Trim());
            }
            else
            {
                mbText += "Attention le numero de rue ne peut être vide \n";
            }
            if(tBxAjoutClientAdresseTypeNom.Text!="")
            {
                nouveauClient.AdresseClientRue = tBxAjoutClientAdresseTypeNom.Text;
            }
            else
            {
                mbText += "Attention l'adresse ne peut être vide \n";
            }
            if(tBxAjoutClientAdresseCodePostal.Text!="")
            {
                nouveauClient.AdresseClientCodePostal = Int32.Parse(tBxAjoutClientAdresseCodePostal.Text.Trim());
            }
            else
            {
                mbText += "Attention le code postal ne peut être vide \n";

            }
            if(tBxAjoutClientAdresseVille.Text!="")
            {
                nouveauClient.AdresseClientVille = tBxAjoutClientAdresseVille.Text;
            }
            else
            {
                mbText += "Attention la ville ne peut être vide \n";

            }
            if (cbxAjoutClientPays.SelectedItem != null)
            {
                nouveauClient.AdresseClientPays = cbxAjoutClientPays.SelectedItem.ToString();
            }
            else
            {
                mbText += "Attention le pays ne peut être vide \n";
            }
            if(cBxClientTypeTelephone.SelectedItem!=null)
            {
                nouveauClient.ClientTypeTelephone = cBxClientTypeTelephone.SelectedItem.ToString();
            }
            else
            {
                mbText += "Attention le type de téléphone ne peut être vide \n";
            }
            if(tBxClientTelephone.Text.ToString()!="")
            {
                nouveauClient.ClientTelephoneNumero = Int32.Parse(tBxClientTelephone.Text.Trim());
            }
            else
            {
                mbText += "Attention le numéro de téléphone ne peut être vide \n";
            }
            if(tBxChiffreAffaire.Text.ToString()!="")
            {
                nouveauClient.ClientCA = Convert.ToDouble(tBxChiffreAffaire.Text.ToString());
            }
            else
            {
                mbText += "Attention le chiffre d'affaire ne peut être vide \n";
            }
            if (tBxClientEffectif.Text.ToString() != "")
            {
                nouveauClient.ClientEffectif = Int32.Parse(tBxClientEffectif.Text.Trim());
            }
            else
            {
                mbText += "Attention l'effectif ne peut être vide \n";
            }
            nouveauClient.ClientCommentaire = tBxCommentaire.Text;
            if (tBxNature.Text != "")
            {
                nouveauClient.ClientNature = tBxNature.Text;
            }
            else
            {
                mbText += "Attention la nature du client ne peut être vide \n";
                }
            if (mbText.Length != 0)
            {
                MessageBox.Show(mbText,"Erreur dans le formulaire", MessageBoxButtons.OK);
            }
            else
            {
                DonneesClients.ArrayStag.Add(nouveauClient);
                DonneesClients.NClient++;
                this.DialogResult = DialogResult.OK;
            }


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
