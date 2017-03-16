using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Resource_Injection
{
    /// <summary>
    /// Not full FileStram coverage. Not pointer uses
    /// </summary>
    public partial class FileStream : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var stream = new System.IO.FileStream(Request.Params["file"], FileMode.Open);
            stream = new System.IO.FileStream(Request.Params["file"], FileMode.Open, FileAccess.Read);

            stream = new System.IO.FileStream(Request.Params["file"], FileMode.Open, FileAccess.Read, FileShare.Read);

            stream = new System.IO.FileStream(Request.Params["file"], FileMode.Open, FileAccess.Read, FileShare.Read, 100);

            stream = new System.IO.FileStream(Request.Params["file"], FileMode.Open, FileAccess.Read, FileShare.Read, 100, false);

            stream = new System.IO.FileStream(Request.Params["file"], FileMode.Open, FileAccess.Read, FileShare.Read, 100, FileOptions.None);

            stream = new System.IO.FileStream(Request.Params["file"], FileMode.Open, FileSystemRights.Read, FileShare.Read, 100, FileOptions.None);

            stream = new System.IO.FileStream(Request.Params["file"], FileMode.Open, FileSystemRights.Read, FileShare.Read, 100, FileOptions.None, new FileSecurity());
        }
    }
}