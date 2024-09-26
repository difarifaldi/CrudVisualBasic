Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call Connection()
        Call Status()
        Call loadData()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call DBview2()
        loadData()
    End Sub
End Class