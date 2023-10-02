using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class AddBookPage : System.Web.UI.Page
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

    protected void Button1_Click(object sender, EventArgs e)
    {
        //A method in a web service that checks if the email exist.
        bool test2 = wb.getBookName(TxtBookName.Text);
        if (test2 == true)
        {
            LblError.Visible = true;
        }
        else
        {
            LblError.Visible = false;
        }
        //This calls a method from the web service that will insert datas into a database
        bool test = wb.InsertBook(TxtBookID.Text, TxtBookName.Text, TxtAuthor.Text);
        if (test == true)
        {
            //direct to the home page
            Response.Redirect("HomePage.aspx");
        }
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        //direct to the home page
        Response.Redirect("HomePage.aspx");
    }
}