using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;

public partial class SingUpPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack) { }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        


    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        //Diclare an instance of a web service
        WebService wb = new WebService();
        //an if statement that checks if the password matchs.
        if (TxtPass.Text != TxtConfirm.Text)
        {
            msgPass.Visible = true;
        }
        else
        {
            msgPass.Visible = false;
        }
        //A method in a web service that checks if the email exist.
        bool test2 = wb.getMail(TxtMail.Text);
        if (test2 == true)
        {
            msgEmail.Visible = true;
        }
        else
        {
            msgEmail.Visible = false;

        }
        //This calls a method from the web service that will insert datas into a database
        bool test = wb.registerUser(TxtName.Text, TxtSurname.Text, TxtMail.Text, TxtPass.Text);
        if (test == true)
        {
            //direct to home page
            Response.Redirect("loginPage.aspx");
        }
        
       

    }
}