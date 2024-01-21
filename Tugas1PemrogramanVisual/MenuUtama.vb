Public Class MenuUtama
    Private Sub MenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Call LockMenu()
    End Sub

    Sub LockMenu()
        LoginToolStripMenuItem.Visible = True
        LogoutToolStripMenuItem.Visible = False
        MasterToolStripMenuItem.Visible = False
        MataKuliahToolStripMenuItem.Visible = False
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        End
    End Sub
    Private Sub LogoutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim Conf As Object = MessageBox.Show("Apakah anda yakin akan keluar dari Aplikasi?", "Logout",
                         MessageBoxButtons.YesNo,
                         MessageBoxIcon.Question)

        If Conf = Windows.Forms.DialogResult.Yes Then
            Call LockMenu()
        ElseIf Conf = Conf = Windows.Forms.DialogResult.No Then
            Me.Close()
        End If
    End Sub

    Private Sub MataKuliahToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MataKuliahToolStripMenuItem.Click
        MataKuliah.Show()
    End Sub
End Class
