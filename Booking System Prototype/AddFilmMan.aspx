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
                <li><asp:Button class="btn" ID="ButtonFilm" runat="server" Text="Add Film" OnClick="ButtonAddFilm_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonCustomer" runat="server" Text="Search Customer" OnClick="ButtonSearchCustomer_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonView" runat="server" Text="Cancel Film" OnClick="ButtonCancelFilm_Click"/></li>
                <li style="float:right"><asp:Button class="btn" ID="ButtonLogOut" runat="server" Text="Log Out" OnClick="ButtonLogOut_Click"/></li>
            </ul>
        <br />
     <div>
        <p style="margin-left: 120px">
            <br />
            <br />
            <br />
            <asp:Label ID="LabelAddFilm" runat="server" Font-Size="XX-Large" Text="Add Film"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="LabelTitle" runat="server" Text="Title (search for Films by title's first letter): "></asp:Label>
            <br />
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxTitle" runat="server" AutoPostBack="True" Placeholder="Title..."></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelGenre" runat="server" Text="Genre:"></asp:Label>
            <br />
            <br />
            <asp:DropDownList class="txtbox" ID="DropDownListGenre" runat="server">
                <asp:ListItem>Action</asp:ListItem>
                <asp:ListItem>Horror</asp:ListItem>
                <asp:ListItem>Comedy</asp:ListItem>
                <asp:ListItem>Adventure</asp:ListItem>
                <asp:ListItem>Sci-Fi</asp:ListItem>
                <asp:ListItem>Fantasy</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="LabelAgeRating" runat="server" Text="Age Rating:"></asp:Label>
            <br />
            <br />
            <asp:DropDownList class="txtbox" ID="DropDownListAgeRating" runat="server">
                <asp:ListItem>U</asp:ListItem>
                <asp:ListItem>PG</asp:ListItem>
                <asp:ListItem>12A</asp:ListItem>
                <asp:ListItem>12</asp:ListItem>
                <asp:ListItem>15</asp:ListItem>
                <asp:ListItem>18</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="LabelDuration" runat="server" Text="Duration:"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxDuration" runat="server" AutoPostBack="True"  PlaceHolder ="Duration..."></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelComments" runat="server" Text="Comments:"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxComments" runat="server" PlaceHolder ="Comments..."></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn" ID="ButtonAdd" runat="server" Text="Add" OnClick="ButtonAdd_Click"/>
            <asp:Button CssClass="btn" ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"/>
            <br />
            <br />
            <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
        </p>   
    </div>
    </form>
</body>
</html>
