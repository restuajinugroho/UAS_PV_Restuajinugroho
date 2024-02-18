Imports System.Data.Odbc

Public Class Formkaryawan

    Sub tampilkaryawan()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT nik,nama,departement,area FROM tbl_karyawan", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_karyawan")
        Karyawandgv.DataSource = Ds.Tables("tbl_karyawan")
        Karyawandgv.ReadOnly = True
        Bsavekary.Enabled = True
        Bbackkary.Enabled = True
        Bclearkary.Enabled = True
        Beditkary.Enabled = True

    End Sub
    Private Sub Bbackkary_Click(sender As Object, e As EventArgs)
        Hide()

    End Sub

    Private Sub Formkaryawan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilkaryawan()
    End Sub

    Private Sub Bbackkary_Click_1(sender As Object, e As EventArgs) Handles Bbackkary.Click
        Me.Hide()

    End Sub

    Private Sub Bclearkary_Click(sender As Object, e As EventArgs) Handles Bclearkary.Click
        Tnikkary.Text = ""
        Tnamakary.Text = ""
        Cbdeptkary.Text = ""
        Cbareakary.Text = ""
    End Sub

    Private Sub Karyawandgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Karyawandgv.CellContentClick

    End Sub

    Private Sub Bsavekary_Click(sender As Object, e As EventArgs) Handles Bsavekary.Click
        Call Koneksi()
        If Tnikkary.Text = "" Then
            MsgBox("Nik Tidak Boleh Kosong")
            Exit Sub
        ElseIf Tnamakary.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong")
            Exit Sub
        ElseIf Cbareakary.Text = "" Then
            MsgBox("Area Tidak Boleh Kosong")
            Exit Sub
        ElseIf Cbdeptkary.Text = "" Then
            MsgBox("Departement Tidak Boleh Kosong")
            Exit Sub
        Else
            Dim SimpanData As String = "insert into tbl_karyawan value ('" & Tnikkary.Text & "','" & Tnamakary.Text & "','" & Cbdeptkary.Text & "', '" & Cbareakary.Text & "')"
            Cmd = New OdbcCommand(SimpanData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox(" Data Berhasil di Simpan")
            Bclearkary_Click(sender, e)
            Call tampilkaryawan()
        End If
    End Sub

    Private Sub Bdeletekary_Click(sender As Object, e As EventArgs) Handles Bdeletekary.Click
        Call Koneksi()
        If Tnikkary.Text = "" Then
            MsgBox("Kode Tidak Boleh Kosong")
            Exit Sub

        ElseIf Ketemu = False Then
            MsgBox("Maaf Data Tidak Ditemukan")
            Tnikkary.Focus()
            Exit Sub
        Else
            Dim HapusData As String = "Delete from tbl_karyawan where nik ='" & Tnikkary.Text & "'"
            Cmd = New OdbcCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox(" Data Berhasil di Hapus")
            Bclearkary_Click(sender, e)
            Tnikkary.Focus()
            Call tampilkaryawan()

        End If
    End Sub


    Private Sub Tnikkary_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tnikkary.KeyPress
        Call Koneksi()
        If e.KeyChar = Chr(13) Then
            Cmd = New OdbcCommand("Select * from tbl_karyawan where nik = '" & Tnikkary.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            If Rd.Read Then
                Tnikkary.Text = Rd.Item(0)
                Tnamakary.Text = Rd.Item(1)
                Cbdeptkary.Text = Rd.Item(2)
                Cbareakary.Text = Rd.Item(3)
                MsgBox("Data ditemukan")
                Ketemu = True
                Bsavekary.Enabled = False
                Bbackkary.Enabled = False
                Bclearkary.Enabled = False

            Else
                MsgBox("Maaf Data tidak Ditemukan")
                Tnikkary.Focus()
                Ketemu = False

            End If
        End If
    End Sub

    Private Sub Beditkary_Click(sender As Object, e As EventArgs) Handles Beditkary.Click
        Call Koneksi()

        If Tnikkary.Text = "" Then
            MsgBox("Nik Tidak Boleh Kosong")
            Exit Sub
        ElseIf Tnamakary.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong")
            Exit Sub
        ElseIf Cbdeptkary.Text = "" Then
            MsgBox("Departement Tidak Boleh Kosong")
            Exit Sub
        ElseIf Cbareakary.Text = "" Then
            MsgBox("Area Tidak Boleh Kosong")
            Exit Sub
        Else
            Dim editdatakaryawan As String = "update tbl_karyawan set  nama='" & Tnamakary.Text & "', departement='" & Cbdeptkary.Text & "', area='" & Cbareakary.Text & "'where nik='" & Tnikkary.Text & "'"
            Cmd = New OdbcCommand(editdatakaryawan, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Edit Data Berhasil")
            Bclearkary_Click(sender, e)
            Call tampilkaryawan()
        End If
    End Sub
End Class