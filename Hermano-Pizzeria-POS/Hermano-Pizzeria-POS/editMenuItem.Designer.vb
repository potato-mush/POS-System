﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editMenuItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editMenuItem))
        Me.headerText = New System.Windows.Forms.Label()
        Me.cbProductCategoryEdit = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbProductPriceEdit = New System.Windows.Forms.TextBox()
        Me.cbProductStatusEdit = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbProductDescriptionEdit = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbProductNameEdit = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.pbProductImageEdit = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbItemSizeEdit = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbProductImageEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'headerText
        '
        Me.headerText.AutoSize = True
        Me.headerText.Font = New System.Drawing.Font("Arial Rounded MT Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.headerText.Location = New System.Drawing.Point(60, 17)
        Me.headerText.Name = "headerText"
        Me.headerText.Size = New System.Drawing.Size(184, 24)
        Me.headerText.TabIndex = 1
        Me.headerText.Text = "EDIT MENU ITEM"
        '
        'cbProductCategoryEdit
        '
        Me.cbProductCategoryEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProductCategoryEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProductCategoryEdit.FormattingEnabled = True
        Me.cbProductCategoryEdit.Location = New System.Drawing.Point(172, 312)
        Me.cbProductCategoryEdit.Name = "cbProductCategoryEdit"
        Me.cbProductCategoryEdit.Size = New System.Drawing.Size(339, 26)
        Me.cbProductCategoryEdit.TabIndex = 69
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(348, 421)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 16)
        Me.Label8.TabIndex = 68
        Me.Label8.Text = "Price"
        '
        'tbProductPriceEdit
        '
        Me.tbProductPriceEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProductPriceEdit.Location = New System.Drawing.Point(351, 450)
        Me.tbProductPriceEdit.Name = "tbProductPriceEdit"
        Me.tbProductPriceEdit.Size = New System.Drawing.Size(160, 24)
        Me.tbProductPriceEdit.TabIndex = 67
        '
        'cbProductStatusEdit
        '
        Me.cbProductStatusEdit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbProductStatusEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbProductStatusEdit.FormattingEnabled = True
        Me.cbProductStatusEdit.Items.AddRange(New Object() {"AVAILABLE", "NOT AVAILABLE"})
        Me.cbProductStatusEdit.Location = New System.Drawing.Point(172, 448)
        Me.cbProductStatusEdit.Name = "cbProductStatusEdit"
        Me.cbProductStatusEdit.Size = New System.Drawing.Size(160, 26)
        Me.cbProductStatusEdit.TabIndex = 66
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(169, 421)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 16)
        Me.Label7.TabIndex = 65
        Me.Label7.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(169, 284)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 16)
        Me.Label6.TabIndex = 64
        Me.Label6.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(169, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 16)
        Me.Label4.TabIndex = 63
        Me.Label4.Text = "Description"
        '
        'tbProductDescriptionEdit
        '
        Me.tbProductDescriptionEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProductDescriptionEdit.Location = New System.Drawing.Point(172, 189)
        Me.tbProductDescriptionEdit.Multiline = True
        Me.tbProductDescriptionEdit.Name = "tbProductDescriptionEdit"
        Me.tbProductDescriptionEdit.Size = New System.Drawing.Size(339, 79)
        Me.tbProductDescriptionEdit.TabIndex = 62
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(169, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 16)
        Me.Label2.TabIndex = 61
        Me.Label2.Text = "Item Name"
        '
        'tbProductNameEdit
        '
        Me.tbProductNameEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbProductNameEdit.Location = New System.Drawing.Point(172, 123)
        Me.tbProductNameEdit.Name = "tbProductNameEdit"
        Me.tbProductNameEdit.Size = New System.Drawing.Size(339, 24)
        Me.tbProductNameEdit.TabIndex = 60
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 202)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 59
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
        Me.cancelBtn.TabIndex = 57
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.UseVisualStyleBackColor = False
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
        Me.Panel3.TabIndex = 56
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
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveBtn.FlatAppearance.BorderSize = 0
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.saveBtn.Location = New System.Drawing.Point(203, 507)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(123, 42)
        Me.saveBtn.TabIndex = 55
        Me.saveBtn.Text = "SAVE"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'pbProductImageEdit
        '
        Me.pbProductImageEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbProductImageEdit.Image = Global.Hermano_Pizzeria_POS.My.Resources.Resources.defaultImage
        Me.pbProductImageEdit.Location = New System.Drawing.Point(27, 94)
        Me.pbProductImageEdit.Name = "pbProductImageEdit"
        Me.pbProductImageEdit.Size = New System.Drawing.Size(100, 100)
        Me.pbProductImageEdit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbProductImageEdit.TabIndex = 58
        Me.pbProductImageEdit.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(169, 357)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 16)
        Me.Label3.TabIndex = 71
        Me.Label3.Text = "Size (Optional)"
        '
        'tbItemSizeEdit
        '
        Me.tbItemSizeEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbItemSizeEdit.Location = New System.Drawing.Point(172, 386)
        Me.tbItemSizeEdit.Name = "tbItemSizeEdit"
        Me.tbItemSizeEdit.Size = New System.Drawing.Size(339, 24)
        Me.tbItemSizeEdit.TabIndex = 70
        '
        'editMenuItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 573)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbItemSizeEdit)
        Me.Controls.Add(Me.cbProductCategoryEdit)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.tbProductPriceEdit)
        Me.Controls.Add(Me.cbProductStatusEdit)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbProductDescriptionEdit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbProductNameEdit)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.pbProductImageEdit)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.saveBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editMenuItem"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editMenuItemForm"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbProductImageEdit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents headerText As Label
    Friend WithEvents cbProductCategoryEdit As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents tbProductPriceEdit As TextBox
    Friend WithEvents cbProductStatusEdit As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbProductDescriptionEdit As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbProductNameEdit As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cancelBtn As Button
    Friend WithEvents pbProductImageEdit As PictureBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents saveBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents tbItemSizeEdit As TextBox
End Class
