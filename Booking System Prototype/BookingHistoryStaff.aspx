﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookingHistoryStaff.aspx.cs" Inherits="SearchResult" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <ul>
            <li><img  src="Images/Logo.png" height="47"/></li>
            <li><asp:Button class="btn" ID="ButtonCustomer" runat="server" Text="Search Customer" OnClick="ButtonSearchCustomer_Click"/></li>
            <li><asp:Button class="btn" ID="ButtonView" runat="server" Text="Cancel Film" OnClick="ButtonCancelFilm_Click"/></li>
            <li style="float:right"><asp:Button class="btn" ID="ButtonLogOut" runat="server" Text="Log Out" OnClick="ButtonLogOut_Click"/></li>
        </ul>
        <br />
    <div style="margin-left: 80px">
        <br class="auto-style1" />
        <br />
        <asp:Label ID="LabelHistory" runat="server" Font-Size="XX-Large" Text="Customer Booking History"></asp:Label>
        <br />
        <br />
        <br />
<table class="tbl" border="1"> 
<tr>
<th>Title</th> 
<th>Duration</th> 
<th>Age Rating</th> 
<th>Genre</th> 
<th>Time</th> 
<th>Date</th> 
<th>Screen</th> 
</tr>
<tr> 
<!-- The following data will use an SQL-Join (tblFilm, tblFilms, tblScreenAllocation) -->
<td style="text-align:center">Weather Report Girl</td>
<td style="text-align:center">180 mins</td> 
<td style="text-align:center">18</td> 
<td style="text-align:center">Comedy</td> 
<td style="text-align:center">20:30</td> 
<td style="text-align:center">19/12/2017</td> 
<td style="text-align:center">2</td> 
</tr>
<tr>
<td style="text-align:center">Weather Report Girl</td>
<td style="text-align:center">180 mins</td> 
<td style="text-align:center">18</td> 
<td style="text-align:center">Comedy</td> 
<td style="text-align:center">16:00</td> 
<td style="text-align:center">12/12/2017</td> 
<td style="text-align:center">2</td> 
</tr>
<tr>
<td style="text-align:center">Weather Report Girl</td>
<td style="text-align:center">180 mins</td> 
<td style="text-align:center">18</td> 
<td style="text-align:center">Comedy</td> 
<td style="text-align:center">21:30</td> 
<td style="text-align:center">10/04/2018</td> 
<td style="text-align:center">2</td>   

</table> 
        <br />
        <br />
        <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"/>
        <br />
        <br />
        <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
