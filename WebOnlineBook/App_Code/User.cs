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
using System.Xml.Linq;
using System.Data.OleDb;
using System.Web.Services;
/// <summary>
/// Summary description for User
/// </summary>
public class User
{
    OleDbConnection conn;
    string path = "";


    public User(string path)
    {
        this.path = path;
    }
    //method that creates database connection and opens it.
   public void ConnectToDatabase()
    {
        conn = new OleDbConnection(@"Provider = Microsoft.ACE.OLEDB.12.0; Data Source =" + path);
        conn.Open();
    }
    //Method which disconnect from the database.
    public void DisconnectDatabase()
    {
        conn.Close();
    }
    //Method which is used to execute a query which has no result.
    public bool ExecuteCommand(String query)
    {
        try
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            //Return true indicate success.
            return true;
        }
        catch (OleDbException)
        {
            //Return false indicate failure.
            return false;
        }
    }
    //Method which execute query and return result(if any)
    public OleDbDataReader ExecuteQuery(string query)
    {
        try
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            return cmd.ExecuteReader();
        }
        catch (OleDbException)
        {
            return null;
        }
    }
    //Method used to insert datas into a database.
    public bool InsertQuery(string query)
    {
        try
        {
            OleDbCommand cmd = conn.CreateCommand();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;
        }
        catch (OleDbException)
        {
            return false;
        }
    }

}