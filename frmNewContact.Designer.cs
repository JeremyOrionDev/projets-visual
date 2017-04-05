namespace ABI
{
    partial class frmNewContact
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.frmNewClientBtnEnregistrerContact = new System.Windows.Forms.Button();
            this.btnNouveauContact = new System.Windows.Forms.Button();
            this.gBxFicheContact = new System.Windows.Forms.GroupBox();
            this.tBxFicheContactProfessionel = new System.Windows.Forms.TextBox();
            this.tBxFicheContactPortable = new System.Windows.Forms.TextBox();
            this.tBxFicheContactFonction = new System.Windows.Forms.TextBox();
            this.tBxFicheContactNomPrenom = new System.Windows.Forms.TextBox();
            this.lblFichecontactProfessionel = new System.Windows.Forms.Label();
            this.lblFicheContactPortable = new System.Windows.Forms.Label();
            this.lblFicheContactFonction = new System.Windows.Forms.Label();
            this.lblFicheContactNomPrenom = new System.Windows.Forms.Label();
            this.frmNewClientSupprimerContact = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.dGvContact = new System.Windows.Forms.DataGridView();
            this.gBxFicheContact.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvContact)).BeginInit();
            this.SuspendLayout();
            // 
            // frmNewClientBtnEnregistrerContact
            // 
            this.frmNewClientBtnEnregistrerContact.AutoSize = true;
            this.frmNewClientBtnEnregistrerContact.Location = new System.Drawing.Point(154, 325);
            this.frmNewClientBtnEnregistrerContact.Name = "frmNewClientBtnEnregistrerContact";
            this.frmNewClientBtnEnregistrerContact.Size = new System.Drawing.Size(106, 23);
            this.frmNewClientBtnEnregistrerContact.TabIndex = 27;
            this.frmNewClientBtnEnregistrerContact.Text = "Enregistrer contact";
            this.frmNewClientBtnEnregistrerContact.UseVisualStyleBackColor = true;
            this.frmNewClientBtnEnregistrerContact.Click += new System.EventHandler(this.frmNewClientBtnEnregistrerContact_Click);
            // 
            // btnNouveauContact
            // 
            this.btnNouveauContact.AutoSize = true;
            this.btnNouveauContact.Location = new System.Drawing.Point(12, 325);
            this.btnNouveauContact.Name = "btnNouveauContact";
            this.btnNouveauContact.Size = new System.Drawing.Size(100, 23);
            this.btnNouveauContact.TabIndex = 26;
            this.btnNouveauContact.Text = "&Nouveau contact";
            this.btnNouveauContact.UseVisualStyleBackColor = true;
            this.btnNouveauContact.Click += new System.EventHandler(this.btnNouveauContact_Click);
            // 
            // gBxFicheContact
            // 
            this.gBxFicheContact.Controls.Add(this.tBxFicheContactProfessionel);
            this.gBxFicheContact.Controls.Add(this.tBxFicheContactPortable);
            this.gBxFicheContact.Controls.Add(this.tBxFicheContactFonction);
            this.gBxFicheContact.Controls.Add(this.tBxFicheContactNomPrenom);
            this.gBxFicheContact.Controls.Add(this.lblFichecontactProfessionel);
            this.gBxFicheContact.Controls.Add(this.lblFicheContactPortable);
            this.gBxFicheContact.Controls.Add(this.lblFicheContactFonction);
            this.gBxFicheContact.Controls.Add(this.lblFicheContactNomPrenom);
            this.gBxFicheContact.Location = new System.Drawing.Point(12, 12);
            this.gBxFicheContact.Name = "gBxFicheContact";
            this.gBxFicheContact.Size = new System.Drawing.Size(285, 154);
            this.gBxFicheContact.TabIndex = 25;
            this.gBxFicheContact.TabStop = false;
            this.gBxFicheContact.Text = "Fiche Contact";
            // 
            // tBxFicheContactProfessionel
            // 
            this.tBxFicheContactProfessionel.Location = new System.Drawing.Point(118, 118);
            this.tBxFicheContactProfessionel.Name = "tBxFicheContactProfessionel";
            this.tBxFicheContactProfessionel.Size = new System.Drawing.Size(100, 20);
            this.tBxFicheContactProfessionel.TabIndex = 19;
            // 
            // tBxFicheContactPortable
            // 
            this.tBxFicheContactPortable.Location = new System.Drawing.Point(118, 85);
            this.tBxFicheContactPortable.Name = "tBxFicheContactPortable";
            this.tBxFicheContactPortable.Size = new System.Drawing.Size(100, 20);
            this.tBxFicheContactPortable.TabIndex = 18;
            // 
            // tBxFicheContactFonction
            // 
            this.tBxFicheContactFonction.Location = new System.Drawing.Point(118, 49);
            this.tBxFicheContactFonction.Name = "tBxFicheContactFonction";
            this.tBxFicheContactFonction.Size = new System.Drawing.Size(100, 20);
            this.tBxFicheContactFonction.TabIndex = 17;
            // 
            // tBxFicheContactNomPrenom
            // 
            this.tBxFicheContactNomPrenom.Location = new System.Drawing.Point(118, 20);
            this.tBxFicheContactNomPrenom.Name = "tBxFicheContactNomPrenom";
            this.tBxFicheContactNomPrenom.Size = new System.Drawing.Size(100, 20);
            this.tBxFicheContactNomPrenom.TabIndex = 16;
            // 
            // lblFichecontactProfessionel
            // 
            this.lblFichecontactProfessionel.AutoSize = true;
            this.lblFichecontactProfessionel.Location = new System.Drawing.Point(16, 121);
            this.lblFichecontactProfessionel.Name = "lblFichecontactProfessionel";
            this.lblFichecontactProfessionel.Size = new System.Drawing.Size(82, 13);
            this.lblFichecontactProfessionel.TabIndex = 0;
            this.lblFichecontactProfessionel.Text = "Tel Professionel";
            // 
            // lblFicheContactPortable
            // 
            this.lblFicheContactPortable.AutoSize = true;
            this.lblFicheContactPortable.Location = new System.Drawing.Point(16, 92);
            this.lblFicheContactPortable.Name = "lblFicheContactPortable";
            this.lblFicheContactPortable.Size = new System.Drawing.Size(64, 13);
            this.lblFicheContactPortable.TabIndex = 0;
            this.lblFicheContactPortable.Text = "Tel Portable";
            // 
            // lblFicheContactFonction
            // 
            this.lblFicheContactFonction.Location = new System.Drawing.Point(16, 42);
            this.lblFicheContactFonction.Name = "lblFicheContactFonction";
            this.lblFicheContactFonction.Size = new System.Drawing.Size(84, 33);
            this.lblFicheContactFonction.TabIndex = 0;
            this.lblFicheContactFonction.Text = "Fonction dans la société";
            // 
            // lblFicheContactNomPrenom
            // 
            this.lblFicheContactNomPrenom.AutoSize = true;
            this.lblFicheContactNomPrenom.Location = new System.Drawing.Point(16, 23);
            this.lblFicheContactNomPrenom.Name = "lblFicheContactNomPrenom";
            this.lblFicheContactNomPrenom.Size = new System.Drawing.Size(67, 13);
            this.lblFicheContactNomPrenom.TabIndex = 0;
            this.lblFicheContactNomPrenom.Text = "Nom prénom";
            // 
            // frmNewClientSupprimerContact
            // 
            this.frmNewClientSupprimerContact.AutoSize = true;
            this.frmNewClientSupprimerContact.Location = new System.Drawing.Point(157, 354);
            this.frmNewClientSupprimerContact.Name = "frmNewClientSupprimerContact";
            this.frmNewClientSupprimerContact.Size = new System.Drawing.Size(103, 23);
            this.frmNewClientSupprimerContact.TabIndex = 29;
            this.frmNewClientSupprimerContact.Text = "Supprimer contact";
            this.frmNewClientSupprimerContact.UseVisualStyleBackColor = true;
            this.frmNewClientSupprimerContact.Click += new System.EventHandler(this.frmNewClientSupprimerContact_Click);
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(12, 354);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Importer contact";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(12, 383);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 30;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(185, 383);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(75, 23);
            this.btnValider.TabIndex = 31;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // dGvContact
            // 
            this.dGvContact.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGvContact.Location = new System.Drawing.Point(12, 172);
            this.dGvContact.Name = "dGvContact";
            this.dGvContact.Size = new System.Drawing.Size(285, 147);
            this.dGvContact.TabIndex = 32;
            // 
            // frmNewContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 433);
            this.Controls.Add(this.dGvContact);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.frmNewClientSupprimerContact);
            this.Controls.Add(this.frmNewClientBtnEnregistrerContact);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnNouveauContact);
            this.Controls.Add(this.gBxFicheContact);
            this.Name = "frmNewContact";
            this.Text = "frmNewContact";
            this.gBxFicheContact.ResumeLayout(false);
            this.gBxFicheContact.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dGvContact)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button frmNewClientBtnEnregistrerContact;
        private System.Windows.Forms.Button btnNouveauContact;
        private System.Windows.Forms.GroupBox gBxFicheContact;
        private System.Windows.Forms.TextBox tBxFicheContactProfessionel;
        private System.Windows.Forms.TextBox tBxFicheContactPortable;
        private System.Windows.Forms.TextBox tBxFicheContactFonction;
        private System.Windows.Forms.TextBox tBxFicheContactNomPrenom;
        private System.Windows.Forms.Label lblFichecontactProfessionel;
        private System.Windows.Forms.Label lblFicheContactPortable;
        private System.Windows.Forms.Label lblFicheContactFonction;
        private System.Windows.Forms.Label lblFicheContactNomPrenom;
        private System.Windows.Forms.Button frmNewClientSupprimerContact;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DataGridView dGvContact;
    }
}