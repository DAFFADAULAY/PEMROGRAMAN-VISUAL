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
        Me.txtNilai = New System.Windows.Forms.TextBox()
        Me.btnInput = New System.Windows.Forms.Button()
        Me.picImage = New System.Windows.Forms.PictureBox()
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNilai
        '
        Me.txtNilai.Location = New System.Drawing.Point(318, 161)
        Me.txtNilai.Name = "txtNilai"
        Me.txtNilai.Size = New System.Drawing.Size(100, 20)
        Me.txtNilai.TabIndex = 0
        '
        'btnInput
        '
        Me.btnInput.Location = New System.Drawing.Point(329, 187)
        Me.btnInput.Name = "btnInput"
        Me.btnInput.Size = New System.Drawing.Size(75, 23)
        Me.btnInput.TabIndex = 1
        Me.btnInput.Text = "INPUT"
        Me.btnInput.UseVisualStyleBackColor = True
        '
        'picImage
        '
        Me.picImage.Location = New System.Drawing.Point(318, 55)
        Me.picImage.Name = "picImage"
        Me.picImage.Size = New System.Drawing.Size(100, 100)
        Me.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picImage.TabIndex = 2
        Me.picImage.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.picImage)
        Me.Controls.Add(Me.btnInput)
        Me.Controls.Add(Me.txtNilai)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.picImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNilai As TextBox
    Friend WithEvents btnInput As Button
    Friend WithEvents picImage As PictureBox
End Class
