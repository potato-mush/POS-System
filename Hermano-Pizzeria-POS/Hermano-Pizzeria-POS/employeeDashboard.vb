Imports Hermano_Pizzeria_POS.employeeDashboard
Imports MySql.Data.MySqlClient
Imports System.Globalization
Imports System.IO

Public Class employeeDashboard
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"

    Public Class Product
        Public Property ProductId As Integer
        Public Property ProductImage As Image
        Public Property ProductName As String
        Public Property ProductPrice As Decimal
        Public Property ProductSize As String
    End Class


    Private _employeeId As String
    Public Property EmployeeId() As String
        Get
            Return _employeeId
        End Get
        Set(ByVal value As String)
            _employeeId = value
        End Set
    End Property

    Private _employeeFirstName As String
    Public Property EmployeeFirstName() As String
        Get
            Return _employeeFirstName
        End Get
        Set(ByVal value As String)
            _employeeFirstName = value
        End Set
    End Property

    Private _employeeLastName As String
    Public Property EmployeeLastName() As String
        Get
            Return _employeeLastName
        End Get
        Set(ByVal value As String)
            _employeeLastName = value
        End Set
    End Property

    Private _employeeImage As Image
    Public Property EmployeeImage() As Image
        Get
            Return _employeeImage
        End Get
        Set(ByVal value As Image)
            _employeeImage = value
        End Set
    End Property

    Private Sub UpdateProfilePicture()
        ' Display the employee image in the PictureBox
        pbProfilePicture.Image = EmployeeImage
    End Sub
    Private Sub logoutBtn_Click(sender As Object, e As EventArgs) Handles logoutBtn.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            ' Update the 'logs' table with time_out
            UpdateLogoutTime(EmployeeId)

            Me.Close()
            loginForm.Show()
        End If
    End Sub
    Private Sub UpdateLogoutTime(employeeId As String)
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Update 'logs' table with time_out for the current session
            Dim query As String = "UPDATE logs SET time_out = @TimeOut WHERE employee_id = @EmployeeId AND time_out IS NULL AND date = @Date"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@EmployeeId", employeeId)
                command.Parameters.AddWithValue("@TimeOut", DateTime.Now.ToString("hh:mm tt")) ' 12-hour format
                command.Parameters.AddWithValue("@Date", DateTime.Now.Date)

                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub Timer_Tick(sender As Object, e As EventArgs)
        ' Call the UpdateDateTime function on each timer tick
        UpdateDateTime()
    End Sub

    Private Sub UpdateDateTime()
        ' Get the current date and time
        Dim currentDateTime As DateTime = DateTime.Now

        ' Update the text properties of the labels
        lbl_time.Text = "Time :       " & currentDateTime.ToString("hh:mm:ss tt") ' Format time as hours:minutes:seconds
        lbl_date.Text = "Date :       " & currentDateTime.ToString("yyyy-MM-dd") ' Format date as year-month-day
        ' Display employee_fname and employee_lname in lbl_username
        lbl_username.Text = $"{EmployeeFirstName} {EmployeeLastName}"
        UpdateProfilePicture()
    End Sub
    Private Sub LoadProducts()
        ' Clear existing controls in FlowLayoutPanel
        FlowLayoutPanel1.Controls.Clear()

        ' Fetch product data based on the selected category
        Dim selectedCategory As String = cbCategory.SelectedItem?.ToString()

        ' Fetch search keyword from the textbox
        Dim searchKeyword As String = tbSearchProduct.Text.Trim()

        ' Call the SearchProducts function to get the filtered products
        Dim products As List(Of Product)

        ' Check if the search keyword is blank
        If String.IsNullOrWhiteSpace(searchKeyword) Then
            ' If the search keyword is blank, load all products
            products = GetProductsFromDatabase(selectedCategory)
        Else
            ' If the search keyword is not blank, filter products based on search criteria
            products = SearchProducts(searchKeyword)
        End If

        ' Loop through each product and create controls dynamically
        For Each product In products
            ' Create a panel for each product
            Dim panel As New Panel()
            panel.BorderStyle = BorderStyle.FixedSingle
            panel.Size = New Size(250, 320) ' Increase the size by 50 pixels

            ' Create PictureBox for product image
            Dim pictureBox As New PictureBox()
            pictureBox.Image = product.ProductImage
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom
            pictureBox.Size = New Size(250, 150) ' Adjust the size of PictureBox
            pictureBox.Dock = DockStyle.Top

            ' Create labels for product name, size, and price
            Dim nameLabel As New Label()
            nameLabel.ForeColor = Color.White
            nameLabel.Font = New Font(nameLabel.Font.FontFamily, 14, FontStyle.Bold) ' Increase font size
            nameLabel.Text = product.ProductName
            nameLabel.AutoSize = False
            nameLabel.Size = New Size(230, 50) ' Adjust the size of the label
            nameLabel.Location = New Point(10, 160)
            nameLabel.TextAlign = ContentAlignment.TopLeft

            Dim sizeLabel As New Label()
            sizeLabel.ForeColor = Color.Orange
            sizeLabel.Font = New Font(sizeLabel.Font.FontFamily, 12, FontStyle.Regular) ' Increase font size
            sizeLabel.AutoSize = False
            sizeLabel.Size = New Size(230, 50) ' Adjust the size of the label
            sizeLabel.Location = New Point(10, 210)
            sizeLabel.TextAlign = ContentAlignment.TopLeft

            ' Check if ProductSize is not null or empty before adding the label
            If Not String.IsNullOrEmpty(product.ProductSize) Then
                sizeLabel.Text = "Size: " & product.ProductSize
                panel.Controls.Add(sizeLabel) ' Add the size label to the panel
            End If

            Dim priceLabel As New Label()

            ' Check the product status using product_id
            If IsProductAvailable(product.ProductId) Then
                ' If the product is available, set the price and color
                priceLabel.Text = "Price: ₱" & product.ProductPrice.ToString("0.00")
                priceLabel.ForeColor = Color.FromArgb(128, 255, 128)
            Else
                ' If the product is not available, set the label text and color
                priceLabel.Text = "Not Available"
                priceLabel.ForeColor = Color.Red
                ' Disable the panel
                panel.Enabled = False
            End If

            panel.Tag = product.ProductId

            priceLabel.Font = New Font(priceLabel.Font.FontFamily, 12, FontStyle.Regular) ' Increase font size
            priceLabel.AutoSize = False
            priceLabel.Size = New Size(230, 50) ' Adjust the size of the label
            priceLabel.Location = New Point(10, 260)
            priceLabel.TextAlign = ContentAlignment.TopLeft

            ' Add controls to the panel
            panel.Controls.Add(pictureBox)
            panel.Controls.Add(nameLabel)
            panel.Controls.Add(sizeLabel)
            panel.Controls.Add(priceLabel)

            ' Set the cursor to hand for clickable components
            pictureBox.Cursor = Cursors.Hand
            nameLabel.Cursor = Cursors.Hand
            sizeLabel.Cursor = Cursors.Hand
            priceLabel.Cursor = Cursors.Hand
            panel.Cursor = Cursors.Hand

            ' Add a click event handler to the panel
            AddHandler panel.Click, Sub(sender, e) AddToOrder(product)
            AddHandler pictureBox.Click, Sub(sender, e) AddToOrder(product)
            AddHandler nameLabel.Click, Sub(sender, e) AddToOrder(product)
            AddHandler sizeLabel.Click, Sub(sender, e) AddToOrder(product)
            AddHandler priceLabel.Click, Sub(sender, e) AddToOrder(product)

            ' Add the panel to the FlowLayoutPanel
            FlowLayoutPanel1.Controls.Add(panel)
        Next
    End Sub
    Private Function IsProductAvailable(productId As Integer) As Boolean
        ' Implement logic to check the product status from the database
        ' Assume that you have a table named 'menu' with a column 'product_status'
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT product_status FROM menu WHERE product_id = @ProductId"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@ProductId", productId)

                ' Execute the query
                Dim productStatus As String = Convert.ToString(command.ExecuteScalar())

                ' Check if the product is available
                Return String.Equals(productStatus, "AVAILABLE", StringComparison.OrdinalIgnoreCase)
            End Using
        End Using
    End Function
    ' Class-level variable to store the current product
    Private currentProduct As Product = Nothing

    Private Sub AddToOrder(product As Product)
        ' Set the current product
        currentProduct = product

        ' Check if the product is already in the order
        Dim existingRow As DataGridViewRow = FindProductInOrder(product.ProductSize, product.ProductName)

        If existingRow IsNot Nothing Then
            ' If the product is already in the order, update the quantity and total
            Dim quantity As Integer = CInt(existingRow.Cells("Column4").Value)
            existingRow.Cells("Column4").Value = quantity
            existingRow.Cells("Column5").Value = quantity * product.ProductPrice
        Else
            ' If the product is not in the order, add a new row
            Dim rowIndex As Integer = orderData.Rows.Add()
            Dim newRow As DataGridViewRow = orderData.Rows(rowIndex)
            newRow.Cells("Column1").Value = rowIndex + 1 ' Auto-increment the order number
            newRow.Cells("Column2").Value = $"{product.ProductSize} {product.ProductName}" ' Include size before product name
            newRow.Cells("Column3").Value = product.ProductPrice
            newRow.Cells("Column4").Value = 1 ' Initial quantity
            newRow.Cells("Column5").Value = product.ProductPrice ' Initial total
        End If

        ' Update the total amount display
        UpdateTotal()
        UpdateQuantityLabel()

        ' Show the quantityForm to get the quantity from the user
        Dim quantityForm As New quantityForm()

        ' Pass the product information to quantityForm
        quantityForm.FormProductName = $"{product.ProductSize} {product.ProductName}"
        quantityForm.ProductPrice = product.ProductPrice

        ' Show quantityForm as a dialog
        If quantityForm.ShowDialog() = DialogResult.OK Then
            ' Retrieve the entered quantity from the quantityForm
            Dim enteredQuantity As Integer = quantityForm.Quantity

            ' Update the quantity in the orderData DataGridView
            If enteredQuantity > 0 Then
                ' If the current product is set, update the quantity for that product
                If currentProduct IsNot Nothing Then
                    Dim selectedRow As DataGridViewRow = FindProductInOrder(currentProduct.ProductSize, currentProduct.ProductName)

                    If selectedRow IsNot Nothing Then
                        selectedRow.Cells("Column4").Value = enteredQuantity
                        selectedRow.Cells("Column5").Value = enteredQuantity * product.ProductPrice

                        ' Update the total amount display
                        UpdateTotal()
                        UpdateQuantityLabel()
                    End If
                End If
            Else
                ' If the entered quantity is zero or less, remove the row from the orderData
                orderData.Rows.RemoveAt(orderData.CurrentRow.Index)

                ' Update the total amount display
                UpdateTotal()

                ' Update the quantity label
                UpdateQuantityLabel()
            End If
        End If
    End Sub

    Private Function FindProductInOrder(productSize As String, productName As String) As DataGridViewRow
        ' Search for the product in the order DataGridView based on size and product name
        For Each row As DataGridViewRow In orderData.Rows
            Dim rowProductName As String = row.Cells("Column2").Value.ToString()

            ' Check if the rowProductName contains both the size and product name information
            If rowProductName.StartsWith($"{productSize} {productName}") Then
                Return row
            End If
        Next

        ' Return Nothing if the product is not found
        Return Nothing
    End Function
    Private Function GetProductsFromDatabase(Optional category As String = "") As List(Of Product)
        Dim products As New List(Of Product)()

        ' Connect to the database and retrieve product data based on the selected category
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String

            If String.IsNullOrEmpty(category) Then
                ' If no category is specified, fetch all products
                query = "SELECT product_id, product_image, product_name, product_price, product_size FROM menu"
            Else
                ' If a category is specified, fetch products for that category
                query = "SELECT product_id, product_image, product_name, product_price, product_size FROM menu WHERE product_category = @Category"
            End If

            Using command As New MySqlCommand(query, connection)
                ' Add a parameter for the category, if specified
                If Not String.IsNullOrEmpty(category) Then
                    command.Parameters.AddWithValue("@Category", category)
                End If

                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Create a Product instance for each row in the result set
                        Dim product As New Product()
                        product.ProductId = Convert.ToInt32(reader("product_id"))
                        product.ProductImage = LoadImageFromDatabase(reader("product_image"))
                        product.ProductName = reader("product_name").ToString()
                        product.ProductPrice = Convert.ToDecimal(reader("product_price"))
                        product.ProductSize = reader("product_size").ToString()

                        ' Add the product instance to the list
                        products.Add(product)
                    End While
                End Using
            End Using
        End Using

        Return products
    End Function
    Private Sub UpdateTotal()
        ' Calculate the total amount from the orderData DataGridView
        Dim totalAmount As Decimal = 0
        For Each row As DataGridViewRow In orderData.Rows
            ' Check if the value in Column5 is a valid Decimal
            Dim totalValue As Decimal
            If Decimal.TryParse(row.Cells("Column5").Value.ToString(), totalValue) Then
                totalAmount += totalValue
            End If
        Next

        ' Format the total amount with currency symbol, commas, and "M" for millions
        lbl_total.Text = "₱ " & totalAmount.ToString("N2", CultureInfo.InvariantCulture)
    End Sub
    Private Sub UpdateQuantityLabel()
        Dim totalQuantity As Integer = 0

        ' Loop through each row in the orderData DataGridView
        For Each row As DataGridViewRow In orderData.Rows
            ' Check if the cell value is a valid integer
            If Integer.TryParse(row.Cells("Column4").Value.ToString(), 0) Then
                totalQuantity += Convert.ToInt32(row.Cells("Column4").Value)
            End If
        Next

        ' Update the lblQuantity with the total quantity
        lblQuantity.Text = totalQuantity
    End Sub
    Private Function SearchProducts(keyword As String) As List(Of Product)
        Dim products As New List(Of Product)()

        ' Connect to the database and retrieve product data based on the search keyword
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Create a SQL query to select product data based on the search keyword
            Dim query As String = "SELECT product_image, product_name, product_price, product_size, product_id FROM menu " &
                              "WHERE product_name LIKE @Keyword OR product_size LIKE @Keyword"

            Using command As New MySqlCommand(query, connection)
                ' Add a parameter for the search keyword
                command.Parameters.AddWithValue("@Keyword", $"%{keyword}%")

                Using reader As MySqlDataReader = command.ExecuteReader()
                    While reader.Read()
                        ' Create a Product instance for each row in the result set
                        Dim product As New Product()
                        product.ProductImage = LoadImageFromDatabase(reader("product_image"))
                        product.ProductName = reader("product_name").ToString()
                        product.ProductPrice = Convert.ToDecimal(reader("product_price"))
                        product.ProductSize = reader("product_size").ToString()
                        product.ProductId = Convert.ToInt32(reader("product_id"))

                        ' Add the product to the list without checking availability
                        products.Add(product)
                    End While
                End Using
            End Using
        End Using

        Return products
    End Function

    Private Sub tbSearchProduct_TextChanged(sender As Object, e As EventArgs) Handles tbSearchProduct.TextChanged
        ' Load products based on the selected category and search keyword when the search input changes
        LoadProducts()
    End Sub

    Private Sub cbCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCategory.SelectedIndexChanged
        ' Load products based on the selected category when the ComboBox selection changes
        LoadProducts()
    End Sub

    Private Sub LoadCategories()
        ' Clear existing items in the ComboBox
        cbCategory.Items.Clear()

        ' Establish a database connection
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            ' Create a SQL query to select category names
            Dim query As String = "SELECT category_name FROM category"

            ' Execute the query
            Using command As New MySqlCommand(query, connection)
                ' Read the data
                Using reader As MySqlDataReader = command.ExecuteReader()
                    ' Loop through the results and add them to the ComboBox
                    While reader.Read()
                        cbCategory.Items.Add(reader("category_name").ToString())
                    End While
                End Using
            End Using
        End Using
    End Sub
    Private Function GenerateUniqueTransactionID() As Integer
        Dim random As New Random()
        Dim transactionID As Integer

        ' Loop until a unique transaction ID is generated
        Do
            transactionID = random.Next(1000000, 9999999)
        Loop While IsTransactionIDExists(transactionID)

        Return transactionID
    End Function
    Private Function IsTransactionIDExists(transactionID As Integer) As Boolean
        Using connection As New MySqlConnection(connectionString)
            connection.Open()

            Dim query As String = "SELECT COUNT(*) FROM orders WHERE transaction_id = @TransactionID"
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@TransactionID", transactionID)

                ' Check if the transaction ID already exists
                Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                Return count > 0
            End Using
        End Using
    End Function

    Private Function LoadImageFromDatabase(imageData As Object) As Image
        ' Implement logic to convert image data from the database into an Image
        ' Example assumes the image data is stored as a byte array in the database
        If imageData IsNot DBNull.Value Then
            Dim imageBytes As Byte() = DirectCast(imageData, Byte())
            Using stream As New MemoryStream(imageBytes)
                Return Image.FromStream(stream)
            End Using
        Else
            ' Return a default image if the database field is NULL
            Return My.Resources.defaultImage
        End If
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Call the UpdateDateTime function when the form is loaded
        UpdateDateTime()
        LoadProducts()
        LoadCategories()
        cbCategory.SelectedIndex = 0
        Dim transactionID As Integer = GenerateUniqueTransactionID()
        lbl_transactionID.Text = transactionID.ToString()

        ' Use a Timer to update the date and time every second
        Dim timer As New Timer()
        AddHandler timer.Tick, AddressOf Timer_Tick
        timer.Interval = 1000 ' Set the interval to 1000 milliseconds (1 second)
        timer.Start()
    End Sub
    Public Sub ProcessOrderConfirmation(totalAmount As Decimal, receivedAmount As Decimal, discount As Decimal)
        ' Get the current date and time
        Dim transactionDate As DateTime = DateTime.Now

        ' Get the employee ID (replace "Me.EmployeeId" with the actual instance of your form)
        Dim employeeID As String = Me.EmployeeId

        ' Iterate through the rows of the DataGridView (replace "orderData" with the actual instance of your DataGridView)
        For Each row As DataGridViewRow In orderData.Rows
            ' Extract information from the DataGridView
            Dim productName As String = row.Cells("Column2").Value.ToString()
            Dim subTotal As Decimal = Convert.ToDecimal(row.Cells("Column3").Value)
            Dim quantity As Integer = Convert.ToInt32(row.Cells("Column4").Value)
            Dim grandTotal As Decimal = Convert.ToDecimal(row.Cells("Column5").Value)

            ' Insert the data into your database table
            InsertOrderDetails(lbl_transactionID.Text, productName, subTotal, quantity, grandTotal, transactionDate, employeeID)
        Next

        ' Notify the user that the order has been submitted
        MessageBox.Show("Order submitted successfully!", "Order Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information)

        ' Generate a new transaction ID for the next order
        Dim newTransactionID As Integer = GenerateUniqueTransactionID()
        lbl_transactionID.Text = newTransactionID.ToString()

        ' Optionally, clear the orderData DataGridView or perform any other necessary actions
        'cbCategory.SelectedIndex = 0
        orderData.Rows.Clear()
        lblQuantity.Text = "0"
        lbl_total.Text = "₱ 00.00"
    End Sub
    Private Sub orderBtn_Click(sender As Object, e As EventArgs) Handles orderBtn.Click
        ' Check if there are any items in the order
        If orderData.Rows.Count = 0 Then
            MessageBox.Show("There are no items in the order.", "Empty Order", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        ' Extract the total amount from the label
        Dim totalAmountString As String = lbl_total.Text.Replace("₱ ", "")
        Dim totalAmount As Decimal

        ' Parse the total amount
        If Decimal.TryParse(totalAmountString, totalAmount) Then
            ' Get the transaction ID
            Dim transactionID As String = lbl_transactionID.Text

            ' Create lists to store product names, quantities, subtotals, and grand totals
            Dim productNames As New List(Of String)()
            Dim productQuantities As New List(Of Integer)()
            Dim productSubtotals As New List(Of Decimal)()
            Dim productGrandTotals As New List(Of Decimal)()

            ' Calculate the subtotal
            Dim subTotal As Decimal = 0

            ' Iterate through the rows of the orderData DataGridView to retrieve product names, quantities, subtotals, and grand totals
            For Each row As DataGridViewRow In orderData.Rows
                Dim productName As String = row.Cells("Column2").Value.ToString()
                Dim quantity As Integer = Convert.ToInt32(row.Cells("Column4").Value)
                Dim subTotalPerItem As Decimal = Convert.ToDecimal(row.Cells("Column3").Value)
                Dim grandTotalPerItem As Decimal = Convert.ToDecimal(row.Cells("Column5").Value)

                ' Add product name, quantity, subtotal, and grand total to their respective lists
                productNames.Add(productName)
                productQuantities.Add(quantity)
                productSubtotals.Add(subTotalPerItem)
                productGrandTotals.Add(grandTotalPerItem)
                subTotal += subTotalPerItem
            Next

            ' Create an instance of paymentForm and set the TotalAmount, SubTotal, TransactionID, ProductNames, ProductQuantities, ProductSubtotals, and ProductGrandTotals properties
            Dim paymentFormInstance As New paymentForm()
            paymentFormInstance.TotalAmount = totalAmount
            paymentFormInstance.SubTotal = subTotal
            paymentFormInstance.TransactionID = transactionID
            paymentFormInstance.ProductNames = productNames
            paymentFormInstance.ProductQuantities = productQuantities
            paymentFormInstance.ProductSubtotals = productSubtotals
            paymentFormInstance.ProductGrandTotals = productGrandTotals
            paymentFormInstance.Owner = Me
            paymentFormInstance.ShowDialog()

            ' Clear the order data (DataGridView) after processing
            orderData.Rows.Clear()
            lbl_total.Text = "₱ 00.00"
            lblQuantity.Text = "0"
            Dim newTransactionID As Integer = GenerateUniqueTransactionID()
            lbl_transactionID.Text = newTransactionID.ToString()
        Else
            MessageBox.Show("Invalid total amount format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub InsertOrderDetails(transactionID As String, productName As String, subTotal As Decimal, quantity As Integer, grandTotal As Decimal, transactionDate As DateTime, employeeID As String)
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                Dim query As String = "INSERT INTO orders (transaction_id, product_name, sub_total, quantity, grand_total, transaction_date, employee_id) " &
                                      "VALUES (@TransactionID, @ProductName, @SubTotal, @Quantity, @GrandTotal, @TransactionDate, @EmployeeID)"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@TransactionID", transactionID)
                    command.Parameters.AddWithValue("@ProductName", productName)
                    command.Parameters.AddWithValue("@SubTotal", subTotal)
                    command.Parameters.AddWithValue("@Quantity", quantity)
                    command.Parameters.AddWithValue("@GrandTotal", grandTotal)
                    command.Parameters.AddWithValue("@TransactionDate", transactionDate)
                    command.Parameters.AddWithValue("@EmployeeID", employeeID)

                    ' Execute the INSERT query
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As MySqlException
            ' Handle the exception (e.g., log, display an error message)
            MessageBox.Show($"Error: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub orderData_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles orderData.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex = orderData.Columns("deleteItemBtn").Index Then
            ' Ask for confirmation before deleting the item
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this item?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If result = DialogResult.Yes Then
                ' Remove the selected row
                orderData.Rows.RemoveAt(e.RowIndex)
                ' Update the total amount display
                UpdateTotal()

                ' Update the quantity label
                UpdateQuantityLabel()
            End If
        ElseIf e.RowIndex >= 0 AndAlso e.ColumnIndex = orderData.Columns("Column4").Index Then
            Dim currentQuantity As Integer = CInt(orderData.Rows(e.RowIndex).Cells("Column4").Value)

            ' Show the quantityForm to get the updated quantity from the user
            Dim quantityForm As New quantityForm()

            ' Pass the current quantity to quantityForm
            quantityForm.Quantity = currentQuantity

            ' Show quantityForm as a dialog
            If quantityForm.ShowDialog() = DialogResult.OK Then
                ' Retrieve the updated quantity from the quantityForm
                Dim updatedQuantity As Integer = quantityForm.UpdatedQuantity

                ' Check if the product is already in the order
                Dim existingRow As DataGridViewRow = FindProductInOrder(currentProduct.ProductSize, currentProduct.ProductName)

                If existingRow IsNot Nothing AndAlso existingRow.Index = e.RowIndex Then
                    ' If the product is already in the order and it's the clicked row, update the quantity and total
                    existingRow.Cells("Column4").Value = updatedQuantity
                    existingRow.Cells("Column5").Value = updatedQuantity * CDec(existingRow.Cells("Column3").Value)
                Else
                    ' If the product is not in the order or it's in a different row, update the quantity and total of the clicked row
                    orderData.Rows(e.RowIndex).Cells("Column4").Value = updatedQuantity
                    orderData.Rows(e.RowIndex).Cells("Column5").Value = updatedQuantity * CDec(orderData.Rows(e.RowIndex).Cells("Column3").Value)
                End If

                ' Update the total amount display
                UpdateTotal()

                ' No need to call UpdateQuantityLabel() here since it's specific to quantityForm
            End If
        End If

    End Sub

    Private Sub Panel9_Click(sender As Object, e As EventArgs) Handles Panel9.Click, lbl_username.Click, pbProfilePicture.Click
        ' Instantiate the changePassword form
        Dim changePasswordForm As New ChangePassword()

        ' Set the EmployeeId property in the changePassword form
        changePasswordForm.EmployeeId = Me.EmployeeId

        ' Show the changePassword form
        changePasswordForm.ShowDialog()
    End Sub
End Class