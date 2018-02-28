using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;

public partial class AddFilm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If FirstName, LastName, DateOfBirth, Email, Password, AND PasswordConfirm are NOT null
        if (TextBoxFirstName.Text != "" & TextBoxLastName.Text != "" & TextBoxDateOfBirth.Text != "" & TextBoxEmail.Text != "" & TextBoxPassword.Text != "" & TextBoxPasswordConfirm.Text != "")
        {
            ButtonRegister.Enabled = true; // Enable register button // Render it clickable
            ButtonRegister.BackColor = System.Drawing.Color.DarkSlateGray; // Change register button's back-colour // Note American spelling
        }
        //If FirstName, LastName, DateOfBirth, Email, Password, AND PasswordConfirm ARE null
        else
        {
            ButtonRegister.CssClass = "btn"; // Apply register button's CSS class // CSS class is in StyleSheet.css
            ButtonRegister.BackColor = System.Drawing.Color.LightGray; // Change register button's back-colour // Note American spelling
            ButtonRegister.Enabled = false; // Disable register button // Render it clickable
        }
    }
    protected void ButtonRegister_Click(object sender, EventArgs e)
    {
        //If date of birth is past the present day: Data-validation fails
        if (DateTime.Parse(TextBoxDateOfBirth.Text) > DateTime.Now.Date)
        {
            LabelError.Text = "Error: You must enter a valid date of birth."; // Add label text // Informs user entered date-of-birth's invalid
        }
        //If date of birth was over 100 years ago: Data-validation fails
        else if (DateTime.Parse(TextBoxDateOfBirth.Text) <= DateTime.Now.Date.AddYears(-100))
        {
            LabelError.Text = "Error: You must enter a valid date of birth."; // Add label text // Informs user entered date-of-birth's invalid
        }
        //If date-of-birth data-validation passes:
        else
        {
            //The following statements create a MailMessage object, and add a recipient, sender, message body, and message subject

            //Add a recipient
            string to = TextBoxEmail.Text; // Declare string variable // Value: Textbox text

            //Add a sender
            string from = "reelhouseinc@gmail.com"; // Declare string variable // Value: Reelhouse Inc's Gmail

            //Create a System.Net.Mail.MailMessage object
            MailMessage message = new MailMessage(from, to); // Create MailMessage object // Represents SmptClient-sendable e-mail

            //Add a message body
            string mailbody = "Congratulations! You have succesfully registered with Reelhouse Inc. Your details follow:" // Declare string variable // Body text
             + Environment.NewLine + Environment.NewLine + // String-specific line-breaks
            "Forename: " + TextBoxFirstName.Text + Environment.NewLine + // Forename // Value: Textbox text // String-specific line-breaks
            "Surname: " + TextBoxLastName.Text + Environment.NewLine + // Surname // Value: Textbox text // String-specific line-breaks
            "Date Of Birth: " + TextBoxDateOfBirth.Text + Environment.NewLine + // DateOfBirth // Value: Textbox text // String-specific line-breaks
            "Email Address: " + TextBoxEmail.Text + Environment.NewLine + // EmailAddress // Value: Textbox text // String-specific line-breaks
            "Mobile Phone No.: " + TextBoxMobileNo.Text + Environment.NewLine + // MobilePhoneNo. // Value: Textbox text // String-specific line-breaks
            "Password: " + TextBoxPassword.Text + Environment.NewLine + Environment.NewLine + // Password // Value: Textbox text // String-specific line-breaks
            "We hope you enjoy your membership with Reelhouse Inc.!"; // Body text

            //Add a message subject
            message.Subject = TextBoxFirstName.Text + " " + TextBoxLastName.Text + ": You have successfully registered with Reelhouse Inc.";

            //Add the message body
            message.Body = mailbody;

            //Create a System.Net.Mail.SmtpClient object
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // Set the SMTP host and port number // 587: Google Mail SMTP   
            System.Net.NetworkCredential basicCredential1 = new // Create a System.Net.NetworkCredential object
            System.Net.NetworkCredential("reelhouseinc@gmail.com", "cinemaemail123"); // Input Reelhouse Inc's SMTP credentials: Email, Password
            client.EnableSsl = true; // Enable Secure Socket Layer (SSL) for connection encryption
            client.UseDefaultCredentials = false; // Do not send the DefaultCredentials with requests
            client.Credentials = basicCredential1; // Send Reelhouse Inc's credentials with requests

            //As emails may result in an exception, try is used
            try
            {
                client.Send(message); // Send the e-email
                LabelError.Text = "Account created! A confirmation email has been sent! Redirecting to the login page in 3, 2, 1..."; // Add label text // Informs user registration proved successful
                //The following statements empty input textboxes
                TextBoxFirstName.Text = string.Empty;
                TextBoxLastName.Text = string.Empty;
                TextBoxDateOfBirth.Text = string.Empty;
                TextBoxMobileNo.Text = string.Empty;
                TextBoxPassword.Text = string.Empty;
                TextBoxPasswordConfirm.Text = string.Empty;
                //This statement disables the register button
                //Consequently, users cannot re-register immediately
                //This prevent creating accidental duplicate accounts
                ButtonRegister.Enabled = false;
                //Execute redirect method
                RedirectToLoginAfterXDelay();
            }
            //Catch e-mail sent errors
            catch (Exception ex)
            {
                //Throw an exception
                //Reset stack trace
                throw ex;
            }
        }
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        //Redirect user to the login page
        Response.Redirect("UserPortal.aspx");
    }
    public void RedirectToLoginAfterXDelay()
    {
        //This method redirects the user to the login page
        //Sends page refresh request after four seconds
        Response.AddHeader("REFRESH", "4;URL=UserPortal.aspx");
    }
}