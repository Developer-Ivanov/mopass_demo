using System;
using System.DirectoryServices;
using System.DirectoryServices.ActiveDirectory;

namespace Mopas.Tests
{
    /// <summary>
    /// 9.
    /// LADP Injection
    /// MOPAS
    /// Contains 1 vulnerability 678
    /// </summary>
    public partial class Ldap : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DirectoryContext dc = new DirectoryContext(DirectoryContextType.Domain, "ptsecurity.ru");

            string address = Request.Params["address"];
            string filter = "Address=" + address;
            string result = "";

            Domain domain = Domain.GetDomain(dc);

            DirectorySearcher ds = new DirectorySearcher(domain.GetDirectoryEntry(), filter);

            // Host: localhost
            using (SearchResultCollection src = ds.FindAll())
            {
                foreach (var res in src)
                {
                    result = res.ToString();
                }
            }

            Response.Write(result);
            
            // XSS
            string name = Request.Params["name"];
            // FIXED: AI issue #65, High, Cross-site Scripting, vstfs:///WorkItemTracking/WorkItem/65
            // GET /Tests/1%20INPUT%20DATA%20VERIFICATION/9%20LDAP%20Injection/Ldap.aspx?name=%3cscript%3ealert(1)%3c%2fscript%3e HTTP/1.1
            // Host: localhost
            Response.Write("<b>Hello, " + name + "!</b>");
            
            // XSS
            name = Request.Params["name"];
<<<<<<< HEAD
            // Fixed: AI issue #65, High, Cross-site Scripting, vstfs:///WorkItemTracking/WorkItem/65
=======
            // FIXED: AI issue #65, High, Cross-site Scripting, vstfs:///WorkItemTracking/WorkItem/65
>>>>>>> 2dc55da5af7de351ff3b5bf8adb141ce47497fb3
            // GET /Tests/1%20INPUT%20DATA%20VERIFICATION/9%20LDAP%20Injection/Ldap.aspx?name=%3cscript%3ealert(1)%3c%2fscript%3e HTTP/1.1
            // Host: localhost
            Response.Write("<b>Hello, " + name + "!</b>");  
        
            // XSS
            name = Request.Params["name"];
            // FIXED: AI issue #65, High, Cross-site Scripting, vstfs:///WorkItemTracking/WorkItem/65
            // GET /Tests/1%20INPUT%20DATA%20VERIFICATION/9%20LDAP%20Injection/Ldap.aspx?name=%3cscript%3ealert(1)%3c%2fscript%3e HTTP/1.1
            // Host: localhost
            Response.Write("<b>Hello, " + name + "!</b>");  
            
            // XSS
            name = Request.Params["name"];
            // FIXED: AI issue #65, High, Cross-site Scripting, vstfs:///WorkItemTracking/WorkItem/65
            // GET /Tests/1%20INPUT%20DATA%20VERIFICATION/9%20LDAP%20Injection/Ldap.aspx?name=%3cscript%3ealert(1)%3c%2fscript%3e HTTP/1.1
            // Host: localhost
            Response.Write("<b>Hello, " + name + "!</b>");              
        }
    }
}