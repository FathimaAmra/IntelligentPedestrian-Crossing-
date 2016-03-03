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
    public class PoliceOfficer
    {
        string userId; //Declare variables
        public string UserId //Encapsulation
        {
            get { return userId; }
            set { userId = value; }
        }

        string uName;
        public string UName
        {
            get { return uName; }
            set { uName = value; }
        }

        string cityInCharged;
        public string CityInCharged
        {
            get { return cityInCharged; }
            set { cityInCharged = value; }
        }

        public SqlDataReader getPData(PoliceOfficer obj) //SQL Statement for retreive data
        {
            String SQL = "Select * from PoliceOfficer where [userId]='" + obj.UserId + "'";
            DBConnection myobj = new DBConnection(); ;//to access DBConnection class properties
            return myobj.getdata(SQL);
        }
    }
}
