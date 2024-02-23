Imports System.IO
Imports MySql.Data.MySqlClient

Public Class addCategory
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        If String.IsNullOrWhiteSpace(tbCategoryName.Text) Then
            MessageBox.Show("Please fill in the category name.", "Incomplete Information", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return ' Exit the method if the category name is empty
        End If

        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Insert data into the category table
                Dim query As String = "INSERT INTO category (category_name) " &
                                      "VALUES (@category_name)"

                Using command As New MySqlCommand(query, connection)
                    ' Set parameters with values from the textbox
                    command.Parameters.AddWithValue("@category_name", tbCategoryName.Text)

                    ' Execute the query
                    command.ExecuteNonQuery()

                    MessageBox.Show("Category added successfully.")

                    ' Optionally, refresh the data in the current form or navigate to another form after adding
                    Dim CategoryControl As New categoryControl
                    adminDashboard.contentPanel.Controls.Clear()
                    categoryControl.Dock = DockStyle.Fill
                    adminDashboard.contentPanel.Controls.Add(categoryControl)

                    ' Clear the textbox after adding
                    tbCategoryName.Clear()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error adding category: {ex.Message}")
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
End Class
