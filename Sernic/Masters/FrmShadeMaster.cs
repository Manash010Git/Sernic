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
    public partial class FrmShadeMaster : Form
    {
        ShadeMaster Shade = new ShadeMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtShade = new DataTable();
        public FrmShadeMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                Shade.Shade_name = txtShadeName.Text;

                ins = Mas.saveShadeMaster(Shade);

                MessageBox.Show("Successfull Save");
                BtnClear_Click(null, null);
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

                if (txtShadeCode.Text != null)
                {
                    int ins = 0;

                    Shade.Shade_CODE = Convert.ToInt32(txtShadeCode.Text);
                    ins = Mas.DeleteShadeMaster(Shade);
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
                DtShade = Mas.GetShadeMaster();
                if (DtShade.Rows.Count > 0)
                {
                    frserach.DTab1 = DtShade;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtShadeCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtShade.Select("CODE = '" + txtShadeCode.Text + "'");
                        txtShadeName.Text = str[0]["NAME"].ToString();
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
            txtShadeName.Text = string.Empty;
            txtShadeCode.Text = string.Empty;
        }
    }
}
