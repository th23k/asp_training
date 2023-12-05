<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="bai-tap1.aspx.vb" Inherits="Lab_1.bai_tap1" %>

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

            <asp:Button ID="Button1" runat="server" Text="tổng" /> <br/><br/>

            Ket qua : <asp:Label ID="kq" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
