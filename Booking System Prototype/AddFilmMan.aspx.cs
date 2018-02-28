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
        //If Title is NOT null and if Duration is NOT null
        if (TextBoxTitle.Text != "" & TextBoxDuration.Text != "")
        {
            ButtonAdd.Enabled = true; // Enable button // Render it clickable
            ButtonAdd.BackColor = System.Drawing.Color.DarkSlateGray; // Change button's back-colour // Note American spelling
        }
        //If Title IS null and if Duration IS null
        else
        {
            ButtonAdd.CssClass = "btn"; // Apply button's CSS class // CSS class is in StyleSheet.css
            ButtonAdd.BackColor = System.Drawing.Color.LightGray; // Change button's back-colour // Note American spelling
            ButtonAdd.Enabled = false; // Disable button // Render it unclickable
        }
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        LabelError.Text = "Film sucessfully added."; // Add label text // Informs user Film was successfully added
        //These statements empty input textboxes 
        //Consequently, more Films can be added
        TextBoxTitle.Text = string.Empty;
        TextBoxDuration.Text = string.Empty;
        TextBoxComments.Text = string.Empty;
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        //Redirect manager to the manager homepage
        Response.Redirect("ManagerHomepage.aspx");
    }

    protected void ButtonAddFilm_Click(object sender, EventArgs e)
    {
        //Redirect manager to the add-Film page
        Response.Redirect("AddFilmMan.aspx");
    }
    protected void ButtonSearchCustomer_Click(object sender, EventArgs e)
    {
        //Redirect manager to the manager's search-customer page
        Response.Redirect("SearchCustomerMan.aspx");
    }
    /*protected void ButtonCancelFilm_Click(object sender, EventArgs e)
    {
        //Redirect manager to the cancel-Film page
        Response.Redirect("CancelFilmMan.aspx");
    }*/
    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        //Redirect manager to the login page
        Response.Redirect("UserPortal.aspx");
    }
}