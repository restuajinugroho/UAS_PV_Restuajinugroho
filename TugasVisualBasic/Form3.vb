Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Formpetugas

    Sub Tampil()

        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT kodeadmin,namaadmin FROM tbl_admin", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_admin")
        Petugasdgv.DataSource = Ds.Tables("tbl_admin")
        Petugasdgv.ReadOnly = True
        Bsavepetugas.Enabled = True
        Bbackpetugas.Enabled = True
        Bclearpetugas.Enabled = True
        Beditpetugas.Enabled = True


    End Sub


    Private Sub Formpetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tampil()
    End Sub

    Private Sub Bsavepetugas_Click(sender As Object, e As EventArgs) Handles Bsavepetugas.Click
        Call Koneksi()
        If TKode1.Text = "" Then
            MsgBox("Kode Tidak Boleh Kosong")
            Exit Sub
        ElseIf TNama1.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong")
            Exit Sub
        ElseIf TPass1.Text = "" Then
            MsgBox("Password Tidak Boleh Kosong")
            Exit Sub
        Else
            Dim SimpanData As String = "insert into tbl_admin value ('" & TKode1.Text & "','" & TNama1.Text & "','" & TPass1.Text & "')"
            Cmd = New OdbcCommand(SimpanData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox(" Data Berhasil di Simpan")
            Bclearpetugas_Click(sender, e)
            Call Tampil()
        End If
    End Sub

    Private Sub Bclearpetugas_Click(sender As Object, e As EventArgs) Handles Bclearpetugas.Click
        TKode1.Text = ""
        TNama1.Text = ""
        TPass1.Text = ""
    End Sub

    Private Sub Bbackpetugas_Click(sender As Object, e As EventArgs) Handles Bbackpetugas.Click
        Me.Hide()

    End Sub

    Private Sub Bdeletepetugas_Click(sender As Object, e As EventArgs) Handles Bdeletepetugas.Click
        Call Koneksi()
        If TKode1.Text = "" Then
            MsgBox("Kode Tidak Boleh Kosong")
            Exit Sub

        ElseIf Ketemu = False Then
            MsgBox("Maaf Data Tidak Ditemukan")
            TKode1.Focus()
            Exit Sub
        Else
            Dim HapusData As String = "Delete from tbl_admin where kodeadmin ='" & TKode1.Text & "'"
            Cmd = New OdbcCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox(" Data Berhasil di Hapus")
            Bclearpetugas_Click(sender, e)
            TKode1.Focus()
            Call Tampil()

        End If
    End Sub

    Private Sub TKode1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TKode1.KeyPress
        Call Koneksi()
        If e.KeyChar = Chr(13) Then
            Cmd = New OdbcCommand("Select * from tbl_admin where kodeadmin = '" & TKode1.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            If Rd.Read Then
                TKode1.Text = Rd.Item(0)
                TNama1.Text = Rd.Item(1)
                TPass1.Text = Rd.Item(2)
                MsgBox("Data ditemukan")
                Ketemu = True
                Bsavepetugas.Enabled = False
                Bbackpetugas.Enabled = False
                Bclearpetugas.Enabled = False
            Else
                MsgBox("Maaf Data tidak Ditemukan")
                TKode1.Focus()
                Ketemu = False

            End If
        End If
    End Sub

    Private Sub Beditpetugas_Click(sender As Object, e As EventArgs) Handles Beditpetugas.Click
        Call Koneksi()
        If TKode1.Text = "" Then
            MsgBox("Kode Tidak Boleh Kosong")
            Exit Sub
        ElseIf TNama1.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong")
            Exit Sub
        ElseIf TPass1.Text = "" Then
            MsgBox("Password Tidak Boleh Kosong")
            Exit Sub
        Else
            Dim editdatapetugas As String = "Update tbl_admin set namaadmin='" & TNama1.Text & "',pwdadmin='" & TPass1.Text & "'where kodeadmin='" & TKode1.Text & "'"
            Cmd = New OdbcCommand(editdatapetugas, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Edit Data Berhasil")
            Bclearpetugas_Click(sender, e)
            Call Tampil()
        End If
    End Sub

    Private Sub Petugasdgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Petugasdgv.CellContentClick

    End Sub
End Class