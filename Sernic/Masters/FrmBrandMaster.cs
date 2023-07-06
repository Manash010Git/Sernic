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
    public partial class FrmBrandMaster : Form
    {
        BrandMaster Brand = new BrandMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable Dtbrand = new DataTable();
        public FrmBrandMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                Brand.Brand_name = txtBrandName.Text;

                ins = Mas.saveBrandMaster(Brand);

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

                if (txtBrandCode.Text != null)
                {
                    int ins = 0;

                    Brand.Brand_CODE = Convert.ToInt32(txtBrandCode.Text);
                    ins = Mas.DeleteBrandMaster(Brand);
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
                Dtbrand = Mas.GetBatch();
                if (Dtbrand.Rows.Count > 0)
                {
                    frserach.DTab1 = Dtbrand;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtBrandCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = Dtbrand.Select("CODE = '" + txtBrandCode.Text + "'");
                        txtBrandName.Text = str[0]["NAME"].ToString();
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
            txtBrandName.Text = string.Empty;
            txtBrandCode.Text = string.Empty;
        }
    }
}
