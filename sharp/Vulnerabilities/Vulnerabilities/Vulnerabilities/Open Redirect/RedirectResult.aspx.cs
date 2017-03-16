//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.UI;
//using System.Web.UI.WebControls;

//namespace Vulnerabilities.Vulnerabilities.Open_Redirect
//{
//    /// <summary>
//    /// Need to be moved to MVC project
//    /// </summary>
//    public partial class RedirectResult : System.Web.UI.Page
//    {
//        protected void Page_Load(object sender, EventArgs e)
//        {
//            var res = new System.Web.Mvc.RedirectResult(Request.Params["url"]);
//            res = new System.Web.Mvc.RedirectResult(Request.Params["url"], true);
//        }
//    }
//}