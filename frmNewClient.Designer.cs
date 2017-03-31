﻿namespace ABI
{
    partial class frmNewClient
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
            this.lblAjoutClientIdNumero = new System.Windows.Forms.Label();
            this.lblAjoutClientRaisonSociale = new System.Windows.Forms.Label();
            this.lblAjoutClientType = new System.Windows.Forms.Label();
            this.rBtnAjoutClientTypePublic = new System.Windows.Forms.RadioButton();
            this.rbtnAjoutClientTypePrivé = new System.Windows.Forms.RadioButton();
            this.lblAjoutClientDomaineActivite = new System.Windows.Forms.Label();
            this.gbxAjoutClientAdresse = new System.Windows.Forms.GroupBox();
            this.cbxAjoutClientPays = new System.Windows.Forms.ComboBox();
            this.lblAjoutClientAdressePays = new System.Windows.Forms.Label();
            this.tBxAjoutClientAdresseVille = new System.Windows.Forms.TextBox();
            this.lblAjoutClientAdresseVille = new System.Windows.Forms.Label();
            this.tBxAjoutClientAdresseCodePostal = new System.Windows.Forms.TextBox();
            this.lblAjoutClientAdresseCodePostal = new System.Windows.Forms.Label();
            this.tBxAjoutClientAdresseTypeNom = new System.Windows.Forms.TextBox();
            this.lblAjoutClientAdresseTypeNom = new System.Windows.Forms.Label();
            this.tBxAjoutClientAdresseNumero = new System.Windows.Forms.TextBox();
            this.lblAjoutClientAdresseNumero = new System.Windows.Forms.Label();
            this.btnAjoutClientValider = new System.Windows.Forms.Button();
            this.btnAjoutClientAnnuler = new System.Windows.Forms.Button();
            this.lblAjoutClientTelephone = new System.Windows.Forms.Label();
            this.tBxAjoutClientNumero = new System.Windows.Forms.TextBox();
            this.tBxClientRaisonSociale = new System.Windows.Forms.TextBox();
            this.tbxDomaineActivité = new System.Windows.Forms.TextBox();
            this.tBxClientTelephone = new System.Windows.Forms.TextBox();
            this.cBxClientTypeTelephone = new System.Windows.Forms.ComboBox();
            this.lblAjoutClientChiffreAffaire = new System.Windows.Forms.Label();
            this.tBxChiffreAffaire = new System.Windows.Forms.TextBox();
            this.lblAjoutClientEffectif = new System.Windows.Forms.Label();
            this.tBxClientEffectif = new System.Windows.Forms.TextBox();
            this.gBxFicheContact = new System.Windows.Forms.GroupBox();
            this.tBxFicheContactProfessionel = new System.Windows.Forms.TextBox();
            this.tBxFicheContactPortable = new System.Windows.Forms.TextBox();
            this.tBxFicheContactFonction = new System.Windows.Forms.TextBox();
            this.tBxFicheContactNomPrenom = new System.Windows.Forms.TextBox();
            this.lblFichecontactProfessionel = new System.Windows.Forms.Label();
            this.lblFicheContactPortable = new System.Windows.Forms.Label();
            this.lblFicheContactFonction = new System.Windows.Forms.Label();
            this.lblFicheContactNomPrenom = new System.Windows.Forms.Label();
            this.lblCommentaire = new System.Windows.Forms.Label();
            this.tBxCommentaire = new System.Windows.Forms.TextBox();
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.btnAjoutClientImportContact = new System.Windows.Forms.Button();
            this.lBxContact = new System.Windows.Forms.ListBox();
            this.lblAjoutClientNature = new System.Windows.Forms.Label();
            this.tBxNature = new System.Windows.Forms.TextBox();
            this.gbxAjoutClientAdresse.SuspendLayout();
            this.gBxFicheContact.SuspendLayout();
            this.gbxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAjoutClientIdNumero
            // 
            this.lblAjoutClientIdNumero.AutoSize = true;
            this.lblAjoutClientIdNumero.Location = new System.Drawing.Point(33, 35);
            this.lblAjoutClientIdNumero.Name = "lblAjoutClientIdNumero";
            this.lblAjoutClientIdNumero.Size = new System.Drawing.Size(44, 13);
            this.lblAjoutClientIdNumero.TabIndex = 0;
            this.lblAjoutClientIdNumero.Text = "Numero";
            // 
            // lblAjoutClientRaisonSociale
            // 
            this.lblAjoutClientRaisonSociale.AutoSize = true;
            this.lblAjoutClientRaisonSociale.Location = new System.Drawing.Point(33, 60);
            this.lblAjoutClientRaisonSociale.Name = "lblAjoutClientRaisonSociale";
            this.lblAjoutClientRaisonSociale.Size = new System.Drawing.Size(76, 13);
            this.lblAjoutClientRaisonSociale.TabIndex = 0;
            this.lblAjoutClientRaisonSociale.Text = "Raison sociale";
            this.lblAjoutClientRaisonSociale.Click += new System.EventHandler(this.lblRaisonSociale_Click);
            // 
            // lblAjoutClientType
            // 
            this.lblAjoutClientType.AutoSize = true;
            this.lblAjoutClientType.Location = new System.Drawing.Point(33, 95);
            this.lblAjoutClientType.Name = "lblAjoutClientType";
            this.lblAjoutClientType.Size = new System.Drawing.Size(27, 13);
            this.lblAjoutClientType.TabIndex = 0;
            this.lblAjoutClientType.Text = "type";
            // 
            // rBtnAjoutClientTypePublic
            // 
            this.rBtnAjoutClientTypePublic.AutoSize = true;
            this.rBtnAjoutClientTypePublic.Location = new System.Drawing.Point(15, 9);
            this.rBtnAjoutClientTypePublic.Name = "rBtnAjoutClientTypePublic";
            this.rBtnAjoutClientTypePublic.Size = new System.Drawing.Size(53, 17);
            this.rBtnAjoutClientTypePublic.TabIndex = 4;
            this.rBtnAjoutClientTypePublic.TabStop = true;
            this.rBtnAjoutClientTypePublic.Text = "public";
            this.rBtnAjoutClientTypePublic.UseVisualStyleBackColor = true;
            this.rBtnAjoutClientTypePublic.CheckedChanged += new System.EventHandler(this.rbtnPublic_CheckedChanged);
            // 
            // rbtnAjoutClientTypePrivé
            // 
            this.rbtnAjoutClientTypePrivé.AutoSize = true;
            this.rbtnAjoutClientTypePrivé.Location = new System.Drawing.Point(106, 9);
            this.rbtnAjoutClientTypePrivé.Name = "rbtnAjoutClientTypePrivé";
            this.rbtnAjoutClientTypePrivé.Size = new System.Drawing.Size(48, 17);
            this.rbtnAjoutClientTypePrivé.TabIndex = 4;
            this.rbtnAjoutClientTypePrivé.TabStop = true;
            this.rbtnAjoutClientTypePrivé.Text = "privé";
            this.rbtnAjoutClientTypePrivé.UseVisualStyleBackColor = true;
            this.rbtnAjoutClientTypePrivé.CheckedChanged += new System.EventHandler(this.rbtnPrivé_CheckedChanged);
            // 
            // lblAjoutClientDomaineActivite
            // 
            this.lblAjoutClientDomaineActivite.Location = new System.Drawing.Point(33, 124);
            this.lblAjoutClientDomaineActivite.Name = "lblAjoutClientDomaineActivite";
            this.lblAjoutClientDomaineActivite.Size = new System.Drawing.Size(59, 31);
            this.lblAjoutClientDomaineActivite.TabIndex = 0;
            this.lblAjoutClientDomaineActivite.Text = "Domaine  d\'activité";
            // 
            // gbxAjoutClientAdresse
            // 
            this.gbxAjoutClientAdresse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbxAjoutClientAdresse.Controls.Add(this.cbxAjoutClientPays);
            this.gbxAjoutClientAdresse.Controls.Add(this.lblAjoutClientAdressePays);
            this.gbxAjoutClientAdresse.Controls.Add(this.tBxAjoutClientAdresseVille);
            this.gbxAjoutClientAdresse.Controls.Add(this.lblAjoutClientAdresseVille);
            this.gbxAjoutClientAdresse.Controls.Add(this.tBxAjoutClientAdresseCodePostal);
            this.gbxAjoutClientAdresse.Controls.Add(this.lblAjoutClientAdresseCodePostal);
            this.gbxAjoutClientAdresse.Controls.Add(this.tBxAjoutClientAdresseTypeNom);
            this.gbxAjoutClientAdresse.Controls.Add(this.lblAjoutClientAdresseTypeNom);
            this.gbxAjoutClientAdresse.Controls.Add(this.tBxAjoutClientAdresseNumero);
            this.gbxAjoutClientAdresse.Controls.Add(this.lblAjoutClientAdresseNumero);
            this.gbxAjoutClientAdresse.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gbxAjoutClientAdresse.Location = new System.Drawing.Point(26, 158);
            this.gbxAjoutClientAdresse.Name = "gbxAjoutClientAdresse";
            this.gbxAjoutClientAdresse.Size = new System.Drawing.Size(323, 166);
            this.gbxAjoutClientAdresse.TabIndex = 6;
            this.gbxAjoutClientAdresse.TabStop = false;
            this.gbxAjoutClientAdresse.Text = "Adresse Client";
            this.gbxAjoutClientAdresse.Enter += new System.EventHandler(this.gbxAdresse_Enter);
            // 
            // cbxAjoutClientPays
            // 
            this.cbxAjoutClientPays.FormattingEnabled = true;
            this.cbxAjoutClientPays.Items.AddRange(new object[] {
            "Afghanistan",
            "Afrique du Sud",
            "Albanie",
            "Algérie",
            "Allemagne",
            "Andorre",
            "Angola",
            "Antigua et Barbuda",
            "Arabie saoudite",
            "Argentine",
            "Arménie",
            "Australie",
            "Autriche",
            "Azerbaïdjan",
            "Bahamas",
            "Bahrein",
            "Bangladesh",
            "Barbade",
            "Belgique",
            "Bélize",
            "Benin",
            "Bhoutan",
            "Biélorussie",
            "Bolivie",
            "Bosnie-Herzégovine",
            "Botswana",
            "Brésil",
            "Brunei",
            "Bulgarie",
            "Burkina Faso",
            "Burundi",
            "Cambodge",
            "Cameroun",
            "Canada",
            "Cap Vert",
            "Centrafrique",
            "Chili",
            "Chine",
            "Chypre",
            "Colombie",
            "Comores",
            "Congo démocratique",
            "Congo",
            "Corée du Nord",
            "Corée du Sud",
            "Costa Rica",
            "Côte d\'Ivoire",
            "Croatie",
            "Cuba",
            "Danemark",
            "Djibouti",
            "Dominique",
            "RépubliqueDominicaine",
            "Egypte",
            "Emirats Arabes Unis",
            "Equateur",
            "Erythrée",
            "Espagne",
            "Estonie",
            "Etats-Unis",
            "Ethiopie",
            "Fidji",
            "Finlande",
            "France",
            "Gabon",
            "Gambie",
            "Géorgie",
            "Ghana",
            "Grèce",
            "Grenade",
            "Groenland",
            "Guatémala",
            "Guinée",
            "Guinée Bissau",
            "Guinée équatoriale",
            "Guyana",
            "Haïti",
            "Honduras",
            "Hong Kong",
            "Hongrie",
            "Inde",
            "Indonésie",
            "Irak",
            "Iran",
            "Irlande",
            "Islande",
            "Israël",
            "Italie",
            "Jamaïque",
            "Japon",
            "Jordanie",
            "Kazakhstan",
            "Kenya",
            "Kirghizstan",
            "Kiribati",
            "Koweït",
            "Laos",
            "Lesotho",
            "Lettonie",
            "Liban",
            "Liberia",
            "Libye",
            "Liechtenstein",
            "Lituanie",
            "Luxembourg",
            "Macédoine",
            "Madagascar",
            "Malaisie",
            "Malawi",
            "Maldives",
            "Mali",
            "Malte",
            "Maroc",
            "Marshall",
            "Maurice",
            "Mauritanie",
            "Mexique",
            "Micronésie",
            "Moldavie",
            "Monaco",
            "Mongolie",
            "Mozambique",
            "Myanmar",
            "Namibie",
            "Népal",
            "Nicaragua",
            "Niger",
            "Nigeria",
            "Norvège",
            "Nouvelle Zélande",
            "Oman",
            "Ouganda",
            "Ouzbekistan",
            "Pakistan",
            "Palau",
            "Palestine",
            "Panama",
            "Papouasie - Nouvelle Guinée",
            "Paraguay",
            "Pays-Bas",
            "Pérou",
            "Philippines",
            "Pologne",
            "Porto Rico",
            "Portugal",
            "Qatar",
            "Roumanie",
            "Royaume-Uni",
            "Russie",
            "Rwanda",
            "Saint Christophe et Nevis",
            "Saint Vincent et les Grenadines",
            "Sainte Lucie",
            "Salomon",
            "Salvador",
            "Samoa",
            "São Tomé et Príncipe",
            "Sénégal",
            "Seychelles",
            "Sierra Leone",
            "Singapour",
            "Slovaquie",
            "Slovénie",
            "Somalie",
            "Somaliland",
            "Soudan",
            "Sri Lanka",
            "Suède",
            "Suisse",
            "Surinam",
            "Syrie",
            "Swaziland",
            "Tadjikistan",
            "Taïwan",
            "Tanzanie",
            "Tchad",
            "Tchéquie",
            "Thaïlande",
            "Tibet",
            "Timor Oriental",
            "Togo",
            "Tonga",
            "Trinité et Tobago",
            "Tunisie",
            "Turkmenistan",
            "Turquie",
            "Tuvalu",
            "Ukraine",
            "Uruguay",
            "Vanuatu",
            "Vatican",
            "Vénézuéla",
            "Vietnam",
            "Yémen",
            "Yougoslavie",
            "Zambie",
            "Zimbabwe"});
            this.cbxAjoutClientPays.Location = new System.Drawing.Point(76, 138);
            this.cbxAjoutClientPays.Name = "cbxAjoutClientPays";
            this.cbxAjoutClientPays.Size = new System.Drawing.Size(121, 21);
            this.cbxAjoutClientPays.TabIndex = 10;
            // 
            // lblAjoutClientAdressePays
            // 
            this.lblAjoutClientAdressePays.Location = new System.Drawing.Point(7, 138);
            this.lblAjoutClientAdressePays.Name = "lblAjoutClientAdressePays";
            this.lblAjoutClientAdressePays.Size = new System.Drawing.Size(42, 19);
            this.lblAjoutClientAdressePays.TabIndex = 0;
            this.lblAjoutClientAdressePays.Text = "Pays ";
            // 
            // tBxAjoutClientAdresseVille
            // 
            this.tBxAjoutClientAdresseVille.Location = new System.Drawing.Point(76, 108);
            this.tBxAjoutClientAdresseVille.Name = "tBxAjoutClientAdresseVille";
            this.tBxAjoutClientAdresseVille.Size = new System.Drawing.Size(100, 20);
            this.tBxAjoutClientAdresseVille.TabIndex = 9;
            // 
            // lblAjoutClientAdresseVille
            // 
            this.lblAjoutClientAdresseVille.AutoSize = true;
            this.lblAjoutClientAdresseVille.Location = new System.Drawing.Point(7, 111);
            this.lblAjoutClientAdresseVille.Name = "lblAjoutClientAdresseVille";
            this.lblAjoutClientAdresseVille.Size = new System.Drawing.Size(26, 13);
            this.lblAjoutClientAdresseVille.TabIndex = 0;
            this.lblAjoutClientAdresseVille.Text = "Ville";
            // 
            // tBxAjoutClientAdresseCodePostal
            // 
            this.tBxAjoutClientAdresseCodePostal.Location = new System.Drawing.Point(76, 76);
            this.tBxAjoutClientAdresseCodePostal.Name = "tBxAjoutClientAdresseCodePostal";
            this.tBxAjoutClientAdresseCodePostal.Size = new System.Drawing.Size(100, 20);
            this.tBxAjoutClientAdresseCodePostal.TabIndex = 8;
            // 
            // lblAjoutClientAdresseCodePostal
            // 
            this.lblAjoutClientAdresseCodePostal.AutoSize = true;
            this.lblAjoutClientAdresseCodePostal.Location = new System.Drawing.Point(7, 79);
            this.lblAjoutClientAdresseCodePostal.Name = "lblAjoutClientAdresseCodePostal";
            this.lblAjoutClientAdresseCodePostal.Size = new System.Drawing.Size(63, 13);
            this.lblAjoutClientAdresseCodePostal.TabIndex = 0;
            this.lblAjoutClientAdresseCodePostal.Text = "Code postal";
            // 
            // tBxAjoutClientAdresseTypeNom
            // 
            this.tBxAjoutClientAdresseTypeNom.Location = new System.Drawing.Point(76, 46);
            this.tBxAjoutClientAdresseTypeNom.Name = "tBxAjoutClientAdresseTypeNom";
            this.tBxAjoutClientAdresseTypeNom.Size = new System.Drawing.Size(159, 20);
            this.tBxAjoutClientAdresseTypeNom.TabIndex = 7;
            // 
            // lblAjoutClientAdresseTypeNom
            // 
            this.lblAjoutClientAdresseTypeNom.Location = new System.Drawing.Point(7, 43);
            this.lblAjoutClientAdresseTypeNom.Name = "lblAjoutClientAdresseTypeNom";
            this.lblAjoutClientAdresseTypeNom.Size = new System.Drawing.Size(68, 33);
            this.lblAjoutClientAdresseTypeNom.TabIndex = 0;
            this.lblAjoutClientAdresseTypeNom.Text = "type et nom de voie";
            // 
            // tBxAjoutClientAdresseNumero
            // 
            this.tBxAjoutClientAdresseNumero.Location = new System.Drawing.Point(76, 20);
            this.tBxAjoutClientAdresseNumero.Name = "tBxAjoutClientAdresseNumero";
            this.tBxAjoutClientAdresseNumero.Size = new System.Drawing.Size(24, 20);
            this.tBxAjoutClientAdresseNumero.TabIndex = 6;
            // 
            // lblAjoutClientAdresseNumero
            // 
            this.lblAjoutClientAdresseNumero.AutoSize = true;
            this.lblAjoutClientAdresseNumero.Location = new System.Drawing.Point(7, 23);
            this.lblAjoutClientAdresseNumero.Name = "lblAjoutClientAdresseNumero";
            this.lblAjoutClientAdresseNumero.Size = new System.Drawing.Size(42, 13);
            this.lblAjoutClientAdresseNumero.TabIndex = 0;
            this.lblAjoutClientAdresseNumero.Text = "numéro";
            // 
            // btnAjoutClientValider
            // 
            this.btnAjoutClientValider.Location = new System.Drawing.Point(36, 592);
            this.btnAjoutClientValider.Name = "btnAjoutClientValider";
            this.btnAjoutClientValider.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutClientValider.TabIndex = 21;
            this.btnAjoutClientValider.Text = "&Valider";
            this.btnAjoutClientValider.UseVisualStyleBackColor = true;
            this.btnAjoutClientValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnAjoutClientAnnuler
            // 
            this.btnAjoutClientAnnuler.Location = new System.Drawing.Point(594, 592);
            this.btnAjoutClientAnnuler.Name = "btnAjoutClientAnnuler";
            this.btnAjoutClientAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutClientAnnuler.TabIndex = 0;
            this.btnAjoutClientAnnuler.Text = "&Annuler";
            this.btnAjoutClientAnnuler.UseVisualStyleBackColor = true;
            this.btnAjoutClientAnnuler.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lblAjoutClientTelephone
            // 
            this.lblAjoutClientTelephone.AutoSize = true;
            this.lblAjoutClientTelephone.Location = new System.Drawing.Point(373, 28);
            this.lblAjoutClientTelephone.Name = "lblAjoutClientTelephone";
            this.lblAjoutClientTelephone.Size = new System.Drawing.Size(58, 13);
            this.lblAjoutClientTelephone.TabIndex = 0;
            this.lblAjoutClientTelephone.Text = "Téléphone";
            // 
            // tBxAjoutClientNumero
            // 
            this.tBxAjoutClientNumero.Location = new System.Drawing.Point(132, 32);
            this.tBxAjoutClientNumero.Name = "tBxAjoutClientNumero";
            this.tBxAjoutClientNumero.Size = new System.Drawing.Size(100, 20);
            this.tBxAjoutClientNumero.TabIndex = 1;
            this.tBxAjoutClientNumero.TextChanged += new System.EventHandler(this.tBxNumero_TextChanged);
            // 
            // tBxClientRaisonSociale
            // 
            this.tBxClientRaisonSociale.Location = new System.Drawing.Point(132, 57);
            this.tBxClientRaisonSociale.Name = "tBxClientRaisonSociale";
            this.tBxClientRaisonSociale.Size = new System.Drawing.Size(100, 20);
            this.tBxClientRaisonSociale.TabIndex = 2;
            // 
            // tbxDomaineActivité
            // 
            this.tbxDomaineActivité.Location = new System.Drawing.Point(132, 132);
            this.tbxDomaineActivité.Name = "tbxDomaineActivité";
            this.tbxDomaineActivité.Size = new System.Drawing.Size(100, 20);
            this.tbxDomaineActivité.TabIndex = 5;
            this.tbxDomaineActivité.TextChanged += new System.EventHandler(this.tbxDomaineActivité_TextChanged);
            // 
            // tBxClientTelephone
            // 
            this.tBxClientTelephone.Location = new System.Drawing.Point(536, 28);
            this.tBxClientTelephone.Name = "tBxClientTelephone";
            this.tBxClientTelephone.Size = new System.Drawing.Size(100, 20);
            this.tBxClientTelephone.TabIndex = 12;
            // 
            // cBxClientTypeTelephone
            // 
            this.cBxClientTypeTelephone.FormattingEnabled = true;
            this.cBxClientTypeTelephone.Items.AddRange(new object[] {
            "Société",
            "Portable",
            "Privé\t"});
            this.cBxClientTypeTelephone.Location = new System.Drawing.Point(442, 28);
            this.cBxClientTypeTelephone.Name = "cBxClientTypeTelephone";
            this.cBxClientTypeTelephone.Size = new System.Drawing.Size(72, 21);
            this.cBxClientTypeTelephone.TabIndex = 11;
            // 
            // lblAjoutClientChiffreAffaire
            // 
            this.lblAjoutClientChiffreAffaire.Location = new System.Drawing.Point(373, 57);
            this.lblAjoutClientChiffreAffaire.Name = "lblAjoutClientChiffreAffaire";
            this.lblAjoutClientChiffreAffaire.Size = new System.Drawing.Size(68, 34);
            this.lblAjoutClientChiffreAffaire.TabIndex = 0;
            this.lblAjoutClientChiffreAffaire.Text = "Chiffre d\'affaire";
            // 
            // tBxChiffreAffaire
            // 
            this.tBxChiffreAffaire.Location = new System.Drawing.Point(442, 61);
            this.tBxChiffreAffaire.Name = "tBxChiffreAffaire";
            this.tBxChiffreAffaire.Size = new System.Drawing.Size(100, 20);
            this.tBxChiffreAffaire.TabIndex = 13;
            this.tBxChiffreAffaire.TextChanged += new System.EventHandler(this.tBxChiffreAffaire_TextChanged);
            // 
            // lblAjoutClientEffectif
            // 
            this.lblAjoutClientEffectif.AutoSize = true;
            this.lblAjoutClientEffectif.Location = new System.Drawing.Point(373, 103);
            this.lblAjoutClientEffectif.Name = "lblAjoutClientEffectif";
            this.lblAjoutClientEffectif.Size = new System.Drawing.Size(40, 13);
            this.lblAjoutClientEffectif.TabIndex = 0;
            this.lblAjoutClientEffectif.Text = "Effectif";
            // 
            // tBxClientEffectif
            // 
            this.tBxClientEffectif.Location = new System.Drawing.Point(442, 100);
            this.tBxClientEffectif.Name = "tBxClientEffectif";
            this.tBxClientEffectif.Size = new System.Drawing.Size(100, 20);
            this.tBxClientEffectif.TabIndex = 14;
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
            this.gBxFicheContact.Location = new System.Drawing.Point(392, 158);
            this.gBxFicheContact.Name = "gBxFicheContact";
            this.gBxFicheContact.Size = new System.Drawing.Size(277, 166);
            this.gBxFicheContact.TabIndex = 16;
            this.gBxFicheContact.TabStop = false;
            this.gBxFicheContact.Text = "Fiche Contact";
            this.gBxFicheContact.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // tBxFicheContactProfessionel
            // 
            this.tBxFicheContactProfessionel.Location = new System.Drawing.Point(119, 112);
            this.tBxFicheContactProfessionel.Name = "tBxFicheContactProfessionel";
            this.tBxFicheContactProfessionel.Size = new System.Drawing.Size(100, 20);
            this.tBxFicheContactProfessionel.TabIndex = 19;
            // 
            // tBxFicheContactPortable
            // 
            this.tBxFicheContactPortable.Location = new System.Drawing.Point(119, 83);
            this.tBxFicheContactPortable.Name = "tBxFicheContactPortable";
            this.tBxFicheContactPortable.Size = new System.Drawing.Size(100, 20);
            this.tBxFicheContactPortable.TabIndex = 18;
            // 
            // tBxFicheContactFonction
            // 
            this.tBxFicheContactFonction.Location = new System.Drawing.Point(119, 56);
            this.tBxFicheContactFonction.Name = "tBxFicheContactFonction";
            this.tBxFicheContactFonction.Size = new System.Drawing.Size(100, 20);
            this.tBxFicheContactFonction.TabIndex = 17;
            // 
            // tBxFicheContactNomPrenom
            // 
            this.tBxFicheContactNomPrenom.Location = new System.Drawing.Point(119, 27);
            this.tBxFicheContactNomPrenom.Name = "tBxFicheContactNomPrenom";
            this.tBxFicheContactNomPrenom.Size = new System.Drawing.Size(100, 20);
            this.tBxFicheContactNomPrenom.TabIndex = 16;
            // 
            // lblFichecontactProfessionel
            // 
            this.lblFichecontactProfessionel.AutoSize = true;
            this.lblFichecontactProfessionel.Location = new System.Drawing.Point(17, 115);
            this.lblFichecontactProfessionel.Name = "lblFichecontactProfessionel";
            this.lblFichecontactProfessionel.Size = new System.Drawing.Size(63, 13);
            this.lblFichecontactProfessionel.TabIndex = 0;
            this.lblFichecontactProfessionel.Text = "professionel";
            // 
            // lblFicheContactPortable
            // 
            this.lblFicheContactPortable.AutoSize = true;
            this.lblFicheContactPortable.Location = new System.Drawing.Point(17, 86);
            this.lblFicheContactPortable.Name = "lblFicheContactPortable";
            this.lblFicheContactPortable.Size = new System.Drawing.Size(46, 13);
            this.lblFicheContactPortable.TabIndex = 0;
            this.lblFicheContactPortable.Text = "Portable";
            // 
            // lblFicheContactFonction
            // 
            this.lblFicheContactFonction.Location = new System.Drawing.Point(17, 49);
            this.lblFicheContactFonction.Name = "lblFicheContactFonction";
            this.lblFicheContactFonction.Size = new System.Drawing.Size(84, 33);
            this.lblFicheContactFonction.TabIndex = 0;
            this.lblFicheContactFonction.Text = "Fonction dans la société";
            // 
            // lblFicheContactNomPrenom
            // 
            this.lblFicheContactNomPrenom.AutoSize = true;
            this.lblFicheContactNomPrenom.Location = new System.Drawing.Point(17, 30);
            this.lblFicheContactNomPrenom.Name = "lblFicheContactNomPrenom";
            this.lblFicheContactNomPrenom.Size = new System.Drawing.Size(67, 13);
            this.lblFicheContactNomPrenom.TabIndex = 0;
            this.lblFicheContactNomPrenom.Text = "Nom prénom";
            // 
            // lblCommentaire
            // 
            this.lblCommentaire.AutoSize = true;
            this.lblCommentaire.Location = new System.Drawing.Point(33, 432);
            this.lblCommentaire.Name = "lblCommentaire";
            this.lblCommentaire.Size = new System.Drawing.Size(68, 13);
            this.lblCommentaire.TabIndex = 0;
            this.lblCommentaire.Text = "Commentaire";
            // 
            // tBxCommentaire
            // 
            this.tBxCommentaire.Location = new System.Drawing.Point(37, 455);
            this.tBxCommentaire.Multiline = true;
            this.tBxCommentaire.Name = "tBxCommentaire";
            this.tBxCommentaire.Size = new System.Drawing.Size(631, 115);
            this.tBxCommentaire.TabIndex = 20;
            // 
            // gbxType
            // 
            this.gbxType.Controls.Add(this.rbtnAjoutClientTypePrivé);
            this.gbxType.Controls.Add(this.rBtnAjoutClientTypePublic);
            this.gbxType.Location = new System.Drawing.Point(90, 86);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(170, 33);
            this.gbxType.TabIndex = 3;
            this.gbxType.TabStop = false;
            // 
            // btnAjoutClientImportContact
            // 
            this.btnAjoutClientImportContact.AutoSize = true;
            this.btnAjoutClientImportContact.Location = new System.Drawing.Point(185, 592);
            this.btnAjoutClientImportContact.Name = "btnAjoutClientImportContact";
            this.btnAjoutClientImportContact.Size = new System.Drawing.Size(94, 23);
            this.btnAjoutClientImportContact.TabIndex = 0;
            this.btnAjoutClientImportContact.Text = "Importer contact";
            this.btnAjoutClientImportContact.UseVisualStyleBackColor = true;
            // 
            // lBxContact
            // 
            this.lBxContact.FormattingEnabled = true;
            this.lBxContact.Location = new System.Drawing.Point(392, 343);
            this.lBxContact.Name = "lBxContact";
            this.lBxContact.Size = new System.Drawing.Size(275, 82);
            this.lBxContact.TabIndex = 0;
            // 
            // lblAjoutClientNature
            // 
            this.lblAjoutClientNature.AutoSize = true;
            this.lblAjoutClientNature.Location = new System.Drawing.Point(373, 132);
            this.lblAjoutClientNature.Name = "lblAjoutClientNature";
            this.lblAjoutClientNature.Size = new System.Drawing.Size(39, 13);
            this.lblAjoutClientNature.TabIndex = 22;
            this.lblAjoutClientNature.Text = "Nature";
            // 
            // tBxNature
            // 
            this.tBxNature.Location = new System.Drawing.Point(442, 129);
            this.tBxNature.Name = "tBxNature";
            this.tBxNature.Size = new System.Drawing.Size(100, 20);
            this.tBxNature.TabIndex = 15;
            // 
            // frmNewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 638);
            this.Controls.Add(this.tBxNature);
            this.Controls.Add(this.lblAjoutClientNature);
            this.Controls.Add(this.lBxContact);
            this.Controls.Add(this.btnAjoutClientImportContact);
            this.Controls.Add(this.gbxType);
            this.Controls.Add(this.tBxCommentaire);
            this.Controls.Add(this.lblCommentaire);
            this.Controls.Add(this.gBxFicheContact);
            this.Controls.Add(this.tBxClientEffectif);
            this.Controls.Add(this.lblAjoutClientEffectif);
            this.Controls.Add(this.tBxChiffreAffaire);
            this.Controls.Add(this.lblAjoutClientChiffreAffaire);
            this.Controls.Add(this.cBxClientTypeTelephone);
            this.Controls.Add(this.tBxClientTelephone);
            this.Controls.Add(this.tbxDomaineActivité);
            this.Controls.Add(this.tBxClientRaisonSociale);
            this.Controls.Add(this.tBxAjoutClientNumero);
            this.Controls.Add(this.lblAjoutClientTelephone);
            this.Controls.Add(this.btnAjoutClientAnnuler);
            this.Controls.Add(this.btnAjoutClientValider);
            this.Controls.Add(this.gbxAjoutClientAdresse);
            this.Controls.Add(this.lblAjoutClientDomaineActivite);
            this.Controls.Add(this.lblAjoutClientType);
            this.Controls.Add(this.lblAjoutClientRaisonSociale);
            this.Controls.Add(this.lblAjoutClientIdNumero);
            this.Name = "frmNewClient";
            this.Text = "Ajout client";
            this.gbxAjoutClientAdresse.ResumeLayout(false);
            this.gbxAjoutClientAdresse.PerformLayout();
            this.gBxFicheContact.ResumeLayout(false);
            this.gBxFicheContact.PerformLayout();
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAjoutClientIdNumero;
        private System.Windows.Forms.Label lblAjoutClientRaisonSociale;
        private System.Windows.Forms.Label lblAjoutClientType;
        private System.Windows.Forms.RadioButton rBtnAjoutClientTypePublic;
        private System.Windows.Forms.RadioButton rbtnAjoutClientTypePrivé;
        private System.Windows.Forms.Label lblAjoutClientDomaineActivite;
        private System.Windows.Forms.GroupBox gbxAjoutClientAdresse;
        private System.Windows.Forms.Label lblAjoutClientAdressePays;
        private System.Windows.Forms.TextBox tBxAjoutClientAdresseVille;
        private System.Windows.Forms.Label lblAjoutClientAdresseVille;
        private System.Windows.Forms.TextBox tBxAjoutClientAdresseCodePostal;
        private System.Windows.Forms.Label lblAjoutClientAdresseCodePostal;
        private System.Windows.Forms.TextBox tBxAjoutClientAdresseTypeNom;
        private System.Windows.Forms.Label lblAjoutClientAdresseTypeNom;
        private System.Windows.Forms.TextBox tBxAjoutClientAdresseNumero;
        private System.Windows.Forms.Label lblAjoutClientAdresseNumero;
        private System.Windows.Forms.ComboBox cbxAjoutClientPays;
        private System.Windows.Forms.Button btnAjoutClientValider;
        private System.Windows.Forms.Button btnAjoutClientAnnuler;
        private System.Windows.Forms.Label lblAjoutClientTelephone;
        private System.Windows.Forms.TextBox tBxClientRaisonSociale;
        private System.Windows.Forms.TextBox tbxDomaineActivité;
        private System.Windows.Forms.TextBox tBxClientTelephone;
        private System.Windows.Forms.ComboBox cBxClientTypeTelephone;
        private System.Windows.Forms.Label lblAjoutClientChiffreAffaire;
        private System.Windows.Forms.TextBox tBxChiffreAffaire;
        private System.Windows.Forms.Label lblAjoutClientEffectif;
        private System.Windows.Forms.TextBox tBxClientEffectif;
        private System.Windows.Forms.GroupBox gBxFicheContact;
        private System.Windows.Forms.TextBox tBxFicheContactProfessionel;
        private System.Windows.Forms.TextBox tBxFicheContactPortable;
        private System.Windows.Forms.TextBox tBxFicheContactFonction;
        private System.Windows.Forms.TextBox tBxFicheContactNomPrenom;
        private System.Windows.Forms.Label lblFichecontactProfessionel;
        private System.Windows.Forms.Label lblFicheContactPortable;
        private System.Windows.Forms.Label lblFicheContactFonction;
        private System.Windows.Forms.Label lblFicheContactNomPrenom;
        private System.Windows.Forms.Label lblCommentaire;
        private System.Windows.Forms.TextBox tBxCommentaire;
        private System.Windows.Forms.GroupBox gbxType;
        private System.Windows.Forms.Button btnAjoutClientImportContact;
        private System.Windows.Forms.ListBox lBxContact;
        public System.Windows.Forms.TextBox tBxAjoutClientNumero;
        private System.Windows.Forms.Label lblAjoutClientNature;
        private System.Windows.Forms.TextBox tBxNature;
    }
}