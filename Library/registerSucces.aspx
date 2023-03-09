<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registerSucces.aspx.cs" Inherits="Library.registerSucces" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Register Success</title>
    <link href="styles/registersuccess.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
            <p>zarejestrowano!</p>
            <asp:HyperLink NavigateUrl="~/userLogin.aspx" runat="server">zaloguj się</asp:HyperLink>
    </form>
</body>
</html>
