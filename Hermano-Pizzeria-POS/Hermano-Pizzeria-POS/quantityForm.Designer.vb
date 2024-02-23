<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class quantityForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(quantityForm))
        Me.decreaseBtn = New System.Windows.Forms.Button()
        Me.increaseBtn = New System.Windows.Forms.Button()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.tbQuantity = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'decreaseBtn
        '
        Me.decreaseBtn.BackColor = System.Drawing.Color.Tomato
        Me.decreaseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.decreaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.decreaseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.decreaseBtn.ForeColor = System.Drawing.Color.White
        Me.decreaseBtn.Image = CType(resources.GetObject("decreaseBtn.Image"), System.Drawing.Image)
        Me.decreaseBtn.Location = New System.Drawing.Point(45, 68)
        Me.decreaseBtn.Name = "decreaseBtn"
        Me.decreaseBtn.Size = New System.Drawing.Size(80, 80)
        Me.decreaseBtn.TabIndex = 4
        Me.decreaseBtn.UseVisualStyleBackColor = False
        '
        'increaseBtn
        '
        Me.increaseBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.increaseBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.increaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.increaseBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.increaseBtn.ForeColor = System.Drawing.Color.White
        Me.increaseBtn.Image = CType(resources.GetObject("increaseBtn.Image"), System.Drawing.Image)
        Me.increaseBtn.Location = New System.Drawing.Point(402, 68)
        Me.increaseBtn.Name = "increaseBtn"
        Me.increaseBtn.Size = New System.Drawing.Size(80, 80)
        Me.increaseBtn.TabIndex = 3
        Me.increaseBtn.UseVisualStyleBackColor = False
        '
        'confirmBtn
        '
        Me.confirmBtn.BackColor = System.Drawing.Color.CornflowerBlue
        Me.confirmBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.confirmBtn.Location = New System.Drawing.Point(184, 212)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(171, 58)
        Me.confirmBtn.TabIndex = 2
        Me.confirmBtn.Text = "CONFIRM"
        Me.confirmBtn.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.Panel1.Controls.Add(Me.tbQuantity)
        Me.Panel1.Location = New System.Drawing.Point(184, 58)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(171, 106)
        Me.Panel1.TabIndex = 9
        '
        'tbQuantity
        '
        Me.tbQuantity.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.tbQuantity.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbQuantity.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.tbQuantity.Location = New System.Drawing.Point(21, 17)
        Me.tbQuantity.Name = "tbQuantity"
        Me.tbQuantity.Size = New System.Drawing.Size(127, 73)
        Me.tbQuantity.TabIndex = 1
        Me.tbQuantity.Text = "1"
        Me.tbQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'quantityForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(529, 295)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.confirmBtn)
        Me.Controls.Add(Me.decreaseBtn)
        Me.Controls.Add(Me.increaseBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "quantityForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "quantityForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents increaseBtn As Button
    Friend WithEvents decreaseBtn As Button
    Friend WithEvents confirmBtn As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents tbQuantity As TextBox
End Class
