<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchFilmsMan.aspx.cs" Inherits="SearchFilms" %>

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
                <li><asp:Button class="btn" ID="Button1" runat="server" Text="Search Films" OnClick="ButtonSearch_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonCustomer" runat="server" Text="Search Customer" OnClick="ButtonSearchCustomer_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonView" runat="server" Text="Cancel Film" OnClick="ButtonCancelFilm_Click"/></li>
                <li style="float:right"><asp:Button class="btn" ID="ButtonLogOut" runat="server" Text="Log Out" OnClick="ButtonLogOut_Click"/></li>
            </ul>
        <br />
    <div style="margin-left: 80px">
        <br />
        <br />
        <asp:Label ID="LabelFilmSearch" runat="server" Font-Size="XX-Large" Text="Film Search"></asp:Label>
        <br />
        <br />
        <br />
        Search By:<br />
        
        <asp:DropDownList class="txtbox" ID="DropDownListFilmSearch" runat="server">
            <asp:ListItem>Title</asp:ListItem>
            <asp:ListItem>Genre</asp:ListItem>
            <asp:ListItem>Age Rating</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox class="txtbox" ID="TextBoxSearchCriteria" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button class="btn" ID="ButtonSearch" runat="server" Text="Search" Width="217px" OnClick="ButtonSearchFilms_Click"/>
        &nbsp;
        <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"/>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
