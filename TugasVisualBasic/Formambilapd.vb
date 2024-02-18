Imports System.Data.Odbc

Public Class Formambilapd
    Sub buatkolom()
        Ambildgv.Columns.Clear()
        Ambildgv.Columns.Add("Kode", "Kode")
        Ambildgv.Columns.Add("Nama", "Nama")
        Ambildgv.Columns.Add("Jumlah", "Jumlah")
    End Sub

    Sub kondisiawal()
        Tnikambil.Text = ""
        Lblnama.Text = ""
        Lbldept.Text = ""
        Lblarea.Text = ""
        Tjumlahbrg.Text = ""
        Tkodeambilbrg.Text = ""
        Lblnamabrg.Text = ""
        Ambildgv.Columns.Clear()
    End Sub





    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tkodeambilbrg.KeyPress
        Call Koneksi()
        If e.KeyChar = Chr(13) Then
            Cmd = New OdbcCommand("Select * from tbl_barang where kodebarang = '" & Tkodeambilbrg.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            If Rd.Read Then
                Tkodeambilbrg.Text = Rd.Item(0)
                Lblnamabrg.Text = Rd.Item(1)
                MsgBox("Data ditemukan")
                Ketemu = True

            Else
                MsgBox("Maaf Data tidak Ditemukan")
                Tkodeambilbrg.Focus()
                Ketemu = False

            End If
        End If
    End Sub

    Private Sub Binsertambil_Click(sender As Object, e As EventArgs) Handles Binsertambil.Click
        Ambildgv.Rows.Add(New String() {Tkodeambilbrg.Text, Lblnamabrg.Text, Tjumlahbrg.Text})
        Tkodeambilbrg.Text = ""
        Lblnamabrg.Text = ""
        Tjumlahbrg.Text = ""
    End Sub



    Private Sub Tnikambil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tnikambil.KeyPress
        Call Koneksi()
        If e.KeyChar = Chr(13) Then
            Cmd = New OdbcCommand("Select * from tbl_karyawan where nik = '" & Tnikambil.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            If Rd.Read Then
                Tnikambil.Text = Rd.Item(0)
                Lblnama.Text = Rd.Item(1)
                Lbldept.Text = Rd.Item(2)
                Lblarea.Text = Rd.Item(3)
                MsgBox("Data ditemukan")
                Ketemu = True

            Else
                MsgBox("Maaf Data tidak Ditemukan")
                Tjumlahbrg.Focus()
                Ketemu = False

            End If
        End If
    End Sub



    Private Sub Formambilapd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call buatkolom()
    End Sub

    Private Sub Btutupambil_Click(sender As Object, e As EventArgs) Handles Btutupambil.Click
        Me.Close()

    End Sub

    Private Sub Bsimpanambil_Click(sender As Object, e As EventArgs) Handles Bsimpanambil.Click

        For baris As Integer = 0 To Ambildgv.Rows.Count - 2
            Cmd = New OdbcCommand("select * from tbl_barang where kodebarang='" & Ambildgv.Rows(baris).Cells(0).Value & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            Dim kurangistok As String = "Update tbl_barang set jumlahbarang='" & Rd.Item(2) - Ambildgv.Rows(baris).Cells(2).Value & "' where kodebarang ='" & Ambildgv.Rows(baris).Cells(0).Value & "'"
            Cmd = New OdbcCommand(kurangistok, Conn)
            Cmd.ExecuteNonQuery()
        Next
        MsgBox("Data Berhasil Disimpan")
        Call kondisiawal()
    End Sub
End Class