Public Class Tema_1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub



    Private Sub Lblcorrecta_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub R1C_CheckedChanged(sender As Object, e As EventArgs) Handles R1C.CheckedChanged



    End Sub



    Private Sub BtnVerificar1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub

    Dim Correctas As Integer 'me ayudara a llevar los puntos obtenidos en la ronda
    Private Sub R1d_CheckedChanged(sender As Object, e As EventArgs) Handles R1d.CheckedChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If R1d.Checked Then
            Correctas = Correctas + 1     'al tener esto verificara si esta bien la respuesta y sumara un punto si lo es
            Label3.Text = Correctas

        End If

        GroupBox1.Enabled = False 'esto sirve para que una vez que se verifique la pregunta, ya no se pueda responder de nuevo
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If RadioButton3.Checked Then
            Correctas = Correctas + 1   'al tener esto verificara si esta bien la respuesta y sumara un punto si lo es
            Label3.Text = Correctas

        End If

        GroupBox2.Enabled = False  'esto sirve para que una vez que se verifique la pregunta, ya no se pueda responder de nuevo
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If RadioButton5.Checked Then
            Correctas = Correctas + 1  'al tener esto verificara si esta bien la respuesta y sumara un punto si lo es
            Label3.Text = Correctas

        End If

        GroupBox3.Enabled = False  'esto sirve para que una vez que se verifique la pregunta, ya no se pueda responder de nuevo
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If RadioButton9.Checked Then
            Correctas = Correctas + 1  'al tener esto verificara si esta bien la respuesta y sumara un punto si lo es
            Label3.Text = Correctas

        End If

        GroupBox4.Enabled = False  'esto sirve para que una vez que se verifique la pregunta, ya no se pueda responder de nuevo
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If RadioButton15.Checked Then
            Correctas = Correctas + 1  'al tener esto verificara si esta bien la respuesta y sumara un punto si lo es
            Label3.Text = Correctas

        End If

        GroupBox5.Enabled = False  'esto sirve para que una vez que se verifique la pregunta, ya no se pueda responder de nuevo
    End Sub

    'al tener todos los demas formularios copiados de este, se tendran los mismos codigos, donde lo unico que 
    'cambia seran las variables, por eso cree este primer formulario con todas las caracteristicas necesarias
    'para asi despues solo tener que copiar y pegar en los forms 2, 3, 4 y 5
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Tema_2.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Puntaje.Show()
        Me.Hide()
    End Sub
End Class
