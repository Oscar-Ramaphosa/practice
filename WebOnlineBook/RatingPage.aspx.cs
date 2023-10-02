using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RatingPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //set up cookies
        if (Request.Cookies["LoggedIn"] == null || (Request.Cookies["LoggedIn"] != null &&
            Request.Cookies["LoggedIn"].Value != "true"))
        {
            //direct to home page
            Response.Redirect("HomePage.aspx");
        }

        if (!Page.IsPostBack) { }
    }

    protected void BtnAddRating_Click(object sender, EventArgs e)
    {
        //direct to ratebook page
        Response.Redirect("RateBookPage.aspx");
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //direct to home page
        Response.Redirect("HomePage.aspx");
    }
}