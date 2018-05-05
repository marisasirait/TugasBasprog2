Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Hasil.Click
        Dim a, b, c, i, d, j As Integer

        c = bil.Text * bil.Text
        txtkuadrat.Text = c


        '  For a = 1 To bil.Text
        a = 1
        For i = 1 To bil.Text
            a = a * i

        Next
        faktor.Text = a
        'Next()


        a = 0
        b = 1
        j = 1
        For i = 2 To bil.Text
            d = a + b

            If i > 3 Then
                d = b + j
                j = b
                b = d
            End If
        Next
        fibo.Text = d


    End Sub
End Class
