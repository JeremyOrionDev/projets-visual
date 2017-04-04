namespace ABI
{
    partial class frmUpdClient
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
            this.btnEnregistrer = new System.Windows.Forms.Button();
            this.gbxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnEnregistrer
            // 
            this.btnEnregistrer.Location = new System.Drawing.Point(26, 592);
            this.btnEnregistrer.Name = "btnEnregistrer";
            this.btnEnregistrer.Size = new System.Drawing.Size(75, 23);
            this.btnEnregistrer.TabIndex = 24;
            this.btnEnregistrer.Text = "&Enregistrer";
            this.btnEnregistrer.UseVisualStyleBackColor = true;
            // 
            // frmUpdClient
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(733, 638);
            this.Controls.Add(this.btnEnregistrer);
            this.Name = "frmUpdClient";
            this.Text = "frmUpdClient";
            this.Load += new System.EventHandler(this.frmUpdClient_Load);
            this.Controls.SetChildIndex(this.btnAjoutClientValider, 0);
            this.Controls.SetChildIndex(this.tBxAjoutClientNumero, 0);
            this.Controls.SetChildIndex(this.tBxClientRaisonSociale, 0);
            this.Controls.SetChildIndex(this.tbxDomaineActivité, 0);
            this.Controls.SetChildIndex(this.tBxClientTelephone, 0);
            this.Controls.SetChildIndex(this.cBxClientTypeTelephone, 0);
            this.Controls.SetChildIndex(this.tBxChiffreAffaire, 0);
            this.Controls.SetChildIndex(this.tBxClientEffectif, 0);
            this.Controls.SetChildIndex(this.gbxType, 0);
            this.Controls.SetChildIndex(this.tBxNature, 0);
            this.Controls.SetChildIndex(this.btnEnregistrer, 0);
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnregistrer;
    }
}