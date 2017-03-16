<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TemplateControlXPath.aspx.cs" Inherits="Vulnerabilities.Vulnerabilities.XPath.TemplateControlXPath" %>
<%@ Import Namespace="System.Xml" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:XmlDataSource
            id="XmlDataSource1" 
            runat="server"
            XPath="books" 
            DataFile="books.xml" />    
        <asp:FormView 
            id="FormView1" 
            runat="server" 
            DataSourceID="XmlDataSource1">
            <ItemTemplate>
              <hr />
              <asp:Repeater 
                id="Repeater1" 
                runat="server" 
                DataSource='<%# XPathSelect("author") %>' >
                    <ItemTemplate>
                      Name: <%# XPath(Request.Params["name"]) %> <br />
                      Name: <%# XPath(Request.Params["name"], new XmlNamespaceManager(new XmlTextReader("books.xml").NameTable)) %> <br />
                      Name: <%# XPath(Request.Params["name"], "0,1") %> <br />
                      Name: <%# XPath(Request.Params["name"], "0,1", new XmlNamespaceManager(new XmlTextReader("books.xml").NameTable)) %> <br />
                      <hr />
                    </ItemTemplate>
                </asp:Repeater>
            </ItemTemplate>
        </asp:FormView>
    </div>
    </form>
</body>
</html>
