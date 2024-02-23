<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class logsControl
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(logsControl))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.displayAllBtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.filterBtn = New System.Windows.Forms.Button()
        Me.toDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.fromDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tbSearchEmployee = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logsData = New System.Windows.Forms.DataGridView()
        Me.employee_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_position = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time_in = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.time_out = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.datee = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.logsData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PrintDocument1
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.displayAllBtn)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.filterBtn)
        Me.Panel1.Controls.Add(Me.toDatePicker)
        Me.Panel1.Controls.Add(Me.fromDatePicker)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 88)
        Me.Panel1.TabIndex = 4
        '
        'displayAllBtn
        '
        Me.displayAllBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.displayAllBtn.FlatAppearance.BorderSize = 0
        Me.displayAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.displayAllBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayAllBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.displayAllBtn.Location = New System.Drawing.Point(846, 25)
        Me.displayAllBtn.Name = "displayAllBtn"
        Me.displayAllBtn.Size = New System.Drawing.Size(94, 36)
        Me.displayAllBtn.TabIndex = 27
        Me.displayAllBtn.Text = "Display All"
        Me.displayAllBtn.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.printBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(950, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(139, 88)
        Me.Panel4.TabIndex = 26
        '
        'printBtn
        '
        Me.printBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.printBtn.FlatAppearance.BorderSize = 0
        Me.printBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.printBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.printBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.printBtn.Location = New System.Drawing.Point(48, 25)
        Me.printBtn.Name = "printBtn"
        Me.printBtn.Size = New System.Drawing.Size(75, 36)
        Me.printBtn.TabIndex = 18
        Me.printBtn.Text = "Print"
        Me.printBtn.UseVisualStyleBackColor = False
        '
        'filterBtn
        '
        Me.filterBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.filterBtn.FlatAppearance.BorderSize = 0
        Me.filterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.filterBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.filterBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.filterBtn.Location = New System.Drawing.Point(753, 25)
        Me.filterBtn.Name = "filterBtn"
        Me.filterBtn.Size = New System.Drawing.Size(75, 36)
        Me.filterBtn.TabIndex = 25
        Me.filterBtn.Text = "Filter"
        Me.filterBtn.UseVisualStyleBackColor = False
        '
        'toDatePicker
        '
        Me.toDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.toDatePicker.Location = New System.Drawing.Point(591, 30)
        Me.toDatePicker.Name = "toDatePicker"
        Me.toDatePicker.Size = New System.Drawing.Size(136, 26)
        Me.toDatePicker.TabIndex = 24
        '
        'fromDatePicker
        '
        Me.fromDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fromDatePicker.Location = New System.Drawing.Point(400, 30)
        Me.fromDatePicker.Name = "fromDatePicker"
        Me.fromDatePicker.Size = New System.Drawing.Size(136, 26)
        Me.fromDatePicker.TabIndex = 22
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(556, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 23)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "-"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.tbSearchEmployee)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Location = New System.Drawing.Point(11, 22)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel5.Size = New System.Drawing.Size(356, 44)
        Me.Panel5.TabIndex = 21
        '
        'tbSearchEmployee
        '
        Me.tbSearchEmployee.BackColor = System.Drawing.Color.White
        Me.tbSearchEmployee.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSearchEmployee.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchEmployee.Location = New System.Drawing.Point(51, 13)
        Me.tbSearchEmployee.Name = "tbSearchEmployee"
        Me.tbSearchEmployee.Size = New System.Drawing.Size(289, 19)
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
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.logsData)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 88)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1089, 373)
        Me.Panel2.TabIndex = 5
        '
        'logsData
        '
        Me.logsData.AllowUserToAddRows = False
        Me.logsData.AllowUserToDeleteRows = False
        Me.logsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.logsData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.logsData.ColumnHeadersHeight = 60
        Me.logsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.logsData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.employee_id, Me.employee_name, Me.employee_position, Me.time_in, Me.time_out, Me.datee})
        Me.logsData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.logsData.Location = New System.Drawing.Point(0, 0)
        Me.logsData.Name = "logsData"
        Me.logsData.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.logsData.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.logsData.RowHeadersVisible = False
        Me.logsData.RowHeadersWidth = 20
        Me.logsData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logsData.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.logsData.RowTemplate.Height = 40
        Me.logsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.logsData.Size = New System.Drawing.Size(1089, 373)
        Me.logsData.TabIndex = 1
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
        'time_in
        '
        Me.time_in.DataPropertyName = "time_in"
        Me.time_in.HeaderText = "Time In"
        Me.time_in.Name = "time_in"
        Me.time_in.ReadOnly = True
        '
        'time_out
        '
        Me.time_out.DataPropertyName = "time_out"
        Me.time_out.HeaderText = "Time Out"
        Me.time_out.Name = "time_out"
        Me.time_out.ReadOnly = True
        '
        'datee
        '
        Me.datee.DataPropertyName = "date"
        Me.datee.HeaderText = "Date"
        Me.datee.Name = "datee"
        Me.datee.ReadOnly = True
        '
        'logsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "logsControl"
        Me.Size = New System.Drawing.Size(1089, 461)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.logsData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PageSetupDialog1 As PageSetupDialog
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents displayAllBtn As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents printBtn As Button
    Friend WithEvents filterBtn As Button
    Friend WithEvents toDatePicker As DateTimePicker
    Friend WithEvents fromDatePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents tbSearchEmployee As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents logsData As DataGridView
    Friend WithEvents employee_id As DataGridViewTextBoxColumn
    Friend WithEvents employee_name As DataGridViewTextBoxColumn
    Friend WithEvents employee_position As DataGridViewTextBoxColumn
    Friend WithEvents time_in As DataGridViewTextBoxColumn
    Friend WithEvents time_out As DataGridViewTextBoxColumn
    Friend WithEvents datee As DataGridViewTextBoxColumn
End Class
