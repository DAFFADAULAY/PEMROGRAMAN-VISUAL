<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtama
    Inherits System.Windows.Forms.Form
    Private components As System.ComponentModel.IContainer

    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then components.Dispose()
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        mnsUtama = New MenuStrip()
        mnuBerkas = New ToolStripMenuItem()
        mnuKeluar = New ToolStripMenuItem()
        mnuData = New ToolStripMenuItem()
        mnuDataMahasiswa = New ToolStripMenuItem()
        mnuDataJurusan = New ToolStripMenuItem()
        mnuJendela = New ToolStripMenuItem()
        mnuBertumpuk = New ToolStripMenuItem()
        mnuHorizontal = New ToolStripMenuItem()
        mnuVertikal = New ToolStripMenuItem()
        sepPenutupan = New ToolStripSeparator()
        mnuTutupAktif = New ToolStripMenuItem()
        mnuTutupSemua = New ToolStripMenuItem()
        sepDaftar = New ToolStripSeparator()
        mnuBantuan = New ToolStripMenuItem()
        mnuTentang = New ToolStripMenuItem()
        mnsUtama.SuspendLayout()
        SuspendLayout()
        ' 
        ' mnsUtama
        ' 
        mnsUtama.Items.AddRange(New ToolStripItem() {mnuBerkas, mnuData, mnuJendela, mnuBantuan})
        mnsUtama.Location = New Point(0, 0)
        mnsUtama.MdiWindowListItem = mnuJendela
        mnsUtama.Name = "mnsUtama"
        mnsUtama.Size = New Size(1050, 24)
        mnsUtama.TabIndex = 0
        ' 
        ' mnuBerkas
        ' 
        mnuBerkas.DropDownItems.AddRange(New ToolStripItem() {mnuKeluar})
        mnuBerkas.Name = "mnuBerkas"
        mnuBerkas.Size = New Size(53, 20)
        mnuBerkas.Text = "&Berkas"
        ' 
        ' mnuKeluar
        ' 
        mnuKeluar.Name = "mnuKeluar"
        mnuKeluar.ShortcutKeys = Keys.Control Or Keys.Q
        mnuKeluar.Size = New Size(180, 22)
        mnuKeluar.Text = "&Keluar"
        ' 
        ' mnuData
        ' 
        mnuData.DropDownItems.AddRange(New ToolStripItem() {mnuDataMahasiswa, mnuDataJurusan})
        mnuData.Name = "mnuData"
        mnuData.Size = New Size(43, 20)
        mnuData.Text = "&Data"
        ' 
        ' mnuDataMahasiswa
        ' 
        mnuDataMahasiswa.Name = "mnuDataMahasiswa"
        mnuDataMahasiswa.ShortcutKeys = Keys.Control Or Keys.D1
        mnuDataMahasiswa.Size = New Size(172, 22)
        mnuDataMahasiswa.Text = "&Mahasiswa"
        ' 
        ' mnuDataJurusan
        ' 
        mnuDataJurusan.Name = "mnuDataJurusan"
        mnuDataJurusan.ShortcutKeys = Keys.Control Or Keys.D2
        mnuDataJurusan.Size = New Size(172, 22)
        mnuDataJurusan.Text = "&Jurusan"
        ' 
        ' mnuJendela
        ' 
        mnuJendela.DropDownItems.AddRange(New ToolStripItem() {mnuBertumpuk, mnuHorizontal, mnuVertikal, sepPenutupan, mnuTutupAktif, mnuTutupSemua, sepDaftar})
        mnuJendela.Name = "mnuJendela"
        mnuJendela.Size = New Size(58, 20)
        mnuJendela.Text = "&Jendela"
        ' 
        ' mnuBertumpuk
        ' 
        mnuBertumpuk.Enabled = False
        mnuBertumpuk.Name = "mnuBertumpuk"
        mnuBertumpuk.Size = New Size(210, 22)
        mnuBertumpuk.Text = "&Bertumpuk"
        ' 
        ' mnuHorizontal
        ' 
        mnuHorizontal.Enabled = False
        mnuHorizontal.Name = "mnuHorizontal"
        mnuHorizontal.Size = New Size(210, 22)
        mnuHorizontal.Text = "Berdampingan &Horizontal"
        ' 
        ' mnuVertikal
        ' 
        mnuVertikal.Enabled = False
        mnuVertikal.Name = "mnuVertikal"
        mnuVertikal.Size = New Size(210, 22)
        mnuVertikal.Text = "Berdampingan &Vertikal"
        ' 
        ' sepPenutupan
        ' 
        sepPenutupan.Name = "sepPenutupan"
        sepPenutupan.Size = New Size(207, 6)
        ' 
        ' mnuTutupAktif
        ' 
        mnuTutupAktif.Enabled = False
        mnuTutupAktif.Name = "mnuTutupAktif"
        mnuTutupAktif.ShortcutKeys = Keys.Control Or Keys.W
        mnuTutupAktif.Size = New Size(210, 22)
        mnuTutupAktif.Text = "Tutup &Aktif"
        ' 
        ' mnuTutupSemua
        ' 
        mnuTutupSemua.Enabled = False
        mnuTutupSemua.Name = "mnuTutupSemua"
        mnuTutupSemua.Size = New Size(210, 22)
        mnuTutupSemua.Text = "Tutup &Semua"
        ' 
        ' sepDaftar
        ' 
        sepDaftar.Name = "sepDaftar"
        sepDaftar.Size = New Size(207, 6)
        ' 
        ' mnuBantuan
        ' 
        mnuBantuan.DropDownItems.AddRange(New ToolStripItem() {mnuTentang})
        mnuBantuan.Name = "mnuBantuan"
        mnuBantuan.Size = New Size(63, 20)
        mnuBantuan.Text = "B&antuan"
        ' 
        ' mnuTentang
        ' 
        mnuTentang.Name = "mnuTentang"
        mnuTentang.ShortcutKeys = Keys.F1
        mnuTentang.Size = New Size(136, 22)
        mnuTentang.Text = "&Tentang"
        ' 
        ' FrmUtama
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1050, 650)
        Controls.Add(mnsUtama)
        IsMdiContainer = True
        MainMenuStrip = mnsUtama
        MinimumSize = New Size(700, 480)
        Name = "FrmUtama"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Pertemuan 12 - Administrasi Mahasiswa MDI"
        mnsUtama.ResumeLayout(False)
        mnsUtama.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents mnsUtama As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuBerkas As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuKeluar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDataMahasiswa As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDataJurusan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuJendela As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBertumpuk As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuVertikal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sepPenutupan As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuTutupAktif As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTutupSemua As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents sepDaftar As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuBantuan As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuTentang As System.Windows.Forms.ToolStripMenuItem
End Class
