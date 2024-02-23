Imports MySql.Data.MySqlClient

Public Class editCategory
    ' Add a field to store the original category name
    Private originalCategoryName As String
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"

    ' LoadData method to populate the controls with selected data
    Public Sub LoadData(categoryName As String)
        ' Populate the controls with the selected data
        tbCategoryNameEdit.Text = categoryName
        ' Store the original category name
        originalCategoryName = categoryName
    End Sub

    ' SaveBtn click event handler
    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        ' Validate that all fields are filled
        If String.IsNullOrWhiteSpace(tbCategoryNameEdit.Text) Then
            MessageBox.Show("Please fill in all fields.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method if any field is empty
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Update data in the category table
                Dim query As String = "UPDATE category SET category_name = @category_name WHERE category_name = @original_category_name"

                Using command As New MySqlCommand(query, connection)
                    ' Set parameters with values from textboxes
                    command.Parameters.AddWithValue("@original_category_name", originalCategoryName)
                    command.Parameters.AddWithValue("@category_name", tbCategoryNameEdit.Text)

                    ' Execute the query
                    command.ExecuteNonQuery()

                    MessageBox.Show("Changes saved successfully.")

                    ' Reload data after editing a category
                    Dim categoryControl As New categoryControl
                    adminDashboard.contentPanel.Controls.Clear()
                    categoryControl.Dock = DockStyle.Fill
                    adminDashboard.contentPanel.Controls.Add(categoryControl)
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
End Class
