using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HomePage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //set up cookies
        if (Request.Cookies["LoggedIn"] == null || (Request.Cookies["LoggedIn"] != null && 
            Request.Cookies ["LoggedIn"]. Value != "true"))
        {
            //direct to the log in page
            Response.Redirect("logInPage.aspx");
        }
        if (!Page.IsPostBack) { }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //direct to the log in page
        if (Response.Cookies["LoggedIn"] != null)
        {
            HttpCookie loggedInCookie = new HttpCookie("LoggedIn", "false");
            Response.SetCookie(loggedInCookie);
            //direct to the log in page
            Response.Redirect("logInPage.aspx");
        }
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        //direct to the Rating page
        Response.Redirect("RatingPage.aspx");
    }

    protected void BtnAddBook_Click(object sender, EventArgs e)
    {
        //direct to the Add book page
        Response.Redirect("AddBookPage.aspx");
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        //direct to the user profile page
        Response.Redirect("UserProfile.aspx");
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        if (Response.Cookies["LoggedIn"] != null)
        {
            //set cookies
            HttpCookie loggedInCookie = new HttpCookie("LoggedIn", "false");
            Response.SetCookie(loggedInCookie);
            //direct to the home page
            Response.Redirect("logInPage.aspx");
        }
    }
}