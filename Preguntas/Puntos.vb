
Imports System.Data
Imports System.Data.OleDb


Module Puntos
    Public conexion As New OleDbConnection
    Public estado As String


    Sub enlace()
        Try
            conexion.ConnectionString = ""
        Catch ex As Exception

        End Try
    End Sub

End Module
