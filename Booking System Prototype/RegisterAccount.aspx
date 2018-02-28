<%@ Page Language="C#" AutoEventWireup="true" CodeFile="RegisterAccount.aspx.cs" Inherits="AddFilm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <link href="stylesheet.css" rel="stylesheet" type="text/css" />
     <title></title>
</head>
<body>
     <form id="form1" runat="server">
     <div>
        <p style="margin-left: 120px">
            <br />
            <br />
            <br />
            <asp:Label ID="LabelRegister" runat="server" Font-Size="XX-Large" Text="Register a New Account"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Label ID="LabelFirstName" runat="server" Text="First Name:"></asp:Label>
            <br />
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxFirstName" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelLastName" runat="server" Text="Last Name:"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxLastName" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelDateOfBirth" runat="server" Text="Date of Birth (enter year first, X resets date):"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxDateOfBirth" runat="server" TextMode="Date" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelEmail" runat="server" Text="Email Address:"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxEmail" TextMode="Email" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelMobileNo" runat="server" Text="Mobile Phone Number (Optional):"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxMobileNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelPassword" runat="server" Text="Password:"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxPassword" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelPasswordConfirm" runat="server" Text="Confirm Password:"></asp:Label>
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxPasswordConfirm" runat="server" AutoPostBack="True"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn" ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click" Enabled="False"/>
            <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Back" OnClick="ButtonBack_Click"/>
            <br />
            <br />
            <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
        </p>   
    </div>
    </form>
</body>
</html>
