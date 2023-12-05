Imports System.Security.Cryptography

Public Class bai_tap1
    Inherits System.Web.UI.Page
    Dim a As Integer
    Dim b As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        kq.Text = a + b
    End Sub
End Class