Public Class RentalMobil

    Private Sub RentalMobil_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FormKaryawanToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FormKaryawanToolStripMenuItem.Click
        formKaryawan.Show()
        formPelanggan.Close()
        formMobil.Close()
        formSewaMobil.Close()
        formKaryawan.MdiParent = Me
    End Sub

    Private Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub FormPelangganToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormPelangganToolStripMenuItem.Click
        formPelanggan.Show()
        formKaryawan.Close()
        formMobil.Close()
        formSewaMobil.Close()
        formPelanggan.MdiParent = Me
    End Sub

    Private Sub FormMobilToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListMobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListMobilToolStripMenuItem.Click

    End Sub

    Private Sub FormMobilToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles FormMobilToolStripMenuItem.Click
        formMobil.Show()
        formKaryawan.Close()
        formPelanggan.Close()
        formSewaMobil.Close()
        formMobil.MdiParent = Me
    End Sub

    Private Sub FormSewaMobilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormSewaMobilToolStripMenuItem.Click
        formSewaMobil.Show()
        formKaryawan.Close()
        formPelanggan.Close()
        formMobil.Close()
        formSewaMobil.MdiParent = Me
    End Sub
End Class
