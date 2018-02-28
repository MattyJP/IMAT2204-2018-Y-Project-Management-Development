<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDetailsMan.aspx.cs" Inherits="SearchResult" %>

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
                <li><asp:Button class="btn" ID="ButtonFilm" runat="server" Text="Add Film" OnClick="ButtonAddFilm_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonSearch" runat="server" Text="Search Films" OnClick="ButtonSearch_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonCustomer" runat="server" Text="Search Customer" OnClick="ButtonSearchCustomer_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonView" runat="server" Text="Cancel Film" OnClick="ButtonCancelFilm_Click"/></li>
                <li style="float:right"><asp:Button class="btn" ID="ButtonLogOut" runat="server" Text="Log Out" OnClick="ButtonLogOut_Click"/></li>
            </ul>
        <br />
    <div>
    
        <p style="margin-left: 80px">
    
        <br class="auto-style1" />
        <br />
        <asp:Label ID="LabelSearchResults" runat="server" Font-Size="XX-Large" Text="Customer Details"></asp:Label>
        <br />
        <br />
        <br />
        </p>
        <p style="margin-left: 80px">
    
            <asp:Label ID="LabelName" runat="server" Text="Name:"></asp:Label>
&nbsp;Burt Hansen</p>
        <p style="margin-left: 80px">
    
            <asp:Label ID="LabelDoB" runat="server" Text="Date of Birth:"></asp:Label>
&nbsp;26/03/1989</p>
        <p style="margin-left: 80px">
    
            &nbsp;<asp:Label ID="LabelEmail" runat="server" Text="Email Address:"></asp:Label>
&nbsp;<a href="mailto:BHansen@gmail.com">BHansen@gmail.com</a></p>
        <p style="margin-left: 80px">
    
            <asp:Label ID="LabelMobile" runat="server" Text="Mobile No.:"></asp:Label>
&nbsp;0789962345</p>
        <p style="margin-left: 80px">
    
            &nbsp;</p>
        <p style="margin-left: 80px">
    
            <br />
            <asp:Button class="btn" ID="ButtonEdit" runat="server" Text="Edit Details" OnClick="ButtonEdit_Click" />
            <asp:Button class="btn" ID="ButtonBookings" runat="server" Text="View Bookings" OnClick="ButtonBookings_Click" />
            <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"/>
        <br />
        </p>
    
    </div>
    </form>
</body>
</html>
