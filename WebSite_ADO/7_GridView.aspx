﻿<%@ Page Language="C#" %>

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
            <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="Horizontal">
                <Columns>
                    <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" />
                    <asp:BoundField DataField="CustomerID" HeaderText="客戶編號" SortExpression="CustomerID" />
                    <asp:BoundField DataField="CompanyName" HeaderText="CompanyName" SortExpression="CompanyName" />
                    <asp:TemplateField HeaderText="Country" SortExpression="Country">
                        <EditItemTemplate>
                            <%--<asp:TextBox ID="TextBox1" runat="server" Text='<%# Bind("Country") %>'></asp:TextBox>--%>
                            <asp:DropDownList ID="DropDownList1" runat="server"
                                DataSourceID="ObjectDataSource2" SelectedValue='<%# Bind("Country") %>'>
                            </asp:DropDownList>
                            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server"
                                SelectMethod="GetCountries" TypeName="CustomerUtility"></asp:ObjectDataSource>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="Label1" runat="server" Text='<%# Bind("Country") %>'></asp:Label>
                            -XXX
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:BoundField DataField="City" HeaderText="City" SortExpression="City" />
                </Columns>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="GetCustomers" TypeName="CustomerUtility" UpdateMethod="Update">
                <DeleteParameters>
                    <asp:Parameter Name="customerId" Type="String" />
                </DeleteParameters>
                <InsertParameters>
                    <asp:Parameter Name="customerId" Type="String" />
                    <asp:Parameter Name="companyName" Type="String" />
                    <asp:Parameter Name="country" Type="String" />
                    <asp:Parameter Name="city" Type="String" />
                </InsertParameters>
                <UpdateParameters>
                    <asp:Parameter Name="customerId" Type="String" />
                    <asp:Parameter Name="companyName" Type="String" />
                    <asp:Parameter Name="country" Type="String" />
                    <asp:Parameter Name="city" Type="String" />
                </UpdateParameters>
            </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
