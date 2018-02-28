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
        //This method redirects the staff member to the staff search-customer page
        Response.Redirect("SearchCustomerStaff.aspx");
    }
    protected void ButtonView_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the staff customer-details page
        Response.Redirect("CustomerDetailsStaff.aspx");
    }
    protected void ButtonSearchCustomer_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the staff search-customer page
        Response.Redirect("SearchCustomerStaff.aspx");
    }
    protected void ButtonCancelFilm_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the staff cancel-Film page
        Response.Redirect("CancelFilmStaff.aspx");
    }
    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the login page
        Response.Redirect("UserPortal.aspx");
    }
}