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
            
            //si la dataGrid est vide le bouton modifier disparaît
            if (dgrdClient.RowCount!=0) btnModifierClient.Enabled = false;
            //On ajoute la selection  de type de recherche dans la ComboBox
            this.cbxChoixrecherche.Items.AddRange(new String[]
                { "nom client", "NumeroClient", "nature", "raison sociale" });

        }

        private void frmDspClient_Load(object sender, EventArgs e)
        {
            DonneesClients.taClient.Fill(DonneesClients.DataSetClient.ClientBDD);
            dgrdClient.DataSource = DonneesClients.DataSetClient.ClientBDD;
           
            int count = DonneesClients.DataSetClient.ClientBDD.Count;
            if (count == 0)
            {
                DonneesClients.nbreClient = 0;
            }
            else
            {
                DonneesClients.nbreClient = DonneesClients.DataSetClient.ClientBDD[count-1].idClient;
            }

            //dgrdClient.Columns[9].Visible = false;
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
            frmNC.ShowDialog();
            
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
            mbTexT+="Numero Client"+dgrdClient.CurrentRow.Cells[1].Value.ToString() +" ---Nom Client:"+dgrdClient.CurrentRow.Cells[1].Value.ToString();
            
            if(MessageBox.Show(mbTexT, "Attention Suppression client", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Int32 idClient = Convert.ToInt32(dgrdClient.CurrentRow.Cells[0].Value);
                ClientBDDRow client = null;
                //Parcours la Table ClientDBB dans le DataSet
                for (int i = 0; i < DonneesClients.DataSetClient.ClientBDD.Count; i++)
                {
                    //Récupère le clientbddrow à chaque indice i
                    ClientBDDRow c = DonneesClients.DataSetClient.ClientBDD[i];
                    //si idclient du client à l'indice i = iclient de la ligne sélectionnée
                    if (c.idClient == idClient)
                    {
                        //Client trouvé !
                        client = c;
                    }
                }
                if(client != null)
                {
                    DonneesClients.taClient.Delete(client.idClient, client.adresse_code_postal, client.numero_telephone, client.effectif, client.numéro_Client);
                    DonneesClients.DataSetClient.ClientBDD.RemoveClientBDDRow(client);
                }
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
    }
}
