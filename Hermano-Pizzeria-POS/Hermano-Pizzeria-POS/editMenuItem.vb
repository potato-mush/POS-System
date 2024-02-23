Imports System.IO
Imports MySql.Data.MySqlClient

Public Class editMenuItem
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"
    Dim productId As Integer = 0

    ' LoadData method to populate the controls with selected data
    Public Sub LoadData(productID As Integer, productName As String, productDescription As String, productCategory As String, productPrice As String, productImage As Image, productStatus As String, productSize As String)
        ' Set class-level productId
        Me.productId = productID

        ' Populate the controls with the selected data
        tbProductNameEdit.Text = productName
        tbProductDescriptionEdit.Text = productDescription

        ' Call GetCategoryNames to get the category names from the database
        Dim categoryNames As List(Of String) = GetCategoryNames()

        ' Set the category names to the ComboBox
        cbProductCategoryEdit.DataSource = categoryNames

        ' Set the selected category
        cbProductCategoryEdit.Text = productCategory

        tbProductPriceEdit.Text = productPrice
        tbItemSizeEdit.Text = productSize
        pbProductImageEdit.Image = productImage
        cbProductStatusEdit.Text = productStatus
    End Sub

    ' Convert Image to byte array
    Public Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Private Function GetCategoryNames() As List(Of String)
        Dim categoryNames As New List(Of String)

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Retrieve category names from the category table
                Dim query As String = "SELECT category_name FROM category"
                Using command As New MySqlCommand(query, connection)
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            categoryNames.Add(reader("category_name").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error getting category names: {ex.Message}")
        End Try

        Return categoryNames
    End Function

    Private Sub pbProductImageEdit_Click(sender As Object, e As EventArgs) Handles pbProductImageEdit.Click
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
                pbProductImageEdit.Image = selectedImage

                ' Optionally, you can save the image file path or perform other actions with the selected image
            Catch ex As Exception
                MessageBox.Show("Invalid image file. Please select a valid image.", "Invalid Image", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        ' Validate that all fields are filled
        If String.IsNullOrWhiteSpace(tbProductNameEdit.Text) OrElse
       String.IsNullOrWhiteSpace(cbProductCategoryEdit.Text) OrElse
       String.IsNullOrWhiteSpace(tbProductPriceEdit.Text) OrElse
       pbProductImageEdit.Image Is Nothing OrElse
       String.IsNullOrWhiteSpace(cbProductStatusEdit.Text) Then

            MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method if any field is empty
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Update data in the menu table
                Dim updateQuery As String = "UPDATE menu SET product_name = @product_name, " &
                        "product_description = @product_description, " &
                        "product_category = @product_category, product_price = @product_price, " &
                        "product_image = @product_image, product_status = @product_status, " &
                        "product_size = @product_size " &
                        "WHERE product_id = @product_id"

                Using updateCommand As New MySqlCommand(updateQuery, connection)
                    ' Set parameters with values from textboxes and PictureBox
                    updateCommand.Parameters.AddWithValue("@product_id", productId)
                    updateCommand.Parameters.AddWithValue("@product_name", tbProductNameEdit.Text)
                    updateCommand.Parameters.AddWithValue("@product_description", tbProductDescriptionEdit.Text)
                    updateCommand.Parameters.AddWithValue("@product_category", cbProductCategoryEdit.Text)
                    updateCommand.Parameters.AddWithValue("@product_price", tbProductPriceEdit.Text)

                    ' Check if the PictureBox has an image selected
                    If pbProductImageEdit.Image Is Nothing Then
                        ' If no image is selected, use the default image from resources
                        Dim defaultImageBytes As Byte() = ImageToByteArray(My.Resources.defaultImage)
                        updateCommand.Parameters.AddWithValue("@product_image", defaultImageBytes)
                    Else
                        ' If an image is selected, use the selected image
                        Dim selectedImageBytes As Byte() = ImageToByteArray(pbProductImageEdit.Image)
                        updateCommand.Parameters.AddWithValue("@product_image", selectedImageBytes)
                    End If

                    updateCommand.Parameters.AddWithValue("@product_status", cbProductStatusEdit.Text)
                    updateCommand.Parameters.AddWithValue("@product_size", If(String.IsNullOrEmpty(tbItemSizeEdit.Text), DBNull.Value, tbItemSizeEdit.Text)) ' Include product size

                    ' Execute the UPDATE query
                    updateCommand.ExecuteNonQuery()

                    MessageBox.Show("Changes saved successfully.")

                    ' Optionally, refresh the data in the current form after editing
                    adminDashboard.contentPanel.Controls.Clear()
                    Dim MenuControl As New menuControl
                    MenuControl.Dock = DockStyle.Fill
                    adminDashboard.contentPanel.Controls.Add(MenuControl)
                    Me.Hide()
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error saving changes: {ex.Message}")
        End Try
    End Sub

    ' Keypress event handler for tbProductPriceEdit
    Private Sub tbProductPriceEdit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbProductPriceEdit.KeyPress
        ' Allow only numeric input, backspace, and the decimal point
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "."c Then
            e.Handled = True
        End If

        ' Allow only one decimal point
        If e.KeyChar = "."c AndAlso DirectCast(sender, TextBox).Text.IndexOf("."c) > -1 Then
            e.Handled = True
        End If
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
End Class
