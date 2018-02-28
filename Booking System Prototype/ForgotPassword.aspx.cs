using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;      // .NET 2.0 Namespace Framework facilitates sending emails
using System.Net.Mail; // System.Net.Mail.MailMessage class facilitates building emails


public partial class SearchResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If Email is NOT null
        if (TextBoxEmail.Text != "")
        {
            ButtonConfirm.Enabled = true; // Enable confirm button // Render it clickable
            ButtonConfirm.BackColor = System.Drawing.Color.DarkSlateGray; // Change confirm button's back-colour // Note American spelling
        }
        //If Email IS null
        else
        {
            ButtonConfirm.CssClass = "btn"; // Apply confirm button's CSS class // CSS class is in StyleSheet.css
            ButtonConfirm.BackColor = System.Drawing.Color.LightGray; // Change confirm button's back-colour // Note American spelling
            ButtonConfirm.Enabled = false; // Disable confirm button // Render it unclickable
        }
    }
    protected void ButtonConfirm_Click(object sender, EventArgs e)
    {
        //The following statements create a MailMessage object, and add a recipient, sender, message body, and message subject

        //Add a recipient
        string to = TextBoxEmail.Text; // Declare string // Value: textbox text

        //Add a sender
        string from = "reelhouseinc@gmail.com"; // Declare string // Value: Reelhouse Inc's Gmail

        //Create a System.Net.Mail.MailMessage object
        MailMessage message = new MailMessage(from, to); // Create MailMessage object // Represents SmptClient-sendable e-mail

        //Add a message body
        string mailbody = "A forgotten password request has been sent to this email. Your password follows:" // Declare string // Body text
        + Environment.NewLine + Environment.NewLine + // String-specific line-breaks
        "Password: password123" + // Body text // Forgotten password // For prototying purposes, password is hard-coded in-line
        Environment.NewLine + Environment.NewLine + // String-specific line-breaks
        "If this email has not been sent by you, please contact Reelhouse Inc.: reelhouseinc@gmail.com"; // Body text

        //Add a message subject
        message.Subject = "Reelhouse Inc. Forgotten Password.";

        //Add the message body
        message.Body = mailbody;

        //The following statements send ReelHouse Inc's encrypted Gmail credentials
        //over SSL to authenticate and send an email. Consequently, Reelhouse sends built emails.

        //Create a System.Net.Mail.SmtpClient object
        SmtpClient client = new SmtpClient("smtp.gmail.com", 587); // Set the SMTP host and port number // 587: Google Mail SMTP   
        System.Net.NetworkCredential basicCredential1 = new // Create a System.Net.NetworkCredential object
        System.Net.NetworkCredential("reelhouseinc@gmail.com", "cinemaemail123"); // Input Reelhouse Inc's SMTP credentials: Email, Password
        client.EnableSsl = true; // Enable Secure Socket Layer (SSL) for connection encryption
        client.UseDefaultCredentials = false; // Do not send the DefaultCredentials with requests
        client.Credentials = basicCredential1; // Send Reelhouse Inc's credentials with requests

        //Send the e-mail
        client.Send(message);
        //Make label visible
        LabelError.Visible = true; // Informs user email was sent
        //Execute redirect method
        RedirectToLoginAfterXDelay();
    }
    public void RedirectToLoginAfterXDelay()
    {
        //This method redirects the user to the login page
        //Sends page refresh request after four seconds
        Response.AddHeader("REFRESH", "4;URL=UserPortal.aspx");
    }
}