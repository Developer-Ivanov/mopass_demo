using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Dynamic;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Injection
{
    public partial class Linq : System.Web.UI.Page
    {
        public class User
        {
            private string username;
            private string id;
            private string password;

            public string Username
            {
                get { return username; }
                set { username = value; }
            }

            public string Id
            {
                get { return id; }
                set { id = value; }
            }

            public string Password
            {
                get { return password; }
                set { password = value; }
            }

            public User(string username, string password)
            {
                this.username = username;
                this.password = password;
                this.id = DateTime.Now.Second.ToString();

            }

            
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            List<User> users = new List<User>();
            users.Add(new User("admin", "password"));
            users.Add(new User("user", "pass"));

            var userselected = users.Where("Username = \"" + Request.Params["username"] + "\" and Password = \"" + Request.Params["password"] + "\"");
            if(userselected.Count() > 0)
                Response.Write("Your ID: " + userselected.ToArray()[0].Id);
            else
            {
                Response.Write("Enter valid username and password");
            }

        }
    }
}