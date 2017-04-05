namespace ABI
{
    partial class ImportContact
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
            this.lblSelectionClient = new System.Windows.Forms.Label();
            this.cBxSelectionClient = new System.Windows.Forms.ComboBox();
            this.lblSelectionContact = new System.Windows.Forms.Label();
            this.cBxSelectionContact = new System.Windows.Forms.ComboBox();
            this.btnSelectionnerContact = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSelectionClient
            // 
            this.lblSelectionClient.AutoSize = true;
            this.lblSelectionClient.Location = new System.Drawing.Point(23, 30);
            this.lblSelectionClient.Name = "lblSelectionClient";
            this.lblSelectionClient.Size = new System.Drawing.Size(80, 13);
            this.lblSelectionClient.TabIndex = 0;
            this.lblSelectionClient.Text = "Selection Client";
            // 
            // cBxSelectionClient
            // 
            this.cBxSelectionClient.FormattingEnabled = true;
            this.cBxSelectionClient.Location = new System.Drawing.Point(142, 27);
            this.cBxSelectionClient.Name = "cBxSelectionClient";
            this.cBxSelectionClient.Size = new System.Drawing.Size(121, 21);
            this.cBxSelectionClient.TabIndex = 1;
            this.cBxSelectionClient.SelectedIndexChanged += new System.EventHandler(this.cBxSelectionClient_SelectedIndexChanged);
            // 
            // lblSelectionContact
            // 
            this.lblSelectionContact.AutoSize = true;
            this.lblSelectionContact.Location = new System.Drawing.Point(23, 64);
            this.lblSelectionContact.Name = "lblSelectionContact";
            this.lblSelectionContact.Size = new System.Drawing.Size(90, 13);
            this.lblSelectionContact.TabIndex = 2;
            this.lblSelectionContact.Text = "Selection contact";
            // 
            // cBxSelectionContact
            // 
            this.cBxSelectionContact.FormattingEnabled = true;
            this.cBxSelectionContact.Location = new System.Drawing.Point(142, 64);
            this.cBxSelectionContact.Name = "cBxSelectionContact";
            this.cBxSelectionContact.Size = new System.Drawing.Size(121, 21);
            this.cBxSelectionContact.TabIndex = 3;
            // 
            // btnSelectionnerContact
            // 
            this.btnSelectionnerContact.Location = new System.Drawing.Point(188, 120);
            this.btnSelectionnerContact.Name = "btnSelectionnerContact";
            this.btnSelectionnerContact.Size = new System.Drawing.Size(75, 23);
            this.btnSelectionnerContact.TabIndex = 4;
            this.btnSelectionnerContact.Text = "Sélectionner";
            this.btnSelectionnerContact.UseVisualStyleBackColor = true;
            this.btnSelectionnerContact.Click += new System.EventHandler(this.btnSelectionnerContact_Click);
            // 
            // ImportContact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 166);
            this.Controls.Add(this.btnSelectionnerContact);
            this.Controls.Add(this.cBxSelectionContact);
            this.Controls.Add(this.lblSelectionContact);
            this.Controls.Add(this.cBxSelectionClient);
            this.Controls.Add(this.lblSelectionClient);
            this.Name = "ImportContact";
            this.Text = "ImportContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelectionClient;
        private System.Windows.Forms.ComboBox cBxSelectionClient;
        private System.Windows.Forms.Label lblSelectionContact;
        private System.Windows.Forms.ComboBox cBxSelectionContact;
        private System.Windows.Forms.Button btnSelectionnerContact;
    }
}