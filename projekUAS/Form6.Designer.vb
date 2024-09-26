<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bSearch = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t_Kelas = New System.Windows.Forms.TextBox()
        Me.l_Kelas = New System.Windows.Forms.Label()
        Me.t_NIM = New System.Windows.Forms.TextBox()
        Me.l_NIM = New System.Windows.Forms.Label()
        Me.t_Nama = New System.Windows.Forms.TextBox()
        Me.l_Nama = New System.Windows.Forms.Label()
        Me.t_Search = New System.Windows.Forms.TextBox()
        Me.l_Search = New System.Windows.Forms.Label()
        Me.pOff = New System.Windows.Forms.PictureBox()
        Me.pOn = New System.Windows.Forms.PictureBox()
        Me.btn_Upd = New System.Windows.Forms.Button()
        Me.btn_Del = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblIsiTugas = New System.Windows.Forms.Label()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.bAddExt = New System.Windows.Forms.Button()
        Me.bClear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblInfoFind = New System.Windows.Forms.Label()
        Me.lblMatches = New System.Windows.Forms.Label()
        Me.bFind = New System.Windows.Forms.Button()
        Me.tbFind = New System.Windows.Forms.TextBox()
        Me.tbAssign = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblFind = New System.Windows.Forms.Label()
        Me.lblHuruf = New System.Windows.Forms.Label()
        Me.lblBanyakHuruf = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.pOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pOn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bSearch)
        Me.Panel1.Controls.Add(Me.CheckBox1)
        Me.Panel1.Controls.Add(Me.RichTextBox2)
        Me.Panel1.Controls.Add(Me.dtp1)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.t_Kelas)
        Me.Panel1.Controls.Add(Me.l_Kelas)
        Me.Panel1.Controls.Add(Me.t_NIM)
        Me.Panel1.Controls.Add(Me.l_NIM)
        Me.Panel1.Controls.Add(Me.t_Nama)
        Me.Panel1.Controls.Add(Me.l_Nama)
        Me.Panel1.Controls.Add(Me.t_Search)
        Me.Panel1.Controls.Add(Me.l_Search)
        Me.Panel1.Controls.Add(Me.pOff)
        Me.Panel1.Controls.Add(Me.pOn)
        Me.Panel1.Controls.Add(Me.btn_Upd)
        Me.Panel1.Controls.Add(Me.btn_Del)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.lblIsiTugas)
        Me.Panel1.Controls.Add(Me.btnSubmit)
        Me.Panel1.Controls.Add(Me.bAddExt)
        Me.Panel1.Controls.Add(Me.bClear)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.bFind)
        Me.Panel1.Controls.Add(Me.tbFind)
        Me.Panel1.Controls.Add(Me.tbAssign)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Controls.Add(Me.lblFind)
        Me.Panel1.Controls.Add(Me.lblHuruf)
        Me.Panel1.Controls.Add(Me.lblBanyakHuruf)
        Me.Panel1.Controls.Add(Me.RichTextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.ForeColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1125, 684)
        Me.Panel1.TabIndex = 0
        '
        'bSearch
        '
        Me.bSearch.BackColor = System.Drawing.Color.White
        Me.bSearch.FlatAppearance.BorderSize = 0
        Me.bSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSearch.ForeColor = System.Drawing.Color.Black
        Me.bSearch.Location = New System.Drawing.Point(870, 613)
        Me.bSearch.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bSearch.Name = "bSearch"
        Me.bSearch.Size = New System.Drawing.Size(59, 31)
        Me.bSearch.TabIndex = 96
        Me.bSearch.Text = "Search"
        Me.bSearch.UseVisualStyleBackColor = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(808, 105)
        Me.CheckBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(132, 24)
        Me.CheckBox1.TabIndex = 95
        Me.CheckBox1.Text = "Tampilkan data"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'RichTextBox2
        '
        Me.RichTextBox2.Location = New System.Drawing.Point(14, 151)
        Me.RichTextBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(508, 205)
        Me.RichTextBox2.TabIndex = 94
        Me.RichTextBox2.Text = ""
        '
        'dtp1
        '
        Me.dtp1.CalendarMonthBackground = System.Drawing.Color.White
        Me.dtp1.CalendarTrailingForeColor = System.Drawing.Color.White
        Me.dtp1.CustomFormat = "dd-MM-yyyy"
        Me.dtp1.Location = New System.Drawing.Point(614, 99)
        Me.dtp1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(157, 27)
        Me.dtp1.TabIndex = 93
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(560, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 92
        Me.Label4.Text = "Tanggal"
        '
        't_Kelas
        '
        Me.t_Kelas.Location = New System.Drawing.Point(614, 59)
        Me.t_Kelas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t_Kelas.Name = "t_Kelas"
        Me.t_Kelas.Size = New System.Drawing.Size(157, 27)
        Me.t_Kelas.TabIndex = 91
        '
        'l_Kelas
        '
        Me.l_Kelas.AutoSize = True
        Me.l_Kelas.ForeColor = System.Drawing.Color.White
        Me.l_Kelas.Location = New System.Drawing.Point(568, 63)
        Me.l_Kelas.Name = "l_Kelas"
        Me.l_Kelas.Size = New System.Drawing.Size(44, 20)
        Me.l_Kelas.TabIndex = 90
        Me.l_Kelas.Text = "Kelas"
        '
        't_NIM
        '
        Me.t_NIM.Location = New System.Drawing.Point(401, 95)
        Me.t_NIM.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t_NIM.Name = "t_NIM"
        Me.t_NIM.Size = New System.Drawing.Size(151, 27)
        Me.t_NIM.TabIndex = 89
        '
        'l_NIM
        '
        Me.l_NIM.AutoSize = True
        Me.l_NIM.ForeColor = System.Drawing.Color.White
        Me.l_NIM.Location = New System.Drawing.Point(360, 99)
        Me.l_NIM.Name = "l_NIM"
        Me.l_NIM.Size = New System.Drawing.Size(37, 20)
        Me.l_NIM.TabIndex = 88
        Me.l_NIM.Text = "NIM"
        '
        't_Nama
        '
        Me.t_Nama.Location = New System.Drawing.Point(401, 56)
        Me.t_Nama.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t_Nama.Name = "t_Nama"
        Me.t_Nama.Size = New System.Drawing.Size(151, 27)
        Me.t_Nama.TabIndex = 87
        '
        'l_Nama
        '
        Me.l_Nama.AutoSize = True
        Me.l_Nama.ForeColor = System.Drawing.Color.White
        Me.l_Nama.Location = New System.Drawing.Point(350, 60)
        Me.l_Nama.Name = "l_Nama"
        Me.l_Nama.Size = New System.Drawing.Size(49, 20)
        Me.l_Nama.TabIndex = 86
        Me.l_Nama.Text = "Nama"
        '
        't_Search
        '
        Me.t_Search.Location = New System.Drawing.Point(936, 613)
        Me.t_Search.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.t_Search.Name = "t_Search"
        Me.t_Search.Size = New System.Drawing.Size(174, 27)
        Me.t_Search.TabIndex = 83
        '
        'l_Search
        '
        Me.l_Search.AutoSize = True
        Me.l_Search.ForeColor = System.Drawing.Color.White
        Me.l_Search.Location = New System.Drawing.Point(866, 589)
        Me.l_Search.Name = "l_Search"
        Me.l_Search.Size = New System.Drawing.Size(255, 20)
        Me.l_Search.TabIndex = 82
        Me.l_Search.Text = "Cari berdasarkan (Nama/Kelas/Judul)"
        '
        'pOff
        '
        Me.pOff.Image = CType(resources.GetObject("pOff.Image"), System.Drawing.Image)
        Me.pOff.Location = New System.Drawing.Point(1061, 9)
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
        Me.pOn.Location = New System.Drawing.Point(1061, 11)
        Me.pOn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.pOn.Name = "pOn"
        Me.pOn.Size = New System.Drawing.Size(29, 36)
        Me.pOn.TabIndex = 80
        Me.pOn.TabStop = False
        Me.pOn.Visible = False
        '
        'btn_Upd
        '
        Me.btn_Upd.BackColor = System.Drawing.Color.White
        Me.btn_Upd.FlatAppearance.BorderSize = 0
        Me.btn_Upd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_Upd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Upd.ForeColor = System.Drawing.Color.Black
        Me.btn_Upd.Location = New System.Drawing.Point(677, 640)
        Me.btn_Upd.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Upd.Name = "btn_Upd"
        Me.btn_Upd.Size = New System.Drawing.Size(183, 28)
        Me.btn_Upd.TabIndex = 78
        Me.btn_Upd.Text = "Update Data"
        Me.btn_Upd.UseVisualStyleBackColor = False
        '
        'btn_Del
        '
        Me.btn_Del.BackColor = System.Drawing.Color.White
        Me.btn_Del.FlatAppearance.BorderSize = 0
        Me.btn_Del.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btn_Del.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Del.ForeColor = System.Drawing.Color.Black
        Me.btn_Del.Location = New System.Drawing.Point(677, 596)
        Me.btn_Del.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_Del.Name = "btn_Del"
        Me.btn_Del.Size = New System.Drawing.Size(183, 31)
        Me.btn_Del.TabIndex = 77
        Me.btn_Del.Text = "Delete Data"
        Me.btn_Del.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.DataGridView1.Location = New System.Drawing.Point(529, 151)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(582, 423)
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
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column4.HeaderText = "Kelas"
        Me.Column4.MinimumWidth = 6
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 73
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
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column6.HeaderText = "Isi Tugas"
        Me.Column6.MinimumWidth = 6
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 95
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
        Me.Label3.Location = New System.Drawing.Point(990, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 25)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "Status :"
        '
        'lblIsiTugas
        '
        Me.lblIsiTugas.AutoSize = True
        Me.lblIsiTugas.ForeColor = System.Drawing.Color.White
        Me.lblIsiTugas.Location = New System.Drawing.Point(14, 127)
        Me.lblIsiTugas.Name = "lblIsiTugas"
        Me.lblIsiTugas.Size = New System.Drawing.Size(219, 20)
        Me.lblIsiTugas.TabIndex = 70
        Me.lblIsiTugas.Text = "Write Here or  Add External File"
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.White
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.ForeColor = System.Drawing.Color.Black
        Me.btnSubmit.Location = New System.Drawing.Point(547, 587)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(122, 87)
        Me.btnSubmit.TabIndex = 69
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'bAddExt
        '
        Me.bAddExt.BackColor = System.Drawing.Color.White
        Me.bAddExt.FlatAppearance.BorderSize = 0
        Me.bAddExt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bAddExt.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAddExt.ForeColor = System.Drawing.Color.Black
        Me.bAddExt.Location = New System.Drawing.Point(357, 637)
        Me.bAddExt.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bAddExt.Name = "bAddExt"
        Me.bAddExt.Size = New System.Drawing.Size(184, 31)
        Me.bAddExt.TabIndex = 68
        Me.bAddExt.Text = "Add External Files"
        Me.bAddExt.UseVisualStyleBackColor = False
        '
        'bClear
        '
        Me.bClear.BackColor = System.Drawing.Color.White
        Me.bClear.FlatAppearance.BorderSize = 0
        Me.bClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bClear.ForeColor = System.Drawing.Color.Black
        Me.bClear.Location = New System.Drawing.Point(357, 596)
        Me.bClear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bClear.Name = "bClear"
        Me.bClear.Size = New System.Drawing.Size(184, 31)
        Me.bClear.TabIndex = 67
        Me.bClear.Text = "Clear Submission"
        Me.bClear.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblInfoFind)
        Me.GroupBox2.Controls.Add(Me.lblMatches)
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(45, 581)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(183, 91)
        Me.GroupBox2.TabIndex = 66
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 20)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Find Words Of :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 20)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Matches  :"
        '
        'lblInfoFind
        '
        Me.lblInfoFind.AutoSize = True
        Me.lblInfoFind.Location = New System.Drawing.Point(127, 25)
        Me.lblInfoFind.Name = "lblInfoFind"
        Me.lblInfoFind.Size = New System.Drawing.Size(0, 20)
        Me.lblInfoFind.TabIndex = 16
        '
        'lblMatches
        '
        Me.lblMatches.AutoSize = True
        Me.lblMatches.Location = New System.Drawing.Point(96, 61)
        Me.lblMatches.Name = "lblMatches"
        Me.lblMatches.Size = New System.Drawing.Size(0, 20)
        Me.lblMatches.TabIndex = 15
        '
        'bFind
        '
        Me.bFind.BackColor = System.Drawing.Color.White
        Me.bFind.FlatAppearance.BorderSize = 0
        Me.bFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bFind.ForeColor = System.Drawing.Color.Black
        Me.bFind.Location = New System.Drawing.Point(264, 596)
        Me.bFind.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bFind.Name = "bFind"
        Me.bFind.Size = New System.Drawing.Size(86, 72)
        Me.bFind.TabIndex = 65
        Me.bFind.Text = "Find"
        Me.bFind.UseVisualStyleBackColor = False
        '
        'tbFind
        '
        Me.tbFind.Location = New System.Drawing.Point(168, 91)
        Me.tbFind.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbFind.Name = "tbFind"
        Me.tbFind.Size = New System.Drawing.Size(161, 27)
        Me.tbFind.TabIndex = 64
        '
        'tbAssign
        '
        Me.tbAssign.Location = New System.Drawing.Point(168, 52)
        Me.tbAssign.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.tbAssign.Name = "tbAssign"
        Me.tbAssign.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.tbAssign.Size = New System.Drawing.Size(161, 27)
        Me.tbAssign.TabIndex = 63
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(168, 16)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(37, 27)
        Me.TextBox1.TabIndex = 62
        Me.TextBox1.Text = "0"
        '
        'lblFind
        '
        Me.lblFind.AutoSize = True
        Me.lblFind.ForeColor = System.Drawing.Color.White
        Me.lblFind.Location = New System.Drawing.Point(14, 95)
        Me.lblFind.Name = "lblFind"
        Me.lblFind.Size = New System.Drawing.Size(77, 20)
        Me.lblFind.TabIndex = 61
        Me.lblFind.Text = "Find Word"
        '
        'lblHuruf
        '
        Me.lblHuruf.AutoSize = True
        Me.lblHuruf.ForeColor = System.Drawing.Color.White
        Me.lblHuruf.Location = New System.Drawing.Point(14, 63)
        Me.lblHuruf.Name = "lblHuruf"
        Me.lblHuruf.Size = New System.Drawing.Size(86, 20)
        Me.lblHuruf.TabIndex = 60
        Me.lblHuruf.Text = "Assignment"
        '
        'lblBanyakHuruf
        '
        Me.lblBanyakHuruf.AutoSize = True
        Me.lblBanyakHuruf.ForeColor = System.Drawing.Color.White
        Me.lblBanyakHuruf.Location = New System.Drawing.Point(14, 20)
        Me.lblBanyakHuruf.Name = "lblBanyakHuruf"
        Me.lblBanyakHuruf.Size = New System.Drawing.Size(151, 20)
        Me.lblBanyakHuruf.TabIndex = 59
        Me.lblBanyakHuruf.Text = "Number of Sentences"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(14, 365)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(508, 207)
        Me.RichTextBox1.TabIndex = 57
        Me.RichTextBox1.Text = ""
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1125, 684)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pOn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents lblIsiTugas As Label
    Friend WithEvents btnSubmit As Button
    Friend WithEvents bAddExt As Button
    Friend WithEvents bClear As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblInfoFind As Label
    Friend WithEvents lblMatches As Label
    Friend WithEvents bFind As Button
    Friend WithEvents tbFind As TextBox
    Friend WithEvents tbAssign As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblFind As Label
    Friend WithEvents lblHuruf As Label
    Friend WithEvents lblBanyakHuruf As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btn_Upd As Button
    Friend WithEvents btn_Del As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents dtp1 As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents t_Kelas As TextBox
    Friend WithEvents l_Kelas As Label
    Friend WithEvents t_NIM As TextBox
    Friend WithEvents l_NIM As Label
    Friend WithEvents t_Nama As TextBox
    Friend WithEvents l_Nama As Label
    Friend WithEvents t_Search As TextBox
    Friend WithEvents l_Search As Label
    Friend WithEvents pOff As PictureBox
    Friend WithEvents pOn As PictureBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents bSearch As Button
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
End Class
