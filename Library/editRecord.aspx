<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editRecord.aspx.cs" Inherits="Library.editRecord" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Edit Record</title>
    <link href="styles/addrecord.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
            <div class="component">
                <asp:Label ID="lbAuthors" runat="server" Text="Authors"></asp:Label>
                <asp:TextBox ID="tbAuthors" runat="server" CssClass="textbox"></asp:TextBox>
            </div>
            <div class="component">
                <asp:Label ID="lbTitle" runat="server" Text="Title"></asp:Label>
                <asp:TextBox ID="tbTitle" runat="server" CssClass="textbox"></asp:TextBox>
            </div>
            <div class="component">
                <asp:Label ID="lbRealese" runat="server" Text="Release date"></asp:Label>
                <asp:TextBox ID="tbRealese" runat="server" CssClass="textbox"></asp:TextBox>
            </div>
            <div class="component">
                <asp:Label ID="lbIsbm" runat="server" Text="ISBN"></asp:Label>
                <asp:TextBox ID="tbIsbm" runat="server" CssClass="textbox"></asp:TextBox>
            </div>
            <div class="component">
                <asp:Label ID="lbFormat" runat="server" Text="Format"></asp:Label>
                <asp:TextBox ID="tbFormat" runat="server" CssClass="textbox" MaxLength="3"></asp:TextBox>
            </div>
            <div class="component">
                <asp:Label ID="lbPages" runat="server" Text="Pages"></asp:Label>
                <asp:TextBox ID="tbPages" runat="server" CssClass="textbox"></asp:TextBox>
            </div>
            <div class="component">
                <asp:Label ID="lbDescription" runat="server" Text="Description"></asp:Label>
                <asp:TextBox ID="tbDescription" runat="server" Rows="5" TextMode="MultiLine" CssClass="textbox"></asp:TextBox>
            </div>
            <asp:Button ID="btnEdit" runat="server" Text="edytuj" OnClick="btnEdit_Click" CausesValidation="False" UseSubmitBehavior="False" CssClass="button"/>
            <asp:Label ID="lbInfo" runat="server" ForeColor="#FF3300" CssClass="lbInfo"></asp:Label> 
            <asp:HyperLink ID="hlBack" runat="server" NavigateUrl="~/ShowData.aspx" CssClass="link">wróć</asp:HyperLink>                    
    </form>
</body>
</html>
