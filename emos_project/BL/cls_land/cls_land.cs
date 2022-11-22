using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace emos_project.BL.cls_land
{
    class cls_land
    {

        /////////////////////////////////////////////
        //these method used with select mostly
        //////////////////////////////////////////

        //method to select all lands
        public DataTable L_Get_All_Lands()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_lands", null);
            DAL.close();
            return DT;

        }//end method get all lands


        //method to request sell
        public DataTable L_Get_All_Request_Sell()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_request_sell", null);
            DAL.close();
            return DT;

        }//end method get all request sell



        //method to select all request sell selled
        public DataTable L_Get_All_Request_Sell_Selled()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_request_sell_selled", null);
            DAL.close();
            return DT;

        }//end method get all request sell selled


        //method to select all request sell selled appart
        public DataTable L_Get_All_Request_Sell_Selled_Appart()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_request_sell_selled_appart", null);
            DAL.close();
            return DT;

        }//end method get all request sell selled appart



        //method to select all request sell unselled
        public DataTable L_Get_All_Request_Sell_Unselled()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_request_sell_unselled", null);
            DAL.close();
            return DT;

        }//end method get all request sell unselled


        //method to select all request buy
        public DataTable L_Get_All_Request_Buy()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_request_buy", null);
            DAL.close();
            return DT;

        }//end method get all request buy


        //method to select all request buy proccessed
        public DataTable L_Get_All_Request_Buy_Proccessed()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_request_buy_proccessed", null);
            DAL.close();
            return DT;

        }//end method get all request buy proccessed


        //method to select all request buy  unproccessed
        public DataTable L_Get_All_Request_Buy_Unproccessed()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_request_buy_unproccessed", null);
            DAL.close();
            return DT;

        }//end method get all request buy unproccessed


        //method to select all request rent
        public DataTable L_Get_All_Request_Rent()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_request_rent", null);
            DAL.close();
            return DT;

        }//end method get all request rent


        //method to select all request resident
        public DataTable L_Get_All_Request_Resident()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_request_resident", null);
            DAL.close();
            return DT;

        }//end method get all request resident



       // ..........................................

        //method  all sellers name
        public DataTable L_Get_All_Sellers_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_sellers_name", null);
            DAL.close();
            return DT;

        }//end method get all  sellers name


        //method get all buyers name
        public DataTable L_Get_All_Buyers_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_buyers_name", null);
            DAL.close();
            return DT;

        }//end method get all buyers name


        //method get all residents name
        public DataTable L_Get_All_Residents_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_residents_name", null);
            DAL.close();
            return DT;

        }//end method get all residents name

        //method get all renters name
        public DataTable L_Get_All_Renters_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_renters_name", null);
            DAL.close();
            return DT;

        }//end method get all renters name


        //method get request sell info
        public DataTable L_Get_Request_Sell_Info(int land_id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@land_id", SqlDbType.Int);
            param[0].Value =land_id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_request_sell_info", param);
            DAL.close();
            return DT;

        }//end method get request sell info


        //method get request land info
        public DataTable L_Get_Request_Land_Info(int land_id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@land_id", SqlDbType.Int);
            param[0].Value = land_id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_request_land_info", param);
            DAL.close();
            return DT;

        }//end method get request land info


        //method get request buy info
        public DataTable L_Get_Request_Buy_Info(int land_id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@land_id", SqlDbType.Int);
            param[0].Value = land_id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_request_buy_info", param);
            DAL.close();
            return DT;

        }//end method get request buy info

        //............................


        //method of check order type 
        public DataTable L_Get_Order_Type(int Land_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@land_id", SqlDbType.Int);
            param[0].Value = Land_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_check_order_type", param);
            DAL.close();
            return DT;

        }//end method check order type

        //method of get image land
        public DataTable L_Get_Image_land(int Land_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@land_id", SqlDbType.Int);
            param[0].Value = Land_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_image_land", param);
            DAL.close();
            return DT;

        }//end method get image land

        //method of view image land
        public DataTable L_View_Image_land(int Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@id", SqlDbType.Int);
            param[0].Value = Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_view_image_land", param);
            DAL.close();
            return DT;

        }//end method view image land

        //method of get board area land
        public DataTable L_Get_Board_Area_Land(int land_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@land_id", SqlDbType.Int);
            param[0].Value =land_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_board_area_land", param);
            DAL.close();
            return DT;

        }//end method get board area land

        //................................................................

        //method add_request sell for land
        public void L_Add_Request_Sell(int cust_id, string land_name, string conservatism, string city, string squar, string street, string price, string order_type, string order_state,string land_type, string land_state, string note,string area)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[13];

            param[0] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[0].Value = cust_id;
            param[1] = new SqlParameter("@land_name", SqlDbType.VarChar, 50);
            param[1].Value = land_name;
            param[2] = new SqlParameter("@conservatism", SqlDbType.VarChar, 50);
            param[2].Value = conservatism;
            param[3] = new SqlParameter("@city", SqlDbType.VarChar, 50);
            param[3].Value = city;
            param[4] = new SqlParameter("@squar", SqlDbType.VarChar, 50);
            param[4].Value = squar;
            param[5] = new SqlParameter("@street", SqlDbType.VarChar, 50);
            param[5].Value = street;
            param[6] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[6].Value = price;
            param[7] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[7].Value = order_type;
            param[8] = new SqlParameter("@order_state", SqlDbType.VarChar, 50);
            param[8].Value = order_state;
            param[9] = new SqlParameter("@land_type", SqlDbType.VarChar, 50);
            param[9].Value = land_type;
            param[10] = new SqlParameter("@land_state", SqlDbType.VarChar, 50);
            param[10].Value = land_state;
            param[11] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[11].Value = note;
            param[12] = new SqlParameter("@area", SqlDbType.VarChar, 50);
            param[12].Value = area;
            DAL.Executecommand("L_add_request_sell", param);
            DAL.close();


        }//end of method Add request sell

        //method update_land request sell
        public void L_Update_Request_Sell(int Id, string land_name, string conservatism, string city, string squar, string street, string price, string order_type,string order_state,string land_type,string land_state,string note,string area)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[13];



            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            param[1] = new SqlParameter("@land_name", SqlDbType.VarChar, 50);
            param[1].Value = land_name;
            param[2] = new SqlParameter("@conservatism", SqlDbType.VarChar, 50);
            param[2].Value = conservatism;
            param[3] = new SqlParameter("@city", SqlDbType.VarChar, 50);
            param[3].Value = city;
            param[4] = new SqlParameter("@squar", SqlDbType.VarChar, 50);
            param[4].Value = squar;
            param[5] = new SqlParameter("@street", SqlDbType.VarChar, 50);
            param[5].Value = street;
            param[6] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[6].Value = price;
            param[7] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[7].Value = order_type;
            param[8] = new SqlParameter("@order_state", SqlDbType.VarChar, 50);
            param[8].Value = order_state; 
            param[9] = new SqlParameter("@land_type", SqlDbType.VarChar, 50);
            param[9].Value = land_type;
            param[10] = new SqlParameter("@land_state", SqlDbType.VarChar, 50);
            param[10].Value = land_state;
            param[11] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[11].Value = note;
            param[12] = new SqlParameter("@area", SqlDbType.VarChar, 50);
            param[12].Value = area;
            DAL.Executecommand("L_Update_request_sell", param);
            DAL.close();

        }//end of method Update_land request sell


        //method add_request buy for land
        public void L_Add_Request_Buy(int cust_id, string conservatism, string city, string squar, string street, string price, string order_type, string order_state, string land_type, string note,string area)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[11];

            param[0] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[0].Value = cust_id;
            param[1] = new SqlParameter("@conservatism", SqlDbType.VarChar, 50);
            param[1].Value = conservatism;
            param[2] = new SqlParameter("@city", SqlDbType.VarChar, 50);
            param[2].Value = city;
            param[3] = new SqlParameter("@squar", SqlDbType.VarChar, 50);
            param[3].Value = squar;
            param[4] = new SqlParameter("@street", SqlDbType.VarChar, 50);
            param[4].Value = street;
            param[5] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[5].Value = price;
            param[6] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[6].Value = order_type;
            param[7] = new SqlParameter("@order_state", SqlDbType.VarChar, 50);
            param[7].Value = order_state;
            param[8] = new SqlParameter("@land_type", SqlDbType.VarChar, 50);
            param[8].Value = land_type;
            param[9] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[9].Value = note;
            param[10] = new SqlParameter("@area", SqlDbType.VarChar, 50);
            param[10].Value = area;

            DAL.Executecommand("L_add_request_buy", param);
            DAL.close();


        }//end of method Add request buy

        //method update_land request buy
        public void L_Update_Request_Buy(int Id, string conservatism, string city, string squar, string street, string price, string order_type, string order_state, string land_type, string note,string area)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[11];



            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
         
            param[1] = new SqlParameter("@conservatism", SqlDbType.VarChar, 50);
            param[1].Value = conservatism;
            param[2] = new SqlParameter("@city", SqlDbType.VarChar, 50);
            param[2].Value = city;
            param[3] = new SqlParameter("@squar", SqlDbType.VarChar, 50);
            param[3].Value = squar;
            param[4] = new SqlParameter("@street", SqlDbType.VarChar, 50);
            param[4].Value = street;
            param[5] = new SqlParameter("@price", SqlDbType.VarChar, 50);
            param[5].Value = price;
            param[6] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[6].Value = order_type;
            param[7] = new SqlParameter("@order_state", SqlDbType.VarChar, 50);
            param[7].Value = order_state;
            param[8] = new SqlParameter("@land_type", SqlDbType.VarChar, 50);
            param[8].Value = land_type;
            param[9] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[9].Value = note;
            param[10] = new SqlParameter("@area", SqlDbType.VarChar, 50);
            param[10].Value = area;
            DAL.Executecommand("L_Update_request_buy", param);
            DAL.close();

        }//end of method Update_land request buy

        //method add_land image
        public void L_Add_Land_Image(int land_Id, byte[] Image_estate)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@land_Id", SqlDbType.Int);
            param[0].Value = land_Id;
            param[1] = new SqlParameter("@Image_estate", SqlDbType.Image);
            param[1].Value = Image_estate;


            DAL.Executecommand("L_add_land_image", param);
            DAL.close();


        }//end of method Add_land image


        //get max id land table
        public DataTable L_Get_Max_Land_Id()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Select_max_id_land_table", null);
            DAL.close();
            return DT;

        }//end method get max id land table

        //method delete request_land
        public void L_Delete_Request_Land(int land_Id)
        {
            DAL.DataAccessLayers dal = new DAL.DataAccessLayers();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@land_Id", SqlDbType.Int);
            param[0].Value = land_Id;

            dal.Executecommand("L_Delete_request_land", param);

            dal.close();
        }//end of method delete request land







    }//end of cls_land class
}
