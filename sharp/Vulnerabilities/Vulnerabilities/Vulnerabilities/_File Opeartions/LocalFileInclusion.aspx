<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LocalFileInclusion.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.LocalFileInclusion" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%
            try
            {
                Server.Execute(Request.Params["file"]);
            }
            catch
            {
                Response.Write("No file included");
            }
        %>
    </div>
    </form>
</body>
</html>
