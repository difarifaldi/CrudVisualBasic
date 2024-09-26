<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form10
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form10))
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tbAssign = New System.Windows.Forms.TextBox()
        Me.lblHuruf = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.t_Kelas = New System.Windows.Forms.TextBox()
        Me.l_Kelas = New System.Windows.Forms.Label()
        Me.t_Nama = New System.Windows.Forms.TextBox()
        Me.l_Nama = New System.Windows.Forms.Label()
        Me.pOff = New System.Windows.Forms.PictureBox()
        Me.pOn = New System.Windows.Forms.PictureBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.l_NIM = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_NIM = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Column5
        '
        Me.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column5.HeaderText = "Judul Tugas"
        Me.Column5.MinimumWidth = 6
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 115
        '
        'Column7
        '
        Me.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column7.HeaderText = "Tanggal"
        Me.Column7.MinimumWidth = 6
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 90
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(21, 141)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Status :"
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Isi Tugas"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 95
        '
        'tbAssign
        '
        Me.tbAssign.Location = New System.Drawing.Point(143, 20)
        Me.tbAssign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbAssign.Name = "tbAssign"
        Me.tbAssign.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbAssign.Size = New System.Drawing.Size(161, 27)
        Me.tbAssign.TabIndex = 63
        '
        'lblHuruf
        '
        Me.lblHuruf.AutoSize = True
        Me.lblHuruf.ForeColor = System.Drawing.Color.White
        Me.lblHuruf.Location = New System.Drawing.Point(35, 24)
        Me.lblHuruf.Name = "lblHuruf"
        Me.lblHuruf.Size = New System.Drawing.Size(86, 20)
        Me.lblHuruf.TabIndex = 60
        Me.lblHuruf.Text = "Assignment"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Kelas"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 73
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.t_Kelas)
        Me.Panel1.Controls.Add(Me.l_Kelas)
        Me.Panel1.Controls.Add(Me.t_Nama)
        Me.Panel1.Controls.Add(Me.l_Nama)
        Me.Panel1.Controls.Add(Me.pOff)
        Me.Panel1.Controls.Add(Me.pOn)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.tbAssign)
        Me.Panel1.Controls.Add(Me.lblHuruf)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 526)
        Me.Panel1.TabIndex = 1
        '
        't_Kelas
        '
        Me.t_Kelas.Location = New System.Drawing.Point(768, 21)
        Me.t_Kelas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t_Kelas.Name = "t_Kelas"
        Me.t_Kelas.Size = New System.Drawing.Size(157, 27)
        Me.t_Kelas.TabIndex = 91
        '
        'l_Kelas
        '
        Me.l_Kelas.AutoSize = True
        Me.l_Kelas.ForeColor = System.Drawing.Color.White
        Me.l_Kelas.Location = New System.Drawing.Point(722, 25)
        Me.l_Kelas.Name = "l_Kelas"
        Me.l_Kelas.Size = New System.Drawing.Size(44, 20)
        Me.l_Kelas.TabIndex = 90
        Me.l_Kelas.Text = "Kelas"
        '
        't_Nama
        '
        Me.t_Nama.Location = New System.Drawing.Point(470, 20)
        Me.t_Nama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t_Nama.Name = "t_Nama"
        Me.t_Nama.Size = New System.Drawing.Size(157, 27)
        Me.t_Nama.TabIndex = 87
        '
        'l_Nama
        '
        Me.l_Nama.AutoSize = True
        Me.l_Nama.ForeColor = System.Drawing.Color.White
        Me.l_Nama.Location = New System.Drawing.Point(419, 24)
        Me.l_Nama.Name = "l_Nama"
        Me.l_Nama.Size = New System.Drawing.Size(49, 20)
        Me.l_Nama.TabIndex = 86
        Me.l_Nama.Text = "Nama"
        '
        'pOff
        '
        Me.pOff.Image = CType(resources.GetObject("pOff.Image"), System.Drawing.Image)
        Me.pOff.Location = New System.Drawing.Point(92, 134)
        Me.pOff.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pOff.Name = "pOff"
        Me.pOff.Size = New System.Drawing.Size(29, 33)
        Me.pOff.TabIndex = 81
        Me.pOff.TabStop = False
        Me.pOff.Visible = False
        '
        'pOn
        '
        Me.pOn.Image = CType(resources.GetObject("pOn.Image"), System.Drawing.Image)
        Me.pOn.Location = New System.Drawing.Point(92, 136)
        Me.pOn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pOn.Name = "pOn"
        Me.pOn.Size = New System.Drawing.Size(29, 36)
        Me.pOn.TabIndex = 80
        Me.pOn.TabStop = False
        Me.pOn.Visible = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(183, 149)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(637, 335)
        Me.DataGridView1.TabIndex = 73
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nama"
        Me.Column1.MinimumWidth = 6
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 125
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column3.HeaderText = "NIM"
        Me.Column3.MinimumWidth = 6
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 66
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.dtp1)
        Me.GroupBox1.Controls.Add(Me.l_NIM)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.t_NIM)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(959, 124)
        Me.GroupBox1.TabIndex = 95
        Me.GroupBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(756, 65)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 94
        Me.Button1.Text = "Update"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dtp1
        '
        Me.dtp1.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp1.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtp1.CustomFormat = "dd-MM-yyyy"
        Me.dtp1.Location = New System.Drawing.Point(462, 65)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(157, 27)
        Me.dtp1.TabIndex = 93
        '
        'l_NIM
        '
        Me.l_NIM.AutoSize = True
        Me.l_NIM.ForeColor = System.Drawing.Color.White
        Me.l_NIM.Location = New System.Drawing.Point(23, 69)
        Me.l_NIM.Name = "l_NIM"
        Me.l_NIM.Size = New System.Drawing.Size(37, 20)
        Me.l_NIM.TabIndex = 88
        Me.l_NIM.Text = "NIM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(395, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Tanggal"
        '
        't_NIM
        '
        Me.t_NIM.Location = New System.Drawing.Point(131, 63)
        Me.t_NIM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t_NIM.Name = "t_NIM"
        Me.t_NIM.Size = New System.Drawing.Size(161, 27)
        Me.t_NIM.TabIndex = 89
        '
        'Form10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(983, 526)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form10"
        Me.Text = "Form10"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents tbAssign As TextBox
    Friend WithEvents lblHuruf As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Panel1 As Panel
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents t_Kelas As TextBox
    Friend WithEvents l_Kelas As Label
    Friend WithEvents t_NIM As TextBox
    Friend WithEvents l_NIM As Label
    Friend WithEvents t_Nama As TextBox
    Friend WithEvents l_Nama As Label
    Friend WithEvents pOff As PictureBox
    Friend WithEvents pOn As PictureBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
End Class
