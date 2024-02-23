Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class homeControl
    Dim connectionString As String = "Server=localhost;Database=hermano_db;User ID=root;Password=;Pooling=false;"

    Sub DisplayTotalRevenue()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Calculate total revenue
                Dim query As String = "SELECT SUM(grand_total) FROM orders"

                Using command As New MySqlCommand(query, connection)
                    Dim totalRevenue As Object = command.ExecuteScalar()

                    If totalRevenue IsNot DBNull.Value Then
                        ' Format total revenue with currency symbol, commas, and "M" for millions
                        Dim revenue As Decimal = Convert.ToDecimal(totalRevenue)
                        If revenue >= 1000000 Then
                            lbl_revenue.Text = $"₱ {revenue / 1000000:N2}M"
                        Else
                            lbl_revenue.Text = $"₱ {revenue:N2}"
                        End If
                    Else
                        lbl_revenue.Text = "₱ 0.00"
                    End If
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error calculating total revenue: {ex.Message}")
        End Try
    End Sub

    Sub DisplayTotalEmployee()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Calculate total revenue
                Dim query As String = "SELECT COUNT(employee_id) FROM employee"

                Using command As New MySqlCommand(query, connection)
                    Dim totalEmployee As Object = command.ExecuteScalar()

                    lbl_employee.Text = totalEmployee
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error calculating total employee: {ex.Message}")
        End Try
    End Sub
    Sub DisplayTotalMenu()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Calculate total revenue
                Dim query As String = "SELECT COUNT(product_name) FROM menu"

                Using command As New MySqlCommand(query, connection)
                    Dim totalMenuItems As Object = command.ExecuteScalar()

                    lbl_menu.Text = totalMenuItems
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error calculating total menu: {ex.Message}")
        End Try
    End Sub
    Sub DisplayTotalCategories()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Calculate total revenue
                Dim query As String = "SELECT COUNT(category_name) FROM category"

                Using command As New MySqlCommand(query, connection)
                    Dim totalCategories As Object = command.ExecuteScalar()

                    lbl_categories.Text = totalCategories
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error calculating total categories: {ex.Message}")
        End Try
    End Sub
    Sub DisplayTotalTransactions()
        Try
            Using connection As New MySqlConnection(connectionString)
                connection.Open()

                ' Calculate total revenue
                Dim query As String = "SELECT COUNT(DISTINCT transaction_id) FROM orders"

                Using command As New MySqlCommand(query, connection)
                    Dim totalTransactions As Object = command.ExecuteScalar()

                    lbl_transactions.Text = totalTransactions
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error calculating total categories: {ex.Message}")
        End Try
    End Sub
    Private Sub homeControl_Load(sender As Object, e As EventArgs) Handles Me.Load
        DisplayTotalRevenue()
        DisplayTotalEmployee()
        DisplayTotalMenu()
        DisplayTotalCategories()
        DisplayTotalTransactions()
    End Sub
End Class
