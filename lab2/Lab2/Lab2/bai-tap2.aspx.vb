Public Class bai_tap2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub LinkButtonConfirm_Click(sender As Object, e As EventArgs) Handles LinkButton1.Click
        label_hoTen.Text = TextBox1.Text
        label_result.Text = "Chào mừng bạn đã đến với môn học Lập trình Web2"
    End Sub
End Class