Imports System.Data.Odbc
Module ModuleKoneksi
    Public Da As OdbcDataAdapter
    Public Ds As DataSet
    Public Str As String
    Public Conn As New OdbcConnection("DSN=dsn_kampus")

    Public Sub Koneksi()
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module
