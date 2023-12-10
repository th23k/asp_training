Public Class bai_tap5
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim selectedItem As String = ddlDisplayMode.SelectedItem.Text
        Dim quantity As String = textbox_soLuong.Text

        If String.IsNullOrEmpty(quantity) Then
            label_error.Text = "Chưa có số lượng"
        Else
            ListBox1.Items.Add(New ListItem(selectedItem & " (" & quantity & ")", selectedItem))
            ddlDisplayMode.SelectedIndex = 0
            textbox_soLuong.Text = ""
        End If
    End Sub
    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As EventArgs)
        ListBox1.Items.Clear()
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim hoTen As String = textbox_hoTen.Text
        Dim diaChi As String = textbox_diaChi.Text
        Dim maSoThue As String = textbox_maSoThue.Text
        Session("HoTen") = hoTen
        Session("DiaChi") = diaChi
        Session("MaSoThue") = maSoThue

        Dim danhSachBanh As List(Of String) = New List(Of String)()
        For Each item As ListItem In ListBox1.Items
            danhSachBanh.Add(item.Text)
        Next
        Session("DanhSachBanh") = danhSachBanh
        ShowInvoice()
    End Sub

    Private Sub ShowInvoice()
        litHoTen.Text = TryCast(Session("HoTen"), String)
        litDiaChi.Text = TryCast(Session("DiaChi"), String)
        litMaSoThue.Text = TryCast(Session("MaSoThue"), String)
        Dim danhSachBanh As List(Of String) = TryCast(Session("DanhSachBanh"), List(Of String))
        Dim dt As DataTable = New DataTable()
        dt.Columns.AddRange(New DataColumn(1) {New DataColumn("TenBanh"), New DataColumn("SoLuong")})
        For Each banh In danhSachBanh
            dt.Rows.Add(banh, 1)
        Next
        GridView1.DataSource = dt
        GridView1.DataBind()
        pnlInvoice.Visible = True
    End Sub

End Class