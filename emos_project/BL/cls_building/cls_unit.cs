using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace emos_project.BL.cls_building
{
    class cls_unit
    {

        //method add build unit
        public void B_Add_Request_Rent_Unit(int build_id,string unit_name,string unit_price,string living_room,string bed_room,string bath_room,string ketchen,string round_area,string note,string room_number, string unit_state)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[11];



            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_id;
            param[1] = new SqlParameter("@unit_name", SqlDbType.VarChar, 50);
            param[1].Value = unit_name;
            param[2] = new SqlParameter("@unit_price", SqlDbType.VarChar, 50);
            param[2].Value = unit_price;
            param[3] = new SqlParameter("@living_room", SqlDbType.VarChar, 50);
            param[3].Value = living_room;
            param[4] = new SqlParameter("@bed_room", SqlDbType.VarChar, 50);
            param[4].Value = bed_room;
            param[5] = new SqlParameter("@bath_room", SqlDbType.VarChar, 50);
            param[5].Value = bath_room;
            param[6] = new SqlParameter("@ketchen", SqlDbType.VarChar, 50);
            param[6].Value = ketchen;
            param[7] = new SqlParameter("@round_area", SqlDbType.VarChar, 50);
            param[7].Value = round_area;
            param[8] = new SqlParameter("@note", SqlDbType.VarChar, 300);
            param[8].Value = note;
            param[9] = new SqlParameter("@room_number", SqlDbType.VarChar, 50);
            param[9].Value = room_number;
            param[10] = new SqlParameter("@unit_state", SqlDbType.VarChar, 50);
            param[10].Value = unit_state;

            DAL.Executecommand("B_add_build_unit", param);
            DAL.close();

        }//end of method add build unit



        //get max id unit table
        public DataTable B_Get_Max_Unit_Id()
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Select_max_id_unit_table", null);
            DAL.close();
            return DT;

        }//end method get max id unit table


        //method add_unit rent image
        public void B_Add_Unit_Image(int unit_Id, byte[] Image_estate)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[2];

            param[0] = new SqlParameter("@unit_Id", SqlDbType.Int);
            param[0].Value = unit_Id;
            param[1] = new SqlParameter("@Image_estate", SqlDbType.Image);
            param[1].Value = Image_estate;


            DAL.Executecommand("B_add_unit_image", param);
            DAL.close();


        }//end of method add unit image



        //method of getting unit in build information
        public DataTable B_Get_All_Unit_In_Build(int build_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@build_Id", SqlDbType.Int);
            param[0].Value = build_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_all_unit_in_build", param);
            DAL.close();
            return DT;

        }//end method getting all unit in build
        //method of getting image of unit
        public DataTable B_Get_Image_Unit(int unit_Id)
        {

            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@unit_id", SqlDbType.Int);
            param[0].Value = unit_Id;

            DataTable DT = new DataTable();
            DT = DAL.SelectData("B_Get_image_unit", param);
            DAL.close();
            return DT;

        }//end method getting image of unit


    }
}
