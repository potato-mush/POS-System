<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class loginForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(loginForm))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.headerText = New System.Windows.Forms.Label()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.loginPanel = New System.Windows.Forms.Panel()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbPassword = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbEmployeeId = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.loginPanel.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.headerText)
        Me.Panel3.Controls.Add(Me.closeBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(552, 58)
        Me.Panel3.TabIndex = 3
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(14, 12)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(35, 35)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'headerText
        '
        Me.headerText.AutoSize = True
        Me.headerText.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerText.Location = New System.Drawing.Point(60, 17)
        Me.headerText.Name = "headerText"
        Me.headerText.Size = New System.Drawing.Size(80, 24)
        Me.headerText.TabIndex = 1
        Me.headerText.Text = "LOGIN"
        '
        'closeBtn
        '
        Me.closeBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.closeBtn.FlatAppearance.BorderSize = 0
        Me.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.closeBtn.Location = New System.Drawing.Point(494, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(58, 58)
        Me.closeBtn.TabIndex = 0
        Me.closeBtn.Text = "X"
        Me.closeBtn.UseVisualStyleBackColor = True
        '
        'loginPanel
        '
        Me.loginPanel.Controls.Add(Me.loginBtn)
        Me.loginPanel.Controls.Add(Me.Panel2)
        Me.loginPanel.Controls.Add(Me.Panel1)
        Me.loginPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.loginPanel.Location = New System.Drawing.Point(0, 58)
        Me.loginPanel.Name = "loginPanel"
        Me.loginPanel.Size = New System.Drawing.Size(552, 299)
        Me.loginPanel.TabIndex = 4
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.loginBtn.FlatAppearance.BorderSize = 0
        Me.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.loginBtn.Location = New System.Drawing.Point(359, 221)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(135, 44)
        Me.loginBtn.TabIndex = 14
        Me.loginBtn.Text = "LOGIN"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Controls.Add(Me.tbPassword)
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Location = New System.Drawing.Point(64, 130)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel2.Size = New System.Drawing.Size(430, 72)
        Me.Panel2.TabIndex = 2
        '
        'tbPassword
        '
        Me.tbPassword.BackColor = System.Drawing.Color.White
        Me.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbPassword.ForeColor = System.Drawing.Color.Silver
        Me.tbPassword.Location = New System.Drawing.Point(81, 23)
        Me.tbPassword.Name = "tbPassword"
        Me.tbPassword.Size = New System.Drawing.Size(325, 28)
        Me.tbPassword.TabIndex = 1
        Me.tbPassword.Text = "Password"
        '
        'PictureBox2
        '
        Me.PictureBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(56, 56)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.tbEmployeeId)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Location = New System.Drawing.Point(64, 42)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel1.Size = New System.Drawing.Size(430, 72)
        Me.Panel1.TabIndex = 0
        '
        'tbEmployeeId
        '
        Me.tbEmployeeId.BackColor = System.Drawing.Color.White
        Me.tbEmployeeId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbEmployeeId.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmployeeId.ForeColor = System.Drawing.Color.Silver
        Me.tbEmployeeId.Location = New System.Drawing.Point(81, 23)
        Me.tbEmployeeId.Name = "tbEmployeeId"
        Me.tbEmployeeId.Size = New System.Drawing.Size(325, 28)
        Me.tbEmployeeId.TabIndex = 1
        Me.tbEmployeeId.Text = "Employee ID"
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(56, 56)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'loginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(552, 357)
        Me.Controls.Add(Me.loginPanel)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "loginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "loginForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.loginPanel.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As Panel
    Friend WithEvents closeBtn As Button
    Friend WithEvents headerText As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents loginPanel As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbPassword As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents tbEmployeeId As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents loginBtn As Button
End Class
