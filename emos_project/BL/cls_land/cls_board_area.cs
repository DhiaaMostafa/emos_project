using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace emos_project.BL.cls_land
{
    class cls_board_area
    {
        //method add board area
        public void L_Add_Board_Area(int land_id, string east, string board_east, string west, string board_west, string north, string board_north, string south, string board_south,string prim_diag,string sec_diag,string calc_area)
        {
            DAL.DataAccessLayers DAL = new DAL.DataAccessLayers();
            DAL.open();
            SqlParameter[] param = new SqlParameter[12];

            param[0] = new SqlParameter("@land_id", SqlDbType.Int);
            param[0].Value = land_id;

            param[1] = new SqlParameter("@east", SqlDbType.VarChar, 50);
            param[1].Value = east;
            param[2] = new SqlParameter("@board_east", SqlDbType.VarChar, 50);
            param[2].Value = board_east;
            param[3] = new SqlParameter("@west", SqlDbType.VarChar, 50);
            param[3].Value = west;
            param[4] = new SqlParameter("@board_west", SqlDbType.VarChar, 50);
            param[4].Value = board_west;
            param[5] = new SqlParameter("@north", SqlDbType.VarChar, 50);
            param[5].Value = north;
            param[6] = new SqlParameter("@board_north", SqlDbType.VarChar, 50);
            param[6].Value = board_north;
            param[7] = new SqlParameter("@south", SqlDbType.VarChar, 50);
            param[7].Value = south;
            param[8] = new SqlParameter("@board_south", SqlDbType.VarChar, 50);
            param[8].Value = board_south;
            param[9] = new SqlParameter("@prim_diag", SqlDbType.VarChar, 300);
            param[9].Value = prim_diag;
            param[10] = new SqlParameter("@sec_diag", SqlDbType.VarChar, 50);
            param[10].Value = sec_diag;
            param[11] = new SqlParameter("@calc_area", SqlDbType.VarChar, 300);
            param[11].Value = calc_area ;

            DAL.Executecommand("L_add_board_area", param);
            DAL.close();


        }//end of method Add board area


    }
}
