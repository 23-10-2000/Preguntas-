Public Class Bienvenida
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click



        Tema_1.Show() 'esto hara que al dar clic en el boton valla a otra venta
        Me.Hide()   'y al poner esto se ocultara la ventana actual



    End Sub

    Private Sub textBox2_TextChanged(sender As Object, e As EventArgs) Handles TxtbNombre.TextChanged

    End Sub

    Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged

    End Sub
End Class