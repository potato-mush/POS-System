<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EmployeeControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EmployeeControl))
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.removeBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tbSearchEmployee = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.addEmployeeBtn = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.employeeData = New System.Windows.Forms.DataGridView()
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_age = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_img = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.lblPageNumber = New System.Windows.Forms.Label()
        Me.btnLastPage = New System.Windows.Forms.Button()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.btnPrevPage = New System.Windows.Forms.Button()
        Me.btnFirstPage = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.employeeData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 176)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel6)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 93)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1089, 83)
        Me.Panel3.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.removeBtn)
        Me.Panel6.Controls.Add(Me.editBtn)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(769, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(320, 83)
        Me.Panel6.TabIndex = 2
        '
        'removeBtn
        '
        Me.removeBtn.BackColor = System.Drawing.Color.Crimson
        Me.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.removeBtn.FlatAppearance.BorderSize = 0
        Me.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.removeBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.removeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.removeBtn.Image = CType(resources.GetObject("removeBtn.Image"), System.Drawing.Image)
        Me.removeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.removeBtn.Location = New System.Drawing.Point(167, 13)
        Me.removeBtn.Name = "removeBtn"
        Me.removeBtn.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.removeBtn.Size = New System.Drawing.Size(128, 44)
        Me.removeBtn.TabIndex = 1
        Me.removeBtn.Text = "Remove"
        Me.removeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.removeBtn.UseVisualStyleBackColor = False
        '
        'editBtn
        '
        Me.editBtn.BackColor = System.Drawing.Color.Orange
        Me.editBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.editBtn.FlatAppearance.BorderSize = 0
        Me.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.editBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.editBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.editBtn.Image = CType(resources.GetObject("editBtn.Image"), System.Drawing.Image)
        Me.editBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.editBtn.Location = New System.Drawing.Point(13, 14)
        Me.editBtn.Name = "editBtn"
        Me.editBtn.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.editBtn.Size = New System.Drawing.Size(128, 44)
        Me.editBtn.TabIndex = 0
        Me.editBtn.Text = "Edit"
        Me.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.editBtn.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.addEmployeeBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(646, 83)
        Me.Panel4.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.tbSearchEmployee)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Location = New System.Drawing.Point(214, 13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel5.Size = New System.Drawing.Size(409, 44)
        Me.Panel5.TabIndex = 0
        '
        'tbSearchEmployee
        '
        Me.tbSearchEmployee.BackColor = System.Drawing.Color.White
        Me.tbSearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSearchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchEmployee.Location = New System.Drawing.Point(51, 13)
        Me.tbSearchEmployee.Name = "tbSearchEmployee"
        Me.tbSearchEmployee.Size = New System.Drawing.Size(337, 19)
        Me.tbSearchEmployee.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(8, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(28, 28)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'addEmployeeBtn
        '
        Me.addEmployeeBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.addEmployeeBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addEmployeeBtn.FlatAppearance.BorderSize = 0
        Me.addEmployeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addEmployeeBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addEmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addEmployeeBtn.Image = CType(resources.GetObject("addEmployeeBtn.Image"), System.Drawing.Image)
        Me.addEmployeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addEmployeeBtn.Location = New System.Drawing.Point(14, 13)
        Me.addEmployeeBtn.Name = "addEmployeeBtn"
        Me.addEmployeeBtn.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.addEmployeeBtn.Size = New System.Drawing.Size(157, 44)
        Me.addEmployeeBtn.TabIndex = 0
        Me.addEmployeeBtn.Text = "Add Employee"
        Me.addEmployeeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.addEmployeeBtn.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.employeeData)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 176)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1089, 285)
        Me.Panel2.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel7.Location = New System.Drawing.Point(0, 226)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1089, 59)
        Me.Panel7.TabIndex = 1
        '
        'employeeData
        '
        Me.employeeData.AllowUserToAddRows = False
        Me.employeeData.AllowUserToDeleteRows = False
        Me.employeeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeeData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.employeeData.ColumnHeadersHeight = 60
        Me.employeeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.employeeData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employee_id, Me.employee_name, Me.employee_position, Me.employee_gender, Me.employee_age, Me.employee_img})
        Me.employeeData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.employeeData.Location = New System.Drawing.Point(0, 0)
        Me.employeeData.Name = "employeeData"
        Me.employeeData.ReadOnly = True
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employeeData.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.employeeData.RowHeadersVisible = False
        Me.employeeData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeData.RowsDefaultCellStyle = DataGridViewCellStyle9
        Me.employeeData.RowTemplate.Height = 100
        Me.employeeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.employeeData.Size = New System.Drawing.Size(1089, 285)
        Me.employeeData.TabIndex = 0
        '
        'employee_id
        '
        Me.employee_id.DataPropertyName = "employee_id"
        Me.employee_id.HeaderText = "Employee ID"
        Me.employee_id.Name = "employee_id"
        Me.employee_id.ReadOnly = True
        '
        'employee_name
        '
        Me.employee_name.DataPropertyName = "employee_name"
        Me.employee_name.HeaderText = "Employee Name"
        Me.employee_name.Name = "employee_name"
        Me.employee_name.ReadOnly = True
        '
        'employee_position
        '
        Me.employee_position.DataPropertyName = "employee_position"
        Me.employee_position.HeaderText = "Position"
        Me.employee_position.Name = "employee_position"
        Me.employee_position.ReadOnly = True
        '
        'employee_gender
        '
        Me.employee_gender.DataPropertyName = "employee_gender"
        Me.employee_gender.HeaderText = "Gender"
        Me.employee_gender.Name = "employee_gender"
        Me.employee_gender.ReadOnly = True
        '
        'employee_age
        '
        Me.employee_age.DataPropertyName = "employee_age"
        Me.employee_age.HeaderText = "Age"
        Me.employee_age.Name = "employee_age"
        Me.employee_age.ReadOnly = True
        '
        'employee_img
        '
        Me.employee_img.DataPropertyName = "employee_img"
        Me.employee_img.HeaderText = "Profile"
        Me.employee_img.Name = "employee_img"
        Me.employee_img.ReadOnly = True
        Me.employee_img.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.employee_img.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.lblPageNumber)
        Me.Panel8.Controls.Add(Me.btnLastPage)
        Me.Panel8.Controls.Add(Me.btnNextPage)
        Me.Panel8.Controls.Add(Me.btnPrevPage)
        Me.Panel8.Controls.Add(Me.btnFirstPage)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(364, 59)
        Me.Panel8.TabIndex = 13
        '
        'lblPageNumber
        '
        Me.lblPageNumber.AutoSize = True
        Me.lblPageNumber.Location = New System.Drawing.Point(154, 23)
        Me.lblPageNumber.Name = "lblPageNumber"
        Me.lblPageNumber.Size = New System.Drawing.Size(39, 13)
        Me.lblPageNumber.TabIndex = 17
        Me.lblPageNumber.Text = "Label1"
        '
        'btnLastPage
        '
        Me.btnLastPage.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnLastPage.FlatAppearance.BorderSize = 0
        Me.btnLastPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLastPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLastPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnLastPage.Location = New System.Drawing.Point(282, 11)
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(75, 36)
        Me.btnLastPage.TabIndex = 16
        Me.btnLastPage.Text = "Last"
        Me.btnLastPage.UseVisualStyleBackColor = False
        '
        'btnNextPage
        '
        Me.btnNextPage.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnNextPage.FlatAppearance.BorderSize = 0
        Me.btnNextPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNextPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNextPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnNextPage.Location = New System.Drawing.Point(237, 11)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(39, 36)
        Me.btnNextPage.TabIndex = 15
        Me.btnNextPage.Text = ">>"
        Me.btnNextPage.UseVisualStyleBackColor = False
        '
        'btnPrevPage
        '
        Me.btnPrevPage.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnPrevPage.FlatAppearance.BorderSize = 0
        Me.btnPrevPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrevPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrevPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnPrevPage.Location = New System.Drawing.Point(89, 11)
        Me.btnPrevPage.Name = "btnPrevPage"
        Me.btnPrevPage.Size = New System.Drawing.Size(39, 36)
        Me.btnPrevPage.TabIndex = 14
        Me.btnPrevPage.Text = "<<"
        Me.btnPrevPage.UseVisualStyleBackColor = False
        '
        'btnFirstPage
        '
        Me.btnFirstPage.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.btnFirstPage.FlatAppearance.BorderSize = 0
        Me.btnFirstPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnFirstPage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFirstPage.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.btnFirstPage.Location = New System.Drawing.Point(8, 11)
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(75, 36)
        Me.btnFirstPage.TabIndex = 13
        Me.btnFirstPage.Text = "First"
        Me.btnFirstPage.UseVisualStyleBackColor = False
        '
        'EmployeeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "EmployeeControl"
        Me.Size = New System.Drawing.Size(1089, 461)
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        CType(Me.employeeData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents addEmployeeBtn As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents tbSearchEmployee As TextBox
    Friend WithEvents employeeData As DataGridView
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents employee_name As DataGridViewTextBoxColumn
    Friend WithEvents employee_position As DataGridViewTextBoxColumn
    Friend WithEvents employee_gender As DataGridViewTextBoxColumn
    Friend WithEvents employee_age As DataGridViewTextBoxColumn
    Friend WithEvents employee_img As DataGridViewImageColumn
    Friend WithEvents Panel6 As Panel
    Friend WithEvents removeBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel8 As Panel
    Friend WithEvents lblPageNumber As Label
    Friend WithEvents btnLastPage As Button
    Friend WithEvents btnNextPage As Button
    Friend WithEvents btnPrevPage As Button
    Friend WithEvents btnFirstPage As Button
End Class
