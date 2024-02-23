<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class adminDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(adminDashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.logoutBtn = New System.Windows.Forms.PictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logsBtn = New System.Windows.Forms.Button()
        Me.reportBtn = New System.Windows.Forms.Button()
        Me.categoriesBtn = New System.Windows.Forms.Button()
        Me.menuBtn = New System.Windows.Forms.Button()
        Me.employeeBtn = New System.Windows.Forms.Button()
        Me.homeBtn = New System.Windows.Forms.Button()
        Me.contentPanel = New System.Windows.Forms.Panel()
        Me.settingsBtn = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.logoutBtn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1102, 70)
        Me.Panel1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.logoutBtn)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1047, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(55, 70)
        Me.Panel3.TabIndex = 10
        '
        'logoutBtn
        '
        Me.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logoutBtn.Image = CType(resources.GetObject("logoutBtn.Image"), System.Drawing.Image)
        Me.logoutBtn.Location = New System.Drawing.Point(18, 23)
        Me.logoutBtn.Name = "logoutBtn"
        Me.logoutBtn.Size = New System.Drawing.Size(25, 25)
        Me.logoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.logoutBtn.TabIndex = 0
        Me.logoutBtn.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(81, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(156, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Dashboard"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 9)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(50, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.settingsBtn)
        Me.Panel2.Controls.Add(Me.logsBtn)
        Me.Panel2.Controls.Add(Me.reportBtn)
        Me.Panel2.Controls.Add(Me.categoriesBtn)
        Me.Panel2.Controls.Add(Me.menuBtn)
        Me.Panel2.Controls.Add(Me.employeeBtn)
        Me.Panel2.Controls.Add(Me.homeBtn)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 70)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(213, 545)
        Me.Panel2.TabIndex = 1
        '
        'logsBtn
        '
        Me.logsBtn.BackColor = System.Drawing.Color.Gray
        Me.logsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.logsBtn.FlatAppearance.BorderSize = 0
        Me.logsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.logsBtn.Image = CType(resources.GetObject("logsBtn.Image"), System.Drawing.Image)
        Me.logsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.logsBtn.Location = New System.Drawing.Point(0, 315)
        Me.logsBtn.Name = "logsBtn"
        Me.logsBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.logsBtn.Size = New System.Drawing.Size(213, 63)
        Me.logsBtn.TabIndex = 5
        Me.logsBtn.Text = "Logs"
        Me.logsBtn.UseVisualStyleBackColor = False
        '
        'reportBtn
        '
        Me.reportBtn.BackColor = System.Drawing.Color.Gray
        Me.reportBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.reportBtn.FlatAppearance.BorderSize = 0
        Me.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.reportBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reportBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.reportBtn.Image = CType(resources.GetObject("reportBtn.Image"), System.Drawing.Image)
        Me.reportBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.reportBtn.Location = New System.Drawing.Point(0, 252)
        Me.reportBtn.Name = "reportBtn"
        Me.reportBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.reportBtn.Size = New System.Drawing.Size(213, 63)
        Me.reportBtn.TabIndex = 4
        Me.reportBtn.Text = "Report"
        Me.reportBtn.UseVisualStyleBackColor = False
        '
        'categoriesBtn
        '
        Me.categoriesBtn.BackColor = System.Drawing.Color.Gray
        Me.categoriesBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.categoriesBtn.FlatAppearance.BorderSize = 0
        Me.categoriesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.categoriesBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.categoriesBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.categoriesBtn.Image = CType(resources.GetObject("categoriesBtn.Image"), System.Drawing.Image)
        Me.categoriesBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.categoriesBtn.Location = New System.Drawing.Point(0, 189)
        Me.categoriesBtn.Name = "categoriesBtn"
        Me.categoriesBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.categoriesBtn.Size = New System.Drawing.Size(213, 63)
        Me.categoriesBtn.TabIndex = 3
        Me.categoriesBtn.Text = "Categories"
        Me.categoriesBtn.UseVisualStyleBackColor = False
        '
        'menuBtn
        '
        Me.menuBtn.BackColor = System.Drawing.Color.Gray
        Me.menuBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.menuBtn.FlatAppearance.BorderSize = 0
        Me.menuBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menuBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.menuBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.menuBtn.Image = CType(resources.GetObject("menuBtn.Image"), System.Drawing.Image)
        Me.menuBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.menuBtn.Location = New System.Drawing.Point(0, 126)
        Me.menuBtn.Name = "menuBtn"
        Me.menuBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.menuBtn.Size = New System.Drawing.Size(213, 63)
        Me.menuBtn.TabIndex = 2
        Me.menuBtn.Text = "Menu"
        Me.menuBtn.UseVisualStyleBackColor = False
        '
        'employeeBtn
        '
        Me.employeeBtn.BackColor = System.Drawing.Color.Gray
        Me.employeeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.employeeBtn.FlatAppearance.BorderSize = 0
        Me.employeeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.employeeBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.employeeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.employeeBtn.Image = CType(resources.GetObject("employeeBtn.Image"), System.Drawing.Image)
        Me.employeeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.employeeBtn.Location = New System.Drawing.Point(0, 63)
        Me.employeeBtn.Name = "employeeBtn"
        Me.employeeBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.employeeBtn.Size = New System.Drawing.Size(213, 63)
        Me.employeeBtn.TabIndex = 1
        Me.employeeBtn.Text = "Employee"
        Me.employeeBtn.UseVisualStyleBackColor = False
        '
        'homeBtn
        '
        Me.homeBtn.BackColor = System.Drawing.Color.Gray
        Me.homeBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.homeBtn.FlatAppearance.BorderSize = 0
        Me.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.homeBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.homeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.homeBtn.Image = CType(resources.GetObject("homeBtn.Image"), System.Drawing.Image)
        Me.homeBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.homeBtn.Location = New System.Drawing.Point(0, 0)
        Me.homeBtn.Name = "homeBtn"
        Me.homeBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.homeBtn.Size = New System.Drawing.Size(213, 63)
        Me.homeBtn.TabIndex = 0
        Me.homeBtn.Text = "Home"
        Me.homeBtn.UseVisualStyleBackColor = False
        '
        'contentPanel
        '
        Me.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.contentPanel.Location = New System.Drawing.Point(213, 70)
        Me.contentPanel.Name = "contentPanel"
        Me.contentPanel.Size = New System.Drawing.Size(889, 545)
        Me.contentPanel.TabIndex = 2
        '
        'settingsBtn
        '
        Me.settingsBtn.BackColor = System.Drawing.Color.Gray
        Me.settingsBtn.Dock = System.Windows.Forms.DockStyle.Top
        Me.settingsBtn.FlatAppearance.BorderSize = 0
        Me.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.settingsBtn.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.settingsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.settingsBtn.Image = CType(resources.GetObject("settingsBtn.Image"), System.Drawing.Image)
        Me.settingsBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.settingsBtn.Location = New System.Drawing.Point(0, 378)
        Me.settingsBtn.Name = "settingsBtn"
        Me.settingsBtn.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.settingsBtn.Size = New System.Drawing.Size(213, 63)
        Me.settingsBtn.TabIndex = 6
        Me.settingsBtn.Text = "Settings"
        Me.settingsBtn.UseVisualStyleBackColor = False
        '
        'adminDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 615)
        Me.Controls.Add(Me.contentPanel)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "adminDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "adminDashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.logoutBtn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents contentPanel As Panel
    Friend WithEvents homeBtn As Button
    Friend WithEvents categoriesBtn As Button
    Friend WithEvents menuBtn As Button
    Friend WithEvents employeeBtn As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents reportBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents logoutBtn As PictureBox
    Friend WithEvents logsBtn As Button
    Friend WithEvents settingsBtn As Button
End Class
