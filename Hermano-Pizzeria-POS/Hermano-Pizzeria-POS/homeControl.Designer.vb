<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeControl
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lbl_revenue = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_categories = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_menu = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lbl_employee = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lbl_transactions = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(20)
        Me.Panel1.Size = New System.Drawing.Size(745, 461)
        Me.Panel1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel6)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(20, 20)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(705, 156)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Tan
        Me.Panel4.Controls.Add(Me.lbl_revenue)
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Location = New System.Drawing.Point(13, 13)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(13)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(239, 126)
        Me.Panel4.TabIndex = 4
        '
        'lbl_revenue
        '
        Me.lbl_revenue.AutoSize = True
        Me.lbl_revenue.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_revenue.ForeColor = System.Drawing.Color.Green
        Me.lbl_revenue.Location = New System.Drawing.Point(21, 90)
        Me.lbl_revenue.Name = "lbl_revenue"
        Me.lbl_revenue.Size = New System.Drawing.Size(86, 25)
        Me.lbl_revenue.TabIndex = 1
        Me.lbl_revenue.Text = "₱00.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(21, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 24)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Revenue"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightBlue
        Me.Panel3.Controls.Add(Me.lbl_categories)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(278, 13)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(13)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(239, 126)
        Me.Panel3.TabIndex = 5
        '
        'lbl_categories
        '
        Me.lbl_categories.AutoSize = True
        Me.lbl_categories.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categories.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_categories.Location = New System.Drawing.Point(188, 90)
        Me.lbl_categories.Name = "lbl_categories"
        Me.lbl_categories.Size = New System.Drawing.Size(21, 24)
        Me.lbl_categories.TabIndex = 1
        Me.lbl_categories.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(21, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 24)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Categories"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.Panel2.Controls.Add(Me.lbl_menu)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Location = New System.Drawing.Point(13, 165)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(13)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(239, 126)
        Me.Panel2.TabIndex = 6
        '
        'lbl_menu
        '
        Me.lbl_menu.AutoSize = True
        Me.lbl_menu.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_menu.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_menu.Location = New System.Drawing.Point(188, 90)
        Me.lbl_menu.Name = "lbl_menu"
        Me.lbl_menu.Size = New System.Drawing.Size(21, 24)
        Me.lbl_menu.TabIndex = 1
        Me.lbl_menu.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(21, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 24)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Menu"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightCoral
        Me.Panel5.Controls.Add(Me.lbl_employee)
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Location = New System.Drawing.Point(278, 165)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(239, 126)
        Me.Panel5.TabIndex = 3
        '
        'lbl_employee
        '
        Me.lbl_employee.AutoSize = True
        Me.lbl_employee.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_employee.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_employee.Location = New System.Drawing.Point(188, 90)
        Me.lbl_employee.Name = "lbl_employee"
        Me.lbl_employee.Size = New System.Drawing.Size(21, 24)
        Me.lbl_employee.TabIndex = 1
        Me.lbl_employee.Text = "0"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(21, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Employee"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.Crimson
        Me.Panel6.Controls.Add(Me.lbl_transactions)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(13, 317)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(13)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(239, 126)
        Me.Panel6.TabIndex = 7
        '
        'lbl_transactions
        '
        Me.lbl_transactions.AutoSize = True
        Me.lbl_transactions.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_transactions.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lbl_transactions.Location = New System.Drawing.Point(188, 90)
        Me.lbl_transactions.Name = "lbl_transactions"
        Me.lbl_transactions.Size = New System.Drawing.Size(21, 24)
        Me.lbl_transactions.TabIndex = 1
        Me.lbl_transactions.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(21, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Transactions"
        '
        'homeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "homeControl"
        Me.Size = New System.Drawing.Size(745, 461)
        Me.Panel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbl_revenue As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents lbl_categories As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_menu As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents lbl_employee As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbl_transactions As Label
    Friend WithEvents Label3 As Label
End Class
