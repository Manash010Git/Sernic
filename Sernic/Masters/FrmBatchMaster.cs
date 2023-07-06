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
    public partial class FrmBatchMaster : Form
    {
        BatchMaster batch = new BatchMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable Dtbatch = new DataTable();
        public FrmBatchMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                batch.Batch_name = txtBatchName.Text;
               
                ins = Mas.savebatchMaster(batch);

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

                if (txtBatchCode.Text != null)
                {
                    int ins = 0;
                   
                    batch.Batch_CODE = Convert.ToInt32(txtBatchCode.Text);
                    ins = Mas.DeleteBatchMaster(batch);
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
                Dtbatch = Mas.GetBatch();
                if (Dtbatch.Rows.Count > 0)
                {
                    frserach.DTab1 = Dtbatch;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtBatchCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = Dtbatch.Select("CODE = '" + txtBatchCode.Text + "'");
                        txtBatchName.Text = str[0]["NAME"].ToString();
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
            txtBatchCode.Text = string.Empty;
            txtBatchName.Text = string.Empty;
        }
    }
}
