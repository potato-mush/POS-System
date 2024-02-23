Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.IO

Public Class menuControl
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"
    Dim currentPage As Integer = 1
    Dim recordsPerPage As Integer = 10

    Private Function ResizeImage(originalImage As Image, width As Integer, height As Integer) As Image
        Return New Bitmap(originalImage, New Size(width, height))
    End Function

    Private Function ByteArrayToImage(byteArray As Byte()) As Image
        Using ms As New MemoryStream(byteArray)
            Return Image.FromStream(ms)
        End Using
    End Function

    Private Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

    Sub LoadMenuData(existingDataGridView As DataGridView, filterText As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Calculate the starting index based on the current page and records per page
                Dim startIndex As Integer = (currentPage - 1) * recordsPerPage

                ' Load menu data with optional filtering and pagination
                Dim query As String = $"SELECT product_id, product_name, product_description, product_category, product_price, product_image, product_status, product_size FROM menu"

                If Not String.IsNullOrWhiteSpace(filterText) Then
                    ' Concatenate relevant columns for search
                    query &= $" WHERE CONCAT(product_name, product_description, product_category, product_price, product_status) LIKE '%{filterText}%'"
                End If

                ' Do not add LIMIT clause if the search text is not empty
                If String.IsNullOrWhiteSpace(filterText) Then
                    ' Add LIMIT clause for pagination
                    query &= $" LIMIT {startIndex}, {recordsPerPage}"
                End If

                Using command As New MySqlCommand(query, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataSet As New DataSet()
                        adapter.Fill(dataSet, "menu")

                        ' Bind the data to the specified columns of the existing DataGridView
                        existingDataGridView.DataSource = dataSet.Tables("menu")

                        ' Resize the image column to 100x100 pixels (assuming the image column is at index 5)
                        Dim imageColumnIndex As Integer = existingDataGridView.Columns("product_image").Index

                        For Each row As DataGridViewRow In existingDataGridView.Rows
                            Dim byteArray As Byte() = TryCast(row.Cells(imageColumnIndex).Value, Byte())

                            If byteArray IsNot Nothing AndAlso byteArray.Length > 0 Then
                                Dim originalImage As Image = ByteArrayToImage(byteArray)
                                Dim resizedImage As Image = ResizeImage(originalImage, 100, 100)
                                row.Cells(imageColumnIndex).Value = resizedImage
                            End If
                        Next
                    End Using
                End Using
            End Using

            ' Update the page number label after loading data
            UpdatePageNumberLabel()

        Catch ex As Exception
            MessageBox.Show($"Error loading menu data: {ex.Message}")
        End Try
    End Sub

    Private Sub UpdatePageNumberLabel()
        Try
            ' Get the total number of records
            Dim totalRecords As Integer = GetTotalRecordsCount()

            ' Calculate the total number of pages
            Dim totalPages As Integer = Math.Ceiling(totalRecords / recordsPerPage)

            ' Ensure that the current page does not exceed the maximum number of pages
            If currentPage > totalPages Then
                currentPage = totalPages
            End If

            ' Update the page number label
            lblPageNumber.Text = $"Page {currentPage} of {totalPages}"

        Catch ex As Exception
            MessageBox.Show($"Error updating page number label: {ex.Message}")
        End Try
    End Sub

    Private Sub addMenuItemBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        addMenuItem.ShowDialog()

        ' Reload data after adding a new menu item
        LoadMenuData(menuData, tbSearchMenu.Text.Trim())
    End Sub

    Private Sub editMenuItemBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        ' Check if there is a selected row
        If menuData.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = menuData.SelectedRows(0)

            ' Get the values from the selected row
            Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("product_id").Value)
            Dim productName As String = selectedRow.Cells("product_name").Value.ToString()
            Dim productDescription As String = selectedRow.Cells("product_description").Value.ToString()
            Dim productCategory As String = selectedRow.Cells("product_category").Value.ToString()
            Dim productPrice As String = selectedRow.Cells("product_price").Value.ToString()
            Dim productImage As Image = ByteArrayToImage(DirectCast(selectedRow.Cells("product_image").Value, Byte()))
            Dim productStatus As String = selectedRow.Cells("product_status").Value.ToString()
            Dim productSize As String = selectedRow.Cells("product_size").Value.ToString()

            ' Open the "Edit Menu Item" form and pass the selected data
            Dim editMenuItemForm As New editMenuItem()
            editMenuItemForm.LoadData(productId, productName, productDescription, productCategory, productPrice, productImage, productStatus, productSize)
            editMenuItemForm.ShowDialog()

            ' Optionally, refresh the data in the current form after editing
            LoadMenuData(menuData, tbSearchMenu.Text.Trim())
        Else
            MessageBox.Show("Please select a row to edit.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub removeMenuItemBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click
        Try
            ' Check if there is a selected row
            If menuData.SelectedRows.Count > 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = menuData.SelectedRows(0)

                ' Get the values from the selected row
                Dim productId As Integer = Convert.ToInt32(selectedRow.Cells("product_id").Value)
                Dim productName As String = selectedRow.Cells("product_name").Value.ToString()

                ' Display a confirmation message
                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the menu item '{productName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' Check the user's response
                If result = DialogResult.Yes Then
                    ' SQL syntax for deletion
                    Dim deleteQuery As String = $"DELETE FROM menu WHERE product_id = {productId}"

                    ' Execute the deletion query
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()
                        Using command As New MySqlCommand(deleteQuery, connection)
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Refresh the DataGridView after deletion
                    LoadMenuData(menuData, tbSearchMenu.Text.Trim())
                End If
            Else
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error removing menu item: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        ' Calculate the total number of records
        Dim totalRecords As Integer = GetTotalRecordsCount()
        ' Calculate the total number of pages
        Dim totalPages As Integer = Math.Ceiling(totalRecords / recordsPerPage)

        ' Move to the next page only if the current page is less than the total pages
        If currentPage < totalPages Then
            ' Move to the next page
            currentPage += 1
            ' Reload data for the new page
            LoadMenuData(menuData, tbSearchMenu.Text.Trim())
        End If
    End Sub

    Private Sub btnPrevPage_Click(sender As Object, e As EventArgs) Handles btnPrevPage.Click
        ' Move to the previous page
        If currentPage > 1 Then
            currentPage -= 1
            ' Reload data for the new page
            LoadMenuData(menuData, tbSearchMenu.Text.Trim())
        End If
    End Sub

    Private Sub btnLastPage_Click(sender As Object, e As EventArgs) Handles btnLastPage.Click
        ' Move to the last page
        ' Calculate the total number of records
        Dim totalRecords As Integer = GetTotalRecordsCount()
        ' Calculate the total number of pages
        Dim totalPages As Integer = Math.Ceiling(totalRecords / recordsPerPage)
        ' Set the current page to the last page
        currentPage = totalPages
        ' Reload data for the new page
        LoadMenuData(menuData, tbSearchMenu.Text.Trim())
    End Sub

    Private Sub btnFirstPage_Click(sender As Object, e As EventArgs) Handles btnFirstPage.Click
        ' Move to the first page
        currentPage = 1
        ' Reload data for the new page
        LoadMenuData(menuData, tbSearchMenu.Text.Trim())
    End Sub

    Private Function GetTotalRecordsCount() As Integer
        ' Calculate the total number of records
        Dim totalRecords As Integer = 0

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Get the total number of records
                Dim query As String = "SELECT COUNT(*) FROM menu"
                Using command As New MySqlCommand(query, connection)
                    totalRecords = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error getting total records count: {ex.Message}")
        End Try

        Return totalRecords
    End Function

    ' Search TextBox TextChanged event handler
    Private Sub tbSearchMenu_TextChanged(sender As Object, e As EventArgs) Handles tbSearchMenu.TextChanged
        ' Reload data based on the search criteria
        LoadMenuData(menuData, tbSearchMenu.Text.Trim())
    End Sub

    Private Sub menuControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadMenuData(menuData, String.Empty)
    End Sub
End Class
