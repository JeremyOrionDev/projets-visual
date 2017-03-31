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
    public partial class frmUpdClient : frmNewClient
    {
        public frmUpdClient(Client unclient)
        {
            this.leClient = unclient;
            InitializeComponent();
            
        }
        private Client leClient;

        private void frmUpdClient_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
