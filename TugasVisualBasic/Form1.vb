Imports System.Data.Odbc


Public Class Formmenulogin

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Tnik.Text = "" Or Tpwd.Text = "" Then
            MsgBox("Nik atau Password tidak boleh kosong!")
        Else
            Try

                Call Koneksi()
                Cmd = New OdbcCommand("Select * From tbl_admin WHERE kodeadmin = '" & Tnik.Text & "' and pwdadmin = '" & Tpwd.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    'If TextBox1.Text = "AA" And TextBox2.Text = "BB" Then
                    Me.Hide()
                    Tnik.Text = ""
                    Tpwd.Text = ""
                    Formmenuutama.Show()

                Else
                    MsgBox("Kode admin atau Password salah!")

                End If

            Catch ex As Exception
                MsgBox("Gagal terhubung ke database. Pastikan server database telah dijalankan dan konfigurasi koneksi database Anda benar." & vbCrLf & vbCrLf & "Error: " & ex.Message)
            Finally
                ' Tutup koneksi setelah selesai
                Conn.Close()
            End Try
        End If
    End Sub

    Private Sub Formmenuutama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Tpwd.PasswordChar = "*"
    End Sub
End Class