<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBulan = New System.Windows.Forms.TextBox()
        Me.chkMahasiswa = New System.Windows.Forms.CheckBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.lblHasil = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(314, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Durasi Langganan (Bulan):"
        '
        'txtBulan
        '
        Me.txtBulan.Location = New System.Drawing.Point(317, 126)
        Me.txtBulan.Name = "txtBulan"
        Me.txtBulan.Size = New System.Drawing.Size(100, 20)
        Me.txtBulan.TabIndex = 1
        '
        'chkMahasiswa
        '
        Me.chkMahasiswa.AutoSize = True
        Me.chkMahasiswa.Location = New System.Drawing.Point(317, 161)
        Me.chkMahasiswa.Name = "chkMahasiswa"
        Me.chkMahasiswa.Size = New System.Drawing.Size(149, 17)
        Me.chkMahasiswa.TabIndex = 2
        Me.chkMahasiswa.Text = "Status Pelajar/Mahasiswa"
        Me.chkMahasiswa.UseVisualStyleBackColor = True
        '
        'btnHitung
        '
        Me.btnHitung.Location = New System.Drawing.Point(317, 184)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(75, 23)
        Me.btnHitung.TabIndex = 3
        Me.btnHitung.Text = "Hitung Total"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'lblHasil
        '
        Me.lblHasil.AutoSize = True
        Me.lblHasil.Location = New System.Drawing.Point(333, 223)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(39, 13)
        Me.lblHasil.TabIndex = 4
        Me.lblHasil.Text = "Label2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.chkMahasiswa)
        Me.Controls.Add(Me.txtBulan)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtBulan As TextBox
    Friend WithEvents chkMahasiswa As CheckBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents lblHasil As Label
End Class
