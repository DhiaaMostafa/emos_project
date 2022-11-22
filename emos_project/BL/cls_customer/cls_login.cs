using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace emos_project.classes.BL
{
    class cls_login
    {
        
        //method login in cls_login
        public DataTable login(string id, string pwd)
        {
            DAL.DataAccessLayers dal = new DAL.DataAccessLayers();

            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user_name", SqlDbType.VarChar, 50);
            param[0].Value = id;
            param[1] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
            param[1].Value = pwd;

            dal.open();

            DataTable dt = new DataTable();
            dt = dal.SelectData("sp_login", param);
            return dt;

        }

        //method of getting user_account_info
        public DataTable User_Account_Info(string user_name,string user_pass)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@user_name", SqlDbType.VarChar,50);
            param[0].Value = user_name;
            param[1] = new SqlParameter("@user_pass", SqlDbType.VarChar, 50);
            param[1].Value = user_pass;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("user_account_info", param);
            DAL.close();
            return DT;

        }//end method user_account_info

    }
}
