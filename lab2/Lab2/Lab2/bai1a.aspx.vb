Imports System.Drawing

Public Class bai1a
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub button_dangKy_Click(sender As Object, e As EventArgs) Handles button_dangKy.Click
        Dim selectedValue As String
        selectedValue = ""
        If radio_nam.Checked Then
            selectedValue = radio_nam.Text
        End If
        If raio_nu.Checked Then
            selectedValue = raio_nu.Text
        End If

        bulletedlist_result.Items.Clear()
        bulletedlist_result.Items.Add($"Họ tên khách hàng: {textbox_hoTen.Text}")
            bulletedlist_result.Items.Add($"Giới tính: {selectedValue}")
            bulletedlist_result.Items.Add($"Email: {textbox_email.Text}")
            bulletedlist_result.Items.Add($"Địa chỉ: {textarea_diaChi.Value}")
            bulletedlist_result.Items.Add($"Điện thoại: {textbox_dienThoai.Text}")

    End Sub
End Class