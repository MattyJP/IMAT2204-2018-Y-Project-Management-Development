using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class SearchFilms : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        //This method redirects the manager to the manager homepage
        Response.Redirect("ManagerHomepage.aspx");
    }

    protected void ButtonAddFilm_Click(object sender, EventArgs e)
    {
        //This method redirects the manager to the manager add-Film page
        Response.Redirect("AddFilmMan.aspx");
    }
    protected void ButtonSearch_Click(object sender, EventArgs e)
    {
        //This method redirects the manager to the manager search-Films page
        Response.Redirect("SearchFilmsMan.aspx");
    }
    protected void ButtonSearchCustomer_Click(object sender, EventArgs e)
    {
        //This method redirects the manager to the manager search-customers page
        Response.Redirect("SearchCustomerMan.aspx");
    }
    protected void ButtonCancelFilm_Click(object sender, EventArgs e)
    {
        //This method redirects the manager to the manager cancel-Film page
        Response.Redirect("CancelFilmMan.aspx");
    }
    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        //This method redirects the manager to the login page
        Response.Redirect("UserPortal.aspx");
    }
}