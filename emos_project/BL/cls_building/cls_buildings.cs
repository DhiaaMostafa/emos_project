using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.IO;
using System.Data.SqlClient;

namespace emos_project.BL.cls_building
{
    class cls_buildings
    {



        //method add_build rent
        public void B_add_build(int cust_id,string build_name,string conservatism,string city,string squar,string street,string  price,string build_type,string build_state,string  area,string order_type,string order_state,string note )
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[13];
            
            param[0] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[0].Value = cust_id;
            param[1] = new SqlParameter("@build_name", SqlDbType.VarChar, 50);
            param[1].Value = build_name;
            param[2] = new SqlParameter("@conservatism", SqlDbType.VarChar, 50);
            param[2].Value = conservatism;
            param[3] = new SqlParameter("@city", SqlDbType.VarChar, 50);
            param[3].Value = city;
            param[4] = new SqlParameter("@squar", SqlDbType.VarChar, 50);
            param[4].Value = squar;
            param[5] = new SqlParameter("@street", SqlDbType.VarChar,50);
            param[5].Value = street;
            param[6] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[6].Value = price;
            param[7] = new SqlParameter("@build_type", SqlDbType.VarChar, 50);
            param[7].Value = build_type;
            param[8] = new SqlParameter("@build_state", SqlDbType.VarChar, 50);
            param[8].Value = build_state;
            param[9] = new SqlParameter("@area", SqlDbType.VarChar,50);
            param[9].Value = area;
            param[10] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[10].Value = order_type;
            param[11] = new SqlParameter("@order_state", SqlDbType.VarChar, 50);
            param[11].Value = order_state;
            param[12] = new SqlParameter("@note", SqlDbType.VarChar,300);
            param[12].Value = note;

            DAL.Executecommand("B_add_build", param);
            DAL.close();
        }//end of method Add_build rent



        //method update_build request rent
        public void B_Update_Request_Rent(int Id, string build_name, string conservatism, string city, string squar, string street, string price, string build_type, string build_state, string area, string order_type, string order_state, string note)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[13];


            
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            param[1] = new SqlParameter("@build_name", SqlDbType.VarChar, 50);
            param[1].Value = build_name;
            param[2] = new SqlParameter("@conservatism", SqlDbType.VarChar, 50);
            param[2].Value = conservatism;
            param[3] = new SqlParameter("@city", SqlDbType.VarChar, 50);
            param[3].Value = city;
            param[4] = new SqlParameter("@squar", SqlDbType.VarChar, 50);
            param[4].Value = squar;
            param[5] = new SqlParameter("@street", SqlDbType.VarChar, 50);
            param[5].Value = street;
            param[6] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[6].Value = price;
            param[7] = new SqlParameter("@build_type", SqlDbType.VarChar, 50);
            param[7].Value = build_type;
            param[8] = new SqlParameter("@build_state", SqlDbType.VarChar, 50);
            param[8].Value = build_state;
            param[9] = new SqlParameter("@area", SqlDbType.VarChar,50);
            param[9].Value = area;
            param[10] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[10].Value = order_type;
            param[11] = new SqlParameter("@order_state", SqlDbType.VarChar, 50);
            param[11].Value = order_state;
            param[12] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[12].Value = note;

            DAL.Executecommand("B_Update_request_rent", param);
            DAL.close();

        }//end of method Update_build request rent




        //get max id build_id
        public DataTable B_Get_max_build_Id()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Select_max_id_build_table", null);
            DAL.close();
            return DT;

        }//end method get max id build_table


        //method add_build rent image
        public void B_Add_Build_Image(int build_Id ,byte [] Image_estate)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;
            param[1] = new SqlParameter("@Image_estate", SqlDbType.Image);
            param[1].Value = Image_estate;
         

            DAL.Executecommand("B_add_build_image", param);
            DAL.close();


        }//end of method Add_build rent image

        //method of get image build
        public DataTable B_Get_Image_Build(int build_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_id", SqlDbType.Int);
            param[0].Value = build_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_image_build", param);
            DAL.close();
            return DT;

        }//end method get image build

        //method add_build request resident
        public void B_Add_Build_Request_Resident(string build_name,int cust_id,  string conservatism, string city, string squar, string street, string price, string build_type, string area, string order_type, string order_state, string note)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[12];
            param[0] = new SqlParameter("@build_name", SqlDbType.VarChar,50);
            param[0].Value = build_name;
            param[1] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[1].Value = cust_id;
            param[2] = new SqlParameter("@conservatism", SqlDbType.VarChar, 50);
            param[2].Value = conservatism;
            param[3] = new SqlParameter("@city", SqlDbType.VarChar, 50);
            param[3].Value = city;
            param[4] = new SqlParameter("@squar", SqlDbType.VarChar, 50);
            param[4].Value = squar;
            param[5] = new SqlParameter("@street", SqlDbType.VarChar, 50);
            param[5].Value = street;
            param[6] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[6].Value = price;
            param[7] = new SqlParameter("@build_type", SqlDbType.VarChar, 50);
            param[7].Value = build_type;
            param[8] = new SqlParameter("@area", SqlDbType.VarChar,50);
            param[8].Value = area;
            param[9] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[9].Value = order_type;
            param[10] = new SqlParameter("@order_state", SqlDbType.VarChar, 50);
            param[10].Value = order_state;
            param[11] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[11].Value = note;

            DAL.Executecommand("B_add_build_request_resident", param);
            DAL.close();


        }//end of method Add_build request resident

        //method update_build request resident
        public void B_Update_Request_Resident(int Id, string conservatism, string city, string squar, string street, string price, string build_type, string area, string order_type, string order_state, string note,string build_name)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[12];



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
            param[5] = new SqlParameter("@price", SqlDbType.VarChar,50);
            param[5].Value = price;
            param[6] = new SqlParameter("@build_type", SqlDbType.VarChar, 50);
            param[6].Value = build_type;
            param[7] = new SqlParameter("@area", SqlDbType.VarChar,50);
            param[7].Value = area;
            param[8] = new SqlParameter("@order_type", SqlDbType.VarChar, 50);
            param[8].Value = order_type;
            param[9] = new SqlParameter("@order_state", SqlDbType.VarChar, 50);
            param[9].Value = order_state;
            param[10] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[10].Value = note;
            param[11] = new SqlParameter("@build_name", SqlDbType.VarChar, 300);
            param[11].Value = build_name;
            DAL.Executecommand("B_Update_request_resident", param);
            DAL.close();

        }//end of method Update_build request resident



        //method to get all renters name
        public DataTable B_Get_All_Renters_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_renters_name", null);
            DAL.close();
            return DT;

        }//end method get all renters name


        //method to get all resident name
        public DataTable B_Get_All_Residents_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_residents_name", null);
            DAL.close();
            return DT;

        }//end method get all residents name

        //method to get all sellers name
        public DataTable B_Get_All_Sellers_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_sellers_name", null);
            DAL.close();
            return DT;

        }//end method get all sellers name

        //method to get all buyers name
        public DataTable B_Get_All_Buyers_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_buyers_name", null);
            DAL.close();
            return DT;

        }//end method get all buyers name


        //method to get all building
        public DataTable B_Get_All_Building()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_building", null);
            DAL.close();
            return DT;

        }//end method get all building

        //method to get all request rent
        public DataTable B_Get_All_Request_Rent()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_request_rent", null);
            DAL.close();
            return DT;

        }//end method get all request rent

    
        //ليعطي كل  طلبات التاجير المعالجة او العمائر الموجرة كليا
        //method to get all request rent full
        public DataTable B_Get_All_Request_Rent_Full()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_request_rent_full", null);
            DAL.close();
            return DT;

        }//end method get all request rent_full



        //ليعطي كل  طلبات التاجير الغير معالجة او العمائر الغير موجرة 
        //method to get all request rent full
        public DataTable B_Get_All_Request_Rent_Empty()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_request_rent_empty", null);
            DAL.close();
            return DT;

        }//end method get all request rent_empty


        //ليعطي كل  طلبات التاجير  المعالجة جزئيا او العمائر  المؤجرة جزئيا 
        //method to get all request rent full
        public DataTable B_Get_All_Request_Rent_Mid_Full()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_request_rent_mid_full", null);
            DAL.close();
            return DT;

        }//end method get all request rent_midd_full


        //ليعطي كل  طلبات الاستاجار المنفذة   
        //method to get all request resident
        public DataTable B_Get_All_Request_Resident()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_request_resident", null);
            DAL.close();
            return DT;

        }//end method get all request resident


        //method to get all request resident proccessed
        public DataTable B_Get_All_Request_Resident_Proccessed()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_request_resident_proccessed", null);
            DAL.close();
            return DT;

        }//end method get all request resident proccessed

        //method to get all request resident unproccessed
        public DataTable B_Get_All_Request_Resident_Unproccessed()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_request_resident_unproccessed", null);
            DAL.close();
            return DT;

        }//end method get all request resident unproccessed

        ////method of getting building information
        //public DataTable Get_Build_Info(int Id)
        //{

        //    DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
        //    DAL.open();
        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@Id", SqlDbType.Int);
        //    param[0].Value = Id;

        //    DataTable DT = new DataTable();
        //    DT = DAL.SelectData("Get_build_info", param);
        //    DAL.close();
        //    return DT;

        //}//end method Get_build_info



        //method to get all request sell
        public DataTable B_Get_All_Request_Sell()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_request_sell", null);
            DAL.close();
            return DT;

        }//end method get all request sell


        //method to get all request buy
        public DataTable B_Get_All_Request_Buy()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_request_buy", null);
            DAL.close();
            return DT;

        }//end method get all request buy


        //method of get all build_conservatism
        public DataTable B_Get_All_Cust_Conservatism()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_Cust_conservatism", null);
            DAL.close();
            return DT;
        }//end of method get all customer_conservatism




        //method of getting build city
        public DataTable B_Get_All_Customer_City(int Id)
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


        //method of getting Get_count_unit_in_build_state
        public DataTable B_Get_All_Count_Unit_in_Build_State(int build_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_count_unit_in_build_state", param);
            DAL.close();
            return DT;

        }//end method Get_Get_count_unit_in_build_state


        //method of checking order_type 
        public DataTable B_Get_Order_Type(int build_id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_id", SqlDbType.Int);
            param[0].Value = build_id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_check_order_type", param);
            DAL.close();
            return DT;

        }//end method of Get request renter info

        public DataTable B_Get_Request_Rent_info(int build_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_request_rent_info", param);
            DAL.close();
            return DT;

        }//end method of get request rent info


        public DataTable B_Get_Request_Resident_info(int build_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_request_rent_info", param);
            DAL.close();
            return DT;

        }//end method of get request rent info


        //method of getting build information
        public DataTable B_Get_build_Info(int Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_build_info", param);
            DAL.close();
            return DT;

        }//end method getting build information



        //method delete request_build
        public void B_Delete_Request_Build(int build_Id)
        {
            DAL.DataAccessLayers dal = new DAL.DataAccessLayers();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;

            dal.Executecommand("B_Delete_request_build", param);

            dal.close();
        }//end of method delete request build




        //method of getting B_Get_all_Unit_In_build_Count information

        public int B_Get_All_Unit_In_build_Count(int build_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            int count;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_unit_in_build_count", param);
            DAL.close();
            count = DT.Rows.Count;
            return count;

        }//end method Get all unit in build count



        //method of getting count build in lease 

        public int B_Get_Count_Build_In_Lease(int build_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            int count;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_count_build_in_lease", param);
            DAL.close();
            count = DT.Rows.Count;
            return count;

        }//end method getting count build in lease 



        //...............


        //method update_order_state_build and unit for seller request
        public void B_Update_Order_State_For_Seller_Request(int build_Id, int unit_Id)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];



            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;
            param[1] = new SqlParameter("@unit_Id", SqlDbType.Int);
            param[1].Value = unit_Id;


            DAL.Executecommand("B_Update_order_state_request_seller", param);
            DAL.close();

        }//end of method Update_ order state build and unit for seller request


          //method update_order_state_build and unit for seller request
        public void B_Update_Order_State_Request_Rent_Build_Unit(int build_Id, int unit_Id)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];



            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;
            param[1] = new SqlParameter("@unit_Id", SqlDbType.Int);
            param[1].Value = unit_Id;


            DAL.Executecommand("B_Update_order_state_request_rent_build_unit", param);
            DAL.close();

        }//end of method Update_ order state build and unit for seller request
        

        
              //method update_order_state_build and unit for seller request
        public void B_Update_Order_State_Request_Seller_Build_Unit(int build_Id, int unit_Id)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];



            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;
            param[1] = new SqlParameter("@unit_Id", SqlDbType.Int);
            param[1].Value = unit_Id;


            DAL.Executecommand("B_Update_order_state_request_seller_build_unit", param);
            DAL.close();

        }//end of method Update_ order state build and unit for seller request

        //method update_order_state_build and unit for buyer request
        public void B_Update_Order_State_For_Buyer_Request(int cust_Id, int build_Id)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];


            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;
            param[1] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[1].Value = build_Id;



            DAL.Executecommand("B_Update_order_state_request_buyer", param);
            DAL.close();

        }//end of method Update_ order state build and unit for buyer request




        //method get all order request buyer build name
        public DataTable Les_Get_All_Order_Request_Buyer_Build_Name(int cust_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_all_order_request_buyer_build_name", param);
            DAL.close();
            return DT;

        }//endmethod get all order request buyer build name



        //method for search build
        public DataTable B_Search_Build(string key)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.VarChar, 50);
            param[0].Value = key;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Search_build", param);
            DAL.close();
            return DT;

        }//end method for search build

 
        //...........


    }//end of class build
}
