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
    public partial class FrmProduactMaster : Form
    {
        ProductMaster Product = new ProductMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtProduct = new DataTable();
        public FrmProduactMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                Product.Product_name = txtProductName.Text;

                ins = Mas.saveProductMaster(Product);

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

                if (txtProductCode.Text != null)
                {
                    int ins = 0;

                    Product.Product_CODE = Convert.ToInt32(txtProductCode.Text);
                    ins = Mas.DeleteProductMaster(Product);
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
                DtProduct = Mas.GetProduct();
                if (DtProduct.Rows.Count > 0)
                {
                    frserach.DTab1 = DtProduct;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtProductCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtProduct.Select("CODE = '" + txtProductCode.Text + "'");
                        txtProductName.Text = str[0]["NAME"].ToString();
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
            txtProductCode.Text = string.Empty;
            txtProductName.Text = string.Empty;
        }
    }
}
