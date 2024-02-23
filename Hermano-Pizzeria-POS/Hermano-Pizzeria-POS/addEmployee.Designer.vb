<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addEmployee))
        Me.addBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.headerText = New System.Windows.Forms.Label()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.pbEmployeePhoto = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbFname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbLname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbAccountPassword = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbGender = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbAge = New System.Windows.Forms.TextBox()
        Me.cbPosition = New System.Windows.Forms.ComboBox()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbEmployeePhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.FlatAppearance.BorderSize = 0
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addBtn.Location = New System.Drawing.Point(209, 438)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(123, 42)
        Me.addBtn.TabIndex = 15
        Me.addBtn.Text = "ADD"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Silver
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.headerText)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(544, 58)
        Me.Panel3.TabIndex = 16
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
        Me.headerText.Size = New System.Drawing.Size(178, 24)
        Me.headerText.TabIndex = 1
        Me.headerText.Text = "ADD EMPLOYEE"
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Crimson
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.FlatAppearance.BorderSize = 0
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cancelBtn.Location = New System.Drawing.Point(357, 438)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(123, 42)
        Me.cancelBtn.TabIndex = 17
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'pbEmployeePhoto
        '
        Me.pbEmployeePhoto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEmployeePhoto.Image = Global.Hermano_Pizzeria_POS.My.Resources.Resources.user
        Me.pbEmployeePhoto.Location = New System.Drawing.Point(27, 94)
        Me.pbEmployeePhoto.Name = "pbEmployeePhoto"
        Me.pbEmployeePhoto.Size = New System.Drawing.Size(100, 100)
        Me.pbEmployeePhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEmployeePhoto.TabIndex = 18
        Me.pbEmployeePhoto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Select an image"
        '
        'tbFname
        '
        Me.tbFname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFname.Location = New System.Drawing.Point(172, 123)
        Me.tbFname.Name = "tbFname"
        Me.tbFname.Size = New System.Drawing.Size(160, 24)
        Me.tbFname.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Last Name"
        '
        'tbLname
        '
        Me.tbLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLname.Location = New System.Drawing.Point(351, 123)
        Me.tbLname.Name = "tbLname"
        Me.tbLname.Size = New System.Drawing.Size(160, 24)
        Me.tbLname.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Employee ID"
        '
        'tbEmployeeID
        '
        Me.tbEmployeeID.Enabled = False
        Me.tbEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmployeeID.Location = New System.Drawing.Point(172, 189)
        Me.tbEmployeeID.Name = "tbEmployeeID"
        Me.tbEmployeeID.Size = New System.Drawing.Size(339, 24)
        Me.tbEmployeeID.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(169, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(134, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Account Password"
        '
        'tbAccountPassword
        '
        Me.tbAccountPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAccountPassword.Location = New System.Drawing.Point(172, 251)
        Me.tbAccountPassword.Name = "tbAccountPassword"
        Me.tbAccountPassword.Size = New System.Drawing.Size(339, 24)
        Me.tbAccountPassword.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(169, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Position"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Gender"
        '
        'cbGender
        '
        Me.cbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGender.FormattingEnabled = True
        Me.cbGender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbGender.Location = New System.Drawing.Point(172, 373)
        Me.cbGender.Name = "cbGender"
        Me.cbGender.Size = New System.Drawing.Size(160, 26)
        Me.cbGender.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(348, 346)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 16)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Age"
        '
        'tbAge
        '
        Me.tbAge.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAge.Location = New System.Drawing.Point(351, 375)
        Me.tbAge.Name = "tbAge"
        Me.tbAge.Size = New System.Drawing.Size(160, 24)
        Me.tbAge.TabIndex = 33
        '
        'cbPosition
        '
        Me.cbPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPosition.FormattingEnabled = True
        Me.cbPosition.Items.AddRange(New Object() {"WAITER", "COOK", "CASHIER", "ADMIN"})
        Me.cbPosition.Location = New System.Drawing.Point(172, 312)
        Me.cbPosition.Name = "cbPosition"
        Me.cbPosition.Size = New System.Drawing.Size(339, 26)
        Me.cbPosition.TabIndex = 35
        '
        'addEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 510)
        Me.Controls.Add(Me.cbPosition)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbAge)
        Me.Controls.Add(Me.cbGender)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.tbAccountPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbEmployeeID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbLname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbFname)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbEmployeePhoto)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.addBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addEmployee"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbEmployeePhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents addBtn As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents headerText As Label
    Friend WithEvents cancelBtn As Button
    Friend WithEvents pbEmployeePhoto As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents tbFname As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbLname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbEmployeeID As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbAccountPassword As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbGender As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbAge As TextBox
    Friend WithEvents cbPosition As ComboBox
End Class
