Option Strict On
Option Explicit On

Imports System.Windows.Forms

' Titik masuk aplikasi: menjalankan form peminjaman buku.
Module Program

    ' Menyiapkan tampilan Windows Forms lalu membuka frmPeminjaman.
    <STAThread>
    Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New frmPeminjaman())
    End Sub

End Module
