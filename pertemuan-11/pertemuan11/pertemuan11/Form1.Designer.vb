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
        Label1 = New Label()
        Label2 = New Label()
        Me.pnlTimer = New Panel()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        btnMulai = New Button()
        Me.btnUlangi = New Button()
        btnRingkas = New Button()
        CheckBox1 = New CheckBox()
        Me.lblDurasi = New Label()
        Me.nudMenit = New NumericUpDown()
        Me.lblMenit = New Label()
        Me.lblDetik = New Label()
        Me.nudDetik = New NumericUpDown()
        chkBunyi = New CheckBox()
        Label9 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Me.pnlTimer.SuspendLayout()
        CType(Me.nudMenit, ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudDetik, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(183, 25)
        Label1.TabIndex = 0
        Label1.Text = "Asistensi Presentasi"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 48)
        Label2.Name = "Label2"
        Label2.Size = New Size(233, 15)
        Label2.TabIndex = 1
        Label2.Text = "Jaga durasi tanpa meninggalkan slide anda"
        ' 
        ' pnlTimer
        ' 
        Me.pnlTimer.BackColor = SystemColors.ActiveCaptionText
        Me.pnlTimer.Controls.Add(Label5)
        Me.pnlTimer.Controls.Add(Label4)
        Me.pnlTimer.Controls.Add(Label3)
        Me.pnlTimer.Location = New Point(12, 77)
        Me.pnlTimer.Name = "pnlTimer"
        Me.pnlTimer.Size = New Size(333, 115)
        Me.pnlTimer.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = SystemColors.ControlLightLight
        Label5.Location = New Point(59, 81)
        Label5.Name = "Label5"
        Label5.Size = New Size(212, 15)
        Label5.TabIndex = 2
        Label5.Text = "Atur durasi, lalu mulai ketika Anda siap"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ControlLightLight
        Label4.Location = New Point(127, 40)
        Label4.Name = "Label4"
        Label4.Size = New Size(67, 30)
        Label4.TabIndex = 1
        Label4.Text = "05:00"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = SystemColors.Control
        Label3.Location = New Point(118, 13)
        Label3.Name = "Label3"
        Label3.Size = New Size(85, 15)
        Label3.TabIndex = 0
        Label3.Text = "Siap presentasi"
        ' 
        ' btnMulai
        ' 
        btnMulai.BackColor = SystemColors.MenuHighlight
        btnMulai.Font = New Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnMulai.ForeColor = SystemColors.ButtonHighlight
        btnMulai.Location = New Point(12, 198)
        btnMulai.Name = "btnMulai"
        btnMulai.Size = New Size(203, 49)
        btnMulai.TabIndex = 3
        btnMulai.Text = "Mulai Presentasi"
        btnMulai.UseVisualStyleBackColor = False
        ' 
        ' btnUlangi
        ' 
        Me.btnUlangi.Location = New Point(221, 198)
        Me.btnUlangi.Name = "btnUlangi"
        Me.btnUlangi.Size = New Size(124, 49)
        Me.btnUlangi.TabIndex = 4
        Me.btnUlangi.Text = "Ulangi"
        Me.btnUlangi.UseVisualStyleBackColor = True
        ' 
        ' btnRingkas
        ' 
        btnRingkas.Location = New Point(221, 253)
        btnRingkas.Name = "btnRingkas"
        btnRingkas.Size = New Size(124, 33)
        btnRingkas.TabIndex = 5
        btnRingkas.Text = "Mode ringkas"
        btnRingkas.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(12, 261)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(156, 19)
        CheckBox1.TabIndex = 6
        CheckBox1.Text = "Tetap di atas aplikasi lain"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' lblDurasi
        ' 
        Me.lblDurasi.AutoSize = True
        Me.lblDurasi.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Me.lblDurasi.Location = New Point(12, 292)
        Me.lblDurasi.Name = "lblDurasi"
        Me.lblDurasi.Size = New Size(102, 15)
        Me.lblDurasi.TabIndex = 7
        Me.lblDurasi.Text = "Durasi presentasi"
        ' 
        ' nudMenit
        ' 
        Me.nudMenit.Location = New Point(56, 315)
        Me.nudMenit.Name = "nudMenit"
        Me.nudMenit.Size = New Size(50, 23)
        Me.nudMenit.TabIndex = 8
        ' 
        ' lblMenit
        ' 
        Me.lblMenit.AutoSize = True
        Me.lblMenit.Location = New Point(12, 317)
        Me.lblMenit.Name = "lblMenit"
        Me.lblMenit.Size = New Size(38, 15)
        Me.lblMenit.TabIndex = 9
        Me.lblMenit.Text = "Menit"
        ' 
        ' lblDetik
        ' 
        Me.lblDetik.AutoSize = True
        Me.lblDetik.Location = New Point(112, 317)
        Me.lblDetik.Name = "lblDetik"
        Me.lblDetik.Size = New Size(34, 15)
        Me.lblDetik.TabIndex = 10
        Me.lblDetik.Text = "Detik"
        ' 
        ' nudDetik
        ' 
        Me.nudDetik.Location = New Point(157, 315)
        Me.nudDetik.Name = "nudDetik"
        Me.nudDetik.Size = New Size(49, 23)
        Me.nudDetik.TabIndex = 11
        ' 
        ' chkBunyi
        ' 
        chkBunyi.AutoSize = True
        chkBunyi.Location = New Point(221, 319)
        chkBunyi.Name = "chkBunyi"
        chkBunyi.Size = New Size(117, 19)
        chkBunyi.TabIndex = 12
        chkBunyi.Text = "Bunyi saat selesai"
        chkBunyi.UseVisualStyleBackColor = True
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(12, 358)
        Label9.Name = "Label9"
        Label9.Size = New Size(132, 15)
        Label9.TabIndex = 13
        Label9.Text = "Ctrl+Alt+F9: mulai/jeda"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(12, 373)
        Label10.Name = "Label10"
        Label10.Size = New Size(283, 15)
        Label10.TabIndex = 14
        Label10.Text = "Ctrl+Alt+F10: ulangi. Tombol tetap dapat digunakan"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Location = New Point(12, 412)
        Label11.Name = "Label11"
        Label11.Size = New Size(363, 15)
        Label11.TabIndex = 15
        Label11.Text = "Timer siap. Aktifkan Tetap di atas agar terlihat saat berganti aplikasi."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(400, 453)
        Controls.Add(Label11)
        Controls.Add(Label10)
        Controls.Add(Label9)
        Controls.Add(chkBunyi)
        Controls.Add(Me.nudDetik)
        Controls.Add(Me.lblDetik)
        Controls.Add(Me.lblMenit)
        Controls.Add(Me.nudMenit)
        Controls.Add(Me.lblDurasi)
        Controls.Add(CheckBox1)
        Controls.Add(btnRingkas)
        Controls.Add(Me.btnUlangi)
        Controls.Add(btnMulai)
        Controls.Add(Me.pnlTimer)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        Me.pnlTimer.ResumeLayout(False)
        Me.pnlTimer.PerformLayout()
        CType(Me.nudMenit, ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudDetik, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnMulai As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnUlang As Button
    Friend WithEvents btnRingkas As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents NumericUpDown2 As NumericUpDown
    Friend WithEvents chkBunyi As CheckBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label

End Class
