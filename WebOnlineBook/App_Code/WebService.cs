using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Adapters;
using System.Xml.Linq;
using System.IO;
using System.Data.OleDb;
using System.Web.Services;

/// <summary>
/// Summary description for WebService
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class WebService : System.Web.Services.WebService
{
    //create a new instance of a database class
    User userDb = new User(HttpContext.Current.ApplicationInstance.Server.MapPath("~/App_Data\\UserDatabase.mdb"));

    public WebService()
    {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }


    //method used to login
    [WebMethod]
    public string Login(string Email, string password)
    {
        //Construct a query using the values i the text box.
        string query = "SELECT * FROM [UserInfor] WHERE MailAddress = '" + Email + "'AND password ='" + password + "';";
        userDb.ConnectToDatabase();
        OleDbDataReader Reader = userDb.ExecuteQuery(query);
        if (Reader != null && Reader.HasRows)
        {
            return "true" ;
        }
        else
        {
            return "false" ;
        }
    }



    //Method to register user.
    [WebMethod]
    public bool registerUser(string Name, string Surname, string email, string password)
    {
        //Add values in a database.
        string query = "INSERT INTO UserInfor([Name], [Surname], [MailAddress], [password])"
                       + "VALUES ('" + Name + "','" + Surname + "','" + email +  "','" + password + "');";
        userDb.ConnectToDatabase();
        bool b = userDb.InsertQuery(query);
        userDb.DisconnectDatabase();
        return b; 
    }

    //method to insert into book table.
    [WebMethod]
    public bool InsertBook (string bookId, string bookName, string author)
    {
        //Add values into a database.
        string query = "INSERT INTO BookInfor([bookId], [bookName], [author])" +
                        "VALUES ('" + bookId + "','" + bookName + "','" + author + "');";
        userDb.ConnectToDatabase();
        bool I = userDb.InsertQuery(query);
        userDb.DisconnectDatabase();
        return I;
    }

    //method used to add ratting to the rating table.
    [WebMethod]
    public bool addRating (string userID, string MailAddress, string ratings, string bookId)
    {
        //Add values to the rating table.
        string query = "INSERT INTO ratingInfor([userID], [MailAddress], [ratings], [bookId])" +
                       "VALUES ('" + userID + "','" + MailAddress + "','" + ratings + "','" + bookId + "');";
        userDb.ConnectToDatabase();
        bool t = userDb.InsertQuery(query);
        userDb.DisconnectDatabase();
        return t;
    }

    //Method used to get mail from database.
    [WebMethod]
    public bool getMail(string email)
    {
        //the values from the database
        string query = "SELECT * FROM [UserInfor] WHERE MailAddress ='" + email + "';";
        userDb.ConnectToDatabase();
        OleDbDataReader Reader = userDb.ExecuteQuery(query);
        if(Reader != null && Reader.HasRows)
        {
            return true;
        }
        else
        {
            return false;
        }

    }

    //a method that wiil get book id from the database
    [WebMethod]
    public bool getBookID(string bookID)
    {
        string query = "SELECT * FROM [ratingsInfor] WHERE bookId ='" + bookID + "';";
        int x = 0;
        Int32.TryParse(bookID, out x);
        userDb.ConnectToDatabase();
        OleDbDataReader Reader = userDb.ExecuteQuery(query);
        if (Reader != null && Reader.HasRows)
        {
            return true;
        }
        else
        {
            return false;
        }

    }


    //method that is used to get the password from the database.
    [WebMethod]
    public bool getPassword(string Password)
    {
        string query = "SELECT * FROM [UserInfor] WHERE password ='" + Password + "';";
        userDb.ConnectToDatabase();
        OleDbDataReader Reader = userDb.ExecuteQuery(query);
        if(Reader.HasRows)
        {   
           return true ;
        }
        else
        {
            return false;
        }
      
    }


    //Method that enable or set sessions.
    [WebMethod(EnableSession = true)]
    public bool session(string email)
     {
        bool s = false;
        Session["MailAddress"] = " '" + email + "' ";
        if (Session["MailAddress"] != null)
        {
            s = true;
        }
        return s;
    }

    //method used to get book name.
    [WebMethod]
    public bool getBookName(string BookName)
    {
        string query = "SELECT * FROM [BookInfor] WHERE bookName ='" + BookName + "';";
        userDb.ConnectToDatabase();
        OleDbDataReader Reader = userDb.ExecuteQuery(query);
        if(Reader != null && Reader.HasRows)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    //method used to get the ratings from the database.
    [WebMethod]
    public bool getRating(string rating)
    {
        string query = "SELECT * FROM [ratingInfor] WHERE ratings = '" + rating + "';";
        userDb.ConnectToDatabase();
        OleDbDataReader Reader = userDb.ExecuteQuery(query);
        if(Reader != null && Reader.HasRows)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    //method used to change user's password.
    [WebMethod]
    public bool changePassword (string newPassword , string email)
    {
        //string used to update a user's password
        string query = @"UPDATE [UserInfor] " + "SET [password] = '" + newPassword + "' WHERE MailAddress = '"
                       + email + "';";
        userDb.ConnectToDatabase();
        bool n =userDb.ExecuteCommand(query);
        userDb.DisconnectDatabase();
        return n;
    }

    //a method that will update the user profile
     [WebMethod]
     public bool UpdateProfile( string newEmail, string newName, string newSurname)
    {
        string query = @"UPDATE [UserInfor]" + "SET [MailAddress]= '" + newEmail + "' ,[Name] ='" + newName + "' ,[surname] ='" + newSurname +
                        "'WHERE MailAddress = '" + newEmail + "';";
        userDb.ConnectToDatabase();
        bool t = userDb.ExecuteCommand(query);
        userDb.DisconnectDatabase();
        return t;
    }

}
