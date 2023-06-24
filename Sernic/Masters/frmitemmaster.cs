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
            DataTable DT = new DataTable();
            DT = Mas.GetProduct();

            foreach (DataRow item in DT.Rows)
            {
                CmbProduct.Properties.Items.Add(item["ProdName"]);
            }
        }
    }
}
