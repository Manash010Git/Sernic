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

namespace Sernic.Masters
{
    public partial class frmitemmaster : Form
    {
        Master Mas = new Master();
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
            DataTable DtProduct = new DataTable();
            DtProduct = Mas.GetProduct();

            foreach (DataRow item in DtProduct.Rows)
            {
                CmbProduct.Properties.Items.Add(item["ProdName"]);
            }

            DataTable DtBrand = new DataTable();
            DtBrand = Mas.GetBrand();

            foreach (DataRow item in DtBrand.Rows)
            {
                CmbBrand.Properties.Items.Add(item["BrandName"]);
            }

            DataTable DtSize = new DataTable();
            DtSize = Mas.GetSize();

            foreach (DataRow item in DtSize.Rows)
            {
                CmbSize.Properties.Items.Add(item["SizeName"]);
            }

            DataTable DtCatgory = new DataTable();
            DtCatgory = Mas.GetCatgory();

            foreach (DataRow item in DtCatgory.Rows)
            {
                CmbCategory.Properties.Items.Add(item["CatName"]);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
