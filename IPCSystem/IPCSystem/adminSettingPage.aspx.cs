using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IPCSystem
{
    public partial class adminSettingPage : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                lblUserID.Text = Session["ID"].ToString();

                if (Session["IPEnd1"].ToString() != "")
                {
                    txtIPEnd1.Text = Session["IPEnd1"].ToString();
                    txtIPEnd2.Text = Session["IPEnd2"].ToString();
                    txtCDistance.Text = Session["CDistance"].ToString();
                    txtITime.Text = Session["ITime"].ToString(); 
                }
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
                IPCSystem_DBLayer.Administrator objAdmin = new IPCSystem_DBLayer.Administrator();

                objAdmin.Status = "Inactive";
                objAdmin.UserId = lblUserID.Text;
                objAdmin.updateStatus(objAdmin);

                Session.RemoveAll();
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

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtIPEnd1.Text == "")
                {
                    Response.Write("<script type=\"text/javascript\">alert('IP address of Camera is Empty');</script>");
                }
                else if (txtIPEnd2.Text == "")
                {
                    Response.Write("<script type=\"text/javascript\">alert('IP address of Camera is Empty');</script>");
                }
                else if (txtCDistance.Text == "")
                {
                    Response.Write("<script type=\"text/javascript\">alert('Crossing Distance is Empty');</script>");
                }
                else if (txtITime.Text == "")
                {
                    Response.Write("<script type=\"text/javascript\">alert('Interval Time is Empty');</script>");
                }
                else
                {
                    Session["IPEnd1"] = txtIPEnd1.Text;
                    Session["IPEnd2"] = txtIPEnd2.Text;
                    Session["CDistance"] = txtCDistance.Text;
                    Session["ITime"] = txtITime.Text;
                }
            }
            catch (Exception ee)
            {
                ErrorLogging.LogError(ee, "");
                Response.Redirect("Error.aspx", false);
                Context.ApplicationInstance.CompleteRequest();
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            txtIPEnd1.Text = "";
            txtIPEnd2.Text = "";
            txtCDistance.Text = "";
            txtITime.Text = "";

            Session["IPEnd1"] = "";
            Session["IPEnd2"] = "";
            Session["CDistance"] = "";
            Session["ITime"] = "";
        }
    }
}