<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.UsernameJamil = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PasswordJamil = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnLoginJamil = New System.Windows.Forms.Button()
        Me.btnKeluarJamil = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Username"
        '
        'UsernameJamil
        '
        Me.UsernameJamil.Location = New System.Drawing.Point(23, 75)
        Me.UsernameJamil.Name = "UsernameJamil"
        Me.UsernameJamil.Size = New System.Drawing.Size(204, 24)
        Me.UsernameJamil.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Open Sans", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(177, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "SIAKAD (Kelompok 2)"
        '
        'PasswordJamil
        '
        Me.PasswordJamil.Location = New System.Drawing.Point(23, 131)
        Me.PasswordJamil.Name = "PasswordJamil"
        Me.PasswordJamil.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordJamil.Size = New System.Drawing.Size(204, 24)
        Me.PasswordJamil.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Password"
        '
        'btnLoginJamil
        '
        Me.btnLoginJamil.Location = New System.Drawing.Point(23, 171)
        Me.btnLoginJamil.Name = "btnLoginJamil"
        Me.btnLoginJamil.Size = New System.Drawing.Size(88, 33)
        Me.btnLoginJamil.TabIndex = 5
        Me.btnLoginJamil.Text = "Login"
        Me.btnLoginJamil.UseVisualStyleBackColor = True
        '
        'btnKeluarJamil
        '
        Me.btnKeluarJamil.Location = New System.Drawing.Point(136, 171)
        Me.btnKeluarJamil.Name = "btnKeluarJamil"
        Me.btnKeluarJamil.Size = New System.Drawing.Size(91, 33)
        Me.btnKeluarJamil.TabIndex = 6
        Me.btnKeluarJamil.Text = "Keluar"
        Me.btnKeluarJamil.UseVisualStyleBackColor = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(253, 227)
        Me.Controls.Add(Me.btnKeluarJamil)
        Me.Controls.Add(Me.btnLoginJamil)
        Me.Controls.Add(Me.PasswordJamil)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.UsernameJamil)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Open Sans", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents UsernameJamil As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PasswordJamil As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnLoginJamil As Button
    Friend WithEvents btnKeluarJamil As Button
End Class
