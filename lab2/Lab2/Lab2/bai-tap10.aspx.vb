Public Class bai_tap10
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ViewState("SelectedItems") = New List(Of String)()
        Else
            Dim selectedItems As List(Of String) = TryCast(ViewState("SelectedItems"), List(Of String))

            If selectedItems IsNot Nothing Then
                For Each item In selectedItems
                    ListBox1.Items.Add(New ListItem(item, item.GetHashCode().ToString()))
                Next
                resultLabel.Text = $"{selectedItems.Count} sản phẩm"
            End If
        End If

    End Sub

    Protected Sub CheckBox_CheckedChanged(sender As Object, e As EventArgs)
        UpdateCheckedCount()
    End Sub
    Private Sub UpdateCheckedCount()
        Dim selectedItems As List(Of String) = TryCast(ViewState("SelectedItems"), List(Of String))

        If selectedItems Is Nothing Then
            selectedItems = New List(Of String)()
        End If
        Dim selectedCount = 0
        ListBox1.Items.Clear()
        If CheckBox1.Checked Then
            ListBox1.Items.Add(New ListItem(CheckBox1.Text, "1"))
            selectedItems.Add("Option 1")
            selectedCount += 1
        End If
        If CheckBox2.Checked Then
            ListBox1.Items.Add(New ListItem(CheckBox2.Text, "2"))
            selectedItems.Add("Option 2")
            selectedCount += 1
        End If
        If CheckBox3.Checked Then
            ListBox1.Items.Add(New ListItem(CheckBox3.Text, "3"))
            selectedItems.Add("Option 3")
            selectedCount += 1
        End If
        If CheckBox4.Checked Then
            ListBox1.Items.Add(New ListItem(CheckBox4.Text, "4"))
            selectedItems.Add("Option 4")
            selectedCount += 1
        End If
        If CheckBox5.Checked Then
            ListBox1.Items.Add(New ListItem(CheckBox5.Text, "5"))
            selectedItems.Add("Option 5")
            selectedCount += 1
        End If
        If CheckBox6.Checked Then
            ListBox1.Items.Add(New ListItem(CheckBox6.Text, "6"))
            selectedItems.Add("Option 6")
            selectedCount += 1
        End If
        If CheckBox7.Checked Then
            ListBox1.Items.Add(New ListItem(CheckBox7.Text, "7"))
            selectedItems.Add("Option 7")
            selectedCount += 1
        End If
        ViewState("SelectedItems") = selectedItems
        resultLabel.Text = $"{selectedCount} sản phẩm"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        ViewState("SelectedItems") = New List(Of String)()
        ListBox1.Items.Clear()
        resultLabel.Text = "0 sản phẩm"
    End Sub
End Class