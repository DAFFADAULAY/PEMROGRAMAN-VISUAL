<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        btnTampil = New Button()
        dgvMahasiswa = New DataGridView()
        lblNama = New Label()
        lblNim = New Label()
        lblJurusan = New Label()
        txtNama = New TextBox()
        Me.txtNIM = New TextBox()
        txtJurusan = New TextBox()
        btnTambah = New Button()
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(191, 238)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(75, 23)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' dgvMahasiswa
        ' 
        dgvMahasiswa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMahasiswa.Location = New Point(111, 66)
        dgvMahasiswa.Name = "dgvMahasiswa"
        dgvMahasiswa.Size = New Size(240, 150)
        dgvMahasiswa.TabIndex = 1
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(406, 66)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(39, 15)
        lblNama.TabIndex = 2
        lblNama.Text = "Nama"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(406, 111)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(30, 15)
        lblNim.TabIndex = 3
        lblNim.Text = "NIM"
        ' 
        ' lblJurusan
        ' 
        lblJurusan.AutoSize = True
        lblJurusan.Location = New Point(406, 156)
        lblJurusan.Name = "lblJurusan"
        lblJurusan.Size = New Size(47, 15)
        lblJurusan.TabIndex = 4
        lblJurusan.Text = "Jurusan"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(475, 58)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 5
        ' 
        ' txtNIM
        ' 
        Me.txtNIM.Location = New Point(475, 103)
        Me.txtNIM.Name = "txtNIM"
        Me.txtNIM.Size = New Size(100, 23)
        Me.txtNIM.TabIndex = 6
        ' 
        ' txtJurusan
        ' 
        txtJurusan.Location = New Point(475, 153)
        txtJurusan.Name = "txtJurusan"
        txtJurusan.Size = New Size(100, 23)
        txtJurusan.TabIndex = 7
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(442, 207)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(75, 23)
        btnTambah.TabIndex = 8
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnTambah)
        Controls.Add(txtJurusan)
        Controls.Add(Me.txtNIM)
        Controls.Add(txtNama)
        Controls.Add(lblJurusan)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(dgvMahasiswa)
        Controls.Add(btnTampil)
        Name = "Form1"
        Text = "Form1"
        CType(dgvMahasiswa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents dgvMahasiswa As DataGridView
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents lblJurusan As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents txtJurusan As TextBox
    Friend WithEvents btnTambah As Button

End Class
