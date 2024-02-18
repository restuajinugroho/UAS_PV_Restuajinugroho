<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Formkaryawan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formkaryawan))
        Bclearkary = New Button()
        Bbackkary = New Button()
        Bdeletekary = New Button()
        Beditkary = New Button()
        Bsavekary = New Button()
        Tnamakary = New TextBox()
        Tnikkary = New TextBox()
        Label4 = New Label()
        Label2 = New Label()
        Label5 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Karyawandgv = New DataGridView()
        Cbdeptkary = New ComboBox()
        Cbareakary = New ComboBox()
        CType(Karyawandgv, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Bclearkary
        ' 
        Bclearkary.Location = New Point(609, 72)
        Bclearkary.Name = "Bclearkary"
        Bclearkary.Size = New Size(187, 99)
        Bclearkary.TabIndex = 33
        Bclearkary.Text = "Clear"
        Bclearkary.UseVisualStyleBackColor = True
        ' 
        ' Bbackkary
        ' 
        Bbackkary.Location = New Point(683, 248)
        Bbackkary.Name = "Bbackkary"
        Bbackkary.Size = New Size(107, 56)
        Bbackkary.TabIndex = 32
        Bbackkary.Text = "Back"
        Bbackkary.UseVisualStyleBackColor = True
        ' 
        ' Bdeletekary
        ' 
        Bdeletekary.Location = New Point(499, 248)
        Bdeletekary.Name = "Bdeletekary"
        Bdeletekary.Size = New Size(107, 56)
        Bdeletekary.TabIndex = 31
        Bdeletekary.Text = "Delete"
        Bdeletekary.UseVisualStyleBackColor = True
        ' 
        ' Beditkary
        ' 
        Beditkary.Location = New Point(297, 248)
        Beditkary.Name = "Beditkary"
        Beditkary.Size = New Size(107, 56)
        Beditkary.TabIndex = 30
        Beditkary.Text = "Edit"
        Beditkary.UseVisualStyleBackColor = True
        ' 
        ' Bsavekary
        ' 
        Bsavekary.Location = New Point(111, 248)
        Bsavekary.Name = "Bsavekary"
        Bsavekary.RightToLeft = RightToLeft.No
        Bsavekary.Size = New Size(107, 56)
        Bsavekary.TabIndex = 29
        Bsavekary.Text = "Save"
        Bsavekary.UseVisualStyleBackColor = True
        ' 
        ' Tnamakary
        ' 
        Tnamakary.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tnamakary.ForeColor = SystemColors.ActiveCaptionText
        Tnamakary.Location = New Point(238, 74)
        Tnamakary.Name = "Tnamakary"
        Tnamakary.Size = New Size(260, 30)
        Tnamakary.TabIndex = 27
        ' 
        ' Tnikkary
        ' 
        Tnikkary.Font = New Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point)
        Tnikkary.ForeColor = SystemColors.ActiveCaptionText
        Tnikkary.Location = New Point(238, 30)
        Tnikkary.Name = "Tnikkary"
        Tnikkary.Size = New Size(260, 30)
        Tnikkary.TabIndex = 26
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(102, 118)
        Label4.Name = "Label4"
        Label4.Size = New Size(127, 28)
        Label4.TabIndex = 25
        Label4.Text = "Departement"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(102, 72)
        Label2.Name = "Label2"
        Label2.Size = New Size(64, 28)
        Label2.TabIndex = 24
        Label2.Text = "Nama"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.ForeColor = SystemColors.ActiveCaptionText
        Label5.Location = New Point(102, 30)
        Label5.Name = "Label5"
        Label5.Size = New Size(44, 28)
        Label5.TabIndex = 23
        Label5.Text = "NIK"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(100, 30)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 20)
        Label1.TabIndex = 22
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(100, 165)
        Label3.Name = "Label3"
        Label3.Size = New Size(52, 28)
        Label3.TabIndex = 34
        Label3.Text = "Area"
        ' 
        ' Karyawandgv
        ' 
        Karyawandgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Karyawandgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Karyawandgv.Location = New Point(94, 333)
        Karyawandgv.Name = "Karyawandgv"
        Karyawandgv.RowHeadersWidth = 51
        Karyawandgv.RowTemplate.Height = 29
        Karyawandgv.Size = New Size(709, 233)
        Karyawandgv.TabIndex = 36
        ' 
        ' Cbdeptkary
        ' 
        Cbdeptkary.FormattingEnabled = True
        Cbdeptkary.Items.AddRange(New Object() {"Production", "Engineering", "Quality"})
        Cbdeptkary.Location = New Point(238, 126)
        Cbdeptkary.Name = "Cbdeptkary"
        Cbdeptkary.Size = New Size(260, 28)
        Cbdeptkary.TabIndex = 37
        ' 
        ' Cbareakary
        ' 
        Cbareakary.FormattingEnabled = True
        Cbareakary.Items.AddRange(New Object() {"High care", "Medium care", "Low care"})
        Cbareakary.Location = New Point(238, 169)
        Cbareakary.Name = "Cbareakary"
        Cbareakary.Size = New Size(260, 28)
        Cbareakary.TabIndex = 38
        ' 
        ' Formkaryawan
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        ClientSize = New Size(914, 600)
        Controls.Add(Cbareakary)
        Controls.Add(Cbdeptkary)
        Controls.Add(Karyawandgv)
        Controls.Add(Label3)
        Controls.Add(Bclearkary)
        Controls.Add(Bbackkary)
        Controls.Add(Bdeletekary)
        Controls.Add(Beditkary)
        Controls.Add(Bsavekary)
        Controls.Add(Tnamakary)
        Controls.Add(Tnikkary)
        Controls.Add(Label4)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(Label1)
        Name = "Formkaryawan"
        Text = "Form Karyawan"
        CType(Karyawandgv, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Bclearkary As Button
    Friend WithEvents Bbackkary As Button
    Friend WithEvents Bdeletekary As Button
    Friend WithEvents Beditkary As Button
    Friend WithEvents Bsavekary As Button
    Friend WithEvents Tnamakary As TextBox
    Friend WithEvents Tnikkary As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Karyawandgv As DataGridView
    Friend WithEvents Cbdeptkary As ComboBox
    Friend WithEvents Cbareakary As ComboBox
End Class
