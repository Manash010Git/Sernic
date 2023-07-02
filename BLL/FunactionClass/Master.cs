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
