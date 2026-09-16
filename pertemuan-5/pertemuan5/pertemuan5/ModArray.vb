Module ModArray
    Public Sub TampilkanPesan(nama As String)
        MessageBox.Show("Haloo " & nama)
    End Sub

    Function Hitung(panjang As Integer, lebar As Integer) As Integer
        If panjang <= 50 Then
            Return 2 * (panjang + lebar)
        Else
            Return panjang * lebar
        End If
    End Function

    Public nilai() As Integer = {50, 60, 70, 80, 90, 100}
End Module
