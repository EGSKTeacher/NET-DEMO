<%@ Page Language="C#" %>

<!DOCTYPE html>

<script runat="server">
//https://www.w3schools.com/css/css_form.asp
//https://www.w3schools.com/css/tryit.asp?filename=trycss_forms

</script>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        input[type=text], select {
            width: 100%;
            padding: 12px 20px;
            margin: 8px 0;
            display: inline-block;
            border: 1px solid #ccc;
            border-radius: 4px;
            box-sizing: border-box;
        }

        input[type=submit] {
            width: 100%;
            background-color: #4CAF50;
            color: white;
            padding: 14px 20px;
            margin: 8px 0;
            border: none;
            border-radius: 4px;
            cursor: pointer;
        }

            input[type=submit]:hover {
                background-color: #45a049;
            }

        div {
            border-radius: 5px;
            background-color: #f2f2f2;
            padding: 20px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <label for="fname">CustomerId</label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>

            <label for="lname">CompanyName</label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>

            <label for="country">Country</label>
            <asp:DropDownList ID="DropDownList1" runat="server"
                DataSourceID="ObjectDataSource2">
            </asp:DropDownList>
            <asp:ObjectDataSource ID="ObjectDataSource2" runat="server"
                SelectMethod="GetCountries" TypeName="CustomerUtility"></asp:ObjectDataSource>

            <label for="fname">City</label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>

            <%--<input type="submit" value="Submit">--%>
            <asp:Button ID="Button1" runat="server" Text="Add Customer" />
        </div>
    </form>
</body>
</html>
