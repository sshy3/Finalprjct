<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="Swinney.adminlogin" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="http://code.jquery.com/mobile/1.1.0/jquery.mobile-1.1.0.min.css" />
<script src="http://code.jquery.com/jquery-1.7.1.min.js"></script>
<script src="http://code.jquery.com/mobile/1.1.0/jquery.mobile-1.1.0.min.js"></script>
<script type="text/javascript" src="http://maps.google.com/maps/api/js?sensor=false"></script>
<meta http-equiv="content-type" content="text/html; charset=utf-8" />
<title>Home</title>
<meta name="keywords" content="" />
<meta name="Premium Series" content="" />
<link href="./Styles/default.css" rel="stylesheet" type="text/css" media="screen" />

</head>
<body>
    <div data-role="page">
	<div data-role="header" data-theme="e">
		<div id="header">
		<div id="logo">
		<h1><a href="#">Swinney Recreation Center</a></h1>
		<p>A bear, however hard he tries, grows tubby without exercise.</p>
			</div>


		</div>
	</div>
<div data-role="content" data-theme="e">
<div id="wrapper">
	<!-- start page -->
	<div id="page">
		<div id="sidebar1" class="sidebar">
				<div id="checkin" class="boxed">
			<ul><li><h2 class="title"><a  href="Administrator.html" >About Swinney</a></h2></li></ul>
			<div class="content">
				<form id="form1" method="post" action="#" runat="server">
					<fieldset>
					<h3>Admin Login</h3>
                    <asp:Label ID="Label3" runat="server" cssclass="label" Text="Login" Visible="False" ></asp:Label>
					<label for="inputtext1">Admin ID</label></br>
                    <asp:TextBox id="name" cssclass="textbox" runat="server" />
					<label for="password">Password</label></br>
					<asp:TextBox id="password" cssclass="textbox" type="password" runat="server" />
					<asp:Button ID="button1" runat="server" onclick="Submit" Text="Login" />

					


					</fieldset>
				</form>
			</div>
		</div>		
		</div>
		<!-- start content -->
		<div id="content">
			<div class="picture"><img src="images/img06.jpg" alt="" width="510" height="250" /></div>
		</div>

		<!-- end content -->
		<!-- start sidebars -->
		
		<!-- end sidebars -->
		<div style="clear: both;">&nbsp;</div>
	</div>
	<!-- end page -->
</div>

<div id="footer">
	<p class="copyright">&copy;&nbsp;&nbsp;2014 All Rights Reserved &nbsp;&bull;&nbsp; Design by <a href="http://www.umkc.edu">Official UMKC Website</a>.</p>
	<p class="link"><a href="#">Privacy Policy</a>&nbsp;&#8226;&nbsp;<a href="#">Terms of Use</a></p>
</div>
</div>

</body>
</html>
