<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="users.aspx.cs" Inherits="architecture.users" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       
        <table>
            <tr>
                <th>Id</th>
                <td>
                    <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
                </td>
            </tr>
            <tr>
                <th>Name</th>
                <td>
                    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <th>Email</th>
                <td>
                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                </td>
                <td></td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnAdd" runat="server" Text="ADD" OnClick="btnAdd_Click" />
                </td>
                <td>
                    <asp:Button ID="btnUpdate" runat="server" Text="UPDATE" OnClick="btnUpdate_Click" />
                </td>
                <td>
                    <asp:Button ID="btnDelete" runat="server" Text="DELETE" OnClick="btnDelete_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
                </td>
            </tr>
        </table>
       
    </form>
</body>
</html>
