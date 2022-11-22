using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace emos_project.BL
{
    class cls_partner
    {

        //method add_partner
        public void Add_Partner( int cust_Id, string p_name,string p_phone, string p_note,byte [] imag)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[5];
            //param[0] = new SqlParameter("@Id", SqlDbType.Int);
            //param[0].Value = Id;
            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = cust_Id;
            param[1] = new SqlParameter("@p_name", SqlDbType.VarChar, 50);
            param[1].Value = p_name;
            param[2] = new SqlParameter("@p_phone", SqlDbType.VarChar, 50);
            param[2].Value = p_phone;
            param[3] = new SqlParameter("@p_note", SqlDbType.VarChar, 300);
            param[3].Value = p_note;
            param[4] = new SqlParameter("@imag", SqlDbType.Image);
            param[4].Value = imag;

            DAL.Executecommand("Add_partner", param);
            DAL.close();


        }//end of method Add_partner


        //method of getting customer's partner
        public DataTable Get_Cust_Partner(int Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@cust_Id", SqlDbType.Int);
            param[0].Value = Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_cust_partner", param);
            DAL.close();
            return DT;

        }//end method Get_Cust_partner

        //method of getting customer's partner image
        public DataTable Get_Image_Partner(int Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("Get_image_partner", param);
            DAL.close();
            return DT;

        }//end method Get_Cust_partner image


        //method update_customer partner
        public void Update_Customer_Partner(int Id,int cust_Id,string p_name ,byte [] p_image ,string p_note,string p_phone)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[6];

            param[0] = new SqlParameter("@Id", SqlDbType.Int);
            param[0].Value = Id;
            param[1] = new SqlParameter("@cust_id", SqlDbType.Int);
            param[1].Value = cust_Id;
            param[2] = new SqlParameter("@p_name", SqlDbType.VarChar,50);
            param[2].Value = p_name;
            param[3] = new SqlParameter("@p_image", SqlDbType.Image);
            param[3].Value = p_image;
            param[4] = new SqlParameter("@p_note", SqlDbType.VarChar,300);
            param[4].Value = p_note;
            param[5] = new SqlParameter("@p_phone", SqlDbType.VarChar, 50);
            param[5].Value = p_phone;
          
            DAL.Executecommand("Update_customer_partner", param);
            DAL.close();

        }//end of method Update_customer partner

        
    }
}
