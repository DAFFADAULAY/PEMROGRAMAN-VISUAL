Option Strict On
Option Explicit On

' Module berisi fungsi validasi yang bisa dipakai di mana saja pada proyek.
Public Module modValidasi

    ' Memeriksa apakah semua karakter pada teks adalah angka 0 sampai 9.
    ' Teks kosong dianggap tidak valid.
    Public Function SemuaDigit(teks As String) As Boolean
        If teks.Length = 0 Then
            Return False
        End If

        For Each huruf As Char In teks
            If huruf < "0"c OrElse huruf > "9"c Then
                Return False
            End If
        Next

        Return True
    End Function

    ' Memeriksa format kode buku: "BK" diikuti 4 digit (contoh BK0012).
    ' Huruf kecil (bk0012) tetap diterima karena diubah ke huruf besar dulu.
    Public Function KodeBukuValid(kode As String) As Boolean
        Dim k As String = kode.Trim().ToUpper()

        ' Periksa panjang dulu agar Substring di bawah aman dipakai.
        If k.Length <> 6 Then
            Return False
        End If

        If Not k.StartsWith("BK") Then
            Return False
        End If

        Return SemuaDigit(k.Substring(2))
    End Function

End Module
