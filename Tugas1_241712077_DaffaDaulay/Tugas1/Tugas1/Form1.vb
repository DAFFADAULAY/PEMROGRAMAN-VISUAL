Imports System.Windows

Public Class Form1
    ' Menambahkan role saat form dimuat
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbRole.Items.Add("Staff")
        cmbRole.Items.Add("Manager")
    End Sub

    ' Mengganti gambar berdasarkan pilihan
    Private Sub cmbRole_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbRole.SelectedIndexChanged
        If cmbRole.SelectedItem IsNot Nothing Then
            If cmbRole.SelectedItem.ToString() = "Staff" Then
                picImage.Image = Image.FromFile("Image\form-login-staff.png")
            ElseIf cmbRole.SelectedItem.ToString() = "Manager" Then
                picImage.Image = Image.FromFile("Image\form-login-manager.png")
            End If
        End If
    End Sub

    ' Validasi input huruf dan angka
    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        If Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtNIM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNIM.KeyPress
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    ' Proses login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim role As String = cmbRole.Text
        Dim nama As String = txtNama.Text.Trim()
        Dim nim As String = txtNIM.Text.Trim()

        Dim isStaffValid As Boolean = (role = "Staff" AndAlso nama = "Nadya" AndAlso nim = "241712051")
        Dim isManagerValid As Boolean = (role = "Manager" AndAlso nama = "Shata Diyaul Haq" AndAlso nim = "241712061")

        If isStaffValid OrElse isManagerValid Then
            ' Buka Form2 dan sembunyikan Form1
            Form2.Show()
            Me.Hide()

            cmbRole.SelectedIndex = -1
            txtNama.Clear()
            txtNIM.Clear()
            picImage.Image = Nothing
        Else
            MessageBox.Show("Kombinasi Role, Nama, atau NIM tidak sesuai!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtNIM.Focus()
        End If
    End Sub
End Class
