Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim biaya As Integer
        Dim kode As Char
        Dim buku As String
        Dim disc As Single
        kode = TextBox1.Text

        buku = TextBox3.Text
        Select Case kode
            Case "A"
                buku = "Alunan Musik"
                biaya = 35000
                TextBox2.Text = TextBox5.Text * biaya
            Case "B"
                buku = "Buah-Buahan"
                biaya = 26000
                TextBox2.Text = TextBox5.Text * biaya
            Case "C"
                buku = "Cake"
                biaya = 43000
                TextBox2.Text = TextBox5.Text * biaya
            Case "D"
                buku = "Dunia Anak"
                biaya = 37500
                TextBox2.Text = TextBox5.Text * biaya
            Case "E"
                buku = "Elok Rupawan"
                biaya = 40000
                TextBox2.Text = TextBox5.Text * biaya
            Case "F"
                buku = "Funny Game"
                biaya = 27600
                TextBox2.Text = TextBox5.Text * biaya
            Case Else
                MsgBox("Saat Ini Buku Belum Tersedia")
        End Select
        TextBox4.Text = biaya
        TextBox3.Text = buku

        If TextBox5.Text < 3 Then
            disc = 0.1 * TextBox2.Text
        ElseIf TextBox5.Text >= 3 Then
            disc = 0.2 * TextBox2.Text
        End If
        TextBox6.Text = disc

        TextBox7.Text = TextBox2.Text - TextBox6.Text

    End Sub


    
End Class