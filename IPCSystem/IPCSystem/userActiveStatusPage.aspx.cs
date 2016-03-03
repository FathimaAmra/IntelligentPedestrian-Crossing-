using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace IPCSystem
{
    public partial class userActiveStatusPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string userId = Session["ID"].ToString();

            try
            {
                IPCSystem_DBLayer.PoliceOfficer pObj = new IPCSystem_DBLayer.PoliceOfficer();

                pObj.UserId = Session["ID"].ToString();
                SqlDataReader sqlDataRrP = pObj.getPData(pObj);

                while (sqlDataRrP.Read())
                {
                    lblUserID.Text = sqlDataRrP["Name"].ToString().Trim();
                    lblCity.Text = sqlDataRrP["cityInCharged"].ToString();      
                }


                SqlConnection sqlcon = new SqlConnection("Data Source=AMRA-PC;Initial Catalog=IPCSystemDB;Integrated Security=true");
                SqlDataAdapter sqladap = new SqlDataAdapter("SELECT userId as [Operator ID], PedestrianStation as [Pedestrian Station], PStatus as [Status] FROM Administrator where city='" + lblCity.Text + "'", sqlcon);
                DataSet dset = new DataSet();
                sqladap.Fill(dset, "Administrator");
                GridViewStatus.DataSource = dset.Tables["Administrator"].DefaultView;
                GridViewStatus.DataBind();

            }
            catch (Exception ee)
            {
                ErrorLogging.LogError(ee, "");
                Response.Redirect("Error.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }


        protected void btnLogout_Click(object sender, EventArgs e)
        {
            try
            {
                Session.Remove("ID");
                Response.Redirect("LoginPage.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
            catch (Exception ee)
            {
                ErrorLogging.LogError(ee, "");
                Response.Redirect("Error.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }

        protected void btnRefresh_Click(object sender, EventArgs e)
        {
            GridViewStatus.DataBind();
            Response.Redirect(Request.RawUrl);
        }
    }
}