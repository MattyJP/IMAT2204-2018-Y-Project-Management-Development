<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CancelFilmMan.aspx.cs" Inherits="CancelFilm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="stylesheet.css" rel="stylesheet" type="text/css" />
    <title></title>
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
    <div style="margin-left: 80px">
    
        <br />
        <br />
        <br />
        <asp:Label ID="LabelCancelFilm" runat="server" Font-Size="XX-Large" Text="Cancel Film"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Select a Film to cancel:"></asp:Label>
        <br />
        <br />
        <asp:DropDownList class="txtbox" ID="DropDownListFilms" runat="server" Width="510px">
            <asp:ListItem>Vampire Bikini Babes Suck Paris, Screen 1, 28/02/2018, 14:00, £5.50</asp:ListItem>
            <asp:ListItem>Weather Report Girl, Screen 4, 28/02/2018, 15:00, £7.50</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button class="btn" ID="ButtonCancel" runat="server" Text="OK" OnClick="ButtonCancel_Click"/>
        <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"/>
        <br />
        <br />
        <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
