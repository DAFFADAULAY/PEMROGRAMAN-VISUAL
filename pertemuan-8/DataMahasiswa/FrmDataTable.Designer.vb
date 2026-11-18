<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmDataTable
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
        Me.lblJudul = New System.Windows.Forms.Label()
        Me.lblCari = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnRapikan = New System.Windows.Forms.Button()
        Me.dgvMahasiswa = New System.Windows.Forms.DataGridView()
        Me.lblJumlah = New System.Windows.Forms.Label()
        Me.bsMahasiswa = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bsMahasiswa, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblJudul.Text = "DataTable + BindingSource"
        '
        'lblCari
        '
        Me.lblCari.AutoSize = True
        Me.lblCari.Location = New System.Drawing.Point(24, 68)
        Me.lblCari.Name = "lblCari"
        Me.lblCari.Size = New System.Drawing.Size(98, 15)
        Me.lblCari.TabIndex = 1
        Me.lblCari.Text = "Cari nama/NIM:"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(130, 64)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(260, 23)
        Me.txtCari.TabIndex = 2
        '
        'btnRapikan
        '
        Me.btnRapikan.Location = New System.Drawing.Point(410, 62)
        Me.btnRapikan.Name = "btnRapikan"
        Me.btnRapikan.Size = New System.Drawing.Size(130, 27)
        Me.btnRapikan.TabIndex = 3
        Me.btnRapikan.Text = "Rapikan Kolom"
        Me.btnRapikan.UseVisualStyleBackColor = True
        '
        'dgvMahasiswa
        '
        Me.dgvMahasiswa.AllowUserToAddRows = False
        Me.dgvMahasiswa.AllowUserToDeleteRows = False
        Me.dgvMahasiswa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMahasiswa.Location = New System.Drawing.Point(24, 104)
        Me.dgvMahasiswa.MultiSelect = False
        Me.dgvMahasiswa.Name = "dgvMahasiswa"
        Me.dgvMahasiswa.ReadOnly = True
        Me.dgvMahasiswa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMahasiswa.Size = New System.Drawing.Size(712, 320)
        Me.dgvMahasiswa.TabIndex = 4
        '
        'lblJumlah
        '
        Me.lblJumlah.AutoSize = True
        Me.lblJumlah.Location = New System.Drawing.Point(24, 438)
        Me.lblJumlah.Name = "lblJumlah"
        Me.lblJumlah.Size = New System.Drawing.Size(175, 15)
        Me.lblJumlah.TabIndex = 5
        Me.lblJumlah.Text = "Menampilkan 0 dari 0 data"
        '
        'FrmDataTable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 470)
        Me.Controls.Add(Me.lblJumlah)
        Me.Controls.Add(Me.dgvMahasiswa)
        Me.Controls.Add(Me.btnRapikan)
        Me.Controls.Add(Me.txtCari)
        Me.Controls.Add(Me.lblCari)
        Me.Controls.Add(Me.lblJudul)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmDataTable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DataTable, BindingSource & Filter"
        CType(Me.dgvMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bsMahasiswa, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents lblCari As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnRapikan As System.Windows.Forms.Button
    Friend WithEvents dgvMahasiswa As System.Windows.Forms.DataGridView
    Friend WithEvents lblJumlah As System.Windows.Forms.Label
    Friend WithEvents bsMahasiswa As System.Windows.Forms.BindingSource

End Class
