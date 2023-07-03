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
    public partial class FrmuserMaster : Form
    {
        UserMaster User = new UserMaster();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable Dtuser = new DataTable();
        public FrmuserMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                int ins = 0;
                User.User_name = txtUserName.Text;

                ins = Mas.saveUserMaster(User);

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

                if (txtEmplaoyeeCode.Text != null)
                {
                    int ins = 0;

                    User.Employee_CODE = Convert.ToInt32(txtEmplaoyeeCode.Text);
                    ins = Mas.DeleteUserMaster(User);
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
                Dtuser = Mas.GetUserMaster();
                if (Dtuser.Rows.Count > 0)
                {
                    frserach.DTab1 = Dtuser;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtEmplaoyeeCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = Dtuser.Select("CODE = '" + txtEmplaoyeeCode.Text + "'");
                        txtUserName.Text = str[0]["NAME"].ToString();
                        txtPassword.Text = str[0]["Password"].ToString();
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
            txtEmplaoyeeCode.Text = string.Empty;
            txtUserName.Text = string.Empty;
            txtPassword.Text = string.Empty;
        }
    }
}
