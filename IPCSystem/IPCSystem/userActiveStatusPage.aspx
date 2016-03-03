<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userActiveStatusPage.aspx.cs" Inherits="IPCSystem.userActiveStatusPage" %>

<!DOCTYPE html>

<html>
<head id="Head1" runat="server">
<meta charset="utf-8"/>
    <!-- Set the viewport width to device width for mobile -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
    <meta name="description" content=""/>
  
      <title>Active Status</title>

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
    <form id="form1" runat="server">
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
               <asp:Label ID="Label3" runat="server" Text="Welcome, "></asp:Label>
                <asp:Label ID="lblUserID" runat="server" Text=""></asp:Label>
                <br />
                <div style="float:right">
                <asp:Button ID="btnLogout" runat="server" Text="Logout" Font-Underline="true" BorderColor="Transparent" BackColor="Transparent" OnClick="btnLogout_Click" />
                </div>
            </div>
        </div>
    </div>
    <div class="container">
       
        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12" style="width:1150px">
            <div class="registrationform" >
                <div class="form-horizontal">
           
                         <div class="form-group">
                            <asp:Label ID="Label2" runat="server" Text="City" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10" style="width:300px">
                                <asp:Label ID="lblCity" runat="server" Font-Bold="true" CssClass="col-lg-2 control-label"></asp:Label>
                            </div> 
                         </div> 

                    <br />
                    <br />
                        <div class="form-group">
                           <asp:GridView ID="GridViewStatus" runat="server"></asp:GridView>
                        </div>
                    <asp:Button ID="btnRefresh" runat="server" Text="Button" OnClick="btnRefresh_Click" />
                       
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

