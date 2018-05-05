Public Class Form2

    Private Sub hasil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles hasil.Click
        Dim i, j As Integer
        Dim cetak As String
        cetak = ""
        For i = 0 To p.Text '- 1
            For j = 0 To l.Text '- 1
                cetak = cetak & "*"
            Next
            cetak = cetak & vbCrLf
        Next
        MsgBox(cetak)

    End Sub
End Class