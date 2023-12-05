Public Class bai_tap5
    Inherits System.Web.UI.Page
    Dim a As Double
    Dim b As Double
    Dim c As Double
    Dim d As Double

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        d = (b * b) - (4 * a * c)
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        If a = 0 Then
            kq.Text = "PHUONG TRINH BAC HAI VO NGHIEM"
        End If
        If a <> 0 And (d) < 0 Then
            kq.Text = " PHUONG TRINH VO NGHIEM"
        End If
        If a <> 0 And (d) = 0 Then
            kq.Text = " PHUONG TRINH CO NGHIEM KEP X=" & (-b / 2 * a)
        End If
        If a <> 0 And (b) > 0 Then
            kq.Text = " PHUONG TRINH CO 2 NGHIEM X1= " & ((b + Math.Sqrt(d)) / 2 * a) & " X2=" & ((-b - Math.Sqrt(d)) / 2 * a)
        End If
    End Sub
End Class