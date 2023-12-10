<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="bai-tap1b.aspx.vb" Inherits="Lab2.bai_tap1b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Css/bai-tap1b.css" rel="stylesheet" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
                <table>
    <tr class="row-1">
        <td>Lợi ích của đọc báo:
            <ul>
            <li>Mở rộng kiến thức</li>
            <li>Cập nhật thông tin</li>
            <li>Rèn luyện trí nhớ</li>
            <li>Giải trí ít tốn kém</li>
        </ul>
        </td>
        
        <td>
            <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/docbao.jfif" Width="80%" Height="100px" /></td>
    </tr>
    <tr class="row-2">
        <td colspan="2">
            <asp:HyperLink ID="hyperlink_tuoiTre" runat="server" NavigateUrl="https://tuoitre.vn/" ForeColor="Yellow">Tuổi trẻ</asp:HyperLink>
        </td>

    </tr>
    <tr class="row-3">
        <td colspan="2">
             <asp:HyperLink ID="hyperlink_tinNhanh" runat="server" NavigateUrl="https://vnexpress.net/" ForeColor="Yellow">Tin nhanh</asp:HyperLink>
        </td>
    </tr>
    <tr class="row-4">
        <td colspan="2">
            <asp:HyperLink ID="hyperlink_thanhNien" runat="server" NavigateUrl="https://thanhnien.vn/" ForeColor="Yellow">Thanh niên</asp:HyperLink>
        </td>
    </tr>
         <tr class="row-5">
        <td colspan="2">
            <asp:HyperLink ID="hyperlink_nguoiLaoDong" runat="server" NavigateUrl="https://nld.com.vn/" ForeColor="Yellow">Người lao động</asp:HyperLink>
        </td>
    </tr>
</table>
        </div>
    </form>
</body>
</html>
