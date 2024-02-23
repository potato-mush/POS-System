<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class paymentForm
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbReceivedAmount = New System.Windows.Forms.TextBox()
        Me.confirmBtn = New System.Windows.Forms.Button()
        Me.cancelBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.tbChange = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.rbWithoutDiscount = New System.Windows.Forms.RadioButton()
        Me.rbDiscounted = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbl_grandTotal = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.tbReceivedAmount)
        Me.Panel1.Location = New System.Drawing.Point(70, 240)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(576, 73)
        Me.Panel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(27, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 39)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "₱"
        '
        'tbReceivedAmount
        '
        Me.tbReceivedAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.tbReceivedAmount.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbReceivedAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbReceivedAmount.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbReceivedAmount.Location = New System.Drawing.Point(87, 20)
        Me.tbReceivedAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.tbReceivedAmount.Name = "tbReceivedAmount"
        Me.tbReceivedAmount.Size = New System.Drawing.Size(455, 34)
        Me.tbReceivedAmount.TabIndex = 0
        Me.tbReceivedAmount.Text = "0.00"
        '
        'confirmBtn
        '
        Me.confirmBtn.BackColor = System.Drawing.Color.YellowGreen
        Me.confirmBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.confirmBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.confirmBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.confirmBtn.ForeColor = System.Drawing.Color.White
        Me.confirmBtn.Location = New System.Drawing.Point(70, 609)
        Me.confirmBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.confirmBtn.Name = "confirmBtn"
        Me.confirmBtn.Size = New System.Drawing.Size(259, 71)
        Me.confirmBtn.TabIndex = 5
        Me.confirmBtn.Text = "CONFIRM"
        Me.confirmBtn.UseVisualStyleBackColor = False
        '
        'cancelBtn
        '
        Me.cancelBtn.BackColor = System.Drawing.Color.Tomato
        Me.cancelBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cancelBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cancelBtn.ForeColor = System.Drawing.Color.White
        Me.cancelBtn.Location = New System.Drawing.Point(387, 609)
        Me.cancelBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.cancelBtn.Name = "cancelBtn"
        Me.cancelBtn.Size = New System.Drawing.Size(259, 71)
        Me.cancelBtn.TabIndex = 6
        Me.cancelBtn.Text = "CANCEL"
        Me.cancelBtn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(65, 188)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(194, 25)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Received Amount :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(65, 343)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 25)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Discount :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(65, 458)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 25)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Change :"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel3.Controls.Add(Me.tbChange)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(70, 510)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(576, 73)
        Me.Panel3.TabIndex = 13
        '
        'tbChange
        '
        Me.tbChange.AutoSize = True
        Me.tbChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbChange.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tbChange.Location = New System.Drawing.Point(80, 20)
        Me.tbChange.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.tbChange.Name = "tbChange"
        Me.tbChange.Size = New System.Drawing.Size(74, 36)
        Me.tbChange.TabIndex = 17
        Me.tbChange.Text = "0.00"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(27, 16)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 39)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "₱"
        '
        'rbWithoutDiscount
        '
        Me.rbWithoutDiscount.AutoSize = True
        Me.rbWithoutDiscount.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbWithoutDiscount.ForeColor = System.Drawing.Color.Orange
        Me.rbWithoutDiscount.Location = New System.Drawing.Point(77, 390)
        Me.rbWithoutDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.rbWithoutDiscount.Name = "rbWithoutDiscount"
        Me.rbWithoutDiscount.Size = New System.Drawing.Size(263, 36)
        Me.rbWithoutDiscount.TabIndex = 15
        Me.rbWithoutDiscount.TabStop = True
        Me.rbWithoutDiscount.Text = "Without Discount"
        Me.rbWithoutDiscount.UseVisualStyleBackColor = True
        '
        'rbDiscounted
        '
        Me.rbDiscounted.AutoSize = True
        Me.rbDiscounted.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold)
        Me.rbDiscounted.ForeColor = System.Drawing.Color.Orange
        Me.rbDiscounted.Location = New System.Drawing.Point(426, 390)
        Me.rbDiscounted.Margin = New System.Windows.Forms.Padding(4)
        Me.rbDiscounted.Name = "rbDiscounted"
        Me.rbDiscounted.Size = New System.Drawing.Size(220, 36)
        Me.rbDiscounted.TabIndex = 16
        Me.rbDiscounted.TabStop = True
        Me.rbDiscounted.Text = "With Discount"
        Me.rbDiscounted.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(65, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 25)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Grand Total :"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(80, Byte), Integer))
        Me.Panel2.Controls.Add(Me.lbl_grandTotal)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Location = New System.Drawing.Point(70, 82)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(576, 73)
        Me.Panel2.TabIndex = 17
        '
        'lbl_grandTotal
        '
        Me.lbl_grandTotal.AutoSize = True
        Me.lbl_grandTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_grandTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lbl_grandTotal.Location = New System.Drawing.Point(80, 20)
        Me.lbl_grandTotal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_grandTotal.Name = "lbl_grandTotal"
        Me.lbl_grandTotal.Size = New System.Drawing.Size(74, 36)
        Me.lbl_grandTotal.TabIndex = 17
        Me.lbl_grandTotal.Text = "0.00"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(27, 16)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 39)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "₱"
        '
        'paymentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(60, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(721, 725)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.rbDiscounted)
        Me.Controls.Add(Me.rbWithoutDiscount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cancelBtn)
        Me.Controls.Add(Me.confirmBtn)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "paymentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "paymentForm"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents confirmBtn As Button
    Friend WithEvents cancelBtn As Button
    Friend WithEvents tbReceivedAmount As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tbChange As Label
    Friend WithEvents rbWithoutDiscount As RadioButton
    Friend WithEvents rbDiscounted As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbl_grandTotal As Label
    Friend WithEvents Label8 As Label
End Class
