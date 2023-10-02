using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class UserProfile : System.Web.UI.Page
{
    WebService wb = new WebService();

    protected void Page_Load(object sender, EventArgs e)
    {
        //set up cookies
        if (Request.Cookies["LoggedIn"] == null || (Request.Cookies["LoggedIn"] != null &&
            Request.Cookies["LoggedIn"].Value != "true"))
        {
            //direct to home page
            Response.Redirect("HomePage.aspx");
        }
    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //call a method from the web service that will get the mail of the user
        bool getMail = wb.getMail(TxtEmail.Text);
        if(getMail != true)
        {
            //error message will be visible
            LblErrorMail.Visible = true;
        }
        else
        {
            //call a method from the web service that will update the user profile
            bool test = wb.UpdateProfile(TxtMail.Text, TxtName.Text, TxtSurname.Text);
            if (test == true)
            {
                //error messages will be visible
                LblOK.Visible = true;
                BtnOK.Visible = true;
            }
        }
   
    }

    protected void BtnOK_Click(object sender, EventArgs e)
    {
        //direct to home page
        Response.Redirect("HomePage.aspx");
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        //this will direct to home page
        Response.Redirect("HomePage.aspx");
    }
}