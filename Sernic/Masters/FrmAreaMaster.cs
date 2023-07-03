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
    public partial class FrmAreaMaster : Form
    {
        AreaMaster Area = new AreaMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtArea = new DataTable();
        public FrmAreaMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                Area.Area_name = txtAreaName.Text;

                ins = Mas.saveAREAMaster(Area);

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

                if (txtAreaCode.Text != null)
                {
                    int ins = 0;

                    Area.Area_CODE = Convert.ToInt32(txtAreaCode.Text);
                    ins = Mas.DeleteAreaMaster(Area);
                    MessageBox.Show("Successfull Delete");
                    BtnClear_Click(null,null);
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
                DtArea = Mas.GetArea();
                if (DtArea.Rows.Count > 0)
                {
                    frserach.DTab1 = DtArea;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtAreaCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtArea.Select("CODE = '" + txtAreaCode.Text + "'");
                        txtAreaName.Text = str[0]["NAME"].ToString();
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
            txtAreaCode.Text = string.Empty;
            txtAreaName.Text = string.Empty;
        }
    }
}
