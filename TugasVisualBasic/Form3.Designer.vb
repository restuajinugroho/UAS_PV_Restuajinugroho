<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formpetugas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formpetugas))
        Label1 = New Label()
        TPass1 = New TextBox()
        TNama1 = New TextBox()
        TKode1 = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Bsavepetugas = New Button()
        Beditpetugas = New Button()
        Bdeletepetugas = New Button()
        Bbackpetugas = New Button()
        Bclearpetugas = New Button()
        Petugasdgv = New DataGridView()
        CType(Petugasdgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(59, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 0
        ' 
        ' TPass1
        ' 
        TPass1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TPass1.ForeColor = SystemColors.ActiveCaptionText
        TPass1.Location = New Point(197, 122)
        TPass1.Name = "TPass1"
        TPass1.Size = New Size(260, 30)
        TPass1.TabIndex = 15
        ' 
        ' TNama1
        ' 
        TNama1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TNama1.ForeColor = SystemColors.ActiveCaptionText
        TNama1.Location = New Point(197, 76)
        TNama1.Name = "TNama1"
        TNama1.Size = New Size(260, 30)
        TNama1.TabIndex = 14
        ' 
        ' TKode1
        ' 
        TKode1.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        TKode1.ForeColor = SystemColors.ActiveCaptionText
        TKode1.Location = New Point(197, 32)
        TKode1.Name = "TKode1"
        TKode1.Size = New Size(260, 30)
        TKode1.TabIndex = 13
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(61, 120)
        Label4.Name = "Label4"
        Label4.Size = New Size(93, 28)
        Label4.TabIndex = 11
        Label4.Text = "Password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(61, 74)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 10
        Label2.Text = "Nama"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(61, 32)
        Label5.Name = "Label5"
        Label5.Size = New Size(131, 28)
        Label5.TabIndex = 9
        Label5.Text = "Kode Petugas"
        ' 
        ' Bsavepetugas
        ' 
        Bsavepetugas.Location = New Point(105, 195)
        Bsavepetugas.Name = "Bsavepetugas"
        Bsavepetugas.RightToLeft = RightToLeft.No
        Bsavepetugas.Size = New Size(107, 56)
        Bsavepetugas.TabIndex = 17
        Bsavepetugas.Text = "Save"
        Bsavepetugas.UseVisualStyleBackColor = True
        ' 
        ' Beditpetugas
        ' 
        Beditpetugas.Location = New Point(291, 195)
        Beditpetugas.Name = "Beditpetugas"
        Beditpetugas.Size = New Size(107, 56)
        Beditpetugas.TabIndex = 18
        Beditpetugas.Text = "Edit"
        Beditpetugas.UseVisualStyleBackColor = True
        ' 
        ' Bdeletepetugas
        ' 
        Bdeletepetugas.Location = New Point(493, 195)
        Bdeletepetugas.Name = "Bdeletepetugas"
        Bdeletepetugas.Size = New Size(107, 56)
        Bdeletepetugas.TabIndex = 19
        Bdeletepetugas.Text = "Delete"
        Bdeletepetugas.UseVisualStyleBackColor = True
        ' 
        ' Bbackpetugas
        ' 
        Bbackpetugas.Location = New Point(677, 195)
        Bbackpetugas.Name = "Bbackpetugas"
        Bbackpetugas.Size = New Size(107, 56)
        Bbackpetugas.TabIndex = 20
        Bbackpetugas.Text = "Back"
        Bbackpetugas.UseVisualStyleBackColor = True
        ' 
        ' Bclearpetugas
        ' 
        Bclearpetugas.Location = New Point(583, 42)
        Bclearpetugas.Name = "Bclearpetugas"
        Bclearpetugas.Size = New Size(187, 99)
        Bclearpetugas.TabIndex = 21
        Bclearpetugas.Text = "Clear"
        Bclearpetugas.UseVisualStyleBackColor = True
        ' 
        ' Petugasdgv
        ' 
        Petugasdgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Petugasdgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Petugasdgv.Location = New Point(61, 274)
        Petugasdgv.Name = "Petugasdgv"
        Petugasdgv.RowHeadersWidth = 51
        Petugasdgv.RowTemplate.Height = 29
        Petugasdgv.Size = New Size(774, 237)
        Petugasdgv.TabIndex = 16
        ' 
        ' Formpetugas
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(914, 600)
        Controls.Add(Bclearpetugas)
        Controls.Add(Bbackpetugas)
        Controls.Add(Bdeletepetugas)
        Controls.Add(Beditpetugas)
        Controls.Add(Bsavepetugas)
        Controls.Add(Petugasdgv)
        Controls.Add(TPass1)
        Controls.Add(TNama1)
        Controls.Add(TKode1)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Formpetugas"
        Text = "Form Petugas"
        CType(Petugasdgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TPass1 As TextBox
    Friend WithEvents TNama1 As TextBox
    Friend WithEvents TKode1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Bsavepetugas As Button
    Friend WithEvents Beditpetugas As Button
    Friend WithEvents Bdeletepetugas As Button
    Friend WithEvents Bbackpetugas As Button
    Friend WithEvents Bclearpetugas As Button
    Friend WithEvents Petugasdgv As DataGridView
End Class
