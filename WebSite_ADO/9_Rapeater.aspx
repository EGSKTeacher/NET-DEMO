<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
    //https://www.w3schools.com/css/css_table.asp
    //https://www.w3schools.com/css/tryit.asp?filename=trycss_table_fancy
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
                <HeaderTemplate>
                    Header <br />
                </HeaderTemplate>
                <ItemTemplate>
                    <%# Eval("CustomerId") %> <br />
                </ItemTemplate>
                <FooterTemplate>
                    Footer <br />
                </FooterTemplate>
            </asp:Repeater>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCustomers" TypeName="CustomerUtility"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
