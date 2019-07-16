<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Puntaje
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(284, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(223, 110)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "####"
        '
        'btnTerminar
        '
        Me.btnTerminar.BackColor = System.Drawing.Color.White
        Me.btnTerminar.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminar.Location = New System.Drawing.Point(320, 322)
        Me.btnTerminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(160, 59)
        Me.btnTerminar.TabIndex = 2
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(293, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 60)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Puntaje"
        '
        'Puntaje
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.ProyectoFinal_Uribe_Solanilla_Arboleda.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Puntaje"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "Puntaje"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents btnTerminar As Button
    Friend WithEvents Label1 As Label
End Class
