<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminSettingPage.aspx.cs" Inherits="IPCSystem.adminSettingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
<meta charset="utf-8"/>
    <!-- Set the viewport width to device width for mobile -->
    <meta name="viewport" content="width=device-width, initial-scale=1, maximum-scale=1"/>
    <meta name="description" content=""/>
  
      <title>Settings</title>

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
       
        <div class="col-lg-6 col-md-6 col-sm-6 col-xs-12" style="width:1000px">
            <div class="registrationform">
                <div class="form-horizontal">
                    <fieldset>
                        <legend>Settings <i class="fa fa-pencil pull-right"></i></legend>
                        <div class="form-group">
                            <%--2016.01.20--%>
                            <asp:Label ID="ipCamAdd1" runat="server" Text="Camera IP of Pedestrian End 1" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10" style="width:600px">
                                <asp:TextBox ID="txtIPEnd1" runat="server" placeholder="Camera IP of Pedestrian End 1" CssClass="form-control" ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="ipCamAdd2" runat="server" Text="Camera IP of Pedestrian End 2" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10" style="width:600px">
                                <asp:TextBox ID="txtIPEnd2" runat="server" placeholder="Camera IP of Pedestrian End 2" CssClass="form-control" ></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <asp:Label ID="BankName" runat="server" Text="Crossing Distance" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10" style="width:600px">
                                <asp:TextBox ID="txtCDistance" runat="server" placeholder="Crossing Distance" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <asp:Label ID="BranchName" runat="server" Text="Interval Time" CssClass="col-lg-2 control-label"></asp:Label>
                            <div class="col-lg-10" style="width:600px">
                                <asp:TextBox ID="txtITime" runat="server" placeholder="Interval Time" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>

                        <div class="form-group">
                            <div class="col-lg-10 col-lg-offset-2">
                                <asp:Button ID="btnSubmit" runat="server" CssClass="btn btn-primary" Text="Submit" OnClick="btnSubmit_Click" />
                                  <asp:Button ID="btnCancel" runat="server" CssClass="btn btn-warning" Text="Clear" OnClick="btnCancel_Click" />                              
                            </div>
                        </div>
                    </fieldset>
        
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
