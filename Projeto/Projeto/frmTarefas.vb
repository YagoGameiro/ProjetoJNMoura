Imports Projeto.clsCategoria
Imports Projeto.clsTarefas
Public Class frmTarefas

    Public Shared idUser As Integer
    Private selectedRow As Integer = -1

    Private Sub frmTarefas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtpHoraTarefa.Format = DateTimePickerFormat.Time
        dtpHoraTarefa.ShowUpDown = True

        'Carrega combobox prioridades
        cboPrioridade.ValueMember = "Id"
        cboPrioridade.DisplayMember = "Prioridade"
        Dim tb As New DataTable
        tb.Columns.Add("Id", GetType(Integer))
        tb.Columns.Add("Prioridade", GetType(String))
        tb.Rows.Add(0, "Baixa")
        tb.Rows.Add(1, "Média")
        tb.Rows.Add(2, "Alta")
        cboPrioridade.DataSource = tb

        CarregaCategorias()

        CarregaGrid()
    End Sub

    Private Sub CarregaGrid()
        With dgvTarefas
            .DataSource = BuscaListaTarefas(idUser)
            .RowHeadersVisible = False

            If .DataSource.Rows.Count = 0 Then
                .ColumnHeadersVisible = False
                Exit Sub
            End If
            .Rows(0).Selected = False
            .Columns(0).Visible = False
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(6).Visible = False
        End With

    End Sub

    Private Sub CarregaCategorias()
        Dim tb As New Data.DataTable
        tb = BuscaCategorias(idUser)

        cboCategoria.ValueMember = "IdCategoria"
        cboCategoria.DisplayMember = "Descricao"
        cboCategoria.DataSource = tb
    End Sub

    Private Sub btnAddTarefa_Click(sender As Object, e As EventArgs) Handles btnAddTarefa.Click
        If txtDescricao.Text = String.Empty OrElse String.IsNullOrWhiteSpace(txtDescricao.Text) Then
            MessageBox.Show("Digite uma descição valida para a tarefa", "Adicionar tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim data As String = dtpDataTarefa.Value.Date & " " & dtpHoraTarefa.Value.TimeOfDay.ToString()
        If data < Date.Now Then
            MessageBox.Show("Data da Conclusão deve ser maior que horário atual.", "Adicionar tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim tarefa As New Tarefas
        tarefa.Descricao() = txtDescricao.Text
        tarefa.DataConclusao() = data
        tarefa.Prioridade() = cboPrioridade.SelectedValue
        Dim IdCategoria As Integer = cboCategoria.SelectedValue
        Dim descricaoCategoria As String = cboCategoria.Text

        If descricaoCategoria = String.Empty OrElse String.IsNullOrWhiteSpace(descricaoCategoria) Then
            MessageBox.Show("Favor preencher uma categoria", "Categoria em branco", MessageBoxButtons.OK)
            Exit Sub
        End If

        If Not ValidaCategoria(descricaoCategoria) Then
            Dim result As DialogResult = MessageBox.Show("Categoria não existe, Deseja criar uma nova categoria?", "Nova Categoria", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                InsereCategoria(descricaoCategoria, idUser)
                IdCategoria = BuscaCategoriaByDescricao(descricaoCategoria)
            Else
                Exit Sub
            End If
        End If
        tarefa.IdCategoria() = IdCategoria
        tarefa.IdUser() = idUser

        InsereTarefa(tarefa)
        MessageBox.Show("Tarefa adicionada com sucesso", "Adicionar tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        CarregaCategorias()
        CarregaGrid()
    End Sub

    Private Sub dgvTarefas_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles dgvTarefas.RowPrePaint
        ' dont do the NewRow
        If e.RowIndex < 0 Then Return

        If Convert.ToInt32(dgvTarefas.Rows(e.RowIndex).Cells(6).Value) = 1 Then
            dgvTarefas.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightGreen
        ElseIf Convert.ToDateTime(dgvTarefas.Rows(e.RowIndex).Cells(3).Value) < Date.Now Then
            dgvTarefas.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.MistyRose
        End If
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        CarregaGrid()
    End Sub

    Private Sub btnConcluir_Click(sender As Object, e As EventArgs) Handles btnConcluir.Click
        If selectedRow < 0 Then
            MessageBox.Show("Selecione uma tarefa para concluir.", "Concluir Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        ConcluiTarefa(dgvTarefas.Rows(selectedRow).Cells(0).Value)
        CarregaGrid()
    End Sub

    Private Sub dgvTarefas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvTarefas.CellClick
        If e.RowIndex < 0 Then Return
        selectedRow = e.RowIndex

        txtDescricao.Text = dgvTarefas.Rows(selectedRow).Cells(2).Value
        dtpDataTarefa.Value = Convert.ToDateTime(dgvTarefas.Rows(selectedRow).Cells(3).Value)
        dtpHoraTarefa.Value = Convert.ToDateTime(dgvTarefas.Rows(selectedRow).Cells(3).Value)
        If dgvTarefas.Rows(selectedRow).Cells(1).Value = "Baixa" Then
            cboPrioridade.SelectedValue = 0
        ElseIf dgvTarefas.Rows(selectedRow).Cells(1).Value = "Média" Then
            cboPrioridade.SelectedValue = 1
        ElseIf dgvTarefas.Rows(selectedRow).Cells(1).Value = "Alta" Then
            cboPrioridade.SelectedValue = 2
        End If

        cboCategoria.SelectedValue = BuscaCategoriaByDescricao((dgvTarefas.Rows(selectedRow).Cells(4).Value))
    End Sub

    Private Sub btnAlterar_Click(sender As Object, e As EventArgs) Handles btnAlterar.Click
        If selectedRow < 0 Then
            MessageBox.Show("Selecione uma tarefa para alterar", "Alterar Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        If txtDescricao.Text = String.Empty OrElse String.IsNullOrWhiteSpace(txtDescricao.Text) Then
            MessageBox.Show("Digite uma descição valida para a tarefa", "Adicionar tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        Dim data As String = dtpDataTarefa.Value.Date & " " & dtpHoraTarefa.Value.TimeOfDay.ToString()
        If data < Date.Now Then
            MessageBox.Show("Data da Conclusão deve ser maior que horário atual.", "Adicionar tarefa", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Dim tarefa As New Tarefas
        tarefa.Descricao() = txtDescricao.Text
        tarefa.DataConclusao() = data
        tarefa.Prioridade() = cboPrioridade.SelectedValue
        Dim IdCategoria As Integer = cboCategoria.SelectedValue
        Dim descricaoCategoria As String = cboCategoria.Text

        If descricaoCategoria = String.Empty OrElse String.IsNullOrWhiteSpace(descricaoCategoria) Then
            MessageBox.Show("Favor preencher uma categoria", "Categoria em branco", MessageBoxButtons.OK)
            Exit Sub
        End If

        If Not ValidaCategoria(descricaoCategoria) Then
            Dim result As DialogResult = MessageBox.Show("Categoria não existe, Deseja criar uma nova categoria?", "Nova Categoria", MessageBoxButtons.YesNoCancel)
            If result = DialogResult.Yes Then
                InsereCategoria(descricaoCategoria, idUser)
                IdCategoria = BuscaCategoriaByDescricao(descricaoCategoria)
            Else
                Exit Sub
            End If
        End If
        tarefa.IdCategoria() = IdCategoria
        tarefa.IdUser() = idUser

        tarefa.IdTarefa = dgvTarefas.Rows(selectedRow).Cells(0).Value

        UpdateTarefa(tarefa)
        MessageBox.Show("Tarefa alterada com sucesso", "Alterar tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        CarregaCategorias()
        CarregaGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If selectedRow < 0 Then
            MessageBox.Show("Selecione uma tarefa para alterar", "Alterar Tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If

        DeleteTarefasByIdTarefa(dgvTarefas.Rows(selectedRow).Cells(0).Value)
        MessageBox.Show("Tarefa excluida com sucesso", "Excluir tarefa", MessageBoxButtons.OK, MessageBoxIcon.Information)
        CarregaCategorias()
        CarregaGrid()
    End Sub

    Private Sub dgvTarefas_CellMouseDoubleClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dgvTarefas.CellMouseDoubleClick
        If e.ColumnIndex < 0 Then Return

        Dim coluna As String = sender.columns(e.ColumnIndex).headercell.value
        Dim filtro As New frmFiltro
        filtro.lblColuna.Text = coluna
        filtro.ShowDialog()
        Dim result As String = filtro.txtFiltro.Text
        Dim condicao As String

        If coluna = "Prioridade" Then
            If result.ToLower() = "alta" Then
                result = 2
            ElseIf result.ToLower() = "média" Or result.ToLower() = "media" Then
                result = 1
            ElseIf result.ToLower() = "baixa" Then
                result = 0
            ElseIf Not result = String.Empty Then
                result = 9 'Não acha nada
            End If

        ElseIf coluna = "Concluido" Then
            If result.ToLower() = "pendente" Then
                result = 0
            ElseIf result.ToLower() = "concluido" Then
                result = 1
            End If
        ElseIf coluna = "Descricao" Then
            coluna = "t.Descricao"
        ElseIf coluna = "Categoria" Then
            coluna = "c.Descricao"
        End If

        If Not result = String.Empty Then
            condicao = " AND " & coluna & " = '" & result & "'"
        End If

        With dgvTarefas
            .DataSource = BuscaListaTarefasFiltradas(idUser, condicao)
            .RowHeadersVisible = False

            If .DataSource.Rows.Count = 0 Then
                Exit Sub
            End If
            .Rows(0).Selected = False
            .Columns(0).Visible = False
            .Columns(2).AutoSizeMode = DataGridViewAutoSizeColumnsMode.Fill
            .Columns(6).Visible = False
        End With
    End Sub
End Class