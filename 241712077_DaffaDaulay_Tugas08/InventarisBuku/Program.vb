Option Strict On
Option Explicit On

Imports System.Windows.Forms

' Titik masuk aplikasi: menjalankan form inventaris buku.
Module Program

    ' Menyiapkan tampilan Windows Forms lalu membuka frmInventaris.
    <STAThread>
    Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New frmInventaris())
    End Sub

End Module
