Public Class Form9
    Private Sub Form9_Load(sender As Object, e As EventArgs)
        Call Status()
        Call Connection()
        loadData()
    End Sub

    Private Sub bSubmit_Click(sender As Object, e As EventArgs) Handles bSubmit.Click
        If CheckBox1.CheckState = False Or t_Nama.Text = "" Or t_NIM.Text = "" Or t_Kelas.Text = "" Or cb1.Text = "" Then
            MsgBox(" Pastikan sudah mengisi semua form ", vbInformation)
        ElseIf rbTidak.Checked = True Then
            MsgBox(" Pastikan mengganti dengan ya ")
        ElseIf CheckBox1.CheckState = False Then
            MsgBox(" Pastikan sudah menceklis kalimat kejujuran ")
        Else
            Call Save3()
            loadData()
        End If
    End Sub

    Private Sub bSearch_Click(sender As Object, e As EventArgs) Handles bSearch.Click
        loadData()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Call DBview3()
    End Sub

End Class