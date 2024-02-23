Public Class quantityForm
    ' Variable to store the entered quantity
    Private _quantity As Integer = 1

    ' Private variable to store the product name
    Private _productName As String = ""

    ' Private variable to store the product ID
    Private _productId As Integer = 0

    ' Public property to get the entered quantity
    Public Property Quantity As Integer
        Get
            Return _quantity
        End Get
        Set(value As Integer)
            _quantity = value
            UpdateQuantityLabel()
        End Set
    End Property

    ' Add a public property to get the value of tbQuantity
    Public ReadOnly Property UpdatedQuantity As Integer
        Get
            ' Return the value of tbQuantity as an integer
            Return Integer.Parse(tbQuantity.Text)
        End Get
    End Property
    ' Public property to set and get the product name
    Public Property FormProductName As String
        Get
            Return _productName
        End Get
        Set(value As String)
            _productName = value
        End Set
    End Property

    ' Public property to set and get the product ID
    Public Property ProductId As Integer
        Get
            Return _productId
        End Get
        Set(value As Integer)
            _productId = value
        End Set
    End Property

    ' Public property to set and get the product price
    Public Property ProductPrice As Decimal
        Get
            ' Implement logic to retrieve the product price based on your needs
            Return 0 ' Replace with actual logic
        End Get
        Set(value As Decimal)
            ' Implement logic to set the product price based on your needs
            ' Example: lblProductPrice.Text = value.ToString()
        End Set
    End Property

    Private Sub tbQuantity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbQuantity.KeyPress
        ' Allow digits, control characters (Backspace and Enter)
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
            Return
        End If

        ' Handle Backspace and Enter
        If e.KeyChar = ChrW(Keys.Back) OrElse e.KeyChar = ChrW(Keys.Enter) Then
            ' Process Backspace and Enter without further validation
            Return
        End If

        ' Get the current quantity value
        Dim currentText As String = tbQuantity.Text.TrimStart("0"c)
        Dim currentQuantity As Integer

        ' If the text is empty, set currentQuantity to 0
        If String.IsNullOrEmpty(currentText) Then
            currentQuantity = 0
        Else
            ' Use TryParse to handle the situation gracefully
            If Integer.TryParse(currentText, currentQuantity) Then
                ' Combine the current quantity with the entered digit
                Dim newValue As Integer
                If Integer.TryParse(e.KeyChar.ToString(), newValue) Then
                    newValue += currentQuantity * 10

                    ' Check if the combined value exceeds 999
                    If newValue > 999 Then
                        e.Handled = True
                    End If
                Else
                    ' Handle the case where the character cannot be parsed to an integer
                    e.Handled = True
                End If
            Else
                ' Handle the case where the text cannot be parsed to an integer
                e.Handled = True
            End If
        End If
    End Sub

    ' Handle TextChanged event of tbQuantity
    Private Sub tbQuantity_TextChanged(sender As Object, e As EventArgs) Handles tbQuantity.TextChanged
        ' Check if the text is a valid integer
        If Integer.TryParse(tbQuantity.Text, _quantity) Then
            ' Update the quantity label
            UpdateQuantityLabel()
        End If
    End Sub

    ' Handle Click event of the increase button
    Private Sub increaseBtn_Click(sender As Object, e As EventArgs) Handles increaseBtn.Click
        _quantity += 1
        UpdateQuantityLabel()
    End Sub

    ' Handle Click event of the decrease button
    Private Sub decreaseBtn_Click(sender As Object, e As EventArgs) Handles decreaseBtn.Click
        If _quantity > 0 Then
            _quantity -= 1
            UpdateQuantityLabel()
        End If
    End Sub

    ' Handle Click event of the confirm button
    Private Sub confirmBtn_Click(sender As Object, e As EventArgs) Handles confirmBtn.Click
        ' Close the form with DialogResult.OK
        DialogResult = DialogResult.OK
        Close()
    End Sub

    ' Update the quantity label with the current quantity
    Private Sub UpdateQuantityLabel()
        ' Update the quantity label in the employeeDashboard
        tbQuantity.Text = _quantity.ToString()
    End Sub
End Class
