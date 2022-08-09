Imports Projeto.clsUsuarios

Public Class FrmListaUsuarios
    Private Sub FrmListaUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CarregaGrid()
    End Sub

    Private Sub BuscaUsuario()
        lblUsuarioNaoEncontrado.Visible = False
        Dim nome As String = Me.txtBuscaUsuario.Text

        If nome = String.Empty OrElse String.IsNullOrWhiteSpace(nome) Then
            CarregaGrid()
        Else
            dgvUsuarios.Columns.Clear()
            With dgvUsuarios
                .DataSource = BuscaUsuariosEmAberto(nome)
                .Columns(0).Visible = False
                .RowHeadersVisible = False
                .ColumnHeadersVisible = False
                .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill

                If dgvUsuarios.Rows.Count = 0 Then
                    lblUsuarioNaoEncontrado.Visible = True
                    Exit Sub
                End If

                Dim btn As New DataGridViewButtonColumn()
                .Columns.Add(btn)
                btn.Text = "Verificar tarefas"
                btn.Name = "btnTarefas"
                btn.UseColumnTextForButtonValue = True

                Dim btn2 As New DataGridViewButtonColumn()
                .Columns.Add(btn2)
                btn2.Text = "Excluir usuário"
                btn2.Name = "btnExcluir"
                btn2.UseColumnTextForButtonValue = True
            End With
        End If

        If dgvUsuarios.Rows.Count = 0 Then
            MessageBox.Show("Lista de usuários vazia.", "Nenhum registro encontrado", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        BuscaUsuario()
    End Sub

    Private Sub btnCadastrar_Click(sender As Object, e As EventArgs) Handles btnCadastrar.Click
        lblUsuarioNaoEncontrado.Visible = False
        Dim nome As String = Me.txtBuscaUsuario.Text

        If nome.Length <= 8 OrElse String.IsNullOrWhiteSpace(nome) Then
            MessageBox.Show("Digite o nome completo do usuário", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If VerificaUsuarioByNome(nome) Then
            MessageBox.Show("Usuário já existe", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        InsereUsuario(nome)

        If VerificaUsuarioByNome(nome) Then
            MessageBox.Show("Cadastro efetuado com sucesso.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Não foi possivel cadastrar usuário. Tente novamente mais tarde.", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        CarregaGrid()

    End Sub

    Private Sub txtBuscaUsuario_TextChanged(sender As Object, e As EventArgs) Handles txtBuscaUsuario.TextChanged
        If Me.txtBuscaUsuario.TextLength > 0 Then
            lblUserPlaceholder.Visible = False
        Else
            lblUserPlaceholder.Visible = True
        End If
    End Sub

    Private Sub CarregaGrid()
        dgvUsuarios.Columns.Clear()

        With dgvUsuarios
            .DataSource = BuscaListaUsuarios()
            .Columns(0).Visible = False
            .RowHeadersVisible = False
            .ColumnHeadersVisible = False
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill

            Dim btn As New DataGridViewButtonColumn()
            .Columns.Add(btn)
            btn.Text = "Verificar tarefas"
            btn.Name = "btnTarefas"
            btn.UseColumnTextForButtonValue = True

            Dim btn2 As New DataGridViewButtonColumn()
            .Columns.Add(btn2)
            btn2.Text = "Excluir usuário"
            btn2.Name = "btnExcluir"
            btn2.UseColumnTextForButtonValue = True
        End With
    End Sub

    Private Sub dgvUsuarios_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentClick
        Dim id As Integer = dgvUsuarios.Rows(e.RowIndex).Cells(0).Value
        Dim nome As String = dgvUsuarios.Rows(e.RowIndex).Cells(1).Value

        If TypeOf sender.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 2 Then 'Exibe tarefas do usuário
            Dim tarefas As New frmTarefas
            tarefas.IdUser = id
            tarefas.ShowDialog()
        ElseIf TypeOf sender.Columns(e.ColumnIndex) Is DataGridViewButtonColumn AndAlso e.ColumnIndex = 3 Then 'Excluir linha

            DeleteUsuarioById(id)
            If VerificaUsuarioByNome(nome) Then
                MessageBox.Show("Ocorreu algum erro ao tenta excluir o usuário " & nome, "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MessageBox.Show("Usuário excluído com sucesso.", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information)
                CarregaGrid()
            End If
        End If
    End Sub

    Private Sub txtBuscaUsuario_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscaUsuario.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            BuscaUsuario()
        End If
    End Sub
End Class
