<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.mtbPin = New System.Windows.Forms.MaskedTextBox()
        Me.tbUser2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbPass2 = New System.Windows.Forms.TextBox()
        Me.bEnter = New System.Windows.Forms.Button()
        Me.bSave = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.bUpdate = New System.Windows.Forms.Button()
        Me.bDelete = New System.Windows.Forms.Button()
        Me.mtbSC = New System.Windows.Forms.MaskedTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bBack = New System.Windows.Forms.Button()
        Me.pOff = New System.Windows.Forms.PictureBox()
        Me.pOn = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.bExit = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(91, 240)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign In"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Security Code:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "PIN:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(83, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(129, 32)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Validation"
        '
        'mtbPin
        '
        Me.mtbPin.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbPin.Location = New System.Drawing.Point(22, 201)
        Me.mtbPin.Mask = "0-0-0-0-0"
        Me.mtbPin.Name = "mtbPin"
        Me.mtbPin.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mtbPin.Size = New System.Drawing.Size(166, 16)
        Me.mtbPin.TabIndex = 2
        Me.mtbPin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbUser2
        '
        Me.tbUser2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUser2.Enabled = False
        Me.tbUser2.Location = New System.Drawing.Point(91, 310)
        Me.tbUser2.Name = "tbUser2"
        Me.tbUser2.Size = New System.Drawing.Size(121, 16)
        Me.tbUser2.TabIndex = 8
        Me.tbUser2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Password:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 313)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Username:"
        '
        'tbPass2
        '
        Me.tbPass2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPass2.Enabled = False
        Me.tbPass2.Location = New System.Drawing.Point(91, 345)
        Me.tbPass2.Name = "tbPass2"
        Me.tbPass2.Size = New System.Drawing.Size(121, 16)
        Me.tbPass2.TabIndex = 9
        Me.tbPass2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bEnter
        '
        Me.bEnter.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.bEnter.FlatAppearance.BorderSize = 0
        Me.bEnter.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bEnter.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bEnter.ForeColor = System.Drawing.Color.White
        Me.bEnter.Location = New System.Drawing.Point(209, 172)
        Me.bEnter.Name = "bEnter"
        Me.bEnter.Size = New System.Drawing.Size(59, 37)
        Me.bEnter.TabIndex = 10
        Me.bEnter.Text = "Enter"
        Me.bEnter.UseVisualStyleBackColor = False
        '
        'bSave
        '
        Me.bSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.bSave.Enabled = False
        Me.bSave.FlatAppearance.BorderSize = 0
        Me.bSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSave.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bSave.ForeColor = System.Drawing.Color.White
        Me.bSave.Location = New System.Drawing.Point(23, 383)
        Me.bSave.Name = "bSave"
        Me.bSave.Size = New System.Drawing.Size(75, 37)
        Me.bSave.TabIndex = 11
        Me.bSave.Text = "Save"
        Me.bSave.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3})
        Me.DataGridView1.Enabled = False
        Me.DataGridView1.Location = New System.Drawing.Point(3, 435)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(274, 150)
        Me.DataGridView1.TabIndex = 12
        '
        'bUpdate
        '
        Me.bUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.bUpdate.Enabled = False
        Me.bUpdate.FlatAppearance.BorderSize = 0
        Me.bUpdate.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bUpdate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bUpdate.ForeColor = System.Drawing.Color.White
        Me.bUpdate.Location = New System.Drawing.Point(104, 383)
        Me.bUpdate.Name = "bUpdate"
        Me.bUpdate.Size = New System.Drawing.Size(75, 37)
        Me.bUpdate.TabIndex = 13
        Me.bUpdate.Text = "Update"
        Me.bUpdate.UseVisualStyleBackColor = False
        '
        'bDelete
        '
        Me.bDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.bDelete.Enabled = False
        Me.bDelete.FlatAppearance.BorderSize = 0
        Me.bDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bDelete.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bDelete.ForeColor = System.Drawing.Color.White
        Me.bDelete.Location = New System.Drawing.Point(185, 383)
        Me.bDelete.Name = "bDelete"
        Me.bDelete.Size = New System.Drawing.Size(75, 37)
        Me.bDelete.TabIndex = 14
        Me.bDelete.Text = "Delete"
        Me.bDelete.UseVisualStyleBackColor = False
        '
        'mtbSC
        '
        Me.mtbSC.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mtbSC.Location = New System.Drawing.Point(22, 157)
        Me.mtbSC.Mask = "000-00-0000"
        Me.mtbSC.Name = "mtbSC"
        Me.mtbSC.Size = New System.Drawing.Size(166, 16)
        Me.mtbSC.TabIndex = 1
        Me.mtbSC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bBack)
        Me.Panel1.Controls.Add(Me.pOff)
        Me.Panel1.Controls.Add(Me.pOn)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.bExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(400, 36)
        Me.Panel1.TabIndex = 22
        '
        'bBack
        '
        Me.bBack.Dock = System.Windows.Forms.DockStyle.Left
        Me.bBack.FlatAppearance.BorderSize = 0
        Me.bBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bBack.Image = CType(resources.GetObject("bBack.Image"), System.Drawing.Image)
        Me.bBack.Location = New System.Drawing.Point(0, 0)
        Me.bBack.Name = "bBack"
        Me.bBack.Size = New System.Drawing.Size(50, 36)
        Me.bBack.TabIndex = 88
        Me.bBack.UseVisualStyleBackColor = True
        '
        'pOff
        '
        Me.pOff.Image = CType(resources.GetObject("pOff.Image"), System.Drawing.Image)
        Me.pOff.Location = New System.Drawing.Point(216, 4)
        Me.pOff.Name = "pOff"
        Me.pOff.Size = New System.Drawing.Size(25, 25)
        Me.pOff.TabIndex = 87
        Me.pOff.TabStop = False
        Me.pOff.Visible = False
        '
        'pOn
        '
        Me.pOn.Image = CType(resources.GetObject("pOn.Image"), System.Drawing.Image)
        Me.pOn.Location = New System.Drawing.Point(216, 5)
        Me.pOn.Name = "pOn"
        Me.pOn.Size = New System.Drawing.Size(25, 27)
        Me.pOn.TabIndex = 86
        Me.pOn.TabStop = False
        Me.pOn.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(154, 9)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 20)
        Me.Label9.TabIndex = 85
        Me.Label9.Text = "Status :"
        '
        'bExit
        '
        Me.bExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.bExit.FlatAppearance.BorderSize = 0
        Me.bExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExit.Image = CType(resources.GetObject("bExit.Image"), System.Drawing.Image)
        Me.bExit.Location = New System.Drawing.Point(350, 0)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(50, 36)
        Me.bExit.TabIndex = 9
        Me.bExit.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.Label11)
        Me.Panel2.Controls.Add(Me.Label10)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.bSave)
        Me.Panel2.Controls.Add(Me.bDelete)
        Me.Panel2.Controls.Add(Me.tbUser2)
        Me.Panel2.Controls.Add(Me.bUpdate)
        Me.Panel2.Controls.Add(Me.bEnter)
        Me.Panel2.Controls.Add(Me.mtbSC)
        Me.Panel2.Controls.Add(Me.mtbPin)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.tbPass2)
        Me.Panel2.Location = New System.Drawing.Point(63, 59)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(280, 590)
        Me.Panel2.TabIndex = 23
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(91, 371)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(121, 5)
        Me.Label13.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(91, 337)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(121, 5)
        Me.Label12.TabIndex = 29
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(22, 220)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(165, 5)
        Me.Label11.TabIndex = 27
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(23, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(165, 5)
        Me.Label10.TabIndex = 26
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(280, 96)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(113, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 70)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Username"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 85
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "Password"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(400, 700)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign In"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents mtbPin As MaskedTextBox
    Friend WithEvents tbUser2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbPass2 As TextBox
    Friend WithEvents bEnter As Button
    Friend WithEvents bSave As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents bUpdate As Button
    Friend WithEvents bDelete As Button
    Friend WithEvents mtbSC As MaskedTextBox
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents bBack As Button
    Friend WithEvents pOff As PictureBox
    Friend WithEvents pOn As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents bExit As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
