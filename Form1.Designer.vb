<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtUAS = New System.Windows.Forms.TextBox()
        Me.txtUTS = New System.Windows.Forms.TextBox()
        Me.txtTugas = New System.Windows.Forms.TextBox()
        Me.txtNPM = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtIPS = New System.Windows.Forms.TextBox()
        Me.txtIPK = New System.Windows.Forms.TextBox()
        Me.btnHitung = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.Label1.Location = New System.Drawing.Point(341, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PENILAIAN MAHASISWA"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtUAS)
        Me.GroupBox1.Controls.Add(Me.txtUTS)
        Me.GroupBox1.Controls.Add(Me.txtTugas)
        Me.GroupBox1.Controls.Add(Me.txtNPM)
        Me.GroupBox1.Controls.Add(Me.txtNama)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.GroupBox1.Location = New System.Drawing.Point(45, 65)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 339)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NILAI MAHASISWA"
        '
        'txtUAS
        '
        Me.txtUAS.Location = New System.Drawing.Point(177, 248)
        Me.txtUAS.Name = "txtUAS"
        Me.txtUAS.Size = New System.Drawing.Size(100, 25)
        Me.txtUAS.TabIndex = 9
        '
        'txtUTS
        '
        Me.txtUTS.Location = New System.Drawing.Point(177, 194)
        Me.txtUTS.Name = "txtUTS"
        Me.txtUTS.Size = New System.Drawing.Size(100, 25)
        Me.txtUTS.TabIndex = 8
        '
        'txtTugas
        '
        Me.txtTugas.Location = New System.Drawing.Point(178, 144)
        Me.txtTugas.Name = "txtTugas"
        Me.txtTugas.Size = New System.Drawing.Size(100, 25)
        Me.txtTugas.TabIndex = 7
        '
        'txtNPM
        '
        Me.txtNPM.Location = New System.Drawing.Point(177, 88)
        Me.txtNPM.Name = "txtNPM"
        Me.txtNPM.Size = New System.Drawing.Size(100, 25)
        Me.txtNPM.TabIndex = 6
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(179, 41)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(100, 25)
        Me.txtNama.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(49, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 17)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Nilai UAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 202)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 17)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Nilai UTS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(49, 147)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 17)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Nilai Tugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(49, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 17)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "NPM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(49, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Nama Mahasiswa"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label7.Location = New System.Drawing.Point(442, 162)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Total Nilai"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label8.Location = New System.Drawing.Point(442, 227)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(25, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "IPS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(442, 293)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "IPK"
        '
        'txtIPS
        '
        Me.txtIPS.Location = New System.Drawing.Point(530, 219)
        Me.txtIPS.Name = "txtIPS"
        Me.txtIPS.Size = New System.Drawing.Size(100, 23)
        Me.txtIPS.TabIndex = 5
        '
        'txtIPK
        '
        Me.txtIPK.Location = New System.Drawing.Point(530, 290)
        Me.txtIPK.Name = "txtIPK"
        Me.txtIPK.Size = New System.Drawing.Size(100, 23)
        Me.txtIPK.TabIndex = 6
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHitung.Location = New System.Drawing.Point(442, 367)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(83, 37)
        Me.btnHitung.TabIndex = 7
        Me.btnHitung.Text = "HITUNG"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnHapus.Location = New System.Drawing.Point(568, 367)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(92, 37)
        Me.btnHapus.TabIndex = 8
        Me.btnHapus.Text = "HAPUS"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(530, 158)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 23)
        Me.txtTotal.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtIPK)
        Me.Controls.Add(Me.txtIPS)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtUAS As TextBox
    Friend WithEvents txtUTS As TextBox
    Friend WithEvents txtTugas As TextBox
    Friend WithEvents txtNPM As TextBox
    Friend WithEvents txtNama As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtIPS As TextBox
    Friend WithEvents txtIPK As TextBox
    Friend WithEvents btnHitung As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents txtTotal As TextBox
End Class
