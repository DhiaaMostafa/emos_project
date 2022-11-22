using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace emos_project.BL
{
    class cls_customer
    {
        //method to get all customer
        public DataTable Get_All_Cust()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_customer", null);
            DAL.close();
            return DT;

        }//end method get all customer

        //method to get all seller
        public DataTable Get_All_seller()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_seller", null);
            DAL.close();
            return DT;

        }//end method get all seller


        //method to get all buyers
        public DataTable Get_All_buyer()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_buyers", null);
            DAL.close();
            return DT;

        }//end method get all buyer



        //method to get all renters
        public DataTable Get_All_Renters()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_renters", null);
            DAL.close();
            return DT;

        }//end method get all renters



        //method to get all rensidents
        public DataTable Get_All_Residents()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_resident", null);
            DAL.close();
            return DT;

        }//end method get all residents


        //method to get all agents
        public DataTable Get_All_Agents()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_agents", null);
            DAL.close();
            return DT;

        }//end method get all agents


        //method to get all auctioneers
        public DataTable Get_All_Auctioneers()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_acutioneers", null);
            DAL.close();
            return DT;

        }//end method get all auctioneers


        
        //method add_cutomer
        public void Add_Customer(string cust_name, string card_no, string card_loc, string conservatism, string city, string squar, string street, string tel, string phone, string email, string note, string auctioneer, string agent, int cust_type_id, string card_date, byte[] imag)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[16];
           
            param[0] = new SqlParameter("@cust_name", SqlDbType.VarChar, 50);
            param[0].Value = cust_name;
            param[1] = new SqlParameter("@card_no", SqlDbType.VarChar, 50);
            param[1].Value = card_no;
            param[2] = new SqlParameter("@card_loc", SqlDbType.VarChar, 50);
            param[2].Value = card_loc;
            param[3] = new SqlParameter("@conservatism", SqlDbType.VarChar, 50);
            param[3].Value = conservatism;
            param[4] = new SqlParameter("@city", SqlDbType.VarChar, 50);
            param[4].Value = city;
            param[5] = new SqlParameter("@squar", SqlDbType.VarChar, 50);
            param[5].Value = squar;
            param[6] = new SqlParameter("@street", SqlDbType.VarChar, 50);
            param[6].Value = street;
            param[7] = new SqlParameter("@tel", SqlDbType.VarChar, 50);
            param[7].Value = tel;
            param[8] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[8].Value = phone;
            param[9] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[9].Value = email;
            param[10] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[10].Value = note;
            param[11] = new SqlParameter("@auctioneer", SqlDbType.VarChar, 50);
            param[11].Value = auctioneer;
            param[12] = new SqlParameter("@agent", SqlDbType.VarChar, 50);
            param[12].Value = agent;
            param[13] = new SqlParameter("@cust_type_id", SqlDbType.Int);
            param[13].Value = cust_type_id;
            param[14] = new SqlParameter("@card_date", SqlDbType.DateTime);
            param[14].Value = card_date;
            param[15] = new SqlParameter("@imag", SqlDbType.Image);
            param[15].Value = imag;
            DAL.Executecommand("Add_customer", param);
            DAL.close();
        }//end of method Add_customer

        //method update_cutomer
        public void Update_Customer(int Id ,string cust_name, string card_no, string card_loc, string conservatism, string city, string squar, string street, string tel, string phone, string email, string note, string auctioneer, string agent, int cust_type_id, string card_date, byte[] imag)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[17];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            param[1] = new SqlParameter("@cust_name", SqlDbType.VarChar, 50);
            param[1].Value = cust_name;
            param[2] = new SqlParameter("@card_no", SqlDbType.VarChar, 50);
            param[2].Value = card_no;
            param[3] = new SqlParameter("@card_loc", SqlDbType.VarChar, 50);
            param[3].Value = card_loc;
            param[4] = new SqlParameter("@conservatism", SqlDbType.VarChar, 50);
            param[4].Value = conservatism;
            param[5] = new SqlParameter("@city", SqlDbType.VarChar, 50);
            param[5].Value = city;
            param[6] = new SqlParameter("@squar", SqlDbType.VarChar, 50);
            param[6].Value = squar;
            param[7] = new SqlParameter("@street", SqlDbType.VarChar, 50);
            param[7].Value = street;
            param[8] = new SqlParameter("@tel", SqlDbType.VarChar, 50);
            param[8].Value = tel;
            param[9] = new SqlParameter("@phone", SqlDbType.VarChar, 50);
            param[9].Value = phone;
            param[10] = new SqlParameter("@email", SqlDbType.VarChar, 50);
            param[10].Value = email;
            param[11] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[11].Value = note;
            param[12] = new SqlParameter("@auctioneer", SqlDbType.VarChar, 50);
            param[12].Value = auctioneer;
            param[13] = new SqlParameter("@agent", SqlDbType.VarChar, 50);
            param[13].Value = agent;
            param[14] = new SqlParameter("@cust_type_id", SqlDbType.Int);
            param[14].Value = cust_type_id;
            param[15] = new SqlParameter("@card_date", SqlDbType.DateTime);
            param[15].Value = card_date;
            param[16] = new SqlParameter("@imag", SqlDbType.Image);
            param[16].Value = imag;
            DAL.Executecommand("Update_customer", param);
            DAL.close();
        }//end of method Update_customer


        //method delete customer
        public void Delete_Customer(int id)
        {
            DAL.DataAccessLayers dal = new DAL.DataAccessLayers();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            dal.Executecommand("Delete_customer",param);

            dal.close();
        }//end of method delete



        //method of getting customer information
        public DataTable Get_Cust_Info(int Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_cust_info", param);
            DAL.close();
            return DT;

        }//end method Get_cust_info


        //method of getting Get_All_Request_Build
        public DataTable Get_All_Request_Build(int cust_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_request_build", param);
            DAL.close();
            return DT;

        }//end method Get_All_Request_Build


        //method of getting Get_All_Request_land
        public DataTable Get_All_Request_Land(int cust_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_request_land", param);
            DAL.close();
            return DT;

        }//end method Get_All_Request_land


        //method of get all customer_conservatism
        public DataTable Get_All_Cust_Conservatism()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_Cust_conservatism", null);
            DAL.close();
            return DT;
        }//end of method get all customer_conservatism




        //method of getting customer city
        public DataTable Get_All_Customer_City(int Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_customer_city", param);
            DAL.close();
            return DT;

        }//end method Get_cust_city


        
        //method of getting customer image
        public DataTable View_Image(int Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("view_cust_image", param);
            DAL.close();
            return DT;

        }//end method Get_cust_image




        //get max id
        public DataTable Get_max()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("select_max_id", null);
            DAL.close();
            return DT;

        }//end method get max id 



        //method for search customer
        public DataTable Search_Customer(string key)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.VarChar,50);
            param[0].Value = key;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Search_customer", param);
            DAL.close();
            return DT;

        }//end method for search customer



        ////method add_user_account
        //public void Add_User_Account(int cust_id,string user_name ,string user_pass,string user_permission ,string user_status)
        //{
        //    DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
        //    DAL.open();
        //    SqlParameter[] param = new SqlParameter[5];

           
        //    param[0] = new SqlParameter("@cust_id", SqlDbType.Int);
        //    param[0].Value = cust_id;
        //    param[1] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
        //    param[1].Value = user_name;
        //    param[2] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
        //    param[2].Value = user_pass;
        //    param[3] = new SqlParameter("@user_permission", SqlDbType.VarChar, 50);
        //    param[3].Value = user_permission;
        //    param[4] = new SqlParameter("@user_status", SqlDbType.VarChar, 50);
        //    param[4].Value = user_status;
         
        //    DAL.Executecommand("Add_user_account", param);
        //    DAL.close();
        //}//end of method Add_user_account


        //method of get all customer name
        public DataTable Get_All_Cust_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_cust_name", null);
            DAL.close();
            return DT;
        }//end of method get all customer name


        //method delete customer partner
        public void Delete_Customer_Partner(int id)
        {
            DAL.DataAccessLayers dal = new DAL.DataAccessLayers();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            dal.Executecommand("Delete_cust_partner", param);

            dal.close();
        }//end of method delete partner

        //method of getting customer type id 

        public DataTable Get_Cust_Type_Id(int cust_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_cust_type_for_update", param);
            DAL.close();
            return DT;

        }//end method Get_cust_type id 
    


    }//end of class customer 

}
