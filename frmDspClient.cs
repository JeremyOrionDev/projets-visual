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
    /// <summary>
    /// classe partielle d'affichage des clients 
    /// </summary>
    public partial class frmDspClient : Form
    {
        //DataTable: pour enregistrer les clients
        // liés au DataGridView
        DataTable dt = new DataTable();
        DataRow dr;
        public frmDspClient()
        {
            
            InitializeComponent();
            afficheClient();
            //si la dataGrid est vide le bouton modifier disparaît
            if (dgrdClient.RowCount!=0) btnModifierClient.Enabled = false;
            //On ajoute la selection  de type de recherche dans la ComboBox
            this.cbxChoixrecherche.Items.AddRange(new String[]
                { "nom client", "NumeroClient", "nature", "raison sociale" });
            
            creationClientTest();
        }

        private void frmDspClient_Load(object sender, EventArgs e)
        {
            

        }
        /// <summary>
        /// Client test pour remplir la datagrid au démarrage
        /// </summary>
        private void creationClientTest()
        {
            Client machin = new Client();
            machin.NumeroClient = 3;
            machin.NomClient = "nom client";
            machin.ClientRaisonSociale = "raison sociale";
            machin.TypeActivité = "public";
            machin.ClientDomaineActivite = "Domaine";
            machin.AdresseClientNumeroRue = 12;
            machin.AdresseClientRue = " rue test";
            machin.AdresseClientCodePostal = 24500;
            machin.AdresseClientVille = "VIlle";
            machin.AdresseClientPays = "France";
            machin.ClientTypeTelephone = "Société";
            machin.ClientTelephoneNumero = "0254125485";
            machin.ClientCA = 1234;
            machin.ClientEffectif = 456;
            machin.IdClient = 4;
            machin.ClientCommentaire = "";
            machin.ClientNature= "ancienne";
            DonneesClients.ArrayStag.Add(machin);
            DonneesClients.NClient++;
            Client test = new Client();
            test.NomClient = "papa";
            test.AdresseClientCodePostal = 06300;
            test.AdresseClientNumeroRue = 244;
            test.AdresseClientPays = "France";
            test.AdresseClientRue = "Route de turin";
            test.AdresseClientVille = "nice";
            test.ClientCA = 2;
            test.ClientCommentaire = "sympa";
            test.ClientDomaineActivite = "afpa";
            test.ClientEffectif = 2;
            test.ClientNature = "ancienne";
            test.ClientRaisonSociale = "SARL";
            test.ClientTelephoneNumero = "0493254123";
            test.ClientTypeTelephone = "société";
            test.NumeroClient = 1;
            test.TypeActivité = "privé";
            DonneesClients.ArrayStag.Add(test);
            DonneesClients.NClient++;
            Client jean = new Client();
            jean.NomClient = "jean";
            jean.AdresseClientCodePostal = 01234;
            jean.AdresseClientNumeroRue = 5;
            jean.AdresseClientPays = "Allemagne";
            jean.AdresseClientRue = "route test";
            jean.AdresseClientVille = "Berlin";
            jean.ClientCA = 2323;
            jean.ClientCommentaire = "Test";
            jean.ClientDomaineActivite = "test pierre";
            jean.ClientEffectif = 3;
            jean.ClientNature = "nouveau";
            jean.ClientRaisonSociale = "Test";
            jean.ClientTelephoneNumero = "055323232";
            jean.ClientTypeTelephone = "société";
            jean.NumeroClient = 2;
            jean.TypeActivité = "public";
            DonneesClients.ArrayStag.Add(jean);
            DonneesClients.NClient++;
            //ajouteClient();
        }
        /// <summary>
        /// On veut ajouter un client le form d'ajout de client s'ouvre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            frmNewClient frmNC;
            frmNC = new  frmNewClient();
            if (frmNC.ShowDialog()==DialogResult.OK)
            {
                this.btnSupprimerClient.Enabled = true;
                ajouteClient();
            }
            
        }
        /// <summary>
        /// Constructeur de la datagrid en ajoutant les colonnes
        /// </summary>
        private void afficheClient()
        {

            Int32 i;
            dt.Columns.Add(new DataColumn("NumeroClient", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("nom client", typeof(String)));
            dt.Columns.Add(new DataColumn("Raison sociale", typeof(System.String)));            
            dt.Columns.Add(new DataColumn("type", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Domaine d'activité", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Nature", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Chiffre d'affaire", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Effectif", typeof(System.Int32)));
            //rempli les colonnes avec les valeurs du client
            ajouteClient();
        }
        private void ajouteClient()
        {
            for (Int32 i = 0; i < DonneesClients.ArrayStag.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = DonneesClients.ArrayStag[i].NumeroClient;
                dr[1] = DonneesClients.ArrayStag[i].NomClient;
                dr[2] = DonneesClients.ArrayStag[i].ClientRaisonSociale;
                dr[3] = DonneesClients.ArrayStag[i].TypeActivité;
                dr[4] = DonneesClients.ArrayStag[i].ClientDomaineActivite;
                dr[5] = DonneesClients.ArrayStag[i].AdresseClientNumeroRue + DonneesClients.ArrayStag[i].AdresseClientRue + DonneesClients.ArrayStag[i].AdresseClientCodePostal + DonneesClients.ArrayStag[i].AdresseClientVille;
                dr[6] = DonneesClients.ArrayStag[i].ClientNature;
                dr[7] = DonneesClients.ArrayStag[i].ClientCA;
                dr[8] = DonneesClients.ArrayStag[i].ClientEffectif;
                dt.Rows.Add(dr);
            }
            this.dgrdClient.DataSource = dt;
        }
        /// <summary>
        /// on affiche tous les clients dans la datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfficherTout_Click(object sender, EventArgs e)
        {            
            this.txtBxRecherche.Text = null;
            foreach(DataGridViewRow row in dgrdClient.Rows)
            {
                row.Visible = true;
                txtBxRecherche.Text = "";
            }
        }
        /// <summary>
        /// on ferme le
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
        DataSet ds = new DataSet();
        private void btnListeRechercheClient_Click(object sender, EventArgs e)
        {
            string searchValue = txtBxRecherche.Text;

            dgrdClient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            try
            {
                foreach (DataGridViewRow row in dgrdClient.Rows)
                {
                    if (!row.Cells[cbxChoixrecherche.SelectedItem.ToString()].Value.ToString().Equals(searchValue))
                    {
                        row.Visible=false;
                        break;
                    }
                    //else row.Visible = false;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            //dt.DefaultView.RowFilter = string.Format(cbxChoixrecherche.SelectedItem.ToString()+ "LIKE'%{0}%'", txtBxRecherche.Text.ToString());
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
        private void enCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDspProj frmDP;
            frmDP = new frmDspProj();
            if (frmDP.ShowDialog() == DialogResult.OK)
            {
               
            }
        }

        private void frmDspClient_DoubleClick(object sender, EventArgs e)
        {
            Int32 iClient;
            iClient = this.dgrdClient.CurrentRow.Index;
            MessageBox.Show("numero client : ",iClient.ToString());
        }

        private void dgrdClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            DonneesClients.ArrayStag.RemoveAt(dgrdClient.CurrentRow.Index);
            afficheClient();
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            ajouteClient();
            creationClientTest();
            //afficheClient();
        }
    }
}
