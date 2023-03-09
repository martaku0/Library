<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userLogin.aspx.cs" Inherits="Library.userLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Login</title>
    <link href="styles/login.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
            <div class="component">
                <asp:Label ID="lbUser" runat="server" Text="użytkownik"></asp:Label>
                <asp:TextBox ID="tbUser" runat="server" CssClass="textbox"></asp:TextBox>
            </div>
            <div class="component">
                <asp:Label ID="lbPassword" runat="server" Text="hasło"></asp:Label>
                <asp:TextBox ID="tbPassword" runat="server" passwordChar="*" CssClass="textbox"></asp:TextBox>
            </div>
            <asp:Button ID="btnSubmit" runat="server" Text="zaloguj" OnClick="btnSubmit_Click" CssClass="button"/>
            <asp:HyperLink ID="hlRegister" runat="server" NavigateUrl="~/userRegister.aspx" CssClass="link">zarejestruj</asp:HyperLink>    
            <asp:Label ID="lbInfo" runat="server" ForeColor="#FF3300" CssClass="lbInfo"></asp:Label> 
            <asp:HyperLink ID="hlBack" runat="server" NavigateUrl="~/Connection.aspx" CssClass="link">wróć</asp:HyperLink>            
    </form>
</body>
</html>
