Public Class bai_tap4
    Inherits System.Web.UI.Page
    Dim selectedValue As String
    Dim count As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub button_Result_Click(sender As Object, e As EventArgs) Handles button_Result.Click
        butteledlist_Result.Items.Clear()
        Dim count = 1
        For Each item As ListItem In CheckBoxList1.Items
            If item.Selected Then
                butteledlist_Result.Items.Add(New ListItem($"{count}. {item.Text}", item.Value))
                count += 1
            End If
        Next
    End Sub

    Protected Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs)
        selectedValue = ""

        If radio_mayGiat.Checked Then
            selectedValue = radio_mayGiat.Text
        End If
        If (radio_tuLanh.Checked) Then
            selectedValue = radio_tuLanh.Text
        End If
        If (radio_tivi.Checked) Then
            selectedValue = radio_tivi.Text
        End If

        If (radio_dauDia.Checked) Then
            selectedValue = radio_dauDia.Text
        End If

        If (radio_loViBa.Checked) Then
            selectedValue = radio_loViBa.Text
        End If
        If (radio_noiComDien.Checked) Then
            selectedValue = radio_noiComDien.Text
        End If
        label_result.Text = "Bạn đã chọn: " + selectedValue
    End Sub
End Class