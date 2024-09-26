Imports System.Data.OleDb
Module Module1
    Public Conn As OleDbConnection
    Public Da As OleDbDataAdapter
    Public DS As DataSet
    Dim lokasiDB As String
    Public Cmd As OleDbCommand
    Public RD As OleDbDataReader
    Dim i As Integer
    Dim text1 As String
    Dim index As Integer = 0
    Dim iEnd As Integer
    Dim mysplit As Array
    Dim count As Integer
    Dim ket As String
    Function wordCount(ByVal str As String)
        'fungsi perhitungan
        Dim NumberOfWord As Integer
        NumberOfWord = UBound(Split(Trim(Replace(str, Space(2), Space(1))))) + 1
        Return NumberOfWord
    End Function

    '~~~ Form 1&3 (Login, Signin) ~~~
    Public Sub Connection()
        lokasiDB = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\HP\Documents\filelaravel\projekUAS\bin\Debug\datalogin.accdb"
        Conn = New OleDbConnection(lokasiDB)
    End Sub
    Public Sub Status()
        Try
            Conn.Open()
            Form1.pOn.Visible = True
            Form3.pOn.Visible = True
            Form6.pOn.Visible = True
            Form4.pOn.Visible = True
            Form9.pOn.Visible = True
        Catch ex As Exception
            Form1.pOff.Visible = True
            Form3.pOff.Visible = True
            Form6.pOff.Visible = True
            Form4.pOff.Visible = True
            Form9.pOn.Visible = True
        End Try
        Conn.Close()
    End Sub

    Public Sub Validation()
        Conn.Open()
        Cmd = New OleDbCommand("select * from datalogin where Nama='" & Form1.tbUser.Text & "' and Password= '" & Form1.tbPass.Text & "'", Conn)
        RD = Cmd.ExecuteReader
        RD.Read()
        If RD.HasRows Then
            Select Case Form1.tbUser.Text
                Case "Mahasiswa"
                    Form1.Hide()
                    Form2.Show()
                Case "Dosen"
                    Form1.Hide()
                    Form5.Show()
            End Select
        Else
            MsgBox(" User atau Pass salah! ")
        End If
        Conn.Close()
    End Sub

    Public Sub Valid()
        If Form3.mtbSC.Text = "555-99-0000" _
            And Form3.mtbPin.Text = "9-3-9-2-1" Then
            MsgBox(" Selamat Datang Admin ! ")
            Form3.tbUser2.Enabled = True
            Form3.tbPass2.Enabled = True
            Form3.bSave.Enabled = True
            Form3.bDelete.Enabled = True
            Form3.bUpdate.Enabled = True
            Form3.DataGridView1.Enabled = True
            Form3.Height = 700
        Else
            MsgBox(" Tidak Dikenali ! ")
            Form3.Height = 400
        End If
    End Sub

    '~~~ Form 3 ~~~
    Public Sub loadData()
        Try
            Conn.Open()
            Form3.DataGridView1.Rows.Clear()
            Cmd = New OleDbCommand("select * from datalogin ", Conn)
            RD = Cmd.ExecuteReader
            While RD.Read
                Form3.DataGridView1.Rows.Add(RD.Item("Nama"), RD.Item("Password"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
        '6
        Try
            Conn.Open()
            Form6.DataGridView1.Rows.Clear()
            Cmd = New OleDbCommand("select * from datatugas ", Conn)
            RD = Cmd.ExecuteReader
            While RD.Read
                Form6.DataGridView1.Rows.Add(RD.Item("Nama"), RD.Item("NIM"), RD.Item("Kelas"), RD.Item("Judul Tugas"), RD.Item("Isi Tugas"), RD.Item("Tanggal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()

        '8
        Da = New OleDbDataAdapter("Select * from datanilai", Conn)
        DS = New DataSet
        DS.Clear()
        Da.Fill(DS, "datanilai")
        Form8.DataGridView1.DataSource = (DS.Tables("datanilai"))

        '9
        Try
            Conn.Open()
            Form9.DataGridView1.Rows.Clear()
            Cmd = New OleDbCommand("select * from dataabsen ", Conn)
            RD = Cmd.ExecuteReader
            While RD.Read
                Form9.DataGridView1.Rows.Add(RD.Item("Nama"), RD.Item("NIM"), RD.Item("Kelas"), RD.Item("Kehadiran"), RD.Item("Tanggal"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub Save()
        Try
            Conn.Open()
            If MsgBox("Are you sure to save the data ?", vbQuestion + vbYesNo) = vbYes Then
                Cmd = New OleDbCommand("Insert Into datalogin(`Nama`,`Password`)values(@Nama,@Password)", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Nama", Form3.tbUser2.Text)
                Cmd.Parameters.AddWithValue("@Password", Form3.tbPass2.Text)
                i = Cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Saved", vbInformation)
                Else
                    MsgBox("Pastikan mengisi kolom", vbInformation)
                End If

            Else
                MsgBox("Failed to save data", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub Clear()
        Form3.mtbSC.Clear()
        Form3.mtbPin.Clear()
        Form3.tbUser2.Clear()
        Form3.tbPass2.Clear()
        Form3.DataGridView1.Rows.Clear()
        Form3.tbUser2.Enabled = False
        Form3.tbPass2.Enabled = False
        Form3.bSave.Enabled = False
        Form3.bDelete.Enabled = False
        Form3.bUpdate.Enabled = False
        Form3.DataGridView1.Enabled = False
    End Sub

    Public Sub Delete()
        Try
            Conn.Open()
            If MsgBox("Are You Sure to Delete?", vbQuestion + vbYesNo) = vbYes Then
                Cmd = New OleDbCommand("Delete *from datalogin where Nama=@Nama ", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Nama", Form3.tbUser2.Text)
                i = Cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Deleted", vbInformation)
                End If
            Else
                MsgBox("Failed to Delete", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub DBView()
        Form3.tbUser2.Text = Form3.DataGridView1.CurrentRow.Cells(0).Value
        Form3.tbPass2.Text = Form3.DataGridView1.CurrentRow.Cells(1).Value
    End Sub

    Public Sub Updated()
        Try
            Conn.Open()
            If MsgBox("Are You Sure to Change Data?", vbQuestion + vbYesNo) = vbYes Then
                Cmd = New OleDbCommand("UPDATE datalogin SET `Nama`=@Nama,`Password`=@Password where Nama=@Nama ", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Nama", Form3.tbUser2.Text)
                Cmd.Parameters.AddWithValue("@Password", Form3.tbPass2.Text)
                i = Cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Changed", vbInformation)
                End If
            Else
                MsgBox("Failed to Changed", vbCritical, "Info")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub Search()
        If Form4.tbSearch.Text = "" Then
            MsgBox(" Harap isi kolom ", vbCritical, "Info")
            Return
        Else
            Try
                Form4.DataGridView1.Rows.Clear()
                Conn.Open()
                Cmd = New OleDbCommand("Select *from datalogin where `Nama` like '%" & Form4.tbSearch.Text & "%' or `Password` like '%" & Form4.tbSearch.Text & "%' ", Conn)
                RD = Cmd.ExecuteReader
                While RD.Read
                    Form4.DataGridView1.Rows.Add(RD.Item("Nama"), RD.Item("Password"))
                End While
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            Conn.Close()
        End If
    End Sub


    '~~~ Form6 ~~~
    Public Sub Save2()
        Try
            Conn.Open()
            If MsgBox("Are you sure to save the data ?", vbQuestion + vbYesNo) = vbYes Then
                Cmd = New OleDbCommand("Insert Into datatugas(`Nama`,`NIM`,`Kelas`,`Judul Tugas`,`Isi Tugas`,`Tanggal`)values(@Nama,@NIM,@Kelas,@JudulTugas,@IsiTugas,@Tanggal)", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Nama", Form6.t_Nama.Text)
                Cmd.Parameters.AddWithValue("@NIM", Form6.t_NIM.Text)
                Cmd.Parameters.AddWithValue("@Kelas", Form6.t_Kelas.Text)
                Cmd.Parameters.AddWithValue("@Judul Tugas", Form6.tbAssign.Text)
                Cmd.Parameters.AddWithValue("@Isi Tugas", Form6.RichTextBox2.Text)
                Cmd.Parameters.AddWithValue("@Tanggal", Form6.dtp1.Text)
                i = Cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Saved", vbInformation)
                End If
            Else
                MsgBox("Failed to save data", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub Clear2()
        Form6.t_Nama.Clear()
        Form6.t_NIM.Clear()
        Form6.t_Kelas.Clear()
        Form6.tbAssign.Clear()
        Form6.RichTextBox2.Clear()
        Form6.RichTextBox1.Clear()
    End Sub

    Public Sub Delete2()
        Try
            Conn.Open()
            If MsgBox("Are You Sure to Delete?", vbQuestion + vbYesNo) = vbYes Then
                Cmd = New OleDbCommand("Delete *from datatugas where Nama=@Nama ", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Nama", Form6.t_Nama.Text)
                i = Cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Deleted", vbInformation)
                End If
            Else
                MsgBox("Failed to Delete", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub DBview2()
        Form6.t_Nama.Text = Form6.DataGridView1.CurrentRow.Cells(0).Value
        Form6.t_NIM.Text = Form6.DataGridView1.CurrentRow.Cells(1).Value
        Form6.t_Kelas.Text = Form6.DataGridView1.CurrentRow.Cells(2).Value
        Form6.tbAssign.Text = Form6.DataGridView1.CurrentRow.Cells(3).Value
        Form6.RichTextBox1.Text = Form6.DataGridView1.CurrentRow.Cells(4).Value
        Form6.dtp1.Text = Form6.DataGridView1.CurrentRow.Cells(5).Value
    End Sub

    Public Sub Updated2()
        Try
            Conn.Open()
            If MsgBox("Are You Sure to Change Data?", vbQuestion + vbYesNo) = vbYes Then
                Cmd = New OleDbCommand("UPDATE datatugas SET `Nama`=@Nama,`NIM`=@NIM ,`Kelas`=@Kelas,`Judul Tugas`=@JudulTugas,`Isi Tugas`=@IsiTugas,`Tanggal`=@Tanggal where Nama=@Nama", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Nama", Form6.t_Nama.Text)
                Cmd.Parameters.AddWithValue("@NIM", Form6.t_NIM.Text)
                Cmd.Parameters.AddWithValue("@Kelas", Form6.t_Kelas.Text)
                Cmd.Parameters.AddWithValue("@Judul Tugas", Form6.tbAssign.Text)
                Cmd.Parameters.AddWithValue("@Isi Tugas", Form6.RichTextBox2.Text)
                Cmd.Parameters.AddWithValue("@Tanggal", Form6.dtp1.Text)
                i = Cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Changed", vbInformation)
                End If
            Else
                MsgBox("Failed to Changed", vbCritical, "Info")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    Public Sub Search2()
        Try
            Form6.DataGridView1.Rows.Clear()
            Conn.Open()
            Cmd = New OleDbCommand("Select *from datatugas where `Nama` like '%" & Form6.t_Search.Text & "%' or `Judul Tugas` like '%" & Form6.t_Search.Text & "%' or `Kelas` like '%" & Form6.t_Search.Text & "%' ", Conn)
            RD = Cmd.ExecuteReader
            While RD.Read
                Form6.DataGridView1.Rows.Add(RD.Item("Nama"), RD.Item("Kelas"), RD.Item("Judul Tugas"))
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub
    '~~~ Form6 (Search n Count) ~~~
    Public Sub TextBrubah()
        If Form6.RichTextBox1.Text.ToLower = " " Then
            Form6.TextBox1.Text = "0"
        Else
            Form6.TextBox1.Text = wordCount(Form6.RichTextBox1.Text.ToLower)
        End If
    End Sub

    Public Sub extFile()
        If (Form6.OpenFileDialog1.ShowDialog = DialogResult.OK) Then
            Form6.RichTextBox2.Text = My.Computer.FileSystem.ReadAllText(Form6.OpenFileDialog1.FileName)
        Else
            Return
        End If
    End Sub
    Public Sub kosongin()
        Dim ask As MsgBoxResult
        ask = MsgBox("Would You Like To Delete Text??", MsgBoxStyle.YesNo, " Caution ")
        If ask = MsgBoxResult.Yes Then
            MsgBox(" Deleted ", MessageBoxIcon.Warning, " Yes Indeed ")
            Form6.tbAssign.Text = ""
            Form6.tbFind.Text = ""
            Form6.RichTextBox1.Text = ""
            Form6.lblInfoFind.Text = ""
            Form6.lblMatches.Text = ""
            Form6.TextBox1.Text = 0
            Form6.RichTextBox2.Text = ""
        Else
            If ask = MsgBoxResult.No Then
                MsgBox(" Canceled ", MessageBoxIcon.Asterisk, " No Indeed ")
                Return
            End If
        End If
    End Sub
    Public Sub Temu()
        text1 = (Form6.RichTextBox1.Text)
        mysplit = Split(text1, Form6.tbFind.Text)
        count = mysplit.Length - 1
        Form6.lblMatches.Text = count
        Form6.lblInfoFind.Text = Form6.tbFind.Text

        'untuk HightLight
        iEnd = Form6.RichTextBox1.Text.LastIndexOf(Form6.tbFind.Text)
        Form6.RichTextBox1.SelectAll()
        Form6.RichTextBox1.SelectionBackColor = Color.White

        While index < iEnd
            Form6.RichTextBox1.Find(Form6.tbFind.Text, index, Form6.RichTextBox1.TextLength, RichTextBoxFinds.None)
            Form6.RichTextBox1.SelectionBackColor = Color.Yellow
            index = Form6.RichTextBox1.Text.IndexOf(Form6.tbFind.Text, index) + 1
        End While
    End Sub
    '~~~ Form 9 ~~~
    Public Sub Save3()
        Try
            Conn.Open()
            If MsgBox("Are you sure to save the data ?", vbQuestion + vbYesNo) = vbYes Then
                Cmd = New OleDbCommand("Insert Into dataabsen(`Nama`,`NIM`,`Kelas`,`Kehadiran`,`Tanggal`)values(@Nama,@NIM,@Kelas,@Kehadiran,@Tanggal)", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Nama", Form9.t_Nama.Text)
                Cmd.Parameters.AddWithValue("@NIM", Form9.t_NIM.Text)
                Cmd.Parameters.AddWithValue("@Kelas", Form9.t_Kelas.Text)
                Cmd.Parameters.AddWithValue("@Kehadiran", Form9.cb1.Text)
                Cmd.Parameters.AddWithValue("@Tanggal", Form9.dtp1.Text)
                i = Cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Saved", vbInformation)
                End If
            Else
                MsgBox("Failed to save data", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub
    Public Sub DBview3()
        Form9.t_Nama.Text = Form9.DataGridView1.CurrentRow.Cells(0).Value
        Form9.t_NIM.Text = Form9.DataGridView1.CurrentRow.Cells(1).Value
        Form9.t_Kelas.Text = Form9.DataGridView1.CurrentRow.Cells(2).Value
        Form9.cb1.Text = Form9.DataGridView1.CurrentRow.Cells(3).Value
        Form9.dtp1.Text = Form9.DataGridView1.CurrentRow.Cells(4).Value
    End Sub
    '~~~ DB SC ~~~
    Public Sub Simpen()
        Dim str_input As String
        str_input = (Form6.RichTextBox2.Text.ToLower)
        Form6.RichTextBox1.AppendText(str_input + " ")
    End Sub
    Public Function animasi()
        Select Case Form2.Label5.Text
            Case ""
                Form2.Label5.Text = "W"
            Case "W"
                Form2.Label5.Text = "WE"
            Case "WE"
                Form2.Label5.Text = "WEL"
            Case "WEL"
                Form2.Label5.Text = "WELC"
            Case "WELC"
                Form2.Label5.Text = "WELCO"
            Case "WELCO"
                Form2.Label5.Text = "WELCOM"
            Case "WELCOM"
                Form2.Label5.Text = "WELCOME"
            Case "WELCOME"
                Form2.Label5.Text = ""
        End Select

        Select Case Form5.Label5.Text
            Case ""
                Form5.Label5.Text = "W"
            Case "W"
                Form5.Label5.Text = "WE"
            Case "WE"
                Form5.Label5.Text = "WEL"
            Case "WEL"
                Form5.Label5.Text = "WELC"
            Case "WELC"
                Form5.Label5.Text = "WELCO"
            Case "WELCO"
                Form5.Label5.Text = "WELCOM"
            Case "WELCOM"
                Form5.Label5.Text = "WELCOME"
            Case "WELCOME"
                Form5.Label5.Text = ""
        End Select
    End Function
    Public Function animasi2()
        Select Case Form7.lblstory.Text
            Case ""
        Form7.lblstory.Text = "B"
        Case "B"
        Form7.lblstory.Text = "BA"
            Case "BA"
                Form7.lblstory.Text = "BAC"
        Case "BAC"
        Form7.lblstory.Text = "BACK"
            Case "BACK"
                Form7.lblstory.Text = "BACKGR"
        Case "BACKGR"
        Form7.lblstory.Text = "BACKGROU"
        Case "BACKGROU"
        Form7.lblstory.Text = "BACKGROUND"
        Case "BACKGROUND"
                Form7.lblstory.Text = ""
        End Select
    End Function

    'Form 8 (Dosen)
    Public Sub Masukkan()
        Try
            Conn.Open()
            If MsgBox("Are you sure to save the data ?", vbQuestion + vbYesNo) = vbYes Then
                Cmd = New OleDbCommand("Insert Into datanilai(`Nama`,`Matkul`,`Nilai`,`Tanggal`)values(@Nama,@Matkul,@Nilai,@Tanggal)", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Nama", Form8.TextBox1.Text)
                Cmd.Parameters.AddWithValue("@Matkul", Form8.ComboBox1.Text)
                Cmd.Parameters.AddWithValue("@Nilai", Form8.TextBox2.Text)
                Cmd.Parameters.AddWithValue("@Tanggal", Form8.DateTimePicker1.Value)
                i = Cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Saved", vbInformation)
                    ket = (Form8.TextBox1.Text & vbCrLf & " mendapat nilai " & vbCrLf & Form8.TextBox2.Text)
                    Form8.ListBox1.Items.Add(Format(Now, "dd/MM/yy") & vbCrLf & Format(Now, " hh:mm:ss tt ") & vbCrLf & ket)
                Else
                    MsgBox("Pastikan mengisi kolom", vbInformation)
                End If
            Else
                MsgBox("Failed to save data", vbCritical)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub
    Public Sub DBview4()
        Form8.TextBox1.Text = Form8.DataGridView1.CurrentRow.Cells(0).Value
        Form8.ComboBox1.Text = Form8.DataGridView1.CurrentRow.Cells(1).Value
        Form8.TextBox2.Text = Form8.DataGridView1.CurrentRow.Cells(2).Value
        Form8.DateTimePicker1.Value = Form8.DataGridView1.CurrentRow.Cells(3).Value
    End Sub

    Public Sub Ganti()
        Try
            Conn.Open()
            If MsgBox("Are You Sure to Change Data?", vbQuestion + vbYesNo) = vbYes Then
                Cmd = New OleDbCommand("UPDATE datanilai SET `Nama`=@Nama,`Matkul`=@Matkul,`Nilai`=@Nilai, `Tanggal`=@Tanggal`
                                        where Nama=@Nama ", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Nama", Form8.TextBox1.Text)
                Cmd.Parameters.AddWithValue("@Matkul", Form8.ComboBox1.Text)
                Cmd.Parameters.AddWithValue("@Nilai", Form8.TextBox2.Text)
                Cmd.Parameters.AddWithValue("@Tanggal", Form8.DateTimePicker1.Value)
                i = Cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Changed", vbInformation)
                    ket = (" Data " & vbCrLf & Form8.TextBox1.Text & vbCrLf & " telah diubah")
                    Form8.ListBox1.Items.Add(Format(Now, "dd/MM/yy") & vbCrLf & Format(Now, " hh:mm:ss tt") & vbCrLf & ket)
                End If
            Else
                MsgBox("Failed to Changed", vbCritical, "Info")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()
    End Sub

    'form 11
    Public Sub Ubah()
        Try
            Conn.Open()
            If MsgBox("Are You Sure to Change Data?", vbQuestion + vbYesNo) = vbYes Then
                Cmd = New OleDbCommand("UPDATE datalogin SET `Kehadiran`=@Kehadiran where Nama=@Nama ", Conn)
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@Kehadiran", Form11.cb1.Text)
                i = Cmd.ExecuteNonQuery
                If i > 0 Then
                    MsgBox("Changed", vbInformation)
                End If
            Else
                MsgBox("Failed to Changed", vbCritical, "Info")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Conn.Close()

    End Sub
    Public Sub DBview5()
        Form11.t_Nama.Text = Form9.DataGridView1.CurrentRow.Cells(0).Value
        Form11.t_NIM.Text = Form9.DataGridView1.CurrentRow.Cells(1).Value
        Form11.t_Kelas.Text = Form9.DataGridView1.CurrentRow.Cells(2).Value
        Form11.cb1.Text = Form9.DataGridView1.CurrentRow.Cells(3).Value
        Form11.TextBox1.Text = Form9.DataGridView1.CurrentRow.Cells(4).Value
    End Sub
End Module
