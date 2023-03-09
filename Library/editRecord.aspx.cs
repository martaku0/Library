using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class editRecord : System.Web.UI.Page
    {
        int editId;
        ConnectionHandler handler = new ConnectionHandler();
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["connectionData"] is null || !(bool)Session["connectionData"]) Response.Redirect("~/Connection.aspx");
            if (Session["userLoggedIn"] is null || !(bool)Session["userLoggedIn"]) Response.Redirect("~/userLogin.aspx");

            handler.loadFromSession(Session);
            editId = Convert.ToInt32(Session["editId"]);

            
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            MySqlCommand command = handler.connetion.CreateCommand();
            command.CommandText = $"SELECT * FROM books WHERE Id='{editId}'";

            MySqlDataReader reader = command.ExecuteReader();
            string authors, title, releaseDate, isbn, format, description, pages;
            if (!reader.Read())
            {
                Response.Redirect("/ShowData.aspx");
                return;
            }

            authors = reader.GetString("Authors");
            title = reader.GetString("Title");
            releaseDate = reader.GetString("Release_date");
            isbn = reader.GetString("ISBN");
            format = reader.GetString("Format");
            description = reader.GetString("Description");
            pages = reader.GetString("Pages");

            tbAuthors.Text = authors;
            tbTitle.Text = title;
            tbRealese.Text = releaseDate;
            tbPages.Text = pages;
            tbIsbm.Text = isbn;
            tbFormat.Text = format;
            tbDescription.Text = description;


            reader.Close();

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {

            string author = tbAuthors.Text;
            string title = tbTitle.Text;
            string releaseDate = tbRealese.Text;
            string isbm = tbIsbm.Text;
            string format = tbFormat.Text;
            string pages = tbPages.Text;
            string description = tbDescription.Text;

            if (author == "" || title == "" || releaseDate == "" || isbm == "" || format == "" || pages == "" || description == "")
            {
                lbInfo.Text = "wypełnij wszystkie pola";
                return;
            }

            MySqlCommand command = handler.connetion.CreateCommand();
            command.CommandText = "UPDATE `books` SET " +
                $"`Authors`='{author}', " +
                $"`Title`='{title}', " +
                $"`Release_date`='{releaseDate}', " +
                $"`ISBN`='{isbm}', " +
                $"`Format`='{format}', " +
                $"`Pages`='{pages}', " +
                $"`Description`='{description}'" +
                $" WHERE `Id`='{editId}'";
            command.ExecuteNonQuery();

            Response.Redirect("/ShowData.aspx");

        }
    }
}