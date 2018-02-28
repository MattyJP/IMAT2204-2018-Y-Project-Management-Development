<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddFilmMan.aspx.cs" Inherits="AddFilm" %>

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
    <div>
    
        <p style="margin-left: 120px">
            <br />
            <br />
            <br />
            <asp:Label ID="LabelAddFilm" runat="server" Font-Size="XX-Large" Text="Add Film"></asp:Label>
            <br />
        </p>
        <p style="margin-left: 120px">
            &nbsp;<br />
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="LabelFilm" runat="server" Text="Film (search for Films by title's first letter):"></asp:Label>
            <br />
            <asp:DropDownList class="txtbox" ID="DropDownListFilm" runat="server" AutoPostBack =" true">
                <asp:ListItem>Vampire Bikini Babes Suck Paris</asp:ListItem>
                <asp:ListItem>P.S. I Like You</asp:ListItem>
                <asp:ListItem>The Last Beefeater</asp:ListItem>
                <asp:ListItem>Space Things Episode VIII</asp:ListItem>
                <asp:ListItem>Death Camp for Kanye</asp:ListItem>
                <asp:ListItem>Weather Report Girl</asp:ListItem>
            </asp:DropDownList>
            <asp:TextBox class="txtbox" ID="TextBoxTitle" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelScreenDate" runat="server" Text="Date:"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxDate" TextMode="Date" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelTime" runat="server" Text="Time:"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxTime" TextMode="Time" AutoPostBack="True" runat="server"></asp:TextBox>
            <br />
        </p>
        <p style="margin-left: 120px">
            <asp:Label ID="LabelScreen" runat="server" Text="Screen:"></asp:Label>
            <br />
            <asp:DropDownList class="txtbox" ID="DropDownList1" runat="server">
                <asp:ListItem>1</asp:ListItem>
                <asp:ListItem>2</asp:ListItem>
                <asp:ListItem>3</asp:ListItem>
                <asp:ListItem>4</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="LabelPrice" runat="server" Text="Ticket Price:"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxPrice" AutoPostBack="True" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn" ID="ButtonAdd" runat="server" Text="Add" OnClick="ButtonAdd_Click"/>
            <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"/>
            <br />
            <br />
            <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
        </p>
    
    </div>
    </form>
</body>
</html>
