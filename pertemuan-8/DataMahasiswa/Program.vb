Option Strict On
Option Explicit On

Imports System.Windows.Forms

' Titik masuk aplikasi: membuka FrmUtama sebagai form awal.
Module Program

    ' Menyiapkan tampilan Windows Forms lalu menjalankan FrmUtama.
    <STAThread>
    Sub Main()
        Application.SetHighDpiMode(HighDpiMode.SystemAware)
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New FrmUtama())
    End Sub

End Module
