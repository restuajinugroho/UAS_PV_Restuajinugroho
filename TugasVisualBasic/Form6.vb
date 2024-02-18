Imports System.Data.Odbc

Public Class formdataapd

    Sub tampilbarang()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT kodebarang,namabarang,jumlahbarang,satuanbarang FROM tbl_barang", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbl_barang")
        BarangDGV.DataSource = Ds.Tables("tbl_barang")
        BarangDGV.ReadOnly = True
    End Sub

    Sub tampilbutton()
        Bsavebrg.Enabled = True
        Bbackbrg.Enabled = True
        Bclearbrg.Enabled = True
    End Sub

    Private Sub Bbackbrg_Click(sender As Object, e As EventArgs) Handles Bbackbrg.Click
        Me.Hide()

    End Sub

    Private Sub Bclearbrg_Click(sender As Object, e As EventArgs) Handles Bclearbrg.Click
        Tkodebrg.Text = ""
        Tnamabrg.Text = ""
        Tjumlahbrg.Text = ""
        Cbsatuanbrg.Text = ""
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampilbarang()
    End Sub

    Private Sub Bsavebrg_Click(sender As Object, e As EventArgs) Handles Bsavebrg.Click
        Call Koneksi()
        If Tkodebrg.Text = "" Then
            MsgBox("Kode Barang Tidak Boleh Kosong")
            Exit Sub
        ElseIf Tnamabrg.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong")
            Exit Sub
        ElseIf Tjumlahbrg.Text = "" Then
            MsgBox("Jumlah Tidak Boleh Kosong")
            Exit Sub
        ElseIf Cbsatuanbrg.Text = "" Then
            MsgBox("Satuan Tidak Boleh Kosong")
            Exit Sub
        Else
            Dim SimpanData As String = "insert into tbl_barang value ('" & Tkodebrg.Text & "','" & Tnamabrg.Text & "','" & Tjumlahbrg.Text & "','" & Cbsatuanbrg.Text & "')"
            Cmd = New OdbcCommand(SimpanData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox(" Data Berhasil di Simpan")
            Bclearbrg_Click(sender, e)
            Call tampilbarang()
        End If
    End Sub

    Private Sub Bdeletebrg_Click(sender As Object, e As EventArgs) Handles Bdeletebrg.Click
        Call Koneksi()
        If Tkodebrg.Text = "" Then
            MsgBox("Kode Barang Tidak Boleh Kosong")
            Exit Sub

        ElseIf Ketemu = False Then
            MsgBox("Maaf Data Tidak Ditemukan")
            Tkodebrg.Focus()
            Exit Sub
        Else
            Dim HapusData As String = "Delete from tbl_barang where kodebarang ='" & Tkodebrg.Text & "'"
            Cmd = New OdbcCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox(" Data Berhasil di Hapus")
            Bclearbrg_Click(sender, e)
            Tkodebrg.Focus()
            Call tampilbarang()
            Call tampilbutton()

        End If
    End Sub



    Private Sub Tkodebrg_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Tkodebrg.KeyPress
        Call Koneksi()
        If e.KeyChar = Chr(13) Then
            Cmd = New OdbcCommand("Select * from tbl_barang where kodebarang = '" & Tkodebrg.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            If Rd.Read Then
                Tkodebrg.Text = Rd.Item(0)
                Tnamabrg.Text = Rd.Item(1)
                Tjumlahbrg.Text = Rd.Item(2)
                Cbsatuanbrg.Text = Rd.Item(3)
                MsgBox("Data ditemukan")
                Ketemu = True
                Bsavebrg.Enabled = False
                Bbackbrg.Enabled = False
                Bclearbrg.Enabled = False

            Else
                MsgBox("Maaf Data tidak Ditemukan")
                Tkodebrg.Focus()
                Ketemu = False

            End If
        End If
    End Sub

    Private Sub Beditbrg_Click(sender As Object, e As EventArgs) Handles Beditbrg.Click
        Call Koneksi()

        If Tkodebrg.Text = "" Then
            MsgBox("Kode Barang Tidak Boleh Kosong")
            Exit Sub
        ElseIf Tnamabrg.Text = "" Then
            MsgBox("Nama Tidak Boleh Kosong")
            Exit Sub
        ElseIf Tjumlahbrg.Text = "" Then
            MsgBox("Jumlah Tidak Boleh Kosong")
            Exit Sub
        ElseIf Cbsatuanbrg.Text = "" Then
            MsgBox("barang Tidak Boleh Kosong")
            Exit Sub

        Else
            Dim editdatakaryawan As String = "update tbl_barang set  namabarang='" & Tnamabrg.Text & "', jumlahbarang='" & Tjumlahbrg.Text & "', satuanbarang='" & Cbsatuanbrg.Text & "' where kodebarang='" & Tkodebrg.Text & "'"
            Cmd = New OdbcCommand(editdatakaryawan, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Edit Data Berhasil")
            Bclearbrg_Click(sender, e)
            Call tampilbarang()
            Call tampilbutton()
        End If
    End Sub
End Class