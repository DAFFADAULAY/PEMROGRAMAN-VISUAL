<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmInventaris
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
        Me.lblPenulis = New System.Windows.Forms.Label()
        Me.txtPenulis = New System.Windows.Forms.TextBox()
        Me.lblKategori = New System.Windows.Forms.Label()
        Me.cboKategori = New System.Windows.Forms.ComboBox()
        Me.lblTahun = New System.Windows.Forms.Label()
        Me.txtTahun = New System.Windows.Forms.TextBox()
        Me.lblStok = New System.Windows.Forms.Label()
        Me.txtStok = New System.Windows.Forms.TextBox()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnBersihkan = New System.Windows.Forms.Button()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.lblFilterKategori = New System.Windows.Forms.Label()
        Me.cboFilterKategori = New System.Windows.Forms.ComboBox()
        Me.chkStokHabis = New System.Windows.Forms.CheckBox()
        Me.lblUrut = New System.Windows.Forms.Label()
        Me.cboUrut = New System.Windows.Forms.ComboBox()
        Me.dgvBuku = New System.Windows.Forms.DataGridView()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.lblTotalStok = New System.Windows.Forms.Label()
        Me.bsBuku = New System.Windows.Forms.BindingSource(Me.components)
        Me.errBuku = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgvBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errBuku, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJudulForm
        '
        Me.lblJudulForm.AutoSize = True
        Me.lblJudulForm.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudulForm.Location = New System.Drawing.Point(24, 16)
        Me.lblJudulForm.Name = "lblJudulForm"
        Me.lblJudulForm.Size = New System.Drawing.Size(285, 25)
        Me.lblJudulForm.TabIndex = 0
        Me.lblJudulForm.Text = "Inventaris Buku Perpustakaan"
        '
        'lblKodeBuku
        '
        Me.lblKodeBuku.AutoSize = True
        Me.lblKodeBuku.Location = New System.Drawing.Point(24, 64)
        Me.lblKodeBuku.Name = "lblKodeBuku"
        Me.lblKodeBuku.Size = New System.Drawing.Size(62, 15)
        Me.lblKodeBuku.TabIndex = 1
        Me.lblKodeBuku.Text = "Kode buku"
        '
        'txtKodeBuku
        '
        Me.txtKodeBuku.Location = New System.Drawing.Point(24, 84)
        Me.txtKodeBuku.Name = "txtKodeBuku"
        Me.txtKodeBuku.Size = New System.Drawing.Size(250, 23)
        Me.txtKodeBuku.TabIndex = 2
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Location = New System.Drawing.Point(24, 114)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(61, 15)
        Me.lblJudul.TabIndex = 3
        Me.lblJudul.Text = "Judul buku"
        '
        'txtJudul
        '
        Me.txtJudul.Location = New System.Drawing.Point(24, 134)
        Me.txtJudul.Name = "txtJudul"
        Me.txtJudul.Size = New System.Drawing.Size(250, 23)
        Me.txtJudul.TabIndex = 4
        '
        'lblPenulis
        '
        Me.lblPenulis.AutoSize = True
        Me.lblPenulis.Location = New System.Drawing.Point(24, 164)
        Me.lblPenulis.Name = "lblPenulis"
        Me.lblPenulis.Size = New System.Drawing.Size(45, 15)
        Me.lblPenulis.TabIndex = 5
        Me.lblPenulis.Text = "Penulis"
        '
        'txtPenulis
        '
        Me.txtPenulis.Location = New System.Drawing.Point(24, 184)
        Me.txtPenulis.Name = "txtPenulis"
        Me.txtPenulis.Size = New System.Drawing.Size(250, 23)
        Me.txtPenulis.TabIndex = 6
        '
        'lblKategori
        '
        Me.lblKategori.AutoSize = True
        Me.lblKategori.Location = New System.Drawing.Point(24, 214)
        Me.lblKategori.Name = "lblKategori"
        Me.lblKategori.Size = New System.Drawing.Size(54, 15)
        Me.lblKategori.TabIndex = 7
        Me.lblKategori.Text = "Kategori"
        '
        'cboKategori
        '
        Me.cboKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboKategori.FormattingEnabled = True
        Me.cboKategori.Items.AddRange(New Object() {"Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        Me.cboKategori.Location = New System.Drawing.Point(24, 234)
        Me.cboKategori.Name = "cboKategori"
        Me.cboKategori.Size = New System.Drawing.Size(250, 23)
        Me.cboKategori.TabIndex = 8
        '
        'lblTahun
        '
        Me.lblTahun.AutoSize = True
        Me.lblTahun.Location = New System.Drawing.Point(24, 264)
        Me.lblTahun.Name = "lblTahun"
        Me.lblTahun.Size = New System.Drawing.Size(71, 15)
        Me.lblTahun.TabIndex = 9
        Me.lblTahun.Text = "Tahun terbit"
        '
        'txtTahun
        '
        Me.txtTahun.Location = New System.Drawing.Point(24, 284)
        Me.txtTahun.Name = "txtTahun"
        Me.txtTahun.Size = New System.Drawing.Size(250, 23)
        Me.txtTahun.TabIndex = 10
        '
        'lblStok
        '
        Me.lblStok.AutoSize = True
        Me.lblStok.Location = New System.Drawing.Point(24, 314)
        Me.lblStok.Name = "lblStok"
        Me.lblStok.Size = New System.Drawing.Size(30, 15)
        Me.lblStok.TabIndex = 11
        Me.lblStok.Text = "Stok"
        '
        'txtStok
        '
        Me.txtStok.Location = New System.Drawing.Point(24, 334)
        Me.txtStok.Name = "txtStok"
        Me.txtStok.Size = New System.Drawing.Size(250, 23)
        Me.txtStok.TabIndex = 12
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(24, 382)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(120, 30)
        Me.btnTambah.TabIndex = 13
        Me.btnTambah.Text = "Tambah Buku"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnBersihkan
        '
        Me.btnBersihkan.CausesValidation = False
        Me.btnBersihkan.Location = New System.Drawing.Point(154, 382)
        Me.btnBersihkan.Name = "btnBersihkan"
        Me.btnBersihkan.Size = New System.Drawing.Size(120, 30)
        Me.btnBersihkan.TabIndex = 14
        Me.btnBersihkan.Text = "Bersihkan"
        Me.btnBersihkan.UseVisualStyleBackColor = True
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.Location = New System.Drawing.Point(310, 64)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(99, 15)
        Me.lblCari.TabIndex = 15
        Me.lblCari.Text = "Cari judul/penulis"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(310, 84)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(646, 23)
        Me.txtCari.TabIndex = 16
        '
        'lblFilterKategori
        '
        Me.lblFilterKategori.AutoSize = True
        Me.lblFilterKategori.Location = New System.Drawing.Point(310, 114)
        Me.lblFilterKategori.Name = "lblFilterKategori"
        Me.lblFilterKategori.Size = New System.Drawing.Size(80, 15)
        Me.lblFilterKategori.TabIndex = 17
        Me.lblFilterKategori.Text = "Filter kategori"
        '
        'cboFilterKategori
        '
        Me.cboFilterKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterKategori.FormattingEnabled = True
        Me.cboFilterKategori.Items.AddRange(New Object() {"Semua", "Fiksi", "Nonfiksi", "Referensi", "Majalah"})
        Me.cboFilterKategori.Location = New System.Drawing.Point(310, 134)
        Me.cboFilterKategori.Name = "cboFilterKategori"
        Me.cboFilterKategori.Size = New System.Drawing.Size(180, 23)
        Me.cboFilterKategori.TabIndex = 18
        '
        'chkStokHabis
        '
        Me.chkStokHabis.AutoSize = True
        Me.chkStokHabis.Location = New System.Drawing.Point(510, 136)
        Me.chkStokHabis.Name = "chkStokHabis"
        Me.chkStokHabis.Size = New System.Drawing.Size(114, 19)
        Me.chkStokHabis.TabIndex = 19
        Me.chkStokHabis.Text = "Hanya stok habis"
        Me.chkStokHabis.UseVisualStyleBackColor = True
        '
        'lblUrut
        '
        Me.lblUrut.AutoSize = True
        Me.lblUrut.Location = New System.Drawing.Point(740, 114)
        Me.lblUrut.Name = "lblUrut"
        Me.lblUrut.Size = New System.Drawing.Size(70, 15)
        Me.lblUrut.TabIndex = 20
        Me.lblUrut.Text = "Urutkan buku"
        '
        'cboUrut
        '
        Me.cboUrut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUrut.FormattingEnabled = True
        Me.cboUrut.Items.AddRange(New Object() {"Urutan awal", "Judul A-Z", "Tahun terbaru", "Stok terbanyak"})
        Me.cboUrut.Location = New System.Drawing.Point(740, 134)
        Me.cboUrut.Name = "cboUrut"
        Me.cboUrut.Size = New System.Drawing.Size(216, 23)
        Me.cboUrut.TabIndex = 21
        '
        'dgvBuku
        '
        Me.dgvBuku.AllowUserToAddRows = False
        Me.dgvBuku.AllowUserToDeleteRows = False
        Me.dgvBuku.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBuku.Location = New System.Drawing.Point(310, 176)
        Me.dgvBuku.MultiSelect = False
        Me.dgvBuku.Name = "dgvBuku"
        Me.dgvBuku.ReadOnly = True
        Me.dgvBuku.RowHeadersVisible = False
        Me.dgvBuku.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBuku.Size = New System.Drawing.Size(646, 330)
        Me.dgvBuku.TabIndex = 22
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(310, 522)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(150, 15)
        Me.lblJumlah.TabIndex = 23
        Me.lblJumlah.Text = "Menampilkan 0 dari 0 buku"
        '
        'lblTotalStok
        '
        Me.lblTotalStok.AutoSize = True
        Me.lblTotalStok.Location = New System.Drawing.Point(310, 546)
        Me.lblTotalStok.Name = "lblTotalStok"
        Me.lblTotalStok.Size = New System.Drawing.Size(138, 15)
        Me.lblTotalStok.TabIndex = 24
        Me.lblTotalStok.Text = "Total stok yang tampil: 0"
        '
        'errBuku
        '
        Me.errBuku.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errBuku.ContainerControl = Me
        '
        'frmInventaris
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(980, 590)
        Me.Controls.Add(Me.lblTotalStok)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.dgvBuku)
        Me.Controls.Add(Me.cboUrut)
        Me.Controls.Add(Me.lblUrut)
        Me.Controls.Add(Me.chkStokHabis)
        Me.Controls.Add(Me.cboFilterKategori)
        Me.Controls.Add(Me.lblFilterKategori)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.lblCari)
        Me.Controls.Add(Me.btnBersihkan)
        Me.Controls.Add(Me.btnTambah)
        Me.Controls.Add(Me.txtStok)
        Me.Controls.Add(Me.lblStok)
        Me.Controls.Add(Me.txtTahun)
        Me.Controls.Add(Me.lblTahun)
        Me.Controls.Add(Me.cboKategori)
        Me.Controls.Add(Me.lblKategori)
        Me.Controls.Add(Me.txtPenulis)
        Me.Controls.Add(Me.lblPenulis)
        Me.Controls.Add(Me.txtJudul)
        Me.Controls.Add(Me.lblJudul)
        Me.Controls.Add(Me.txtKodeBuku)
        Me.Controls.Add(Me.lblKodeBuku)
        Me.Controls.Add(Me.lblJudulForm)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInventaris"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventaris Buku Perpustakaan"
        CType(Me.dgvBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsBuku, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errBuku, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudulForm As System.Windows.Forms.Label
    Friend WithEvents lblKodeBuku As System.Windows.Forms.Label
    Friend WithEvents txtKodeBuku As System.Windows.Forms.TextBox
    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents txtJudul As System.Windows.Forms.TextBox
    Friend WithEvents lblPenulis As System.Windows.Forms.Label
    Friend WithEvents txtPenulis As System.Windows.Forms.TextBox
    Friend WithEvents lblKategori As System.Windows.Forms.Label
    Friend WithEvents cboKategori As System.Windows.Forms.ComboBox
    Friend WithEvents lblTahun As System.Windows.Forms.Label
    Friend WithEvents txtTahun As System.Windows.Forms.TextBox
    Friend WithEvents lblStok As System.Windows.Forms.Label
    Friend WithEvents txtStok As System.Windows.Forms.TextBox
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnBersihkan As System.Windows.Forms.Button
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents lblFilterKategori As System.Windows.Forms.Label
    Friend WithEvents cboFilterKategori As System.Windows.Forms.ComboBox
    Friend WithEvents chkStokHabis As System.Windows.Forms.CheckBox
    Friend WithEvents lblUrut As System.Windows.Forms.Label
    Friend WithEvents cboUrut As System.Windows.Forms.ComboBox
    Friend WithEvents dgvBuku As System.Windows.Forms.DataGridView
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents lblTotalStok As System.Windows.Forms.Label
    Friend WithEvents bsBuku As System.Windows.Forms.BindingSource
    Friend WithEvents errBuku As System.Windows.Forms.ErrorProvider

End Class
