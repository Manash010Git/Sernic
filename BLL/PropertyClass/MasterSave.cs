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
        public string Ledger_Short_name { get; set; }
        public string group { get; set; }
        public int is_bank { get; set; }
        public string Bank_name { get; set; }
        public string bank_AccNo { get; set; }
        public string IFSC_NO { get; set; }
        public string Country_name { get; set; }
        public string Address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string PINcode { get; set; }
        public string PANno { get; set; }
        public string Registration { get; set; }
        public int is_gst { get; set; }
        public string GST_no { get; set; }
        public string office_conno { get; set; }
        public string Email_id { get; set; }
    }
    public class SizeMaster
    {
        public string Size_name { get; set; }
        public int Size_CODE { get; set; }
    }
    public class AreaMaster
    {
        public string Area_name { get; set; }
        public int Area_CODE { get; set; }
    }
    public class GoDownMaster
    {
        public string Godown_name { get; set; }
        public int Godown_CODE { get; set; }
    }
    public class GradeMaster
    {
        public string Grade_name { get; set; }
        public int Grade_CODE { get; set; }
    }
    public class GroupMaster
    {
        public string Group_name { get; set; }
        public int Group_CODE { get; set; }
    }
    public class ProductMaster
    {
        public string Product_name { get; set; }
        public int Product_CODE { get; set; }
    }
    public class CompanyMaster
    {
        public string Company_name { get; set; }
        public int Company_CODE { get; set; }
    }
}
