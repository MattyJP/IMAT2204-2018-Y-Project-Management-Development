<%@ Page Language="C#" AutoEventWireup="true" CodeFile="EditCustomerDetailsStaff.aspx.cs" Inherits="AddFilm" %>

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
            <asp:Label ID="LabelEditDetails" runat="server" Font-Size="XX-Large" Text="Edit Customer Details"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="LabelFirstName" runat="server" Text="First Name:"></asp:Label>
            <br />
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxFirstName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelLastName" runat="server" Text="Last Name::"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxLastName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelMobileNo" runat="server" Text="Mobile Phone Number:"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxMobileNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn" ID="ButtonConfirm" runat="server" Text="Confirm" OnClick="ButtonConfirm_Click"/>
            <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"/>
            <br />
            <br />
            <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
        </p>   
    </div>
    </form>
</body>
</html>
