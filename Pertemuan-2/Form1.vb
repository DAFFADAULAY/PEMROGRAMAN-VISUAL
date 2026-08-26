Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()

        ' Mengembalikan kedipan kursor ke TextBox pertama (Nama)
        TextBox1.Focus()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pesan As String = "Nama : " & TextBox1.Text & vbCrLf &
                      "NIM : " & TextBox2.Text & vbCrLf &
                      "KOM : " & TextBox3.Text

        ' Menampilkan pesan dalam bentuk pop-up
        MessageBox.Show(pesan, "Data Mahasiswa", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class
