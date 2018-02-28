using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;

public partial class SearchResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonConfirm_Click(object sender, EventArgs e)
    {
        //Redirect the customer to the customer homepage
        Response.Redirect("CustomerHomepage.aspx");
    }
    protected void ButtonBookTickets_Click(object sender, EventArgs e)
    {
        //Redirect the customer to the customer search-Films page
        Response.Redirect("SearchFilmsCust.aspx");
    }
    protected void ButtonCurrentBookings_Click(object sender, EventArgs e)
    {
        //Redirect the customer to the customer current-bookings page
        Response.Redirect("CurrentBookingsCust.aspx");
    }
    protected void ButtonBookingHistory_Click(object sender, EventArgs e)
    {
        //Redirect the customer to the customer bookings-history page
        Response.Redirect("BookingHistoryCust.aspx");
    }
    protected void ButtonViewAccountDetails_Click(object sender, EventArgs e)
    {
        //Redirect the customer to the customer customer-details page
        Response.Redirect("CustomerDetailsCust.aspx");
    }
    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        //Redirect the customer to the login page
        Response.Redirect("UserPortal.aspx");
    }
}