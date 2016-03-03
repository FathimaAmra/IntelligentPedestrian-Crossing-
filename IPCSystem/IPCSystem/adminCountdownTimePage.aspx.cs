

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace IPCSystem
{
    public partial class adminCountdownTimePage : System.Web.UI.Page
    {
        string IPEnd1 = "";
        string IPEnd2 = "";
        string CDistance = "";
        string ITime = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                    lblUserID.Text = Session["ID"].ToString();
                    IPEnd1 = Session["IPEnd1"].ToString();
                    IPEnd2 = Session["IPEnd2"].ToString();
                    CDistance = Session["CDistance"].ToString();
                    ITime = Session["ITime"].ToString();

                IPCSystem_DBLayer.Administrator adminObj = new IPCSystem_DBLayer.Administrator();

                adminObj.UserId = Session["ID"].ToString();
                SqlDataReader sqlDataRrAdmin = adminObj.getAdminPStation(adminObj);

                while (sqlDataRrAdmin.Read())
                {
                    txtPCity.Text = sqlDataRrAdmin["city"].ToString().Trim();
                    txtPStation.Text = sqlDataRrAdmin["PedestrianStation"].ToString();
                }

               
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
                if (IPEnd1 == "")
                {
                    Response.Write("<script type=\"text/javascript\">alert('IP address of Camera is not Fixed');</script>");
                }
                else if (IPEnd2 == "")
                {
                    Response.Write("<script type=\"text/javascript\">alert('IP address of Camera is not Fixed');</script>");
                }
                else if (CDistance == "")
                {
                    Response.Write("<script type=\"text/javascript\">alert('Crossing Distance is not Fixed');</script>");
                }
                else if (ITime == "")
                {
                    Response.Write("<script type=\"text/javascript\">alert('Interval Time is not Fixed');</script>");
                }
                else
                {
                    int holdTime=0;
                    IPCS_BBLayer.calculateCountdownTime a = new IPCS_BBLayer.calculateCountdownTime();
                    var pair = a.countdownTime(IPEnd1, IPEnd2, CDistance);
                    txtCountdowntime.Text = pair.Item1.ToString();
                    holdTime = pair.Item2;

                    string sourceURL = "http://192.168.1.2:8080/shot.jpg";

                    byte[] buffer = new byte[1280 * 780];
                    int read, total = 0;

                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(sourceURL);
                    WebResponse resp = req.GetResponse();

                    Stream stream = resp.GetResponseStream();

                    while ((read = stream.Read(buffer, total, 1000)) != 0)
                    {
                        total += read;
                    }

                    Bitmap bmp = (Bitmap)Bitmap.FromStream(new MemoryStream(buffer, 0, total));

                    MemoryStream ms = new MemoryStream();
                    bmp.Save(ms, ImageFormat.Gif);

                    var base64Data = Convert.ToBase64String(ms.ToArray());
                    imagePEnd1.ImageUrl = "data:image/gif;base64," + base64Data;

                    imagePEnd2.ImageUrl = "data:image/gif;base64," + base64Data;

                }
            }

            catch (Exception ee)
            {
                ErrorLogging.LogError(ee,"");
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
    }
}