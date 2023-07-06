using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DLL;
using DLL.Connections;

namespace Sernic.Transactions
{
    public partial class FrmPurchase : Form
    {
        public FrmPurchase()
        {
            InitializeComponent();
        }
        CommanMaster Con = new CommanMaster();
        private void FrmPurchase_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = Con.GetRecordSet("Select LEDGER_CODE,Ledger_Name from Ledger_Master");
                cbVender.DataSource = dt;
                cbVender.DisplayMember = "Ledger_Name";
                cbVender.ValueMember = "LEDGER_CODE";

                 dt = Con.GetRecordSet("Select StateCODE,SatateName from State_Master");
                cbState.DataSource = dt;
                cbState.DisplayMember = "SatateName";
                cbState.ValueMember = "StateCODE";

                dt = Con.GetRecordSet("Select StateCODE,SatateName from State_Master");
                cmbCity.DataSource = dt;
                cmbCity.DisplayMember = "SatateName";
                cmbCity.ValueMember = "StateCODE";
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbGrade_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }
    }
}
