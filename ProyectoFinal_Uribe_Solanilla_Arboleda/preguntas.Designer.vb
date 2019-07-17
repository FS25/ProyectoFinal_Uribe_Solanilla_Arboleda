<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Preguntas
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
        Me.components = New System.ComponentModel.Container()
        Me.lblQuest = New System.Windows.Forms.Label()
        Me.lblPreguntaNum = New System.Windows.Forms.Label()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.btnSiguiente = New System.Windows.Forms.Button()
        Me.BB_GamesDataSet = New ProyectoFinal_Uribe_Solanilla_Arboleda.BB_GamesDataSet()
        Me.PreguntaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PreguntaTableAdapter = New ProyectoFinal_Uribe_Solanilla_Arboleda.BB_GamesDataSetTableAdapters.preguntaTableAdapter()
        Me.TableAdapterManager = New ProyectoFinal_Uribe_Solanilla_Arboleda.BB_GamesDataSetTableAdapters.TableAdapterManager()
        Me.RespuestaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RespuestaTableAdapter = New ProyectoFinal_Uribe_Solanilla_Arboleda.BB_GamesDataSetTableAdapters.respuestaTableAdapter()
        CType(Me.BB_GamesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PreguntaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RespuestaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblQuest
        '
        Me.lblQuest.AutoSize = True
        Me.lblQuest.BackColor = System.Drawing.Color.Transparent
        Me.lblQuest.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblQuest.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblQuest.Location = New System.Drawing.Point(35, 142)
        Me.lblQuest.Name = "lblQuest"
        Me.lblQuest.Size = New System.Drawing.Size(736, 18)
        Me.lblQuest.TabIndex = 0
        Me.lblQuest.Text = "Los movimientos de la cabeza los podemos utilizar para expresarnos, algo importan" &
    "te para las personas "
        '
        'lblPreguntaNum
        '
        Me.lblPreguntaNum.AutoSize = True
        Me.lblPreguntaNum.BackColor = System.Drawing.Color.Transparent
        Me.lblPreguntaNum.Font = New System.Drawing.Font("Arial Narrow", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreguntaNum.ForeColor = System.Drawing.Color.White
        Me.lblPreguntaNum.Location = New System.Drawing.Point(50, 54)
        Me.lblPreguntaNum.Name = "lblPreguntaNum"
        Me.lblPreguntaNum.Size = New System.Drawing.Size(181, 46)
        Me.lblPreguntaNum.TabIndex = 1
        Me.lblPreguntaNum.Text = "Pregunta #"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton1.Location = New System.Drawing.Point(105, 242)
        Me.RadioButton1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(128, 22)
        Me.RadioButton1.TabIndex = 2
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton2.Location = New System.Drawing.Point(105, 290)
        Me.RadioButton2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(128, 22)
        Me.RadioButton2.TabIndex = 3
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = False
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.RadioButton3.Location = New System.Drawing.Point(105, 338)
        Me.RadioButton3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(128, 22)
        Me.RadioButton3.TabIndex = 4
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "RadioButton3"
        Me.RadioButton3.UseVisualStyleBackColor = False
        '
        'btnSiguiente
        '
        Me.btnSiguiente.BackColor = System.Drawing.Color.White
        Me.btnSiguiente.Font = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSiguiente.Location = New System.Drawing.Point(579, 306)
        Me.btnSiguiente.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(158, 55)
        Me.btnSiguiente.TabIndex = 5
        Me.btnSiguiente.Text = "Siguiente"
        Me.btnSiguiente.UseVisualStyleBackColor = False
        '
        'BB_GamesDataSet
        '
        Me.BB_GamesDataSet.DataSetName = "BB_GamesDataSet"
        Me.BB_GamesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PreguntaBindingSource
        '
        Me.PreguntaBindingSource.DataMember = "pregunta"
        Me.PreguntaBindingSource.DataSource = Me.BB_GamesDataSet
        '
        'PreguntaTableAdapter
        '
        Me.PreguntaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.preguntaTableAdapter = Me.PreguntaTableAdapter
        Me.TableAdapterManager.quiz_usuarioTableAdapter = Nothing
        Me.TableAdapterManager.quizTableAdapter = Nothing
        Me.TableAdapterManager.respuesta_usuarioTableAdapter = Nothing
        Me.TableAdapterManager.respuestaTableAdapter = Nothing
        Me.TableAdapterManager.temaTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = ProyectoFinal_Uribe_Solanilla_Arboleda.BB_GamesDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.usuarioTableAdapter = Nothing
        '
        'RespuestaBindingSource
        '
        Me.RespuestaBindingSource.DataMember = "respuesta"
        Me.RespuestaBindingSource.DataSource = Me.BB_GamesDataSet
        '
        'RespuestaTableAdapter
        '
        Me.RespuestaTableAdapter.ClearBeforeFill = True
        '
        'Preguntas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BackgroundImage = Global.ProyectoFinal_Uribe_Solanilla_Arboleda.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(811, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSiguiente)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.lblPreguntaNum)
        Me.Controls.Add(Me.lblQuest)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Preguntas"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Preguntas"
        CType(Me.BB_GamesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PreguntaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RespuestaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblQuest As Label
    Friend WithEvents lblPreguntaNum As Label
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents btnSiguiente As Button
    Friend WithEvents BB_GamesDataSet As BB_GamesDataSet
    Friend WithEvents PreguntaBindingSource As BindingSource
    Friend WithEvents PreguntaTableAdapter As BB_GamesDataSetTableAdapters.preguntaTableAdapter
    Friend WithEvents TableAdapterManager As BB_GamesDataSetTableAdapters.TableAdapterManager
    Friend WithEvents RespuestaBindingSource As BindingSource
    Friend WithEvents RespuestaTableAdapter As BB_GamesDataSetTableAdapters.respuestaTableAdapter
End Class
