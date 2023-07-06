using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.FunactionClass;
using BLL.PropertyClass;

namespace Sernic.Masters
{
    public partial class FrmGoDownMaster : Form
    {
        GoDownMaster Godown = new GoDownMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtGodown = new DataTable();
        public FrmGoDownMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                Godown.Godown_name = txtGodownName.Text;

                ins = Mas.saveGodownMaster(Godown);

                MessageBox.Show("Successfull Save");
                BtnClear_Click(null,null);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtGoDownCode.Text != null)
                {
                    int ins = 0;

                    Godown.Godown_CODE = Convert.ToInt32(txtGoDownCode.Text);
                    ins = Mas.DeleteGodownMaster(Godown);
                    MessageBox.Show("Successfull Delete");
                    BtnClear_Click(null, null);
                }
                else
                {
                    MessageBox.Show("please Retry Agein Select");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            try
            {
                DtGodown = Mas.GetGoDown();
                if (DtGodown.Rows.Count > 0)
                {
                    frserach.DTab1 = DtGodown;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtGoDownCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtGodown.Select("CODE = '" + txtGoDownCode.Text + "'");
                        txtGodownName.Text = str[0]["NAME"].ToString();
                    }
                    frserach.Hide();
                    frserach.Dispose();
                    frserach = null;
                }
                else
                {
                    MessageBox.Show("No Data Found..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtGoDownCode.Text = string.Empty;
            txtGodownName.Text = string.Empty;
        }
    }
}
