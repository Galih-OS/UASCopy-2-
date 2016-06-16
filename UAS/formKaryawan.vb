Imports System.Data.SqlClient
Public Class formKaryawan

    Dim conn As New SqlConnection("server= GALIH-OS\GALIHOS; database=RentalMobil; integrated security=true") 'koneksi database'
    Dim comm As SqlCommand 'command'
    Dim dr As SqlDataReader 'membaca tabel lebih dari satu nilai'
    Dim cb As SqlCommandBuilder
    Dim da As SqlDataAdapter
    Dim ds As DataSet
    Dim code As String
    Dim dsMobil As New DataSet("dsMobil")
    Dim dtKaryawan As New DataTable("dtKaryawan")

    Private Sub formKaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CreateDataAdapter()
        tampilTabel()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        bersih()
    End Sub

    Sub CreateDataAdapter()
        dsMobil.Clear()
        da = New SqlDataAdapter("select * from dbo.tampilKaryawan()", conn)
        cb = New SqlCommandBuilder(da)
        da.FillSchema(dsMobil, SchemaType.Mapped, "dtKaryawan")
        da.Fill(dsMobil, "dtKaryawan")
        da.Dispose()
    End Sub

    Sub tampilTabel()
        CreateDataAdapter()
        DataGridView1.DataSource = dsMobil
        DataGridView1.DataMember = "dtKaryawan"
        With DataGridView1
            .Columns(0).HeaderText = "ID Karyawan"
            .Columns(1).HeaderText = "Nama Karyawan"
            .Columns(2).HeaderText = "Alamat Karyawan"
            .Columns(3).HeaderText = "Jk Kelamin"
            .Columns(4).HeaderText = "No. Telp"
            .Columns(5).HeaderText = "Passoword"
            .Columns(0).Width = 100
            .Columns(1).Width = 200
            .Columns(2).Width = 100
            .Columns(3).Width = 150
            .Columns(4).Width = 120
            .Columns(5).Width = 100
        End With
    End Sub

    'Clear Data'
    Sub bersih()
        txtIdKaryawan.Text = ""
        txtNamaKaryawan.Text = ""
        txtAlamatKaryawan.Text = ""
        txtJenisKelamin.Text = ""
        txtNoTelp.Text = ""
        txtPass.Text = ""
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        conn.Open()
        comm = New SqlCommand("dbo.simpanKaryawan", conn)
        'dr = comm.ExecuteReader
        comm.CommandType = CommandType.StoredProcedure
        comm.Parameters.Add("@id_karyawan", SqlDbType.Int).Value = txtIdKaryawan.Text
        comm.Parameters.Add("@nama_karyawan", SqlDbType.VarChar, 50).Value = txtNamaKaryawan.Text
        comm.Parameters.Add("@alamat_karyawan", SqlDbType.VarChar, 50).Value = txtAlamatKaryawan.Text
        comm.Parameters.Add("@jk_karyawan", SqlDbType.Char, 1).Value = txtJenisKelamin.Text
        comm.Parameters.Add("@no_telp_karyawan", SqlDbType.Char, 13).Value = txtNoTelp.Text
        comm.Parameters.Add("@pass", SqlDbType.VarChar, 6).Value = txtPass.Text()

        'comm.Parameters.Add("@hasil", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output

        comm.ExecuteNonQuery()
        MsgBox("Data Karyawan Tersimpan")
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
        "SELECT * FROM karyawan WHERE id_karyawan = '" & txtCheck.Text & "'"


        Dim reader As SqlDataReader
        reader = comm.ExecuteReader

        If reader.HasRows = True Then

            'tampilkan
            While reader.Read
                txtIdKaryawan.Text = reader(0)
                txtNamaKaryawan.Text = reader(1)
                txtAlamatKaryawan.Text = reader(2)
                txtJenisKelamin.Text = reader(3)
                txtNoTelp.Text = reader(4)
                txtPass.Text = reader(5)
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
            commDelete.CommandText = "DELETE FROM karyawan WHERE id_karyawan = '" & txtIdKaryawan.Text & "'"
        commDelete.ExecuteNonQuery()
        If MessageBox.Show("Apakah Anda Yakin ?", "Ingin Menghapus", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then

        End If
        DataGridView1.Rows.RemoveAt(DataGridView1.SelectedRows(0).Index)
        bersih()
        tampilTabel()
        txtIdKaryawan.Focus()
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
        DataGridView1.SelectedRows(0).Cells(0).Value = txtIdKaryawan.Text
        DataGridView1.SelectedRows(0).Cells(1).Value = txtNamaKaryawan.Text
        DataGridView1.SelectedRows(0).Cells(2).Value = txtAlamatKaryawan.Text
        DataGridView1.SelectedRows(0).Cells(3).Value = txtJenisKelamin.Text
        DataGridView1.SelectedRows(0).Cells(4).Value = txtNoTelp.Text
        DataGridView1.SelectedRows(0).Cells(5).Value = txtPass.Text
        If MessageBox.Show("Apakah Anda Yakin ?", "Ingin Mengubah", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.OK Then
            conn.Open()
            Dim commUpdate As New SqlCommand
            commUpdate.Connection = conn
            commUpdate.CommandText = "UPDATE karyawan SET id_karyawan = '" & txtIdKaryawan.Text & "', nama_karyawan = '" & txtNamaKaryawan.Text & "', alamat_karyawan = '" & txtAlamatKaryawan.Text & "', jk_karyawan = '" & txtJenisKelamin.Text & "', no_telp_karyawan = '" & txtNoTelp.Text & "', pass = '" & txtPass.Text & "' WHERE id_karyawan = '" & txtIdKaryawan.Text & "'"
            'comm.CommandText = code
            commUpdate.ExecuteNonQuery()
            conn.Close()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ubah()

        txtIdKaryawan.Text = ""
        txtNamaKaryawan.Text = ""
        txtAlamatKaryawan.Text = ""
        txtJenisKelamin.Text = ""
        txtNoTelp.Text = ""
        txtPass.Text = ""

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
        Dim Pass As String = DataGridView1.SelectedRows(0).Cells(5).Value

        txtIdKaryawan.Text = ID_Karyawan
        txtNamaKaryawan.Text = nama
        txtAlamatKaryawan.Text = Alamat
        txtJenisKelamin.Text = JK_kelamin
        txtNoTelp.Text = NoTelp
        txtPass.Text = Pass

    End Sub

    'Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
    '    Try
    '        Me.KARYAWANTableAdapter.FillBy(Me.RentalMobilDataSet.KARYAWAN)
    '    Catch ex As System.Exception
    '        System.Windows.Forms.MessageBox.Show(ex.Message)
    '    End Try

    'End Sub
End Class