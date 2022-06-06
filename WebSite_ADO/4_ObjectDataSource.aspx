<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Country : 
            <asp:DropDownList ID="DropDownList1" runat="server" 
                DataSourceID="ObjectDataSource1" 
                >
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCountries" TypeName="CustomerUtility"></asp:ObjectDataSource>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
