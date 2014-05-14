﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="reserve.aspx.cs" Inherits="Swinney.reserve" %>

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
</head>
<body>
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
			<ul><li><h2 class="title">Client Details</h2></li></ul>
			<div class="content">
				<form id="form1" method="post" action="#">
					<fieldset>
					<legend>Details</legend>
					<label for="inputtext1">Student ID:</label></br>
					<input id="inputtext1" type="text" name="inputtext1" value="" /></br>
					<label for="inputtext2">Categories:</label></br>
					<select name="Categories">
                    <option value="Basket Ball">Basket Ball</option>
                    <option value="Raquet Ball">Raquet Ball</option>
                    <option value="Badminton">Badminton</option>
                    <option value="Squash Ball">Squash Ball</option>
                    </select></br>
					<label for="inputtext3">Select Court:</label></br>
						<select name="Courts">
                    <option value="Court1">Court1</option>
                    <option value="Court2">Court2</option>
                    <option value="Court3">Court3</option>
                    <option value="Court4">Court4</option>
                    </select></br>
					<label for="inputtext4">Item1:</label></br>
					<select name="items">
                    <option value="item1">BasketBall</option>
                    <option value="item2">Badminton Bat</option>
                    <option value="item3">Birdie</option>
                    <option value="item4">Squash Racket</option>
					<option value="item5">Squash Ball</option>
					<option value="item6">Racket Ball Bat</option>
					<option value="item7">Racket Ball</option>
					<option value="item8">Squash Bat></option>
                    </select></br>
					<label for="inputtext5">Item2:</label> </br>
					<select name="items">
                    <option value="item1">BasketBall</option>
                    <option value="item2">Badminton Bat</option>
                    <option value="item3">Birdie</option>
                    <option value="item4">Squash Racket</option>
					<option value="item5">Squash Ball</option>
					<option value="item6">Racket Ball Bat</option>
					<option value="item7">Racket Ball</option>
					<option value="item8">Squash Bat></option>
                    </select></br>
					
					<input id="Checkin1" type="submit" name="Checkin1" value="Check-In" />
					<input id="Checkout1" type="submit" name="Checkout1" value="Check-Out" />
					
					
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
		<div id="sidebar2" class="sidebar">
			<ul>
				
					
				<li>
					<h2>Items Left</h2>
					<div id="items">
						<table summary="itemsleft">
							
							<tr>
                            <td>Basket Ball</td>		
                            <td>50</td>
                            </tr>
                            <tr>
                            <td>Badminton Bats</td>		
                            <td>15</td>
                            </tr>
                            <tr>
                            <td>Birdies</td>	
                            <td>35</td>
                            </tr>
							<tr>
                            <td>Racket Ball Bats</td>	
                            <td>35</td>
                            </tr>
							<tr>
                            <td>Racket Ball</td>	
                            <td>35</td>
                            </tr>
							<tr>
                            <td>Squash Bats</td>	
                            <td>35</td>
                            </tr>
							<tr>
                            <td>Squash Ball</td>	
                            <td>35</td>
                            </tr>
						</table>
					</div>
				</li>
			</ul>
		</div>
		<!-- end sidebars -->
		<div style="clear: both;">&nbsp;</div>
	</div>
	<!-- end page -->
</div>
</div>
<div id="footer">
	<p class="copyright">&copy;&nbsp;&nbsp;2014 All Rights Reserved &nbsp;&bull;&nbsp; Design by <a href="http://www.umkc.edu">Official UMKC Website</a>.</p>
	<p class="link"><a href="#">Privacy Policy</a>&nbsp;&#8226;&nbsp;<a href="#">Terms of Use</a></p>
</div>

</body>
</html>
