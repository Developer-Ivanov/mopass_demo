<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.Cross_Site_Scripting.Create" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <%@ Register assembly="System.Web.Mvc, Version=4.0.0.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35, processorArchitecture=MSIL" tagPrefix="Mvc" namespace="System.Web.Mvc"%>
        <% var str = System.Web.Mvc.MvcHtmlString.Create(Request.Params["name"]); %>
        <%= str %>
    </div>
    </form>
</body>
</html>
