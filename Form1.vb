Public Class Form1
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles C1.SelectedIndexChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim t1, t2, Result As Integer
        Dim op As String
        t1 = CInt(txt1.Text)
        t2 = CInt(txt2.Text)
        op = C1.Text
        If op = "Suma" Then
            Result = t1 + t2
        End If
        If op = "Resta" Then
            Result = t1 - t2
        End If
        If op = "Multiplicar" Then
            Result = t1 * t2
        End If
        If op = "Dividir" Then
            Result = t1 / t2
        End If
        MsgBox("Resultado es: " & Result)

    End Sub
End Class
