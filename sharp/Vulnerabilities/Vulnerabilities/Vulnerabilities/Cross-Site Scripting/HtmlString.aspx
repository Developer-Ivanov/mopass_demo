<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HtmlString.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.Cross_Site_Scripting.HtmlString" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <% var str = new HtmlString(Request.Params["name"]); %>
        <%= str %>
    </div>
    </form>
</body>
</html>
