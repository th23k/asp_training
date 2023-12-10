Public Class bai_tap6
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub
    Protected Sub BulletedList1_Click(ByVal sender As Object, ByVal e As BulletedListEventArgs)
        Dim selectedValue As String = BulletedList1.Items(e.Index).Value
        Response.Redirect(selectedValue)
    End Sub

    Private Sub SetBulletedListDisplayMode()
        Select Case ddlDisplayMode.SelectedValue
            Case "1"
                BulletedList1.BulletStyle = BulletStyle.Numbered
            Case "2"
                BulletedList1.BulletStyle = BulletStyle.LowerRoman
            Case "3"
                BulletedList1.BulletStyle = BulletStyle.UpperRoman
            Case "4"
                BulletedList1.BulletStyle = BulletStyle.Circle
            Case "5"
                BulletedList1.BulletStyle = BulletStyle.Square
            Case Else
                BulletedList1.DisplayMode = BulletedListDisplayMode.LinkButton
        End Select
    End Sub

    Protected Sub ddlDisplayMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ddlDisplayMode.SelectedIndexChanged
        SetBulletedListDisplayMode()
    End Sub
End Class