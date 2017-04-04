using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Reflection;


namespace ABI
{
    public partial class frmDspClient : Form
    {


        private IBindingList blist;
        public frmDspClient()
        {
            InitializeComponent();
            if(dgrdClient.RowCount!=0) btnModifierClient.Enabled = false;
            this.cbxChoixrecherche.Items.AddRange(new String[]
                { "nom ", "numero", "nature", "raison sociale" });
            Client jean= new Client();
            jean.AdresseClientCodePostal = 06300;
            jean.AdresseClientNumeroRue = 244;
            jean.AdresseClientPays = "France";
            jean.AdresseClientRue="Route de turin";
            jean.AdresseClientVille = "nice";
            jean.ClientCA = 2;
            jean.ClientCommentaire = "sympa";
            jean.ClientDomaineActivite = "afpa";
            jean.ClientEffectif = 2;
            jean.ClientNature = "ancienne";
            jean.ClientRaisonSociale = "SARL";
            jean.ClientTelephoneNumero = 0493254123;
            jean.ClientTypeTelephone = "société";
            jean.NumeroClient = 1;
            jean.TypeActivité = "privé";
            DonneesClients.ArrayStag.Add(jean);
            DonneesClients.NClient++;
            afficheClient();
        }

        private void frmDspClient_Load(object sender, EventArgs e)
        {
            

        }

        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            frmNewClient frmNC;
            frmNC = new frmNewClient();
            if (frmNC.ShowDialog()==DialogResult.OK)
            {
                this.btnSupprimerClient.Enabled = true;
                afficheClient();
            }
            
        }
        private void afficheClient()
        {
            //DataTable: pour enregistrer les clients
            // liés au DataGridView
            DataTable dt = new DataTable();
            DataRow dr;
            Int32 i;
            dt.Columns.Add(new DataColumn("NumeroClient", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Raison sociale", typeof(System.String)));            
            dt.Columns.Add(new DataColumn("type", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Domaine d'activité", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Chiffre d'affaire", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));

            for ( i = 0; i < DonneesClients.ArrayStag.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = DonneesClients.ArrayStag[i].NumeroClient;
                dr[1] = DonneesClients.ArrayStag[i].ClientRaisonSociale;
                dr[2] = DonneesClients.ArrayStag[i].TypeActivité;
                dr[3] = DonneesClients.ArrayStag[i].ClientDomaineActivite;
                dr[4] = DonneesClients.ArrayStag[i].AdresseClientNumeroRue + DonneesClients.ArrayStag[i].AdresseClientRue + DonneesClients.ArrayStag[i].AdresseClientCodePostal + DonneesClients.ArrayStag[i].AdresseClientVille;
                dr[5] = DonneesClients.ArrayStag[i].ClientNature;
                dr[6] = DonneesClients.ArrayStag[i].ClientCA;
                dr[7] = DonneesClients.ArrayStag[i].ClientEffectif;
                dt.Rows.Add(dr);
            }
            this.dgrdClient.DataSource = dt;
            
        }


        private void cbxChoixrecherche_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblNomRecherche_Click(object sender, EventArgs e)
        {

        }

        private void txtBxRecherche_TextChanged(object sender, EventArgs e)
        {

        }



        private void dGrdListeClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAfficherTout_Click(object sender, EventArgs e)
        {
            
            this.txtBxRecherche.Text = null;
            (dgrdClient.DataSource as DataTable).DefaultView.RowFilter = null;
        }

        private void btnQuitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListeRechercheClient_Click(object sender, EventArgs e)
        {
            (dgrdClient.DataSource as DataTable).DefaultView.RowFilter = string.Format("nom ='{0}'", txtBxRecherche.Text);
        }
       
        private void cbxChoixrecherche_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ////            if(txtBxRecherche.Text!=null&&cbxChoixrecherche.Text=="nom")
            //{

            //    (dgrdClient.DataSource as DataTable).DefaultView.RowFilter = string.Format("nom ='{0}'", txtBxRecherche.Text);
            //}
            //if (txtBxRecherche.Text != null && cbxChoixrecherche.Text == "numero")
            //{
            //    ((DataView)(this.dgrdClient.DataSource)).RowFilter = "NumeroClient like'%" + Int32.Parse(txtBxRecherche.Text) + "%'";
            //}
        }

        private void dgrdClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DonneesClients leClient;
        private void dgrdClient_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Int32 iClient;
            iClient = this.dgrdClient.CurrentRow.Index;
            Client leClient = DonneesClients.ArrayStag[iClient];
            frmUpdClient frmUC = new frmUpdClient(leClient);
            frmUC.ShowDialog();
            if (frmUC.ShowDialog() == DialogResult.OK)
            {
                this.btnSupprimerClient.Enabled = true;
                this.afficheClient();
            }
        }

        private void dgrdClient_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void enCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDspProj frmDP;
            frmDP = new frmDspProj();

        }

        private void frmDspClient_DoubleClick(object sender, EventArgs e)
        {
            Int32 iClient;
            iClient = this.dgrdClient.CurrentRow.Index;
            MessageBox.Show("numero client : ",iClient.ToString());
        }
    }
}
