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
    public partial class FrmsizeMaster : Form
    {
        SizeMaster Size = new SizeMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtSize = new DataTable();
        public FrmsizeMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                Size.Size_name = txtSizeName.Text;

                ins = Mas.saveSizeMaster(Size);

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

                if (txtSizeCode.Text != null)
                {
                    int ins = 0;

                    Size.Size_CODE = Convert.ToInt32(txtSizeCode.Text);
                    ins = Mas.DeleteSizeMaster(Size);
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
                DtSize = Mas.GetSize();
                if (DtSize.Rows.Count > 0)
                {
                    frserach.DTab1 = DtSize;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtSizeCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtSize.Select("CODE = '" + txtSizeCode.Text + "'");
                        txtSizeName.Text = str[0]["NAME"].ToString();
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
    }
}
