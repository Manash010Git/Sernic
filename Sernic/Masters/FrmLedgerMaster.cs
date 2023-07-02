using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sernic.Masters
{
    public partial class FrmLedgerMaster : Form
    {
        public FrmLedgerMaster()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedText == "Yes")
            {
                groupBox1.Visible = true;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedText == "Yes")
            {
                groupBox2.Visible = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

        }
    }
}
