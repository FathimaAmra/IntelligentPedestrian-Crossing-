using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace IPCSystem
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            String userType;

            IPCSystem_DBLayer.SUser obj = new IPCSystem_DBLayer.SUser();
            IPCSystem_DBLayer.Administrator objAdmin = new IPCSystem_DBLayer.Administrator();

            try
            {
                if (txtUsername.Text == "")
                {
                    Response.Write("<script type=\"text/javascript\">alert('Username cannot be empty');</script>");
                }
                else if (txtPassword.Text == "")
                {
                    Response.Write("<script type=\"text/javascript\">alert('password cannot be empty');</script>");
                }
                else
                {
                    obj.UserId = txtUsername.Text;
                    obj.Password = txtPassword.Text;

                    SqlDataReader sqlDataRr = obj.getLogin(obj);

                    if (sqlDataRr.Read())
                    {
                        userType = sqlDataRr["userType"].ToString().Trim();
                        Session["ID"] = txtUsername.Text;

                        if (userType == "Admin")
                        {
                            objAdmin.Status = "Active";
                            objAdmin.UserId = txtUsername.Text;
                            objAdmin.updateStatus(objAdmin);

                            Response.Redirect("adminCountdownTimePage.aspx", false);
                            Context.ApplicationInstance.CompleteRequest();

                            Session["IPEnd1"] = "";
                            Session["IPEnd2"] = "";
                            Session["CDistance"] = "";
                            Session["ITime"] = "";

                        }
                        else if (userType == "User")
                        {
                            Response.Redirect("userActiveStatusPage.aspx", false);
                            Context.ApplicationInstance.CompleteRequest();

                        }
                    }
                    else
                    {
                        Response.Write("<script type=\"text/javascript\">alert('Invalid Username Or Password');</script>");
                    }
                }
            }
            catch (Exception ee)
            {
                ErrorLogging.LogError(ee,"");
                Response.Redirect("Error.aspx", false);
                Context.ApplicationInstance.CompleteRequest(); 
            }

        }

    }
}