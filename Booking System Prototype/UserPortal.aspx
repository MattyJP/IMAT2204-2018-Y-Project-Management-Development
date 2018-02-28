<%@ Page Language="C#" AutoEventWireup="true" CodeFile="UserPortal.aspx.cs" Inherits="AddFilm" %>

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
            <asp:RadioButton ID="RadioButtonCust" GroupName="language" runat="server" Text="Customer" AutoPostBack="True" Checked="False"/>
            <asp:RadioButton ID="RadioButtonStaff" GroupName="language" runat="server" Text="Staff" AutoPostBack="True" Checked="False"/>
            <asp:RadioButton ID="RadioButtonMan" GroupName="language" runat="server" Text="Manager" AutoPostBack="True" Checked="False"/>
            <br />
            <br />
            <asp:Label ID="LabelEmailAddress" runat="server" Text="Email Address:"></asp:Label>
            <br />
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxEmailAddress" TextMode="Email" Placeholder="Your email..." runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="LabelPassword" runat="server" Text="Password:"></asp:Label>
            <br />
            <br />
            <asp:TextBox class="txtbox" ID="TextBoxPassword" Placeholder="Your password..." runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button class="btn" ID="ButtonLogin" runat="server" Text="Login" OnClick="ButtonLogin_Click"/>
            <br />
            <br />
            <asp:Label ID="LabelRegister" runat="server" Text="Not a customer yet? Register below!"></asp:Label>
            <br />
            <asp:Button class="btn" ID="ButtonRegister" runat="server" Text="Register" OnClick="ButtonRegister_Click"/>
            <br />
            <br />
            <asp:Label ID="LabelForgotPassword" runat="server" Text="Forgot your password? Click below!"></asp:Label>
            <br />
            <asp:Button class="btn" ID="ButtonForgotPassword" runat="server" Text="Resend Password" OnClick="ButtonForgotPassword_Click"/>
            <br />
            <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
        </p>   
    </div>
    </form>
</body>
</html>
