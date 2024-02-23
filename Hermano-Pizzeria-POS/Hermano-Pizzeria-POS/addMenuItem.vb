Imports System.IO
Imports MySql.Data.MySqlClient

Public Class addMenuItem
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"

    Private Sub pbProductImage_Click(sender As Object, e As EventArgs) Handles pbProductImage.Click
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
                pbProductImage.Image = selectedImage

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
        If String.IsNullOrWhiteSpace(tbProductName.Text) OrElse
           String.IsNullOrWhiteSpace(cbProductCategory.Text) OrElse
           String.IsNullOrWhiteSpace(tbProductPrice.Text) OrElse
           pbProductImage.Image Is Nothing OrElse ImageEquals(pbProductImage.Image, My.Resources.defaultImage) Then

            MessageBox.Show("Please fill in all fields and select an image for the product.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method if any field is empty or an image is not selected
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Insert data into the menu table
                Dim query As String = "INSERT INTO menu (product_name, product_description, product_category, product_price, product_image, product_status, product_size) " &
                      "VALUES (@product_name, @product_description, @product_category, @product_price, @product_image, @product_status, @product_size)"

                Using command As New MySqlCommand(query, connection)
                    ' Set parameters with values from textboxes and PictureBox
                    command.Parameters.AddWithValue("@product_name", tbProductName.Text)
                    command.Parameters.AddWithValue("@product_description", tbProductDescription.Text)
                    command.Parameters.AddWithValue("@product_category", cbProductCategory.Text)
                    command.Parameters.AddWithValue("@product_price", tbProductPrice.Text)
                    command.Parameters.AddWithValue("@product_status", cbStatus.Text)
                    command.Parameters.AddWithValue("@product_size", tbItemSize.Text)

                    ' Check if the PictureBox has an image selected
                    If pbProductImage.Image Is Nothing Then
                        ' If no image is selected, use the default image from resources
                        Dim defaultImageBytes As Byte() = ImageToByteArray(My.Resources.defaultImage)
                        command.Parameters.AddWithValue("@product_image", defaultImageBytes)
                    Else
                        ' If an image is selected, use the selected image
                        Dim selectedImageBytes As Byte() = ImageToByteArray(pbProductImage.Image)
                        command.Parameters.AddWithValue("@product_image", selectedImageBytes)
                    End If

                    ' Execute the query
                    command.ExecuteNonQuery()

                    MessageBox.Show("Product added successfully.")

                    tbProductName.Clear()
                    tbProductDescription.Clear()
                    cbProductCategory.SelectedIndex = -1
                    cbStatus.SelectedIndex = -1
                    tbItemSize.Clear()
                    tbProductPrice.Clear()
                    pbProductImage.Image = My.Resources.defaultImage
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error adding product: {ex.Message}")
        End Try
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
    ' Keypress event handler for tbProductPriceEdit
    Private Sub tbProductPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbProductPrice.KeyPress
        ' Allow only numeric input, backspace, and the decimal point
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
    End Sub

    Private Sub addMenuItem_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Load product categories from the database
        LoadProductCategories()
    End Sub

    Private Sub LoadProductCategories()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Query to retrieve product categories from the database
                Dim query As String = "SELECT category_name FROM category"

                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ' Clear existing items in the ComboBox
                        cbProductCategory.Items.Clear()

                        ' Add retrieved product categories to the ComboBox
                        While reader.Read()
                            cbProductCategory.Items.Add(reader("category_name").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error loading product categories: {ex.Message}")
        End Try
    End Sub
End Class
