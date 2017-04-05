namespace ABI
{
    partial class frmDspClient
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrerSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exporterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complèteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sélectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.projetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enCoursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnSupprimerClient = new System.Windows.Forms.Button();
            this.btnAjouterClient = new System.Windows.Forms.Button();
            this.lblNomRecherche = new System.Windows.Forms.Label();
            this.txtBxRecherche = new System.Windows.Forms.TextBox();
            this.cbxChoixrecherche = new System.Windows.Forms.ComboBox();
            this.btnListeRechercheClient = new System.Windows.Forms.Button();
            this.btnAfficherTout = new System.Windows.Forms.Button();
            this.btnModifierClient = new System.Windows.Forms.Button();
            this.dgrdClient = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.donneesClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donneesClientsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.clientToolStripMenuItem,
            this.projetToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(840, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enregistrerToolStripMenuItem,
            this.enregistrerSousToolStripMenuItem,
            this.toolStripSeparator1,
            this.exporterToolStripMenuItem,
            this.toolStripMenuItem1,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // enregistrerToolStripMenuItem
            // 
            this.enregistrerToolStripMenuItem.Name = "enregistrerToolStripMenuItem";
            this.enregistrerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.enregistrerToolStripMenuItem.Text = "Enregistrer";
            // 
            // enregistrerSousToolStripMenuItem
            // 
            this.enregistrerSousToolStripMenuItem.Name = "enregistrerSousToolStripMenuItem";
            this.enregistrerSousToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.enregistrerSousToolStripMenuItem.Text = "&Enregistrer Sous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(155, 6);
            // 
            // exporterToolStripMenuItem
            // 
            this.exporterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeClientToolStripMenuItem});
            this.exporterToolStripMenuItem.Name = "exporterToolStripMenuItem";
            this.exporterToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.exporterToolStripMenuItem.Text = "E&xporter";
            // 
            // listeClientToolStripMenuItem
            // 
            this.listeClientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.complèteToolStripMenuItem,
            this.sélectionToolStripMenuItem});
            this.listeClientToolStripMenuItem.Name = "listeClientToolStripMenuItem";
            this.listeClientToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.listeClientToolStripMenuItem.Text = "&Liste client ";
            // 
            // complèteToolStripMenuItem
            // 
            this.complèteToolStripMenuItem.Name = "complèteToolStripMenuItem";
            this.complèteToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.complèteToolStripMenuItem.Text = "&Complète";
            // 
            // sélectionToolStripMenuItem
            // 
            this.sélectionToolStripMenuItem.Name = "sélectionToolStripMenuItem";
            this.sélectionToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.sélectionToolStripMenuItem.Text = "Sé&lection";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.toolStripMenuItem1.Text = "&Imprimer";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(155, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            // 
            // projetToolStripMenuItem
            // 
            this.projetToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enCoursToolStripMenuItem,
            this.toolStripTextBox1});
            this.projetToolStripMenuItem.Name = "projetToolStripMenuItem";
            this.projetToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.projetToolStripMenuItem.Text = "Projet";
            // 
            // enCoursToolStripMenuItem
            // 
            this.enCoursToolStripMenuItem.Name = "enCoursToolStripMenuItem";
            this.enCoursToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.enCoursToolStripMenuItem.Text = "En cours";
            this.enCoursToolStripMenuItem.Click += new System.EventHandler(this.enCoursToolStripMenuItem_Click);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(100, 23);
            this.toolStripTextBox1.Text = "terminés";
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(679, 245);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 7;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click_1);
            // 
            // btnSupprimerClient
            // 
            this.btnSupprimerClient.Location = new System.Drawing.Point(202, 245);
            this.btnSupprimerClient.Name = "btnSupprimerClient";
            this.btnSupprimerClient.Size = new System.Drawing.Size(75, 23);
            this.btnSupprimerClient.TabIndex = 6;
            this.btnSupprimerClient.Text = "&Supprimer";
            this.btnSupprimerClient.UseVisualStyleBackColor = true;
            this.btnSupprimerClient.Click += new System.EventHandler(this.btnSupprimerClient_Click);
            // 
            // btnAjouterClient
            // 
            this.btnAjouterClient.Location = new System.Drawing.Point(19, 245);
            this.btnAjouterClient.Name = "btnAjouterClient";
            this.btnAjouterClient.Size = new System.Drawing.Size(84, 23);
            this.btnAjouterClient.TabIndex = 5;
            this.btnAjouterClient.Text = "&Ajouter";
            this.btnAjouterClient.UseVisualStyleBackColor = true;
            this.btnAjouterClient.Click += new System.EventHandler(this.btnAjouterClient_Click);
            // 
            // lblNomRecherche
            // 
            this.lblNomRecherche.AutoSize = true;
            this.lblNomRecherche.Location = new System.Drawing.Point(14, 34);
            this.lblNomRecherche.Name = "lblNomRecherche";
            this.lblNomRecherche.Size = new System.Drawing.Size(80, 13);
            this.lblNomRecherche.TabIndex = 8;
            this.lblNomRecherche.Text = "Nom recherché";
            // 
            // txtBxRecherche
            // 
            this.txtBxRecherche.Location = new System.Drawing.Point(247, 31);
            this.txtBxRecherche.Name = "txtBxRecherche";
            this.txtBxRecherche.Size = new System.Drawing.Size(122, 20);
            this.txtBxRecherche.TabIndex = 9;
            // 
            // cbxChoixrecherche
            // 
            this.cbxChoixrecherche.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.cbxChoixrecherche.FormattingEnabled = true;
            this.cbxChoixrecherche.Location = new System.Drawing.Point(120, 31);
            this.cbxChoixrecherche.Name = "cbxChoixrecherche";
            this.cbxChoixrecherche.Size = new System.Drawing.Size(121, 21);
            this.cbxChoixrecherche.TabIndex = 10;
            this.cbxChoixrecherche.SelectedIndexChanged += new System.EventHandler(this.cbxChoixrecherche_SelectedIndexChanged_1);
            // 
            // btnListeRechercheClient
            // 
            this.btnListeRechercheClient.Location = new System.Drawing.Point(421, 29);
            this.btnListeRechercheClient.Name = "btnListeRechercheClient";
            this.btnListeRechercheClient.Size = new System.Drawing.Size(75, 23);
            this.btnListeRechercheClient.TabIndex = 11;
            this.btnListeRechercheClient.Text = "Recherche";
            this.btnListeRechercheClient.UseVisualStyleBackColor = true;
            this.btnListeRechercheClient.Click += new System.EventHandler(this.btnListeRechercheClient_Click);
            // 
            // btnAfficherTout
            // 
            this.btnAfficherTout.AutoSize = true;
            this.btnAfficherTout.Location = new System.Drawing.Point(556, 28);
            this.btnAfficherTout.Name = "btnAfficherTout";
            this.btnAfficherTout.Size = new System.Drawing.Size(78, 23);
            this.btnAfficherTout.TabIndex = 12;
            this.btnAfficherTout.Text = "Afficher Tout";
            this.btnAfficherTout.UseVisualStyleBackColor = true;
            this.btnAfficherTout.Click += new System.EventHandler(this.btnAfficherTout_Click);
            // 
            // btnModifierClient
            // 
            this.btnModifierClient.Location = new System.Drawing.Point(412, 245);
            this.btnModifierClient.Name = "btnModifierClient";
            this.btnModifierClient.Size = new System.Drawing.Size(75, 23);
            this.btnModifierClient.TabIndex = 13;
            this.btnModifierClient.Text = "Modifier";
            this.btnModifierClient.UseVisualStyleBackColor = true;
            // 
            // dgrdClient
            // 
            this.dgrdClient.AllowUserToAddRows = false;
            this.dgrdClient.AllowUserToDeleteRows = false;
            this.dgrdClient.AllowUserToOrderColumns = true;
            this.dgrdClient.AllowUserToResizeRows = false;
            this.dgrdClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dgrdClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrdClient.Location = new System.Drawing.Point(19, 68);
            this.dgrdClient.Name = "dgrdClient";
            this.dgrdClient.ReadOnly = true;
            this.dgrdClient.Size = new System.Drawing.Size(758, 150);
            this.dgrdClient.TabIndex = 14;
            this.dgrdClient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgrdClient_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgrdClient);
            this.groupBox1.Controls.Add(this.btnModifierClient);
            this.groupBox1.Controls.Add(this.btnQuitter);
            this.groupBox1.Controls.Add(this.btnAfficherTout);
            this.groupBox1.Controls.Add(this.btnListeRechercheClient);
            this.groupBox1.Controls.Add(this.cbxChoixrecherche);
            this.groupBox1.Controls.Add(this.txtBxRecherche);
            this.groupBox1.Controls.Add(this.lblNomRecherche);
            this.groupBox1.Controls.Add(this.btnSupprimerClient);
            this.groupBox1.Controls.Add(this.btnAjouterClient);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(806, 285);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Clients";
            // 
            // donneesClientsBindingSource
            // 
            this.donneesClientsBindingSource.DataSource = typeof(ABI.DonneesClients);
            // 
            // frmDspClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 350);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmDspClient";
            this.Text = "Affichage liste client";
            this.Load += new System.EventHandler(this.frmDspClient_Load);
            this.DoubleClick += new System.EventHandler(this.frmDspClient_DoubleClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrdClient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donneesClientsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrerSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exporterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complèteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sélectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem projetToolStripMenuItem;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnSupprimerClient;
        private System.Windows.Forms.Button btnAjouterClient;
        private System.Windows.Forms.Label lblNomRecherche;
        private System.Windows.Forms.TextBox txtBxRecherche;
        private System.Windows.Forms.ComboBox cbxChoixrecherche;
        private System.Windows.Forms.Button btnListeRechercheClient;
        private System.Windows.Forms.Button btnAfficherTout;
        private System.Windows.Forms.Button btnModifierClient;
        private System.Windows.Forms.ToolStripMenuItem enCoursToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.BindingSource donneesClientsBindingSource;
        private System.Windows.Forms.DataGridView dgrdClient;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

