using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.PropertyClass
{
   public class MasterSave
    {
        public string Product_name { get; set; }
        public string Size_name { get; set; }
        public string category_name { get; set; }
        public string Brand_name { get; set; }
        public string Name { get; set; }
        public string Comman_Name { get; set; }
        public string Unit { get; set; }
        public decimal Weights { get; set; }
        public string Item_Status { get; set; }
        public string Min_Qunantity { get; set; }
        public string Iteam_Discontinue { get; set; }
        public string Maintain_Stock { get; set; }
        public string Finish { get; set; }

    }
    public class CityMaster
    {
        public string City_name { get; set; }
        public string PinCode_name { get; set; }
        public int CITY_CODE { get; set; }
    }
    public class BatchMaster
    {
        public string Batch_name { get; set; }
        public int Batch_CODE { get; set; }
    }
    public class LedgerMaster
    {
        public int ledger_code { get; set; }
        public string ledger_name { get; set; }
        public string Ldeger_Short_name { get; set; }
        public string group { get; set; }
        public int is_bank { get; set; }
        public string Bank_name { get; set; }
        public string bank_AccNo { get; set; }
        public string IFSC_NO { get; set; }
    }
}
