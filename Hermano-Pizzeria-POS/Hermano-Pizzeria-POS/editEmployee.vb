Imports System.IO
Imports MySql.Data.MySqlClient
Imports BCrypt.Net.BCrypt

Public Class editEmployee
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"

    Public Sub LoadData(employeeID As String, employeeName As String, position As String, gender As String, age As String, image As Image)
        ' Extract first name and last name from the full name
        Dim nameParts As String() = employeeName.Split(" "c)
        Dim firstName As String = nameParts(0)

        ' Concatenate the remaining parts as the last name
        Dim lastName As String = String.Join(" ", nameParts.Skip(1))

        ' Populate the controls with the selected data
        tbEmployeeIDEdit.Text = employeeID
        tbFnameEdit.Text = firstName
        tbLnameEdit.Text = lastName
        cbPositionEdit.Text = position
        cbGenderEdit.Text = gender
        tbAgeEdit.Text = age
        pbEmployeePhotoEdit.Image = image
    End Sub


    ' Convert Image to byte array
    Public Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Private Sub pbEmployeePhotoEdit_Click(sender As Object, e As EventArgs) Handles pbEmployeePhotoEdit.Click
        ' Show the OpenFileDialog to allow the user to choose an image file
        Dim openFileDialog As New OpenFileDialog()
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp|All Files|*.*"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            ' Get the selected file path
            Dim selectedImagePath As String = openFileDialog.FileName

            Try
                ' Validate if the selected file is a valid image file
                Dim selectedImage As Image = Image.FromFile(selectedImagePath)

                ' Display the selected image in the PictureBox
                pbEmployeePhotoEdit.Image = selectedImage

                ' Optionally, you can save the image file path or perform other actions with the selected image
            Catch ex As Exception
                MessageBox.Show("Invalid image file. Please select a valid image.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    ' SaveBtn click event handler
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        ' Validate that all fields are filled
        If String.IsNullOrWhiteSpace(tbFnameEdit.Text) OrElse
           String.IsNullOrWhiteSpace(tbLnameEdit.Text) OrElse
           String.IsNullOrWhiteSpace(cbPositionEdit.Text) OrElse
           String.IsNullOrWhiteSpace(cbGenderEdit.Text) OrElse
           String.IsNullOrWhiteSpace(tbAgeEdit.Text) Then

            MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method if any field is empty
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Update data in the employee table
                Dim query As String = "UPDATE employee SET employee_fname = @employee_fname, employee_lname = @employee_lname, " &
                                      "employee_position = @employee_position, employee_gender = @employee_gender, " &
                                      "employee_age = @employee_age, " &
                                      "employee_img = @employee_img WHERE employee_id = @employee_id"

                Using command As New MySqlCommand(query, connection)
                    ' Set parameters with values from textboxes and PictureBox
                    command.Parameters.AddWithValue("@employee_id", tbEmployeeIDEdit.Text)
                    command.Parameters.AddWithValue("@employee_fname", tbFnameEdit.Text)
                    command.Parameters.AddWithValue("@employee_lname", tbLnameEdit.Text)
                    command.Parameters.AddWithValue("@employee_position", cbPositionEdit.Text)
                    command.Parameters.AddWithValue("@employee_gender", cbGenderEdit.Text)
                    command.Parameters.AddWithValue("@employee_age", tbAgeEdit.Text)

                    ' Check if the PictureBox has an image selected
                    If pbEmployeePhotoEdit.Image Is Nothing Then
                        ' If no image is selected, use the default image from resources
                        Dim defaultImageBytes As Byte() = ImageToByteArray(My.Resources.user)
                        command.Parameters.AddWithValue("@employee_img", defaultImageBytes)
                    Else
                        ' If an image is selected, use the selected image
                        Dim selectedImageBytes As Byte() = ImageToByteArray(pbEmployeePhotoEdit.Image)
                        command.Parameters.AddWithValue("@employee_img", selectedImageBytes)
                    End If

                    ' Execute the query
                    command.ExecuteNonQuery()

                    MessageBox.Show("Changes saved successfully.")

                    Dim EmployeeControl As New EmployeeControl
                    adminDashboard.contentPanel.Controls.Clear()
                    EmployeeControl.Dock = DockStyle.Fill
                    adminDashboard.contentPanel.Controls.Add(EmployeeControl)
                    Me.Hide()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error saving changes: {ex.Message}")
        End Try
    End Sub

    ' CancelBtn click event handler
    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        ' Display a confirmation message
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            ' User clicked "Yes," hide the form
            Me.Hide()
        End If
        ' If the user clicked "No," do nothing and keep the form open
    End Sub

    Private Sub resetPasswordBtn_Click(sender As Object, e As EventArgs) Handles resetPasswordBtn.Click
        ' Display a confirmation message
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to reset the password?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        ' Check the user's response
        If result = DialogResult.Yes Then
            Try
                ' Update the password to "pass123"
                Dim newPassword As String = "pass123"

                ' Hash the password using BCrypt
                Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(newPassword)

                Using connection As New MySqlConnection(connectionString)
                    connection.Open()

                    ' Update the password in the employee table
                    Dim query As String = "UPDATE employee SET employee_password = @employee_password WHERE employee_id = @employee_id"

                    Using command As New MySqlCommand(query, connection)
                        ' Set parameters with the new hashed password and employee ID
                        command.Parameters.AddWithValue("@employee_id", tbEmployeeIDEdit.Text)
                        command.Parameters.AddWithValue("@employee_password", hashedPassword)

                        ' Execute the query
                        command.ExecuteNonQuery()

                        MessageBox.Show("Password reset successfully.")
                    End Using
                End Using
            Catch ex As Exception
                MessageBox.Show($"Error resetting password: {ex.Message}")
            End Try
        End If
    End Sub
End Class
