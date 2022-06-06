<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(DropDownList1.SelectedItem.Value);
    }

    protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
    {
        Response.Write(DropDownList2.SelectedItem.Value);
    }
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" 
                DataSourceID="ObjectDataSource1" 
                DataTextField="CustomerID" DataValueField="Country" 
                OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCustomers" TypeName="CustomerUtility"></asp:ObjectDataSource>
            <br />
            <br />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList2" runat="server" 
                DataSourceID="ObjectDataSource2" AutoPostBack="true"
                OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged"
               >
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" 
                SelectMethod="GetCountries" TypeName="CustomerUtility"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
