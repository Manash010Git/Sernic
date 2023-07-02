using Sernic.Masters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sernic
{
    public partial class MainMDI : Form
    {
      

        public MainMDI()
        {
            InitializeComponent();
        }

        private void toolStripItemmaster_Click(object sender, EventArgs e)
        {
            frmitemmaster Item = new frmitemmaster();
            Item.Show();
        }

        private void toolStripCityMaster_Click(object sender, EventArgs e)
        {
            FrmCityMaster city = new FrmCityMaster();
            city.Show();
        }

        private void batchMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBatchMaster Batch = new FrmBatchMaster();
            Batch.Show();
        }

        private void ledgerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
