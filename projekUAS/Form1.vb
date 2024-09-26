
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Status Connection
        Call Connection()
        Call Status()
    End Sub

    Private Sub bExit_Click(sender As Object, e As EventArgs) Handles bExit.Click
        Me.Close()
    End Sub

    Private Sub bLogin_Click_1(sender As Object, e As EventArgs) Handles bLogin.Click
        If tbUser.Text = "" Or tbPass.Text = "" Then
            MsgBox(" Data belum lengkap, silahkan isi semua form ")
        Else
            Call Connection()
            Call Validation()
            tbUser.Clear()
            tbPass.Clear()
        End If
    End Sub

    Private Sub lblSignIn_Click_1(sender As Object, e As EventArgs) Handles lblSignIn.Click
        Me.Hide()
        Form3.Show()
        Form3.Height = 300
    End Sub

    Private Sub lblForgot_Click_1(sender As Object, e As EventArgs) Handles lblForgot.Click
        Me.Hide()
        Form4.Show()
    End Sub
End Class

