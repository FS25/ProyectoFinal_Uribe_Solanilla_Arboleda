﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.dgvQuices = New System.Windows.Forms.DataGridView()
        Me.quiz = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.userName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.score = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.action = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.dgvQuices, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 40)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Quices"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(153, 416)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(492, 51)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Quiz 1 -"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(489, 14)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(128, 51)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "High Score"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.White
        Me.btnSalir.Font = New System.Drawing.Font("Arial Narrow", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(235, 316)
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
        Me.dgvQuices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvQuices.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.quiz, Me.userName, Me.score, Me.action})
        Me.dgvQuices.Location = New System.Drawing.Point(32, 121)
        Me.dgvQuices.Name = "dgvQuices"
        Me.dgvQuices.ReadOnly = True
        Me.dgvQuices.RowTemplate.Height = 24
        Me.dgvQuices.Size = New System.Drawing.Size(613, 150)
        Me.dgvQuices.TabIndex = 6
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
        'SeleccionQuices
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(677, 562)
        Me.ControlBox = False
        Me.Controls.Add(Me.dgvQuices)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "SeleccionQuices"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.Text = "SeleccionQuices"
        CType(Me.dgvQuices, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents btnSalir As Button
    Friend WithEvents dgvQuices As DataGridView
    Friend WithEvents quiz As DataGridViewTextBoxColumn
    Friend WithEvents userName As DataGridViewTextBoxColumn
    Friend WithEvents score As DataGridViewTextBoxColumn
    Friend WithEvents action As DataGridViewButtonColumn
End Class
