Imports System.Data.SqlClient
Public Class formSewaMobil

    Dim conn As New SqlConnection("server= GALIH-OS\GALIHOS; database=RentalMobil; integrated security=true") 'koneksi database'
    Dim comm As SqlCommand 'command'
    Dim dr As SqlDataReader 'membaca tabel lebih dari satu nilai'
    Dim cb As SqlCommandBuilder
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim code As String
    Dim dsMobil As New DataSet("dsMobil")
    Dim dtKaryawan As New DataTable("dtSewa")

    Private Sub formSewaMobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDataAdapter()
        tampilTabel()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'box()
        bersih()
        tbdenda()
        idsewa()
        idpelanggan()
        idkaryawan()
        idmobil()
    End Sub

    'text box non aktif
    'Sub box()
    '    txtIdMobil.Enabled = False
    '    txtIdSewa.Enabled = False
    '    txtNoPlatMobil.Enabled = False
    '    txtJenisMobil.Enabled = False
    '    txtMerkMobil.Enabled = False
    '    txtTahunMobil.Enabled = False
    '    txtWarnaMobil.Enabled = False
    '    txtHargaSewa.Enabled = False
    'End Sub

    Sub CreateDataAdapter()
        dsMobil.Clear()
        da = New SqlDataAdapter("select hrs.ID_SEWA,  m.ID_MOBIL, hrs.ID_PELANGGAN, hrs.ID_KARYAWAN, hrs.TGL_PINJAM, hrs.TGL_KEMBALI, m.harga, hrs.TOT_BAYAR, hrs.KEMBALIAN, hrs.DENDA from dbo.tampilSewa() as hrs join MOBIL as m on hrs.ID_MOBIL = m.ID_MOBIL", conn)
        cb = New SqlCommandBuilder(da)
        da.FillSchema(dsMobil, SchemaType.Mapped, "dtSewa")
        da.Fill(dsMobil, "dtSewa")
        da.Dispose()
    End Sub

    Sub tampilTabel()
        CreateDataAdapter()
        DataGridView1.DataSource = dsMobil
        DataGridView1.DataMember = "dtSewa"
        With DataGridView1
            .Columns(0).HeaderText = "ID Sewa"
            .Columns(1).HeaderText = "ID Mobil"
            .Columns(2).HeaderText = "ID Pelanggan"
            .Columns(3).HeaderText = "Id_Karyawan"
            .Columns(4).HeaderText = "Tgl Pinjam"
            .Columns(5).HeaderText = "Tgl Kembali"
            .Columns(6).HeaderText = "Harga"
            .Columns(7).HeaderText = "Total Bayar"
            .Columns(8).HeaderText = "Kembalian"
            .Columns(9).HeaderText = "Denda"

            .Columns(0).Width = 70
            .Columns(1).Width = 70
            .Columns(2).Width = 70
            .Columns(3).Width = 70
            .Columns(4).Width = 100
            .Columns(5).Width = 100
            .Columns(6).Width = 100
            .Columns(7).Width = 100
            .Columns(8).Width = 70
            .Columns(9).Width = 70
        End With
    End Sub

    'Clear Data'
    Sub bersih()
        txtIdMobil.Text = ""
        txtIdSewa.Text = ""
        txtIdPelanggan.Text = ""
        txtIdKaryawan.Text = ""
        txtTanggalPinjam.Text = ""
        txtTanggalKembali.Text = ""
        txtTotalBayar.Text = ""
        txtDenda.Text = ""
        txtHargaSewa.Text = ""
        lblKembalian.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        conn.Open()
        'comm = New SqlCommand("dbo.simpanMobil", conn)
        comm = New SqlCommand("dbo.simpanSewa", conn)
        'comm = New SqlCommand("dbo.simpanPelanggan", conn)
        ' comm = New SqlCommand("dbo.simpanKaryawan", conn)
        'dr = comm.ExecuteReader
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@id_sewa", SqlDbType.Int).Value = txtIdSewa.Text
        comm.Parameters.Add("@id_pelanggan", SqlDbType.Int).Value = txtIdPelanggan.Text
        comm.Parameters.Add("@id_karyawan", SqlDbType.Int).Value = txtIdKaryawan.Text
        comm.Parameters.Add("@tgl_pinjam", SqlDbType.DateTime).Value = txtTanggalPinjam.Text
        comm.Parameters.Add("@tgl_kembali", SqlDbType.DateTime).Value = txtTanggalKembali.Text
        'comm.Parameters.Add("@harga", SqlDbType.Char, 20).Value = txtHargaSewa.Text
        comm.Parameters.Add("@tot_bayar", SqlDbType.Int).Value = txtTotalBayar.Text
        comm.Parameters.Add("@kembalian", SqlDbType.Int).Value = lblKembalian.Text
        comm.Parameters.Add("@denda", SqlDbType.Int).Value = txtDenda.Text
        comm.Parameters.Add("@id_mobil", SqlDbType.Int).Value = txtIdMobil.Text

        'comm.Parameters.Add("@hasil", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output

        comm.ExecuteNonQuery()
        MsgBox("Data Pelanggan Tersimpan")
        dgvrefresh()
        tampilTabel()
        conn.Close()
        bersih()
    End Sub

    Sub dgvrefresh()
        DataGridView1.RefreshEdit()
    End Sub

    'Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
    '    Cari()
    'End Sub

    'check data/ pencarian data
    'Sub Cari()
    '    conn.Open()

    '    'Insert data
    '    comm = New SqlCommand()
    '    comm.Connection = conn
    '    comm.CommandType = CommandType.Text
    '    comm.CommandText = _
    '    "SELECT * FROM mobil WHERE id_mobil = '" & txtCheck.Text & "'"


    '    Dim reader As SqlDataReader
    '    reader = comm.ExecuteReader

    '    If reader.HasRows = True Then

    '        'tampilkan
    '        While reader.Read
    '            txtIdSewa.Text = reader(0)
    '            txtIdPelanggan.Text = reader(1)
    '            txtIdKaryawan.Text = reader(2)
    '            txtTanggalPinjam.Text = reader(3)
    '            txtTanggalKembali.Text = reader(4)
    '            txtTotalBayar.Text = reader(5)
    '            txtDenda.Text = reader(6)
    '            lblKembalian.Text = reader(7)
    '        End While
    '    Else
    '        MsgBox("Data Tidak Ditemukan")
    '    End If

    '    conn.Close()
    'End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        conn.Open()
        Dim commDelete As New SqlCommand
        commDelete.Connection = conn
        commDelete.CommandText = "DELETE FROM sewa WHERE id_sewa = '" & txtIdSewa.Text & "'"
        commDelete.ExecuteNonQuery()
        If MessageBox.Show("Apakah Anda Yakin ?", "Ingin Menghapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then

        End If
        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
        bersih()
        tampilTabel()
        txtIdSewa.Focus()
        conn.Close()

        'conn.Open()
        'Dim commDelete As New SqlCommand
        'commDelete.Connection = conn
        'commDelete.CommandText = "DELETE FROM karyawan WHERE id_karyawan = '" & txtIdKaryawan.Text & "'"
        'commDelete.ExecuteReader()
        'dgvrefresh()
        'tampilTabel()
        'conn.Close()

        'MessageBox.Show("Sebagian Data Berhasil Dihapus")
        'bersih()
    End Sub

    'Private Sub ubah()
    '    DataGridView1.SelectedRows(0).Cells(0).Value = txtIdMobil.Text
    '    DataGridView1.SelectedRows(0).Cells(1).Value = txtIdSewa.Text
    '    DataGridView1.SelectedRows(0).Cells(2).Value = txtIdPelanggan.Text
    '    DataGridView1.SelectedRows(0).Cells(3).Value = txtIdKaryawan.Text
    '    DataGridView1.SelectedRows(0).Cells(4).Value = txtTanggalPinjam.Text
    '    DataGridView1.SelectedRows(0).Cells(5).Value = txtTanggalKembali.Text
    '    DataGridView1.SelectedRows(0).Cells(6).Value = txtTotalBayar.Text
    '    DataGridView1.SelectedRows(0).Cells(7).Value = txtDenda.Text
    '    DataGridView1.SelectedRows(0).Cells(8).Value = txtHargaSewa.Text
    '    DataGridView1.SelectedRows(0).Cells(9).Value = lblKembalian.Text

    '    If MessageBox.Show("Apakah Anda Yakin ?", "Ingin Mengubah", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
    '        conn.Open()
    '        Dim commUpdate As New SqlCommand
    '        commUpdate.Connection = conn
    '        commUpdate.CommandText = "UPDATE sewa SET id_sewa = '" & txtIdSewa.Text & "', id_pelanggan = '" & txtIdPelanggan.Text & "', id_karyawan = '" & txtIdKaryawan.Text & "', tgl_pinjam = '" & txtTanggalPinjam.Text & "', tgl_kembali = '" & txtTanggalKembali.Text & "', tot_bayar = '" & txtTotalBayar.Text & "', denda = '" & txtDenda.Text & "', kembalian = '" & lblKembalian.Text & "' WHERE id_sewa = '" & txtIdSewa.Text & "'"
    '        'comm.CommandText = code
    '        commUpdate.ExecuteNonQuery()
    '        conn.Close()
    '    End If
    'End Sub

    'Private Sub btnUbah_Click(sender As Object, e As EventArgs)
    '    ubah()
    'End Sub


    Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        Dim id_sewa As String = DataGridView1.SelectedRows(0).Cells(0).Value
        Dim id_mobil As String = DataGridView1.SelectedRows(0).Cells(1).Value
        Dim pelanggan As String = DataGridView1.SelectedRows(0).Cells(2).Value
        Dim karyawan As String = DataGridView1.SelectedRows(0).Cells(3).Value
        Dim tglPinjam As String = DataGridView1.SelectedRows(0).Cells(4).Value
        Dim tglKembali As String = DataGridView1.SelectedRows(0).Cells(5).Value
        Dim harga As String = DataGridView1.SelectedRows(0).Cells(6).Value
        Dim totalBayar As String = DataGridView1.SelectedRows(0).Cells(7).Value
        Dim kembali As String = DataGridView1.SelectedRows(0).Cells(8).Value
        Dim denda As String = DataGridView1.SelectedRows(0).Cells(9).Value

        txtIdMobil.Text = id_mobil
        txtIdSewa.Text = id_sewa
        txtIdPelanggan.Text = pelanggan
        txtIdKaryawan.Text = karyawan
        txtTanggalPinjam.Text = tglPinjam
        txtTanggalKembali.Text = tglKembali
        txtHargaSewa.Text = harga
        txtTotalBayar.Text = totalBayar
        lblKembalian.Text = kembali
        txtDenda.Text = denda
    End Sub


    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click
        If (Integer.Parse(txtTotalBayar.Text) - Integer.Parse(txtHargaSewa.Text) < 0) Then
            MessageBox.Show("Pembayaran Kurang")
            'tbBayar.Text = ""
            'total = ""
        Else
            lblKembalian.Text = Integer.Parse(txtTotalBayar.Text) - Integer.Parse(txtHargaSewa.Text)
            'MessageBox.Show("Total transaksi : Rp." & tbTotal.Text & " " & vbCrLf & "Total Bayar      : Rp." & tbBayar.Text & " " & vbCrLf & "Kembalian       : Rp." & tbKembalian.Text & "")
            'btnSelesai.Enabled = True
        End If
    End Sub

    Sub tbdenda()
        txtDenda.Enabled = False
    End Sub

    Sub idmobil()
        conn.Open()
        Dim commCek As New SqlCommand
        commCek.Connection = conn
        commCek.CommandText = "SELECT max(id_mobil) FROM mobil"
        Dim eksekusi As Object = commCek.ExecuteScalar()
        If (eksekusi Is Nothing) Then
            txtIdMobil.Text = "100"
        Else
            Dim ID As Integer = eksekusi + 1
            txtIdMobil.Text = ID
        End If
        conn.Close()
    End Sub


    Sub idsewa()
        conn.Open()
        Dim commCek As New SqlCommand
        commCek.Connection = conn
        commCek.CommandText = "SELECT max(id_sewa) FROM sewa"
        Dim eksekusi As Object = commCek.ExecuteScalar()
        If (eksekusi Is Nothing) Then
            txtIdSewa.Text = "100"
        Else
            Dim ID As Integer = eksekusi + 1
            txtIdSewa.Text = ID
        End If
        conn.Close()
    End Sub

    Sub idpelanggan()
        conn.Open()
        Dim commCek As New SqlCommand
        commCek.Connection = conn
        commCek.CommandText = "SELECT max(id_pelanggan) FROM pelanggan"
        Dim eksekusi As Object = commCek.ExecuteScalar()
        If (eksekusi Is Nothing) Then
            txtIdPelanggan.Text = "100"
        Else
            Dim ID As Integer = eksekusi + 1
            txtIdPelanggan.Text = ID
        End If
        conn.Close()
    End Sub

    Sub idkaryawan()
        conn.Open()
        Dim commCek As New SqlCommand
        commCek.Connection = conn
        commCek.CommandText = "SELECT max(id_karyawan) FROM karyawan"
        Dim eksekusi As Object = commCek.ExecuteScalar()
        If (eksekusi Is Nothing) Then
            txtIdKaryawan.Text = "100"
        Else
            Dim ID As Integer = eksekusi + 1
            txtIdKaryawan.Text = ID
        End If
        conn.Close()
    End Sub


    Private Sub btnPengembalian_Click(sender As Object, e As EventArgs) Handles btnPengembalian.Click
        'Dim hari As Long = DateDiff(DateInterval.Day, txtTanggalPinjam, txtTanggalKembali)
        Dim tglkembali As Date = Format(Now, "yyyy-MM-dd HH:mm:ss")
        If (tglkembali < txtTanggalKembali.Text) Then
            txtDenda.Text = "0"
        Else
            Dim selisih As Integer = DateDiff(DateInterval.Day, Convert.ToDateTime(txtTanggalKembali.Text), tglkembali)
            Dim denda As Integer = selisih * 100000
            txtDenda.Text = denda
            conn.Open()
            comm = New SqlCommand("dbo.updatedenda", conn)
            comm.CommandType = CommandType.StoredProcedure
            comm.Parameters.Add("@id_sewa", SqlDbType.Int).Value = Integer.Parse(txtIdSewa.Text)
            comm.Parameters.Add("@denda", SqlDbType.Int).Value = Integer.Parse(txtDenda.Text)
            comm.ExecuteNonQuery()
            conn.Close()
            tampilTabel()
        End If
    End Sub
End Class