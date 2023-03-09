<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowData.aspx.cs" Inherits="Library.ShowData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Data</title>
    <link href="styles/showdata.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server" visible="True">
        <asp:GridView ID="GridView1" runat="server" OnRowCommand="GridView1_RowCommand" OnRowDeleting="GridView1_RowDeleting" CssClass="gridview">
            <Columns>
                <asp:ButtonField CommandName="EditRow" HeaderText="Edytuj" ShowHeader="True" Text="edytuj" />
                <asp:ButtonField CommandName="Del" HeaderText="Usuń" ShowHeader="True" Text="usuń" />
            </Columns>
        </asp:GridView>
        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/addRecord.aspx" Text="dodaj"></asp:HyperLink>
        <asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/search.aspx">szukaj</asp:HyperLink>
        <asp:HyperLink ID="hlBack" runat="server" NavigateUrl="~/userLogin.aspx" CssClass="link">wróć</asp:HyperLink>            
    </form>
</body>
</html>
