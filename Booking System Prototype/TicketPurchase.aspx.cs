using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Net.Mail;

public partial class SearchResult : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //If Email is NOT null
        if (TextBoxEmail.Text.Length > 0)
        {
            ButtonConfirm.Enabled = true; // Enable button // Render it clickable
            ButtonConfirm.BackColor = System.Drawing.Color.DarkSlateGray; // Change button's back-colour // Note American spelling
        }
        //If Email IS null
        else if (TextBoxEmail.Text.Length == 0)
        {
            ButtonConfirm.CssClass = "btn"; // Apply button's CSS class // CSS class is in StyleSheet.css
            ButtonConfirm.BackColor = System.Drawing.Color.LightGray; // Change button's back-colour // Note American spelling
            ButtonConfirm.Enabled = false; // Disable button // Render it unclickable
        }
    }
    protected void ButtonBack_Click(object sender, EventArgs e)
    {
        //Redirect customer to the customer search-Films page
        Response.Redirect("SearchFilmsCust.aspx");
    }
    protected void ButtonBuy_Click(object sender, EventArgs e)
    {
        //The following statements create a MailMessage object, and add a recipient, sender, message body, and message subject

        //Add a recipient
        string to = TextBoxEmail.Text; // Declare string variable // Value: textbox text

        //Add a sender
        string from = "reelhouseinc@gmail.com"; // Declare string variable // Value: Reelhouse Inc's Gmail

        //Create a System.Net.Mail.MailMessage object
        MailMessage message = new MailMessage(from, to); // Create MailMessage object // Represents SmptClient-sendable e-mail

        //Add a message body
        string mailbody = LabelName.Text + ", " + LabelDOB.Text + ", " + LabelPhoneNo.Text + Environment.NewLine + Environment.NewLine + // Declare string // Label text values // Body text
        "You have bought a Reelhouse Inc. Ticket for the following: " + Environment.NewLine + Environment.NewLine + // Body text // String-specific line-breaks
        LabelMovieTitle.Text + ", " + LabelPrice.Text + ", " + LabelDate.Text + ", " + LabelTime.Text; // Label text values

        //Add a message subject
        message.Subject = "Reelhouse Inc. Receipt, " + LabelName.Text + ", " + LabelDate.Text + "."; // Fetch label text

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
            //Send the e-mail
            client.Send(message);
            Response.Redirect("TicketPurchaseConfirm.aspx");
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