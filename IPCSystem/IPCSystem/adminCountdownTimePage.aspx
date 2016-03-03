<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminCountdownTimePage.aspx.cs" Inherits="IPCSystem.adminCountdownTimePage" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
<meta charset="utf-8"/>
    <!-- Set the viewport width to device width for mobile -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
    <meta name="description" content=""/>
  
      <title>Countdown Timer</title>

    <!-- ============ Google fonts ============ -->
    <link href='http://fonts.googleapis.com/css?family=EB+Garamond' rel='stylesheet' type='text/css' />
    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,600,700,300,800'
        rel='stylesheet' type='text/css' />

    <!-- ============  CSS  ============ -->
    <link href="css/1bootstrap.min.css" rel="stylesheet" type="text/css" />
    <link href="css/style.css" rel="stylesheet" type="text/css" />
    <link href="css/1font-awesome.css" rel="stylesheet" type="text/css" />
</head>

<body>
    <form id="form1" runat="server" DefaultButton="btnSubmit">
    <div id="custom-bootstrap-menu" class="navbar navbar-default " role="navigation">
        <div class="container">
            <div class="navbar-header">
                <table>
                    <tr>
                        <td><img src="images/IPCS.png" width="100" height="100" style="background-color:transparent" /></td>
                        <td><a class="navbar-brand" href="#" ></a></td>
                    </tr>
                </table>
            </div>
            <br />
            <div style="float:right">
               <asp:Label ID="Label3" runat="server" ForeColor="White" Text="Logged As:"></asp:Label>
               <asp:Label ID="lblUserID" ForeColor="White" runat="server" Text=""></asp:Label>
            </div>
             <br />

            <div style="float:right">
            <table>
                 <tr>
                  <td><div class="collapse navbar-collapse navbar-menubuilder">
                  <ul class="nav navbar-nav navbar-right">
                    <li><a href="adminCountdownTimePage.aspx">Home</a> </li>
                    <li><a href="adminSettingPage.aspx">Setting</a> </li>
                 </ul>
                 </div> </td>
                 <td> <div style="float:right">
                   <asp:Button ID="btnLogout" runat="server" Text="Logout" BorderColor="Transparent" BackColor="Transparent" OnClick="btnLogout_Click" />
                 </div> </td>
                </tr>
            </table>
            </div>
        </div>
    </div>
    <div class="container">
       
        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12" style="width:1150px;">
            <div class="registrationform" >
                <div class="form-horizontal">
                    <div style="width:500px; float:left">
                         <div class="form-group">
                            <br />
                            <asp:Label ID="lblGap" runat="server" Width="20px" ></asp:Label>
                            <asp:Label ID="lblCity" runat="server" Text="City :"  Width="125px" ForeColor="White" ></asp:Label>
                            <asp:Label ID="txtPCity" runat="server" Width="105" Font-Bold="true"  ForeColor="White" ></asp:Label>
                         </div> 

                        <div class="form-group">
                            <asp:Label ID="lblGap2" runat="server" Width="20px" ></asp:Label>
                            <asp:Label ID="lblPStation" runat="server"  Width="125px" Text="Pedestrain Station :" ForeColor="White"></asp:Label>
                            <asp:Label ID="txtPStation" runat="server" Font-Bold="true" ForeColor="White"></asp:Label>
                        </div>

                    <br />                
                       <div class="form-group">
                           <div class="col-lg-10 col-lg-offset-2">
                           <asp:Button ID="btnSubmit" runat="server" Width="200" CssClass="btn btn-primary" Text="Submit" OnClick="btnSubmit_Click" />                                                           
                           </div>
                       </div>
                    <br />
                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                            <asp:Label ID="lblCountdownTime" runat="server" Width="170" Text="Countdown Time  :" CssClass="col-lg-2 control-label"></asp:Label>
                            </div><br />
                            <div class="col-lg-10 col-lg-offset-2">
                            <asp:Label ID="txtCountdowntime" runat="server" Width="125" CssClass="col-lg-2 control-label" ForeColor="White" Font-Size="35px"></asp:Label>
                            </div>
                        </div>
                </div>
                    <table>
                        <tr>
                        <td style="float:left"><asp:Label ID="lblPImageEnd1" runat="server" Width="200px" Text="Image of Pedestrian End 1" CssClass="col-lg-2 control-label"></asp:Label></td>
                        <td style="width:20px"></td>
                        <td style="float:left"><asp:Label ID="lblPImageEnd2" runat="server" Width="200px" Text="Image of Pedestrian End 2" CssClass="col-lg-2 control-label"></asp:Label></td>
                        </tr>
                        <tr>
                        <td><asp:Image ID="imagePEnd1" runat="server" Width="230" Height="350" BackColor="Transparent"/></td>
                        <td style="width:20px"></td>
                        <td><asp:Image ID="imagePEnd2" runat="server" Width="230" Height="350"/></td>
                        </tr>
                    </table>
             </div>
           </div>
        </div>
     </div>
    

    <script src="js/1jquery.js" type="text/javascript"></script>
    <script src="js/1bootstrap.min.js" type="text/javascript"></script>
    <script src="js/jquery.backstretch.js" type="text/javascript"></script>
    <script type="text/javascript">
        'use strict';


        $.backstretch(
        [
            "images/34.jpg"
        ],

        {
            duration: 4000,
            fade: 1500
        }
    );
    </script>
    </form>
</body>
</html>
