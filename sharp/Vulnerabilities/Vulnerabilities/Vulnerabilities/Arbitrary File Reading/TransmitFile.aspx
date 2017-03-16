<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransmitFile.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.Arbitrary_File_Reading.TransmitFile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <% Response.TransmitFile(Request.Params["file"]); %>
        
    <% Response.TransmitFile(Request.Params["file"], 0, 10); %>
    </div>
    </form>
</body>
</html>
