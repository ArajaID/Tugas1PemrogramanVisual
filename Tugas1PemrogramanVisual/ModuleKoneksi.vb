Imports System.Data.Odbc
Module ModuleKoneksi
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Rd As OdbcDataReader
    Public Str As String
    Public Conn As New OdbcConnection("DSN=dsn_kampus")
    Public Cmd As OdbcCommand
    Public ValidData As Boolean = False
    Public Sub Koneksi()
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
