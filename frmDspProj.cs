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
        /// <summary>
        /// référence du projet à afficher
        /// </summary>
        
        public frmDspProj()
        {
            InitializeComponent();
            
        }
        private void frmDspProjet_Load(object sender, EventArgs e)
        {
            this.afficheProjet();
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

            for (i = 0; i < ListProjets.ArrayStag.Count; i++)
            {
                dr = dt.NewRow();
                dr[0] = ListProjets.ArrayStag[i].codeProjet;
                dr[1] = ListProjets.ArrayStag[i].libelleProjetCourt;
                dr[2] = ListProjets.ArrayStag[i].typeProjet;
                dr[3] = ListProjets.ArrayStag[i].secteurActiviteprojet;
                dr[4] = ListProjets.ArrayStag[i].etapeCycleProjet;
                dr[5] = ListProjets.ArrayStag[i].datePrevue ;
                dr[6] = ListProjets.ArrayStag[i].dateReelle;
                dr[7] = ListProjets.ArrayStag[i].chargeInit;
                dr[8] = ListProjets.ArrayStag[i].remarqueProjet;
                dr[9] = ListProjets.ArrayStag[i].tailleEquipe;
                dr[10] = ListProjets.ArrayStag[i].informationsProjet;
                dr[11] = ListProjets.ArrayStag[i].collaborateursProjet;
                dt.Rows.Add(dr);
            }
            this.frmDspProjDgvProjet.DataSource = dt;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmDspProjBtnQuitterProjet_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
