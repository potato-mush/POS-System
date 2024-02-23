Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class ChangePassword

    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"

    Private _employeeId As String

    Public Property EmployeeId() As String
        Get
            Return _employeeId
        End Get
        Set(ByVal value As String)
            _employeeId = value
        End Set
    End Property

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        ' Get values from textboxes
        Dim currentPassword As String = tbAccountPassword.Text
        Dim newPassword As String = tbNewPassword.Text
        Dim confirmPassword As String = tbConfirmPassword.Text

        ' Validate if the new password and confirm password match
        If newPassword <> confirmPassword Then
            MessageBox.Show("New password and confirm password do not match.", "Password Mismatch", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate if the new password has at least 6 characters
        If newPassword.Length < 6 Then
            MessageBox.Show("New password must be at least 6 characters long.", "Password Length", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Validate the current password
        If Not ValidateCurrentPassword(currentPassword) Then
            MessageBox.Show("Current password is incorrect.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Hash the new password using bcrypt
        Dim hashedNewPassword As String = HashPassword(newPassword)

        ' Update the hashed password in the database
        If UpdatePassword(EmployeeId, hashedNewPassword) Then
            MessageBox.Show("Password updated successfully.", "Password Change", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbAccountPassword.Text = ""
            tbNewPassword.Text = ""
            tbConfirmPassword.Text = ""
            Me.Close()
        Else
            MessageBox.Show("Failed to update password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Function ValidateCurrentPassword(currentPassword As String) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Retrieve the hashed password from the database
                Dim query As String = "SELECT employee_password FROM employee WHERE employee_id = @EmployeeId"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@EmployeeId", EmployeeId)

                    ' Execute the query
                    Dim hashedPassword As Object = command.ExecuteScalar()

                    ' Check if the result is not null and not DBNull
                    If hashedPassword IsNot Nothing AndAlso Not Convert.IsDBNull(hashedPassword) Then
                        ' Debug output
                        Console.WriteLine($"Entered Password: {currentPassword}")
                        Console.WriteLine($"Stored Hashed Password: {hashedPassword}")

                        ' Use BCrypt to verify the entered password against the stored hash
                        Return BCrypt.Net.BCrypt.Verify(currentPassword, hashedPassword.ToString())
                    Else
                        ' Handle the case where the hashed password is null or empty
                        MessageBox.Show("Invalid employee ID or missing hashed password.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End If
                End Using
            End Using
        Catch ex As Exception
            ' Handle the exception (e.g., log, display an error message)
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Validation failed due to an error
        End Try
    End Function

    Private Function HashPassword(password As String) As String
        ' Generate a random salt using BCrypt
        Dim salt As String = BCrypt.Net.BCrypt.GenerateSalt()

        ' Hash the password with the generated salt
        Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(password, salt)

        Return hashedPassword
    End Function

    Private Function UpdatePassword(employeeId As String, newPassword As String) As Boolean
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Update the password in the database
                Dim query As String = "UPDATE employee SET employee_password = @NewPassword WHERE employee_id = @EmployeeId"
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@NewPassword", newPassword)
                    command.Parameters.AddWithValue("@EmployeeId", employeeId)

                    ' Execute the update query
                    command.ExecuteNonQuery()

                    Return True ' Password updated successfully
                End Using
            End Using
        Catch ex As Exception
            ' Handle the exception (e.g., log, display an error message)
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Failed to update password
        End Try
    End Function

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        tbAccountPassword.Text = ""
        tbNewPassword.Text = ""
        tbConfirmPassword.Text = ""
        Me.Close()
    End Sub
End Class
