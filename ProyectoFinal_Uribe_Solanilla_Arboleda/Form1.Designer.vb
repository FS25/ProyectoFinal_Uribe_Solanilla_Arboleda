<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Quices
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Quices))
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.SuspendLayout()
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombreUsuario.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombreUsuario.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtNombreUsuario.Location = New System.Drawing.Point(122, 182)
        Me.txtNombreUsuario.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(249, 46)
        Me.txtNombreUsuario.TabIndex = 0
        Me.txtNombreUsuario.Text = "Usuario"
        '
        'btnIngresar
        '
        Me.btnIngresar.BackColor = System.Drawing.Color.White
        Me.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnIngresar.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngresar.Location = New System.Drawing.Point(162, 359)
        Me.btnIngresar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(160, 59)
        Me.btnIngresar.TabIndex = 5
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txtPassword.Location = New System.Drawing.Point(122, 270)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(249, 46)
        Me.txtPassword.TabIndex = 7
        Me.txtPassword.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Vladimir Script", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(114, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(268, 48)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "BuzzFeed Quices"
        '
        'Quices
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(499, 491)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Quices"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "Quices"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
