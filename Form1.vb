Public Class Form1
    Function Cod_Cezar(ByVal Text As String, ByVal N As Integer, ByVal Criptare As Boolean)
        Dim Rezultat As String = ""

        For Each caracter As Char In Text
            Dim x As Integer
            If Criptare Then
                x = Asc(caracter) + N
            Else
                x = Asc(caracter) + 26 - N
            End If
            If Char.IsLower(caracter) Then
                If x > Asc("z") Then
                    x -= 26
                End If
                Rezultat += Chr(x)

            ElseIf Char.IsUpper(caracter) Then
                If x > Asc("Z") Then
                    x -= 26
                End If
                Rezultat += Chr(x)
            Else
                Rezultat += caracter
            End If
        Next

        Return Rezultat
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = Cod_Cezar(TextBox2.Text, NumericUpDown1.Value, False)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = Cod_Cezar(TextBox1.Text, NumericUpDown1.Value, True)
    End Sub
End Class