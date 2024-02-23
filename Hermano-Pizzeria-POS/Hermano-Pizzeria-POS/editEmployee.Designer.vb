<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editEmployee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editEmployee))
        Me.cbPositionEdit = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbAgeEdit = New System.Windows.Forms.TextBox()
        Me.cbGenderEdit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbEmployeeIDEdit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbLnameEdit = New System.Windows.Forms.TextBox()
        Me.tbFnameEdit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pbEmployeePhotoEdit = New System.Windows.Forms.PictureBox()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.headerText = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.resetPasswordBtn = New System.Windows.Forms.Button()
        CType(Me.pbEmployeePhotoEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbPositionEdit
        '
        Me.cbPositionEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbPositionEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPositionEdit.FormattingEnabled = True
        Me.cbPositionEdit.Items.AddRange(New Object() {"WAITER", "COOK", "CASHIER", "ADMIN"})
        Me.cbPositionEdit.Location = New System.Drawing.Point(172, 259)
        Me.cbPositionEdit.Name = "cbPositionEdit"
        Me.cbPositionEdit.Size = New System.Drawing.Size(339, 26)
        Me.cbPositionEdit.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(348, 293)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Age"
        '
        'tbAgeEdit
        '
        Me.tbAgeEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAgeEdit.Location = New System.Drawing.Point(351, 322)
        Me.tbAgeEdit.Name = "tbAgeEdit"
        Me.tbAgeEdit.Size = New System.Drawing.Size(160, 24)
        Me.tbAgeEdit.TabIndex = 52
        '
        'cbGenderEdit
        '
        Me.cbGenderEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbGenderEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbGenderEdit.FormattingEnabled = True
        Me.cbGenderEdit.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.cbGenderEdit.Location = New System.Drawing.Point(172, 320)
        Me.cbGenderEdit.Name = "cbGenderEdit"
        Me.cbGenderEdit.Size = New System.Drawing.Size(160, 26)
        Me.cbGenderEdit.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(169, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Position"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Employee ID"
        '
        'tbEmployeeIDEdit
        '
        Me.tbEmployeeIDEdit.Enabled = False
        Me.tbEmployeeIDEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbEmployeeIDEdit.Location = New System.Drawing.Point(172, 189)
        Me.tbEmployeeIDEdit.Name = "tbEmployeeIDEdit"
        Me.tbEmployeeIDEdit.Size = New System.Drawing.Size(339, 24)
        Me.tbEmployeeIDEdit.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "Last Name"
        '
        'tbLnameEdit
        '
        Me.tbLnameEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbLnameEdit.Location = New System.Drawing.Point(351, 123)
        Me.tbLnameEdit.Name = "tbLnameEdit"
        Me.tbLnameEdit.Size = New System.Drawing.Size(160, 24)
        Me.tbLnameEdit.TabIndex = 43
        '
        'tbFnameEdit
        '
        Me.tbFnameEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbFnameEdit.Location = New System.Drawing.Point(172, 123)
        Me.tbFnameEdit.Name = "tbFnameEdit"
        Me.tbFnameEdit.Size = New System.Drawing.Size(160, 24)
        Me.tbFnameEdit.TabIndex = 41
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Select an image"
        '
        'pbEmployeePhotoEdit
        '
        Me.pbEmployeePhotoEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbEmployeePhotoEdit.Image = Global.Hermano_Pizzeria_POS.My.Resources.Resources.user
        Me.pbEmployeePhotoEdit.Location = New System.Drawing.Point(27, 94)
        Me.pbEmployeePhotoEdit.Name = "pbEmployeePhotoEdit"
        Me.pbEmployeePhotoEdit.Size = New System.Drawing.Size(100, 100)
        Me.pbEmployeePhotoEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEmployeePhotoEdit.TabIndex = 39
        Me.pbEmployeePhotoEdit.TabStop = False
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Crimson
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.FlatAppearance.BorderSize = 0
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cancelBtn.Location = New System.Drawing.Point(357, 385)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(123, 42)
        Me.cancelBtn.TabIndex = 38
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.UseVisualStyleBackColor = False
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
        Me.headerText.Size = New System.Drawing.Size(181, 24)
        Me.headerText.TabIndex = 1
        Me.headerText.Text = "EDIT EMPLOYEE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "First Name"
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
        Me.Panel3.TabIndex = 37
        '
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveBtn.FlatAppearance.BorderSize = 0
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.saveBtn.Location = New System.Drawing.Point(209, 385)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(123, 42)
        Me.saveBtn.TabIndex = 36
        Me.saveBtn.Text = "SAVE"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'resetPasswordBtn
        '
        Me.resetPasswordBtn.Location = New System.Drawing.Point(27, 322)
        Me.resetPasswordBtn.Name = "resetPasswordBtn"
        Me.resetPasswordBtn.Size = New System.Drawing.Size(103, 23)
        Me.resetPasswordBtn.TabIndex = 55
        Me.resetPasswordBtn.Text = "Reset Password"
        Me.resetPasswordBtn.UseVisualStyleBackColor = True
        '
        'editEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 455)
        Me.Controls.Add(Me.resetPasswordBtn)
        Me.Controls.Add(Me.cbPositionEdit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbAgeEdit)
        Me.Controls.Add(Me.cbGenderEdit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbEmployeeIDEdit)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbLnameEdit)
        Me.Controls.Add(Me.tbFnameEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pbEmployeePhotoEdit)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.saveBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editEmployee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editEmployee"
        CType(Me.pbEmployeePhotoEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbPositionEdit As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbAgeEdit As TextBox
    Friend WithEvents cbGenderEdit As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbEmployeeIDEdit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbLnameEdit As TextBox
    Friend WithEvents tbFnameEdit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents pbEmployeePhotoEdit As PictureBox
    Friend WithEvents cancelBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents headerText As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents saveBtn As Button
    Friend WithEvents resetPasswordBtn As Button
End Class
