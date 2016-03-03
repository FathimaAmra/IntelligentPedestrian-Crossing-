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
    public class Administrator
    {
        string userId; //Declare variables
        public string UserId //Encapsulation
        {
            get { return userId; }
            set { userId = value; }
        }

        string pedestrianStation;
        public string PedestrianStation
        {
            get { return pedestrianStation; }
            set { pedestrianStation = value; }
        }

        string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public void updateStatus(Administrator obj) //SQL Statement for update data
        {
            String SQL = "update Administrator set PStatus='" +obj.status+"' where userId='" +obj.userId+ "'";
            DBConnection mycon = new DBConnection();
            mycon.addvalues(SQL);
        }
        public SqlDataReader getAdminPStation(Administrator obj) //SQL Statement for retreive data
        {
            String SQL = "Select * from Administrator where [userId]='" + obj.UserId + "'";
            DBConnection myobj = new DBConnection(); ;//to access DBConnection class properties
            return myobj.getdata(SQL);
        }
    }
}
