<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTarefas
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.dtpDataTarefa = New System.Windows.Forms.DateTimePicker()
        Me.cboPrioridade = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddTarefa = New System.Windows.Forms.Button()
        Me.cboCategoria = New System.Windows.Forms.ComboBox()
        Me.dtpHoraTarefa = New System.Windows.Forms.DateTimePicker()
        Me.dgvTarefas = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnConcluir = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAlterar = New System.Windows.Forms.Button()
        CType(Me.dgvTarefas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(67, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Descrição"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(67, 105)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(176, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Data e Hora para conclusão"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(67, 64)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(276, 22)
        Me.txtDescricao.TabIndex = 2
        '
        'dtpDataTarefa
        '
        Me.dtpDataTarefa.Location = New System.Drawing.Point(67, 124)
        Me.dtpDataTarefa.Name = "dtpDataTarefa"
        Me.dtpDataTarefa.Size = New System.Drawing.Size(200, 22)
        Me.dtpDataTarefa.TabIndex = 3
        '
        'cboPrioridade
        '
        Me.cboPrioridade.FormattingEnabled = True
        Me.cboPrioridade.Location = New System.Drawing.Point(67, 189)
        Me.cboPrioridade.Name = "cboPrioridade"
        Me.cboPrioridade.Size = New System.Drawing.Size(121, 24)
        Me.cboPrioridade.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(67, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Prioridade"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(67, 233)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Categoria"
        '
        'btnAddTarefa
        '
        Me.btnAddTarefa.Location = New System.Drawing.Point(70, 308)
        Me.btnAddTarefa.Name = "btnAddTarefa"
        Me.btnAddTarefa.Size = New System.Drawing.Size(158, 38)
        Me.btnAddTarefa.TabIndex = 8
        Me.btnAddTarefa.Text = "Adicionar nova tarefa"
        Me.btnAddTarefa.UseVisualStyleBackColor = True
        '
        'cboCategoria
        '
        Me.cboCategoria.FormattingEnabled = True
        Me.cboCategoria.Location = New System.Drawing.Point(70, 252)
        Me.cboCategoria.Name = "cboCategoria"
        Me.cboCategoria.Size = New System.Drawing.Size(185, 24)
        Me.cboCategoria.TabIndex = 9
        '
        'dtpHoraTarefa
        '
        Me.dtpHoraTarefa.Location = New System.Drawing.Point(274, 124)
        Me.dtpHoraTarefa.Name = "dtpHoraTarefa"
        Me.dtpHoraTarefa.Size = New System.Drawing.Size(112, 22)
        Me.dtpHoraTarefa.TabIndex = 10
        '
        'dgvTarefas
        '
        Me.dgvTarefas.AllowUserToAddRows = False
        Me.dgvTarefas.AllowUserToDeleteRows = False
        Me.dgvTarefas.AllowUserToResizeColumns = False
        Me.dgvTarefas.AllowUserToResizeRows = False
        Me.dgvTarefas.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvTarefas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvTarefas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTarefas.Location = New System.Drawing.Point(457, 45)
        Me.dgvTarefas.Name = "dgvTarefas"
        Me.dgvTarefas.ReadOnly = True
        Me.dgvTarefas.RowHeadersWidth = 51
        Me.dgvTarefas.RowTemplate.Height = 24
        Me.dgvTarefas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTarefas.Size = New System.Drawing.Size(773, 249)
        Me.dgvTarefas.TabIndex = 11
        '
        'btnRefresh
        '
        Me.btnRefresh.Location = New System.Drawing.Point(457, 308)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(239, 38)
        Me.btnRefresh.TabIndex = 12
        Me.btnRefresh.Text = "Atualizar"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnConcluir
        '
        Me.btnConcluir.Location = New System.Drawing.Point(724, 308)
        Me.btnConcluir.Name = "btnConcluir"
        Me.btnConcluir.Size = New System.Drawing.Size(239, 38)
        Me.btnConcluir.TabIndex = 13
        Me.btnConcluir.Text = "Concluir tarefa"
        Me.btnConcluir.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(991, 308)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(239, 38)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Excluir tarefa"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAlterar
        '
        Me.btnAlterar.Location = New System.Drawing.Point(234, 308)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(158, 38)
        Me.btnAlterar.TabIndex = 8
        Me.btnAlterar.Text = "Alterar tarefa"
        Me.btnAlterar.UseVisualStyleBackColor = True
        '
        'frmTarefas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1477, 432)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnConcluir)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvTarefas)
        Me.Controls.Add(Me.dtpHoraTarefa)
        Me.Controls.Add(Me.cboCategoria)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.btnAddTarefa)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cboPrioridade)
        Me.Controls.Add(Me.dtpDataTarefa)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTarefas"
        Me.Text = "Tarefas"
        CType(Me.dgvTarefas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents dtpDataTarefa As DateTimePicker
    Friend WithEvents cboPrioridade As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddTarefa As Button
    Friend WithEvents cboCategoria As ComboBox
    Friend WithEvents dtpHoraTarefa As DateTimePicker
    Friend WithEvents dgvTarefas As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents btnConcluir As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAlterar As Button
End Class
