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
    public partial class FrmTransTypeMaster : Form
    {
        TransTypeMaster TransType = new TransTypeMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtTransType = new DataTable();
        public FrmTransTypeMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                TransType.TransType_name = txtTransTypeName.Text;
                TransType.TransType = txtTransType.Text;
                ins = Mas.saveTransTypeMaster(TransType);

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

                if (txtTransTypeCode.Text != null)
                {
                    int ins = 0;

                    TransType.TransType_CODE = Convert.ToInt32(txtTransTypeCode.Text);
                    ins = Mas.DeleteTransTypeMaster(TransType);
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
                DtTransType = Mas.GetBatch();
                if (DtTransType.Rows.Count > 0)
                {
                    frserach.DTab1 = DtTransType;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtTransTypeCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtTransType.Select("CODE = '" + txtTransTypeCode.Text + "'");
                        txtTransType.Text = str[0]["NAME"].ToString();
                        txtTransType.Text = str[0]["TransTypeN"].ToString();
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
            txtTransTypeCode.Text = string.Empty;
            txtTransTypeName.Text = string.Empty;
            txtTransType.Text = string.Empty;
        }
    }
}
