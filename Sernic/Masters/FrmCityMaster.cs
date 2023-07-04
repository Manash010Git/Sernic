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

    public partial class FrmCityMaster : Form
    {
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable Dtcity = new DataTable();
        public FrmCityMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            { 
                int ins = 0;
                CityMaster city = new CityMaster();

                city.City_name = txtcityname.Text;
                city.PinCode_name = txtPinCode.Text;
                ins = Mas.saveCityMaster(city);

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

                if (txtCityCode.Text != null)
                {
                    int ins = 0;
                    CityMaster city = new CityMaster();

                    city.CITY_CODE = Convert.ToInt32(txtCityCode.Text);
                    ins = Mas.DeleteCityMaster(city);
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
                Dtcity = Mas.GetCity();
                if (Dtcity.Rows.Count > 0)
                {
                    frserach.DTab1 = Dtcity;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtCityCode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = Dtcity.Select("CODE = '" + txtCityCode.Text + "'");
                        txtcityname.Text = str[0]["NAME"].ToString();
                        txtPinCode.Text = str[0]["PINCODE"].ToString();
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
            txtCityCode.Text = string.Empty;
            txtcityname.Text = string.Empty;
            txtPinCode.Text = string.Empty;
        }
    }
}
