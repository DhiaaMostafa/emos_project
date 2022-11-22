using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace emos_project.BL
{
    class cls_customer_type
    {
        //method of get all customer type
        public DataTable Get_All_Cust_Type()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_Cust_Type", null);
            DAL.close();
            return DT;
        }//end of method get all customer type

    }
}
