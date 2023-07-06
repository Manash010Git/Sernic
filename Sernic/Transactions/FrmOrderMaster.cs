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
using Sernic.Masters;

namespace Sernic.Transactions
{
    public partial class FrmOrderMaster : Form
    {
        Order_master Order_property = new Order_master();
        Master Mas = new Master();
        FrmSerach frserach = new FrmSerach();
        DataTable Dtbatch = new DataTable();
        public FrmOrderMaster()
        {
            InitializeComponent();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            Order_property.Order_no =Convert.ToInt32(txtOrderNo.Text);
            Order_property.Entry_Date = DtEntryDate.Text;
            Order_property.Entry_Type = CmbType.Text;
            Order_property.Customer = txtPaty.Text;
            Order_property.State = CmbState.SelectedValue.ToString();
            Order_property.City = CmbCity.SelectedValue.ToString();
            Order_property.Order_type = CmborderType.Text.ToString();
            Order_property.Sold_By = txtSoldBy.Text;
            Order_property.Product = CmbProduct.SelectedValue.ToString();
            Order_property.Brand = CmbBrand.SelectedValue.ToString();
            Order_property.Item = txtItem.Text;
            Order_property.Bill_Date = DtBillDate.Text;
            Order_property.Bill_no = txtBillNo.Text;
            Order_property.Truck_no = txtTruckNo.Text;
            Order_property.PO_NO = txtPONo.Text;
            Order_property.TransPort = CmbTrnsport.SelectedValue.ToString();
            Order_property.Tax = CmbTax.SelectedValue.ToString();
            Order_property.LR_No = txtLRNo.Text;
            Order_property.Freight_no = txtFreightNo.Text;
            

        }

        private void FrmOrderMaster_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sampleDataSet13.ProdName' table. You can move, or remove it, as needed.
            this.prodNameTableAdapter.Fill(this.sampleDataSet13.ProdName);
            // TODO: This line of code loads data into the 'sampleDataSet12.TransType' table. You can move, or remove it, as needed.
            this.transTypeTableAdapter.Fill(this.sampleDataSet12.TransType);
            // TODO: This line of code loads data into the 'sampleDataSet11.TaxMast' table. You can move, or remove it, as needed.
            this.taxMastTableAdapter.Fill(this.sampleDataSet11.TaxMast);
            // TODO: This line of code loads data into the 'sampleDataSet10.CatName' table. You can move, or remove it, as needed.
            this.catNameTableAdapter.Fill(this.sampleDataSet10.CatName);
            // TODO: This line of code loads data into the 'sampleDataSet9.City_Master' table. You can move, or remove it, as needed.
            this.city_MasterTableAdapter.Fill(this.sampleDataSet9.City_Master);
            // TODO: This line of code loads data into the 'sampleDataSet8.CtName' table. You can move, or remove it, as needed.
            this.ctNameTableAdapter.Fill(this.sampleDataSet8.CtName);
            // TODO: This line of code loads data into the 'sampleDataSet7.State_Master' table. You can move, or remove it, as needed.
            this.state_MasterTableAdapter.Fill(this.sampleDataSet7.State_Master);
            // TODO: This line of code loads data into the 'sampleDataSet6.StName' table. You can move, or remove it, as needed.
          //  this.stNameTableAdapter.Fill(this.sampleDataSet6.StName);
            // TODO: This line of code loads data into the 'sampleDataSet5.ItemName' table. You can move, or remove it, as needed.
            this.itemNameTableAdapter.Fill(this.sampleDataSet5.ItemName);
            // TODO: This line of code loads data into the 'sampleDataSet4.BrandName' table. You can move, or remove it, as needed.
            this.brandNameTableAdapter.Fill(this.sampleDataSet4.BrandName);
            // TODO: This line of code loads data into the 'sampleDataSet3.LocName' table. You can move, or remove it, as needed.
            this.locNameTableAdapter.Fill(this.sampleDataSet3.LocName);
            // TODO: This line of code loads data into the 'sampleDataSet2.ShadeName' table. You can move, or remove it, as needed.
            this.shadeNameTableAdapter.Fill(this.sampleDataSet2.ShadeName);
            // TODO: This line of code loads data into the 'sampleDataSet1.BatchName' table. You can move, or remove it, as needed.
            this.batchNameTableAdapter.Fill(this.sampleDataSet1.BatchName);
            // TODO: This line of code loads data into the 'sampleDataSet.SizeName' table. You can move, or remove it, as needed.
            this.sizeNameTableAdapter.Fill(this.sampleDataSet.SizeName);

        }
    }
}
