<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formSewaMobil
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtIdSewa = New System.Windows.Forms.TextBox()
        Me.txtIdPelanggan = New System.Windows.Forms.TextBox()
        Me.txtIdKaryawan = New System.Windows.Forms.TextBox()
        Me.txtTanggalPinjam = New System.Windows.Forms.TextBox()
        Me.txtTanggalKembali = New System.Windows.Forms.TextBox()
        Me.txtTotalBayar = New System.Windows.Forms.TextBox()
        Me.txtHargaSewa = New System.Windows.Forms.TextBox()
        Me.btnBayar = New System.Windows.Forms.Button()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblKembalian = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDenda = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnPengembalian = New System.Windows.Forms.Button()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtIdMobil = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(15, 265)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(988, 216)
        Me.DataGridView1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Id Sewa"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Id Pelanggan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 134)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Id Karyawan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 175)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Tanggal Pinjam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 210)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Tanggal Kembali"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(300, 54)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total Bayar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(300, 84)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Harga Sewa"
        '
        'txtIdSewa
        '
        Me.txtIdSewa.Location = New System.Drawing.Point(130, 12)
        Me.txtIdSewa.Name = "txtIdSewa"
        Me.txtIdSewa.Size = New System.Drawing.Size(100, 20)
        Me.txtIdSewa.TabIndex = 8
        '
        'txtIdPelanggan
        '
        Me.txtIdPelanggan.Location = New System.Drawing.Point(130, 90)
        Me.txtIdPelanggan.Name = "txtIdPelanggan"
        Me.txtIdPelanggan.Size = New System.Drawing.Size(100, 20)
        Me.txtIdPelanggan.TabIndex = 9
        '
        'txtIdKaryawan
        '
        Me.txtIdKaryawan.Location = New System.Drawing.Point(130, 127)
        Me.txtIdKaryawan.Name = "txtIdKaryawan"
        Me.txtIdKaryawan.Size = New System.Drawing.Size(100, 20)
        Me.txtIdKaryawan.TabIndex = 10
        '
        'txtTanggalPinjam
        '
        Me.txtTanggalPinjam.Location = New System.Drawing.Point(130, 168)
        Me.txtTanggalPinjam.Name = "txtTanggalPinjam"
        Me.txtTanggalPinjam.Size = New System.Drawing.Size(133, 20)
        Me.txtTanggalPinjam.TabIndex = 11
        '
        'txtTanggalKembali
        '
        Me.txtTanggalKembali.Location = New System.Drawing.Point(130, 203)
        Me.txtTanggalKembali.Name = "txtTanggalKembali"
        Me.txtTanggalKembali.Size = New System.Drawing.Size(133, 20)
        Me.txtTanggalKembali.TabIndex = 12
        '
        'txtTotalBayar
        '
        Me.txtTotalBayar.Location = New System.Drawing.Point(418, 51)
        Me.txtTotalBayar.Name = "txtTotalBayar"
        Me.txtTotalBayar.Size = New System.Drawing.Size(100, 20)
        Me.txtTotalBayar.TabIndex = 13
        '
        'txtHargaSewa
        '
        Me.txtHargaSewa.Location = New System.Drawing.Point(418, 77)
        Me.txtHargaSewa.Name = "txtHargaSewa"
        Me.txtHargaSewa.Size = New System.Drawing.Size(100, 20)
        Me.txtHargaSewa.TabIndex = 14
        '
        'btnBayar
        '
        Me.btnBayar.Location = New System.Drawing.Point(609, 212)
        Me.btnBayar.Name = "btnBayar"
        Me.btnBayar.Size = New System.Drawing.Size(75, 23)
        Me.btnBayar.TabIndex = 15
        Me.btnBayar.Text = "Bayar"
        Me.btnBayar.UseVisualStyleBackColor = True
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(690, 212)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 16
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(771, 212)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 18
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(567, 54)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Kembalian   :"
        '
        'lblKembalian
        '
        Me.lblKembalian.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.lblKembalian.AutoSize = True
        Me.lblKembalian.Location = New System.Drawing.Point(673, 55)
        Me.lblKembalian.Name = "lblKembalian"
        Me.lblKembalian.Size = New System.Drawing.Size(10, 13)
        Me.lblKembalian.TabIndex = 20
        Me.lblKembalian.Text = "-"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(300, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(39, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Denda"
        '
        'txtDenda
        '
        Me.txtDenda.Location = New System.Drawing.Point(418, 144)
        Me.txtDenda.Name = "txtDenda"
        Me.txtDenda.Size = New System.Drawing.Size(100, 20)
        Me.txtDenda.TabIndex = 22
        '
        'Label10
        '
        Me.Label10.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(641, 54)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Rp."
        '
        'btnPengembalian
        '
        Me.btnPengembalian.Location = New System.Drawing.Point(517, 212)
        Me.btnPengembalian.Name = "btnPengembalian"
        Me.btnPengembalian.Size = New System.Drawing.Size(86, 23)
        Me.btnPengembalian.TabIndex = 24
        Me.btnPengembalian.Text = "Pengembalian"
        Me.btnPengembalian.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(44, 13)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Id Mobil"
        '
        'txtIdMobil
        '
        Me.txtIdMobil.Location = New System.Drawing.Point(130, 52)
        Me.txtIdMobil.Name = "txtIdMobil"
        Me.txtIdMobil.Size = New System.Drawing.Size(100, 20)
        Me.txtIdMobil.TabIndex = 26
        '
        'formSewaMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1324, 561)
        Me.Controls.Add(Me.txtIdMobil)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.btnPengembalian)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtDenda)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lblKembalian)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.btnBayar)
        Me.Controls.Add(Me.txtHargaSewa)
        Me.Controls.Add(Me.txtTotalBayar)
        Me.Controls.Add(Me.txtTanggalKembali)
        Me.Controls.Add(Me.txtTanggalPinjam)
        Me.Controls.Add(Me.txtIdKaryawan)
        Me.Controls.Add(Me.txtIdPelanggan)
        Me.Controls.Add(Me.txtIdSewa)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "formSewaMobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "formSewaMobil"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtIdSewa As System.Windows.Forms.TextBox
    Friend WithEvents txtIdPelanggan As System.Windows.Forms.TextBox
    Friend WithEvents txtIdKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents txtTanggalPinjam As System.Windows.Forms.TextBox
    Friend WithEvents txtTanggalKembali As System.Windows.Forms.TextBox
    Friend WithEvents txtTotalBayar As System.Windows.Forms.TextBox
    Friend WithEvents txtHargaSewa As System.Windows.Forms.TextBox
    Friend WithEvents btnBayar As System.Windows.Forms.Button
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblKembalian As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDenda As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnPengembalian As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtIdMobil As System.Windows.Forms.TextBox
End Class
