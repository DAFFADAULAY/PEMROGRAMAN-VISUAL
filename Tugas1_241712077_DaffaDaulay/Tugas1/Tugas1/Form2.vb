Public Class Form2
    ' Validasi agar hanya bisa input angka
    Private Sub txtPendapatan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPendapatan.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Logika hitung pajak
    Private Sub btnHitung_Click(sender As Object, e As EventArgs) Handles btnHitung.Click
        If String.IsNullOrWhiteSpace(txtPendapatan.Text) Then
            MessageBox.Show("Pendapatan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtPendapatan.Focus()
            Return
        End If

        Dim pendapatan As Decimal = Convert.ToDecimal(txtPendapatan.Text)
        Dim persentase As Decimal = 0

        If pendapatan <= 5000000D Then
            persentase = 0D
        ElseIf pendapatan <= 30000000D Then
            persentase = 0.1D
        ElseIf pendapatan <= 100000000D Then
            persentase = 0.2D
        Else
            persentase = 0.3D
        End If

        Dim totalPajak As Decimal = pendapatan * persentase

        Dim hasilFormat As String = "Rp " & totalPajak.ToString("N0", New Globalization.CultureInfo("id-ID"))
        MessageBox.Show("Total Pajak yang harus dibayar: " & hasilFormat, "Hasil Perhitungan Pajak", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    ' Tombol keluar kembali ke Form1
    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
        Form1.Show()
    End Sub
End Class

