<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bLogOut = New System.Windows.Forms.Button()
        Me.bAbout = New System.Windows.Forms.Button()
        Me.bAssignment = New System.Windows.Forms.Button()
        Me.bAttend = New System.Windows.Forms.Button()
        Me.bHome = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblwaktu = New System.Windows.Forms.Label()
        Me.lbltanggal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bLogOut)
        Me.Panel1.Controls.Add(Me.bAbout)
        Me.Panel1.Controls.Add(Me.bAssignment)
        Me.Panel1.Controls.Add(Me.bAttend)
        Me.Panel1.Controls.Add(Me.bHome)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(200, 561)
        Me.Panel1.TabIndex = 0
        '
        'bLogOut
        '
        Me.bLogOut.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.bLogOut.FlatAppearance.BorderSize = 0
        Me.bLogOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLogOut.ForeColor = System.Drawing.Color.Silver
        Me.bLogOut.Image = CType(resources.GetObject("bLogOut.Image"), System.Drawing.Image)
        Me.bLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLogOut.Location = New System.Drawing.Point(0, 526)
        Me.bLogOut.Name = "bLogOut"
        Me.bLogOut.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.bLogOut.Size = New System.Drawing.Size(200, 35)
        Me.bLogOut.TabIndex = 6
        Me.bLogOut.Text = "LogOut"
        Me.bLogOut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bLogOut.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bLogOut.UseVisualStyleBackColor = True
        '
        'bAbout
        '
        Me.bAbout.Dock = System.Windows.Forms.DockStyle.Top
        Me.bAbout.FlatAppearance.BorderSize = 0
        Me.bAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAbout.ForeColor = System.Drawing.Color.Silver
        Me.bAbout.Image = CType(resources.GetObject("bAbout.Image"), System.Drawing.Image)
        Me.bAbout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAbout.Location = New System.Drawing.Point(0, 313)
        Me.bAbout.Name = "bAbout"
        Me.bAbout.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.bAbout.Size = New System.Drawing.Size(200, 55)
        Me.bAbout.TabIndex = 5
        Me.bAbout.Text = "AboutUs"
        Me.bAbout.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAbout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAbout.UseVisualStyleBackColor = True
        '
        'bAssignment
        '
        Me.bAssignment.Dock = System.Windows.Forms.DockStyle.Top
        Me.bAssignment.FlatAppearance.BorderSize = 0
        Me.bAssignment.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bAssignment.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAssignment.ForeColor = System.Drawing.Color.Silver
        Me.bAssignment.Image = CType(resources.GetObject("bAssignment.Image"), System.Drawing.Image)
        Me.bAssignment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAssignment.Location = New System.Drawing.Point(0, 258)
        Me.bAssignment.Name = "bAssignment"
        Me.bAssignment.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.bAssignment.Size = New System.Drawing.Size(200, 55)
        Me.bAssignment.TabIndex = 4
        Me.bAssignment.Text = "Assignment"
        Me.bAssignment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAssignment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAssignment.UseVisualStyleBackColor = True
        '
        'bAttend
        '
        Me.bAttend.Dock = System.Windows.Forms.DockStyle.Top
        Me.bAttend.FlatAppearance.BorderSize = 0
        Me.bAttend.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bAttend.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bAttend.ForeColor = System.Drawing.Color.Silver
        Me.bAttend.Image = CType(resources.GetObject("bAttend.Image"), System.Drawing.Image)
        Me.bAttend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAttend.Location = New System.Drawing.Point(0, 203)
        Me.bAttend.Name = "bAttend"
        Me.bAttend.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.bAttend.Size = New System.Drawing.Size(200, 55)
        Me.bAttend.TabIndex = 3
        Me.bAttend.Text = "Attendance"
        Me.bAttend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bAttend.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bAttend.UseVisualStyleBackColor = True
        '
        'bHome
        '
        Me.bHome.Dock = System.Windows.Forms.DockStyle.Top
        Me.bHome.FlatAppearance.BorderSize = 0
        Me.bHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bHome.ForeColor = System.Drawing.Color.Silver
        Me.bHome.Image = CType(resources.GetObject("bHome.Image"), System.Drawing.Image)
        Me.bHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bHome.Location = New System.Drawing.Point(0, 148)
        Me.bHome.Name = "bHome"
        Me.bHome.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.bHome.Size = New System.Drawing.Size(200, 55)
        Me.bHome.TabIndex = 0
        Me.bHome.Text = "Home"
        Me.bHome.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.bHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.bHome.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.PictureBox1)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 48)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 100)
        Me.Panel4.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(56, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 88)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 48)
        Me.Panel2.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(22, 1)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 45)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Log"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(73, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(157, 37)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Mahasiswa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(73, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 33)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "As"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(200, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(984, 48)
        Me.Panel3.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(934, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(50, 48)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(355, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Form Pembelajaran"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(466, 116)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(128, 135)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(915, 450)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(60, 51)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 8
        Me.PictureBox2.TabStop = False
        '
        'lblwaktu
        '
        Me.lblwaktu.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblwaktu.AutoSize = True
        Me.lblwaktu.Font = New System.Drawing.Font("Stencil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lblwaktu.ForeColor = System.Drawing.Color.White
        Me.lblwaktu.Location = New System.Drawing.Point(355, 280)
        Me.lblwaktu.Name = "lblwaktu"
        Me.lblwaktu.Size = New System.Drawing.Size(322, 95)
        Me.lblwaktu.TabIndex = 9
        Me.lblwaktu.Text = "Waktu"
        '
        'lbltanggal
        '
        Me.lbltanggal.AutoSize = True
        Me.lbltanggal.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.lbltanggal.ForeColor = System.Drawing.Color.White
        Me.lbltanggal.Location = New System.Drawing.Point(493, 356)
        Me.lbltanggal.Name = "lbltanggal"
        Me.lbltanggal.Size = New System.Drawing.Size(101, 24)
        Me.lbltanggal.TabIndex = 10
        Me.lbltanggal.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Stencil", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(355, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(294, 56)
        Me.Label5.TabIndex = 12
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Button2)
        Me.Panel5.Controls.Add(Me.Label5)
        Me.Panel5.Controls.Add(Me.lbltanggal)
        Me.Panel5.Controls.Add(Me.lblwaktu)
        Me.Panel5.Controls.Add(Me.PictureBox2)
        Me.Panel5.Controls.Add(Me.PictureBox4)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(200, 48)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(984, 513)
        Me.Panel5.TabIndex = 2
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(815, 439)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 62)
        Me.Button2.TabIndex = 17
        Me.Button2.Text = "PNJ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 200
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 561)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents bHome As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents bLogOut As Button
    Friend WithEvents bAbout As Button
    Friend WithEvents bAssignment As Button
    Friend WithEvents bAttend As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblwaktu As Label
    Friend WithEvents lbltanggal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Button2 As Button
End Class
