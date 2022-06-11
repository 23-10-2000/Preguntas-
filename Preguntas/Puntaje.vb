Imports System.Data.SqlClient

Public Class Puntaje
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub button1_Click(sender As Object, e As EventArgs)
        Me.Close() 'al oprimir este boton cerrara el programa


    End Sub

    Private Sub textBox4_TextChanged(sender As Object, e As EventArgs)

        'este label tendra la suma de todos los puntos obtenidos en las rondas
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim conexion As String
        conexion = ""
        Dim cn As New Sqlconnection
        cn.ConnectionString = conexion
    End Sub

    Private Sub button1_Click_1(sender As Object, e As EventArgs) Handles button1.Click
        Me.Close()
    End Sub
End Class