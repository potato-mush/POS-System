Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.IO

Public Class categoryControl
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"
    Dim currentPage As Integer = 1
    Dim recordsPerPage As Integer = 10

    Private Function GetTotalCategoryRecordsCount(filterText As String) As Integer
        ' Calculate the total number of category records with optional filtering
        Dim totalRecords As Integer = 0

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Get the total number of category records with optional filtering
                Dim query As String = "SELECT COUNT(*) FROM category"

                If Not String.IsNullOrWhiteSpace(filterText) Then
                    ' Concatenate relevant columns for search
                    query &= $" WHERE category_name LIKE '%{filterText}%'"
                End If

                Using command As New MySqlCommand(query, connection)
                    totalRecords = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error getting total category records count: {ex.Message}")
        End Try

        Return totalRecords
    End Function

    Sub LoadCategoryData(existingDataGridView As DataGridView, filterText As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Load category data with optional filtering
                Dim query As String = "SELECT category_name FROM category"

                If Not String.IsNullOrWhiteSpace(filterText) Then
                    ' Concatenate relevant columns for search
                    query &= $" WHERE category_name LIKE '%{filterText}%'"
                End If

                ' Do not add LIMIT clause if the search text is not empty
                If String.IsNullOrWhiteSpace(filterText) Then
                    ' Calculate the starting index based on the current page and records per page
                    Dim startIndex As Integer = (currentPage - 1) * recordsPerPage
                    ' Add LIMIT clause for pagination
                    query &= $" LIMIT {startIndex}, {recordsPerPage}"
                End If

                Using command As New MySqlCommand(query, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataSet As New DataSet()
                        adapter.Fill(dataSet, "category")

                        ' Clear existing data in the DataGridView
                        existingDataGridView.Rows.Clear()

                        ' Set row numbers for each row directly in 'Column1'
                        For i As Integer = 0 To dataSet.Tables("category").Rows.Count - 1
                            existingDataGridView.Rows.Add(dataSet.Tables("category").Rows(i)("category_name").ToString())
                        Next
                    End Using
                End Using
            End Using

            ' Update the total records count and page number label after loading data
            UpdateTotalRecordsAndPageNumberLabel(filterText)

        Catch ex As Exception
            MessageBox.Show($"Error loading category data: {ex.Message}")
        End Try
    End Sub

    Private Sub tbSearchCategory_TextChanged(sender As Object, e As EventArgs) Handles tbSearchCategory.TextChanged
        ' If the search bar is blank, set current page to 1 and reload data for the new page
        If String.IsNullOrWhiteSpace(tbSearchCategory.Text) Then
            ' Assuming you have a variable named currentPageCategory
            currentPage = 1
        End If

        ' Call LoadCategoryData with the current text in the search textbox for filtering
        LoadCategoryData(categoryData, tbSearchCategory.Text.Trim())
    End Sub

    Private Sub categoryControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Pass the existing DataGridView to the LoadCategoryData method without filtering initially
        LoadCategoryData(categoryData, String.Empty)
    End Sub

    Private Sub tbSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles tbSearchCategory.TextChanged
        ' If the search bar is blank, set current page to 1 and reload data for the new page
        If String.IsNullOrWhiteSpace(tbSearchCategory.Text) Then
            currentPage = 1
        End If

        ' Call LoadCategoryData with the current text in the search textbox for filtering
        LoadCategoryData(categoryData, tbSearchCategory.Text.Trim())
    End Sub

    Private Sub UpdateTotalRecordsAndPageNumberLabel(filterText As String)
        Try
            ' Get the total number of records with optional filtering
            Dim totalRecords As Integer = GetTotalCategoryRecordsCount(filterText)

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

    Private Sub btnNextPage_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        ' Calculate the total number of records
        Dim totalRecords As Integer = GetTotalCategoryRecordsCount(tbSearchCategory.Text.Trim())
        ' Calculate the total number of pages
        Dim totalPages As Integer = Math.Ceiling(totalRecords / recordsPerPage)

        ' Move to the next page only if the current page is less than the total pages
        If currentPage < totalPages Then
            ' Move to the next page
            currentPage += 1
            ' Reload data for the new page
            LoadCategoryData(categoryData, tbSearchCategory.Text.Trim())
        End If
    End Sub

    Private Sub btnPrevPage_Click(sender As Object, e As EventArgs) Handles btnPrevPage.Click
        ' Move to the previous page
        If currentPage > 1 Then
            currentPage -= 1
            ' Reload data for the new page
            LoadCategoryData(categoryData, tbSearchCategory.Text.Trim())
        End If
    End Sub

    Private Sub btnLastPage_Click(sender As Object, e As EventArgs) Handles btnLastPage.Click
        ' Move to the last page
        ' Calculate the total number of records
        Dim totalRecords As Integer = GetTotalCategoryRecordsCount(tbSearchCategory.Text.Trim())
        ' Calculate the total number of pages
        Dim totalPages As Integer = Math.Ceiling(totalRecords / recordsPerPage)
        ' Set the current page to the last page
        currentPage = totalPages
        ' Reload data for the new page
        LoadCategoryData(categoryData, tbSearchCategory.Text.Trim())
    End Sub

    Private Sub btnFirstPage_Click(sender As Object, e As EventArgs) Handles btnFirstPage.Click
        ' Move to the first page
        currentPage = 1
        ' Reload data for the new page
        LoadCategoryData(categoryData, tbSearchCategory.Text.Trim())
    End Sub

    Private Sub addCategoryBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        ' Open the "Add Category" form
        addCategory.ShowDialog()

        ' Reload data after adding a new category
        LoadCategoryData(categoryData, tbSearchCategory.Text.Trim())
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        ' Check if there is a selected row
        If categoryData.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = categoryData.SelectedRows(0)

            ' Get the value from the selected row
            Dim selectedCategoryName As String = selectedRow.Cells("category_name").Value.ToString()

            ' Open the "Edit Category" form and pass the selected data
            Dim editCategoryForm As New editCategory()
            editCategoryForm.LoadData(selectedCategoryName)
            editCategoryForm.ShowDialog()

            ' Optionally, refresh the data in the current form after editing
            LoadCategoryData(categoryData, tbSearchCategory.Text.Trim())
        Else
            MessageBox.Show("Please select a row to edit.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click
        Try
            ' Check if there is a selected row
            If categoryData.SelectedRows.Count > 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = categoryData.SelectedRows(0)

                ' Get the value from the selected row
                Dim selectedCategoryName As String = selectedRow.Cells("category_name").Value.ToString()

                ' Display a confirmation message
                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the category '{selectedCategoryName}'?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' Check the user's response
                If result = DialogResult.Yes Then
                    ' SQL syntax for deletion
                    Dim deleteQuery As String = $"DELETE FROM category WHERE category_name = '{selectedCategoryName}'"

                    ' Execute the deletion query
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()
                        Using command As New MySqlCommand(deleteQuery, connection)
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Refresh the DataGridView after deletion
                    LoadCategoryData(categoryData, tbSearchCategory.Text.Trim())
                End If
            Else
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error removing category: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
