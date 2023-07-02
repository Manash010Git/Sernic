using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using BLL.PropertyClass;
using DLL.Connections;

namespace BLL.FunactionClass
{
   public class Master
    {
        CommanMaster Con = new CommanMaster();
        public DataTable GetProduct()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select * from ProdName";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public DataTable GetSize()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select * from SizeName";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public DataTable GetCatgory()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select * from CatName";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public DataTable GetBrand()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select * from BrandName";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public DataTable GetCity()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select A.CITY_CODE AS CODE,A.CITY_NAME AS NAME,A.PINCODE from CITY_MASTER A";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public DataTable GetBatch()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select A.BtCode AS CODE,A.BtName AS NAME from BatchName A";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public DataTable GetLedgerMaster()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select A.LEDGER_CODE AS CODE,A.LEDGER_NAME AS NAME,a.LEDGER_SHORT_NAME,a.GROUP_NAME,a.STATE,a.CITY,a.PIN_CODE,a.OFFICE_CONNO,a.OFFICE_ADDRESS,a.EMAIL,a.GST_NO,a.PAN_NO,a.BANK_NAME,a.BANK_NO,a.IFAC_CODE as IFSC_CODE,a.COUNTRY_NAME,a.IS_BANK,a.IS_GST,a.REGISTRATION_TYPE from LEDGER_MASTER A";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public  int saveiteamMaster(MasterSave mas)
        {
            int i = 0;
            string Iteam = "INSERT INTO [dbo].[ItemName] ([ProdCode],[BrandCode],[CatCode],[SizeCode],[ItemName],[ItemName1],[Idesc],[ItemWt])VALUES('" +mas.Product_name + "','" + mas.Brand_name + "','" + mas.category_name + "','" + mas.Size_name + "','" + mas.Name + "','" + mas.Comman_Name + "','" + mas.Item_Status + "','" + mas.Weights + "')";
            Con.ExecuteQueries(Iteam);

            return i;
        }
        public int saveCityMaster(CityMaster mas)
        {
            int i = 0;
            string CityMAster = "INSERT INTO [dbo].[CITY_MASTER] ([CITY_NAME],[PINCODE])VALUES('" + mas.City_name + "','" + mas.PinCode_name + "')";
            Con.ExecuteQueries(CityMAster);

            return i;
        }
        public int saveLedgerMaster(LedgerMaster mas)
        {
            int i = 0;
            string CityMAster = "INSERT INTO [dbo].[LEDGER_MASTER] ([LEDGER_NAME],[LEDGER_SHORT_NAME],[GROUP_NAME],[STATE],[CITY],[PIN_CODE],[OFFICE_CONNO],[OFFICE_ADDRESS],[EMAIL],[GST_NO],[PAN_NO],[BANK_NAME],[BANK_NO],[IFAC_CODE],[COUNTRY_NAME],[IS_BANK],[IS_GST],[REGISTRATION_TYPE])VALUES('" + mas.ledger_name + "','" + mas.Ledger_Short_name + "''" + mas.group + "''" + mas.state + "''" + mas.city + "''" + mas.PINcode + "''" + mas.office_conno + "''" + mas.Address + "''" + mas.Email_id + "''" + mas.GST_no + "''" + mas.PANno + "''" + mas.Bank_name + "''" + mas.bank_AccNo + "''" + mas.IFSC_NO + "''" + mas.Country_name + "''" + mas.is_bank + "''" + mas.is_gst + "''" + mas.Registration + "')";
            Con.ExecuteQueries(CityMAster);

            return i;
        }
        public int DeleteLedgerMaster(LedgerMaster mas)
        {
            int i = 0;
            string CityMAster = "DELETE FROM LEDGER_MASTER WHERE LEDEGER_CODE = ('" + mas.ledger_code + "')";
            Con.ExecuteQueries(CityMAster);

            return i;
        }
        public int DeleteCityMaster(CityMaster mas)
        {
            int i = 0;
            string CityMAster = "DELETE FROM CITY_MASTER WHERE  CITY_CODE = ('" + mas.CITY_CODE + "')";
            Con.ExecuteQueries(CityMAster);

            return i;
        }
        public int savebatchMaster(BatchMaster mas)
        {
            int i = 0;
            string BatchMAster = "INSERT INTO [dbo].[BatchName] ([BtName])VALUES('" + mas.Batch_name + "')";
            Con.ExecuteQueries(BatchMAster);
            return i;
        }
        public int DeleteBatchMaster(BatchMaster mas)
        {
            int i = 0;
            string BatchMAster = "DELETE FROM BatchMAster WHERE  BtCode = ('" + mas.Batch_CODE + "')";
            Con.ExecuteQueries(BatchMAster);
            return i;
        }
    }
}
