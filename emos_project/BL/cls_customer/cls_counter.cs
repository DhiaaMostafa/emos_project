using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace emos_project.BL
{
    class cls_counter
    {
        //method count all customer
        public int Get_All_Customer_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_customer_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all customer

        //method count all saller
        public int Get_All_saller_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_saller_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all saller

        //method count all buyer
        public int Get_All_buyer_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_buyer_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all buyer

      

        //method count all resident
        public int Get_All_Resident_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_resident_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all resident

        //method count all renter
        public int Get_All_renter_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_renter_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all renter

        //method count all owner
        public int Get_All_owner_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_owner_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all owner

        //method count all build count
        public int Get_All_Build_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_build_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all build count


        //method count all unit count
        public int Get_All_Unit_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_unit_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all unit count


        //method count all land count
        public int Get_All_Land_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_land_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all land count


        //method count all lease build count
        public int Get_All_Lease_Build_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_lease_build_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all lease build count



        //method count all lease unit count
        public int Get_All_Lease_Unit_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_lease_unit_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all lease unit count



        //method count all lease land count
        public int Get_All_Lease_Land_Counts()
        {
            int count;
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_lease_land_count", null);
            DAL.close();
            count = DT.Rows.Count;
            return count;
        }//end of count all lease land count







    }
}
