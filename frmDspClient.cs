﻿using System;
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
            btnModifierClient.Enabled = false;
            afficheClient();
            this.cbxChoixrecherche.Items.AddRange(new String[]
                { "nom ", "numero", "nature", "raison sociale" }); 
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
            dt.Columns.Add(new DataColumn("nom", typeof(System.String)));
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
                dr[1] = DonneesClients.ArrayStag[i].ContactNomPrenom;
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
            ((DataView)(this.dgrdClient.DataSource)).RowFilter = null;
        }

        private void btnQuitter_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnListeRechercheClient_Click(object sender, EventArgs e)
        {
            if(DataColumn.Equals()
        }c
        
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

        private void dgrdClient_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void dgrdClient_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Int32 iClient;
            iClient = this.dgrdClient.CurrentRow.Index;
            Client leclient = DonneesClients.ArrayStag[iClient];
            frmUpdClient frmUC = new frmUpdClient(leclient);
            frmUC.ShowDialog();
            this.afficheClient();
        }
    }
}