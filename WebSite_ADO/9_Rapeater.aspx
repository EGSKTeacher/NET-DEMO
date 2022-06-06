<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
//https://www.w3schools.com/css/css_table.asp
//https://www.w3schools.com/css/tryit.asp?filename=trycss_table_fancy
</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #customers {
            font-family: Arial, Helvetica, sans-serif;
            border-collapse: collapse;
            width: 100%;
        }

            #customers td, #customers th {
                border: 1px solid #ddd;
                padding: 8px;
            }

            #customers tr:nth-child(even) {
                background-color: #f2f2f2;
            }

            #customers tr:hover {
                background-color: #ddd;
            }

            #customers th {
                padding-top: 12px;
                padding-bottom: 12px;
                text-align: left;
                background-color: #04AA6D;
                color: white;
            }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <h1>A Fancy Table</h1>


            <asp:Repeater ID="Repeater1" runat="server" DataSourceID="ObjectDataSource1">
                <HeaderTemplate>
                    <table id="customers">
                        <tr>
                            <th>CustomerId</th>
                            <th>CompanyName</th>
                            <th>Country</th>
                            <th>City</th>
                        </tr>
                </HeaderTemplate>
                <ItemTemplate>
                    <tr>
                        <td><%# Eval("CustomerId") %></td>
                        <td><%# Eval("CompanyName") %></td>
                        <td><%# Eval("Country") %></td>
                        <td><%# Eval("City") %></td>
                    </tr>
                </ItemTemplate>
                <FooterTemplate>
                    </table>
                </FooterTemplate>
            </asp:Repeater>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCustomers" TypeName="CustomerUtility"></asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
