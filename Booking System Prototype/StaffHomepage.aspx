<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffHomepage.aspx.cs" Inherits="CustomerHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
    <title></title>
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
             <asp:Label ID="LabelHomepage" runat="server" Font-Size="XX-Large" Text="Staff Homepage"></asp:Label>

    </form>
</body>
</html>
