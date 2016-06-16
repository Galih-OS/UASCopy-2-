<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentalMobil
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.KaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormKaryawanToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormPelangganToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormSewaMobilToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KaryawanToolStripMenuItem, Me.PelangganToolStripMenuItem, Me.ListMobilToolStripMenuItem, Me.LogOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1350, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'KaryawanToolStripMenuItem
        '
        Me.KaryawanToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormKaryawanToolStripMenuItem})
        Me.KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        Me.KaryawanToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.KaryawanToolStripMenuItem.Text = "Karyawan"
        '
        'FormKaryawanToolStripMenuItem
        '
        Me.FormKaryawanToolStripMenuItem.Name = "FormKaryawanToolStripMenuItem"
        Me.FormKaryawanToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.FormKaryawanToolStripMenuItem.Text = "formKaryawan"
        '
        'PelangganToolStripMenuItem
        '
        Me.PelangganToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormPelangganToolStripMenuItem})
        Me.PelangganToolStripMenuItem.Name = "PelangganToolStripMenuItem"
        Me.PelangganToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.PelangganToolStripMenuItem.Text = "Pelanggan"
        '
        'FormPelangganToolStripMenuItem
        '
        Me.FormPelangganToolStripMenuItem.Name = "FormPelangganToolStripMenuItem"
        Me.FormPelangganToolStripMenuItem.Size = New System.Drawing.Size(156, 22)
        Me.FormPelangganToolStripMenuItem.Text = "formPelanggan"
        '
        'ListMobilToolStripMenuItem
        '
        Me.ListMobilToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FormMobilToolStripMenuItem, Me.FormSewaMobilToolStripMenuItem})
        Me.ListMobilToolStripMenuItem.Name = "ListMobilToolStripMenuItem"
        Me.ListMobilToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ListMobilToolStripMenuItem.Text = "Mobil"
        '
        'FormMobilToolStripMenuItem
        '
        Me.FormMobilToolStripMenuItem.Name = "FormMobilToolStripMenuItem"
        Me.FormMobilToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.FormMobilToolStripMenuItem.Text = "formMobil"
        '
        'FormSewaMobilToolStripMenuItem
        '
        Me.FormSewaMobilToolStripMenuItem.Name = "FormSewaMobilToolStripMenuItem"
        Me.FormSewaMobilToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.FormSewaMobilToolStripMenuItem.Text = "formSewaMobil"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.LogOutToolStripMenuItem.Text = "LogOut"
        '
        'RentalMobil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1350, 729)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RentalMobil"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Rental Mobil Execute"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents KaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormKaryawanToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormPelangganToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ListMobilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormMobilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FormSewaMobilToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
