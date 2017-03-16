<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Csrf.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.Request_Forgery.Csrf" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="userPass" runat="server"></asp:TextBox>
        <<asp:Button ID="Change_Password" runat="server" Text="Change password" />
    </div>
    </form>
</body>
</html>
