Public Class bai_tap3
    Inherits System.Web.UI.Page
    Dim a As Double
    Dim b As Double
    Dim c As Double

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        c = TextBox3.Text
        Dim max As Double
        max = a
        If max < b Then
            max = b
        End If
        If max < c Then
                max = c
            End If
            kq.Text = max
    End Sub
End Class