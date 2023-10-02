using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RateBookPage : System.Web.UI.Page
{
    WebService wb = new WebService();

    protected void Page_Load(object sender, EventArgs e)
    {
        //set up cookies
        if (Request.Cookies["LoggedIn"] == null || (Request.Cookies["LoggedIn"] != null &&
            Request.Cookies["LoggedIn"].Value != "true"))
        {
            //direct to the home page
            Response.Redirect("HomePage.aspx");
        }
        if (!Page.IsPostBack) { }
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //a button used to log out
        if (Response.Cookies["LoggedIn"] != null)
        {
            //set cookies
            HttpCookie loggedInCookie = new HttpCookie("LoggedIn", "false");
            Response.SetCookie(loggedInCookie);
            //direct to the log in page
            Response.Redirect("logInPage.aspx");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //if the button is clicked it should take you to the Rating page.
        Response.Redirect("RatingPage.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        
        
        //calling a method from the web service that add the rating
        bool addRating = wb.addRating(TxtUserID.Text, TxtEmail.Text, TxtRating.Text, TxtBookID.Text);
        if (addRating == true)
        {
            //error messeges will be visible
            Lblsuccess.Visible = true;
            LblClickOK.Visible = true;
            BtnOK.Visible = true;
            GridView1.Visible = true;
        }
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //direct to home page
        Response.Redirect("HomePage.aspx");
    }
}