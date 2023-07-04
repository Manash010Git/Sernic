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
    public partial class FrmCategoryMaster : Form
    {
        CategoryMaster Cate = new CategoryMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtCategory = new DataTable();
        public FrmCategoryMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                Cate.Category_name = txtCategoryName.Text;

                ins = Mas.saveCategoryMaster(Cate);

                MessageBox.Show("Successfull Save");
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

                if (txtCategoryCode.Text != null)
                {
                    int ins = 0;

                    Cate.Category_CODE = Convert.ToInt32(txtCategoryCode.Text);
                    ins = Mas.DeleteCategoryMaster(Cate);
                    MessageBox.Show("Successfull Delete");
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
                DtCategory = Mas.GetBatch();
                if (DtCategory.Rows.Count > 0)
                {
                    frserach.DTab1 = DtCategory;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtCategoryCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtCategory.Select("CODE = '" + txtCategoryCode.Text + "'");
                        txtCategoryName.Text = str[0]["NAME"].ToString();
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
            txtCategoryName.Text = string.Empty;
            txtCategoryCode.Text = string.Empty;
        }
    }
}
