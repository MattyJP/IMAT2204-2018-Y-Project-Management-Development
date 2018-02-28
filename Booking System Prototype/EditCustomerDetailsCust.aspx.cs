using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddFilm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonConfirm_Click(object sender, EventArgs e)
    {
        LabelError.Text = "Details Successfully Updated!"; // Add text to label // Informs user dtails were successfully updated
        //These statements empty input textboxes 
        //Consequently, details can be re-updated
        TextBoxFirstName.Text = string.Empty;
        TextBoxLastName.Text = string.Empty;
        TextBoxMobileNo.Text = string.Empty;
        TextBoxPassword.Text = string.Empty;
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
        //This method redirects the customer to the customer current-bookings page
        Response.Redirect("CurrentBookingsCust.aspx");
    }
    protected void ButtonBookingHistory_Click(object sender, EventArgs e)
    {
        //This method redirects the customer to the customer bookings-history page
        Response.Redirect("BookingHistoryCust.aspx");
    }
    protected void ButtonViewAccountDetails_Click(object sender, EventArgs e)
    {
        //This method redirects the customer to the customer customer-details page
        Response.Redirect("CustomerDetailsCust.aspx");
    }
    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        //This method redirects the customer to the login page
        Response.Redirect("UserPortal.aspx");

    }
}