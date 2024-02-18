<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formmenuutama
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formmenuutama))
        PictureBox1 = New PictureBox()
        Bpengambilan = New Button()
        Bpengembalian = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        HomeToolStripMenuItem = New ToolStripMenuItem()
        PetugasToolStripMenuItem = New ToolStripMenuItem()
        KaryawanToolStripMenuItem = New ToolStripMenuItem()
        LogoutToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1 = New MenuStrip()
        DataToolStripMenuItem = New ToolStripMenuItem()
        DataAPDToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Zoom
        PictureBox1.Location = New Point(334, 85)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(157, 170)
        PictureBox1.TabIndex = 1
        PictureBox1.TabStop = False
        ' 
        ' Bpengambilan
        ' 
        Bpengambilan.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Bpengambilan.Location = New Point(78, 404)
        Bpengambilan.Name = "Bpengambilan"
        Bpengambilan.Size = New Size(211, 97)
        Bpengambilan.TabIndex = 2
        Bpengambilan.Text = "Ambil APD"
        Bpengambilan.UseVisualStyleBackColor = True
        ' 
        ' Bpengembalian
        ' 
        Bpengembalian.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Bpengembalian.Location = New Point(553, 404)
        Bpengembalian.Name = "Bpengembalian"
        Bpengembalian.Size = New Size(211, 89)
        Bpengembalian.TabIndex = 3
        Bpengembalian.Text = "Kembalikan APD"
        Bpengembalian.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(202, 281)
        Label1.Name = "Label1"
        Label1.Size = New Size(444, 46)
        Label1.TabIndex = 4
        Label1.Text = "Aplikasi Pengambilan APD"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(12, 366)
        Label2.Name = "Label2"
        Label2.Size = New Size(361, 20)
        Label2.TabIndex = 8
        Label2.Text = "Klik Tombol Dibawah Ini Jika Ingin Mengambil APD"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(447, 366)
        Label3.Name = "Label3"
        Label3.Size = New Size(395, 20)
        Label3.TabIndex = 9
        Label3.Text = "Klik Tombol Dibawah Ini Jika Ingin Mengembalikan APD"
        ' 
        ' HomeToolStripMenuItem
        ' 
        HomeToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {PetugasToolStripMenuItem, KaryawanToolStripMenuItem})
        HomeToolStripMenuItem.Name = "HomeToolStripMenuItem"
        HomeToolStripMenuItem.Size = New Size(68, 24)
        HomeToolStripMenuItem.Text = "Master"
        ' 
        ' PetugasToolStripMenuItem
        ' 
        PetugasToolStripMenuItem.Name = "PetugasToolStripMenuItem"
        PetugasToolStripMenuItem.Size = New Size(156, 26)
        PetugasToolStripMenuItem.Text = "Petugas"
        ' 
        ' KaryawanToolStripMenuItem
        ' 
        KaryawanToolStripMenuItem.Name = "KaryawanToolStripMenuItem"
        KaryawanToolStripMenuItem.Size = New Size(156, 26)
        KaryawanToolStripMenuItem.Text = "Karyawan"
        ' 
        ' LogoutToolStripMenuItem
        ' 
        LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        LogoutToolStripMenuItem.Size = New Size(70, 24)
        LogoutToolStripMenuItem.Text = "Logout"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {HomeToolStripMenuItem, DataToolStripMenuItem, LogoutToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(854, 28)
        MenuStrip1.TabIndex = 7
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' DataToolStripMenuItem
        ' 
        DataToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {DataAPDToolStripMenuItem})
        DataToolStripMenuItem.Name = "DataToolStripMenuItem"
        DataToolStripMenuItem.Size = New Size(55, 24)
        DataToolStripMenuItem.Text = "Data"
        ' 
        ' DataAPDToolStripMenuItem
        ' 
        DataAPDToolStripMenuItem.Name = "DataAPDToolStripMenuItem"
        DataAPDToolStripMenuItem.Size = New Size(224, 26)
        DataAPDToolStripMenuItem.Text = "Stock APD"
        ' 
        ' Formmenuutama
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(854, 543)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Bpengembalian)
        Controls.Add(Bpengambilan)
        Controls.Add(PictureBox1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Formmenuutama"
        Text = "Aplikasi Pengambilan APD"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Bpengambilan As Button
    Friend WithEvents Bpengembalian As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents HomeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PetugasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KaryawanToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataAPDToolStripMenuItem As ToolStripMenuItem
End Class
