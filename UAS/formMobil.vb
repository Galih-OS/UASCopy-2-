Imports System.Data.SqlClient
Public Class formMobil

    Dim conn As New SqlConnection("server= GALIH-OS\GALIHOS; database=RentalMobil; integrated security=true") 'koneksi database'
    Dim comm As SqlCommand 'command'
    Dim dr As SqlDataReader 'membaca tabel lebih dari satu nilai'
    Dim cb As SqlCommandBuilder
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim code As String
    Dim dsMobil As New DataSet("dsMobil")
    Dim dtKaryawan As New DataTable("dtMobil")

    Private Sub formMobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDataAdapter()
        tampilTabel()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        'box()
        bersih()
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
        da = New SqlDataAdapter("select * from dbo.tampilMobil()", conn)
        cb = New SqlCommandBuilder(da)
        da.FillSchema(dsMobil, SchemaType.Mapped, "dtMobil")
        da.Fill(dsMobil, "dtMobil")
        da.Dispose()
    End Sub

    Sub tampilTabel()
        CreateDataAdapter()
        DataGridView1.DataSource = dsMobil
        DataGridView1.DataMember = "dtMobil"
        With DataGridView1
            .Columns(0).HeaderText = "ID Mobil"
            .Columns(1).HeaderText = "No. Plat"
            .Columns(2).HeaderText = "Jenis"
            .Columns(3).HeaderText = "Merk"
            .Columns(4).HeaderText = "Tahun buat"
            .Columns(5).HeaderText = "Warna"
            .Columns(6).HeaderText = "Harga"
            .Columns(0).Width = 60
            .Columns(1).Width = 90
            .Columns(2).Width = 100
            .Columns(3).Width = 100
            .Columns(4).Width = 100
            .Columns(5).Width = 60
            .Columns(6).Width = 100
        End With
    End Sub

    'Clear Data'
    Sub bersih()
        txtIdMobil.Text = ""
        txtNoPlatMobil.Text = ""
        txtJenisMobil.Text = ""
        txtMerkMobil.Text = ""
        txtTahunMobil.Text = ""
        txtWarnaMobil.Text = ""
        txtHargaSewa.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        conn.Open()
        comm = New SqlCommand("dbo.simpanMobil", conn)
        'dr = comm.ExecuteReader
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@id_mobil", SqlDbType.Int).Value = txtIdMobil.Text
        comm.Parameters.Add("@no_plat", SqlDbType.Char, 20).Value = txtNoPlatMobil.Text
        comm.Parameters.Add("@jenis", SqlDbType.VarChar, 50).Value = txtJenisMobil.Text
        comm.Parameters.Add("@merk", SqlDbType.VarChar, 50).Value = txtMerkMobil.Text
        comm.Parameters.Add("@tahun", SqlDbType.DateTime).Value = txtTahunMobil.Text
        comm.Parameters.Add("@warna", SqlDbType.VarChar, 50).Value = txtWarnaMobil.Text
        comm.Parameters.Add("@harga", SqlDbType.Char, 20).Value = txtHargaSewa.Text


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

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Cari()
    End Sub

    'check data/ pencarian data
    Sub Cari()
        conn.Open()

        'Insert data
        comm = New SqlCommand()
        comm.Connection = conn
        comm.CommandType = CommandType.Text
        comm.CommandText = _
        "SELECT * FROM mobil WHERE id_mobil = '" & txtCheck.Text & "'"


        Dim reader As SqlDataReader
        reader = comm.ExecuteReader

        If reader.HasRows = True Then

            'tampilkan
            While reader.Read
                txtIdMobil.Text = reader(0)
                txtNoPlatMobil.Text = reader(1)
                txtJenisMobil.Text = reader(2)
                txtMerkMobil.Text = reader(3)
                txtTahunMobil.Text = reader(4)
                txtWarnaMobil.Text = reader(5)
                txtHargaSewa.Text = reader(6)
            End While
        Else
            MsgBox("Data Tidak Ditemukan")
        End If

        conn.Close()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        conn.Open()
        Dim commDelete As New SqlCommand
        commDelete.Connection = conn
        commDelete.CommandText = "DELETE FROM mobil WHERE id_mobil = '" & txtIdMobil.Text & "'"
        commDelete.ExecuteNonQuery()
        If MessageBox.Show("Apakah Anda Yakin ?", "Ingin Menghapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then

        End If
        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
        bersih()
        tampilTabel()
        txtIdMobil.Focus()
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

    Private Sub ubah()
        DataGridView1.SelectedRows(0).Cells(0).Value = txtIdMobil.Text
        DataGridView1.SelectedRows(0).Cells(1).Value = txtNoPlatMobil.Text
        DataGridView1.SelectedRows(0).Cells(2).Value = txtJenisMobil.Text
        DataGridView1.SelectedRows(0).Cells(3).Value = txtMerkMobil.Text
        DataGridView1.SelectedRows(0).Cells(4).Value = txtTahunMobil.Text
        DataGridView1.SelectedRows(0).Cells(5).Value = txtWarnaMobil.Text
        DataGridView1.SelectedRows(0).Cells(6).Value = txtHargaSewa.Text
        If MessageBox.Show("Apakah Anda Yakin ?", "Ingin Mengubah", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            conn.Open()
            Dim commUpdate As New SqlCommand
            commUpdate.Connection = conn
            commUpdate.CommandText = "UPDATE pelanggan SET id_pelanggan = '" & txtIdMobil.Text & "', no_plat = '" & txtNoPlatMobil.Text & "', jenis = '" & txtJenisMobil.Text & "', merk = '" & txtMerkMobil.Text & "', thn_buat = '" & txtTahunMobil.Text & "', warna = '" & txtWarnaMobil.Text & "', harga = '" & txtHargaSewa.Text & "' WHERE id_mobil = '" & txtIdMobil.Text & "'"
            'comm.CommandText = code
            commUpdate.ExecuteNonQuery()
            conn.Close()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ubah()
    End Sub


    Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        Dim id_mobil As String = DataGridView1.SelectedRows(0).Cells(0).Value
        'Dim id_sewa As String = DataGridView1.SelectedRows(0).Cells(1).Value
        Dim no_plat As String = DataGridView1.SelectedRows(0).Cells(1).Value
        Dim jenis_mobil As String = DataGridView1.SelectedRows(0).Cells(2).Value
        Dim merk As String = DataGridView1.SelectedRows(0).Cells(3).Value
        Dim tahun As String = DataGridView1.SelectedRows(0).Cells(4).Value
        Dim warna As String = DataGridView1.SelectedRows(0).Cells(5).Value
        Dim sewa As String = DataGridView1.SelectedRows(0).Cells(6).Value

        txtIdMobil.Text = id_mobil
        'txtIdSewa.Text = id_sewa
        txtNoPlatMobil.Text = no_plat
        txtJenisMobil.Text = jenis_mobil
        txtMerkMobil.Text = merk
        txtTahunMobil.Text = tahun
        txtWarnaMobil.Text = warna
        txtHargaSewa.Text = sewa
    End Sub

    'Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.KARYAWANTableAdapter.FillBy(Me.RentalMobilDataSet.KARYAWAN)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class