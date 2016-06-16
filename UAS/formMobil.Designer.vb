<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMobil
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtMerkMobil = New System.Windows.Forms.TextBox()
        Me.txtJenisMobil = New System.Windows.Forms.TextBox()
        Me.txtNoPlatMobil = New System.Windows.Forms.TextBox()
        Me.txtIdMobil = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTahunMobil = New System.Windows.Forms.TextBox()
        Me.txtWarnaMobil = New System.Windows.Forms.TextBox()
        Me.txtHargaSewa = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(561, 20)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(123, 13)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "Masukkan Id Pelanggan"
        '
        'txtCheck
        '
        Me.txtCheck.Location = New System.Drawing.Point(688, 17)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(58, 20)
        Me.txtCheck.TabIndex = 65
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(726, 132)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 64
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(645, 132)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 63
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(564, 132)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 62
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(754, 15)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(47, 23)
        Me.btnCheck.TabIndex = 66
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 177)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(789, 293)
        Me.DataGridView1.TabIndex = 61
        '
        'txtMerkMobil
        '
        Me.txtMerkMobil.Location = New System.Drawing.Point(130, 130)
        Me.txtMerkMobil.Name = "txtMerkMobil"
        Me.txtMerkMobil.Size = New System.Drawing.Size(98, 20)
        Me.txtMerkMobil.TabIndex = 60
        '
        'txtJenisMobil
        '
        Me.txtJenisMobil.Location = New System.Drawing.Point(130, 98)
        Me.txtJenisMobil.Multiline = True
        Me.txtJenisMobil.Name = "txtJenisMobil"
        Me.txtJenisMobil.Size = New System.Drawing.Size(98, 20)
        Me.txtJenisMobil.TabIndex = 59
        '
        'txtNoPlatMobil
        '
        Me.txtNoPlatMobil.Location = New System.Drawing.Point(130, 69)
        Me.txtNoPlatMobil.Name = "txtNoPlatMobil"
        Me.txtNoPlatMobil.Size = New System.Drawing.Size(98, 20)
        Me.txtNoPlatMobil.TabIndex = 58
        '
        'txtIdMobil
        '
        Me.txtIdMobil.Location = New System.Drawing.Point(130, 13)
        Me.txtIdMobil.Name = "txtIdMobil"
        Me.txtIdMobil.Size = New System.Drawing.Size(59, 20)
        Me.txtIdMobil.TabIndex = 56
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Merk Mobil"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Jenis Mobil"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "No Plat Mobil"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Id Mobil"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(272, 20)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(123, 13)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Tahun Pembuatan Mobil"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(273, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 69
        Me.Label8.Text = "Warna Mobil"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(273, 85)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 13)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Harga Sewa"
        '
        'txtTahunMobil
        '
        Me.txtTahunMobil.Location = New System.Drawing.Point(414, 17)
        Me.txtTahunMobil.Name = "txtTahunMobil"
        Me.txtTahunMobil.Size = New System.Drawing.Size(98, 20)
        Me.txtTahunMobil.TabIndex = 71
        '
        'txtWarnaMobil
        '
        Me.txtWarnaMobil.Location = New System.Drawing.Point(414, 47)
        Me.txtWarnaMobil.Name = "txtWarnaMobil"
        Me.txtWarnaMobil.Size = New System.Drawing.Size(98, 20)
        Me.txtWarnaMobil.TabIndex = 72
        '
        'txtHargaSewa
        '
        Me.txtHargaSewa.Location = New System.Drawing.Point(414, 78)
        Me.txtHargaSewa.Name = "txtHargaSewa"
        Me.txtHargaSewa.Size = New System.Drawing.Size(98, 20)
        Me.txtHargaSewa.TabIndex = 73
        '
        'formMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 498)
        Me.Controls.Add(Me.txtHargaSewa)
        Me.Controls.Add(Me.txtWarnaMobil)
        Me.Controls.Add(Me.txtTahunMobil)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtMerkMobil)
        Me.Controls.Add(Me.txtJenisMobil)
        Me.Controls.Add(Me.txtNoPlatMobil)
        Me.Controls.Add(Me.txtIdMobil)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formMobil"
        Me.Text = "formMobil"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtMerkMobil As System.Windows.Forms.TextBox
    Friend WithEvents txtJenisMobil As System.Windows.Forms.TextBox
    Friend WithEvents txtNoPlatMobil As System.Windows.Forms.TextBox
    Friend WithEvents txtIdMobil As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTahunMobil As System.Windows.Forms.TextBox
    Friend WithEvents txtWarnaMobil As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaSewa As System.Windows.Forms.TextBox
End Class
