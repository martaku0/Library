using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class addRecord : System.Web.UI.Page
    {
        ConnectionHandler handler = new ConnectionHandler();

        protected void Page_Load(object sender, EventArgs e)
        {

         
            if (Session["connectionData"] is null || !(bool)Session["connectionData"]) Response.Redirect("~/Connection.aspx");
            if (Session["userLoggedIn"] is null || !(bool)Session["userLoggedIn"]) Response.Redirect("~/userLogin.aspx");

            handler.loadFromSession(Session);
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

            string author = tbAuthors.Text;
            string title = tbTitle.Text;
            string releaseDate = tbRealese.Text;
            string isbm = tbIsbm.Text;
            string format = tbFormat.Text;
            string pages = tbPages.Text;
            string description = tbDescription.Text;

            if(author == "" || title == "" || releaseDate == "" || isbm == "" || format == "" || pages == "" || description == "")
            {
                lbInfo.Text = "wypełnij wszystkie pola";
                return;
            }

            MySqlCommand command = handler.connetion.CreateCommand();
            command.CommandText = "INSERT INTO `books`" +
                "(`Authors`, `Title`, `Release_date`, `ISBN`, `Format`, `Pages`, `Description`) VALUES" +
                $"('{author}', '{title}', '{releaseDate}', '{isbm}', '{format}', '{pages}', '{description}')";

            command.ExecuteNonQuery();

            Response.Redirect("/ShowData.aspx");
        }
    }
}
