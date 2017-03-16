using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Resource_Injection
{
    public partial class IsolatedStoragefileStream : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var stream = new System.IO.IsolatedStorage.IsolatedStorageFileStream(Request.Params["file"], FileMode.Open);

            stream = new System.IO.IsolatedStorage.IsolatedStorageFileStream(Request.Params["file"], FileMode.Open, FileAccess.Read);

            stream = new System.IO.IsolatedStorage.IsolatedStorageFileStream(Request.Params["file"], FileMode.Open, FileAccess.Read, FileShare.Read);

            stream = new System.IO.IsolatedStorage.IsolatedStorageFileStream(Request.Params["file"], FileMode.Open, FileAccess.Read, FileShare.Read, 100);

            stream = new System.IO.IsolatedStorage.IsolatedStorageFileStream(Request.Params["file"], FileMode.Open, IsolatedStorageFile.GetStore(IsolatedStorageScope.User, IsolatedStorageScope.Domain));

            stream = new System.IO.IsolatedStorage.IsolatedStorageFileStream(Request.Params["file"], FileMode.Open, FileAccess.Read, IsolatedStorageFile.GetStore(IsolatedStorageScope.User, IsolatedStorageScope.Domain));

            stream = new System.IO.IsolatedStorage.IsolatedStorageFileStream(Request.Params["file"], FileMode.Open, FileAccess.Read, FileShare.Read, IsolatedStorageFile.GetStore(IsolatedStorageScope.User, IsolatedStorageScope.Domain));

            stream = new System.IO.IsolatedStorage.IsolatedStorageFileStream(Request.Params["file"], FileMode.Open, FileAccess.Read, FileShare.Read, 100, IsolatedStorageFile.GetStore(IsolatedStorageScope.User, IsolatedStorageScope.Domain));
        }
    }
}