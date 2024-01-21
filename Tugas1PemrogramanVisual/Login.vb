Imports System.Data.Odbc
Public Class Login
    Private Sub btnKeluarJamil_Click(sender As Object, e As EventArgs) Handles btnKeluarJamil.Click
        Me.Hide()
    End Sub
    Sub OpenMenu()
        MenuUtama.LoginToolStripMenuItem.Visible = False
        MenuUtama.LogoutToolStripMenuItem.Visible = True
        MenuUtama.MasterToolStripMenuItem.Visible = True
        MenuUtama.MataKuliahToolStripMenuItem.Visible = True
    End Sub
    Sub ResetForm()
        UsernameJamil.Text = ""
        PasswordJamil.Text = ""
    End Sub
    Private Sub btnLoginJamil_Click(sender As Object, e As EventArgs) Handles btnLoginJamil.Click
        If UsernameJamil.Text = "" Or PasswordJamil.Text = "" Then
            MessageBox.Show("Username dan Password tidak boleh Kosong", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            Call Koneksi()
            Cmd = New OdbcCommand("SELECT * FROM tb_users WHERE username ='" & UsernameJamil.Text & "' and password = '" & PasswordJamil.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call OpenMenu()
                MessageBox.Show("Berhasil Login", "Success", MessageBoxButtons.OK)
            Else
                MessageBox.Show("Username dan Password tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call ResetForm()
    End Sub
End Class