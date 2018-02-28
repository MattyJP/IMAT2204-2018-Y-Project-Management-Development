<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ForgotPassword.aspx.cs" Inherits="SearchResult" %>
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
        <asp:Label ID="Label" runat="server" Font-Size="XX-Large" Text="Forgot Password"></asp:Label>
            <br />
            <br />
                    <asp:Label ID="LabelEmail" runat="server" Text="Email address: "></asp:Label>
        <br />
        <br />
                    <asp:TextBox class="txtbox" ID="TextBoxEmail" <!TextMode="Email"!> AutoPostBack="True" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button class="btn" ID="ButtonConfirm" runat="server" Text="Send Password" OnClick="ButtonConfirm_Click" Enabled="false"/>
        <br />
        <br />
                    <asp:Label ID="LabelError" visible="false" runat="server" Text="If this is a valid email, an email has been sent. You will now be redirected to the login page in 3, 2, 1..."></asp:Label>
    
    </div>
    </form>
</body>
</html>
