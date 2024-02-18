<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formmenulogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Formmenulogin))
        Panel1 = New Panel()
        Label4 = New Label()
        Button1 = New Button()
        Label3 = New Label()
        Tpwd = New TextBox()
        Label2 = New Label()
        Tnik = New TextBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Panel2 = New Panel()
        Panel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), Image)
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Button1)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Tpwd)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Tnik)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(PictureBox1)
        Panel1.Dock = DockStyle.Left
        Panel1.ForeColor = SystemColors.ActiveBorder
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(331, 543)
        Panel1.TabIndex = 0
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.Transparent
        Label4.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(16, 502)
        Label4.Name = "Label4"
        Label4.Size = New Size(287, 20)
        Label4.TabIndex = 7
        Label4.Text = "*Hanya petugas laundry yang bisa login"
        ' 
        ' Button1
        ' 
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(94, 382)
        Button1.Name = "Button1"
        Button1.Size = New Size(131, 71)
        Button1.TabIndex = 6
        Button1.Text = "Login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.Transparent
        Label3.Font = New Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(94, 192)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 46)
        Label3.TabIndex = 5
        ' 
        ' Tpwd
        ' 
        Tpwd.BackColor = SystemColors.ButtonHighlight
        Tpwd.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Tpwd.Location = New Point(104, 312)
        Tpwd.Name = "Tpwd"
        Tpwd.Size = New Size(212, 34)
        Tpwd.TabIndex = 4
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.Transparent
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(-1, 311)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 28)
        Label2.TabIndex = 3
        Label2.Text = "Password "
        ' 
        ' Tnik
        ' 
        Tnik.BackColor = SystemColors.ButtonHighlight
        Tnik.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Tnik.Location = New Point(104, 269)
        Tnik.Name = "Tnik"
        Tnik.Size = New Size(214, 34)
        Tnik.TabIndex = 2
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.Transparent
        Label1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(1, 268)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 28)
        Label1.TabIndex = 1
        Label1.Text = "Admin         :"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), Image)
        PictureBox1.BackgroundImageLayout = ImageLayout.Stretch
        PictureBox1.Location = New Point(85, 11)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 166)
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), Image)
        Panel2.BackgroundImageLayout = ImageLayout.Stretch
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Dock = DockStyle.Fill
        Panel2.Location = New Point(331, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(523, 543)
        Panel2.TabIndex = 1
        ' 
        ' Formmenulogin
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(224), CByte(192))
        ClientSize = New Size(854, 543)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Name = "Formmenulogin"
        Text = "Aplikasi Pengambilan APD"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Tnik As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Tpwd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label

End Class
