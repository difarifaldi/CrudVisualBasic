
Public Class Form6
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtp1.Format = DateTimePickerFormat.Custom
        dtp1.CustomFormat = " "
        Call Connection()
        Call Status()

    End Sub
    Private Sub dtp1_ValueChanged(sender As Object, e As EventArgs) Handles dtp1.ValueChanged
        dtp1.CustomFormat = "MM/dd/yyyy"
    End Sub
    Private Sub Form6_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Panel1.Left = (Me.Width - Panel1.Width) / 2
    End Sub
    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        Call TextBrubah()
    End Sub

    Private Sub bAddExt_Click(sender As Object, e As EventArgs) Handles bAddExt.Click
        Call extFile()
    End Sub

    Private Sub bClear_Click(sender As Object, e As EventArgs) Handles bClear.Click
        Call kosongin()
        Call Clear2()
    End Sub

    Private Sub bFind_Click(sender As Object, e As EventArgs) Handles bFind.Click
        Call Temu()
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Call Simpen()
        Call Save2()
        loadData()
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            loadData()
            Call loadData()
        Else
            CheckBox1.CheckState = False
            DataGridView1.Rows.Clear()
            Return
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call DBview2()
        loadData()
    End Sub

    Private Sub btn_Del_Click(sender As Object, e As EventArgs) Handles btn_Del.Click
        Call Delete2()
        loadData()
    End Sub

    Private Sub btn_Upd_Click(sender As Object, e As EventArgs) Handles btn_Upd.Click
        Call Updated2()
        loadData()
    End Sub
    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        Call Search2()
    End Sub
End Class