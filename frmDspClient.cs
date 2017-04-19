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
using static ABI.DataSetAbi;

namespace ABI
{
    /// <summary>
    /// classe partielle d'affichage des clients 
    /// </summary>
    public partial class frmDspClient : Form
    {

        Int32 iClient ;
        public Client leClient; 
        
        public frmDspClient()
        {
            
            InitializeComponent();
            //afficheClient();
            
            //si la dataGrid est vide le bouton modifier disparaît
            if (dgrdClient.RowCount!=0) btnModifierClient.Enabled = false;
            //On ajoute la selection  de type de recherche dans la ComboBox
            this.cbxChoixrecherche.Items.AddRange(new String[]
                { "nom client", "NumeroClient", "nature", "raison sociale" });
            

            ////    Donnees.ArrayStag.Add(unStagiaire);
            ////    afficheStagiaires();
        }

        private void frmDspClient_Load(object sender, EventArgs e)
        {
            //Client unClient; 
            DonneesClients.taClient.Fill(DonneesClients.DataSetClient.ClientBDD);
            dgrdClient.DataSource = DonneesClients.DataSetClient.ClientBDD;
            dgrdClient.Columns[9].Visible = false;
            //foreach (DataSetAbi.ClientBDDRow ClientRow in DonneesClients.DataSetClient.ClientBDD)
            //{
            //    leClient = new Client();
            //    leClient.NumeroClient = ClientRow.numéro_Client;
            //    leClient.NomClient = ClientRow.nom;
            //    leClient.ClientRaisonSociale = ClientRow.raison_sociale;
            //    leClient.TypeActivité = ClientRow._type_d_activité;
            //    leClient.ClientDomaineActivite = ClientRow._domaine_d_activité;
            //    leClient.AdresseClientNumeroRue = ClientRow.adresse_numéro;
            //    leClient.AdresseClientRue = ClientRow.adresse_rue;
            //    leClient.AdresseClientCodePostal =Convert.ToInt32( ClientRow.adresse_code_postal);
            //    leClient.AdresseClientVille = ClientRow.adresse_ville;
            //    leClient.AdresseClientPays = ClientRow.adresse_pays;
            //    leClient.ClientTypeTelephone = ClientRow.type_tel;
            //    leClient.ClientTelephoneNumero = ClientRow.numero_telephone.ToString();
            //    leClient.ClientCA = ClientRow._chiffre_d_affaire;
            //    leClient.ClientEffectif = ClientRow.effectif;
            //    leClient.IdClient = ClientRow.idClient;
            //    leClient.ClientCommentaire = ClientRow.Commentaires;
            //    leClient.ClientNature = ClientRow.nature;

            //    DonneesClients.ArrayClient.Add(leClient);
            //    afficheClient();
            //}

        }
        /// <summary>
        /// Client test pour remplir la datagrid au démarrage
        /// </summary>

        /// <summary>
        /// On veut ajouter un client le form d'ajout de client s'ouvre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouterClient_Click(object sender, EventArgs e)
        {
            frmNewClient frmNC;
            frmNC = new  frmNewClient();
            frmNC.ShowDialog();
            
        }
        /// <summary>
        /// Constructeur de la datagrid en ajoutant les colonnes
        /// </summary>
        private void afficheClient()
        {
            //DataTable: pour enregistrer les clients
            // liés au DataGridView
            DataTable dt = new DataTable();
            DataRow dr;
            
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
            dt.Columns.Add(new DataColumn("IdClient", typeof(Int32)));
            dt.Columns.Add(new DataColumn("téléphone", typeof(Int32)));
            for (i=0;i < DonneesClients.ArrayClient.Count;i++)
            {
                dr = dt.NewRow();
                dr[0] = DonneesClients.ArrayClient[i].NumeroClient;
                dr[1] = DonneesClients.ArrayClient[i].NomClient;
                dr[2] = DonneesClients.ArrayClient[i].ClientRaisonSociale;
                dr[3] = DonneesClients.ArrayClient[i].TypeActivité;
                dr[4] = DonneesClients.ArrayClient[i].ClientDomaineActivite;
                dr[5] = DonneesClients.ArrayClient[i].AdresseClientNumeroRue.ToString() + DonneesClients.ArrayClient[i].AdresseClientRue + DonneesClients.ArrayClient[i].AdresseClientCodePostal.ToString() + DonneesClients.ArrayClient[i].AdresseClientVille;
                dr[6] = DonneesClients.ArrayClient[i].ClientNature;
                dr[7] = DonneesClients.ArrayClient[i].ClientCA;
                dr[8] = DonneesClients.ArrayClient[i].ClientEffectif;
                dr[9] = DonneesClients.ArrayClient[i].IdClient;
                dr[10] = DonneesClients.ArrayClient[i].ClientTelephoneNumero;
                dt.Rows.Add(dr);
            }

            //rempli les colonnes avec les valeurs du client
            this.dgrdClient.DataSource = dt.DefaultView;
        }

        private void deleteClient()
        {
            
            foreach(Client C1 in DonneesClients.ArrayClient)
            {
                if (C1.IdClient.ToString() == dgrdClient.CurrentRow.Cells[9].Value.ToString()) DonneesClients.ArrayClient.Remove(C1);
                
            }
            
            
            foreach(Client C in DonneesClients.ArrayClient)
            {

                if (C.IdClient>Convert.ToInt32( dgrdClient.CurrentRow.Cells[9].Value.ToString()))
                {
                    C.IdClient--;
                    //Juste pour l'affichage le numero client sera géré par le client en fonction de ses normes
                   // C.NumeroClient--;
                   //test
                   //DonneesClients.DataSetClient.ClientBD.RemoveClientBDRow()
                }
            }
            dgrdClient.DataSource = DonneesClients.ArrayClient;

        }
        /// <summary>
        /// on affiche tous les clients dans la datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAfficherTout_Click(object sender, EventArgs e)
        {            
            this.txtBxRecherche.Text = null;
            (dgrdClient.DataSource as DataTable).DefaultView.RowFilter = string.Format("");
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
            if (cbxChoixrecherche.Text == "nom client")
            {
                (dgrdClient.DataSource as DataTable).DefaultView.RowFilter = string.Format("[nom client] like '%" + txtBxRecherche.Text.ToString() + "%'");
            }


            else if (cbxChoixrecherche.Text == "raison sociale")
            {
                (dgrdClient.DataSource as DataTable).DefaultView.RowFilter = string.Format("[raison sociale] like '%" + txtBxRecherche.Text.ToString() + "%'");

            }
            else if (cbxChoixrecherche.Text == "NumeroClient")
            {
                (dgrdClient.DataSource as DataTable).DefaultView.RowFilter = string.Format("NumeroClient like '%" + txtBxRecherche.Text.ToString() + "%'");

            }
            else if (cbxChoixrecherche.Text == "nature")
            {
                (dgrdClient.DataSource as DataTable).DefaultView.RowFilter = string.Format("nature like '%" + txtBxRecherche.Text.ToString() + "%'");

            }
            dgrdClient.Refresh();
        }
            //"[nom client] like '%" + txtBxRecherche.Text.ToString() + "%'"
        

        private void cbxChoixrecherche_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void enCoursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDspProj frmDP;
            frmDP = new frmDspProj();
            if (frmDP.ShowDialog() == DialogResult.OK)
            {
               
            }
        }





        public int indexRow;


        private void dgrdClient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.updateClient();
        }
        /// <summary>
        /// Supprime le client selectionné de la liste de clients
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSupprimerClient_Click(object sender, EventArgs e)
        {
            String mbTexT;
            mbTexT = "Vous allez supprimer un client : \n";
            mbTexT += "----------------------------------\n";
            mbTexT += "Voici les informations du client à supprimer :\n";
            mbTexT+="Numero Client"+dgrdClient.CurrentRow.Cells[0].Value.ToString() +" ---Nom Client:"+dgrdClient.CurrentRow.Cells[1].Value.ToString();
            
            if(MessageBox.Show(mbTexT, "Attention Suppression client", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                deleteClient();
                
            }
            
        }

        private void btnModifierClient_Click(object sender, EventArgs e)
        {
            this.updateClient();
        }

        private void updateClient()
        {
            //récupere idClient en cellule 0 de la ligne selectionnée
            iClient = Int32.Parse(this.dgrdClient.CurrentRow.Cells[0].Value.ToString());
            //Créer un nouveau ClientBDDRow
            ClientBDDRow client = null;
            //Parcours la Table ClientDBB dans le DataSet
            for (int i = 0; i < DonneesClients.DataSetClient.ClientBDD.Count; i++)
            {
                //Récupère le clientbddrow à chaque indice i
                ClientBDDRow c = DonneesClients.DataSetClient.ClientBDD[i];
                //si idclient du client à l'indice i = iclient de la ligne sélectionnée
                if (c.idClient == iClient)
                {
                    //Client trouvé !
                    client = c;
                }
            }
            //vérifie qu'un client à bien été trouvé
            if (client != null)
            {
                frmUpdClient frmUC = new frmUpdClient(client);

                if (frmUC.ShowDialog() == DialogResult.OK)
                {
                    this.btnSupprimerClient.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }
    }
}
