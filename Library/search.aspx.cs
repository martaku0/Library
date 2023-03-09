using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Library
{
    public partial class search : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["connectionData"] is null || !(bool)Session["connectionData"]) Response.Redirect("~/Connection.aspx");
            if (Session["userLoggedIn"] is null || !(bool)Session["userLoggedIn"]) Response.Redirect("~/userLogin.aspx");
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string author = tbAuthors.Text;
            string title = tbTitle.Text;
            string releaseDate = tbRealese.Text;
            string isbm = tbIsbm.Text;
            string format = tbFormat.Text;
            string pages = tbPages.Text;
            string description = tbDescription.Text;

            Response.Redirect(String.Format("/ShowData.aspx?author={}&title={}&relasedate={}&isbm={}&format={}&pages={}&description={}", 
               author,
               title,
               releaseDate,
               isbm,
               format,
               pages,
               description
            ));
        }
    }
}