Option Strict On
Option Explicit On

' Tugas Pertemuan 7 - Form Peminjaman Buku
' Mata kuliah : Pemrograman Visual (TIF 3 031)
' Nama        : (isi nama Anda)
' NIM         : (isi NIM Anda)

Imports System.IO
Imports System.Windows.Forms

' Form tunggal untuk mencatat peminjaman buku perpustakaan.
Public Class frmPeminjaman

    ' Kode buku yang sedang dipinjam, dipakai untuk mencegah peminjaman ganda.
    Private daftarKode As New List(Of String)

    ' Pesan kesalahan format kode buku (dipakai di ValidasiInput dan event Validating).
    Private Const PesanFormatKode As String = "Kode buku harus BK diikuti 4 digit, contoh BK0012."

    ' Menampilkan jumlah peminjaman yang sudah dicatat pada lblStatus.
    Private Sub TampilkanJumlah()
        lblStatus.Text = "Jumlah peminjaman: " & daftarKode.Count.ToString()
    End Sub

    ' Mengosongkan semua isian lalu menaruh kursor di kode buku.
    Private Sub KosongkanIsian()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        cboKategori.SelectedIndex = -1
        txtNamaPeminjam.Clear()
        txtLamaPinjam.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' Memeriksa semua isian sekaligus (tidak berhenti di kesalahan pertama).
    ' Kontrol yang salah ditandai dengan errPinjam. Mengembalikan True jika semua valid.
    Private Function ValidasiInput() As Boolean
        Dim semuaValid As Boolean = True
        Dim lama As Integer

        ' Hapus tanda kesalahan dari pemeriksaan sebelumnya.
        errPinjam.Clear()

        ' Kode buku: format BK + 4 digit, dan belum sedang dipinjam.
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        If Not KodeBukuValid(kode) Then
            errPinjam.SetError(txtKodeBuku, PesanFormatKode)
            semuaValid = False
        ElseIf daftarKode.Contains(kode) Then
            errPinjam.SetError(txtKodeBuku, "Buku ini sedang dipinjam.")
            semuaValid = False
        End If

        ' Judul buku: wajib diisi.
        If txtJudul.Text.Trim().Length = 0 Then
            errPinjam.SetError(txtJudul, "Judul buku wajib diisi.")
            semuaValid = False
        End If

        ' Kategori: wajib dipilih.
        If cboKategori.SelectedIndex = -1 Then
            errPinjam.SetError(cboKategori, "Kategori wajib dipilih.")
            semuaValid = False
        End If

        ' Nama peminjam: minimal 3 karakter (spasi di awal dan akhir tidak dihitung).
        If txtNamaPeminjam.Text.Trim().Length < 3 Then
            errPinjam.SetError(txtNamaPeminjam, "Nama peminjam minimal 3 karakter.")
            semuaValid = False
        End If

        ' Lama pinjam: bilangan bulat 1 sampai 14.
        If Not Integer.TryParse(txtLamaPinjam.Text.Trim(), lama) OrElse lama < 1 OrElse lama > 14 Then
            errPinjam.SetError(txtLamaPinjam, "Lama pinjam harus bilangan bulat 1 sampai 14 hari.")
            semuaValid = False
        End If

        Return semuaValid
    End Function

    ' Saat fokus meninggalkan txtKodeBuku, format kode langsung diperiksa.
    ' Tidak memakai e.Cancel, jadi fokus tetap bebas berpindah.
    Private Sub txtKodeBuku_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles txtKodeBuku.Validating
        Dim teks As String = txtKodeBuku.Text.Trim()

        ' Isian kosong diperiksa oleh ValidasiInput saat tombol Pinjam diklik.
        If teks.Length = 0 Then
            Return
        End If

        If KodeBukuValid(teks) Then
            ' Hapus hanya pesan format; pesan "sedang dipinjam" dibiarkan.
            If errPinjam.GetError(txtKodeBuku) = PesanFormatKode Then
                errPinjam.SetError(txtKodeBuku, "")
            End If
        Else
            errPinjam.SetError(txtKodeBuku, PesanFormatKode)
        End If
    End Sub

    ' Mencatat peminjaman jika semua isian valid.
    Private Sub btnPinjam_Click(sender As Object, e As EventArgs) Handles btnPinjam.Click
        If Not ValidasiInput() Then
            lblStatus.Text = "Periksa isian yang bertanda merah."
            Return
        End If

        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        Dim judul As String = txtJudul.Text.Trim()
        Dim kategori As String = cboKategori.Text
        Dim nama As String = txtNamaPeminjam.Text.Trim()
        Dim lama As Integer
        Integer.TryParse(txtLamaPinjam.Text.Trim(), lama)

        ' Tanggal kembali = hari ini + lama pinjam.
        Dim tglKembali As String = Date.Today.AddDays(lama).ToString("dd/MM/yyyy")

        Dim baris As String = kode & " | " & judul & " | " & kategori & " | " & nama &
                              " | " & lama.ToString() & " hari | kembali " & tglKembali

        lstPeminjaman.Items.Add(baris)
        daftarKode.Add(kode)

        TampilkanJumlah()
        KosongkanIsian()
    End Sub

    ' Mengosongkan form dan menghapus semua ikon ErrorProvider.
    ' Daftar peminjaman yang sudah tercatat tidak ikut dihapus.
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        KosongkanIsian()
        errPinjam.Clear()
        TampilkanJumlah()
    End Sub

    ' Menyimpan isi lstPeminjaman ke peminjaman.csv (folder Documents), pemisah titik koma.
    Private Sub btnEkspor_Click(sender As Object, e As EventArgs) Handles btnEkspor.Click
        ' Daftar kosong: tampilkan pesan dan jangan buat file.
        If lstPeminjaman.Items.Count = 0 Then
            MessageBox.Show("Daftar peminjaman masih kosong. Catat minimal satu peminjaman sebelum mengekspor.",
                            "Ekspor CSV", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        Dim jalurFile As String = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "peminjaman.csv")
        Dim penulis As StreamWriter = Nothing

        Try
            penulis = New StreamWriter(jalurFile)

            ' Baris pertama: judul kolom.
            penulis.WriteLine("Kode Buku;Judul;Kategori;Nama Peminjam;Lama Pinjam;Tanggal Kembali")

            ' Setiap item ListBox menjadi satu baris; pemisah " | " diganti titik koma.
            For Each item As Object In lstPeminjaman.Items
                penulis.WriteLine(item.ToString().Replace(" | ", ";"))
            Next

            lblStatus.Text = "Ekspor berhasil: peminjaman.csv di folder Documents."
        Catch ex As IOException
            MessageBox.Show("File peminjaman.csv tidak bisa ditulis karena sedang dibuka di program lain (misalnya Excel)." &
                            vbCrLf & "Tutup file tersebut, lalu klik Ekspor CSV lagi." &
                            vbCrLf & vbCrLf & "Detail: " & ex.Message,
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblStatus.Text = "Ekspor gagal: file sedang dipakai program lain."
        Catch ex As UnauthorizedAccessException
            MessageBox.Show("Program tidak punya izin menulis peminjaman.csv di folder Documents (file mungkin read-only)." &
                            vbCrLf & "Hapus atribut read-only pada file tersebut atau pindahkan file ke lokasi lain, lalu coba lagi." &
                            vbCrLf & vbCrLf & "Detail: " & ex.Message,
                            "Ekspor Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            lblStatus.Text = "Ekspor gagal: tidak ada izin menulis file."
        Finally
            ' StreamWriter selalu ditutup, baik berhasil maupun gagal.
            If penulis IsNot Nothing Then
                penulis.Close()
            End If
        End Try
    End Sub

End Class
