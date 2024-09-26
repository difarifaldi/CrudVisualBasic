Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs)
        lblstory.Text = ""
        Timer3.Start()
        Timer4.Start()
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        If PictureBox3.Left < Me.Width Then
            PictureBox3.Left = PictureBox3.Left + 10
        Else
            PictureBox3.Left = 0
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox4.Left < Me.Width Then
            PictureBox4.Left = PictureBox4.Left + 10
        Else
            PictureBox4.Left = 0
        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Call animasi2()
    End Sub
End Class