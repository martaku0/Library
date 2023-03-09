using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class userRegister : System.Web.UI.Page
    {
        ConnectionHandler handler = new ConnectionHandler();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["connectionData"] is null || !(bool)Session["connectionData"]) Response.Redirect("~/Connection.aspx");
            
            if (!(Session["userLoggedIn"] is null) && (bool)Session["userLoggedIn"]) Response.Redirect("~/ShowData.aspx");

            tbPassword.Attributes["type"] = "password";
            handler.loadFromSession(Session);
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbEmail.Text.Length == 0 || tbUser.Text.Length == 0 || tbPassword.Text.Length == 0)
            {
                lbInfo.Text = "wypełnij wszystkie pola";
                return;
            }

            MySqlCommand command = handler.connetion.CreateCommand();

            command.CommandText = $"SELECT * FROM users WHERE name='{tbUser.Text}'";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                lbInfo.Text = "taki użytkownik już istnieje";
                return;
            }
            reader.Close();
            command = handler.connetion.CreateCommand();

            command.CommandText = $"SELECT * FROM users WHERE email='{tbEmail.Text}'";
            reader = command.ExecuteReader();

            if (reader.Read())
            {
                lbInfo.Text = "taki mail już istnieje";
                return;
            }
            reader.Close();

            string hashedPassword = null;
            using (var sha = new SHA256CryptoServiceProvider())
            {
                byte[] hashed = sha.ComputeHash(Encoding.Default.GetBytes(tbPassword.Text));
                string output = Convert.ToBase64String(hashed);
                hashedPassword = output;
            }

            command = handler.connetion.CreateCommand();

            command.CommandText = $"INSERT INTO `users`(`name`, `password`, `email`) VALUES ('{tbUser.Text}','{hashedPassword}','{tbEmail.Text}')";
            command.ExecuteNonQuery();

            Response.Redirect("/registerSucces.aspx"); 
        }
    }
}