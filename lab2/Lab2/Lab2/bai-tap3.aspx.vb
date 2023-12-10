Public Class bai_tap3
    Inherits System.Web.UI.Page
    Dim selectedValue As String
    Dim imagePath As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        selectedValue = ListBox1.SelectedValue
        imagePath = $"~/Images/{selectedValue}.jpg"
        Image1.ImageUrl = imagePath
    End Sub
End Class