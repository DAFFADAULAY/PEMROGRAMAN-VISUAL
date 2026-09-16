<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmArray
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
        lblPanjang = New Label()
        lblLebar = New Label()
        txtPanjang = New TextBox()
        txtLebar = New TextBox()
        lstNilai = New ListBox()
        SuspendLayout()
        ' 
        ' btnTampil
        ' 
        btnTampil.Location = New Point(325, 250)
        btnTampil.Name = "btnTampil"
        btnTampil.Size = New Size(75, 23)
        btnTampil.TabIndex = 0
        btnTampil.Text = "Tampilkan"
        btnTampil.UseVisualStyleBackColor = True
        ' 
        ' lblPanjang
        ' 
        lblPanjang.AutoSize = True
        lblPanjang.Location = New Point(325, 100)
        lblPanjang.Name = "lblPanjang"
        lblPanjang.Size = New Size(50, 15)
        lblPanjang.TabIndex = 1
        lblPanjang.Text = "Panjang"
        ' 
        ' lblLebar
        ' 
        lblLebar.AutoSize = True
        lblLebar.Location = New Point(325, 169)
        lblLebar.Name = "lblLebar"
        lblLebar.Size = New Size(36, 15)
        lblLebar.TabIndex = 2
        lblLebar.Text = "Lebar"
        ' 
        ' txtPanjang
        ' 
        txtPanjang.Location = New Point(325, 130)
        txtPanjang.Name = "txtPanjang"
        txtPanjang.Size = New Size(100, 23)
        txtPanjang.TabIndex = 3
        ' 
        ' txtLebar
        ' 
        txtLebar.Location = New Point(325, 204)
        txtLebar.Name = "txtLebar"
        txtLebar.Size = New Size(100, 23)
        txtLebar.TabIndex = 4
        ' 
        ' lstNilai
        ' 
        lstNilai.FormattingEnabled = True
        lstNilai.Location = New Point(314, 295)
        lstNilai.Name = "lstNilai"
        lstNilai.Size = New Size(120, 94)
        lstNilai.TabIndex = 5
        ' 
        ' FrmArray
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstNilai)
        Controls.Add(txtLebar)
        Controls.Add(txtPanjang)
        Controls.Add(lblLebar)
        Controls.Add(lblPanjang)
        Controls.Add(btnTampil)
        Name = "FrmArray"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnTampil As Button
    Friend WithEvents lblPanjang As Label
    Friend WithEvents lblLebar As Label
    Friend WithEvents txtPanjang As TextBox
    Friend WithEvents txtLebar As TextBox
    Friend WithEvents lstNilai As ListBox

End Class
