Public Class Tema_3
    Dim Correctas


    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If R1C.Checked Then
            Correctas = Correctas + 1
            Label3.Text = Correctas

        End If
        GroupBox1.Enabled = False
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If RadioButton4.Checked Then
            Correctas = Correctas + 1
            Label3.Text = Correctas

        End If
        GroupBox2.Enabled = False
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If RadioButton5.Checked Then
            Correctas = Correctas + 1
            Label3.Text = Correctas

        End If
        GroupBox3.Enabled = False
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If RadioButton12.Checked Then
            Correctas = Correctas + 1
            Label3.Text = Correctas

        End If
        GroupBox4.Enabled = False
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If RadioButton9.Checked Then
            Correctas = Correctas + 1
            Label3.Text = Correctas

        End If
        GroupBox5.Enabled = False
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Tema_4.Show()
        Me.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Puntaje.Show()
        Me.Hide()
    End Sub
End Class