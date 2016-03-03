/*
 * Developed by: Fathima Amra
 * Date: 16/2/2016
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IPCSystem_DBLayer
{
    public class DBConnection
    {
        //connect to the database
        SqlConnection con;
        public SqlConnection createConnection()
        {
            //Establish database connection 
            con = new SqlConnection("Data Source=AMRA-PC;Initial Catalog=IPCSystemDB;Integrated Security=True");
            try
            {
                con.Open();
                return con;
            }
            catch (Exception)
            {
                con = null;
                return con;
            }
        }

        public void addvalues(string SQL) //Add data in database 
        {
            con = createConnection();
            SqlCommand cmd = new SqlCommand(SQL, con);
            int i = cmd.ExecuteNonQuery();
        }

        public SqlDataReader getdata(string sql) //Read data in database 
        {
            con = createConnection();
            SqlCommand mycom = new SqlCommand();
            mycom.CommandText = sql;
            mycom.Connection = con;

            SqlDataReader DataReader;
            DataReader = mycom.ExecuteReader();

            return DataReader;
        }
    }
}
