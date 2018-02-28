using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SearchResult : System.Web.UI.Page
{
    int UserAge = 29; // For prototyping purposes, user-age is hard-coded locally
    int MovieAgeRating = 18; // For prototyping purposes, movie-age-rating is hard-coded locally
    DateTime FilmDateTime = DateTime.Now.AddHours(2); // For prototyping purposes, Film-date-time is hard-coded locally
    protected void Page_Load(object sender, EventArgs e)
    {
    }
    protected void ButtonBook_Click(object sender, EventArgs e)
    {
        //Data validation: Film deadline statement
        //If date and time is before Film deadline
        if (DateTime.Now < FilmDateTime)
        {
            //If AgeValidation bool passes
            if (AgeValidation(UserAge, MovieAgeRating))
            {
                //Redirect user to the ticket-purhcase page
                Response.Redirect("TicketPurchase.aspx");
            }
            //If AgeValidation bool fails
            else
            {
                //Add label text // Informs user he/she fails to meet movie's age-rating
                LabelError.Text = "Error: You do not meet this movie's age rating.";
            }
        }
    }
    //Data validation: AgeValidation bool method
    //Using the greater-than relational operator,
    //the user's age is tested against the movie's age-rating
    Boolean AgeValidation(int CurrentUserDOB, int SelectedMovieAgeRating)
    {
        if (CurrentUserDOB > SelectedMovieAgeRating)
        {
            return true;
        }
        else
        {
            return false;
        }
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