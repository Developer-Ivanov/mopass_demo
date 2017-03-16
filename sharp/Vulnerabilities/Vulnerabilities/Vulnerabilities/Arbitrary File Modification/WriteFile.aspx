<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WriteFile.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.Arbitrary_File_Reading.WriteFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <% Response.WriteFile(Request.Params["file"]); %>
    <% Response.WriteFile(Request.Params["file"], false); %>
    <% Response.WriteFile(Request.Params["file"], 0, 100); %>
    </div>
    </form>
</body>
</html>
