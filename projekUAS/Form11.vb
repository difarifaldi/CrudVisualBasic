Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Connection()
        Call Status()
        Call loadData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call DBview5()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Call Ubah()
        Call loadData()
    End Sub

    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        loadData()
    End Sub
End Class