<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(changePassword))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.closeBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.headerText = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbAccountPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbNewPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbConfirmPassword = New System.Windows.Forms.TextBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.closeBtn)
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.headerText)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(432, 58)
        Me.Panel3.TabIndex = 17
        '
        'closeBtn
        '
        Me.closeBtn.Dock = System.Windows.Forms.DockStyle.Right
        Me.closeBtn.FlatAppearance.BorderSize = 0
        Me.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Orange
        Me.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.closeBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.closeBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.closeBtn.Location = New System.Drawing.Point(374, 0)
        Me.closeBtn.Name = "closeBtn"
        Me.closeBtn.Size = New System.Drawing.Size(58, 58)
        Me.closeBtn.TabIndex = 3
        Me.closeBtn.Text = "X"
        Me.closeBtn.UseVisualStyleBackColor = True
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
        Me.headerText.Size = New System.Drawing.Size(234, 24)
        Me.headerText.TabIndex = 1
        Me.headerText.Text = "CHANGE PASSWORD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(43, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 16)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Old Password"
        '
        'tbAccountPassword
        '
        Me.tbAccountPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccountPassword.Location = New System.Drawing.Point(46, 132)
        Me.tbAccountPassword.Name = "tbAccountPassword"
        Me.tbAccountPassword.Size = New System.Drawing.Size(339, 24)
        Me.tbAccountPassword.TabIndex = 28
        Me.tbAccountPassword.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(43, 180)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 16)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "New Password"
        '
        'tbNewPassword
        '
        Me.tbNewPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNewPassword.Location = New System.Drawing.Point(46, 209)
        Me.tbNewPassword.Name = "tbNewPassword"
        Me.tbNewPassword.Size = New System.Drawing.Size(339, 24)
        Me.tbNewPassword.TabIndex = 30
        Me.tbNewPassword.UseSystemPasswordChar = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 256)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 16)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Confirm Password"
        '
        'tbConfirmPassword
        '
        Me.tbConfirmPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbConfirmPassword.Location = New System.Drawing.Point(46, 285)
        Me.tbConfirmPassword.Name = "tbConfirmPassword"
        Me.tbConfirmPassword.Size = New System.Drawing.Size(339, 24)
        Me.tbConfirmPassword.TabIndex = 32
        Me.tbConfirmPassword.UseSystemPasswordChar = True
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.saveBtn.FlatAppearance.BorderSize = 0
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.saveBtn.Location = New System.Drawing.Point(125, 345)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(180, 44)
        Me.saveBtn.TabIndex = 34
        Me.saveBtn.Text = "SAVE CHANGES"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'changePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 426)
        Me.Controls.Add(Me.saveBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbConfirmPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbNewPassword)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbAccountPassword)
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "changePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "changePassword"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents headerText As Label
    Friend WithEvents closeBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents tbAccountPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbNewPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbConfirmPassword As TextBox
    Friend WithEvents saveBtn As Button
End Class
