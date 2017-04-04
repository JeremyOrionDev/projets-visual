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
        public frmUpdClient(Client unClient)
        {
            this.leClient = unClient;
            InitializeComponent();
            afficheUnClient();
            this.btnAjoutClientValider.Visible = false;
            this.frmNewClientBtnEnregistrer.Visible = true;
        }
        private void afficheUnClient()
        {
            tBxAjoutClientNumero.Text = leClient.NumeroClient.ToString();
            tBxClientRaisonSociale.Text = leClient.ClientRaisonSociale;
            if (leClient.TypeActivité == "privé") rbtnAjoutClientTypePrivé.Checked = true;
            if (leClient.TypeActivité == "public") rBtnAjoutClientTypePublic.Checked = true;
            tbxDomaineActivité.Text = leClient.ClientDomaineActivite;
            tBxAjoutClientAdresseNumero.Text = leClient.AdresseClientNumeroRue.ToString();
            tBxAjoutClientAdresseTypeNom.Text = leClient.AdresseClientRue;
            tBxAjoutClientAdresseVille.Text = leClient.AdresseClientVille;
            tBxAjoutClientAdresseCodePostal.Text = leClient.AdresseClientCodePostal.ToString();
            cbxAjoutClientPays.SelectedItem = leClient.AdresseClientPays;
            cBxClientTypeTelephone.SelectedItem = leClient.ClientTypeTelephone;
            tBxClientEffectif.Text = leClient.ClientEffectif.ToString();
           
            tBxChiffreAffaire.Text = leClient.ClientCA.ToString();



            this.tBxClientRaisonSociale.Text = leClient.ClientRaisonSociale.ToString();
        }


        private Client leClient;

        
        private void frmUpdClient_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnAjoutClientAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
