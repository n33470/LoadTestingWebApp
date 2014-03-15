<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPQuery.aspx.cs" Inherits="LoadTestWebApp.DynamicParameters.ASPQuery" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="IndexLabel" runat="server" Text="Label"></asp:Label>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="QueryString.aspx">Back</asp:HyperLink>
    </div>
    </form>
</body>
</html>
