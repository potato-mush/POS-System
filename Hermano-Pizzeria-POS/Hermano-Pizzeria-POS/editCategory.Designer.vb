<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class editCategory
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(editCategory))
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.headerText = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.saveBtn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCategoryNameEdit = New System.Windows.Forms.TextBox()
        Me.Panel3.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Crimson
        Me.cancelBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cancelBtn.FlatAppearance.BorderSize = 0
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.cancelBtn.Location = New System.Drawing.Point(276, 184)
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
        Me.headerText.Size = New System.Drawing.Size(185, 24)
        Me.headerText.TabIndex = 1
        Me.headerText.Text = "EDIT CATEGORY"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGray
        Me.Panel3.Controls.Add(Me.PictureBox3)
        Me.Panel3.Controls.Add(Me.headerText)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(529, 58)
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
        'saveBtn
        '
        Me.saveBtn.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.saveBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.saveBtn.FlatAppearance.BorderSize = 0
        Me.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.saveBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.saveBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.saveBtn.Location = New System.Drawing.Point(128, 184)
        Me.saveBtn.Name = "saveBtn"
        Me.saveBtn.Size = New System.Drawing.Size(123, 42)
        Me.saveBtn.TabIndex = 36
        Me.saveBtn.Text = "SAVE"
        Me.saveBtn.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(127, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 16)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Category Name"
        '
        'tbCategoryNameEdit
        '
        Me.tbCategoryNameEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCategoryNameEdit.Location = New System.Drawing.Point(130, 130)
        Me.tbCategoryNameEdit.Name = "tbCategoryNameEdit"
        Me.tbCategoryNameEdit.Size = New System.Drawing.Size(271, 24)
        Me.tbCategoryNameEdit.TabIndex = 39
        '
        'editCategory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 250)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tbCategoryNameEdit)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.saveBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "editCategory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "editCategory"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cancelBtn As Button
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents headerText As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents saveBtn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCategoryNameEdit As TextBox
End Class
