﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="SearchFilmResultCust.aspx.cs" Inherits="SearchResult" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <ul>
                <li><img  src="Images/Logo.png" height="47"/></li>
                <li><asp:Button class="btn" ID="ButtonFilm" runat="server" Text="Book Tickets"  OnClick="ButtonBookTickets_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonCurrent" runat="server" Text="Check Current Bookings" OnClick="ButtonCurrentBookings_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonHistory" runat="server" Text="Check Booking History" OnClick="ButtonBookingHistory_Click"/></li>
                <li><asp:Button class="btn" ID="ButtonView" runat="server" Text="View Account Details" OnClick="ButtonViewAccountDetails_Click"/></li>
                <li style="float:right"><asp:Button class="btn" ID="ButtonLogOut" runat="server" Text="Log Out" OnClick="ButtonLogOut_Click"/></li>
            </ul>
        <br />
    <form id="form1" runat="server">
    <div style="margin-left: 80px">
 
        <br class="auto-style1" />
        <br />
        <asp:Label ID="LabelSearchResults" runat="server" Font-Size="XX-Large" Text="Film Search Results"></asp:Label>
        <br />
        <br />
        <br />
        <table class="tbl" border="1"> 
            <tr>
                <th>Title</th> 
                <th>Duration</th> 
                <th>Age Rating</th> 
                <th>Genre</th> 
                <th>Time</th> 
                <th>Date</th> 
                <th>Screen</th> 
                <th>Select</th> 
            </tr>
            <tr> 
                <!-- The following data will use an SQL-Join (tblFilm, tblFilms, tblScreenAllocati on) -->
                <td style="text-align:center">Weather Report Girl</td>
                <td style="text-align:center">180 mins</td> 
                <td style="text-align:center">18</td> 
                <td style="text-align:center">Comedy</td> 
                <td style="text-align:center">21:30</td> 
                <td style="text-align:center">10/04/2018</td> 
                <td style="text-align:center">2</td> 
                <td style="text-align:center"><input type="radio" name="Filmresult1" runat="server" autopostback="True"></td>
            </tr>
            <tr> 
                <td style="text-align:center">Weather Report Girl</td>
                <td style="text-align:center">180 mins</td> 
                <td style="text-align:center">18</td> 
                <td style="text-align:center">Comedy</td> 
                <td style="text-align:center">15:00</td> 
                <td style="text-align:center">12/02/2018</td> 
                <td style="text-align:center">4</td> 
                <td style="text-align:center"><input type="radio" name="Filmresult2" runat="server" autopostback="True"></td>
            </tr>  

        </table> 
        <br />
        <br />
        <asp:Button class="btn" ID="ButtonBook" runat="server" Text="Book" OnClick="ButtonBook_Click"/>
        <asp:Button class="btn" ID="ButtonBack" runat="server" Text="Cancel" OnClick="ButtonBack_Click"/>
        <br />
        <br />
        <asp:Label ID="LabelError" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>
