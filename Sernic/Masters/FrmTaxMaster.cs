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
    public partial class FrmTaxMaster : Form
    {
        TaxMaster Tax = new TaxMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtTax = new DataTable();
        public FrmTaxMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                Tax.Tax_name = txtTaxName.Text;

                ins = Mas.saveTaxMaster(Tax);

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

                if (txtTaxCode.Text != null)
                {
                    int ins = 0;

                    Tax.Tax_CODE = Convert.ToInt32(txtTaxCode.Text);
                    ins = Mas.DeleteTaxMaster(Tax);
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
                DtTax = Mas.GetTaxMaster();
                if (DtTax.Rows.Count > 0)
                {
                    frserach.DTab1 = DtTax;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtTaxCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtTax.Select("CODE = '" + txtTaxCode.Text + "'");
                        txtTaxName.Text = str[0]["NAME"].ToString();
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
            txtTaxCode.Text = string.Empty;
            txtTaxName.Text = string.Empty;
        }
    }
}
