Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Utilities
Imports System.Drawing.Printing
Imports System.IO

Public Class logsControl
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"
    Dim currentPage As Integer = 1

    Private Sub ReportControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim fromDate As DateTime = fromDatePicker.Value
        Dim toDate As DateTime = toDatePicker.Value
        ' Load all transaction data with date filtering
        LoadTransactionData(logsData, tbSearchEmployee.Text.Trim(), fromDate, toDate)
    End Sub

    Sub LoadAllTransactionData(existingDataGridView As DataGridView)
        ' Load all transaction data without any filtering
        LoadTransactionData(existingDataGridView, "", DateTime.MinValue, DateTime.MinValue)
    End Sub

    Sub LoadTransactionData(existingDataGridView As DataGridView, filterText As String, Optional ByVal fromDate As DateTime = Nothing, Optional ByVal toDate As DateTime = Nothing)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Load all transaction data without any filtering
                Dim query As String = "SELECT employee_id, employee_name, employee_position, time_in, time_out, date FROM logs"

                ' Add date range filtering if fromDate and toDate are provided
                If fromDate <> DateTime.MinValue AndAlso toDate <> DateTime.MinValue Then
                    query &= $" WHERE date BETWEEN '{fromDate.ToString("yyyy-MM-dd")}' AND '{toDate.ToString("yyyy-MM-dd")}'"
                End If

                If Not String.IsNullOrWhiteSpace(filterText) Then
                    ' Concatenate relevant columns for search
                    query &= If(fromDate <> DateTime.MinValue OrElse toDate <> DateTime.MinValue, " AND ", " WHERE ")
                    query &= $"CONCAT(employee_id, employee_name, employee_position, time_in, time_out, date) LIKE '%{filterText}%'"
                End If

                Using command As New MySqlCommand(query, connection)
                    Using adapter As New MySqlDataAdapter(command)
                        Dim dataSet As New DataSet()
                        adapter.Fill(dataSet, "logs")

                        ' Bind the data to the specified columns of the existing DataGridView
                        existingDataGridView.DataSource = dataSet.Tables("logs")
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error loading transaction data: {ex.Message}")
        End Try
    End Sub

    Private Sub tbSearchTransaction_TextChanged(sender As Object, e As EventArgs) Handles tbSearchEmployee.TextChanged
        ' Handle the filter logic when the search text changes
        ' Load all transactions without applying the date filter
        LoadTransactionData(logsData, tbSearchEmployee.Text.Trim())
    End Sub

    Private Sub filterBtn_Click(sender As Object, e As EventArgs) Handles filterBtn.Click
        Dim fromDate As DateTime = fromDatePicker.Value
        Dim toDate As DateTime = toDatePicker.Value
        ' Pass the existing DataGridView to the LoadTransactionData method with the date range filtering
        LoadTransactionData(logsData, tbSearchEmployee.Text.Trim(), fromDate, toDate)
    End Sub

    Private Sub displayAllBtn_Click(sender As Object, e As EventArgs) Handles displayAllBtn.Click
        ' Reset current page to 1 when displaying all data
        LoadAllTransactionData(logsData)
        ' Optionally, you can clear the search text if needed
        tbSearchEmployee.Text = ""
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        ' Call the method to print all data
        PrintAllData(logsData, e)
    End Sub

    ' Method to print all data in the data grid view
    Private Sub PrintAllData(dataGridView As DataGridView, e As PrintPageEventArgs)
        ' Define the font and other formatting options
        Dim printFont As New Font("Arial", 10, FontStyle.Regular)
        Dim margin As Integer = 20
        Dim spaceBetweenSections As Integer = 10  ' Adjust this value for spacing
        Dim spaceBelowLine As Integer = 5  ' Adjust this value for bottom margin below the line
        Dim newPage As Boolean = False
        Dim yPos As Integer = margin

        ' Define column widths
        Dim columnWidths(dataGridView.Columns.Count - 1) As Integer

        ' Set specific widths for each column
        columnWidths(0) = 120 ' Width for the first column (Employee ID)
        columnWidths(1) = 280 ' Width for the second column (Employee Name)
        columnWidths(2) = 150 ' Width for the third column (Positionl)
        columnWidths(3) = 150  ' Width for the fourth column (Time-In)
        columnWidths(4) = 150 ' Width for the fifth column (Time-Out)
        columnWidths(5) = 120 ' Width for the sixth column (Date)

        ' Calculate total width
        Dim totalWidth As Integer = columnWidths.Sum()

        ' Calculate scaling factor to fit the data grid view within the printable area
        Dim scalingFactor As Single = CSng(e.MarginBounds.Width * 1.22) / CSng(totalWidth)

        ' Update column widths based on scaling factor
        For i As Integer = 0 To dataGridView.Columns.Count - 1
            columnWidths(i) = CInt(columnWidths(i) * scalingFactor)
        Next

        ' Print column headers
        Dim xPos As Integer = margin
        Dim format As New StringFormat() With {
        .Alignment = StringAlignment.Center
    }

        ' Define your custom column headers
        Dim customHeaders As String() = {"Employee ID", "Employee Name", "Position", "Time-In", "Time-Out", "Date"}

        ' Print column headers with custom names
        For i As Integer = 0 To customHeaders.Length - 1
            Dim headerText As String = customHeaders(i)
            e.Graphics.DrawString(headerText, printFont, Brushes.Black, New Rectangle(xPos, yPos, columnWidths(i), printFont.Height), format)

            xPos += columnWidths(i) ' Adjust xPos based on column width
        Next
        yPos += CInt(printFont.GetHeight()) + spaceBetweenSections  ' Move to the next line with added space

        ' Draw a horizontal line below headers
        Dim lineYPos As Integer = yPos
        e.Graphics.DrawLine(Pens.Black, margin, lineYPos, xPos, lineYPos)

        ' Move to the next line below the line with added space
        yPos += spaceBelowLine

        ' Loop through the data and print each row
        While currentPage < dataGridView.Rows.Count AndAlso Not newPage
            ' Reset xPos for data rows
            xPos = margin

            ' Loop through the columns and draw each cell
            For i As Integer = 0 To dataGridView.Columns.Count - 1
                Dim cellValue As String = dataGridView.Rows(currentPage).Cells(i).FormattedValue.ToString()

                ' Draw the cell
                e.Graphics.DrawString(cellValue, printFont, Brushes.Black, New Rectangle(xPos, yPos, columnWidths(i), printFont.Height), format)

                ' Move to the next column
                xPos += columnWidths(i)
            Next

            ' Move to the next line
            yPos += CInt(printFont.GetHeight()) + spaceBetweenSections  ' Move to the next line with added space

            ' Check if there are more lines to print on the current page
            If yPos + printFont.GetHeight() > e.MarginBounds.Bottom Then
                ' If there are more lines, set newPage to True
                newPage = True
                Exit While
            End If

            ' Move to the next row
            currentPage += 1
        End While

        ' Check if there are more pages to print
        If newPage Then
            e.HasMorePages = True
        Else
            ' Draw a horizontal line below the last row
            Dim lastLineYPos As Integer = yPos
            e.Graphics.DrawLine(Pens.Black, margin, lastLineYPos, xPos, lastLineYPos)

            ' Move to the next line
            yPos += spaceBetweenSections

            ' Reset for the next print job
            currentPage = 0
        End If
    End Sub

    Private Sub printBtn_Click(sender As Object, e As EventArgs) Handles printBtn.Click
        ' Set up PrintDialog
        Dim printDialog As New PrintDialog()
        printDialog.Document = PrintDocument1

        ' Set up PageSetupDialog
        Dim pageSetupDialog As New PageSetupDialog()
        pageSetupDialog.Document = PrintDocument1

        ' Set the initial values for page setup (optional)
        pageSetupDialog.PageSettings = PrintDocument1.DefaultPageSettings

        ' Show the PageSetupDialog
        If pageSetupDialog.ShowDialog() = DialogResult.OK Then
            ' If the user selects OK in PageSetupDialog, show PrintPreviewDialog
            Dim printPreviewDialog As New PrintPreviewDialog()
            printPreviewDialog.Document = PrintDocument1

            ' Show print preview
            If printDialog.ShowDialog() = DialogResult.OK Then
                printPreviewDialog.WindowState = FormWindowState.Maximized
                printPreviewDialog.ShowDialog()
            End If
        End If
    End Sub

End Class
