<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        lblLimaJuta = New Label()
        lblTigaPuluhJuta = New Label()
        lblSeratusJuta = New Label()
        lblPendpatan = New Label()
        lblRupiah = New Label()
        txtPendapatan = New TextBox()
        btnHitung = New Button()
        btnKeluar = New Button()
        SuspendLayout()
        ' 
        ' lblLimaJuta
        ' 
        lblLimaJuta.AutoSize = True
        lblLimaJuta.Location = New Point(337, 119)
        lblLimaJuta.Name = "lblLimaJuta"
        lblLimaJuta.Size = New Size(108, 15)
        lblLimaJuta.TabIndex = 0
        lblLimaJuta.Text = "> Rp 5.000.000 : 0%"
        ' 
        ' lblTigaPuluhJuta
        ' 
        lblTigaPuluhJuta.AutoSize = True
        lblTigaPuluhJuta.Location = New Point(293, 148)
        lblTigaPuluhJuta.Name = "lblTigaPuluhJuta"
        lblTigaPuluhJuta.Size = New Size(209, 15)
        lblTigaPuluhJuta.TabIndex = 1
        lblTigaPuluhJuta.Text = "> Rp 5.000.000 s.d. Rp 30.000.000 : 10%"
        ' 
        ' lblSeratusJuta
        ' 
        lblSeratusJuta.AutoSize = True
        lblSeratusJuta.Location = New Point(289, 179)
        lblSeratusJuta.Name = "lblSeratusJuta"
        lblSeratusJuta.Size = New Size(221, 15)
        lblSeratusJuta.TabIndex = 2
        lblSeratusJuta.Text = "> Rp 30.000.000 s.d. Rp 100.000.000 : 20%"
        ' 
        ' lblPendpatan
        ' 
        lblPendpatan.AutoSize = True
        lblPendpatan.Location = New Point(327, 226)
        lblPendpatan.Name = "lblPendpatan"
        lblPendpatan.Size = New Size(130, 15)
        lblPendpatan.TabIndex = 3
        lblPendpatan.Text = "Masukkan Pendapatan:"
        ' 
        ' lblRupiah
        ' 
        lblRupiah.AutoSize = True
        lblRupiah.Location = New Point(302, 243)
        lblRupiah.Name = "lblRupiah"
        lblRupiah.Size = New Size(24, 15)
        lblRupiah.TabIndex = 4
        lblRupiah.Text = "Rp."
        ' 
        ' txtPendapatan
        ' 
        txtPendapatan.Location = New Point(332, 244)
        txtPendapatan.Name = "txtPendapatan"
        txtPendapatan.Size = New Size(100, 23)
        txtPendapatan.TabIndex = 5
        ' 
        ' btnHitung
        ' 
        btnHitung.Location = New Point(332, 273)
        btnHitung.Name = "btnHitung"
        btnHitung.Size = New Size(75, 23)
        btnHitung.TabIndex = 6
        btnHitung.Text = "Hitung"
        btnHitung.UseVisualStyleBackColor = True
        ' 
        ' btnKeluar
        ' 
        btnKeluar.Location = New Point(332, 302)
        btnKeluar.Name = "btnKeluar"
        btnKeluar.Size = New Size(75, 23)
        btnKeluar.TabIndex = 7
        btnKeluar.Text = "Keluar"
        btnKeluar.UseVisualStyleBackColor = True
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnKeluar)
        Controls.Add(btnHitung)
        Controls.Add(txtPendapatan)
        Controls.Add(lblRupiah)
        Controls.Add(lblPendpatan)
        Controls.Add(lblSeratusJuta)
        Controls.Add(lblTigaPuluhJuta)
        Controls.Add(lblLimaJuta)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblLimaJuta As Label
    Friend WithEvents lblTigaPuluhJuta As Label
    Friend WithEvents lblSeratusJuta As Label
    Friend WithEvents lblPendpatan As Label
    Friend WithEvents lblRupiah As Label
    Friend WithEvents txtPendapatan As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnKeluar As Button
End Class
