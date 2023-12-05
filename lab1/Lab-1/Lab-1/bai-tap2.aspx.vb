Public Class bai_tap2
    Inherits System.Web.UI.Page
    Dim a As Double
    Dim b As Double
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Tong.Click
        a = TextBox1.Text
        b = TextBox2.Text
        kq.Text = a + b
    End Sub

    Protected Sub Button2_Click(sender As Object, e As EventArgs) Handles Hieu.Click
        a = TextBox1.Text
        b = TextBox2.Text
        kq.Text = a - b
    End Sub

    Protected Sub Button3_Click(sender As Object, e As EventArgs) Handles Thuong.Click
        a = TextBox1.Text
        b = TextBox2.Text
        kq.Text = a / b
    End Sub
End Class