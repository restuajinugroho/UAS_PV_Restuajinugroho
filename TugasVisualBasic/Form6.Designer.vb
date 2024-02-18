<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formdataapd
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(formdataapd))
        Label5 = New Label()
        Label2 = New Label()
        Label4 = New Label()
        Tkodebrg = New TextBox()
        Tnamabrg = New TextBox()
        Cbsatuanbrg = New ComboBox()
        BarangDGV = New DataGridView()
        Bbackbrg = New Button()
        Bdeletebrg = New Button()
        Beditbrg = New Button()
        Bsavebrg = New Button()
        Bclearbrg = New Button()
        Tjumlahbrg = New TextBox()
        Label1 = New Label()
        CType(BarangDGV, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(88, 21)
        Label5.Name = "Label5"
        Label5.Size = New Size(58, 28)
        Label5.TabIndex = 16
        Label5.Text = "Kode"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(88, 63)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 17
        Label2.Text = "Nama"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(88, 157)
        Label4.Name = "Label4"
        Label4.Size = New Size(72, 28)
        Label4.TabIndex = 18
        Label4.Text = "Satuan"
        ' 
        ' Tkodebrg
        ' 
        Tkodebrg.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tkodebrg.ForeColor = SystemColors.ActiveCaptionText
        Tkodebrg.Location = New Point(224, 21)
        Tkodebrg.Name = "Tkodebrg"
        Tkodebrg.Size = New Size(260, 30)
        Tkodebrg.TabIndex = 19
        ' 
        ' Tnamabrg
        ' 
        Tnamabrg.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tnamabrg.ForeColor = SystemColors.ActiveCaptionText
        Tnamabrg.Location = New Point(224, 65)
        Tnamabrg.Name = "Tnamabrg"
        Tnamabrg.Size = New Size(260, 30)
        Tnamabrg.TabIndex = 20
        ' 
        ' Cbsatuanbrg
        ' 
        Cbsatuanbrg.FormattingEnabled = True
        Cbsatuanbrg.Items.AddRange(New Object() {"Pcs", "Box"})
        Cbsatuanbrg.Location = New Point(224, 161)
        Cbsatuanbrg.Name = "Cbsatuanbrg"
        Cbsatuanbrg.Size = New Size(260, 28)
        Cbsatuanbrg.TabIndex = 21
        ' 
        ' BarangDGV
        ' 
        BarangDGV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        BarangDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        BarangDGV.Location = New Point(105, 314)
        BarangDGV.Name = "BarangDGV"
        BarangDGV.RowHeadersWidth = 51
        BarangDGV.RowTemplate.Height = 29
        BarangDGV.Size = New Size(604, 264)
        BarangDGV.TabIndex = 22
        ' 
        ' Bbackbrg
        ' 
        Bbackbrg.Location = New Point(640, 230)
        Bbackbrg.Name = "Bbackbrg"
        Bbackbrg.Size = New Size(107, 56)
        Bbackbrg.TabIndex = 52
        Bbackbrg.Text = "Back"
        Bbackbrg.UseVisualStyleBackColor = True
        ' 
        ' Bdeletebrg
        ' 
        Bdeletebrg.Location = New Point(456, 230)
        Bdeletebrg.Name = "Bdeletebrg"
        Bdeletebrg.Size = New Size(107, 56)
        Bdeletebrg.TabIndex = 51
        Bdeletebrg.Text = "Delete"
        Bdeletebrg.UseVisualStyleBackColor = True
        ' 
        ' Beditbrg
        ' 
        Beditbrg.Location = New Point(254, 230)
        Beditbrg.Name = "Beditbrg"
        Beditbrg.Size = New Size(107, 56)
        Beditbrg.TabIndex = 50
        Beditbrg.Text = "Edit"
        Beditbrg.UseVisualStyleBackColor = True
        ' 
        ' Bsavebrg
        ' 
        Bsavebrg.Location = New Point(68, 230)
        Bsavebrg.Name = "Bsavebrg"
        Bsavebrg.RightToLeft = RightToLeft.No
        Bsavebrg.Size = New Size(107, 56)
        Bsavebrg.TabIndex = 49
        Bsavebrg.Text = "Save"
        Bsavebrg.UseVisualStyleBackColor = True
        ' 
        ' Bclearbrg
        ' 
        Bclearbrg.Location = New Point(590, 65)
        Bclearbrg.Name = "Bclearbrg"
        Bclearbrg.Size = New Size(119, 76)
        Bclearbrg.TabIndex = 52
        Bclearbrg.Text = "Clear"
        Bclearbrg.UseVisualStyleBackColor = True
        ' 
        ' Tjumlahbrg
        ' 
        Tjumlahbrg.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tjumlahbrg.ForeColor = SystemColors.ActiveCaptionText
        Tjumlahbrg.Location = New Point(224, 111)
        Tjumlahbrg.Name = "Tjumlahbrg"
        Tjumlahbrg.Size = New Size(260, 30)
        Tjumlahbrg.TabIndex = 54
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(88, 113)
        Label1.Name = "Label1"
        Label1.Size = New Size(73, 28)
        Label1.TabIndex = 53
        Label1.Text = "Jumlah"
        ' 
        ' formdataapd
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(913, 590)
        Controls.Add(Tjumlahbrg)
        Controls.Add(Label1)
        Controls.Add(Bclearbrg)
        Controls.Add(Bbackbrg)
        Controls.Add(Bdeletebrg)
        Controls.Add(Beditbrg)
        Controls.Add(Bsavebrg)
        Controls.Add(BarangDGV)
        Controls.Add(Cbsatuanbrg)
        Controls.Add(Tnamabrg)
        Controls.Add(Tkodebrg)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Name = "formdataapd"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form Data APD"
        CType(BarangDGV, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Tkodebrg As TextBox
    Friend WithEvents Tnamabrg As TextBox
    Friend WithEvents Cbsatuanbrg As ComboBox
    Friend WithEvents BarangDGV As DataGridView
    Friend WithEvents Bbackbrg As Button
    Friend WithEvents Bdeletebrg As Button
    Friend WithEvents Beditbrg As Button
    Friend WithEvents Bsavebrg As Button
    Friend WithEvents Bclearbrg As Button
    Friend WithEvents Tjumlahbrg As TextBox
    Friend WithEvents Label1 As Label
End Class
