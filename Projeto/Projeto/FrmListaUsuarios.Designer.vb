<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmListaUsuarios
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
        Me.txtBuscaUsuario = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.lblUsuarioNaoEncontrado = New System.Windows.Forms.Label()
        Me.lblUserPlaceholder = New System.Windows.Forms.Label()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(235, 146)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Lista de usuários"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Usuário:"
        '
        'txtBuscaUsuario
        '
        Me.txtBuscaUsuario.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBuscaUsuario.Location = New System.Drawing.Point(238, 105)
        Me.txtBuscaUsuario.Name = "txtBuscaUsuario"
        Me.txtBuscaUsuario.Size = New System.Drawing.Size(299, 22)
        Me.txtBuscaUsuario.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnBuscar.Location = New System.Drawing.Point(552, 104)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(98, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnCadastrar.Location = New System.Drawing.Point(694, 103)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(234, 23)
        Me.btnCadastrar.TabIndex = 4
        Me.btnCadastrar.Text = "Cadastrar Novo Usuário"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'lblUsuarioNaoEncontrado
        '
        Me.lblUsuarioNaoEncontrado.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUsuarioNaoEncontrado.AutoSize = True
        Me.lblUsuarioNaoEncontrado.ForeColor = System.Drawing.Color.Red
        Me.lblUsuarioNaoEncontrado.Location = New System.Drawing.Point(325, 86)
        Me.lblUsuarioNaoEncontrado.Name = "lblUsuarioNaoEncontrado"
        Me.lblUsuarioNaoEncontrado.Size = New System.Drawing.Size(154, 16)
        Me.lblUsuarioNaoEncontrado.TabIndex = 5
        Me.lblUsuarioNaoEncontrado.Text = "Usuário não encontrado!"
        Me.lblUsuarioNaoEncontrado.Visible = False
        '
        'lblUserPlaceholder
        '
        Me.lblUserPlaceholder.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUserPlaceholder.AutoSize = True
        Me.lblUserPlaceholder.BackColor = System.Drawing.SystemColors.Window
        Me.lblUserPlaceholder.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.lblUserPlaceholder.Location = New System.Drawing.Point(243, 110)
        Me.lblUserPlaceholder.Name = "lblUserPlaceholder"
        Me.lblUserPlaceholder.Size = New System.Drawing.Size(149, 16)
        Me.lblUserPlaceholder.TabIndex = 6
        Me.lblUserPlaceholder.Text = "Digite o nome completo"
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.AllowUserToResizeColumns = False
        Me.dgvUsuarios.AllowUserToResizeRows = False
        Me.dgvUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Location = New System.Drawing.Point(239, 177)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersWidth = 51
        Me.dgvUsuarios.RowTemplate.Height = 24
        Me.dgvUsuarios.Size = New System.Drawing.Size(751, 234)
        Me.dgvUsuarios.TabIndex = 7
        '
        'FrmListaUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1278, 538)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Controls.Add(Me.lblUserPlaceholder)
        Me.Controls.Add(Me.lblUsuarioNaoEncontrado)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtBuscaUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmListaUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tarefas: Lista de Usuários"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBuscaUsuario As TextBox
    Friend WithEvents btnBuscar As Button
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents lblUsuarioNaoEncontrado As Label
    Friend WithEvents lblUserPlaceholder As Label
    Friend WithEvents dgvUsuarios As DataGridView
End Class
