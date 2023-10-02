using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using localhost;

public partial class forgotPasswordPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
     
        if (!Page.IsPostBack) { }
    }

    protected void SubmitBtn_Click(object sender, EventArgs e)
    {
        //call an instance of a web service
        WebService wb = new WebService();
        //call amethod in the web service that is used to get Email from the database
        bool test = wb.getMail(EmailTxt.Text);
        if (test != true)
        {
            //an error message will be visible if the test is not true
            errorLbl.Visible = true;
        }
        else if(test == true)
        {
            //call a method from the web service that changes the password
            bool changePassword = wb.changePassword(TxtNewPass.Text, EmailTxt.Text);
            if (changePassword == true)
            {
                //error messages will be visible
                LblSuccess.Visible = true;
                BtnContinue.Visible = true;
            }
        }

    }

    protected void CancelBtn_Click(object sender, EventArgs e)
    {
      
    }

    protected void btnContinue_Click(object sender, EventArgs e)
    {
        
    }

    protected void BtnCancel_Click(object sender, EventArgs e)
    {
        //direct to the log in page
        Response.Redirect("logInPage.aspx");
    }

    protected void BtnDone_Click(object sender, EventArgs e)
    {
        
       
    }

    protected void BtnContinue_Click(object sender, EventArgs e)
    {
        //direct to the log in page.
        Response.Redirect("logInPage.aspx");
    }
}