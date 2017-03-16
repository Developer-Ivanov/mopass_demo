<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Raw.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.Cross_Site_Scripting.Raw" %>
<%@ Import Namespace="Microsoft.Web.Infrastructure" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%/* var str = new System.Web.WebPages.Html.HtmlHelper(null, null).Raw(Request.Params["name"]); */%>
    </div>
    </form>
</body>
</html>
