<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TicketPurchaseConfirm.aspx.cs" Inherits="SearchResult" %>
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
                <li><asp:Button class="btn" ID="ButtonFilm" runat="server" Text="Book Tickets"  OnClick="ButtonBookTickets_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonCurrent" runat="server" Text="Check Current Bookings" OnClick="ButtonCurrentBookings_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonHistory" runat="server" Text="Check Booking History" OnClick="ButtonBookingHistory_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonView" runat="server" Text="View Account Details" OnClick="ButtonViewAccountDetails_Click"/></li>
                <li style="float:right"><asp:Button class="btn" ID="ButtonLogOut" runat="server" Text="Log Out" OnClick="ButtonLogOut_Click"/></li>
            </ul>
        <br />
    <div style="margin-left: 80px">

        <br class="auto-style1" />
        <br />
        <asp:Label ID="Label" runat="server" Font-Size="XX-Large" Text="Confirm Ticket"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="LabelText" runat="server" Text="Thanks for your purchase. You have been emailed a receipt. Funds have been automatically debited from your preferred debit/credit card."></asp:Label>
        <br />
        <br />
        <asp:Button class="btn" ID="ButtonConfirm" runat="server" Text="OK" OnClick="ButtonConfirm_Click"/>

    
    </div>
    </form>
</body>
</html>
