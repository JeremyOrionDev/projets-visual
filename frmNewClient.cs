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
    public   partial class frmNewClient : Form
    {
        public int referenceClient;
        public frmNewClient()
        {
            InitializeComponent();
            
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
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            String mbText = "";
            ClientBDDRow client = DonneesClients.DataSetClient.ClientBDD.NewClientBDDRow();
            
            if (tBxNomClient.Text != "")
            {
                client.nom = tBxNomClient.Text;
            }
            else
            {
                mbText += " Attention le nom du client ne peut être vide \n";
            }

            if (tBxClientRaisonSociale.Text != "")
            {
                client.raison_sociale = tBxClientRaisonSociale.Text;
            }
            else
            {
                mbText += "Attention la raison sociale ne peut être vide \n";
            }

            if (rbtnAjoutClientTypePrivé.Checked)
            {
                client._type_d_activité = "privé";
            }
            if (rBtnAjoutClientTypePublic.Checked)
            {
                client._type_d_activité = "public";
            }
            if (!rbtnAjoutClientTypePrivé.Checked && !rBtnAjoutClientTypePublic.Checked)
            {
                mbText += "Attention le type du client ne peut être vide \n";
            }

            if (tbxDomaineActivité.Text != "")
            {
                client._domaine_d_activité = tbxDomaineActivité.Text;
            }
            else
            {
                mbText += "Attention le domaine d'activité ne peut être vide \n";
            }
            if (tBxAjoutClientAdresseNumero.Text != "")
            {
                client.adresse_numéro = tBxAjoutClientAdresseNumero.Text;
            }
            else
            {
                mbText += "Attention le numero de rue ne peut être vide \n";
            }

            if (tBxAjoutClientAdresseTypeNom.Text != "")
            {
                client.adresse_rue = tBxAjoutClientAdresseTypeNom.Text;
            }
            else
            {
                mbText += "Attention l'adresse ne peut être vide \n";
            }

            if (tBxAjoutClientAdresseCodePostal.Text != "")
            {
                client.adresse_code_postal = tBxAjoutClientAdresseCodePostal.Text;
            }
            else
            {
                mbText += "Attention le code postal ne peut être vide \n";
            }

            if (tBxAjoutClientAdresseVille.Text != "")
            {
                client.adresse_ville = tBxAjoutClientAdresseVille.Text;
            }
            else
            {
                mbText += "Attention la ville ne peut être vide \n";
            }

            if (cbxAjoutClientPays.SelectedItem != null)
            {
                client.adresse_pays = cbxAjoutClientPays.Text.ToString();
            }
            else
            {
                mbText += "Attention le pays ne peut être vide \n";
            }
            if (cBxClientTypeTelephone.SelectedItem != null)
            {
                client.type_tel = cBxClientTypeTelephone.SelectedItem.ToString();
            }
            else
            {
                mbText += "Attention le type de téléphone ne peut être vide \n";
            }

            if (tBxClientTelephone.Text.ToString() != "")
            {
                int tel;
                Boolean b = Int32.TryParse(tBxClientTelephone.Text, out tel);
                if (b)
                {
                    client.numero_telephone = tel;
                }
                else
                {
                    mbText += "Attention le numéro de téléphone doit contenir seulement des chifrres \n";
                }

            }
            else if (tBxClientTelephone.Text.Length != 10)
            {
                mbText += "Attention le numéro de téléphone doit avoir 10 chiffres \n";
            }

            if (tBxChiffreAffaire.Text.ToString() != "")
            {
                client._chiffre_d_affaire = tBxChiffreAffaire.Text;
            }
            else
            {
                mbText += "Attention le chiffre d'affaire ne peut être vide \n";
            }

            if (tBxClientEffectif.Text.ToString() != "")
            {
                Int32 eff;
                Boolean b = Int32.TryParse(tBxClientEffectif.Text, out eff);
                if (b)
                {
                    client.effectif = eff;
                }
                else
                {
                    mbText += "Attention l'effectif doit être des chiffres \n";
                }
            }
            else
            {
                mbText += "Attention l'effectif ne peut être vide \n";
            }

            client.Commentaires = tBxCommentaire.Text;

            if (tBxNature.Text != "")
            {
                client.nature = tBxNature.Text;
            }
            else
            {
                mbText += "Attention la nature du client ne peut être vide \n";
            }

            if (mbText.ToString() != "")
            {
                MessageBox.Show(mbText, "Erreur dans le formulaire", MessageBoxButtons.OK);
            }
            else
            {
                client.idClient = ++DonneesClients.nbreClient;
                DonneesClients.DataSetClient.ClientBDD.AddClientBDDRow(client);
                this.DialogResult = DialogResult.OK;
            }
    }


        private void btnAjouterContact_Click(object sender, EventArgs e)
        {
            frmNewContact frmNCC = new frmNewContact(this);
            referenceClient= Convert.ToInt32(tBxIdClient.Text);
            frmNCC.ShowDialog();
        }

        private void cBxClientTypeTelephone_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
