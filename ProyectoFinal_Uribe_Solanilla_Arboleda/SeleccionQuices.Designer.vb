<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SeleccionQuices
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
        Me.btnHighScore = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvQuices = New System.Windows.Forms.DataGridView()
        Me.qId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.quiz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.dgvQuices, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(121, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quices"
        '
        'btnHighScore
        '
        Me.btnHighScore.BackColor = System.Drawing.Color.White
        Me.btnHighScore.Font = New System.Drawing.Font("Arial", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHighScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnHighScore.Location = New System.Drawing.Point(603, 39)
        Me.btnHighScore.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHighScore.Name = "btnHighScore"
        Me.btnHighScore.Size = New System.Drawing.Size(128, 51)
        Me.btnHighScore.TabIndex = 4
        Me.btnHighScore.Text = "Mejores Puntajes"
        Me.btnHighScore.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Font = New System.Drawing.Font("Arial", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(298, 316)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(182, 40)
        Me.btnSalir.TabIndex = 5
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'dgvQuices
        '
        Me.dgvQuices.AllowUserToAddRows = False
        Me.dgvQuices.AllowUserToDeleteRows = False
        Me.dgvQuices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvQuices.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvQuices.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvQuices.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvQuices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.qId, Me.quiz, Me.userName, Me.score, Me.action})
        Me.dgvQuices.Cursor = System.Windows.Forms.Cursors.SizeWE
        Me.dgvQuices.Location = New System.Drawing.Point(76, 123)
        Me.dgvQuices.Name = "dgvQuices"
        Me.dgvQuices.ReadOnly = True
        Me.dgvQuices.RowTemplate.Height = 24
        Me.dgvQuices.Size = New System.Drawing.Size(655, 150)
        Me.dgvQuices.TabIndex = 6
        '
        'qId
        '
        Me.qId.HeaderText = "ID"
        Me.qId.Name = "qId"
        Me.qId.ReadOnly = True
        '
        'quiz
        '
        Me.quiz.HeaderText = "Quiz"
        Me.quiz.Name = "quiz"
        Me.quiz.ReadOnly = True
        '
        'userName
        '
        Me.userName.HeaderText = "Mejor Jugador"
        Me.userName.Name = "userName"
        Me.userName.ReadOnly = True
        '
        'score
        '
        Me.score.HeaderText = "Puntaje"
        Me.score.Name = "score"
        Me.score.ReadOnly = True
        '
        'action
        '
        Me.action.HeaderText = "Jugar"
        Me.action.Name = "action"
        Me.action.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.ProyectoFinal_Uribe_Solanilla_Arboleda.My.Resources.Resources.Logo
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(25, 15)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 75)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'SeleccionQuices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.ProyectoFinal_Uribe_Solanilla_Arboleda.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(793, 403)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.dgvQuices)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnHighScore)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SeleccionQuices"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SeleccionQuices"
        CType(Me.dgvQuices, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnHighScore As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgvQuices As DataGridView
    Friend WithEvents qId As DataGridViewTextBoxColumn
    Friend WithEvents quiz As DataGridViewTextBoxColumn
    Friend WithEvents userName As DataGridViewTextBoxColumn
    Friend WithEvents score As DataGridViewTextBoxColumn
    Friend WithEvents action As DataGridViewButtonColumn
    Friend WithEvents PictureBox1 As PictureBox
End Class
