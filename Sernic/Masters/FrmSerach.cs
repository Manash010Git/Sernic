using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sernic.Masters
{
    public partial class FrmSerach : Form
    {
        public DataTable DTab1;
        public DataRow From2DRow { get; set; }
        public string selectedvalue = "";
        public string ColumnHeaderCaption { get; internal set; }
        public string ColumntoHide { get; internal set; }
        public FrmSerach()
        {
            InitializeComponent();
        }

        private void FrmSerach_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DTab1;
            dataGridView1.Refresh();
        }
        public void selectRow()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Inv_No");
                dt.Columns.Add("Inv_Date");
                dt.Columns.Add("Party_Name");
                dt.Columns.Add("KG");
                dt.Columns.Add("Rate");
                dt.Columns.Add("Amount");
                DataGridViewRow row = dataGridView1.SelectedRows[0];
                var DRow1 = row.Cells["Inv_No"].Value.ToString();


                dt.Rows.Add(DRow1);
                foreach (DataRow Drow in dt.Rows)
                {
                    From2DRow = Drow;
                    Drow["CODE"] = dt.Rows[0]["CODE"].ToString();
                }

                this.Close();
                //SendKeys.Send("{TAB}");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dataGridView1_Enter(object sender, EventArgs e)
        {
            selectRow();
        }
    }
}
