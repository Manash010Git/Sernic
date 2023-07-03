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
        public DataTable GetSizeMaster()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select A.SizeCode AS CODE,A.SizeName AS NAME from SizeName A";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public int saveSizeMaster(SizeMaster mas)
        {
            int i = 0;
            string Iteam = "INSERT INTO [dbo].[SizeName] ([SizeName])VALUES('" + mas.Size_name + "')";
            Con.ExecuteQueries(Iteam);

            return i;
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
        public int DeleteSizeMaster(SizeMaster mas)
        {
            int i = 0;
            string BatchMAster = "DELETE FROM SizeName WHERE  SizeCode = ('" + mas.Size_CODE + "')";
            Con.ExecuteQueries(BatchMAster);
            return i;
        }
        public DataTable GetArea()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select A.AREA_CODE AS CODE,A.AREA_NAME AS NAME from AREA_MASTER A";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public int saveAREAMaster(AreaMaster mas)
        {
            int i = 0;
            string Iteam = "INSERT INTO [dbo].[AREA_MASTER] ([AREA_NAME])VALUES('" + mas.Area_name + "')";
            Con.ExecuteQueries(Iteam);

            return i;
        }
        public int DeleteAreaMaster(AreaMaster mas)
        {
            int i = 0;
            string BatchMAster = "DELETE FROM AREA_MASTER WHERE  AREA_CODE = ('" + mas.Area_CODE + "')";
            Con.ExecuteQueries(BatchMAster);
            return i;
        }
        public DataTable GetGoDown()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select A.GODOWN_CODE AS CODE,A.GODOWN_NAME AS NAME from GODOWN_MASTER A";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public int saveGodownMaster(GoDownMaster mas)
        {
            int i = 0;
            string Iteam = "INSERT INTO [dbo].[GODOWN_MASTER] ([GODOWN_NAME])VALUES('" + mas.Godown_name + "')";
            Con.ExecuteQueries(Iteam);

            return i;
        }
        public int DeleteGodownMaster(GoDownMaster mas)
        {
            int i = 0;
            string BatchMAster = "DELETE FROM GODOWN_MASTER WHERE  GODOWN_CODE = ('" + mas.Godown_CODE + "')";
            Con.ExecuteQueries(BatchMAster);
            return i;
        }
        public DataTable GetGrade()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select A.GRADE_CODE AS CODE,A.GRADE_NAME AS NAME from GRADE_MASTER A";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public int saveGradeMaster(GradeMaster mas)
        {
            int i = 0;
            string Iteam = "INSERT INTO [dbo].[GRADE_MASTER] ([GRADE_NAME])VALUES('" + mas.Grade_name + "')";
            Con.ExecuteQueries(Iteam);

            return i;
        }
        public int DeleteGradeMaster(GradeMaster mas)
        {
            int i = 0;
            string BatchMAster = "DELETE FROM GRADE_MASTER WHERE  GRADE_CODE = ('" + mas.Grade_CODE + "')";
            Con.ExecuteQueries(BatchMAster);
            return i;
        }
        public DataTable GetGroup()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select A.GROUP_CODE AS CODE,A.GROUP_NAME AS NAME from GROUP_MASTER A";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public int saveGroupMaster(GroupMaster mas)
        {
            int i = 0;
            string Iteam = "INSERT INTO [dbo].[GROUP_MASTER] ([GroupName])VALUES('" + mas.Group_name + "')";
            Con.ExecuteQueries(Iteam);

            return i;
        }
        public int DeleteGroupMaster(GroupMaster mas)
        {
            int i = 0;
            string BatchMAster = "DELETE FROM GROUP_MASTER WHERE  GroupCode = ('" + mas.Group_CODE + "')";
            Con.ExecuteQueries(BatchMAster);
            return i;
        }
        public DataTable GetProductMaster()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select A.PRODUCT_CODE AS CODE,A.PRODUCT_NAME AS NAME from PRODUCT_MASTER A";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public int saveProductMaster(ProductMaster mas)
        {
            int i = 0;
            string Iteam = "INSERT INTO [dbo].[PRODUCT_MASTER] ([PRODUCT_NAME])VALUES('" + mas.Product_name + "')";
            Con.ExecuteQueries(Iteam);

            return i;
        }
        public int DeleteProductMaster(ProductMaster mas)
        {
            int i = 0;
            string BatchMAster = "DELETE FROM PRODUCT_MASTER WHERE  ProdCode = ('" + mas.Product_CODE + "')";
            Con.ExecuteQueries(BatchMAster);
            return i;
        }
        public DataTable GetCompanyMaster()
        {
            DataTable DTab = new DataTable();
            string str = string.Empty;
            str = "Select A.COMPANY_CODE AS CODE,A.COMPANY_NAME AS NAME from COMPANY_MASTER A";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
        public int saveCompanyMaster(CompanyMaster mas)
        {
            int i = 0;
            string Iteam = "INSERT INTO [dbo].[COMPANY_MASTER] ([COMPANY_NAME])VALUES('" + mas.Company_name + "')";
            Con.ExecuteQueries(Iteam);

            return i;
        }
        public int DeleteCompanyMaster(CompanyMaster mas)
        {
            int i = 0;
            string BatchMAster = "DELETE FROM COMPANY_MASTER WHERE  COMPANY_CODE = ('" + mas.Company_CODE + "')";
            Con.ExecuteQueries(BatchMAster);
            return i;
        }
    }
}
