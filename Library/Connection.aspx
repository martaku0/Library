<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Connection.aspx.cs" Inherits="Library.Connection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Connection</title>
    <link href="styles/connection.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="component">
            <asp:Label ID="lbServer" runat="server" Text="serwer"></asp:Label>
            <asp:TextBox ID="tbServer" runat="server" CssClass="textbox">localhost</asp:TextBox>
        </div>
        <div class="component">
            <asp:Label ID="lbDatabase" runat="server" Text="baza danych"></asp:Label>
            <asp:TextBox ID="tbDatabase" runat="server" CssClass="textbox">library</asp:TextBox>
        </div>
        <div class="component">
            <asp:Label ID="lbUser" runat="server" Text="użytkownik"></asp:Label>
            <asp:TextBox ID="tbUser" runat="server" CssClass="textbox">root</asp:TextBox>
        </div>
        <div class="component">
            <asp:Label ID="lbPassword" runat="server" Text="hasło"></asp:Label>
            <asp:TextBox ID="tbPassword" runat="server" CssClass="textbox"></asp:TextBox>
        </div>
        <asp:Button ID="btConnect" runat="server" Text="połącz" OnClick="btConnect_Click" class="button"/>
        <asp:Label ID="lbError" runat="server" Text="Label" ForeColor="#FF3300" CssClass="lbInfo"></asp:Label>
    </form>
</body>
</html>
