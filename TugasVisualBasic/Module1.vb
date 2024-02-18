Imports System.Data.Odbc
Module Module1
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public str As String
    Public Rd As OdbcDataReader
    Public Cmd As OdbcCommand
    Public Conn As New OdbcConnection("DSN=dsn_bajuapd")
    Public Ketemu As Boolean = False

    Public Sub Koneksi()
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If

    End Sub
End Module
