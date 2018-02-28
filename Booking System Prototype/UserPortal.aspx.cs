using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddFilm : System.Web.UI.Page
{
    Boolean LoggedIn; // Declare Boolean

    protected void Page_Load(object sender, EventArgs e)
    {
        //As logging-in may result in exceptions, try is used
        try
        {
            //Log-in successful // Boolean set to session
            LoggedIn = (Boolean)Session["LoggedIn"];
        }
        //If log-in unsuccessful, handle the exception
        catch
        {
            //Log-in unsuccesssful // Boolean false
            LoggedIn = false;
        }

        //Session logged-in
        Login(LoggedIn);

        //If Customer, Manager, OR Staff radio buttons is checked
        if ((RadioButtonCust.Checked || RadioButtonMan.Checked || RadioButtonStaff.Checked))
        {
            ButtonLogin.Enabled = true; // Enable button // Render it clickable
            ButtonLogin.BackColor = System.Drawing.Color.DarkSlateGray; // Change button's back-colour // Note American spelling
        }
        //If neither Customer, Manager, OR Staff radio button is checked
        else
        {
            ButtonLogin.Enabled = false; // Disable button // Render it unclickable
            ButtonLogin.CssClass = "btn"; // Apply button's CSS class // CSS class is in StyleSheet.css
            ButtonLogin.BackColor = System.Drawing.Color.LightGray; // Change button's back-colour // Note American spelling
        }
    }

    protected void Page_UnLoad(object sender, EventArgs e)
    {
        //If this page is unloaded, its login-session returns the boolean
        Session["LoggedIn"] = LoggedIn;
    }

    protected void ButtonLogin_Click(object sender, EventArgs e)
    {
        LabelError.Text = ""; // Label text null
        // LoginOK bool method // If Email, Password, and a radio button are NOT null
        if (LoginOK(TextBoxEmailAddress.Text, TextBoxPassword.Text, RadioButtonCust.Checked || RadioButtonMan.Checked || RadioButtonStaff.Checked) == true)
        {
            LoggedIn = true; // Boolean returns true
            Login(LoggedIn); // LoginSession returns Boolean

            if (RadioButtonCust.Checked)
            {
                //Redirect user to the customer homepage
                Response.Redirect("CustomerHomepage.aspx");
            }
            else if (RadioButtonMan.Checked)
            {
                //Redirect usre to the manager homepage
                Response.Redirect("ManagerHomepage.aspx");
            }
            else if (RadioButtonStaff.Checked)
            {
                //Redirect user to the staff homepage
                Response.Redirect("StaffHomepage.aspx");
            }
        }
        //If LoginOK fails // If Email, Password, AND/OR a radio button are NULL
        else
        {
            //The following statements empty the textbox
            //& uncheck the radio buttons
            //Consequently, login can be re-attempted
            TextBoxEmailAddress.Text = "";
            TextBoxPassword.Text = "";
            RadioButtonCust.Checked = false;
            RadioButtonMan.Checked = false;
            RadioButtonStaff.Checked = false;
            ButtonLogin.Enabled = false;
            //Add label text // Inform user login failed: Enter valid login details
            LabelError.Text = "You must enter a valid user name and password.";
        }
    }
    //Data Validation: LoginOK bool method
    Boolean LoginOK(string UserName, string Password, Boolean User)
    {
        if (UserName != "" & Password != "" & User == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    void Login(Boolean State)
    {
        // Do not delete this event handler
    }
    protected void ButtonRegister_Click(object sender, EventArgs e)
    {
        //Redirect user to the register-account page
        Response.Redirect("RegisterAccount.aspx");
    }
    protected void ButtonForgotPassword_Click(object sender, EventArgs e)
    {
        //Redirect user to the forgot-password page
        Response.Redirect("ForgotPassword.aspx");
    }
}