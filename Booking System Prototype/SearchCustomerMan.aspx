<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchCustomerMan.aspx.cs" Inherits="SearchFilms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="stylesheet.css" rel="stylesheet" type="text/css" />
    <title></title>
    <style type="text/css">
        #form1 {
            height: 328px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <ul>
                <li><img  src="Images/Logo.png" height="47"/></li>
                <li><asp:Button class="btn" ID="ButtonFilm" runat="server" Text="Add Film" OnClick="ButtonAddFilm_Click"/></li>
                <li><asp:Button class="btn" ID="Button1" runat="server" Text="Search Films" OnClick="ButtonSearch_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonCustomer" runat="server" Text="Search Customer" OnClick="ButtonSearchCustomer_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonView" runat="server" Text="Cancel Film" OnClick="ButtonCancelFilm_Click"/></li>
                <li style="float:right"><asp:Button class="btn" ID="ButtonLogOut" runat="server" Text="Log Out" OnClick="ButtonLogOut_Click"/></li>
            </ul>
        <br />
    <div style="margin-left: 80px">
    
        <br />
        <br />
        <asp:Label ID="LabelCustomerSearch" runat="server" Font-Size="XX-Large" Text="Customer Search"></asp:Label>
        <br />
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Search By:<br />
        <asp:TextBox class="txtbox" ID="TextBoxSearchCriteria" runat="server"></asp:TextBox>
        <asp:DropDownList class="txtbox" ID="DropDownListFilmSearch" runat="server">
            <asp:ListItem>First Name</asp:ListItem>
            <asp:ListItem>Last Name</asp:ListItem>
            <asp:ListItem>Email Address</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button class="btn" ID="ButtonSearch" runat="server" Text="Search" Width="217px" />
        &nbsp;
        <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"/>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
