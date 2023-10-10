Imports System.Configuration
Imports System.Data.SqlClient

Public Class BasicCrud

    Public Shared Function GetConnection() As SqlConnection
        Dim connectionString As String = ConfigurationManager.ConnectionStrings("dbconnection_practiceCrud").ConnectionString
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        Return connection
    End Function
    Public Sub Create()
        Using connection As SqlConnection = GetConnection()
            Dim query As String = "INSERT INTO Users(firstName, middleName, lastName, email)" &
                                  "VALUES(@firstName, @middleName, @lastName, @email)"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@firstName", txtBox_FirstName.Text)
            command.Parameters.AddWithValue("@middleName", txtBox_middleName.Text)
            command.Parameters.AddWithValue("@lastName", txtBox_LastName.Text)
            command.Parameters.AddWithValue("@email", txtBox_Email.Text)
            command.ExecuteNonQuery()
        End Using
        Read()
    End Sub

    Public Sub Read()
        Using connection As SqlConnection = GetConnection()
            Dim query As String = "SELECT * FROM Users"
            Dim data As New SqlDataAdapter(query, connection)
            Dim dataTable As New DataTable
            data.Fill(dataTable)

            UsersTable.DataSource = dataTable
        End Using
    End Sub

    Public Sub Update()
        Using connection As SqlConnection = GetConnection()
            Dim query As String = "UPDATE Users SET " &
            "firstName = @firstName, middleName = @middleName, lastName = @lastName, email = @email " &
            "WHERE id = @id"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@firstName", txtBox_update_firstName.Text)
            command.Parameters.AddWithValue("@middleName", txtBox_update_middleName.Text)
            command.Parameters.AddWithValue("@lastName", txtBox_update_lastName.Text)
            command.Parameters.AddWithValue("@email", txtBox_update_email.Text)
            command.Parameters.AddWithValue("@id", txtBox_update_id.Text)
            command.ExecuteNonQuery()
        End Using
        Read()
    End Sub

    Public Sub Delete()
        Using connection As SqlConnection = GetConnection()
            Dim query As String = "DELETE FROM Users WHERE id = @id"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@id", txtBox_delete_id.Text)
            command.ExecuteNonQuery()
        End Using
        Read()
    End Sub

    Private Sub btn_create_Click(sender As Object, e As EventArgs) Handles btn_create.Click
        Create()
    End Sub

    Private Sub btn_read_Click(sender As Object, e As EventArgs) Handles btn_read.Click
        Read()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        Update()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        Delete()
    End Sub
End Class