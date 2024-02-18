<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formkembaliapd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formkembaliapd))
        Tnikkembali = New TextBox()
        Btutupkembali = New Button()
        Bkembalikan = New Button()
        Binsertkembali = New Button()
        Lblnamakembalibrg = New Label()
        Tkodekembalibrg = New TextBox()
        Label3 = New Label()
        Label7 = New Label()
        Kembalidgv = New DataGridView()
        Label6 = New Label()
        Lblareakembali = New Label()
        Label4 = New Label()
        Lbldeptkembali = New Label()
        Lblnamakembali = New Label()
        Tjumlahkembalibrg = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        Label5 = New Label()
        CType(Kembalidgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Tnikkembali
        ' 
        Tnikkembali.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tnikkembali.ForeColor = SystemColors.ActiveCaptionText
        Tnikkembali.Location = New Point(199, 28)
        Tnikkembali.Name = "Tnikkembali"
        Tnikkembali.Size = New Size(120, 30)
        Tnikkembali.TabIndex = 53
        ' 
        ' Btutupkembali
        ' 
        Btutupkembali.BackColor = SystemColors.Control
        Btutupkembali.Location = New Point(376, 467)
        Btutupkembali.Name = "Btutupkembali"
        Btutupkembali.Size = New Size(114, 43)
        Btutupkembali.TabIndex = 52
        Btutupkembali.Text = "Tutup"
        Btutupkembali.UseVisualStyleBackColor = False
        ' 
        ' Bkembalikan
        ' 
        Bkembalikan.BackColor = SystemColors.Control
        Bkembalikan.Location = New Point(160, 467)
        Bkembalikan.Name = "Bkembalikan"
        Bkembalikan.Size = New Size(114, 43)
        Bkembalikan.TabIndex = 51
        Bkembalikan.Text = "Kembalikan"
        Bkembalikan.UseVisualStyleBackColor = False
        ' 
        ' Binsertkembali
        ' 
        Binsertkembali.BackColor = SystemColors.Control
        Binsertkembali.Location = New Point(407, 150)
        Binsertkembali.Name = "Binsertkembali"
        Binsertkembali.Size = New Size(114, 43)
        Binsertkembali.TabIndex = 50
        Binsertkembali.Text = "Insert"
        Binsertkembali.UseVisualStyleBackColor = False
        ' 
        ' Lblnamakembalibrg
        ' 
        Lblnamakembalibrg.AutoSize = True
        Lblnamakembalibrg.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lblnamakembalibrg.Location = New Point(490, 72)
        Lblnamakembalibrg.Name = "Lblnamakembalibrg"
        Lblnamakembalibrg.Size = New Size(130, 28)
        Lblnamakembalibrg.TabIndex = 49
        Lblnamakembalibrg.Text = "Nama Barang"
        ' 
        ' Tkodekembalibrg
        ' 
        Tkodekembalibrg.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tkodekembalibrg.ForeColor = SystemColors.ActiveCaptionText
        Tkodekembalibrg.Location = New Point(490, 32)
        Tkodekembalibrg.Name = "Tkodekembalibrg"
        Tkodekembalibrg.Size = New Size(120, 30)
        Tkodekembalibrg.TabIndex = 48
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(357, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 28)
        Label3.TabIndex = 47
        Label3.Text = "Nama Barang :"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.ForeColor = SystemColors.ActiveCaptionText
        Label7.Location = New Point(357, 30)
        Label7.Name = "Label7"
        Label7.Size = New Size(133, 28)
        Label7.TabIndex = 46
        Label7.Text = "Kode Barang :"
        ' 
        ' Kembalidgv
        ' 
        Kembalidgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Kembalidgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Kembalidgv.Location = New Point(66, 215)
        Kembalidgv.Name = "Kembalidgv"
        Kembalidgv.RowHeadersWidth = 51
        Kembalidgv.RowTemplate.Height = 29
        Kembalidgv.Size = New Size(544, 226)
        Kembalidgv.TabIndex = 45
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(66, 150)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 28)
        Label6.TabIndex = 44
        Label6.Text = "Area :"
        ' 
        ' Lblareakembali
        ' 
        Lblareakembali.AutoSize = True
        Lblareakembali.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lblareakembali.Location = New Point(199, 150)
        Lblareakembali.Name = "Lblareakembali"
        Lblareakembali.Size = New Size(52, 28)
        Lblareakembali.TabIndex = 43
        Lblareakembali.Text = "Area"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(66, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 28)
        Label4.TabIndex = 42
        Label4.Text = "Departement :"
        ' 
        ' Lbldeptkembali
        ' 
        Lbldeptkembali.AutoSize = True
        Lbldeptkembali.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbldeptkembali.Location = New Point(199, 110)
        Lbldeptkembali.Name = "Lbldeptkembali"
        Lbldeptkembali.Size = New Size(127, 28)
        Lbldeptkembali.TabIndex = 41
        Lbldeptkembali.Text = "Departement"
        ' 
        ' Lblnamakembali
        ' 
        Lblnamakembali.AutoSize = True
        Lblnamakembali.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lblnamakembali.Location = New Point(199, 68)
        Lblnamakembali.Name = "Lblnamakembali"
        Lblnamakembali.Size = New Size(153, 28)
        Lblnamakembali.TabIndex = 40
        Lblnamakembali.Text = "Nama Karyawan"
        ' 
        ' Tjumlahkembalibrg
        ' 
        Tjumlahkembalibrg.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tjumlahkembalibrg.ForeColor = SystemColors.ActiveCaptionText
        Tjumlahkembalibrg.Location = New Point(490, 114)
        Tjumlahkembalibrg.Name = "Tjumlahkembalibrg"
        Tjumlahkembalibrg.Size = New Size(120, 30)
        Tjumlahkembalibrg.TabIndex = 39
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(66, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 28)
        Label2.TabIndex = 38
        Label2.Text = "Nama :"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(66, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 28)
        Label1.TabIndex = 37
        Label1.Text = "NIK :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(357, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 28)
        Label5.TabIndex = 36
        Label5.Text = "Jumlah "
        ' 
        ' Formkembaliapd
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(677, 536)
        Controls.Add(Tnikkembali)
        Controls.Add(Btutupkembali)
        Controls.Add(Bkembalikan)
        Controls.Add(Binsertkembali)
        Controls.Add(Lblnamakembalibrg)
        Controls.Add(Tkodekembalibrg)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(Kembalidgv)
        Controls.Add(Label6)
        Controls.Add(Lblareakembali)
        Controls.Add(Label4)
        Controls.Add(Lbldeptkembali)
        Controls.Add(Lblnamakembali)
        Controls.Add(Tjumlahkembalibrg)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Name = "Formkembaliapd"
        Text = "Form Kembalikan APD"
        CType(Kembalidgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tnikkembali As TextBox
    Friend WithEvents Btutupkembali As Button
    Friend WithEvents Bkembalikan As Button
    Friend WithEvents Binsertkembali As Button
    Friend WithEvents Lblnamakembalibrg As Label
    Friend WithEvents Tkodekembalibrg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Kembalidgv As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Lblareakembali As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Lbldeptkembali As Label
    Friend WithEvents Lblnamakembali As Label
    Friend WithEvents Tjumlahkembalibrg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
End Class
