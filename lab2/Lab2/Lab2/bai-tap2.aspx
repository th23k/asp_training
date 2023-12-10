<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="bai-tap2.aspx.vb" Inherits="Lab2.bai_tap2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Css/bai-tap2.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
    <tr class="row-1">
        <th colspan="2">
            <asp:Label ID="Label1" runat="server" Text="Nhập họ tên"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:LinkButton ID="LinkButton1" runat="server" OnClientClick="return confirm('Bạn có đồng ý thay đổi câu chào?');" OnClick="LinkButtonConfirm_Click">Thay đổi câu chào</asp:LinkButton>
        </th>
    </tr>
    <tr class="row-2">
        <td>Chào bạn <span class="label-hoten">
            <asp:Label ID="label_hoTen" runat="server"></asp:Label></span>
            <br />
            <asp:Label ID="label_result" runat="server"></asp:Label>
        </td>
    </tr>
</table>
        </div>
    </form>
</body>
</html>
