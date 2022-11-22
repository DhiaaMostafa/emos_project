using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace emos_project.BL
{
    class cls_user_account
    {


        //method add_user_account
        public void Add_User_Account(int cust_id, string user_name, string user_pass, string user_permission, string user_status)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];


            param[0] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[0].Value = cust_id;
            param[1] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[1].Value = user_name;
            param[2] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
            param[2].Value = user_pass;
            param[3] = new SqlParameter("@user_permission", SqlDbType.VarChar, 50);
            param[3].Value = user_permission;
            param[4] = new SqlParameter("@user_status", SqlDbType.VarChar, 50);
            param[4].Value = user_status;

            DAL.Executecommand("Add_user_account", param);
            DAL.close();
        }//end of method Add_user_account


        //method for getting user account info
        public DataTable Get_User_Account_Info(int cust_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_user_account_info", param);
            DAL.close();
            return DT;
        }//end method for getting user account information 


        //method delete user
        public void Delete_User(int id)
        {
            DAL.DataAccessLayers dal = new DAL.DataAccessLayers();
            dal.open();

            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = id;

            dal.Executecommand("Delete_user", param);

            dal.close();
        }//end of method delete user


        //method for getting all user account 
        public DataTable Get_All_User_Account()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_all_user_account", null);
            DAL.close();
            return DT;
        }//end method for getting all user account 


        //method update_user account
        public void Update_User_Account(int Id,int cust_id, string user_name, string user_pass, string user_permission, string user_status)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            param[1] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[1].Value = cust_id;
            param[2] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[2].Value = user_name;
            param[3] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
            param[3].Value = user_pass;
            param[4] = new SqlParameter("@user_permission", SqlDbType.VarChar, 50);
            param[4].Value = user_permission;
            param[5] = new SqlParameter("@user_status", SqlDbType.VarChar, 50);
            param[5].Value = user_status;

            DAL.Executecommand("Update_user_account", param);
            DAL.close();

        }//end of method Update_user_account_control

        public void Update_User_Account_control(int Id, string user_name, string user_pass, string user_permission, string user_status)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];

          
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            param[1] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[1].Value = user_name;
            param[2] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
            param[2].Value = user_pass;
            param[3] = new SqlParameter("@user_permission", SqlDbType.VarChar, 50);
            param[3].Value = user_permission;
            param[4] = new SqlParameter("@user_status", SqlDbType.VarChar, 50);
            param[4].Value = user_status;

            DAL.Executecommand("Update_user_account_control", param);
            DAL.close();

        }//end of method Update_user_account_control
    }
}
