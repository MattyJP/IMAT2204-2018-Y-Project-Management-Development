<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerHomepage.aspx.cs" Inherits="CustomerHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Customer Home Page</title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">

            <ul>
                <li><img  src="Images/Logo.png" height="47"/></li>
                <li><asp:Button class="btn" ID="ButtonFilm" runat="server" Text="Book Tickets"  OnClick="ButtonBookTickets_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonCurrent" runat="server" Text="Check Current Bookings" OnClick="ButtonCurrentBookings_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonHistory" runat="server" Text="Check Booking History" OnClick="ButtonBookingHistory_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonView" runat="server" Text="View Account Details" OnClick="ButtonViewAccountDetails_Click"/></li>
                <li style="float:right"><asp:Button class="btn" ID="ButtonLogOut" runat="server" Text="Log Out" OnClick="ButtonLogOut_Click"/></li>
            </ul>
        <br />
        <div style="margin-left: 80px">
        <asp:Label ID="LabelHomepage" runat="server" Font-Size="XX-Large" Text="Customer Homepage"></asp:Label>
            </div>
    </form>
</body>
</html>
