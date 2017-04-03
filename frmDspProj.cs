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
    public partial class frmDspProj : Form
    {
        public frmDspProj()
        {
            InitializeComponent();
        }

        private void afficheProjet()
        {
            DataTable dt = new DataTable();
            DataRow dr;
            Int32 i;
            dt.Columns.Add(new DataColumn("Code Projet", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Libellé", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Type", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Secteur d'activité", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Etape", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Date prévue", typeof(System.DateTime)));
            dt.Columns.Add(new DataColumn("Date réelle", typeof(System.DateTime)));
            dt.Columns.Add(new DataColumn("Charge globale estimée", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Remarque", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Taille équipe", typeof(System.Int32)));
            dt.Columns.Add(new DataColumn("Infos générales", typeof(System.String)));
            dt.Columns.Add(new DataColumn("Collaborateurs", typeof(System.String)));

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
