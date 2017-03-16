using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.DLL_Injection
{
    public partial class SqliteLoadExtension : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var doc = new SQLiteConnection("sqlite.db");
            doc.LoadExtension(Request.Params["taintedParam"]);
        }
    }
}