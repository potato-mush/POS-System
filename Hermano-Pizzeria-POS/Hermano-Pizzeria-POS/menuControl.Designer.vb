<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class menuControl
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(menuControl))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.menuData = New System.Windows.Forms.DataGridView()
        Me.lblPageNumber = New System.Windows.Forms.Label()
        Me.btnLastPage = New System.Windows.Forms.Button()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.btnPrevPage = New System.Windows.Forms.Button()
        Me.btnFirstPage = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.tbSearchMenu = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.removeBtn = New System.Windows.Forms.Button()
        Me.editBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.product_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_name = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_category = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_image = New System.Windows.Forms.DataGridViewImageColumn()
        Me.product_status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.product_size = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.menuData, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel8.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'menuData
        '
        Me.menuData.AllowUserToAddRows = False
        Me.menuData.AllowUserToDeleteRows = False
        Me.menuData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.menuData.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.menuData.ColumnHeadersHeight = 60
        Me.menuData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.menuData.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.product_id, Me.product_name, Me.product_description, Me.product_category, Me.product_price, Me.product_image, Me.product_status, Me.product_size})
        Me.menuData.Dock = System.Windows.Forms.DockStyle.Fill
        Me.menuData.Location = New System.Drawing.Point(0, 0)
        Me.menuData.Name = "menuData"
        Me.menuData.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.menuData.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.menuData.RowHeadersVisible = False
        Me.menuData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuData.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.menuData.RowTemplate.Height = 100
        Me.menuData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.menuData.Size = New System.Drawing.Size(1089, 285)
        Me.menuData.TabIndex = 0
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel7)
        Me.Panel2.Controls.Add(Me.menuData)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 176)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1089, 285)
        Me.Panel2.TabIndex = 3
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
        'tbSearchMenu
        '
        Me.tbSearchMenu.BackColor = System.Drawing.Color.White
        Me.tbSearchMenu.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbSearchMenu.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSearchMenu.Location = New System.Drawing.Point(51, 13)
        Me.tbSearchMenu.Name = "tbSearchMenu"
        Me.tbSearchMenu.Size = New System.Drawing.Size(337, 19)
        Me.tbSearchMenu.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.Controls.Add(Me.tbSearchMenu)
        Me.Panel5.Controls.Add(Me.PictureBox1)
        Me.Panel5.Location = New System.Drawing.Point(214, 13)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Padding = New System.Windows.Forms.Padding(8)
        Me.Panel5.Size = New System.Drawing.Size(409, 44)
        Me.Panel5.TabIndex = 0
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Controls.Add(Me.addBtn)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(646, 83)
        Me.Panel4.TabIndex = 1
        '
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.FlatAppearance.BorderSize = 0
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addBtn.Image = CType(resources.GetObject("addBtn.Image"), System.Drawing.Image)
        Me.addBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.addBtn.Location = New System.Drawing.Point(14, 13)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Padding = New System.Windows.Forms.Padding(10, 0, 10, 0)
        Me.addBtn.Size = New System.Drawing.Size(157, 44)
        Me.addBtn.TabIndex = 0
        Me.addBtn.Text = "Add Menu"
        Me.addBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.addBtn.UseVisualStyleBackColor = False
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1089, 176)
        Me.Panel1.TabIndex = 2
        '
        'product_id
        '
        Me.product_id.DataPropertyName = "product_id"
        Me.product_id.HeaderText = "Product ID"
        Me.product_id.Name = "product_id"
        Me.product_id.ReadOnly = True
        '
        'product_name
        '
        Me.product_name.DataPropertyName = "product_name"
        Me.product_name.HeaderText = "Product Name"
        Me.product_name.Name = "product_name"
        Me.product_name.ReadOnly = True
        '
        'product_description
        '
        Me.product_description.DataPropertyName = "product_description"
        Me.product_description.HeaderText = "Description"
        Me.product_description.Name = "product_description"
        Me.product_description.ReadOnly = True
        '
        'product_category
        '
        Me.product_category.DataPropertyName = "product_category"
        Me.product_category.HeaderText = "Category"
        Me.product_category.Name = "product_category"
        Me.product_category.ReadOnly = True
        '
        'product_price
        '
        Me.product_price.DataPropertyName = "product_price"
        DataGridViewCellStyle2.Format = "₱00.00"
        Me.product_price.DefaultCellStyle = DataGridViewCellStyle2
        Me.product_price.HeaderText = "Price"
        Me.product_price.Name = "product_price"
        Me.product_price.ReadOnly = True
        '
        'product_image
        '
        Me.product_image.DataPropertyName = "product_image"
        Me.product_image.HeaderText = "Image"
        Me.product_image.Name = "product_image"
        Me.product_image.ReadOnly = True
        Me.product_image.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.product_image.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'product_status
        '
        Me.product_status.DataPropertyName = "product_status"
        Me.product_status.HeaderText = "Status"
        Me.product_status.Name = "product_status"
        Me.product_status.ReadOnly = True
        '
        'product_size
        '
        Me.product_size.DataPropertyName = "product_size"
        Me.product_size.HeaderText = "Size"
        Me.product_size.Name = "product_size"
        Me.product_size.ReadOnly = True
        '
        'menuControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "menuControl"
        Me.Size = New System.Drawing.Size(1089, 461)
        CType(Me.menuData, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents menuData As DataGridView
    Friend WithEvents lblPageNumber As Label
    Friend WithEvents btnLastPage As Button
    Friend WithEvents btnNextPage As Button
    Friend WithEvents btnPrevPage As Button
    Friend WithEvents btnFirstPage As Button
    Friend WithEvents Panel8 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents addBtn As Button
    Friend WithEvents tbSearchMenu As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents removeBtn As Button
    Friend WithEvents editBtn As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents product_id As DataGridViewTextBoxColumn
    Friend WithEvents product_name As DataGridViewTextBoxColumn
    Friend WithEvents product_description As DataGridViewTextBoxColumn
    Friend WithEvents product_category As DataGridViewTextBoxColumn
    Friend WithEvents product_price As DataGridViewTextBoxColumn
    Friend WithEvents product_image As DataGridViewImageColumn
    Friend WithEvents product_status As DataGridViewTextBoxColumn
    Friend WithEvents product_size As DataGridViewTextBoxColumn
End Class
