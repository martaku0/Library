<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userRegister.aspx.cs" Inherits="Library.userRegister" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Register</title>
    <link href="styles/register.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
            <div class="component">
                <asp:Label ID="lbEmail" runat="server" Text="email"></asp:Label>
                <asp:TextBox ID="tbEmail" runat="server" CssClass="textbox"></asp:TextBox>
            </div>
            <div class="component">
                <asp:Label ID="lbUser" runat="server" Text="użytkownik"></asp:Label>
                <asp:TextBox ID="tbUser" runat="server" CssClass="textbox"></asp:TextBox>
            </div>
            <div class="component">
                <asp:Label ID="lbPassword" runat="server" Text="hasło"></asp:Label>
                <asp:TextBox ID="tbPassword" runat="server" passwordChar="*" CssClass="textbox"></asp:TextBox>
            </div>
            <asp:Button ID="btnRegister" runat="server" Text="zarejestruj" OnClick="btnRegister_Click" CssClass="button"/>
            <asp:Label ID="lbInfo" runat="server" ForeColor="#FF3300" CssClass="lbInfo"></asp:Label>
            <asp:HyperLink ID="hlBack" runat="server" NavigateUrl="~/userLogin.aspx" CssClass="link">wróć</asp:HyperLink>            
    </form>
</body>
</html>
