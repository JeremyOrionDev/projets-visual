using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABI
{
    /// <summary>
    /// classe partielle d'import de contact en suspend!!!
    /// </summary>
    public partial class ImportContact : Form
    {
        public String choixContact;
        private frmNewContact parent;
        public ImportContact(frmNewContact parent)
        {
            InitializeComponent();
            this.parent = parent;
            for(Int32 i=0; i<DonneesClients.ArrayClient.Count;i++)
            {
                this.cBxSelectionClient.Items.Add( DonneesClients.ArrayClient[i].NomClient);
            }
            for(Int32 j=0;j<ListContact.ArrayStag.Count;j++)
                {
                cBxSelectionContact.Items.Add(ListContact.ArrayStag[j].ContactNomPrenom);
                }
            
        }
        
        private void cBxSelectionClient_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelectionnerContact_Click(object sender, EventArgs e)
        {
            
            //choixContact = cBxSelectionContact.SelectedItem.ToString();
            
        }
    }
}
