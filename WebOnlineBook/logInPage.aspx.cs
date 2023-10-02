using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using localhost;
using System.Web.Services;

public partial class logInPage : System.Web.UI.Page
{
    //call an instance of a web servise.
    WebService wb = new WebService();

    protected void Page_Load(object sender, EventArgs e)
    {
        //set cookies
        if (Request.Cookies["LoggedIn"] != null && Request.Cookies["LoggedIn"].Value == "true")
        {
            //direct to the home page
            Response.Redirect("HomePage.aspx");
        }

        if (!Page.IsPostBack) { }
    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {

        string test1 = wb.Login(TxtEmail.Text, TxtPass.Text);
        if (test1 == "true")
        {

            //declaring a session with the entered email adress.
            wb.session(TxtEmail.Text);
            //setting up a cookie that assigns a logged status.
            HttpCookie loggedInCookie = new HttpCookie("LoggedIn", "true");
            Response.Cookies.Add(loggedInCookie);
            //Redirect the user to the next page
            Response.Redirect("HomePage.aspx");

        }
        else
        {
            //show an error message that email or password does not exist.
            LblError.Visible = true;

        }

    }

    protected void BtbCancel_Click(object sender, EventArgs e)
    {
        //direct to sing up page
        Response.Redirect("SingUpPage.aspx");
    }

    protected void BtnForgotPass_Click(object sender, EventArgs e)
    {
        //direct to forgot password page
        Response.Redirect("forgotPasswordPage.aspx");
    }
}