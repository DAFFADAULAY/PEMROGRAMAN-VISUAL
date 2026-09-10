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
        btnLogin = New Button()
        picImage = New PictureBox()
        cmbRole = New ComboBox()
        lblRole = New Label()
        lblNama = New Label()
        lblNim = New Label()
        txtNama = New TextBox()
        txtNIM = New TextBox()
        CType(picImage, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnLogin
        ' 
        btnLogin.Location = New Point(346, 249)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(75, 23)
        btnLogin.TabIndex = 0
        btnLogin.Text = "Login"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' picImage
        ' 
        picImage.Location = New Point(327, 55)
        picImage.Name = "picImage"
        picImage.Size = New Size(100, 50)
        picImage.SizeMode = PictureBoxSizeMode.StretchImage
        picImage.TabIndex = 1
        picImage.TabStop = False
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Location = New Point(346, 122)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(121, 23)
        cmbRole.TabIndex = 2
        ' 
        ' lblRole
        ' 
        lblRole.AutoSize = True
        lblRole.Location = New Point(299, 125)
        lblRole.Name = "lblRole"
        lblRole.Size = New Size(38, 15)
        lblRole.TabIndex = 3
        lblRole.Text = "ROLE:"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(299, 164)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(46, 15)
        lblNama.TabIndex = 4
        lblNama.Text = "NAMA:"
        ' 
        ' lblNim
        ' 
        lblNim.AutoSize = True
        lblNim.Location = New Point(299, 208)
        lblNim.Name = "lblNim"
        lblNim.Size = New Size(33, 15)
        lblNim.TabIndex = 5
        lblNim.Text = "NIM:"
        ' 
        ' txtNama
        ' 
        txtNama.Location = New Point(346, 161)
        txtNama.Name = "txtNama"
        txtNama.Size = New Size(100, 23)
        txtNama.TabIndex = 6
        ' 
        ' txtNIM
        ' 
        txtNIM.Location = New Point(346, 205)
        txtNIM.Name = "txtNIM"
        txtNIM.Size = New Size(100, 23)
        txtNIM.TabIndex = 7
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(txtNIM)
        Controls.Add(txtNama)
        Controls.Add(lblNim)
        Controls.Add(lblNama)
        Controls.Add(lblRole)
        Controls.Add(cmbRole)
        Controls.Add(picImage)
        Controls.Add(btnLogin)
        Name = "Form1"
        Text = "FrmLogin"
        CType(picImage, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnLogin As Button
    Friend WithEvents picImage As PictureBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents lblRole As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents lblNim As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNIM As TextBox

End Class
