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
    public class SUser
    {
        string userId; //Declare variables
        public string UserId //Encapsulation
        {
            get { return userId; }
            set { userId = value; }
        }

        string password;
        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        string userType;
        public string UserType
        {
            get { return userType; }
            set { userType = value; }
        }


        public SqlDataReader getLogin(SUser obj) //SQL Statement for retreive data
        {
            String SQL = "Select * from SUser where [userId]='" +obj.userId+ "' and [password]='" +obj.password+ "'";
            DBConnection myobj = new DBConnection(); ;//to access DBConnection class properties
            return myobj.getdata(SQL);
        }

        public SqlDataReader getUserData(SUser obj) //SQL Statement for retreive data
        {
            String SQL = "Select * from SUser where [userId]='" + obj.userId + "'";
            DBConnection myobj = new DBConnection(); ;//to access DBConnection class properties
            return myobj.getdata(SQL);
        }

    }
}
