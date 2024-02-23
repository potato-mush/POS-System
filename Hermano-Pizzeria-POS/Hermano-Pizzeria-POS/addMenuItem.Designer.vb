<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addMenuItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(addMenuItem))
        Me.cbProductCategory = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbProductPrice = New System.Windows.Forms.TextBox()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbProductDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbProductName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.headerText = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.addBtn = New System.Windows.Forms.Button()
        Me.pbProductImage = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbItemSize = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProductImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbProductCategory
        '
        Me.cbProductCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProductCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProductCategory.FormattingEnabled = True
        Me.cbProductCategory.Location = New System.Drawing.Point(172, 312)
        Me.cbProductCategory.Name = "cbProductCategory"
        Me.cbProductCategory.Size = New System.Drawing.Size(339, 26)
        Me.cbProductCategory.TabIndex = 54
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(348, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Price"
        '
        'tbProductPrice
        '
        Me.tbProductPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProductPrice.Location = New System.Drawing.Point(351, 450)
        Me.tbProductPrice.Name = "tbProductPrice"
        Me.tbProductPrice.Size = New System.Drawing.Size(160, 24)
        Me.tbProductPrice.TabIndex = 52
        '
        'cbStatus
        '
        Me.cbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        Me.cbStatus.Location = New System.Drawing.Point(172, 448)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(160, 26)
        Me.cbStatus.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 421)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(169, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Description"
        '
        'tbProductDescription
        '
        Me.tbProductDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProductDescription.Location = New System.Drawing.Point(172, 189)
        Me.tbProductDescription.Multiline = True
        Me.tbProductDescription.Name = "tbProductDescription"
        Me.tbProductDescription.Size = New System.Drawing.Size(339, 79)
        Me.tbProductDescription.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Item Name"
        '
        'tbProductName
        '
        Me.tbProductName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProductName.Location = New System.Drawing.Point(172, 123)
        Me.tbProductName.Name = "tbProductName"
        Me.tbProductName.Size = New System.Drawing.Size(339, 24)
        Me.tbProductName.TabIndex = 41
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
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Crimson
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.FlatAppearance.BorderSize = 0
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cancelBtn.Location = New System.Drawing.Point(351, 507)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(123, 42)
        Me.cancelBtn.TabIndex = 38
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'headerText
        '
        Me.headerText.AutoSize = True
        Me.headerText.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerText.Location = New System.Drawing.Point(60, 17)
        Me.headerText.Name = "headerText"
        Me.headerText.Size = New System.Drawing.Size(181, 24)
        Me.headerText.TabIndex = 1
        Me.headerText.Text = "ADD MENU ITEM"
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
        'addBtn
        '
        Me.addBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.addBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.addBtn.FlatAppearance.BorderSize = 0
        Me.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.addBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.addBtn.Location = New System.Drawing.Point(203, 507)
        Me.addBtn.Name = "addBtn"
        Me.addBtn.Size = New System.Drawing.Size(123, 42)
        Me.addBtn.TabIndex = 36
        Me.addBtn.Text = "ADD"
        Me.addBtn.UseVisualStyleBackColor = False
        '
        'pbProductImage
        '
        Me.pbProductImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbProductImage.Image = Global.Hermano_Pizzeria_POS.My.Resources.Resources.defaultImage
        Me.pbProductImage.Location = New System.Drawing.Point(27, 94)
        Me.pbProductImage.Name = "pbProductImage"
        Me.pbProductImage.Size = New System.Drawing.Size(100, 100)
        Me.pbProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProductImage.TabIndex = 39
        Me.pbProductImage.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Size (Optional)"
        '
        'tbItemSize
        '
        Me.tbItemSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbItemSize.Location = New System.Drawing.Point(172, 386)
        Me.tbItemSize.Name = "tbItemSize"
        Me.tbItemSize.Size = New System.Drawing.Size(339, 24)
        Me.tbItemSize.TabIndex = 55
        '
        'addMenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 573)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbItemSize)
        Me.Controls.Add(Me.cbProductCategory)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbProductPrice)
        Me.Controls.Add(Me.cbStatus)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbProductDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbProductName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.pbProductImage)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.addBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "addMenuItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "addMenuItemForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProductImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents cbProductCategory As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbProductPrice As TextBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbProductDescription As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbProductName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cancelBtn As Button
    Friend WithEvents headerText As Label
    Friend WithEvents pbProductImage As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents addBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbItemSize As TextBox
End Class
