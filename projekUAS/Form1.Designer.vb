<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pOff = New System.Windows.Forms.PictureBox()
        Me.bExit = New System.Windows.Forms.Button()
        Me.pOn = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblForgot = New System.Windows.Forms.Label()
        Me.lblSignIn = New System.Windows.Forms.Label()
        Me.bLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbPass = New System.Windows.Forms.TextBox()
        Me.tbUser = New System.Windows.Forms.TextBox()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.pOff, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pOn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.Panel1.Controls.Add(Me.pOff)
        Me.Panel1.Controls.Add(Me.bExit)
        Me.Panel1.Controls.Add(Me.pOn)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(559, 37)
        Me.Panel1.TabIndex = 0
        '
        'pOff
        '
        Me.pOff.Image = CType(resources.GetObject("pOff.Image"), System.Drawing.Image)
        Me.pOff.Location = New System.Drawing.Point(65, 4)
        Me.pOff.Name = "pOff"
        Me.pOff.Size = New System.Drawing.Size(25, 25)
        Me.pOff.TabIndex = 84
        Me.pOff.TabStop = False
        Me.pOff.Visible = False
        '
        'bExit
        '
        Me.bExit.Dock = System.Windows.Forms.DockStyle.Right
        Me.bExit.FlatAppearance.BorderSize = 0
        Me.bExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver
        Me.bExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bExit.Image = CType(resources.GetObject("bExit.Image"), System.Drawing.Image)
        Me.bExit.Location = New System.Drawing.Point(509, 0)
        Me.bExit.Name = "bExit"
        Me.bExit.Size = New System.Drawing.Size(50, 37)
        Me.bExit.TabIndex = 8
        Me.bExit.UseVisualStyleBackColor = True
        '
        'pOn
        '
        Me.pOn.Image = CType(resources.GetObject("pOn.Image"), System.Drawing.Image)
        Me.pOn.Location = New System.Drawing.Point(65, 5)
        Me.pOn.Name = "pOn"
        Me.pOn.Size = New System.Drawing.Size(25, 27)
        Me.pOn.TabIndex = 83
        Me.pOn.TabStop = False
        Me.pOn.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 20)
        Me.Label4.TabIndex = 82
        Me.Label4.Text = "Status :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblForgot)
        Me.Panel2.Controls.Add(Me.lblSignIn)
        Me.Panel2.Controls.Add(Me.bLogin)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.tbPass)
        Me.Panel2.Controls.Add(Me.tbUser)
        Me.Panel2.Controls.Add(Me.lblPass)
        Me.Panel2.Controls.Add(Me.lblUser)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Location = New System.Drawing.Point(130, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(302, 378)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(61, 246)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 5)
        Me.Label1.TabIndex = 29
        '
        'lblForgot
        '
        Me.lblForgot.AutoSize = True
        Me.lblForgot.Location = New System.Drawing.Point(119, 346)
        Me.lblForgot.Name = "lblForgot"
        Me.lblForgot.Size = New System.Drawing.Size(73, 15)
        Me.lblForgot.TabIndex = 28
        Me.lblForgot.Text = "Forgot Pass?"
        '
        'lblSignIn
        '
        Me.lblSignIn.AutoSize = True
        Me.lblSignIn.Location = New System.Drawing.Point(134, 331)
        Me.lblSignIn.Name = "lblSignIn"
        Me.lblSignIn.Size = New System.Drawing.Size(43, 15)
        Me.lblSignIn.TabIndex = 27
        Me.lblSignIn.Text = "Sign In"
        '
        'bLogin
        '
        Me.bLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.bLogin.FlatAppearance.BorderSize = 0
        Me.bLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(27, Byte), Integer), CType(CType(156, Byte), Integer), CType(CType(252, Byte), Integer))
        Me.bLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bLogin.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.bLogin.ForeColor = System.Drawing.Color.White
        Me.bLogin.Location = New System.Drawing.Point(61, 283)
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(193, 34)
        Me.bLogin.TabIndex = 26
        Me.bLogin.Text = "Login"
        Me.bLogin.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(61, 177)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(192, 5)
        Me.Label2.TabIndex = 24
        '
        'tbPass
        '
        Me.tbPass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPass.Location = New System.Drawing.Point(61, 227)
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbPass.Size = New System.Drawing.Size(193, 16)
        Me.tbPass.TabIndex = 22
        Me.tbPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'tbUser
        '
        Me.tbUser.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbUser.Location = New System.Drawing.Point(61, 158)
        Me.tbUser.Name = "tbUser"
        Me.tbUser.Size = New System.Drawing.Size(193, 16)
        Me.tbUser.TabIndex = 21
        Me.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblPass
        '
        Me.lblPass.AutoSize = True
        Me.lblPass.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblPass.Location = New System.Drawing.Point(119, 204)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(73, 20)
        Me.lblPass.TabIndex = 20
        Me.lblPass.Text = "Password:"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblUser.Location = New System.Drawing.Point(119, 135)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(78, 20)
        Me.lblUser.TabIndex = 19
        Me.lblUser.Text = "Username:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(44, Byte), Integer), CType(CType(97, Byte), Integer))
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(302, 112)
        Me.Panel3.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(124, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(68, 62)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(44, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(71, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(559, 467)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
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

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblForgot As Label
    Friend WithEvents lblSignIn As Label
    Friend WithEvents bLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbPass As TextBox
    Friend WithEvents tbUser As TextBox
    Friend WithEvents lblPass As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents bExit As Button
    Friend WithEvents pOff As PictureBox
    Friend WithEvents pOn As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
