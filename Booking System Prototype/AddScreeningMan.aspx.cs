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
        //Title-textbox derives from drop-down list's selected value
        //This prototypes a data-sourced searchable drop-down list
        TextBoxTitle.Text = DropDownListFilm.SelectedValue.ToString();

        //If Time is NOT null and if Price is NOT null
        if (TextBoxTime.Text != "" & TextBoxPrice.Text != "")
        {
            ButtonAdd.Enabled = true; // Enable add button // Render it clickable
            ButtonAdd.BackColor = System.Drawing.Color.DarkSlateGray; // Change add button's back-colour // Note American spelling
        }
        //If Time IS null and if Price IS null
        else
        {
            ButtonAdd.CssClass = "btn"; // Apply add button's CSS class // CSS class is in StyleSheet.css
            ButtonAdd.BackColor = System.Drawing.Color.LightGray; // Change add button's back-colour // Note American spelling
            ButtonAdd.Enabled = false; // Disable add button // Render it unclickable
        }
    }
    protected void ButtonAdd_Click(object sender, EventArgs e)
    {
        LabelError.Text = "Film sucessfully added.";  // Add label text // Informs user Film was successfully added
        //These statements empty input textboxes
        // & reset drop-down lists' selected indexes
        //Consequently, more Films can be added
        DropDownListFilm.SelectedIndex = 0;
        TextBoxDate.Text = string.Empty;
        TextBoxTime.Text = string.Empty;
        DropDownList1.SelectedIndex = 0;
        TextBoxPrice.Text = string.Empty;
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        //Redirect the manager to the manager homepage
        Response.Redirect("ManagerHomepage.aspx");
    }

    protected void ButtonAddFilm_Click(object sender, EventArgs e)
    {
        //Redirect the manager to the add-Film page
        Response.Redirect("AddFilmMan.aspx");
    }
    protected void ButtonSearch_Click(object sender, EventArgs e)
    {
        //Redirect the manager to the manager search-Films page
        Response.Redirect("SearchFilmsMan.aspx");
    }
    protected void ButtonSearchCustomer_Click(object sender, EventArgs e)
    {
        //Rdirect manager to the manager's search-customer page
        Response.Redirect("SearchCustomerMan.aspx");
    }
    protected void ButtonCancelFilm_Click(object sender, EventArgs e)
    {
        //Redirect manager to the cancel-Film page
        Response.Redirect("CancelFilmMan.aspx");
    }
    protected void ButtonLogOut_Click(object sender, EventArgs e)
    {
        //Redirect manager to the login page
        Response.Redirect("UserPortal.aspx");
    }
}