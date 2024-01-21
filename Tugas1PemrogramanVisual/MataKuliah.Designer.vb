<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MataKuliah
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnSimpanJamil = New System.Windows.Forms.Button()
        Me.KodeMatkulJamil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NamaMatkulJamil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DosenPengampuJamil = New System.Windows.Forms.TextBox()
        Me.ProdiJamil = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SKSJamil = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnHapusJamil = New System.Windows.Forms.Button()
        Me.btnClearJamil = New System.Windows.Forms.Button()
        Me.btnKeluarJamil = New System.Windows.Forms.Button()
        Me.DGVMatkulJamil = New System.Windows.Forms.DataGridView()
        Me.SemesterJamil = New System.Windows.Forms.ComboBox()
        CType(Me.DGVMatkulJamil, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSimpanJamil
        '
        Me.btnSimpanJamil.Location = New System.Drawing.Point(575, 33)
        Me.btnSimpanJamil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSimpanJamil.Name = "btnSimpanJamil"
        Me.btnSimpanJamil.Size = New System.Drawing.Size(114, 67)
        Me.btnSimpanJamil.TabIndex = 7
        Me.btnSimpanJamil.Text = "Simpan"
        Me.btnSimpanJamil.UseVisualStyleBackColor = True
        '
        'KodeMatkulJamil
        '
        Me.KodeMatkulJamil.Location = New System.Drawing.Point(22, 40)
        Me.KodeMatkulJamil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KodeMatkulJamil.Name = "KodeMatkulJamil"
        Me.KodeMatkulJamil.Size = New System.Drawing.Size(114, 24)
        Me.KodeMatkulJamil.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Kode Mata Kuliah"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 17)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nama Mata Kuliah"
        '
        'NamaMatkulJamil
        '
        Me.NamaMatkulJamil.Location = New System.Drawing.Point(22, 97)
        Me.NamaMatkulJamil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.NamaMatkulJamil.Name = "NamaMatkulJamil"
        Me.NamaMatkulJamil.Size = New System.Drawing.Size(246, 24)
        Me.NamaMatkulJamil.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 17)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Dosen Pengampu"
        '
        'DosenPengampuJamil
        '
        Me.DosenPengampuJamil.Location = New System.Drawing.Point(22, 151)
        Me.DosenPengampuJamil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DosenPengampuJamil.Name = "DosenPengampuJamil"
        Me.DosenPengampuJamil.Size = New System.Drawing.Size(246, 24)
        Me.DosenPengampuJamil.TabIndex = 3
        '
        'ProdiJamil
        '
        Me.ProdiJamil.FormattingEnabled = True
        Me.ProdiJamil.Items.AddRange(New Object() {"S1 - Sistem Informasi", "S1 - Teknik Informatika", "S1 - Komunikasi", "S1 - Akuntansi", "S1 - Manajemen"})
        Me.ProdiJamil.Location = New System.Drawing.Point(286, 150)
        Me.ProdiJamil.Name = "ProdiJamil"
        Me.ProdiJamil.Size = New System.Drawing.Size(246, 25)
        Me.ProdiJamil.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(283, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Prodi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(283, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 17)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "SKS"
        '
        'SKSJamil
        '
        Me.SKSJamil.Location = New System.Drawing.Point(286, 40)
        Me.SKSJamil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SKSJamil.Name = "SKSJamil"
        Me.SKSJamil.Size = New System.Drawing.Size(121, 24)
        Me.SKSJamil.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(283, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Semester"
        '
        'btnHapusJamil
        '
        Me.btnHapusJamil.Location = New System.Drawing.Point(698, 33)
        Me.btnHapusJamil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnHapusJamil.Name = "btnHapusJamil"
        Me.btnHapusJamil.Size = New System.Drawing.Size(114, 67)
        Me.btnHapusJamil.TabIndex = 8
        Me.btnHapusJamil.Text = "Hapus"
        Me.btnHapusJamil.UseVisualStyleBackColor = True
        '
        'btnClearJamil
        '
        Me.btnClearJamil.Location = New System.Drawing.Point(575, 108)
        Me.btnClearJamil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClearJamil.Name = "btnClearJamil"
        Me.btnClearJamil.Size = New System.Drawing.Size(114, 70)
        Me.btnClearJamil.TabIndex = 9
        Me.btnClearJamil.Text = "Clear"
        Me.btnClearJamil.UseVisualStyleBackColor = True
        '
        'btnKeluarJamil
        '
        Me.btnKeluarJamil.Location = New System.Drawing.Point(698, 108)
        Me.btnKeluarJamil.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnKeluarJamil.Name = "btnKeluarJamil"
        Me.btnKeluarJamil.Size = New System.Drawing.Size(114, 70)
        Me.btnKeluarJamil.TabIndex = 10
        Me.btnKeluarJamil.Text = "Keluar"
        Me.btnKeluarJamil.UseVisualStyleBackColor = True
        '
        'DGVMatkulJamil
        '
        Me.DGVMatkulJamil.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVMatkulJamil.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVMatkulJamil.Location = New System.Drawing.Point(22, 196)
        Me.DGVMatkulJamil.Name = "DGVMatkulJamil"
        Me.DGVMatkulJamil.Size = New System.Drawing.Size(790, 276)
        Me.DGVMatkulJamil.TabIndex = 17
        '
        'SemesterJamil
        '
        Me.SemesterJamil.FormattingEnabled = True
        Me.SemesterJamil.Items.AddRange(New Object() {"Semester 1", "Semester 2", "Semester 3", "Semester 4", "Semester 5", "Semester 6", "Semester 7", "Semester 8"})
        Me.SemesterJamil.Location = New System.Drawing.Point(286, 97)
        Me.SemesterJamil.Name = "SemesterJamil"
        Me.SemesterJamil.Size = New System.Drawing.Size(121, 25)
        Me.SemesterJamil.TabIndex = 5
        '
        'MataKuliah
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 490)
        Me.Controls.Add(Me.SemesterJamil)
        Me.Controls.Add(Me.DGVMatkulJamil)
        Me.Controls.Add(Me.btnKeluarJamil)
        Me.Controls.Add(Me.btnClearJamil)
        Me.Controls.Add(Me.btnHapusJamil)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.SKSJamil)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ProdiJamil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DosenPengampuJamil)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NamaMatkulJamil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.KodeMatkulJamil)
        Me.Controls.Add(Me.btnSimpanJamil)
        Me.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MataKuliah"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mata Kuliah"
        CType(Me.DGVMatkulJamil, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimpanJamil As Button
    Friend WithEvents KodeMatkulJamil As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NamaMatkulJamil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DosenPengampuJamil As TextBox
    Friend WithEvents ProdiJamil As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents SKSJamil As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnHapusJamil As Button
    Friend WithEvents btnClearJamil As Button
    Friend WithEvents btnKeluarJamil As Button
    Friend WithEvents DGVMatkulJamil As DataGridView
    Friend WithEvents SemesterJamil As ComboBox
End Class
