using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerHomepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonSearchCustomer_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the staff search-customers page
        Response.Redirect("SearchCustomerStaff.aspx");
    }
    protected void ButtonCancelFilm_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the staff cancel-Films page
        Response.Redirect("CancelFilmStaff.aspx");
    }
    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the login page
        Response.Redirect("UserPortal.aspx");
    }
}