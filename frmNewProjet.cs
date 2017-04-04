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
    public partial class frmNewProjet : Form
    {
        public frmNewProjet()
        {
            InitializeComponent();
            frmNewProjetCbxType.Items.AddRange(new String[]
                {"forfait","régie","assistance"});
        }

        private void frmNewProjetBtnValider_Click(object sender, EventArgs e)
        {
            Projet ceProjet = new Projet();
            if(frmNewProjetTbxCodeProjet.Text!="")
            {
                ceProjet.codeProjet = Int32.Parse(frmNewProjetTbxCodeProjet.Text);
            }
            if(frmNewProjetTbxLibelléCourt.Text!="")
            {
                ceProjet.libelleProjetCourt = frmNewProjetTbxLibelléCourt.Text;
            }        
            if(frmNewProjetTbxSecteurActivité.Text!="")
            {
                ceProjet.secteurActiviteprojet = frmNewProjetTbxSecteurActivité.Text;
            }
        }
    }
}
