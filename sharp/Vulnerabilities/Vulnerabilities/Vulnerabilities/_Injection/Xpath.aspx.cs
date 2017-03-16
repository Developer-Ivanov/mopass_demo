using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml;

namespace Vulnerabilities.Vulnerabilities.Injection
{
    public partial class Xpath : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string xml = @"<root>
                    <users>
                        <user name=""admin"">Admin</user>
                        <user name=""user1"">Peter</user>
                        <user name=""user3"">John</user>
                        <user name=""user4"">Alex</user>
                        <user name=""user5"">Mike</user>
                    </users>
                    <roles>                        
                        <role name=""admin"" id=""0"">admin</role>
                        <role name=""user1"" id=""1"">privileged</role>
                        <role name=""user3"" id=""1"">privileged</role>
                        <role name=""user4"" id=""2"">common</role>
                        <role name=""user5"" id=""1"">privileged</role>
                    </roles>
            </root>";


            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            string role = Request.Params["role"];
            string result = "";

            if (role != null)
            {
                foreach (XmlNode target in doc.SelectNodes("/root/roles/role[@id='" + role + "']"))
                {
                    result = result + target.InnerText;
                }

                Response.Write(result);
            }
        }
    }
}