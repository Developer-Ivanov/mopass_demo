<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Execute.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.Arbitrary_File_Reading.Execute" %>
<%@ Import Namespace="System.IO" %>

<!DOCTYPE html>

    <script runat="server">

        protected void ReadFile(object sender, EventArgs e)
        {
            Server.Execute(Request.Params["file"]);
            Server.Execute(Request.Params["file"], true);
            
        }
        
        
    </script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" OnLoad="ReadFile">
    <div>
    </div>
    </form>
</body>
</html>
