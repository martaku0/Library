using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class userLogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Session["connectionData"] is null || !(bool)Session["connectionData"]) Response.Redirect("~/../Connection/Connection.aspx");
            tbPassword.Attributes["type"] = "password";
            handler.loadFromSession(Session);
        }
        ConnectionHandler handler = new ConnectionHandler();
        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            string hashedPassword = null;
            using (var sha = new SHA256CryptoServiceProvider())
            {
                byte[] hashed = sha.ComputeHash(Encoding.Default.GetBytes(tbPassword.Text));
                string output = Convert.ToBase64String(hashed);
                hashedPassword = output;
            }
            MySqlCommand command = handler.connetion.CreateCommand();

            command.CommandText = $"SELECT * FROM users WHERE name='{tbUser.Text}' AND password='{hashedPassword}'";
            MySqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                Session["userLoggedIn"] = true;
                Response.Redirect("ShowData.aspx");
                return;
            }

            lbInfo.Text = "logowanie zakończone niepowodzeniem";
            
            }

        
    }
}