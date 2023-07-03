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
    public partial class FrmCompanyMaster : Form
    {
        CompanyMaster Company = new CompanyMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtCompany = new DataTable();
        public FrmCompanyMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                Company.Company_name = txtComapnyName.Text;

                ins = Mas.saveCompanyMaster(Company);

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

                if (txtCompanyCode.Text != null)
                {
                    int ins = 0;

                    Company.Company_CODE = Convert.ToInt32(txtCompanyCode.Text);
                    ins = Mas.DeleteCompanyMaster(Company);
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
                DtCompany = Mas.GetCompanyMaster();
                if (DtCompany.Rows.Count > 0)
                {
                    frserach.DTab1 = DtCompany;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtCompanyCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtCompany.Select("CODE = '" + txtCompanyCode.Text + "'");
                        txtComapnyName.Text = str[0]["NAME"].ToString();
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
            txtComapnyName.Text = string.Empty;
            txtCompanyCode.Text = string.Empty;
        }
    }
}
