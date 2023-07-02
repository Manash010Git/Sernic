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
    public partial class FrmLedgerMaster : Form
    {
        LedgerMaster mas = new LedgerMaster();
        Master mast = new Master();
        DataTable DtLedger = new DataTable();
        FrmSerach frserach = new FrmSerach();
        public FrmLedgerMaster()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedText == "Yes")
            {
                groupBox1.Visible = true;
            }
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedText == "Yes")
            {
                groupBox2.Visible = true;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                mas.ledger_name = txtPartName.Text;
                mas.Ledger_Short_name = txtLedgerShortName.Text;
                mas.group = txtgroupName.Text;
                mas.state = txtstate.Text;
                mas.city = txtCity.Text;
                mas.PINcode = txtPinCode.Text;
                mas.office_conno = txtofficeNo.Text;
                mas.Address = txtaddress.Text;
                mas.Email_id = txtEmailAdress.Text;
                mas.GST_no = txtGSTNo.Text;
                mas.PANno = txtPANno.Text;
                mas.Bank_name = txtbankName.Text;
                mas.bank_AccNo = txtBanckACNo.Text;
                mas.IFSC_NO = txtIFSCNO.Text;
                mas.Country_name = txtCountry.Text;
                if (comboBox2.SelectedText == "Yes")
                {
                    mas.is_bank = 1;
                    groupBox1.Visible = true;
                }
                else if (comboBox2.SelectedText == "No")
                {
                    mas.is_bank = 0;
                    groupBox1.Visible = false;
                }
                if (comboBox5.SelectedText == "Yes")
                {
                    mas.is_gst = 1;
                    groupBox2.Visible = true;
                }
                else if (comboBox5.SelectedText == "No")
                {
                    mas.is_gst = 0;
                    groupBox1.Visible = false;
                }
                mas.Registration = comboBox4.SelectedText;
                mast.saveLedgerMaster(mas);
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

                if (txtLedgercode.Text != null)
                {
                    int ins = 0;

                    mas.ledger_code = Convert.ToInt32(txtLedgercode.Text);
                    ins = mast.DeleteLedgerMaster(mas);
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
                DtLedger = mast.GetLedgerMaster();
                if (DtLedger.Rows.Count > 0)
                {
                    frserach.DTab1 = DtLedger;
                    frserach.ShowDialog();
                    if (frserach.From2DRow != null)
                    {
                        txtLedgercode.Text = frserach.From2DRow["CODE"].ToString();
                        DataRow[] str = DtLedger.Select("CODE = '" + txtLedgercode.Text + "'");
                        txtPartName.Text = str[0]["NAME"].ToString();
                        txtLedgerShortName.Text = str[0]["LEDGER_SHORT_NAME"].ToString();
                        txtgroupName.Text= str[0]["GROUP_NAME"].ToString();
                        txtstate.Text= str[0]["STATE"].ToString();
                        txtCity.Text= str[0]["CITY"].ToString();
                        txtPinCode.Text= str[0]["PIN_CODE"].ToString();
                        txtofficeNo.Text= str[0]["OFFICE_CONNO"].ToString();
                        txtaddress.Text= str[0]["OFFICE_ADDRESS"].ToString();
                        txtEmailAdress.Text= str[0]["EMAIL"].ToString();
                        txtGSTNo.Text= str[0]["GST_NO"].ToString();
                        txtPANno.Text= str[0]["PAN_NO"].ToString();
                        txtbankName.Text= str[0]["BANK_NAME"].ToString();
                        txtBanckACNo.Text= str[0]["BANK_NO"].ToString();
                        txtIFSCNO.Text= str[0]["IFSC_CODE"].ToString();
                        txtCountry.Text= str[0]["COUNTRY_NAME"].ToString();
                        if (str[0]["IS_BANK"].ToString() == "1")
                        {
                            comboBox2.Text = "Yes";
                        }
                        else if (str[0]["IS_BANK"].ToString() == "0")
                        {
                            comboBox2.Text = "No";
                        }
                        if (str[0]["IS_GST"].ToString() == "1")
                        {
                            comboBox5.Text = "Yes";
                        }
                        else if (str[0]["IS_GST"].ToString() == "0")
                        {
                            comboBox5.Text = "No";
                        }
                        comboBox4.Text = str[0]["REGISTRATION_TYPE"].ToString();

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
            txtPartName.Text = string.Empty;
            txtLedgerShortName.Text = string.Empty;
            txtgroupName.Text = string.Empty;
            txtstate.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtPinCode.Text = string.Empty;
            txtofficeNo.Text = string.Empty;
            txtaddress.Text = string.Empty;
            txtEmailAdress.Text = string.Empty;
            txtGSTNo.Text = string.Empty;
            txtPANno.Text = string.Empty;
            txtbankName.Text = string.Empty;
            txtBanckACNo.Text = string.Empty;
            txtIFSCNO.Text = string.Empty;
            txtCountry.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox5.Text = string.Empty;
            comboBox4.Text = string.Empty;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }
    }
}
