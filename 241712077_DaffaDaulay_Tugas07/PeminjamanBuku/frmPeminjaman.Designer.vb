<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPeminjaman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblJudulForm = New System.Windows.Forms.Label()
        Me.lblKodeBuku = New System.Windows.Forms.Label()
        Me.txtKodeBuku = New System.Windows.Forms.TextBox()
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.txtJudul = New System.Windows.Forms.TextBox()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.cboKategori = New System.Windows.Forms.ComboBox()
        Me.lblNamaPeminjam = New System.Windows.Forms.Label()
        Me.txtNamaPeminjam = New System.Windows.Forms.TextBox()
        Me.lblLamaPinjam = New System.Windows.Forms.Label()
        Me.txtLamaPinjam = New System.Windows.Forms.TextBox()
        Me.btnPinjam = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.lstPeminjaman = New System.Windows.Forms.ListBox()
        Me.btnEkspor = New System.Windows.Forms.Button()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.errPinjam = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.errPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJudulForm
        '
        Me.lblJudulForm.AutoSize = True
        Me.lblJudulForm.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulForm.Location = New System.Drawing.Point(24, 16)
        Me.lblJudulForm.Name = "lblJudulForm"
        Me.lblJudulForm.Size = New System.Drawing.Size(158, 25)
        Me.lblJudulForm.TabIndex = 0
        Me.lblJudulForm.Text = "Peminjaman Buku"
        '
        'lblKodeBuku
        '
        Me.lblKodeBuku.AutoSize = True
        Me.lblKodeBuku.Location = New System.Drawing.Point(24, 64)
        Me.lblKodeBuku.Name = "lblKodeBuku"
        Me.lblKodeBuku.Size = New System.Drawing.Size(62, 15)
        Me.lblKodeBuku.TabIndex = 1
        Me.lblKodeBuku.Text = "Kode Buku"
        '
        'txtKodeBuku
        '
        Me.txtKodeBuku.Location = New System.Drawing.Point(24, 84)
        Me.txtKodeBuku.Name = "txtKodeBuku"
        Me.txtKodeBuku.Size = New System.Drawing.Size(260, 23)
        Me.txtKodeBuku.TabIndex = 2
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Location = New System.Drawing.Point(24, 116)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(61, 15)
        Me.lblJudul.TabIndex = 3
        Me.lblJudul.Text = "Judul Buku"
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(24, 136)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(260, 23)
        Me.txtJudul.TabIndex = 4
        '
        'lblKategori
        '
        Me.lblKategori.AutoSize = True
        Me.lblKategori.Location = New System.Drawing.Point(24, 168)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(54, 15)
        Me.lblKategori.TabIndex = 5
        Me.lblKategori.Text = "Kategori"
        '
        'cboKategori
        '
        Me.cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKategori.FormattingEnabled = True
        Me.cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        Me.cboKategori.Location = New System.Drawing.Point(24, 188)
        Me.cboKategori.Name = "cboKategori"
        Me.cboKategori.Size = New System.Drawing.Size(260, 23)
        Me.cboKategori.TabIndex = 6
        '
        'lblNamaPeminjam
        '
        Me.lblNamaPeminjam.AutoSize = True
        Me.lblNamaPeminjam.Location = New System.Drawing.Point(24, 220)
        Me.lblNamaPeminjam.Name = "lblNamaPeminjam"
        Me.lblNamaPeminjam.Size = New System.Drawing.Size(93, 15)
        Me.lblNamaPeminjam.TabIndex = 7
        Me.lblNamaPeminjam.Text = "Nama Peminjam"
        '
        'txtNamaPeminjam
        '
        Me.txtNamaPeminjam.Location = New System.Drawing.Point(24, 240)
        Me.txtNamaPeminjam.Name = "txtNamaPeminjam"
        Me.txtNamaPeminjam.Size = New System.Drawing.Size(260, 23)
        Me.txtNamaPeminjam.TabIndex = 8
        '
        'lblLamaPinjam
        '
        Me.lblLamaPinjam.AutoSize = True
        Me.lblLamaPinjam.Location = New System.Drawing.Point(24, 272)
        Me.lblLamaPinjam.Name = "lblLamaPinjam"
        Me.lblLamaPinjam.Size = New System.Drawing.Size(103, 15)
        Me.lblLamaPinjam.TabIndex = 9
        Me.lblLamaPinjam.Text = "Lama Pinjam (hari)"
        '
        'txtLamaPinjam
        '
        Me.txtLamaPinjam.Location = New System.Drawing.Point(24, 292)
        Me.txtLamaPinjam.Name = "txtLamaPinjam"
        Me.txtLamaPinjam.Size = New System.Drawing.Size(260, 23)
        Me.txtLamaPinjam.TabIndex = 10
        '
        'btnPinjam
        '
        Me.btnPinjam.Location = New System.Drawing.Point(24, 336)
        Me.btnPinjam.Name = "btnPinjam"
        Me.btnPinjam.Size = New System.Drawing.Size(125, 30)
        Me.btnPinjam.TabIndex = 11
        Me.btnPinjam.Text = "Pinjam"
        Me.btnPinjam.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.CausesValidation = False
        Me.btnBersihkan.Location = New System.Drawing.Point(159, 336)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(125, 30)
        Me.btnBersihkan.TabIndex = 12
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'lstPeminjaman
        '
        Me.lstPeminjaman.FormattingEnabled = True
        Me.lstPeminjaman.HorizontalScrollbar = True
        Me.lstPeminjaman.ItemHeight = 15
        Me.lstPeminjaman.Location = New System.Drawing.Point(320, 84)
        Me.lstPeminjaman.Name = "lstPeminjaman"
        Me.lstPeminjaman.Size = New System.Drawing.Size(456, 229)
        Me.lstPeminjaman.TabIndex = 13
        '
        'btnEkspor
        '
        Me.btnEkspor.Location = New System.Drawing.Point(320, 336)
        Me.btnEkspor.Name = "btnEkspor"
        Me.btnEkspor.Size = New System.Drawing.Size(125, 30)
        Me.btnEkspor.TabIndex = 14
        Me.btnEkspor.Text = "Ekspor CSV"
        Me.btnEkspor.UseVisualStyleBackColor = True
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(24, 384)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(135, 15)
        Me.lblStatus.TabIndex = 15
        Me.lblStatus.Text = "Jumlah peminjaman: 0"
        '
        'errPinjam
        '
        Me.errPinjam.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errPinjam.ContainerControl = Me
        '
        'frmPeminjaman
        '
        Me.AcceptButton = Me.btnPinjam
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 420)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.btnEkspor)
        Me.Controls.Add(Me.lstPeminjaman)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.btnPinjam)
        Me.Controls.Add(Me.txtLamaPinjam)
        Me.Controls.Add(Me.lblLamaPinjam)
        Me.Controls.Add(Me.txtNamaPeminjam)
        Me.Controls.Add(Me.lblNamaPeminjam)
        Me.Controls.Add(Me.cboKategori)
        Me.Controls.Add(Me.lblKategori)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.txtKodeBuku)
        Me.Controls.Add(Me.lblKodeBuku)
        Me.Controls.Add(Me.lblJudulForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmPeminjaman"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Peminjaman Buku"
        CType(Me.errPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudulForm As System.Windows.Forms.Label
    Friend WithEvents lblKodeBuku As System.Windows.Forms.Label
    Friend WithEvents txtKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents cboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lblNamaPeminjam As System.Windows.Forms.Label
    Friend WithEvents txtNamaPeminjam As System.Windows.Forms.TextBox
    Friend WithEvents lblLamaPinjam As System.Windows.Forms.Label
    Friend WithEvents txtLamaPinjam As System.Windows.Forms.TextBox
    Friend WithEvents btnPinjam As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents lstPeminjaman As System.Windows.Forms.ListBox
    Friend WithEvents btnEkspor As System.Windows.Forms.Button
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents errPinjam As System.Windows.Forms.ErrorProvider

End Class
