using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace emos_project.BL.cls_lease_land
{
    class cls_lease_land
    {

        //method to get lease_land
        public DataTable Land_Les_Get_All_Lease_Land()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Land_Les_Get_all_lease_land", null);
            DAL.close();
            return DT;

        }//end method get all lease land


        //method to get all lease land sells
        public DataTable Land_Les_Get_All_Lease_Land_Sells()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Land_Les_Get_all_lease_Land_sells", null);
            DAL.close();
            return DT;

        }//end method get all lease land_sells


        //method to get all lease land rent
        public DataTable Land_Les_Get_All_Lease_Land_Rents()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Land_Les_Get_all_lease_land_rent", null);
            DAL.close();
            return DT;

        }//end method get all lease land_rent


        // ..........................................

        //method  all sellers name
        public DataTable Land_Les_Get_All_Sellers_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_sellers_name", null);
            DAL.close();
            return DT;

        }//end method get all  sellers name


        //method get all buyers name
        public DataTable Land_Les_Get_All_Buyers_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_buyers_name", null);
            DAL.close();
            return DT;

        }//end method get all buyers name


        //method get all residents name
        public DataTable Land_Les_Get_All_Residents_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_residents_name", null);
            DAL.close();
            return DT;

        }//end method get all residents name

        //method get all renters name
        public DataTable Land_Les_Get_All_Renters_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_renters_name", null);
            DAL.close();
            return DT;

        }//end method get all renters name


        //method get all lands name
        public DataTable Land_Les_Get_All_Lands_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Land_Get_all_lands_name", null);
            DAL.close();
            return DT;

        }//end method get all lands name

        //method get all lands sell name
        public DataTable Land_Les_Get_All_Lands_Sell_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Land_Get_all_land_sell_name", null);
            DAL.close();
            return DT;

        }//end method get all lands sell name

        //method get all lands rent name
        public DataTable Land_Les_Get_All_Lands_Rent_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Land_Get_all_land_rent_name", null);
            DAL.close();
            return DT;

        }//end method get all lands rent name

        //.........................


        //method get lease land info
        public DataTable Land_Les_Get_Lease_Land_Info(int lease_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@lease_Id", SqlDbType.Int);
            param[0].Value = lease_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Land_Les_Get_lease_land_info", param);
            DAL.close();
            return DT;

        }//end method get lease land info

        //...........................................

        //method of lease add lease land
        public void Land_Les_Add_Lease_Land(int cust_Id,int land_Id, string lease_write_date, string lease_start_date, string lease_end_date, string total_money, string payed_money, string inst_money, string date_pay_money, string clusing_percentage, string estate_percentage, string pay_type, string wat1, string wat2, string lease_type, string note)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[16];

            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;
            param[1] = new SqlParameter("@land_Id", SqlDbType.Int);
            param[1].Value = land_Id;
            param[2] = new SqlParameter("@lease_write_date", SqlDbType.DateTime);
            param[2].Value = lease_write_date;
            param[3] = new SqlParameter("@lease_start_date", SqlDbType.DateTime);
            param[3].Value = lease_start_date;
            param[4] = new SqlParameter("@lease_end_date", SqlDbType.DateTime);
            param[4].Value = lease_end_date;
            param[5] = new SqlParameter("@total_money", SqlDbType.VarChar, 50);
            param[5].Value = total_money;
            param[6] = new SqlParameter("@payed_money", SqlDbType.VarChar, 50);
            param[6].Value = payed_money;
            param[7] = new SqlParameter("@inst_money", SqlDbType.VarChar, 50);
            param[7].Value = inst_money;
            param[8] = new SqlParameter("@date_pay_money", SqlDbType.DateTime);
            param[8].Value = date_pay_money;
            param[9] = new SqlParameter("@clusing_percentage", SqlDbType.VarChar, 50);
            param[9].Value = clusing_percentage;
            param[10] = new SqlParameter("@estate_percentage", SqlDbType.VarChar, 50);
            param[10].Value = estate_percentage;
            param[11] = new SqlParameter("@pay_type", SqlDbType.VarChar, 50);
            param[11].Value = pay_type;
            param[12] = new SqlParameter("@wat1", SqlDbType.VarChar, 50);
            param[12].Value = wat1;
            param[13] = new SqlParameter("@wat2", SqlDbType.VarChar, 50);
            param[13].Value = wat2;
            param[14] = new SqlParameter("@lease_type", SqlDbType.VarChar, 50);
            param[14].Value = lease_type;
            param[15] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[15].Value = note;

            DAL.Executecommand("Land_Les_Add_lease_land", param);
            DAL.close();


        }//end of method Add_lease land


        //method of lease update lease land
        public void Land_Les_Update_Lease_Land(int lease_Id,int land_Id, string lease_write_date, string lease_start_date, string lease_end_date, string total_money, string payed_money, string inst_money, string date_pay_money, string clusing_percentage, string estate_percentage, string pay_type, string wat1, string wat2, string lease_type, string note)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[16];

            param[0] = new SqlParameter("@lease_Id", SqlDbType.Int);
            param[0].Value = lease_Id;
            param[1] = new SqlParameter("@land_Id", SqlDbType.Int);
            param[1].Value = land_Id;
            param[2] = new SqlParameter("@lease_write_date", SqlDbType.DateTime);
            param[2].Value = lease_write_date;
            param[3] = new SqlParameter("@lease_start_date", SqlDbType.DateTime);
            param[3].Value = lease_start_date;
            param[4] = new SqlParameter("@lease_end_date", SqlDbType.DateTime);
            param[4].Value = lease_end_date;
            param[5] = new SqlParameter("@total_money", SqlDbType.VarChar, 50);
            param[5].Value = total_money;
            param[6] = new SqlParameter("@payed_money", SqlDbType.VarChar, 50);
            param[6].Value = payed_money;
            param[7] = new SqlParameter("@inst_money", SqlDbType.VarChar, 50);
            param[7].Value = inst_money;
            param[8] = new SqlParameter("@date_pay_money", SqlDbType.DateTime);
            param[8].Value = date_pay_money;
            param[9] = new SqlParameter("@clusing_percentage", SqlDbType.VarChar, 50);
            param[9].Value = clusing_percentage;
            param[10] = new SqlParameter("@estate_percentage", SqlDbType.VarChar, 50);
            param[10].Value = estate_percentage;
            param[11] = new SqlParameter("@pay_type", SqlDbType.VarChar, 50);
            param[11].Value = pay_type;
            param[12] = new SqlParameter("@wat1", SqlDbType.VarChar, 50);
            param[12].Value = wat1;
            param[13] = new SqlParameter("@wat2", SqlDbType.VarChar, 50);
            param[13].Value = wat2;
            param[14] = new SqlParameter("@lease_type", SqlDbType.VarChar, 50);
            param[14].Value = lease_type;
            param[15] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[15].Value = note;

            DAL.Executecommand("Land_Les_Update_lease_land", param);
            DAL.close();


        }//end of method Update_lease land


        //method delete lease land 
        public void Land_Les_Delete_Lease_Land(int lease_Id)
        {
            DAL.DataAccessLayers dal = new DAL.DataAccessLayers();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@lease_Id", SqlDbType.Int);
            param[0].Value = lease_Id;

            dal.Executecommand("les_Delete_lease_build", param);

            dal.close();
        }//end of method delete lease land

        //.........................


        //method get cust_id, ,land id from lease table 
        public DataTable Land_Les_Get_Ids(int lease_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@lease_Id", SqlDbType.Int);
            param[0].Value = lease_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_Ids", param);
            DAL.close();
            return DT;

        }//end method get lease ids

        //method get land info
        public DataTable Land_Les_Get_Land_Info(int land_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@land_Id", SqlDbType.Int);
            param[0].Value = land_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Land_Les_Get_land_info", param);
            DAL.close();
            return DT;

        }//end method get land info

        //method get owner_info
        public DataTable Land_Les_Get_Owner_Info(int land_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@land_Id", SqlDbType.Int);
            param[0].Value = land_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Land_Les_Get_owner_info", param);
            DAL.close();
            return DT;

        }//end method get owner info


        //method get resident_buyer info
        public DataTable Land_Les_Get_Resident_buyer_Info(int cust_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_resident_buyer_info", param);
            DAL.close();
            return DT;

        }//end method get resident buyer info

        //method get land_board area info
        public DataTable Land_Les_Get_Board_Area(int land_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Land_Id", SqlDbType.Int);
            param[0].Value = land_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Land_Les_Get_board_area_land", param);
            DAL.close();
            return DT;

        }//end method get land board area



    }//end of class

}
