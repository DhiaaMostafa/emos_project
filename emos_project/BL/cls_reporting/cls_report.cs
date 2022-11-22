using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace emos_project.BL.cls_reporting
{
    class cls_report
    {


        //method Rep_Get_All_Cust_Name
        public DataTable Rep_Get_All_Cust_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Rep_get_all_cust_name", null);
            DAL.close();
            return DT;

        }//end method Rep_Get_All_Cust_Name


        //method rep_get_all_cust_type
        public DataTable Rep_Get_All_Cust_Type()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("rep_get_all_cust_type", null);
            DAL.close();
            return DT;

        }//end method rep_get_all_cust_type

        //method of get all customer_conservatism
        public DataTable Rep_Get_All_Cust_Conservatism()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_Cust_conservatism", null);
            DAL.close();
            return DT;
        }//end of method get all customer_conservatism

        
    }
}
