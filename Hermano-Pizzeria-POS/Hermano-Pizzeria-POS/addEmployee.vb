Imports System.IO
Imports MySql.Data.MySqlClient
Imports BCrypt.Net

Public Class addEmployee
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"
    Private Sub GetNextEmployeeID()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Get the next employee_id
                Dim query As String = "SELECT MAX(employee_id) + 1 FROM employee"
                Using command As New MySqlCommand(query, connection)
                    Dim nextEmployeeID As Object = command.ExecuteScalar()

                    If nextEmployeeID IsNot DBNull.Value AndAlso nextEmployeeID IsNot Nothing Then
                        ' Display the next employee_id in the TextBox
                        tbEmployeeID.Text = nextEmployeeID.ToString()
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error getting next employee ID: {ex.Message}")
        End Try
    End Sub
    Private Function GetNextEmployeeID(connection As MySqlConnection) As Integer
        ' Get the next employee_id
        Dim query As String = "SELECT MAX(employee_id) + 1 FROM employee"
        Using command As New MySqlCommand(query, connection)
            Dim nextEmployeeID As Object = command.ExecuteScalar()

            If nextEmployeeID IsNot DBNull.Value AndAlso nextEmployeeID IsNot Nothing Then
                Return Convert.ToInt32(nextEmployeeID)
            Else
                ' If there are no existing records, set the employee_id to 1
                Return 1
            End If
        End Using
    End Function
    Private Sub pbEmployeePhoto_Click(sender As Object, e As EventArgs) Handles pbEmployeePhoto.Click
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
                pbEmployeePhoto.Image = selectedImage

                ' Optionally, you can save the image file path or perform other actions with the selected image
            Catch ex As Exception
                MessageBox.Show("Invalid image file. Please select a valid image.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub

    Public Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function
    Private Function ImageEquals(image1 As Image, image2 As Image) As Boolean
        If image1 Is Nothing AndAlso image2 Is Nothing Then
            Return True
        ElseIf image1 Is Nothing OrElse image2 Is Nothing Then
            Return False
        End If

        Using stream1 As New MemoryStream(), stream2 As New MemoryStream()
            image1.Save(stream1, Imaging.ImageFormat.Png)
            image2.Save(stream2, Imaging.ImageFormat.Png)

            Dim byteArray1 As Byte() = stream1.ToArray()
            Dim byteArray2 As Byte() = stream2.ToArray()

            Return byteArray1.SequenceEqual(byteArray2)
        End Using
    End Function

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If String.IsNullOrWhiteSpace(tbFname.Text) OrElse
           String.IsNullOrWhiteSpace(tbLname.Text) OrElse
           String.IsNullOrWhiteSpace(tbEmployeeID.Text) OrElse
           String.IsNullOrWhiteSpace(tbAccountPassword.Text) OrElse
           String.IsNullOrWhiteSpace(cbPosition.Text) OrElse
           String.IsNullOrWhiteSpace(cbGender.Text) OrElse
           String.IsNullOrWhiteSpace(tbAge.Text) OrElse
           pbEmployeePhoto.Image Is Nothing OrElse ImageEquals(pbEmployeePhoto.Image, My.Resources.user) Then

            MessageBox.Show("Please fill in all fields and select an image for the employee.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method if any field is empty or an image is not selected
        End If
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()
                Dim nextEmployeeID As Integer = GetNextEmployeeID(connection)

                ' Check if the password meets the length criteria
                If tbAccountPassword.Text.Length < 6 Then
                    MessageBox.Show("Password must be 6 characters or longer.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Return ' Exit the method if the password is too short
                End If

                ' Hash the password using bcrypt
                Dim hashedPassword As String = BCrypt.Net.BCrypt.HashPassword(tbAccountPassword.Text)

                ' Insert data into the employee table
                Dim query As String = "INSERT INTO employee (employee_id, employee_fname, employee_lname, employee_position, employee_gender, employee_age, employee_password, employee_img) " &
                                      "VALUES (@employee_id, @employee_fname, @employee_lname, @employee_position, @employee_gender, @employee_age, @employee_password, @employee_img)"

                Using command As New MySqlCommand(query, connection)
                    ' Set parameters with values from textboxes and PictureBox
                    command.Parameters.AddWithValue("@employee_id", tbEmployeeID.Text)
                    command.Parameters.AddWithValue("@employee_fname", tbFname.Text)
                    command.Parameters.AddWithValue("@employee_lname", tbLname.Text)
                    command.Parameters.AddWithValue("@employee_position", cbPosition.Text)
                    command.Parameters.AddWithValue("@employee_gender", cbGender.Text)
                    command.Parameters.AddWithValue("@employee_age", tbAge.Text)
                    command.Parameters.AddWithValue("@employee_password", hashedPassword)

                    ' Check if the PictureBox has an image selected
                    If pbEmployeePhoto.Image Is Nothing Then
                        ' If no image is selected, use the default image from resources
                        Dim defaultImageBytes As Byte() = ImageToByteArray(My.Resources.user)
                        command.Parameters.AddWithValue("@employee_img", defaultImageBytes)
                    Else
                        ' If an image is selected, use the selected image
                        Dim selectedImageBytes As Byte() = ImageToByteArray(pbEmployeePhoto.Image)
                        command.Parameters.AddWithValue("@employee_img", selectedImageBytes)
                    End If

                    ' Execute the query
                    command.ExecuteNonQuery()

                    MessageBox.Show("Employee added successfully.")

                    ' Get and set the next employee ID
                    nextEmployeeID = GetNextEmployeeID(connection)
                    tbEmployeeID.Text = nextEmployeeID.ToString()

                    tbFname.Clear()
                    tbLname.Clear()
                    tbAccountPassword.Clear()
                    cbPosition.SelectedIndex = -1
                    cbGender.SelectedIndex = -1
                    tbAge.Clear()
                    pbEmployeePhoto.Image = My.Resources.user

                    Dim EmployeeControl As New EmployeeControl
                    adminDashboard.contentPanel.Controls.Clear()
                    EmployeeControl.Dock = DockStyle.Fill
                    adminDashboard.contentPanel.Controls.Add(EmployeeControl)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error adding employee: {ex.Message}")
        End Try
    End Sub
    Private Sub tbAge_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbAge.KeyPress
        ' Check if the pressed key is a digit or a control key (e.g., Backspace)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' If not a digit or control key, suppress the key press
            e.Handled = True
        End If

        ' Check the length of the current text and allow only two digits
        If tbAge.Text.Length >= 2 AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

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

    Private Sub addEmployee_Load(sender As Object, e As EventArgs) Handles Me.Load
        GetNextEmployeeID()
    End Sub
End Class