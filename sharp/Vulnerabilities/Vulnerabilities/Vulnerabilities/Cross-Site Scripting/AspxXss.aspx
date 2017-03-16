<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AspxXss.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.Cross_Site_Scripting.AspxXss" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Hello, <% Response.Write(Request.Params["name"]); %>!
    </div>
    </form>
</body>
</html>
