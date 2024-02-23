Imports System.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.Transactions
Imports MySql.Data.MySqlClient

Public Class paymentForm
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"
    Private _productNames As List(Of String)
    Private _productQuantities As List(Of Integer)
    Private _productSubtotals As List(Of Decimal)
    Private _productGrandTotals As List(Of Decimal)
    Private _subTotal As Decimal
    Private _totalAmount As Decimal
    Private _transactionID As String

    Public Property ProductNames() As List(Of String)
        Get
            Return _productNames
        End Get
        Set(ByVal value As List(Of String))
            _productNames = value
        End Set
    End Property

    Public Property ProductQuantities() As List(Of Integer)
        Get
            Return _productQuantities
        End Get
        Set(ByVal value As List(Of Integer))
            _productQuantities = value
        End Set
    End Property

    Public Property ProductSubtotals() As List(Of Decimal)
        Get
            Return _productSubtotals
        End Get
        Set(ByVal value As List(Of Decimal))
            _productSubtotals = value
        End Set
    End Property

    Public Property ProductGrandTotals() As List(Of Decimal)
        Get
            Return _productGrandTotals
        End Get
        Set(ByVal value As List(Of Decimal))
            _productGrandTotals = value
        End Set
    End Property

    Public Property SubTotal() As Decimal
        Get
            Return _subTotal
        End Get
        Set(ByVal value As Decimal)
            _subTotal = value
        End Set
    End Property

    Public Property TotalAmount() As Decimal
        Get
            Return _totalAmount
        End Get
        Set(ByVal value As Decimal)
            _totalAmount = value
        End Set
    End Property

    Public Property TransactionID() As String
        Get
            Return _transactionID
        End Get
        Set(ByVal value As String)
            _transactionID = value
        End Set
    End Property
    Private receivedAmount As Decimal ' Declare receivedAmount variable
    Private discount As Decimal ' Declare discount variable
    Private Sub RadioButton_CheckedChanged(sender As Object, e As EventArgs)
        If rbDiscounted.Checked Then
            ' Determine the discount based on the selected radio button
            Dim discountPercentage As Decimal = If(rbDiscounted.Checked, 0.05D, 0D) ' 5% discount if rbDiscounted is checked, otherwise 0%

            ' Calculate the total amount after applying the discount
            Dim totalAmountWithDiscount As Decimal = _totalAmount * (1 - discountPercentage)

            ' Calculate the change
            Dim change As Decimal = receivedAmount - totalAmountWithDiscount

            ' Update the change textbox
            tbChange.Text = If(change >= 0, $"{change.ToString("N2", CultureInfo.InvariantCulture)}", "Insufficient Amount")

            ' Update the grand total label
            lbl_grandTotal.Text = totalAmountWithDiscount.ToString("N2", CultureInfo.InvariantCulture)
        Else
            lbl_grandTotal.Text = _totalAmount
        End If
    End Sub

    Private Function CalculateTotalAmount() As Decimal
        ' Calculate total amount based on selected radio button
        Dim total As Decimal = _subTotal ' Assuming _subTotal holds the subtotal

        If rbDiscounted.Checked Then
            ' Apply discount if rbDiscounted is checked
            Dim discountPercentage As Decimal = 0.05D ' 5% discount
            total -= total * discountPercentage
        End If

        Return total
    End Function

    Private Sub UpdateChangeAndGrandTotal()
        ' Check if the received amount is a valid decimal value
        If Decimal.TryParse(tbReceivedAmount.Text, receivedAmount) Then
            ' Determine the discount based on the selected radio button
            Dim discountPercentage As Decimal = If(rbDiscounted.Checked, 0.05D, 0D) ' 5% discount if rbDiscounted is checked, otherwise 0%

            ' Calculate the total amount after applying the discount
            Dim totalAmountWithDiscount As Decimal = _totalAmount * (1 - discountPercentage)

            ' Calculate the change
            Dim change As Decimal = receivedAmount - totalAmountWithDiscount

            ' Update the change textbox
            tbChange.Text = If(change >= 0, $"{change.ToString("N2", CultureInfo.InvariantCulture)}", "Insufficient Amount")

            ' Update the grand total label
            lbl_grandTotal.Text = totalAmountWithDiscount.ToString("N2", CultureInfo.InvariantCulture)
        Else
            ' If the received amount is not a valid decimal value, clear the change textbox
            tbChange.Text = ""
        End If
    End Sub

    Private Sub tbReceivedAmount_TextChanged(sender As Object, e As EventArgs) Handles tbReceivedAmount.TextChanged, rbDiscounted.CheckedChanged, rbWithoutDiscount.CheckedChanged
        UpdateChangeAndGrandTotal()
    End Sub

    Private Sub tbReceivedAmount_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbReceivedAmount.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub
    Private Sub paymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbWithoutDiscount.Checked = True
        Console.WriteLine(TotalAmount.ToString("0.00"))
        ' Attach event handlers to the radio buttons
        AddHandler rbDiscounted.CheckedChanged, AddressOf RadioButton_CheckedChanged
        AddHandler rbWithoutDiscount.CheckedChanged, AddressOf RadioButton_CheckedChanged
    End Sub

    Private Sub cancelBtn_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        Me.Hide()
    End Sub
    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        Dim receivedAmount As Decimal
        If Decimal.TryParse(tbReceivedAmount.Text, receivedAmount) Then
            Dim discountPercentage As Decimal = If(rbDiscounted.Checked, 5D, 0D)
            Dim totalAmountWithDiscount As Decimal = TotalAmount * (1 - discountPercentage / 100)
            Dim change As Decimal = receivedAmount - totalAmountWithDiscount

            If change >= 0 Then
                ' Insert order details into the database for each product
                For i As Integer = 0 To ProductNames.Count - 1
                    Dim productName As String = ProductNames(i)
                    Dim quantity As Integer = ProductQuantities(i)
                    Dim subtotal As Decimal = ProductSubtotals(i) ' Get the subtotal for the current product
                    Dim grandTotal As Decimal = ProductGrandTotals(i) ' Get the grand total for the current product
                    InsertOrderDetails(TransactionID, productName, subtotal, quantity, grandTotal, DateTime.Now)
                Next
                ' Notify the user that the order details have been saved
                MessageBox.Show("Order details saved successfully!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ShowPrintPreview()

                ' Set DialogResult to OK and close the paymentForm
                DialogResult = DialogResult.OK
                Me.Close()
            Else
                MessageBox.Show("Insufficient amount. Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            tbChange.Text = "Invalid Input"
        End If
    End Sub

    Private Sub InsertOrderDetails(transactionID As String, productName As String, subTotal As Decimal, quantity As Integer, grandTotal As Decimal, transactionDate As DateTime)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Assuming the discount percentage is retrieved from the paymentForm's UI elements
                Dim discountPercentage As Decimal = If(rbDiscounted.Checked, 5D, 0D)

                Dim query As String = "INSERT INTO orders (transaction_id, product_name, sub_total, quantity, grand_total, transaction_date, employee_id) " &
                      "VALUES (@TransactionID, @ProductName, @SubTotal, @Quantity, @GrandTotal, @TransactionDate, @EmployeeID)"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@TransactionID", transactionID)
                    command.Parameters.AddWithValue("@ProductName", productName)
                    command.Parameters.AddWithValue("@SubTotal", subTotal * (1 - discountPercentage / 100))
                    command.Parameters.AddWithValue("@Quantity", quantity) ' Assuming quantity is always 1 for simplicity
                    command.Parameters.AddWithValue("@GrandTotal", grandTotal * (1 - discountPercentage / 100)) ' Use the grandTotal parameter
                    command.Parameters.AddWithValue("@TransactionDate", transactionDate)
                    command.Parameters.AddWithValue("@EmployeeID", employeeDashboard.EmployeeId) ' Assuming EmployeeId is accessible here

                    ' Execute the INSERT query
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            ' Handle the exception (e.g., log, display an error message)
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    ' Method to resize the image with high-quality interpolation
    Private Function ResizeImage(ByVal image As Image, ByVal width As Integer, ByVal height As Integer) As Image
        Dim resizedImage As New Bitmap(width, height)
        Using graphics As Graphics = Graphics.FromImage(resizedImage)
            graphics.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            graphics.DrawImage(image, 0, 0, width, height)
        End Using
        Return resizedImage
    End Function

    ' Create a PrintDocument instance
    Dim printDocument As New Printing.PrintDocument()
    Private Sub ShowPrintPreview()
        ' Attach the PrintPage event handler to the printDocument
        AddHandler printDocument.PrintPage, AddressOf PrintReceipt_PrintPage

        Dim customWidth As Integer = 219 ' Specify your custom width here

        ' Create customPaperSize object with specified width and default height
        Dim customPaperSize As New PaperSize("CustomSize", customWidth, printDocument.DefaultPageSettings.PaperSize.Height)

        ' Set the custom paper size to the print document
        printDocument.DefaultPageSettings.PaperSize = customPaperSize

        ' Print the document directly
        printDocument.Print()
    End Sub

    Private Sub PrintReceipt_PrintPage(sender As Object, e As Printing.PrintPageEventArgs)
        PrintAllDataForReceipt(e)
    End Sub

    Private Sub PrintAllDataForReceipt(e As Printing.PrintPageEventArgs)
        Dim OrderData = employeeDashboard.orderData

        ' Example values for the missing parameters
        Dim storeName As String = "Hermano's Pizzeria"
        Dim transactionID As String = employeeDashboard.lbl_transactionID.Text
        Dim transactionDate As String = DateTime.Now.ToString("yyyy-MM-dd hh:mm tt")
        Dim totalQuantities As Integer = employeeDashboard.lblQuantity.Text
        Dim cashierName As String = employeeDashboard.lbl_username.Text
        Dim totalAmount As Decimal = _totalAmount
        Dim receivedAmount As Decimal = tbReceivedAmount.Text

        ' Determine the discount percentage based on the selected radio button
        Dim discountPercentage As Decimal = If(rbDiscounted.Checked, 5D, 0D) ' Set discount to 5% if rbDiscounted is checked, otherwise 0%

        Dim changeAmount As Decimal = tbChange.Text

        PrintAllData(OrderData, e, storeName, transactionID, transactionDate, totalQuantities, cashierName, totalAmount, receivedAmount, discountPercentage, changeAmount)
    End Sub

    Private currentPage As Integer = 0
    Private firstPage As Boolean = True
    Private Sub PrintAllData(orderData As DataGridView, e As Printing.PrintPageEventArgs, storeName As String, transactionID As String, transactionDate As String, totalQuantities As Integer, cashierName As String, totalAmount As Decimal, receivedAmount As Decimal, discountPercentage As Decimal, changeAmount As Decimal)
        ' Define the font and other formatting options
        Dim addressFont As New Font("Calibri", 9, FontStyle.Regular) ' Modified printFont size
        Dim printFont As New Font("Calibri", 10, FontStyle.Regular) ' Modified printFont size
        Dim headingFont As New Font("Calibri", 14, FontStyle.Bold) ' Modified headingFont size
        Dim totalFont As New Font("Calibri", 12, FontStyle.Bold) ' New totalFont with bigger size and bold
        Dim spaceBetweenSections As Integer = 5 ' Adjust this value for spacing
        Dim spaceBelowLine As Integer = 3 ' Adjust this value for bottom margin below the line
        Dim tableMargin As Integer = 10 ' Margin above and below the table
        Dim newPage As Boolean = False
        Dim yPos As Integer = tableMargin ' Start yPos at the top with margin

        ' Add +20 spacing
        yPos += 20

        ' Define column widths
        Dim columnWidths(2) As Integer ' Adjust the size based on the number of columns you want to print

        ' Set specific widths for each column
        columnWidths(0) = 100 ' Width for the first column (Food name)
        columnWidths(1) = 30 ' Width for the second column (Qty)
        columnWidths(2) = 60 ' Width for the third column (Total)

        ' Calculate total width
        Dim totalWidth As Integer = columnWidths.Sum()

        ' Calculate scaling factor to fit the data grid view within the printable area
        Dim scalingFactor As Single = CSng(e.MarginBounds.Width) / CSng(totalWidth)

        ' Update column widths based on scaling factor
        For i As Integer = 0 To 2 ' Adjust the size based on the number of columns you want to print
            columnWidths(i) = CInt(columnWidths(i) * 1)
        Next

        ' Print logo and other details only on the first page
        If firstPage Then
            ' Print logo at the center
            Dim originalLogo As Image = My.Resources.logo_2
            Dim logoXPos As Integer = (e.PageBounds.Width - originalLogo.Width) \ 2 ' Calculate X position for center alignment
            Dim logoYPos As Integer = yPos ' Adjust the Y position as needed
            e.Graphics.DrawImage(originalLogo, logoXPos - 15, logoYPos) ' Draw the logo
            yPos += originalLogo.Height + spaceBetweenSections ' Move yPos to the next line with added space

            ' Draw store name at the center
            Dim centerMargin As Integer = e.PageBounds.Width / 2
            Dim storeNameFormat As New StringFormat
            storeNameFormat.Alignment = StringAlignment.Center
            e.Graphics.DrawString(storeName, headingFont, Brushes.Black, centerMargin - 10, yPos - 20, storeNameFormat)
            yPos += headingFont.Height + spaceBetweenSections + 20 ' Move to the next line with added space

            ' Split address into lines if it exceeds the maximum width
            Dim address As String = "10 Quezon Boulevard, Poblacion, Malasiqui, Pangasinan"
            Dim addressLines As New List(Of String)
            Dim addressWords() As String = address.Split(" "c)
            Dim currentLine As String = ""
            For Each word As String In addressWords
                Dim testString As String = currentLine & " " & word
                Dim testSize As SizeF = e.Graphics.MeasureString(testString, printFont)
                If testSize.Width > e.PageBounds.Width Then
                    addressLines.Add(currentLine)
                    currentLine = word
                Else
                    If currentLine = "" Then
                        currentLine = word
                    Else
                        currentLine &= " " & word
                    End If
                End If
            Next
            If currentLine <> "" Then
                addressLines.Add(currentLine)
            End If

            ' Calculate position to draw the address
            Dim addressYPos As Integer = yPos
            For Each line As String In addressLines
                Dim addressSize As SizeF = e.Graphics.MeasureString(line, addressFont)
                Dim addressXPos As Single = (e.PageBounds.Width - addressSize.Width) / 2
                e.Graphics.DrawString(line, printFont, Brushes.Black, addressXPos - 14, addressYPos - 20)
                addressYPos += CInt(addressSize.Height)
            Next

            yPos = addressYPos + 40
            yPos += spaceBetweenSections + 20 ' Move to the next line with added space

            ' Transaction details
            e.Graphics.DrawString("Transaction ID: " & transactionID, printFont, Brushes.Black, 0, yPos) ' Adjusted x-position
            yPos += printFont.GetHeight() ' Move to the next line

            e.Graphics.DrawString("Date: " & transactionDate, printFont, Brushes.Black, 0, yPos) ' Adjusted x-position
            yPos += printFont.GetHeight() + spaceBetweenSections ' Move to the next line with added space

            ' Order details
            e.Graphics.DrawString("No. Orders: " & totalQuantities.ToString(), printFont, Brushes.Black, 0, yPos) ' Adjusted x-position
            yPos += printFont.GetHeight() ' Move to the next line

            e.Graphics.DrawString("Cashier: " & cashierName, printFont, Brushes.Black, 0, yPos) ' Adjusted x-position
            yPos += printFont.GetHeight() + spaceBetweenSections ' Move to the next line with added space

            ' Draw a horizontal line below transaction details
            Dim lineYPos As Integer = yPos + 40
            e.Graphics.DrawLine(Pens.Black, 0, lineYPos, e.PageBounds.Width - 10, lineYPos) ' Adjusted starting x-position
            yPos += spaceBelowLine ' Move to the next line below the line with added space

            ' Print column headers
            Dim xPos As Integer = 0 ' Adjusted starting x-position
            Dim format As New StringFormat() With {.Alignment = StringAlignment.Near}

            ' Define your custom column headers
            Dim customHeaders As String() = {"Food Name", "Qty", "Total"}

            ' Print column headers with custom names (excluding the Price column)
            For i As Integer = 0 To customHeaders.Length - 1
                Dim headerText As String = customHeaders(i)
                Dim headerWidth As Integer = columnWidths(i)
                e.Graphics.DrawString(headerText, printFont, Brushes.Black, New Rectangle(xPos, yPos + 40, headerWidth, printFont.Height), format)
                xPos += headerWidth ' Adjust xPos based on column width
            Next
            yPos += CInt(printFont.GetHeight()) + spaceBetweenSections ' Move to the next line with added space

            ' Draw a horizontal line below headers
            Dim headerLineYPos As Integer = yPos + 40
            e.Graphics.DrawLine(Pens.Black, 0, headerLineYPos, e.PageBounds.Width - 10, headerLineYPos) ' Adjusted starting x-position

            ' Move to the next line below the line with added space
            yPos += spaceBelowLine

            firstPage = False ' Set the flag to false after printing on the first page
        End If

        ' Add margin above the table
        yPos += tableMargin

        ' Loop through the data and print each row
        While currentPage < orderData.Rows.Count AndAlso Not newPage
            ' Reset xPos for data rows
            Dim xPos As Integer = 0 ' Adjusted starting x-position

            ' Loop through the columns and draw each cell
            Dim foodNameIndex As Integer = 1 ' Index of Food Name
            Dim qtyIndex As Integer = 3 ' Index of Qty
            Dim totalIndex As Integer = 4 ' Index of Total

            Dim foodName As String = orderData.Rows(currentPage).Cells(foodNameIndex).FormattedValue.ToString()
            Dim qty As String = orderData.Rows(currentPage).Cells(qtyIndex).FormattedValue.ToString()
            Dim total As String = orderData.Rows(currentPage).Cells(totalIndex).FormattedValue.ToString()

            ' Calculate the required height for the food name cell
            Dim foodNameSize As SizeF = e.Graphics.MeasureString(foodName, printFont, columnWidths(0))

            ' Check if the height exceeds the current yPos
            Dim requiredHeight As Integer = CInt(Math.Ceiling(foodNameSize.Height))
            If requiredHeight > yPos Then
                ' Adjust yPos to fit the new height
                yPos = requiredHeight + 40
            End If

            ' Draw Food Name
            Dim foodNameFormat As New StringFormat()
            foodNameFormat.Alignment = StringAlignment.Near ' Align to the left
            Dim foodNameRect As New Rectangle(xPos, yPos + 40, columnWidths(0), requiredHeight)
            e.Graphics.DrawString(foodName, printFont, Brushes.Black, foodNameRect, foodNameFormat)

            ' Draw Qty
            Dim qtyFormat As New StringFormat()
            qtyFormat.Alignment = StringAlignment.Center
            Dim qtyRect As New Rectangle(xPos + columnWidths(0), yPos + 40, columnWidths(1), requiredHeight)
            e.Graphics.DrawString(qty, printFont, Brushes.Black, qtyRect, qtyFormat)

            ' Draw Total
            Dim totalFormat As New StringFormat()
            totalFormat.Alignment = StringAlignment.Center
            Dim totalRect As New Rectangle(xPos + columnWidths(0) + columnWidths(1), yPos + 40, columnWidths(2), requiredHeight)
            e.Graphics.DrawString(total, printFont, Brushes.Black, totalRect, totalFormat)

            ' Move to the next line
            yPos += requiredHeight + spaceBetweenSections ' Move to the next line with added space

            ' Check if there are more lines to print on the current page
            If yPos + printFont.GetHeight() > e.PageBounds.Bottom - tableMargin Then
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
            ' Additional details (Total, Received Amount, Discount, Change)
            Dim rightMargin As Integer = e.PageBounds.Right ' Calculate the right margin

            ' Draw a horizontal line below the last row
            Dim lastLineXPos As Integer = 0 + columnWidths(0) + columnWidths(1) + columnWidths(2) ' Adjusted starting x-position
            e.Graphics.DrawLine(Pens.Black, 0, yPos + 40, lastLineXPos, yPos + 40) ' Adjusted starting x-position

            ' Move to the next line
            yPos += spaceBetweenSections + 50

            Dim totalAmountWithDiscount As Decimal = totalAmount * (1 - discountPercentage / 100)
            ' Draw labels and values with right alignment
            e.Graphics.DrawString("Total:", totalFont, Brushes.Black, 0, yPos) ' Adjusted x-position
            e.Graphics.DrawString($"₱ {totalAmountWithDiscount.ToString("N2", CultureInfo.InvariantCulture)}", totalFont, Brushes.Black, rightMargin - 120, yPos) ' Modified to use totalFont
            yPos += totalFont.GetHeight() ' Adjusted to use totalFont's height

            e.Graphics.DrawString("Received Amount:", printFont, Brushes.Black, 0, yPos + 8) ' Adjusted x-position
            e.Graphics.DrawString($"₱ {receivedAmount.ToString("0.00")}", printFont, Brushes.Black, rightMargin - 100, yPos + 8) ' Adjusted x-position
            yPos += printFont.GetHeight()

            e.Graphics.DrawString("Discount:", printFont, Brushes.Black, 0, yPos + 8) ' Adjusted x-position
            e.Graphics.DrawString($"{discountPercentage}%", printFont, Brushes.Black, rightMargin - 100, yPos + 8) ' Adjusted x-position
            yPos += printFont.GetHeight()

            e.Graphics.DrawString("Change:", printFont, Brushes.Black, 0, yPos + 8) ' Adjusted x-position
            e.Graphics.DrawString($"₱ {changeAmount.ToString("0.00")}", printFont, Brushes.Black, rightMargin - 100, yPos + 8) ' Adjusted x-position
            yPos += printFont.GetHeight()
        End If
    End Sub

    Private Sub tbReceivedAmount_Enter(sender As Object, e As EventArgs) Handles tbReceivedAmount.Enter
        tbReceivedAmount.Text = ""
    End Sub
End Class
