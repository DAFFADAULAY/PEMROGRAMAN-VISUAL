Option Strict On
Option Explicit On

' Module berisi fungsi untuk menyusun ekspresi BindingSource.Filter dengan aman.
Public Module modFilter

    ' Mengamankan teks dari pengguna sebelum dimasukkan ke dalam ekspresi Filter LIKE.
    ' Tanda kutip tunggal digandakan, sedangkan karakter khusus LIKE ([ ] % *)
    ' dibungkus kurung siku agar dibaca sebagai teks biasa.
    Public Function AmankanFilter(teks As String) As String
        Dim hasil As String = ""

        For Each huruf As Char In teks
            Select Case huruf
                Case "'"c
                    hasil &= "''"
                Case "["c, "]"c, "%"c, "*"c
                    hasil &= "[" & huruf & "]"
                Case Else
                    hasil &= huruf
            End Select
        Next

        Return hasil
    End Function

    ' Menyusun ekspresi Filter dari kata pencarian, kategori, dan pilihan stok habis.
    ' Syarat yang aktif digabung dengan AND; hasil kosong berarti semua buku tampil.
    Public Function BuatFilter(kata As String, kategori As String, hanyaStokHabis As Boolean) As String
        Dim ekspresi As String = ""
        Dim kataBersih As String = kata.Trim()

        ' Syarat 1: kata ada di judul atau penulis.
        If kataBersih.Length > 0 Then
            Dim aman As String = AmankanFilter(kataBersih)
            ekspresi = "(Judul LIKE '%" & aman & "%' OR Penulis LIKE '%" & aman & "%')"
        End If

        ' Syarat 2: kategori tertentu (selain "Semua").
        If kategori.Length > 0 AndAlso kategori <> "Semua" Then
            If ekspresi.Length > 0 Then
                ekspresi &= " AND "
            End If
            ekspresi &= "Kategori = '" & kategori.Replace("'", "''") & "'"
        End If

        ' Syarat 3 (tantangan): hanya buku yang stoknya habis.
        If hanyaStokHabis Then
            If ekspresi.Length > 0 Then
                ekspresi &= " AND "
            End If
            ekspresi &= "Stok = 0"
        End If

        Return ekspresi
    End Function

End Module
