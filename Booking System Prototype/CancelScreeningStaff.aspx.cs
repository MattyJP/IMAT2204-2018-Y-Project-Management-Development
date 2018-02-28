using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CancelFilm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void ButtonCancel_Click(object sender, EventArgs e)
    {
        DropDownListFilms.Items.Remove(DropDownListFilms.SelectedItem); // Remove Film // Removes drop-down list's selected item
        LabelError.Text = "Film sucessfully cancelled."; // Add text to label // Informs user Film was successfully cancelled
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the staff homepage
        Response.Redirect("StaffHomepage.aspx");
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