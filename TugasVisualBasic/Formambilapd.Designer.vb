<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formambilapd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formambilapd))
        Tjumlahbrg = New TextBox()
        Label2 = New Label()
        Label5 = New Label()
        Lblnama = New Label()
        Lbldept = New Label()
        Label4 = New Label()
        Label6 = New Label()
        Lblarea = New Label()
        Ambildgv = New DataGridView()
        Lblnamabrg = New Label()
        Tkodeambilbrg = New TextBox()
        Label3 = New Label()
        Label7 = New Label()
        Binsertambil = New Button()
        Bsimpanambil = New Button()
        Btutupambil = New Button()
        Tnikambil = New TextBox()
        Label1 = New Label()
        CType(Ambildgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Tjumlahbrg
        ' 
        Tjumlahbrg.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tjumlahbrg.ForeColor = SystemColors.ActiveCaptionText
        Tjumlahbrg.Location = New Point(490, 114)
        Tjumlahbrg.Name = "Tjumlahbrg"
        Tjumlahbrg.Size = New Size(120, 30)
        Tjumlahbrg.TabIndex = 23
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(66, 68)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 28)
        Label2.TabIndex = 22
        Label2.Text = "Nama :"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(357, 112)
        Label5.Name = "Label5"
        Label5.Size = New Size(78, 28)
        Label5.TabIndex = 21
        Label5.Text = "Jumlah "
        ' 
        ' Lblnama
        ' 
        Lblnama.AutoSize = True
        Lblnama.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lblnama.Location = New Point(199, 68)
        Lblnama.Name = "Lblnama"
        Lblnama.Size = New Size(153, 28)
        Lblnama.TabIndex = 24
        Lblnama.Text = "Nama Karyawan"
        ' 
        ' Lbldept
        ' 
        Lbldept.AutoSize = True
        Lbldept.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lbldept.Location = New Point(199, 110)
        Lbldept.Name = "Lbldept"
        Lbldept.Size = New Size(127, 28)
        Lbldept.TabIndex = 25
        Lbldept.Text = "Departement"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(66, 110)
        Label4.Name = "Label4"
        Label4.Size = New Size(136, 28)
        Label4.TabIndex = 26
        Label4.Text = "Departement :"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.ForeColor = SystemColors.ActiveCaptionText
        Label6.Location = New Point(66, 150)
        Label6.Name = "Label6"
        Label6.Size = New Size(61, 28)
        Label6.TabIndex = 28
        Label6.Text = "Area :"
        ' 
        ' Lblarea
        ' 
        Lblarea.AutoSize = True
        Lblarea.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lblarea.Location = New Point(199, 150)
        Lblarea.Name = "Lblarea"
        Lblarea.Size = New Size(52, 28)
        Lblarea.TabIndex = 27
        Lblarea.Text = "Area"
        ' 
        ' Ambildgv
        ' 
        Ambildgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Ambildgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Ambildgv.Location = New Point(66, 215)
        Ambildgv.Name = "Ambildgv"
        Ambildgv.RowHeadersWidth = 51
        Ambildgv.RowTemplate.Height = 29
        Ambildgv.Size = New Size(544, 226)
        Ambildgv.TabIndex = 29
        ' 
        ' Lblnamabrg
        ' 
        Lblnamabrg.AutoSize = True
        Lblnamabrg.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Lblnamabrg.Location = New Point(490, 72)
        Lblnamabrg.Name = "Lblnamabrg"
        Lblnamabrg.Size = New Size(130, 28)
        Lblnamabrg.TabIndex = 33
        Lblnamabrg.Text = "Nama Barang"
        ' 
        ' Tkodeambilbrg
        ' 
        Tkodeambilbrg.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tkodeambilbrg.ForeColor = SystemColors.ActiveCaptionText
        Tkodeambilbrg.Location = New Point(490, 32)
        Tkodeambilbrg.Name = "Tkodeambilbrg"
        Tkodeambilbrg.Size = New Size(120, 30)
        Tkodeambilbrg.TabIndex = 32
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(357, 72)
        Label3.Name = "Label3"
        Label3.Size = New Size(139, 28)
        Label3.TabIndex = 31
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
        Label7.TabIndex = 30
        Label7.Text = "Kode Barang :"
        ' 
        ' Binsertambil
        ' 
        Binsertambil.BackColor = SystemColors.Control
        Binsertambil.Location = New Point(407, 150)
        Binsertambil.Name = "Binsertambil"
        Binsertambil.Size = New Size(114, 43)
        Binsertambil.TabIndex = 34
        Binsertambil.Text = "Insert"
        Binsertambil.UseVisualStyleBackColor = False
        ' 
        ' Bsimpanambil
        ' 
        Bsimpanambil.BackColor = SystemColors.Control
        Bsimpanambil.Location = New Point(160, 467)
        Bsimpanambil.Name = "Bsimpanambil"
        Bsimpanambil.Size = New Size(114, 43)
        Bsimpanambil.TabIndex = 34
        Bsimpanambil.Text = "Pinjam"
        Bsimpanambil.UseVisualStyleBackColor = False
        ' 
        ' Btutupambil
        ' 
        Btutupambil.BackColor = SystemColors.Control
        Btutupambil.Location = New Point(376, 467)
        Btutupambil.Name = "Btutupambil"
        Btutupambil.Size = New Size(114, 43)
        Btutupambil.TabIndex = 34
        Btutupambil.Text = "Tutup"
        Btutupambil.UseVisualStyleBackColor = False
        ' 
        ' Tnikambil
        ' 
        Tnikambil.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tnikambil.ForeColor = SystemColors.ActiveCaptionText
        Tnikambil.Location = New Point(199, 28)
        Tnikambil.Name = "Tnikambil"
        Tnikambil.Size = New Size(120, 30)
        Tnikambil.TabIndex = 35
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(66, 26)
        Label1.Name = "Label1"
        Label1.Size = New Size(53, 28)
        Label1.TabIndex = 21
        Label1.Text = "NIK :"
        ' 
        ' Formambilapd
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(677, 536)
        Controls.Add(Tnikambil)
        Controls.Add(Btutupambil)
        Controls.Add(Bsimpanambil)
        Controls.Add(Binsertambil)
        Controls.Add(Tkodeambilbrg)
        Controls.Add(Label3)
        Controls.Add(Label7)
        Controls.Add(Ambildgv)
        Controls.Add(Label6)
        Controls.Add(Lblarea)
        Controls.Add(Label4)
        Controls.Add(Lbldept)
        Controls.Add(Lblnama)
        Controls.Add(Tjumlahbrg)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Label5)
        Controls.Add(Lblnamabrg)
        Name = "Formambilapd"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Ambil APD"
        CType(Ambildgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Tjumlahbrg As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Lblnama As Label
    Friend WithEvents Lbldept As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Lblarea As Label
    Friend WithEvents Ambildgv As DataGridView
    Friend WithEvents Lblnamabrg As Label
    Friend WithEvents Tkodeambilbrg As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Binsertambil As Button
    Friend WithEvents Bsimpanambil As Button
    Friend WithEvents Btutupambil As Button
    Friend WithEvents Tnikambil As TextBox
    Friend WithEvents Label1 As Label
End Class
