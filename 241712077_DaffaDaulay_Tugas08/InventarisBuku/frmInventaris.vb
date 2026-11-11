Option Strict On
Option Explicit On

' Tugas Pertemuan 8 - Inventaris Buku Perpustakaan
' Mata kuliah : Pemrograman Visual (TIF 3 031)
' Nama        : Daffa Daulay
' NIM         : 241712077

Imports System.Data
Imports System.Windows.Forms

' Form tunggal untuk melihat, menambah, dan mencari buku di inventaris.
Public Class frmInventaris

    ' Data inventaris disimpan di DataTable (di memori, tanpa database).
    Private tabelBuku As New DataTable("Buku")

    ' Membuat struktur kolom tabelBuku.
    Private Sub BuatTabel()
        tabelBuku.Columns.Add("KodeBuku", GetType(String))
        tabelBuku.Columns.Add("Judul", GetType(String))
        tabelBuku.Columns.Add("Penulis", GetType(String))
        tabelBuku.Columns.Add("Kategori", GetType(String))
        tabelBuku.Columns.Add("Tahun", GetType(Integer))
        tabelBuku.Columns.Add("Stok", GetType(Integer))
    End Sub

    ' Menambahkan satu baris buku ke tabelBuku.
    Private Sub TambahBuku(kode As String, judul As String, penulis As String,
                           kategori As String, tahun As Integer, stok As Integer)
        tabelBuku.Rows.Add(kode, judul, penulis, kategori, tahun, stok)
    End Sub

    ' Mengisi data awal (10 buku, semua kategori terwakili, 2 buku stok 0).
    Private Sub IsiDataAwal()
        TambahBuku("BK0001", "Laskar Pelangi", "Andrea Hirata", "Fiksi", 2005, 8)
        TambahBuku("BK0002", "Bumi Manusia", "Pramoedya Ananta Toer", "Fiksi", 1980, 0)
        TambahBuku("BK0003", "Filosofi Teras", "Henry Manampiring", "Nonfiksi", 2018, 5)
        TambahBuku("BK0004", "Kamus Besar Bahasa Indonesia", "Tim Pusat Bahasa", "Referensi", 2016, 3)
        TambahBuku("BK0005", "Majalah Sains Nusantara", "Redaksi Sains", "Majalah", 2024, 0)
        TambahBuku("BK0006", "Man's Search for Meaning", "Viktor E. Frankl", "Nonfiksi", 1946, 4)
        TambahBuku("BK0007", "Negeri 5 Menara", "Ahmad Fuadi", "Fiksi", 2009, 6)
        TambahBuku("BK0008", "Atlas Indonesia", "Tim Kartografi", "Referensi", 2022, 2)
        TambahBuku("BK0009", "Majalah Taman Kita", "Redaksi Taman", "Majalah", 2023, 7)
        TambahBuku("BK0010", "Sapiens", "Yuval Noah Harari", "Nonfiksi", 2017, 3)
    End Sub

    ' Merapikan tampilan kolom dgvBuku setelah DataSource terisi.
    Private Sub SiapkanKolom()
        dgvBuku.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill

        dgvBuku.Columns("KodeBuku").HeaderText = "Kode Buku"

        ' FillWeight mengatur lebar relatif kolom; Judul dibuat paling lebar.
        dgvBuku.Columns("KodeBuku").FillWeight = 80
        dgvBuku.Columns("Judul").FillWeight = 250
        dgvBuku.Columns("Penulis").FillWeight = 150
        dgvBuku.Columns("Kategori").FillWeight = 90
        dgvBuku.Columns("Tahun").FillWeight = 60
        dgvBuku.Columns("Stok").FillWeight = 50

        ' Kolom angka diratakan ke tengah (judul kolom dan isinya).
        dgvBuku.Columns("Tahun").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.Columns("Tahun").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.Columns("Stok").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
        dgvBuku.Columns("Stok").HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    ' Mengisi data awal, menghubungkan tabel ke grid lewat BindingSource, lalu menyiapkan tampilan.
    Private Sub frmInventaris_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BuatTabel()
        IsiDataAwal()

        bsBuku.DataSource = tabelBuku
        dgvBuku.DataSource = bsBuku
        SiapkanKolom()

        cboFilterKategori.SelectedIndex = 0
        cboUrut.SelectedIndex = 0
        PerbaruiRingkasan()
    End Sub

    ' Memeriksa apakah kode buku sudah ada, dengan perulangan pada tabelBuku.Rows.
    Private Function KodeSudahAda(kode As String) As Boolean
        For Each baris As DataRow In tabelBuku.Rows
            If baris("KodeBuku").ToString() = kode Then
                Return True
            End If
        Next

        Return False
    End Function

    ' Memeriksa semua isian sekaligus (tidak berhenti di kesalahan pertama).
    ' Kontrol yang salah ditandai dengan errBuku. Mengembalikan True jika semua valid.
    Private Function ValidasiInput() As Boolean
        Dim semuaValid As Boolean = True
        Dim tahun As Integer
        Dim stok As Integer
        Dim tahunIni As Integer = Date.Today.Year

        ' Hapus tanda kesalahan dari pemeriksaan sebelumnya.
        errBuku.Clear()

        ' Kode buku: format BK + 4 digit, dan belum ada di tabelBuku.
        Dim kode As String = txtKodeBuku.Text.Trim().ToUpper()
        If Not KodeBukuValid(kode) Then
            errBuku.SetError(txtKodeBuku, "Kode buku harus BK diikuti 4 digit, contoh BK0012.")
            semuaValid = False
        ElseIf KodeSudahAda(kode) Then
            errBuku.SetError(txtKodeBuku, "Kode buku sudah ada di inventaris.")
            semuaValid = False
        End If

        ' Judul dan penulis: wajib diisi.
        If txtJudul.Text.Trim().Length = 0 Then
            errBuku.SetError(txtJudul, "Judul buku wajib diisi.")
            semuaValid = False
        End If

        If txtPenulis.Text.Trim().Length = 0 Then
            errBuku.SetError(txtPenulis, "Penulis wajib diisi.")
            semuaValid = False
        End If

        ' Kategori: wajib dipilih.
        If cboKategori.SelectedIndex = -1 Then
            errBuku.SetError(cboKategori, "Kategori wajib dipilih.")
            semuaValid = False
        End If

        ' Tahun: bilangan bulat dari 1900 sampai tahun ini.
        If Not Integer.TryParse(txtTahun.Text.Trim(), tahun) OrElse tahun < 1900 OrElse tahun > tahunIni Then
            errBuku.SetError(txtTahun, "Tahun harus bilangan bulat 1900 sampai " & tahunIni.ToString() & ".")
            semuaValid = False
        End If

        ' Stok: bilangan bulat 0 atau lebih.
        If Not Integer.TryParse(txtStok.Text.Trim(), stok) OrElse stok < 0 Then
            errBuku.SetError(txtStok, "Stok harus bilangan bulat 0 atau lebih.")
            semuaValid = False
        End If

        Return semuaValid
    End Function

    ' Mengosongkan semua isian input lalu menaruh kursor di kode buku.
    Private Sub KosongkanIsian()
        txtKodeBuku.Clear()
        txtJudul.Clear()
        txtPenulis.Clear()
        cboKategori.SelectedIndex = -1
        txtTahun.Clear()
        txtStok.Clear()
        txtKodeBuku.Focus()
    End Sub

    ' Menambah buku baru jika semua isian valid. Grid langsung ikut berubah karena
    ' terikat ke tabelBuku lewat bsBuku.
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        If Not ValidasiInput() Then
            Return
        End If

        Dim tahun As Integer
        Dim stok As Integer
        Integer.TryParse(txtTahun.Text.Trim(), tahun)
        Integer.TryParse(txtStok.Text.Trim(), stok)

        TambahBuku(txtKodeBuku.Text.Trim().ToUpper(), txtJudul.Text.Trim(), txtPenulis.Text.Trim(),
                   cboKategori.Text, tahun, stok)

        PerbaruiRingkasan()
        KosongkanIsian()
    End Sub

    ' Mengosongkan isian dan menghapus semua ikon ErrorProvider.
    Private Sub btnBersihkan_Click(sender As Object, e As EventArgs) Handles btnBersihkan.Click
        KosongkanIsian()
        errBuku.Clear()
    End Sub

    ' Menerapkan pencarian gabungan (teks + kategori + stok habis) ke bsBuku.Filter.
    ' Jika ekspresi gagal diproses, filter dihapus agar program tetap berjalan.
    Private Sub TerapkanFilter()
        Try
            bsBuku.Filter = BuatFilter(txtCari.Text, cboFilterKategori.Text, chkStokHabis.Checked)
            errBuku.SetError(txtCari, "")
        Catch ex As DataException
            bsBuku.RemoveFilter()
            errBuku.SetError(txtCari, "Kata pencarian tidak dapat diproses.")
        End Try

        PerbaruiRingkasan()
    End Sub

    ' Dipanggil setiap kali kata pencarian, filter kategori, atau pilihan stok habis berubah.
    Private Sub PencarianBerubah(sender As Object, e As EventArgs) _
        Handles txtCari.TextChanged, cboFilterKategori.SelectedIndexChanged, chkStokHabis.CheckedChanged
        TerapkanFilter()
    End Sub

    ' Mengatur urutan tampilan buku di grid sesuai pilihan cboUrut.
    Private Sub cboUrut_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboUrut.SelectedIndexChanged
        Select Case cboUrut.Text
            Case "Judul A-Z"
                bsBuku.Sort = "Judul ASC"
            Case "Tahun terbaru"
                bsBuku.Sort = "Tahun DESC"
            Case "Stok terbanyak"
                bsBuku.Sort = "Stok DESC"
            Case Else
                bsBuku.RemoveSort()
        End Select
    End Sub

    ' Memperbarui lblJumlah dan lblTotalStok berdasarkan baris yang sedang tampil di grid.
    Private Sub PerbaruiRingkasan()
        Dim total As Long = 0

        For Each baris As DataGridViewRow In dgvBuku.Rows
            total += CInt(baris.Cells("Stok").Value)
        Next

        lblJumlah.Text = "Menampilkan " & dgvBuku.Rows.Count.ToString() &
                         " dari " & tabelBuku.Rows.Count.ToString() & " buku"
        lblTotalStok.Text = "Total stok yang tampil: " & total.ToString()
    End Sub

End Class
