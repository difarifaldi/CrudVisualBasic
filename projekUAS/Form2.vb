Imports System.Diagnostics
Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs)
        Label5.Text = ""
        Timer1.Start()
        Timer2.Start()
    End Sub

    Private Sub bAssignment_Click(sender As Object, e As EventArgs) Handles bAssignment.Click
        With Form6
            .TopLevel = False
            Panel5.Controls.Add(Form6)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub bLogOut_Click(sender As Object, e As EventArgs) Handles bLogOut.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub bAttend_Click(sender As Object, e As EventArgs) Handles bAttend.Click
        With Form9
            .TopLevel = False
            Panel5.Controls.Add(Form9)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub bHome_Click(sender As Object, e As EventArgs) Handles bHome.Click
        With Form7
            .TopLevel = False
            Panel5.Controls.Add(Form7)
            BringToFront()
            .Hide()
        End With
        With Form6
            .TopLevel = False
            Panel5.Controls.Add(Form6)
            BringToFront()
            .Hide()
        End With
        With Form9
            .TopLevel = False
            Panel5.Controls.Add(Form9)
            .BringToFront()
            .Hide()
        End With
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        animasi()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblwaktu.Text = Date.Now.ToString(" hh:mm")
        lbltanggal.Text = Date.Now.ToString(" dd/MM/yyyy ")
    End Sub

    Private Sub PictureBox2_Click_1(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim osVersion = My.Computer.Info.OSVersion
        Dim OsName = My.Computer.Info.OSFullName
        MsgBox(OsName & vbCr & osVersion)
    End Sub

    Private Sub bAbout_Click(sender As Object, e As EventArgs) Handles bAbout.Click
        With Form7
            .TopLevel = False
            Panel5.Controls.Add(Form7)
            .BringToFront()
            .Show()
        End With

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim URL As String = "https://pnj.ac.id/"
        Dim NewProcess As Diagnostics.ProcessStartInfo = New Diagnostics.ProcessStartInfo(URL)
        NewProcess.UseShellExecute = True
        System.Diagnostics.Process.Start(NewProcess)
    End Sub
End Class