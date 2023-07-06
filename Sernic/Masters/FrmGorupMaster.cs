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
    public partial class FrmGorupMaster : Form
    {
        GroupMaster group = new GroupMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable DtGroup = new DataTable();
        public FrmGorupMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                group.Group_name = txtGroupName.Text;

                ins = Mas.saveGroupMaster(group);

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

                if (txtGroupCode.Text != null)
                {
                    int ins = 0;

                    group.Group_CODE = Convert.ToInt32(txtGroupCode.Text);
                    ins = Mas.DeleteGroupMaster(group);
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
                DtGroup = Mas.GetGroup();
                if (DtGroup.Rows.Count > 0)
                {
                    frserach.DTab1 = DtGroup;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtGroupCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtGroup.Select("CODE = '" + txtGroupCode.Text + "'");
                        txtGroupName.Text = str[0]["NAME"].ToString();
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
            txtGroupCode.Text = string.Empty;
            txtGroupName.Text = string.Empty;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGroupCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtGroupName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
