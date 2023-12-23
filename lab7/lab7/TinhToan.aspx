<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="TinhToan.aspx.cs" Inherits="lab7.TinhToan" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
      <h3>Tính Tổng</h3>
      <div>
          <label for="lblA">Nhập số N:</label>
          <asp:TextBox ID="txtN" runat="server"></asp:TextBox>
          <asp:RegularExpressionValidator ID="revtxtN" runat="server" ErrorMessage="Nhập N lớn hơn 0 và bé hơn 100" ControlToValidate="txtN" ValidationExpression="^[1-9][0-9]?$|^100$" ForeColor="Red"></asp:RegularExpressionValidator>
          <asp:RequiredFieldValidator ID="rfvtxtN" runat="server" ErrorMessage="Nhập N" ControlToValidate="txtN" ForeColor="Red"></asp:RequiredFieldValidator>
      </div>
      <div>
          <asp:Button ID="btnTong" runat="server" Text="Tính Tổng" OnClick="btnTong_Click" />
      </div>
      <div>
          <asp:Label ID="lblResult" runat="server" ForeColor="Green"></asp:Label>
      </div>
  </div>
</asp:Content>
