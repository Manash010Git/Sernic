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
    public partial class FrmGradeMaster : Form
    {
        GradeMaster Grade = new GradeMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtGarde = new DataTable();
        public FrmGradeMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                Grade.Grade_name = txtGradeName.Text;

                ins = Mas.saveGradeMaster(Grade);

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

                if (txtGradeCode.Text != null)
                {
                    int ins = 0;

                    Grade.Grade_CODE = Convert.ToInt32(txtGradeCode.Text);
                    ins = Mas.DeleteGradeMaster(Grade);
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
                DtGarde = Mas.GetGrade();
                if (DtGarde.Rows.Count > 0)
                {
                    frserach.DTab1 = DtGarde;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtGradeCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtGarde.Select("CODE = '" + txtGradeCode.Text + "'");
                        txtGradeName.Text = str[0]["NAME"].ToString();
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
            txtGradeCode.Text = string.Empty;
            txtGradeName.Text = string.Empty;
        }
    }
}
