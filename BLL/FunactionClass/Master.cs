﻿using System;
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
            string JamaUdhar = "INSERT INTO [dbo].[ItemName] ([ProdCode],[BrandCode],[CatCode],[SizeCode],[ItemName],[ItemName1],[Idesc],[ItemWt])VALUES('" +mas.Product_name + "','" + mas.Brand_name + "','" + mas.category_name + "','" + mas.Size_name + "','" + mas.Name + "','" + mas.Comman_Name + "','" + mas.Item_Status + "','" + mas.Weights + "')";
            Con.ExecuteQueries(JamaUdhar);

            return i;
        }
    }
}
