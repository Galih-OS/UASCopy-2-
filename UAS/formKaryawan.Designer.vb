<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formKaryawan
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
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtNoTelp = New System.Windows.Forms.TextBox()
        Me.txtJenisKelamin = New System.Windows.Forms.TextBox()
        Me.txtAlamatKaryawan = New System.Windows.Forms.TextBox()
        Me.txtNamaKaryawan = New System.Windows.Forms.TextBox()
        Me.txtIdKaryawan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDKARYAWANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NAMAKARYAWANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ALAMATKARYAWANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JKKARYAWANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NOTELPKARYAWANDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PASSDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnSimpan = New System.Windows.Forms.Button()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.txtCheck = New System.Windows.Forms.TextBox()
        Me.btnCheck = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(161, 166)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(58, 20)
        Me.txtPass.TabIndex = 24
        '
        'txtNoTelp
        '
        Me.txtNoTelp.Location = New System.Drawing.Point(161, 136)
        Me.txtNoTelp.Name = "txtNoTelp"
        Me.txtNoTelp.Size = New System.Drawing.Size(142, 20)
        Me.txtNoTelp.TabIndex = 23
        '
        'txtJenisKelamin
        '
        Me.txtJenisKelamin.Location = New System.Drawing.Point(161, 104)
        Me.txtJenisKelamin.Multiline = True
        Me.txtJenisKelamin.Name = "txtJenisKelamin"
        Me.txtJenisKelamin.Size = New System.Drawing.Size(58, 20)
        Me.txtJenisKelamin.TabIndex = 22
        '
        'txtAlamatKaryawan
        '
        Me.txtAlamatKaryawan.Location = New System.Drawing.Point(161, 75)
        Me.txtAlamatKaryawan.Name = "txtAlamatKaryawan"
        Me.txtAlamatKaryawan.Size = New System.Drawing.Size(217, 20)
        Me.txtAlamatKaryawan.TabIndex = 21
        '
        'txtNamaKaryawan
        '
        Me.txtNamaKaryawan.Location = New System.Drawing.Point(161, 49)
        Me.txtNamaKaryawan.Name = "txtNamaKaryawan"
        Me.txtNamaKaryawan.Size = New System.Drawing.Size(217, 20)
        Me.txtNamaKaryawan.TabIndex = 20
        '
        'txtIdKaryawan
        '
        Me.txtIdKaryawan.Location = New System.Drawing.Point(161, 22)
        Me.txtIdKaryawan.Name = "txtIdKaryawan"
        Me.txtIdKaryawan.Size = New System.Drawing.Size(58, 20)
        Me.txtIdKaryawan.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(30, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Pass"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "No. Telp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 107)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Alamat Karyawan"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nama Karyawan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Id Karyawan"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDKARYAWANDataGridViewTextBoxColumn, Me.NAMAKARYAWANDataGridViewTextBoxColumn, Me.ALAMATKARYAWANDataGridViewTextBoxColumn, Me.JKKARYAWANDataGridViewTextBoxColumn, Me.NOTELPKARYAWANDataGridViewTextBoxColumn, Me.PASSDataGridViewTextBoxColumn})
        Me.DataGridView1.Location = New System.Drawing.Point(18, 216)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(789, 256)
        Me.DataGridView1.TabIndex = 25
        '
        'IDKARYAWANDataGridViewTextBoxColumn
        '
        Me.IDKARYAWANDataGridViewTextBoxColumn.DataPropertyName = "ID_KARYAWAN"
        Me.IDKARYAWANDataGridViewTextBoxColumn.HeaderText = "ID_KARYAWAN"
        Me.IDKARYAWANDataGridViewTextBoxColumn.Name = "IDKARYAWANDataGridViewTextBoxColumn"
        Me.IDKARYAWANDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NAMAKARYAWANDataGridViewTextBoxColumn
        '
        Me.NAMAKARYAWANDataGridViewTextBoxColumn.DataPropertyName = "NAMA_KARYAWAN"
        Me.NAMAKARYAWANDataGridViewTextBoxColumn.HeaderText = "NAMA_KARYAWAN"
        Me.NAMAKARYAWANDataGridViewTextBoxColumn.Name = "NAMAKARYAWANDataGridViewTextBoxColumn"
        '
        'ALAMATKARYAWANDataGridViewTextBoxColumn
        '
        Me.ALAMATKARYAWANDataGridViewTextBoxColumn.DataPropertyName = "ALAMAT_KARYAWAN"
        Me.ALAMATKARYAWANDataGridViewTextBoxColumn.HeaderText = "ALAMAT_KARYAWAN"
        Me.ALAMATKARYAWANDataGridViewTextBoxColumn.Name = "ALAMATKARYAWANDataGridViewTextBoxColumn"
        '
        'JKKARYAWANDataGridViewTextBoxColumn
        '
        Me.JKKARYAWANDataGridViewTextBoxColumn.DataPropertyName = "JK_KARYAWAN"
        Me.JKKARYAWANDataGridViewTextBoxColumn.HeaderText = "JK_KARYAWAN"
        Me.JKKARYAWANDataGridViewTextBoxColumn.Name = "JKKARYAWANDataGridViewTextBoxColumn"
        '
        'NOTELPKARYAWANDataGridViewTextBoxColumn
        '
        Me.NOTELPKARYAWANDataGridViewTextBoxColumn.DataPropertyName = "NO_TELP_KARYAWAN"
        Me.NOTELPKARYAWANDataGridViewTextBoxColumn.HeaderText = "NO_TELP_KARYAWAN"
        Me.NOTELPKARYAWANDataGridViewTextBoxColumn.Name = "NOTELPKARYAWANDataGridViewTextBoxColumn"
        '
        'PASSDataGridViewTextBoxColumn
        '
        Me.PASSDataGridViewTextBoxColumn.DataPropertyName = "PASS"
        Me.PASSDataGridViewTextBoxColumn.HeaderText = "PASS"
        Me.PASSDataGridViewTextBoxColumn.Name = "PASSDataGridViewTextBoxColumn"
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(451, 172)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(75, 23)
        Me.btnSimpan.TabIndex = 26
        Me.btnSimpan.Text = "Simpan"
        Me.btnSimpan.UseVisualStyleBackColor = True
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(532, 172)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(75, 23)
        Me.btnUbah.TabIndex = 27
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(613, 172)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 28
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'txtCheck
        '
        Me.txtCheck.Location = New System.Drawing.Point(575, 19)
        Me.txtCheck.Name = "txtCheck"
        Me.txtCheck.Size = New System.Drawing.Size(58, 20)
        Me.txtCheck.TabIndex = 29
        '
        'btnCheck
        '
        Me.btnCheck.Location = New System.Drawing.Point(641, 17)
        Me.btnCheck.Name = "btnCheck"
        Me.btnCheck.Size = New System.Drawing.Size(47, 23)
        Me.btnCheck.TabIndex = 30
        Me.btnCheck.Text = "Check"
        Me.btnCheck.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(448, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(119, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Masukkan Id Karyawan"
        '
        'formKaryawan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 484)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnCheck)
        Me.Controls.Add(Me.txtCheck)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.btnUbah)
        Me.Controls.Add(Me.btnSimpan)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtNoTelp)
        Me.Controls.Add(Me.txtJenisKelamin)
        Me.Controls.Add(Me.txtAlamatKaryawan)
        Me.Controls.Add(Me.txtNamaKaryawan)
        Me.Controls.Add(Me.txtIdKaryawan)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "formKaryawan"
        Me.Text = "formKaryawan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtNoTelp As System.Windows.Forms.TextBox
    Friend WithEvents txtJenisKelamin As System.Windows.Forms.TextBox
    Friend WithEvents txtAlamatKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents txtNamaKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents txtIdKaryawan As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents btnSimpan As System.Windows.Forms.Button
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents txtCheck As System.Windows.Forms.TextBox
    Friend WithEvents btnCheck As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents IDKARYAWANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NAMAKARYAWANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ALAMATKARYAWANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JKKARYAWANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NOTELPKARYAWANDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PASSDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
