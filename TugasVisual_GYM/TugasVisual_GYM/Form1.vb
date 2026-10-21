Public Class Form1
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        ' 1. Deklarasi Variabel
        Dim bulan As Integer
        Dim hargaPerBulan As Double = 150000 ' Contoh tarif Gym Rp 150.000 per bulan
        Dim subTotal As Double
        Dim diskon As Double = 0
        Dim totalBayar As Double

        ' 2. Ambil Input (Pastikan input berupa angka)
        If Integer.TryParse(txtBulan.Text, bulan) = False Then
            MessageBox.Show("Masukkan durasi bulan berupa angka yang valid!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        subTotal = bulan * hargaPerBulan

        ' 3. Proses Percabangan (Aturan Diskon)
        ' Cek kondisi durasi >= 6 bulan untuk diskon dasar 10%
        If bulan >= 6 Then
            diskon = subTotal * 0.1 ' Diskon 10%
        End If

        ' Cek kondisi Mahasiswa untuk diskon tambahan 5%
        If chkMahasiswa.Checked Then
            diskon = diskon + (subTotal * 0.05) ' Tambahan diskon 5%
        End If

        ' 4. Hitung Output
        totalBayar = subTotal - diskon

        ' 5. Tampilkan Output
        lblHasil.Text = "Subtotal: Rp " & subTotal.ToString("N0") & vbCrLf &
                        "Total Diskon: Rp " & diskon.ToString("N0") & vbCrLf &
                        "Total Bayar: Rp " & totalBayar.ToString("N0")
    End Sub
End Class