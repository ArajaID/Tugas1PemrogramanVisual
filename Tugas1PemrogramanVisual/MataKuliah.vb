Imports System.Data.Odbc
Public Class MataKuliah
    Sub ResetForm()
        KodeMatkulJamil.Text = ""
        NamaMatkulJamil.Text = ""
        DosenPengampuJamil.Text = ""
        SKSJamil.Text = ""
        SemesterJamil.Text = ""
        ProdiJamil.Text = ""
        KodeMatkulJamil.Focus()
    End Sub
    Sub ViewData()
        Call Koneksi()
        Da = New OdbcDataAdapter("SELECT * FROM tb_matkul", Conn)
        Ds = New DataSet

        Da.Fill(Ds, "tb_matkul")
        DGVMatkulJamil.DataSource = Ds.Tables("tb_matkul")

        DGVMatkulJamil.Columns(0).HeaderText = "Kode Matkul"
        DGVMatkulJamil.Columns(1).HeaderText = "Nama Matkul"
        DGVMatkulJamil.Columns(2).HeaderText = "SKS"
        DGVMatkulJamil.Columns(3).HeaderText = "Dosen Pengampu"
        DGVMatkulJamil.Columns(4).HeaderText = "Prodi"
        DGVMatkulJamil.Columns(5).HeaderText = "Semester"
    End Sub
    Private Sub btnKeluarJamil_Click(sender As Object, e As EventArgs) Handles btnKeluarJamil.Click
        Me.Close()
    End Sub

    Private Sub btnClearJamil_Click(sender As Object, e As EventArgs) Handles btnClearJamil.Click
        ResetForm()
    End Sub

    Private Sub MataKuliah_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ViewData()
    End Sub

    Private Sub btnSimpanJamil_Click(sender As Object, e As EventArgs) Handles btnSimpanJamil.Click
        If ValidData = True Then
            'ubah
            If KodeMatkulJamil.Text = "" Or NamaMatkulJamil.Text = "" Or DosenPengampuJamil.Text = "" Or SKSJamil.Text = "" Or SemesterJamil.Text = "" Or ProdiJamil.Text = "" Then
                MessageBox.Show("Mohon untuk mengisi semua Form", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Cmd = New OdbcCommand("UPDATE tb_matkul SET nama_matkul ='" & NamaMatkulJamil.Text & "', sks ='" & SKSJamil.Text & "', dosen ='" & DosenPengampuJamil.Text & "', prodi ='" & ProdiJamil.Text & "', semester ='" & SemesterJamil.Text & "' WHERE kode_matkul ='" & KodeMatkulJamil.Text & "'", Conn)
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Ubah data berhasil", "Success", MessageBoxButtons.OK)

                    ResetForm()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            'simpan
            If KodeMatkulJamil.Text = "" Or NamaMatkulJamil.Text = "" Or DosenPengampuJamil.Text = "" Or SKSJamil.Text = "" Or SemesterJamil.Text = "" Or ProdiJamil.Text = "" Then
                MessageBox.Show("Mohon untuk mengisi semua Form", "Validasi", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                Try
                    Cmd = New OdbcCommand("INSERT INTO tb_matkul (kode_matkul, nama_matkul, sks, dosen, prodi, semester) VALUES ('" & KodeMatkulJamil.Text & "', '" & NamaMatkulJamil.Text & "', '" & SKSJamil.Text & "', '" & DosenPengampuJamil.Text & "', '" & ProdiJamil.Text & "', '" & SemesterJamil.Text & "' )", Conn)
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil disimpan", "Success", MessageBoxButtons.OK)

                    ResetForm()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

        ViewData()
    End Sub

    Private Sub KodeMatkulJamil_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KodeMatkulJamil.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()

            Cmd = New OdbcCommand("SELECT * FROM tb_matkul WHERE kode_matkul = '" & KodeMatkulJamil.Text & "'", Conn)

            Rd = Cmd.ExecuteReader

            If Rd.Read Then
                KodeMatkulJamil.Text = Rd.Item(0)
                NamaMatkulJamil.Text = Rd.Item(1)
                DosenPengampuJamil.Text = Rd.Item(3)
                SKSJamil.Text = Rd.Item(2)
                SemesterJamil.Text = Rd.Item(5)
                ProdiJamil.Text = Rd.Item(4)

                MessageBox.Show("Data Ditemukan", "Success", MessageBoxButtons.OK)

                ValidData = True
            Else
                MessageBox.Show("Maaf data tidak ditemukan", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                KodeMatkulJamil.Focus()

                ValidData = False
            End If
        End If
    End Sub

    Private Sub btnHapusJamil_Click(sender As Object, e As EventArgs) Handles btnHapusJamil.Click
        If ValidData = True Then
            Try
                If MessageBox.Show("Apakah anda yakin akan Menghapus Data ?", "Konfirmasi", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
                    Cmd = New OdbcCommand("DELETE FROM tb_matkul WHERE kode_matkul='" & KodeMatkulJamil.Text & "'", Conn)
                    Cmd.ExecuteNonQuery()
                    MessageBox.Show("Data berhasil dihapus", "Success", MessageBoxButtons.OK)

                    ViewData()
                    ResetForm()
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class