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
        Me.btnInput = New Button()
        lblNilaiAwal = New Label()
        Me.lblNilaiAkhir = New Label()
        txtNilaiAwal = New TextBox()
        txtNilaiAkhir = New TextBox()
        SuspendLayout()
        ' 
        ' btnInput
        ' 
        Me.btnInput.Location = New Point(353, 240)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New Size(75, 23)
        Me.btnInput.TabIndex = 0
        Me.btnInput.Text = "INPUT"
        Me.btnInput.UseVisualStyleBackColor = True
        ' 
        ' lblNilaiAwal
        ' 
        lblNilaiAwal.AutoSize = True
        lblNilaiAwal.Location = New Point(353, 90)
        lblNilaiAwal.Name = "lblNilaiAwal"
        lblNilaiAwal.Size = New Size(63, 15)
        lblNilaiAwal.TabIndex = 1
        lblNilaiAwal.Text = "Nilai Awal:"
        ' 
        ' lblNilaiAkhir
        ' 
        Me.lblNilaiAkhir.AutoSize = True
        Me.lblNilaiAkhir.Location = New Point(353, 161)
        Me.lblNilaiAkhir.Name = "lblNilaiAkhir"
        Me.lblNilaiAkhir.Size = New Size(65, 15)
        Me.lblNilaiAkhir.TabIndex = 2
        Me.lblNilaiAkhir.Text = "Nilai Akhir:"
        ' 
        ' txtNilaiAwal
        ' 
        txtNilaiAwal.Location = New Point(353, 119)
        txtNilaiAwal.Name = "txtNilaiAwal"
        txtNilaiAwal.Size = New Size(100, 23)
        txtNilaiAwal.TabIndex = 3
        ' 
        ' txtNilaiAkhir
        ' 
        txtNilaiAkhir.Location = New Point(353, 193)
        txtNilaiAkhir.Name = "txtNilaiAkhir"
        txtNilaiAkhir.Size = New Size(100, 23)
        txtNilaiAkhir.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNilaiAkhir)
        Controls.Add(txtNilaiAwal)
        Controls.Add(Me.lblNilaiAkhir)
        Controls.Add(lblNilaiAwal)
        Controls.Add(Me.btnInput)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents lblNilaiAwal As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNilaiAwal As TextBox
    Friend WithEvents txtNilaiAkhir As TextBox

End Class
