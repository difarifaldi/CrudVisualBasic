Public Class Form4

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Me.Close()
    End Sub

    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        Form1.Show()
        Me.Hide()
        DataGridView1.Rows.Clear()
        tbSearch.Clear()
    End Sub

    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        If tbSearch.Text = "Mahasiswa" Then
            Call Search()
            loadData()
        Else
            MsgBox("Tidak Ditemukan", vbCritical, "ALERT")
            MsgBox("Isi dengan Username (Mahasiswa) dengan 'M' capital ", vbInformation, "Info")
            Return
        End If
    End Sub
End Class