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
        LabelFirstName.Text = string.Empty;
        LabelLastName.Text = string.Empty;
        LabelMobileNo.Text = string.Empty;
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the staff homepage
        Response.Redirect("StaffHomepage.aspx");
    }

    protected void ButtonSearchCustomer_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the staff homepage
        Response.Redirect("SearchCustomerStaff.aspx");
    }
    protected void ButtonCancelFilm_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the staff homepage
        Response.Redirect("CancelFilmStaff.aspx");
    }
    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        //This method redirects the staff member to the staff homepage
        Response.Redirect("UserPortal.aspx");
    }
}