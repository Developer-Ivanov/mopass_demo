<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WritePost.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.Cross_Site_Scripting.WritePost" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        Name is <%= Request.Form["name"] %>
    </div>
    </form>
</body>
</html>
