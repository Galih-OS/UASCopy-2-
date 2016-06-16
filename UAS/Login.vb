Imports System.Data.SqlClient
Public Class Login

    Public logged As String
    Public loggedUser As String
    Public loggedID As String
    Dim conn As New SqlConnection("server= GALIH-OS\GALIHOS; database=RentalMobil; integrated security=true") 'koneksi database'
    Dim commCek As New SqlCommand
    Dim reader As SqlDataReader

    'cek koneksi
    Sub cekKonesi()
        Try
            conn.Open()
        Catch
            MsgBox("Database Not Connected !", MsgBoxStyle.Exclamation, "Error, Please Check")
        End Try
        conn.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cekKonesi()
        conn.Open()
        txtPassword.PasswordChar = "*"
    End Sub

    Private Sub btnMasuk_Click(sender As Object, e As EventArgs) Handles btnMasuk.Click
        commCek.Connection = conn
        commCek.CommandText = "SELECT id_karyawan, nama_karyawan FROM karyawan WHERE id_karyawan='" & txtIdKaryawan.Text & "' and pass='" & txtPassword.Text & "'"
        reader = commCek.ExecuteReader()
        If reader.Read Then
            If reader(0).ToString = "Admin" Then
                MessageBox.Show("Login berhasil, anda login sebagai : " & reader(0).ToString & "")
                loggedUser = txtIdKaryawan.Text
                loggedID = reader(0).ToString
                logged = reader(1).ToString
                bersih()
                RentalMobil.Show()
                Me.Hide()
            Else
                MessageBox.Show("Login berhasil, anda login sebagai : " & reader(1).ToString & "")
                loggedUser = txtIdKaryawan.Text
                loggedID = reader(0).ToString
                logged = reader(1).ToString
                bersih()
                RentalMobil.Show()
                Me.Hide()
            End If
        Else
            MessageBox.Show("Login gagal")
            bersih()
            txtIdKaryawan.Focus()
        End If
        reader.Close()
    End Sub

    'clear form apssword

    Sub bersih()
        txtIdKaryawan.Text = ""
        txtPassword.Text = ""
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Me.Close()
    End Sub
End Class
