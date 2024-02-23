Imports MySql.Data.MySqlClient

Public Class adminDashboard
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"

    Dim LogsControl As New logsControl
    Dim HomeControl As New homeControl
    Dim EmployeeControl As New EmployeeControl
    Dim CategoryControl As New categoryControl
    Dim MenuControl As New menuControl
    Dim ReportControl As New ReportControl
    ' Properties to store information about the logged-in admin
    Private _employeeId As String
    Public Property EmployeeId As String
        Get
            Return _employeeId
        End Get
        Set(value As String)
            _employeeId = value
        End Set
    End Property

    Private _employeeFirstName As String
    Public Property EmployeeFirstName As String
        Get
            Return _employeeFirstName
        End Get
        Set(value As String)
            _employeeFirstName = value
        End Set
    End Property

    Private _employeeLastName As String
    Public Property EmployeeLastName As String
        Get
            Return _employeeLastName
        End Get
        Set(value As String)
            _employeeLastName = value
        End Set
    End Property

    Private _employeeImage As Image
    Public Property EmployeeImage As Image
        Get
            Return _employeeImage
        End Get
        Set(value As Image)
            _employeeImage = value
        End Set
    End Property
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Update the 'logs' table with time_out
            UpdateLogoutTime(EmployeeId)

            Me.Close()
            Dim loginForm As New loginForm()
            loginForm.Show()
        End If
    End Sub
    Private Sub UpdateLogoutTime(employeeId As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Update 'logs' table with time_out for the current session
            Dim query As String = "UPDATE logs SET time_out = @TimeOut WHERE employee_id = @EmployeeId AND time_out IS NULL AND date = @Date"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployeeId", employeeId)
                command.Parameters.AddWithValue("@TimeOut", DateTime.Now.ToString("hh:mm tt")) ' 12-hour format
                command.Parameters.AddWithValue("@Date", DateTime.Now.Date)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub homeBtn_Click(sender As Object, e As EventArgs) Handles homeBtn.Click
        homeBtn.BackColor = Color.FromArgb(64, 64, 64)
        employeeBtn.BackColor = Color.Gray
        menuBtn.BackColor = Color.Gray
        categoriesBtn.BackColor = Color.Gray
        logsBtn.BackColor = Color.Gray
        reportBtn.BackColor = Color.Gray
        settingsBtn.BackColor = Color.Gray

        contentPanel.Controls.Clear()
        HomeControl.Dock = DockStyle.Fill
        contentPanel.Controls.Add(HomeControl)
    End Sub

    Private Sub employeeBtn_Click(sender As Object, e As EventArgs) Handles employeeBtn.Click
        homeBtn.BackColor = Color.Gray
        employeeBtn.BackColor = Color.FromArgb(64, 64, 64)
        menuBtn.BackColor = Color.Gray
        categoriesBtn.BackColor = Color.Gray
        logsBtn.BackColor = Color.Gray
        reportBtn.BackColor = Color.Gray
        settingsBtn.BackColor = Color.Gray

        contentPanel.Controls.Clear()
        EmployeeControl.Dock = DockStyle.Fill
        contentPanel.Controls.Add(EmployeeControl)
    End Sub

    Private Sub categoriesBtn_Click(sender As Object, e As EventArgs) Handles categoriesBtn.Click
        homeBtn.BackColor = Color.Gray
        employeeBtn.BackColor = Color.Gray
        menuBtn.BackColor = Color.Gray
        categoriesBtn.BackColor = Color.FromArgb(64, 64, 64)
        logsBtn.BackColor = Color.Gray
        reportBtn.BackColor = Color.Gray
        settingsBtn.BackColor = Color.Gray

        contentPanel.Controls.Clear()
        CategoryControl.Dock = DockStyle.Fill
        contentPanel.Controls.Add(CategoryControl)
    End Sub

    Private Sub menuBtn_Click(sender As Object, e As EventArgs) Handles menuBtn.Click
        homeBtn.BackColor = Color.Gray
        employeeBtn.BackColor = Color.Gray
        menuBtn.BackColor = Color.FromArgb(64, 64, 64)
        categoriesBtn.BackColor = Color.Gray
        logsBtn.BackColor = Color.Gray
        reportBtn.BackColor = Color.Gray
        settingsBtn.BackColor = Color.Gray

        contentPanel.Controls.Clear()
        MenuControl.Dock = DockStyle.Fill
        contentPanel.Controls.Add(MenuControl)
    End Sub

    Private Sub reportBtn_Click(sender As Object, e As EventArgs) Handles reportBtn.Click
        homeBtn.BackColor = Color.Gray
        employeeBtn.BackColor = Color.Gray
        menuBtn.BackColor = Color.Gray
        categoriesBtn.BackColor = Color.Gray
        logsBtn.BackColor = Color.Gray
        reportBtn.BackColor = Color.FromArgb(64, 64, 64)
        settingsBtn.BackColor = Color.Gray

        contentPanel.Controls.Clear()
        ReportControl.Dock = DockStyle.Fill
        contentPanel.Controls.Add(ReportControl)
    End Sub

    Private Sub logsBtn_Click(sender As Object, e As EventArgs) Handles logsBtn.Click
        homeBtn.BackColor = Color.Gray
        employeeBtn.BackColor = Color.Gray
        menuBtn.BackColor = Color.Gray
        categoriesBtn.BackColor = Color.Gray
        logsBtn.BackColor = Color.FromArgb(64, 64, 64)
        reportBtn.BackColor = Color.Gray
        settingsBtn.BackColor = Color.Gray

        contentPanel.Controls.Clear()
        LogsControl.Dock = DockStyle.Fill
        contentPanel.Controls.Add(LogsControl)
    End Sub
    Private Sub settingsBtn_Click(sender As Object, e As EventArgs) Handles settingsBtn.Click
        homeBtn.BackColor = Color.Gray
        employeeBtn.BackColor = Color.Gray
        menuBtn.BackColor = Color.Gray
        categoriesBtn.BackColor = Color.Gray
        logsBtn.BackColor = Color.Gray
        reportBtn.BackColor = Color.Gray
        settingsBtn.BackColor = Color.FromArgb(64, 64, 64)

        Dim changePasswordForm As New ChangePassword()
        changePasswordForm.EmployeeId = Me.EmployeeId
        changePasswordForm.ShowDialog()
    End Sub

    Private Sub adminDashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
        contentPanel.Controls.Clear()
        HomeControl.Dock = DockStyle.Fill
        contentPanel.Controls.Add(HomeControl)
        homeBtn.BackColor = Color.FromArgb(64, 64, 64)
    End Sub

End Class