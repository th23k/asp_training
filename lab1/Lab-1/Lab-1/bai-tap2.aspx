<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="bai-tap2.aspx.vb" Inherits="Lab_1.bai_tap2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="a: "></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> <br/><br/>

            <asp:Label ID="Label2" runat="server" Text="b: "></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> <br/><br/>

            <asp:Button ID="Tong" runat="server" Text="tổng" style="margin-right:5px"/> <asp:Button ID="Hieu" runat="server" Text="hiệu" style="margin-right:5px"/> <asp:Button ID="Thuong" runat="server" Text="thương" /> <br/>


            Ket qua : <asp:Label ID="kq" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
