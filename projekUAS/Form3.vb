Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Status Connection
        Call Connection()
        Call Status()
    End Sub

    Private Sub bEnter_Click(sender As Object, e As EventArgs) Handles bEnter.Click
        'Validasi
        Call Valid()
        Call loadData()
        loadData()
    End Sub

    Private Sub bSave_Click(sender As Object, e As EventArgs) Handles bSave.Click
        Call Save()
        loadData()
    End Sub

    Private Sub bUpdate_Click(sender As Object, e As EventArgs) Handles bUpdate.Click
        Call Updated()
        loadData()
    End Sub

    Private Sub bDelete_Click(sender As Object, e As EventArgs) Handles bDelete.Click
        Call Delete()
        loadData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call DBView()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Me.Close()
    End Sub

    Private Sub bBack_Click(sender As Object, e As EventArgs) Handles bBack.Click
        Form1.Show()
        Me.Hide()
        Call Clear()
        Me.Height = 300
    End Sub
End Class