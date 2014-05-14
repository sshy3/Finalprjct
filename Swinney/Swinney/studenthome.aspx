<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studenthome.aspx.cs" Inherits="Swinney.studenthome" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
   <link rel="stylesheet" href="http://code.jquery.com/mobile/1.1.0/jquery.mobile-1.1.0.min.css" />
<script src="http://code.jquery.com/jquery-1.7.1.min.js"></script>
<script src="http://code.jquery.com/mobile/1.1.0/jquery.mobile-1.1.0.min.js"></script>
<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>Administrator</title>
<meta name="keywords" content="" />
<meta name="Premium Series" content="" />
<link href="./Styles/default.css" rel="stylesheet" type="text/css" media="screen" />
    <style type="text/css">
        .auto-style1 {
            height: 19px;
        }
    </style>
</head>
<body>

    <form id="form2" runat="server">
   <div data-role="page">
	<div data-role="header" data-theme="e">
		<div id="header">
		<div id="logo">
		<h1><a href="#">Swinney Recreation Center</a></h1>
		<p>A bear, however hard he tries, grows tubby without exercise.</p>
			</div>
			<div id="menu">
			<ul id="main">
				<li class="current_page_item" ><a href="#">Logout</a></li>
			</ul>
			</div>
	
	</div>
</div>
<div data-role="content" data-theme="e">
<div id="wrapper">
	<!-- start page -->
	<div id="page">
		<div id="sidebar1" class="sidebar">
				<div id="checkin" class="boxed">
			<ul><li><h2 class="title">Players in Court</h2></li></ul>
			<div class="content">
					<fieldset>
					<legend>Details</legend>
					    Court 1:<asp:TextBox ID="TextBox12" runat="server"  Width="44px"></asp:TextBox>
                        <br />
                        Court 2:<asp:TextBox ID="TextBox13" runat="server" Width="44px"></asp:TextBox>
                        <br />
                        Court 3:<asp:TextBox ID="TextBox14" runat="server" style="margin-top: 2px" Width="44px"></asp:TextBox>
					
					
					
					
					
					</fieldset>
                
				</div>
		</div>		
		</div>
		<!-- start content -->
		<div id="content">
			<div class="picture"><img src="images/img06.jpg" alt="" width="510" height="250" /></div>
		</div>
			
		<!-- end content -->
		<!-- start sidebars -->
		<div id="sidebar2" class="sidebar">
			<ul>
				
					
				<li>
					<h2>Items Left</h2>
					<div id="items">
						<table summary="itemsleft">
							
							<tr>
                            <td style="margin-left: 40px">Badminton Bat</td>		
                            <td>
                                <asp:TextBox ID="TextBox2" runat="server" Width="34px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                            <td class="auto-style1">BasketBall</td>		
                            <td class="auto-style1">
                                <asp:TextBox ID="TextBox3" runat="server" Width="34px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                            <td>Birdies</td>	
                            <td>
                                <asp:TextBox ID="TextBox4" runat="server" Width="34px"></asp:TextBox>
                                </td>
                            </tr>
							<tr>
                            <td>Racket Ball</td>	
                            <td>
                                <asp:TextBox ID="TextBox5" runat="server" Width="34px"></asp:TextBox>
                                </td>
                            </tr>
							<tr>
                            <td>Racket Ball Bat</td>	
                            <td>
                                <asp:TextBox ID="TextBox6" runat="server" Width="34px"></asp:TextBox>
                                </td>
                            </tr>
							<tr>
                            <td>Squash Ball</td>	
                            <td>
                                <asp:TextBox ID="TextBox7" runat="server" Width="34px"></asp:TextBox>
                                </td>
                            </tr>
							<tr>
                             <td>Squash Bats</td>	
                            <td>
                                <asp:TextBox ID="TextBox10" runat="server" Width="33px"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                            <td>Volley Ball</td>	
                            <td>
                                <asp:TextBox ID="TextBox11" runat="server" Width="33px"></asp:TextBox>
                                </td>
                            </tr>
						</table>
					</div>
				</li>
			</ul>
		</div>
		<!-- end sidebars -->
       
		<div style="clear: both;">&nbsp;
        

            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Notify by Email if Courts are Full" />
        

            </div>

	</div>
	<!-- end page -->
</div>
</div>
<div id="footer">
	<p class="copyright">&copy;&nbsp;&nbsp;2014 All Rights Reserved &nbsp;&bull;&nbsp; Design by <a href="http://www.umkc.edu">Official UMKC Website</a>.</p>
	<p class="link"><a href="#">Privacy Policy</a>&nbsp;&#8226;&nbsp;<a href="#">Terms of Use</a></p>
</div>

    </form>

</body>
</html>
