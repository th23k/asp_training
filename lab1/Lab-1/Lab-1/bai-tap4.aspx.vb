Public Class bai_tap4
    Inherits System.Web.UI.Page
    Dim a As Integer
    Dim b As Integer
    Dim nghiem As Double
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        If a = 0 And b <> 0 Then
            kq.Text = "PHUONG TRINH VO NGHIEM"
        End If
        If a = 0 And b = 0 Then
            kq.Text = "PHUONG TRINH VO SO NGHIEM"
        End If
        If a <> 0 Then
            kq.Text = "PHUONG TRINH CO NGHIEM X= " & (-b / a)
        End If
    End Sub
End Class