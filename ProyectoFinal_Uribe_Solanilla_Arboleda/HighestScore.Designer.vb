<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighestScore
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvScores = New System.Windows.Forms.DataGridView()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.puntos = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tema = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnTerminar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(212, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 46)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Puntuaciones más Altas"
        '
        'dgvScores
        '
        Me.dgvScores.AllowUserToAddRows = False
        Me.dgvScores.AllowUserToDeleteRows = False
        Me.dgvScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvScores.BackgroundColor = System.Drawing.Color.White
        Me.dgvScores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvScores.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvScores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre, Me.puntos, Me.Tema})
        Me.dgvScores.Location = New System.Drawing.Point(82, 139)
        Me.dgvScores.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvScores.Name = "dgvScores"
        Me.dgvScores.ReadOnly = True
        Me.dgvScores.RowTemplate.Height = 28
        Me.dgvScores.Size = New System.Drawing.Size(641, 172)
        Me.dgvScores.TabIndex = 5
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre de Usuario"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'puntos
        '
        Me.puntos.HeaderText = "Puntaje"
        Me.puntos.Name = "puntos"
        Me.puntos.ReadOnly = True
        '
        'Tema
        '
        Me.Tema.HeaderText = "Tema"
        Me.Tema.Name = "Tema"
        Me.Tema.ReadOnly = True
        '
        'btnTerminar
        '
        Me.btnTerminar.BackColor = System.Drawing.Color.White
        Me.btnTerminar.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTerminar.Location = New System.Drawing.Point(332, 346)
        Me.btnTerminar.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTerminar.Name = "btnTerminar"
        Me.btnTerminar.Size = New System.Drawing.Size(142, 47)
        Me.btnTerminar.TabIndex = 6
        Me.btnTerminar.Text = "Terminar"
        Me.btnTerminar.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ProyectoFinal_Uribe_Solanilla_Arboleda.My.Resources.Resources.Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(21, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(64, 65)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'HighestScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.ProyectoFinal_Uribe_Solanilla_Arboleda.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(811, 450)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnTerminar)
        Me.Controls.Add(Me.dgvScores)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.Black
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "HighestScore"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "HighestScore"
        CType(Me.dgvScores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents dgvScores As DataGridView
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents puntos As DataGridViewTextBoxColumn
    Friend WithEvents Tema As DataGridViewTextBoxColumn
    Friend WithEvents btnTerminar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
