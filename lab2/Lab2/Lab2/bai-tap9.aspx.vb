Imports System.IO

Public Class bai_tap9
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MultiView1.ActiveViewIndex = 0
    End Sub

    Protected Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        If FileUpload1.PostedFile IsNot Nothing Then
            Dim fileName As String = Path.GetFileName(FileUpload1.PostedFile.FileName)
            Dim uploadFolder As String = Server.MapPath("~/Upload/")

            If Not Directory.Exists(uploadFolder) Then
                Directory.CreateDirectory(uploadFolder)
            End If
            Dim filePath = Path.Combine(uploadFolder, fileName)
            FileUpload1.SaveAs(filePath)
            LoadFileList()
        End If
    End Sub

    Private Sub LoadFileList()
        Dim uploadFolder As String = Server.MapPath("~/Upload/")
        Dim files = Directory.GetFiles(uploadFolder)

        ListBox1.Items.Clear()

        For Each file In files
            ListBox1.Items.Add(Path.GetFileName(file))
        Next
    End Sub
    Protected Sub lnkView2_Click(ByVal sender As Object, ByVal e As EventArgs)
        MultiView1.ActiveViewIndex = 1
        LoadFileList()
    End Sub

    Protected Sub lnkView1_Click(ByVal sender As Object, ByVal e As EventArgs)
        MultiView1.ActiveViewIndex = 0
    End Sub
End Class