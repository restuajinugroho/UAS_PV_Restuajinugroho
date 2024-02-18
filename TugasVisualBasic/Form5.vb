Imports System.Data.Odbc

Public Class Formkembaliapd

    Sub buatkolom()
        Kembalidgv.Columns.Clear()
        Kembalidgv.Columns.Add("Kode", "Kode")
        Kembalidgv.Columns.Add("Nama", "Nama")
        Kembalidgv.Columns.Add("Jumlah", "Jumlah")
    End Sub
    Sub kondisiawal()
        Tnikkembali.Text = ""
        Lblnamakembali.Text = ""
        Lbldeptkembali.Text = ""
        Lblareakembali.Text = ""
        Tjumlahkembalibrg.Text = ""
        Tkodekembalibrg.Text = ""
        Lblnamakembalibrg.Text = ""
        Kembalidgv.Columns.Clear()
    End Sub
    Private Sub Tnikkembali_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tnikkembali.KeyPress
        Call Koneksi()
        If e.KeyChar = Chr(13) Then
            Cmd = New OdbcCommand("Select * from tbl_karyawan where nik = '" & Tnikkembali.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            If Rd.Read Then
                Tnikkembali.Text = Rd.Item(0)
                Lblnamakembali.Text = Rd.Item(1)
                Lbldeptkembali.Text = Rd.Item(2)
                Lblareakembali.Text = Rd.Item(3)
                MsgBox("Data ditemukan")
                Ketemu = True

            Else
                MsgBox("Maaf Data tidak Ditemukan")
                Tjumlahkembalibrg.Focus()
                Ketemu = False

            End If
        End If
    End Sub



    Private Sub Tkodekembalibrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tkodekembalibrg.KeyPress
        Call Koneksi()
        If e.KeyChar = Chr(13) Then
            Cmd = New OdbcCommand("Select * from tbl_barang where kodebarang = '" & Tkodekembalibrg.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            If Rd.Read Then
                Tkodekembalibrg.Text = Rd.Item(0)
                Lblnamakembalibrg.Text = Rd.Item(1)
                MsgBox("Data ditemukan")
                Ketemu = True

            Else
                MsgBox("Maaf Data tidak Ditemukan")
                Tkodekembalibrg.Focus()
                Ketemu = False

            End If
        End If
    End Sub

    Private Sub Binsertkembali_Click(sender As Object, e As EventArgs) Handles Binsertkembali.Click
        Kembalidgv.Rows.Add(New String() {Tkodekembalibrg.Text, Lblnamakembalibrg.Text, Tjumlahkembalibrg.Text})
        Tkodekembalibrg.Text = ""
        Lblnamakembalibrg.Text = ""
        Tjumlahkembalibrg.Text = ""
    End Sub

    Private Sub Formkembaliapd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buatkolom()
    End Sub

    Private Sub Btutupkembali_Click(sender As Object, e As EventArgs) Handles Btutupkembali.Click
        Me.Close()
    End Sub

    Private Sub Bkembalikan_Click(sender As Object, e As EventArgs) Handles Bkembalikan.Click
        For baris As Integer = 0 To Kembalidgv.Rows.Count - 2
            Cmd = New OdbcCommand("select * from tbl_barang where kodebarang='" & Kembalidgv.Rows(baris).Cells(0).Value & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            Dim kurangistok As String = "Update tbl_barang set jumlahbarang='" & Rd.Item(2) + Kembalidgv.Rows(baris).Cells(2).Value & "' where kodebarang ='" & Kembalidgv.Rows(baris).Cells(0).Value & "'"
            Cmd = New OdbcCommand(kurangistok, Conn)
            Cmd.ExecuteNonQuery()
        Next
        MsgBox("Data Berhasil Disimpan")
        Call kondisiawal()
    End Sub

End Class