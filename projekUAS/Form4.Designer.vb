<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.bBack = New System.Windows.Forms.Button()
        Me.pOff = New System.Windows.Forms.PictureBox()
        Me.pOn = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bExit = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbSearch = New System.Windows.Forms.TextBox()
        Me.bSearch = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        CType(Me.pOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel1.Controls.Add(Me.bBack)
        Me.Panel1.Controls.Add(Me.pOff)
        Me.Panel1.Controls.Add(Me.pOn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.bExit)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 36)
        Me.Panel1.TabIndex = 0
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(154, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 85
        Me.Label4.Text = "Status :"
        '
        'bExit
        '
        Me.bExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.bExit.FlatAppearance.BorderSize = 0
        Me.bExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExit.Image = CType(resources.GetObject("bExit.Image"), System.Drawing.Image)
        Me.bExit.Location = New System.Drawing.Point(344, 0)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(50, 36)
        Me.bExit.TabIndex = 9
        Me.bExit.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 96)
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(82, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 15)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Search Password Here"
        '
        'tbSearch
        '
        Me.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSearch.Location = New System.Drawing.Point(92, 120)
        Me.tbSearch.Name = "tbSearch"
        Me.tbSearch.Size = New System.Drawing.Size(111, 16)
        Me.tbSearch.TabIndex = 15
        Me.tbSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'bSearch
        '
        Me.bSearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.bSearch.FlatAppearance.BorderSize = 0
        Me.bSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bSearch.ForeColor = System.Drawing.Color.White
        Me.bSearch.Location = New System.Drawing.Point(92, 156)
        Me.bSearch.Name = "bSearch"
        Me.bSearch.Size = New System.Drawing.Size(113, 23)
        Me.bSearch.TabIndex = 16
        Me.bSearch.Text = "Search"
        Me.bSearch.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(92, 139)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 5)
        Me.Label2.TabIndex = 25
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3})
        Me.DataGridView1.Location = New System.Drawing.Point(3, 217)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(270, 133)
        Me.DataGridView1.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.bSearch)
        Me.Panel2.Controls.Add(Me.tbSearch)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(59, 68)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(276, 353)
        Me.Panel2.TabIndex = 1
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
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(394, 464)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forgot Form"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.pOff, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pOn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents bExit As Button
    Friend WithEvents pOff As PictureBox
    Friend WithEvents pOn As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents bBack As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbSearch As TextBox
    Friend WithEvents bSearch As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
End Class
