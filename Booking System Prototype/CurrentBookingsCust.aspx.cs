using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SearchResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
 
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        //This method redirects the customer to the customer homepage
        Response.Redirect("CustomerHomepage.aspx");
    }

    protected void ButtonBookTickets_Click(object sender, EventArgs e)
    {
        //This method redirects the customer to the customer search-Films page
        Response.Redirect("SearchFilmsCust.aspx");
    }
    protected void ButtonCurrentBookings_Click(object sender, EventArgs e)
    {
        //This method redirects the customer to the customer current bookings page
        Response.Redirect("CurrentBookingsCust.aspx");
    }
    protected void ButtonBookingHistory_Click(object sender, EventArgs e)
    {
        //This method redirects the customer to the customer booking-history page
        Response.Redirect("BookingHistoryCust.aspx");
    }
    protected void ButtonViewAccountDetails_Click(object sender, EventArgs e)
    {
        //This method redirects the customer to the customer details page
        Response.Redirect("CustomerDetailsCust.aspx");
    }
    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        //This method redirects the customer to the login page
        Response.Redirect("UserPortal.aspx");
    }
    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
        LabelError.Text = "Ticket Cancelled!"; // Add text to label // Informs user ticket was successfully cancelled
    }
}