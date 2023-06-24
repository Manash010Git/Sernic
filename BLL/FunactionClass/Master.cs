using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
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
            str = "Select ProdName from ProdName";
            DTab = Con.GetRecordSet(str);
            return DTab;
        }
    }
}
