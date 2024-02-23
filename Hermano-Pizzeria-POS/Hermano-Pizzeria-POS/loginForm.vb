Imports System
Imports System.IO
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class loginForm
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"

    Private Sub tbEmployeeId_Enter(sender As Object, e As EventArgs) Handles tbEmployeeId.Enter
        If tbEmployeeId.Text = "Employee ID" Then
            tbEmployeeId.ForeColor = Color.Black
            tbEmployeeId.Text = ""
        End If
    End Sub

    Private Sub tbEmployeeId_Leave(sender As Object, e As EventArgs) Handles tbEmployeeId.Leave
        If tbEmployeeId.Text = "" Then
            tbEmployeeId.Text = "Employee ID"
            tbEmployeeId.ForeColor = Color.Silver
        End If
    End Sub

    Private Sub tbPassword_Enter(sender As Object, e As EventArgs) Handles tbPassword.Enter
        If tbPassword.Text = "Password" Then
            tbPassword.Text = ""
            tbPassword.ForeColor = Color.Black
            tbPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub tbPassword_Leave(sender As Object, e As EventArgs) Handles tbPassword.Leave
        If tbPassword.Text = "" Then
            tbPassword.Text = "Password"
            tbPassword.ForeColor = Color.Silver
            tbPassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        Dim employeeId As String = tbEmployeeId.Text
        Dim password As String = tbPassword.Text

        Dim authResult As Tuple(Of Boolean, String, String, String, Image) = AuthenticateEmployee(employeeId, password)

        If authResult.Item1 Then
            If IsCashier(authResult.Item4) OrElse IsAdmin(authResult.Item4) Then
                ' Employee is a cashier or admin
                MessageBox.Show("Login successful!")

                ' Set the properties in the corresponding dashboard
                If IsCashier(authResult.Item4) Then
                    employeeDashboard.EmployeeId = employeeId
                    employeeDashboard.EmployeeFirstName = authResult.Item2
                    employeeDashboard.EmployeeLastName = authResult.Item3
                    employeeDashboard.EmployeeImage = authResult.Item5

                    Me.Hide()
                    employeeDashboard.Show()
                ElseIf IsAdmin(authResult.Item4) Then
                    adminDashboard.EmployeeId = employeeId
                    adminDashboard.EmployeeFirstName = authResult.Item2
                    adminDashboard.EmployeeLastName = authResult.Item3
                    adminDashboard.EmployeeImage = authResult.Item5

                    Me.Hide()
                    adminDashboard.Show()
                End If

                ' Insert data into 'logs' table
                InsertLog(employeeId, $"{authResult.Item2} {authResult.Item3}", authResult.Item4)

                ' Reset textboxes
                tbEmployeeId.Text = "Employee ID"
                tbEmployeeId.ForeColor = Color.Silver
                tbPassword.Text = "Password"
                tbPassword.ForeColor = Color.Silver
                tbPassword.UseSystemPasswordChar = False
            Else
                ' Employee has an unrecognized position
                MessageBox.Show("Invalid employee position. Please contact your administrator.")
            End If
        Else
            ' Employee authentication failed
            MessageBox.Show("Invalid employee ID or password. Please try again.")
        End If
    End Sub

    Private Sub InsertLog(employeeId As String, employeeName As String, position As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Insert data into 'logs' table
            Dim query As String = "INSERT INTO logs (employee_id, employee_name, employee_position, time_in, date) VALUES (@EmployeeId, @EmployeeName, @EmployeePosition, @TimeIn, @Date)"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployeeId", employeeId)
                command.Parameters.AddWithValue("@EmployeeName", employeeName)
                command.Parameters.AddWithValue("@EmployeePosition", position)
                command.Parameters.AddWithValue("@TimeIn", DateTime.Now.ToString("hh:mm tt")) ' 12-hour format
                command.Parameters.AddWithValue("@Date", DateTime.Now.Date)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    ' Function to check if the employee is a cashier
    Private Function IsCashier(position As String) As Boolean
        Return String.Equals(position.Trim(), "CASHIER", StringComparison.OrdinalIgnoreCase)
    End Function

    ' Function to check if the employee is an admin
    Private Function IsAdmin(position As String) As Boolean
        Return String.Equals(position.Trim(), "ADMIN", StringComparison.OrdinalIgnoreCase)
    End Function
    Private Function AuthenticateEmployee(employeeId As String, password As String) As Tuple(Of Boolean, String, String, String, Image)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()
            ' Include a check for the employee's position in the SQL query
            Dim query As String = "SELECT employee_fname, employee_lname, employee_img, employee_password, employee_position FROM employee WHERE employee_id = @EmployeeId"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployeeId", employeeId)

                Using reader As MySqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve data including the hashed password and image
                        Dim firstName As String = reader("employee_fname").ToString()
                        Dim lastName As String = reader("employee_lname").ToString()
                        Dim position As String = reader("employee_position").ToString()
                        Dim hashedPassword As String = reader("employee_password").ToString()
                        Dim imageBytes As Byte() = CType(reader("employee_img"), Byte())
                        Dim imageStream As New MemoryStream(imageBytes)
                        Dim employeeImage As Image = Image.FromStream(imageStream)

                        ' Use bcrypt to verify the entered password against the stored hash
                        If BCrypt.Net.BCrypt.Verify(password, hashedPassword) Then
                            ' Password verification successful
                            Return New Tuple(Of Boolean, String, String, String, Image)(True, firstName, lastName, position, employeeImage)
                        End If
                    End If
                End Using
            End Using
        End Using

        ' Employee authentication failed
        Return New Tuple(Of Boolean, String, String, String, Image)(False, "", "", "", Nothing)
    End Function

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Me.Close()
    End Sub
End Class
