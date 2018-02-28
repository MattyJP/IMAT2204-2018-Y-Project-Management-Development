<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchCustomerResultStaff.aspx.cs" Inherits="SearchResult" %>
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
            <li><asp:Button class="btn" ID="ButtonCustomer" runat="server" Text="Search Customer" OnClick="ButtonSearchCustomer_Click"/></li>
            <li><asp:Button class="btn" ID="Button1" runat="server" Text="Cancel Film" OnClick="ButtonCancelFilm_Click"/></li>
            <li style="float:right"><asp:Button class="btn" ID="ButtonLogOut" runat="server" Text="Log Out" OnClick="ButtonLogOut_Click"/></li>
        </ul>
        <br />
    <div style="margin-left: 80px">
        <br class="auto-style1" />
        <br />
        <asp:Label ID="LabelSearchResults" runat="server" Font-Size="XX-Large" Text="Customer Search Results"></asp:Label>
        <br />
        <br />
        <br />
<table class="tbl" border="1"> 
<tr>
<th>Name</th> 
<th>Date of Birth</th> 
<th>Email Address</th> 
<th>Mobile No</th>
<th>Select</th> 
</tr>
<tr> 
<!-- The following data will use an SQL-Join (tblFilm, tblFilms, tblScreenAllocation) -->
<td style="text-align:center">Burt Hansen</td>
<td style="text-align:center">26/03/1989</td> 
<td style="text-align:center">BHansen@gmail.com</td> 
<td style="text-align:center">0789962345</td> 
<td style="text-align:center"><input type="radio" name="customerresult" runat="server" autopostback="True"></td>
</tr> 

</table> 
        <br />
        <br />
        <asp:Button class="btn" ID="ButtonView" runat="server" Text="View" OnClick="ButtonView_Click"/>
        <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Cancel" OnClick="ButtonBack_Click"/>
        <br />
        <br />
        <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
