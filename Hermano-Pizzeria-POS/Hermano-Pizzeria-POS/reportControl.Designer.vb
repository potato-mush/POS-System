<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ReportControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ReportControl))
        Me.reportData = New System.Windows.Forms.DataGridView()
        Me.transaction_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.transaction_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.employee_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.sub_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quantity = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grand_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.tbSearchTransaction = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.displayAllBtn = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.printBtn = New System.Windows.Forms.Button()
        Me.filterBtn = New System.Windows.Forms.Button()
        Me.toDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.fromDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.lbl_monthlySales = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_todaySales = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        CType(Me.reportData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'reportData
        '
        Me.reportData.AllowUserToAddRows = False
        Me.reportData.AllowUserToDeleteRows = False
        Me.reportData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.reportData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.reportData.ColumnHeadersHeight = 60
        Me.reportData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.reportData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.transaction_id, Me.transaction_date, Me.employee_name, Me.product_name, Me.sub_total, Me.quantity, Me.grand_total})
        Me.reportData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.reportData.Location = New System.Drawing.Point(0, 0)
        Me.reportData.Name = "reportData"
        Me.reportData.ReadOnly = True
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.reportData.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.reportData.RowHeadersVisible = False
        Me.reportData.RowHeadersWidth = 20
        Me.reportData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportData.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.reportData.RowTemplate.Height = 40
        Me.reportData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.reportData.Size = New System.Drawing.Size(1089, 250)
        Me.reportData.TabIndex = 0
        '
        'transaction_id
        '
        Me.transaction_id.DataPropertyName = "transaction_id"
        Me.transaction_id.HeaderText = "Transaction ID"
        Me.transaction_id.Name = "transaction_id"
        Me.transaction_id.ReadOnly = True
        '
        'transaction_date
        '
        Me.transaction_date.DataPropertyName = "transaction_date"
        Me.transaction_date.HeaderText = "Transaction Date"
        Me.transaction_date.Name = "transaction_date"
        Me.transaction_date.ReadOnly = True
        '
        'employee_name
        '
        Me.employee_name.DataPropertyName = "cashier"
        Me.employee_name.HeaderText = "Cashier"
        Me.employee_name.Name = "employee_name"
        Me.employee_name.ReadOnly = True
        '
        'product_name
        '
        Me.product_name.DataPropertyName = "product_name"
        Me.product_name.HeaderText = "Product Name"
        Me.product_name.Name = "product_name"
        Me.product_name.ReadOnly = True
        '
        'sub_total
        '
        Me.sub_total.DataPropertyName = "sub_total"
        DataGridViewCellStyle2.Format = "₱00.00"
        Me.sub_total.DefaultCellStyle = DataGridViewCellStyle2
        Me.sub_total.HeaderText = "Subtotal"
        Me.sub_total.Name = "sub_total"
        Me.sub_total.ReadOnly = True
        '
        'quantity
        '
        Me.quantity.DataPropertyName = "quantity"
        Me.quantity.HeaderText = "Quantity"
        Me.quantity.Name = "quantity"
        Me.quantity.ReadOnly = True
        '
        'grand_total
        '
        Me.grand_total.DataPropertyName = "grand_total"
        DataGridViewCellStyle3.Format = "₱00.00"
        Me.grand_total.DefaultCellStyle = DataGridViewCellStyle3
        Me.grand_total.HeaderText = "Grand Total"
        Me.grand_total.Name = "grand_total"
        Me.grand_total.ReadOnly = True
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.reportData)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 211)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1089, 250)
        Me.Panel2.TabIndex = 3
        '
        'tbSearchTransaction
        '
        Me.tbSearchTransaction.BackColor = System.Drawing.Color.White
        Me.tbSearchTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSearchTransaction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchTransaction.Location = New System.Drawing.Point(51, 13)
        Me.tbSearchTransaction.Name = "tbSearchTransaction"
        Me.tbSearchTransaction.Size = New System.Drawing.Size(289, 19)
        Me.tbSearchTransaction.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.tbSearchTransaction)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Location = New System.Drawing.Point(8, 22)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel5.Size = New System.Drawing.Size(356, 44)
        Me.Panel5.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.displayAllBtn)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.filterBtn)
        Me.Panel3.Controls.Add(Me.toDatePicker)
        Me.Panel3.Controls.Add(Me.fromDatePicker)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel5)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 128)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1089, 83)
        Me.Panel3.TabIndex = 1
        '
        'displayAllBtn
        '
        Me.displayAllBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.displayAllBtn.FlatAppearance.BorderSize = 0
        Me.displayAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.displayAllBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.displayAllBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.displayAllBtn.Location = New System.Drawing.Point(850, 25)
        Me.displayAllBtn.Name = "displayAllBtn"
        Me.displayAllBtn.Size = New System.Drawing.Size(94, 36)
        Me.displayAllBtn.TabIndex = 20
        Me.displayAllBtn.Text = "Display All"
        Me.displayAllBtn.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.printBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(950, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(139, 83)
        Me.Panel4.TabIndex = 19
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
        Me.filterBtn.Location = New System.Drawing.Point(757, 25)
        Me.filterBtn.Name = "filterBtn"
        Me.filterBtn.Size = New System.Drawing.Size(75, 36)
        Me.filterBtn.TabIndex = 17
        Me.filterBtn.Text = "Filter"
        Me.filterBtn.UseVisualStyleBackColor = False
        '
        'toDatePicker
        '
        Me.toDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.toDatePicker.Location = New System.Drawing.Point(595, 30)
        Me.toDatePicker.Name = "toDatePicker"
        Me.toDatePicker.Size = New System.Drawing.Size(136, 26)
        Me.toDatePicker.TabIndex = 3
        '
        'fromDatePicker
        '
        Me.fromDatePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fromDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.fromDatePicker.Location = New System.Drawing.Point(404, 30)
        Me.fromDatePicker.Name = "fromDatePicker"
        Me.fromDatePicker.Size = New System.Drawing.Size(136, 26)
        Me.fromDatePicker.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(560, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 211)
        Me.Panel1.TabIndex = 2
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.lbl_monthlySales)
        Me.Panel9.Controls.Add(Me.Label4)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel9.Location = New System.Drawing.Point(551, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(269, 128)
        Me.Panel9.TabIndex = 3
        '
        'lbl_monthlySales
        '
        Me.lbl_monthlySales.AutoSize = True
        Me.lbl_monthlySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_monthlySales.ForeColor = System.Drawing.Color.Green
        Me.lbl_monthlySales.Location = New System.Drawing.Point(25, 61)
        Me.lbl_monthlySales.Name = "lbl_monthlySales"
        Me.lbl_monthlySales.Size = New System.Drawing.Size(132, 39)
        Me.lbl_monthlySales.TabIndex = 3
        Me.lbl_monthlySales.Text = "₱00.00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(28, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Monthly Sales"
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.lbl_todaySales)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel6.Location = New System.Drawing.Point(820, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(269, 128)
        Me.Panel6.TabIndex = 2
        '
        'lbl_todaySales
        '
        Me.lbl_todaySales.AutoSize = True
        Me.lbl_todaySales.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_todaySales.ForeColor = System.Drawing.Color.Green
        Me.lbl_todaySales.Location = New System.Drawing.Point(20, 61)
        Me.lbl_todaySales.Name = "lbl_todaySales"
        Me.lbl_todaySales.Size = New System.Drawing.Size(132, 39)
        Me.lbl_todaySales.TabIndex = 1
        Me.lbl_todaySales.Text = "₱00.00"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(107, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Today Sales"
        '
        'PrintDocument1
        '
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
        'ReportControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ReportControl"
        Me.Size = New System.Drawing.Size(1089, 461)
        CType(Me.reportData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents reportData As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tbSearchTransaction As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents filterBtn As Button
    Friend WithEvents toDatePicker As DateTimePicker
    Friend WithEvents fromDatePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents printBtn As Button
    Friend WithEvents transaction_id As DataGridViewTextBoxColumn
    Friend WithEvents transaction_date As DataGridViewTextBoxColumn
    Friend WithEvents employee_name As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents sub_total As DataGridViewTextBoxColumn
    Friend WithEvents quantity As DataGridViewTextBoxColumn
    Friend WithEvents grand_total As DataGridViewTextBoxColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents displayAllBtn As Button
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_todaySales As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_monthlySales As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PageSetupDialog1 As PageSetupDialog
End Class
