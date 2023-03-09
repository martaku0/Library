using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

namespace Library
{

    public class ConnectionHandler
    {
        public string server = "localhost";
        public int port = 8080;
        public string database = "library";
        public string user = "root";
        public string password = "";
        public MySqlConnection connetion = null;

        public ConnectionHandler()
        {
            this.connect();
        }
        public void connect()
        {
            string myconnection =
               "Server=" + this.server + ";" +
               //"Port=8080;" +
               "Database=" + this.database + ";" +
               "User=" + this.user + ";" +
               "Password=" + this.password + ";";
            MySqlConnection connection = new MySqlConnection(myconnection);
            try
            {
                connection.Open();
                this.connetion = connection;
            }
            catch (MySql.Data.MySqlClient.MySqlException)
            {
                this.connetion = null;

            }
        }

        public void changeConnectionData(
            string server,
            string database,
            string user,
            string password
            )
        {
            this.server = server;
            this.database = database;
            this.user = user;
            this.password = password;
            this.connect();
        }

        public void loadFromSession(HttpSessionState Session)
        {
            this.changeConnectionData(
                (string)Session["server"],
                (string)Session["database"],
                (string)Session["user"],
                (string)Session["password"]
            );
        }

    }
}