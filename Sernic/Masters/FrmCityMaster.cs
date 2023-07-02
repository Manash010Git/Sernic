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
        public FrmCityMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            int ins = 0;
            CityMaster city = new CityMaster();

            city.City_name = txtcityname.Text;
            city.PinCode_name = txtPinCode.Text;
            ins = Mas.saveCityMaster(city);
            if (ins > 0)
            {
                MessageBox.Show("Successfull Save");
            }
            else
            {
                MessageBox.Show("please Retry Agein Save");
            }
        }

        private void BtnCancle_Click(object sender, EventArgs e)
        {
            if (txtCityCode.Text != null)
            {
                int ins = 0;
                CityMaster city = new CityMaster();

                city.CITY_CODE =Convert.ToInt32(txtCityCode.Text);
                ins = Mas.DeleteCityMaster(city);
                if (ins > 0)
                {
                    MessageBox.Show("Successfull Delete");
                }
                else
                {
                    MessageBox.Show("please Retry Agein Select");
                }
            }
            else
            {
                MessageBox.Show("please Retry Agein Select");
            }
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {

        }
    }
}
