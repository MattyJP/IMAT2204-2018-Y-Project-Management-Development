<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TicketPurchase.aspx.cs" Inherits="SearchResult" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div style="margin-left: 80px">
        <br class="auto-style1" />
        <br />
        <asp:Label ID="Label" runat="server" Font-Size="XX-Large" Text="Confirm Ticket"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="LabelName" runat="server" Text="Name: Burt Hansen"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="LabelDOB" runat="server" Text="Date of Birth: 26/03/1989"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="LabelPhoneNo" runat="server" Text="Phone No.: 0789962345"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="LabelMovieTitle" runat="server" Text="Movie: Weather Report Girl"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="LabelTime" runat="server" Text="Time: 9:30PM"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="LabelDate" runat="server" Text="Date: 10/02/2018"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="LabelPrice" runat="server" Text="Price: £7.99"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="LabelEmail" runat="server" Text="Please enter the email address to send the ticket to:"></asp:Label>
            <br />
                    <asp:TextBox ID="TextBoxEmail" AutoPostBack="True" TextMode="Email" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button class="btn" ID="ButtonConfirm" runat="server" Text="Confirm" Enabled="false" OnClick="ButtonBuy_Click"/>
        &nbsp;
        <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Cancel" OnClick="ButtonBack_Click"/>

    
    </div>
    </form>
</body>
</html>
