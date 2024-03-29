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
            Country : 
            <asp:DropDownList ID="DropDownList1" runat="server" 
                DataSourceID="ObjectDataSource1" AutoPostBack="True" 
                >
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCountries" TypeName="CustomerUtility"></asp:ObjectDataSource>
            <br />
            <br />
            <br />
            <asp:ListView ID="ListView1" runat="server" DataSourceID="ObjectDataSource2">
                <AlternatingItemTemplate>
                    <tr style="background-color: #FFFFFF;color: #284775;">
                        <td>
                            <asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CompanyNameLabel" runat="server" Text='<%# Eval("CompanyName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                        </td>
                    </tr>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <tr style="background-color: #999999;">
                        <td>
                            <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        </td>
                        <td>
                            <asp:TextBox ID="CustomerIDTextBox" runat="server" Text='<%# Bind("CustomerID") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="CompanyNameTextBox" runat="server" Text='<%# Bind("CompanyName") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                        </td>
                    </tr>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                        <tr>
                            <td>No data was returned.</td>
                        </tr>
                    </table>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <tr style="">
                        <td>
                            <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                            <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        </td>
                        <td>
                            <asp:TextBox ID="CustomerIDTextBox" runat="server" Text='<%# Bind("CustomerID") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="CompanyNameTextBox" runat="server" Text='<%# Bind("CompanyName") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="CountryTextBox" runat="server" Text='<%# Bind("Country") %>' />
                        </td>
                        <td>
                            <asp:TextBox ID="CityTextBox" runat="server" Text='<%# Bind("City") %>' />
                        </td>
                    </tr>
                </InsertItemTemplate>
                <ItemTemplate>
                    <tr style="background-color: #E0FFFF;color: #333333;">
                        <td>
                            <asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CompanyNameLabel" runat="server" Text='<%# Eval("CompanyName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
                <LayoutTemplate>
                    <table runat="server">
                        <tr runat="server">
                            <td runat="server">
                                <table id="itemPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                    <tr runat="server" style="background-color: #E0FFFF;color: #333333;">
                                        <th runat="server">CustomerID</th>
                                        <th runat="server">CompanyName</th>
                                        <th runat="server">Country</th>
                                        <th runat="server">City</th>
                                    </tr>
                                    <tr id="itemPlaceholder" runat="server">
                                    </tr>
                                </table>
                            </td>
                        </tr>
                        <tr runat="server">
                            <td runat="server" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                                <asp:DataPager ID="DataPager1" runat="server">
                                    <Fields>
                                        <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowLastPageButton="True" />
                                    </Fields>
                                </asp:DataPager>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <tr style="background-color: #E2DED6;font-weight: bold;color: #333333;">
                        <td>
                            <asp:Label ID="CustomerIDLabel" runat="server" Text='<%# Eval("CustomerID") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CompanyNameLabel" runat="server" Text='<%# Eval("CompanyName") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CountryLabel" runat="server" Text='<%# Eval("Country") %>' />
                        </td>
                        <td>
                            <asp:Label ID="CityLabel" runat="server" Text='<%# Eval("City") %>' />
                        </td>
                    </tr>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="GetCustomersByCountry" TypeName="CustomerUtility">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" Name="country" PropertyName="SelectedValue" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
