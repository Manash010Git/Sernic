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
        public  int saveiteamMaster(MasterSave mas)
        {
            int i = 0;
            string str = "INSERT INTO [dbo].[ItemName] ([GenCode],[ProdCode],[BrandCode],[CatCode],[SizeCode],[ItemName],[ItemName1],[Idesc],[UniCode],[DivCode],[Reorder],[ItemWt],[Mqty],[Mqty1],[Ordqty],[AOrdqty] ,[COrdqty],[ACOrdqty],[BOrdqty],[ABOrdqty],[Prate],[Srate],[Arate],[Mamt],[Mrp],[Drate],[TaxRate],[Mark],[FilePath],[IRemark],[UseConti],[Mark1],[Temp],[Pqty],[Pqty1],[Pqty2],[Pqty3],[CFQty],[BcCode],[BpCode],[ConCode])VALUES(";

            return i;
        }
    }
}
