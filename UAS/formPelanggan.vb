Imports System.Data.SqlClient
Public Class formPelanggan

    Dim conn As New SqlConnection("server= GALIH-OS\GALIHOS; database=RentalMobil; integrated security=true") 'koneksi database'
    Dim comm As SqlCommand 'command'
    Dim dr As SqlDataReader 'membaca tabel lebih dari satu nilai'
    Dim cb As SqlCommandBuilder
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim code As String
    Dim dsMobil As New DataSet("dsMobil")
    Dim dtKaryawan As New DataTable("dtPelanggan")

    Private Sub formPelanggan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDataAdapter()
        tampilTabel()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        bersih()
    End Sub

    Sub CreateDataAdapter()
        dsMobil.Clear()
        da = New SqlDataAdapter("select * from dbo.tampilPelanggan()", conn)
        cb = New SqlCommandBuilder(da)
        da.FillSchema(dsMobil, SchemaType.Mapped, "dtPelanggan")
        da.Fill(dsMobil, "dtPelanggan")
        da.Dispose()
    End Sub

    Sub tampilTabel()
        CreateDataAdapter()
        DataGridView1.DataSource = dsMobil
        DataGridView1.DataMember = "dtPelanggan"
        With DataGridView1
            .Columns(0).HeaderText = "ID Pelanggan"
            .Columns(1).HeaderText = "Nama Pelanggan"
            .Columns(2).HeaderText = "Alamat Pelanggan"
            .Columns(3).HeaderText = "Jk Kelamin"
            .Columns(4).HeaderText = "No. Telp"
            .Columns(0).Width = 100
            .Columns(1).Width = 100
            .Columns(2).Width = 100
            .Columns(3).Width = 100
            .Columns(4).Width = 100
        End With
    End Sub

    'Clear Data'
    Sub bersih()
        txtIdPelanggan.Text = ""
        txtNamaPelanggan.Text = ""
        txtAlamatPelanggan.Text = ""
        txtJenisKelamin.Text = ""
        txtNoTelp.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        conn.Open()
        comm = New SqlCommand("dbo.simpanPelanggan", conn)
        'dr = comm.ExecuteReader
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@id_pelanggan", SqlDbType.Int).Value = txtIdPelanggan.Text
        comm.Parameters.Add("@nama_pelanggan", SqlDbType.VarChar, 50).Value = txtNamaPelanggan.Text
        comm.Parameters.Add("@alamat_pelanggan", SqlDbType.VarChar, 50).Value = txtAlamatPelanggan.Text
        comm.Parameters.Add("@jk_pelanggan", SqlDbType.Char, 1).Value = txtJenisKelamin.Text
        comm.Parameters.Add("@no_telp_pelanggan", SqlDbType.Char, 13).Value = txtNoTelp.Text

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
        "SELECT * FROM pelanggan WHERE id_pelanggan = '" & txtCheck.Text & "'"


        Dim reader As SqlDataReader
        reader = comm.ExecuteReader

        If reader.HasRows = True Then

            'tampilkan
            While reader.Read
                txtIdPelanggan.Text = reader(0)
                txtNamaPelanggan.Text = reader(1)
                txtAlamatPelanggan.Text = reader(2)
                txtJenisKelamin.Text = reader(3)
                txtNoTelp.Text = reader(4)
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
        commDelete.CommandText = "DELETE FROM pelanggan WHERE id_pelanggan = '" & txtIdPelanggan.Text & "'"
        commDelete.ExecuteNonQuery()
        If MessageBox.Show("Apakah Anda Yakin ?", "Ingin Menghapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then

        End If
        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
        bersih()
        tampilTabel()
        txtIdPelanggan.Focus()
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
        DataGridView1.SelectedRows(0).Cells(0).Value = txtIdPelanggan.Text
        DataGridView1.SelectedRows(0).Cells(1).Value = txtNamaPelanggan.Text
        DataGridView1.SelectedRows(0).Cells(2).Value = txtAlamatPelanggan.Text
        DataGridView1.SelectedRows(0).Cells(3).Value = txtJenisKelamin.Text
        DataGridView1.SelectedRows(0).Cells(4).Value = txtNoTelp.Text
        If MessageBox.Show("Apakah Anda Yakin ?", "Ingin Mengubah", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            conn.Open()
            Dim commUpdate As New SqlCommand
            commUpdate.Connection = conn
            commUpdate.CommandText = "UPDATE pelanggan SET id_pelanggan = '" & txtIdPelanggan.Text & "', nama_pelanggan = '" & txtNamaPelanggan.Text & "', alamat_pelanggan = '" & txtAlamatPelanggan.Text & "', jk_pelanggan = '" & txtJenisKelamin.Text & "', no_telp_pelanggan = '" & txtNoTelp.Text & "' WHERE id_pelanggan = '" & txtIdPelanggan.Text & "'"
            'comm.CommandText = code
            commUpdate.ExecuteNonQuery()
            conn.Close()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ubah()

        txtIdPelanggan.Text = ""
        txtNamaPelanggan.Text = ""
        txtAlamatPelanggan.Text = ""
        txtJenisKelamin.Text = ""
        txtNoTelp.Text = ""

        'conn.Open()
        'Dim commUpdate As New SqlCommand
        'commUpdate.Connection = conn
        'commUpdate.CommandText = "UPDATE karyawan SET id_karyawan = '" & txtIdKaryawan.Text & "', nama_karyawan = '" & txtNamaKaryawan.Text & "', alamat_karyawan = '" & txtAlamatKaryawan.Text & "', jk_karyawan = '" & txtJenisKelamin.Text & "', no_telp_karyawan = '" & txtNoTelp.Text & "', pass = '" & txtPass.Text & "' WHERE id_karyawan = '" & txtIdKaryawan.Text & "'"
        'comm.CommandText = code
        'commUpdate.ExecuteNonQuery()
        'conn.Close()
        'MessageBox.Show("Data Berhasil Diperbaharui")
    End Sub


    Private Sub DataGridView1_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles DataGridView1.MouseClick
        Dim ID_Karyawan As String = DataGridView1.SelectedRows(0).Cells(0).Value
        Dim nama As String = DataGridView1.SelectedRows(0).Cells(1).Value
        Dim Alamat As String = DataGridView1.SelectedRows(0).Cells(2).Value
        Dim JK_kelamin As String = DataGridView1.SelectedRows(0).Cells(3).Value
        Dim NoTelp As String = DataGridView1.SelectedRows(0).Cells(4).Value

        txtIdPelanggan.Text = ID_Karyawan
        txtNamaPelanggan.Text = nama
        txtAlamatPelanggan.Text = Alamat
        txtJenisKelamin.Text = JK_kelamin
        txtNoTelp.Text = NoTelp
    End Sub

    'Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.KARYAWANTableAdapter.FillBy(Me.RentalMobilDataSet.KARYAWAN)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class