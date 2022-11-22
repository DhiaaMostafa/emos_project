using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace emos_project.BL.cls_lease_build
{
    class cls_lease_build
    {

        //method to get lease_build
        public DataTable Les_Get_All_Lease_Build()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_all_lease_build", null);
            DAL.close();
            return DT;

        }//end method get all lease build


        //method to get all lease build sells
        public DataTable Les_Get_All_Lease_Build_Sells()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_all_lease_build_sells", null);
            DAL.close();
            return DT;

        }//end method get all lease build_sells


        //method to get all lease build rent
        public DataTable Les_Get_All_Lease_Build_Rents()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_all_lease_build_rent", null);
            DAL.close();
            return DT;

        }//end method get all lease build_rent


        // ..........................................

        //method  all sellers name
        public DataTable Les_Get_All_Sellers_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_sellers_name", null);
            DAL.close();
            return DT;

        }//end method get all  sellers name


        //method get all buyers name
        public DataTable Les_Get_All_Buyers_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_all_buyers_name", null);
            DAL.close();
            return DT;

        }//end method get all buyers name


        //method get all residents name
        public DataTable Les_Get_All_Residents_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_residents_name", null);
            DAL.close();
            return DT;

        }//end method get all residents name

        //method get all renters name
        public DataTable Les_Get_All_Renters_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("L_Get_all_renters_name", null);
            DAL.close();
            return DT;

        }//end method get all renters name

        //........................................


        //method get all build name
        public DataTable Les_Get_All_Build_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_all_build_name", null);
            DAL.close();
            return DT;

        }//end method get all build_name


        //method get all rent build name
        public DataTable Les_Get_All_Rent_Build_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_all_rent_build_name", null);
            DAL.close();
            return DT;

        }//end method get all rent build_name


        //method get all sell build name
        public DataTable Les_Get_All_Sell_Build_Name()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_all_sell_build_name", null);
            DAL.close();
            return DT;

        }//end method get all sell build_name



        //method get all unit name
        public DataTable Les_Get_All_Unit_Name(int build_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_all_unit_name", param);
            DAL.close();
            return DT;

        }//end method get all unit name

        //..................................................

        //method of lease add lease build 
        public void Les_Add_Lease_Build(int cust_Id,int build_Id,int unit_Id,string lease_write_date,string lease_start_date,string lease_end_date,string total_money,string payed_money,string inst_money,string date_pay_money,string clusing_percentage ,string estate_percentage,string pay_type,string wat1,string wat2,string lease_type,string note)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[17];

            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;
            param[1] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[1].Value = build_Id;
            param[2] = new SqlParameter("@unit_Id", SqlDbType.Int);
            param[2].Value = unit_Id;
            param[3] = new SqlParameter("@lease_write_date", SqlDbType.DateTime);
            param[3].Value = lease_write_date;
            param[4] = new SqlParameter("@lease_start_date", SqlDbType.DateTime);
            param[4].Value = lease_start_date;
            param[5] = new SqlParameter("@lease_end_date", SqlDbType.DateTime);
            param[5].Value = lease_end_date;
            param[6] = new SqlParameter("@total_money", SqlDbType.VarChar, 50);
            param[6].Value = total_money;
            param[7] = new SqlParameter("@payed_money", SqlDbType.VarChar, 50);
            param[7].Value = payed_money;
            param[8] = new SqlParameter("@inst_money", SqlDbType.VarChar, 50);
            param[8].Value = inst_money;
            param[9] = new SqlParameter("@date_pay_money", SqlDbType.DateTime);
            param[9].Value = date_pay_money;
            param[10] = new SqlParameter("@clusing_percentage", SqlDbType.VarChar, 50);
            param[10].Value = clusing_percentage;
            param[11] = new SqlParameter("@estate_percentage", SqlDbType.VarChar,50);
            param[11].Value = estate_percentage;
            param[12] = new SqlParameter("@pay_type", SqlDbType.VarChar, 50);
            param[12].Value = pay_type;
            param[13] = new SqlParameter("@wat1", SqlDbType.VarChar, 50);
            param[13].Value = wat1;
            param[14] = new SqlParameter("@wat2", SqlDbType.VarChar, 50);
            param[14].Value = wat2;
            param[15] = new SqlParameter("@lease_type", SqlDbType.VarChar, 50);
            param[15].Value = lease_type;
            param[16] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[16].Value = note;

            DAL.Executecommand("Les_Add_lease_build", param);
            DAL.close();


        }//end of method Add_lease build



        //method of lease add lease build without unit
        public void Les_Add_Lease_Build_Without_Unit(int cust_Id, int build_Id, string lease_write_date, string lease_start_date, string lease_end_date, string total_money, string payed_money, string inst_money, string date_pay_money, string clusing_percentage, string estate_percentage, string pay_type, string wat1, string wat2, string lease_type, string note)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[16];

            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;
            param[1] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[1].Value = build_Id;
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

            DAL.Executecommand("Les_Add_lease_build_without_unit", param);
            DAL.close();

                    }//end of method Add_lease build without unit


              //method of lease update lease build 
        public void Les_Update_Lease_Build(int lease_Id,int build_Id,int unit_Id,string lease_write_date,string lease_start_date,string lease_end_date,string total_money,string payed_money,string inst_money,string date_pay_money,string clusing_percentage ,string estate_percentage,string pay_type,string wat1,string wat2,string lease_type,string note)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[17];

            param[0] = new SqlParameter("@lease_Id", SqlDbType.Int);
            param[0].Value = lease_Id;
            param[1] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[1].Value = build_Id;
            param[2] = new SqlParameter("@unit_Id", SqlDbType.Int);
            param[2].Value = unit_Id;
            param[3] = new SqlParameter("@lease_write_date", SqlDbType.DateTime);
            param[3].Value = lease_write_date;
            param[4] = new SqlParameter("@lease_start_date", SqlDbType.DateTime);
            param[4].Value = lease_start_date;
            param[5] = new SqlParameter("@lease_end_date", SqlDbType.DateTime);
            param[5].Value = lease_end_date;
            param[6] = new SqlParameter("@total_money", SqlDbType.VarChar, 50);
            param[6].Value = total_money;
            param[7] = new SqlParameter("@payed_money", SqlDbType.VarChar, 50);
            param[7].Value = payed_money;
            param[8] = new SqlParameter("@inst_money", SqlDbType.VarChar, 50);
            param[8].Value = inst_money;
            param[9] = new SqlParameter("@date_pay_money", SqlDbType.DateTime);
            param[9].Value = date_pay_money;
            param[10] = new SqlParameter("@clusing_percentage", SqlDbType.VarChar, 50);
            param[10].Value = clusing_percentage;
            param[11] = new SqlParameter("@estate_percentage", SqlDbType.VarChar,50);
            param[11].Value = estate_percentage;
            param[12] = new SqlParameter("@pay_type", SqlDbType.VarChar, 50);
            param[12].Value = pay_type;
            param[13] = new SqlParameter("@wat1", SqlDbType.VarChar, 50);
            param[13].Value = wat1;
            param[14] = new SqlParameter("@wat2", SqlDbType.VarChar, 50);
            param[14].Value = wat2;
            param[15] = new SqlParameter("@lease_type", SqlDbType.VarChar, 50);
            param[15].Value = lease_type;
            param[16] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[16].Value = note;

            DAL.Executecommand("Les_Update_lease_build", param);
            DAL.close();


        }//end of method Update_lease build


        //method delete lease
        public void Les_Delete_Lease_Build(int lease_Id)
        {
            DAL.DataAccessLayers dal = new DAL.DataAccessLayers();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@lease_Id", SqlDbType.Int);
            param[0].Value =lease_Id;

            dal.Executecommand("les_Delete_lease_build", param);

            dal.close();
        }//end of method delete lease build


        //.........................................



        //method get lease build info
        public DataTable Les_Get_Lease_Build_Info(int lease_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@lease_Id", SqlDbType.Int);
            param[0].Value = lease_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_lease_build_info", param);
            DAL.close();
            return DT;

        }//end method get lease build info


        //method get build info
        public DataTable Les_Get_Build_Info(int build_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_build_info", param);
            DAL.close();
            return DT;

        }//end method get build info




        //method get unit in build info
        public DataTable Les_Get_Unit_In_Build_Info(int unit_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@unit_Id", SqlDbType.Int);
            param[0].Value = unit_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_unit_in_build_info", param);
            DAL.close();
            return DT;

        }//end method get unit in  build info

        //method get owner info
        public DataTable Les_Get_Owner_Info(int build_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_owner_info", param);
            DAL.close();
            return DT;

        }//end method get owner info


        //method get resident_buyer info
        public DataTable Les_Get_Resident_buyer_Info(int cust_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value =cust_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Les_Get_resident_buyer_info", param);
            DAL.close();
            return DT;

        }//end method get resident buyer info


        //method get cust_id,build_Id ,unit id from lease table 
        public DataTable Les_Get_Ids(int lease_Id)
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


       


   



    }
}
