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
    public partial class frmitemmaster : Form
    {
        Master Mas = new Master();
        DataTable DtProduct = new DataTable();
        DataTable DtBrand = new DataTable();
        DataTable DtSize = new DataTable();
        DataTable DtCatgory = new DataTable();
        string strpro = string.Empty;
        string strBrand = string.Empty;
        string strSize = string.Empty;
        string strCatgory = string.Empty;
        public frmitemmaster()
        {
            InitializeComponent();
        }

        private void frmitemmaster_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }
        private void LoadTheme()
        {
            
            DtProduct = Mas.GetProduct();

            foreach (DataRow item in DtProduct.Rows)
            {
                CmbProduct.Properties.Items.Add(item["ProdName"]);
            }

           
            DtBrand = Mas.GetBrand();

            foreach (DataRow item in DtBrand.Rows)
            {
                CmbBrand.Properties.Items.Add(item["BrandName"]);
            }

            
            DtSize = Mas.GetSize();

            foreach (DataRow item in DtSize.Rows)
            {
                CmbSize.Properties.Items.Add(item["SizeName"]);
            }

           
            DtCatgory = Mas.GetCatgory();

            foreach (DataRow item in DtCatgory.Rows)
            {
                CmbCategory.Properties.Items.Add(item["CatName"]);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            MasterSave mas = new MasterSave();
           
            mas.Product_name = strpro;
            mas.category_name = strCatgory;
            mas.Size_name = strSize;
            mas.Brand_name = strBrand;
            mas.Name = txtName.Text;
            mas.Comman_Name = txtCommanName.Text;
            mas.Unit = CmbUnit.SelectedItem.ToString();
            mas.Weights = Convert.ToDecimal(txtWeights.Text);
            mas.Item_Status = CmbIteamStatus.Text;
            mas.Min_Qunantity = txtMinQunantity.Text;
            mas.Maintain_Stock = rdMaintainStock.Text;
            mas.Finish = CmbFinish.Text;
            Mas.saveiteamMaster(mas);
            BtnClear_Click(null,null);
        }

        private void CmbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] str = DtProduct.Select("ProdName = '" + CmbProduct.Text + "'");
            strpro = str[0]["ProdCode"].ToString();
        }

        private void CmbBrand_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] str = DtBrand.Select("BrandName = '" + CmbBrand.Text + "'");
            strBrand = str[0]["BrandCode"].ToString();
        }

        private void CmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] str = DtCatgory.Select("CatName = '" + CmbCategory.Text + "'");
            strCatgory = str[0]["CatCode"].ToString();
        }

        private void CmbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRow[] str = DtSize.Select("SizeName = '" + CmbSize.Text + "'");
            strSize = str[0]["SizeCode"].ToString();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {

        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtCommanName.Text = string.Empty;
            txtMinQunantity.Text = string.Empty;
            txtName.Text = string.Empty;
            txtWeights.Text = string.Empty;
            CmbBrand.Text = string.Empty;
            CmbCategory.Text = string.Empty;
            CmbFinish.Text = string.Empty;
            CmbProduct.Text = string.Empty;
            CmbSize.Text = string.Empty;
            CmbUnit.Text = string.Empty;
           
        }
    }
}
