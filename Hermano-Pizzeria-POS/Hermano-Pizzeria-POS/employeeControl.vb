Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.IO

Public Class EmployeeControl
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

    Sub LoadEmployeeData(existingDataGridView As DataGridView, filterText As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Load employee data with optional filtering
                Dim query As String = "SELECT employee_id, CONCAT(employee_fname, ' ', employee_lname) AS employee_name, employee_position, employee_gender, employee_age, employee_img FROM employee"

                If Not String.IsNullOrWhiteSpace(filterText) Then
                    ' Concatenate relevant columns for search
                    query &= $" WHERE CONCAT(employee_id, employee_fname, ' ', employee_lname, ' ', employee_position, ' ', employee_gender, ' ', employee_age) LIKE '%{filterText}%'"
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
                        adapter.Fill(dataSet, "employee")

                        ' Resize the image column to 100x100 pixels (assuming the image column is at index 5)
                        Dim imageColumnIndex As Integer = 5

                        For Each row As DataRow In dataSet.Tables("employee").Rows
                            Dim byteArray As Byte() = DirectCast(row(imageColumnIndex), Byte())
                            If byteArray IsNot Nothing AndAlso byteArray.Length > 0 Then
                                Dim originalImage As Image = ByteArrayToImage(byteArray)
                                Dim resizedImage As Image = ResizeImage(originalImage, 100, 100)
                                row(imageColumnIndex) = ImageToByteArray(resizedImage)
                            End If
                        Next

                        ' Bind the data to the specified columns of the existing DataGridView
                        existingDataGridView.DataSource = dataSet.Tables("employee")
                    End Using
                End Using
            End Using

            ' Update the page number label after loading data
            UpdatePageNumberLabel()

        Catch ex As Exception
            MessageBox.Show($"Error loading employee data: {ex.Message}")
        End Try
    End Sub

    Private Sub employeeControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Pass the existing DataGridView to the LoadEmployeeData method without filtering initially
        LoadEmployeeData(employeeData, String.Empty)
    End Sub

    Private Sub tbSearchEmployee_TextChanged(sender As Object, e As EventArgs) Handles tbSearchEmployee.TextChanged
        ' If the search bar is blank, set current page to 1 and reload data for the new page
        If String.IsNullOrWhiteSpace(tbSearchEmployee.Text) Then
            currentPage = 1
        End If

        ' Call LoadEmployeeData with the current text in the search textbox for filtering
        LoadEmployeeData(employeeData, tbSearchEmployee.Text.Trim())
    End Sub
    Private Function ImageToByteArray(image As Image) As Byte()
        Using ms As New MemoryStream()
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Png)
            Return ms.ToArray()
        End Using
    End Function

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

    Private Sub addEmployeeBtn_Click(sender As Object, e As EventArgs) Handles addEmployeeBtn.Click

        addEmployee.ShowDialog()

        ' Reload data after adding a new employee
        LoadEmployeeData(employeeData, tbSearchEmployee.Text.Trim())
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        ' Check if there is a selected row
        If employeeData.SelectedRows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = employeeData.SelectedRows(0)

            ' Get the values from the selected row
            Dim selectedEmployeeID As String = selectedRow.Cells("employee_id").Value.ToString()
            Dim employeeName As String = selectedRow.Cells("employee_name").Value.ToString()
            Dim employeePosition As String = selectedRow.Cells("employee_position").Value.ToString()
            Dim employeeGender As String = selectedRow.Cells("employee_gender").Value.ToString()
            Dim employeeAge As String = selectedRow.Cells("employee_age").Value.ToString()
            Dim employeeImage As Image = ByteArrayToImage(DirectCast(selectedRow.Cells("employee_img").Value, Byte()))

            ' Open the "Edit Employee" form and pass the selected data
            Dim editEmployeeForm As New editEmployee()
            editEmployeeForm.LoadData(selectedEmployeeID, employeeName, employeePosition, employeeGender, employeeAge, employeeImage)
            editEmployeeForm.ShowDialog()

            ' Optionally, refresh the data in the current form after editing
            LoadEmployeeData(employeeData, tbSearchEmployee.Text.Trim())
        Else
            MessageBox.Show("Please select a row to edit.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub removeBtn_Click(sender As Object, e As EventArgs) Handles removeBtn.Click
        Try
            ' Check if there is a selected row
            If employeeData.SelectedRows.Count > 0 Then
                ' Get the selected row
                Dim selectedRow As DataGridViewRow = employeeData.SelectedRows(0)

                ' Get the values from the selected row
                Dim selectedEmployeeID As String = selectedRow.Cells("employee_id").Value.ToString()
                Dim employeeName As String = selectedRow.Cells("employee_name").Value.ToString()

                ' Display a confirmation message
                Dim result As DialogResult = MessageBox.Show($"Are you sure you want to delete the employee '{employeeName}' with ID {selectedEmployeeID}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                ' Check the user's response
                If result = DialogResult.Yes Then
                    ' Disable foreign key checks
                    Using connection As New MySqlConnection(connectionString)
                        connection.Open()
                        Using disableForeignKeyCmd As New MySqlCommand("SET foreign_key_checks = 0;", connection)
                            disableForeignKeyCmd.ExecuteNonQuery()
                        End Using

                        ' SQL syntax for deletion
                        Dim deleteQuery As String = $"DELETE FROM employee WHERE employee_id = '{selectedEmployeeID}'"

                        ' Execute the deletion query
                        Using command As New MySqlCommand(deleteQuery, connection)
                            command.ExecuteNonQuery()
                        End Using
                    End Using

                    ' Refresh the DataGridView after deletion
                    LoadEmployeeData(employeeData, tbSearchEmployee.Text.Trim())
                End If
            Else
                MessageBox.Show("Please select a row to delete.", "No Row Selected", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show($"Error removing employee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub bindingNavigatorMoveNextItem_Click(sender As Object, e As EventArgs) Handles btnNextPage.Click
        ' Calculate the total number of records
        Dim totalRecords As Integer = GetTotalRecordsCount()
        ' Calculate the total number of pages
        Dim totalPages As Integer = Math.Ceiling(totalRecords / recordsPerPage)

        ' Move to the next page only if the current page is less than the total pages
        If currentPage < totalPages Then
            ' Move to the next page
            currentPage += 1
            ' Reload data for the new page
            LoadEmployeeData(employeeData, tbSearchEmployee.Text.Trim())
        End If
    End Sub


    Private Sub bindingNavigatorMovePreviousItem_Click(sender As Object, e As EventArgs) Handles btnPrevPage.Click
        ' Move to the previous page
        If currentPage > 1 Then
            currentPage -= 1
            ' Reload data for the new page
            LoadEmployeeData(employeeData, tbSearchEmployee.Text.Trim())
        End If
    End Sub

    Private Sub bindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles btnLastPage.Click
        ' Move to the last page
        ' Calculate the total number of records
        Dim totalRecords As Integer = GetTotalRecordsCount()
        ' Calculate the total number of pages
        Dim totalPages As Integer = Math.Ceiling(totalRecords / recordsPerPage)
        ' Set the current page to the last page
        currentPage = totalPages
        ' Reload data for the new page
        LoadEmployeeData(employeeData, tbSearchEmployee.Text.Trim())
    End Sub

    Private Sub bindingNavigatorMoveFirstItem_Click(sender As Object, e As EventArgs) Handles btnFirstPage.Click
        ' Move to the first page
        currentPage = 1
        ' Reload data for the new page
        LoadEmployeeData(employeeData, tbSearchEmployee.Text.Trim())
    End Sub

    Private Function GetTotalRecordsCount() As Integer
        ' Calculate the total number of records
        Dim totalRecords As Integer = 0

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Get the total number of records
                Dim query As String = "SELECT COUNT(*) FROM employee"
                Using command As New MySqlCommand(query, connection)
                    totalRecords = Convert.ToInt32(command.ExecuteScalar())
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error getting total records count: {ex.Message}")
        End Try

        Return totalRecords
    End Function
End Class
