﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vulnerabilities.Vulnerabilities.Unrestricted_File_Upload
{
    public partial class PostedFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var fileCol = Request.Files;
            fileCol[0].SaveAs("C:\\tmp\\file0");
        }
    }
}