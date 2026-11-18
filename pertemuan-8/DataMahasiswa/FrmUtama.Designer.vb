<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUtama
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
        Me.btnDariArray = New System.Windows.Forms.Button()
        Me.btnDariList = New System.Windows.Forms.Button()
        Me.btnDataTable = New System.Windows.Forms.Button()
        Me.btnCariList = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblJudul
        '
        Me.lblJudul.AutoSize = True
        Me.lblJudul.Font = New System.Drawing.Font("Segoe UI", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJudul.Location = New System.Drawing.Point(24, 20)
        Me.lblJudul.Name = "lblJudul"
        Me.lblJudul.Size = New System.Drawing.Size(234, 25)
        Me.lblJudul.TabIndex = 0
        Me.lblJudul.Text = "Contoh Pertemuan 8"
        '
        'btnDariArray
        '
        Me.btnDariArray.Location = New System.Drawing.Point(24, 70)
        Me.btnDariArray.Name = "btnDariArray"
        Me.btnDariArray.Size = New System.Drawing.Size(392, 40)
        Me.btnDariArray.TabIndex = 1
        Me.btnDariArray.Text = "1. DataGridView dari Array"
        Me.btnDariArray.UseVisualStyleBackColor = True
        '
        'btnDariList
        '
        Me.btnDariList.Location = New System.Drawing.Point(24, 120)
        Me.btnDariList.Name = "btnDariList"
        Me.btnDariList.Size = New System.Drawing.Size(392, 40)
        Me.btnDariList.TabIndex = 2
        Me.btnDariList.Text = "2. Binding List(Of Mahasiswa)"
        Me.btnDariList.UseVisualStyleBackColor = True
        '
        'btnDataTable
        '
        Me.btnDataTable.Location = New System.Drawing.Point(24, 170)
        Me.btnDataTable.Name = "btnDataTable"
        Me.btnDataTable.Size = New System.Drawing.Size(392, 40)
        Me.btnDataTable.TabIndex = 3
        Me.btnDataTable.Text = "3. DataTable, Rapikan Kolom dan Filter"
        Me.btnDataTable.UseVisualStyleBackColor = True
        '
        'btnCariList
        '
        Me.btnCariList.Location = New System.Drawing.Point(24, 220)
        Me.btnCariList.Name = "btnCariList"
        Me.btnCariList.Size = New System.Drawing.Size(392, 40)
        Me.btnCariList.TabIndex = 4
        Me.btnCariList.Text = "4. Pencarian dengan Perulangan"
        Me.btnCariList.UseVisualStyleBackColor = True
        '
        'FrmUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(440, 300)
        Me.Controls.Add(Me.btnCariList)
        Me.Controls.Add(Me.btnDataTable)
        Me.Controls.Add(Me.btnDariList)
        Me.Controls.Add(Me.btnDariArray)
        Me.Controls.Add(Me.lblJudul)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "FrmUtama"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pertemuan 8 - DataGridView, Array & Koleksi Data"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblJudul As System.Windows.Forms.Label
    Friend WithEvents btnDariArray As System.Windows.Forms.Button
    Friend WithEvents btnDariList As System.Windows.Forms.Button
    Friend WithEvents btnDataTable As System.Windows.Forms.Button
    Friend WithEvents btnCariList As System.Windows.Forms.Button

End Class
