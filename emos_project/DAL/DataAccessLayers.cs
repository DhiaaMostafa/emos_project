using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace emos_project.DAL
{
    class DataAccessLayers
    {
         SqlConnection sqlconnection;

        //this constructor initiualis the connection object
        public DataAccessLayers()
        {
            sqlconnection = new SqlConnection(@"Data Source=(localdb)\Projects;Initial Catalog=estate_database;Integrated Security=True");
        }//end of constractor

        //open connection 
        public void open()
        {
            if (sqlconnection.State != ConnectionState.Open)
            {
                sqlconnection.Open();
            }
        }//end of method open connection

        //close the connection
        public void close()
        {
            if (sqlconnection.State == ConnectionState.Open)
            {

                sqlconnection.Close();
            }
        }//end of method close connection

        //method of selectData
        public DataTable SelectData(string stored_procedure, SqlParameter[] param)
        {
            SqlCommand sqlcmd = new SqlCommand();
            
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                for (int i = 0; i < param.Length; i++)
                {
                    sqlcmd.Parameters.Add(param[i]);
                }
            }

            SqlDataAdapter da=new SqlDataAdapter(sqlcmd);

            DataTable dt=new DataTable();
            da.Fill(dt);

            return dt;

        }//end of method select data


        //method to insert ,update ,delete data from database
        public void Executecommand(string stored_procedure, SqlParameter[] param)
        {

            SqlCommand sqlcmd = new SqlCommand();
            sqlcmd.CommandType = CommandType.StoredProcedure;
            sqlcmd.CommandText = stored_procedure;
            sqlcmd.Connection = sqlconnection;

            if (param != null)
            {
                sqlcmd.Parameters.AddRange(param);
            }

            sqlcmd.ExecuteNonQuery();

        }//end of method to insert ,update ,delete data from database
    }
}
