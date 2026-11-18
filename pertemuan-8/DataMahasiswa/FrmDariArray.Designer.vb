<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDariArray
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
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.dgvMahasiswa = New System.Windows.Forms.DataGridView()
        Me.btnTampilkan = New System.Windows.Forms.Button()
        Me.btnKosongkan = New System.Windows.Forms.Button()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.colNim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colNama = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colJurusan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colAngkatan = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.colIpk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(24, 16)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(325, 25)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Data dari Array 2 Dimensi"
        '
        'dgvMahasiswa
        '
        Me.dgvMahasiswa.AllowUserToAddRows = False
        Me.dgvMahasiswa.AllowUserToDeleteRows = False
        Me.dgvMahasiswa.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMahasiswa.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colNim, Me.colNama, Me.colJurusan, Me.colAngkatan, Me.colIpk})
        Me.dgvMahasiswa.Location = New System.Drawing.Point(24, 60)
        Me.dgvMahasiswa.MultiSelect = False
        Me.dgvMahasiswa.Name = "dgvMahasiswa"
        Me.dgvMahasiswa.ReadOnly = True
        Me.dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMahasiswa.Size = New System.Drawing.Size(672, 250)
        Me.dgvMahasiswa.TabIndex = 1
        '
        'btnTampilkan
        '
        Me.btnTampilkan.Location = New System.Drawing.Point(24, 322)
        Me.btnTampilkan.Name = "btnTampilkan"
        Me.btnTampilkan.Size = New System.Drawing.Size(110, 30)
        Me.btnTampilkan.TabIndex = 2
        Me.btnTampilkan.Text = "Tampilkan"
        Me.btnTampilkan.UseVisualStyleBackColor = True
        '
        'btnKosongkan
        '
        Me.btnKosongkan.Location = New System.Drawing.Point(144, 322)
        Me.btnKosongkan.Name = "btnKosongkan"
        Me.btnKosongkan.Size = New System.Drawing.Size(110, 30)
        Me.btnKosongkan.TabIndex = 3
        Me.btnKosongkan.Text = "Kosongkan"
        Me.btnKosongkan.UseVisualStyleBackColor = True
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(24, 368)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(98, 15)
        Me.lblJumlah.TabIndex = 4
        Me.lblJumlah.Text = "Jumlah data: 0"
        '
        'colNim
        '
        Me.colNim.HeaderText = "NIM"
        Me.colNim.Name = "colNim"
        '
        'colNama
        '
        Me.colNama.HeaderText = "Nama"
        Me.colNama.Name = "colNama"
        '
        'colJurusan
        '
        Me.colJurusan.HeaderText = "Jurusan"
        Me.colJurusan.Name = "colJurusan"
        '
        'colAngkatan
        '
        Me.colAngkatan.HeaderText = "Angkatan"
        Me.colAngkatan.Name = "colAngkatan"
        '
        'colIpk
        '
        Me.colIpk.HeaderText = "IPK"
        Me.colIpk.Name = "colIpk"
        '
        'FrmDariArray
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 400)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.btnKosongkan)
        Me.Controls.Add(Me.btnTampilkan)
        Me.Controls.Add(Me.dgvMahasiswa)
        Me.Controls.Add(Me.lblJudul)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmDariArray"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataGridView dari Array"
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents dgvMahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents btnTampilkan As System.Windows.Forms.Button
    Friend WithEvents btnKosongkan As System.Windows.Forms.Button
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents colNim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colNama As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colJurusan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colAngkatan As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colIpk As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
