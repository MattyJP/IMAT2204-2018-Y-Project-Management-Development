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
        //This method redirects the manager to the manager search-Films page
        Response.Redirect("SearchFilmsMan.aspx");
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        //This method redirects the manager to the manager add-Films page
        Response.Redirect("Add Film.aspx");
    }
    protected void ButtonAddFilm_Click(object sender, EventArgs e)
    {
        //This method redirects the manager to the add Films page
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
        //This method redirects the manager to the manager search-Films page
        Response.Redirect("CancelFilmMan.aspx");
    }
    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        //This method redirects the manager to the login page
        Response.Redirect("UserPortal.aspx");
    }
}