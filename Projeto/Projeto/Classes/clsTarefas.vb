Imports System.Data.SqlClient
Imports Projeto.clsConexao

Public Class clsTarefas
    Public Shared Function InsereTarefa(ByVal tarefa As Tarefas)
        Dim sql As String = "INSERT INTO Tarefas(Descricao, DataConclusao, Prioridade, IdCategoria, IdUser) "
        sql &= "values (@Descricao, @DataConclusao, @Prioridade, @IdCategoria, @IdUser)"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        cmd.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = tarefa.Descricao()
        cmd.Parameters.Add("@DataConclusao", SqlDbType.VarChar).Value = tarefa.DataConclusao()
        cmd.Parameters.Add("@Prioridade", SqlDbType.VarChar).Value = tarefa.Prioridade()
        cmd.Parameters.Add("@IdCategoria", SqlDbType.VarChar).Value = tarefa.IdCategoria()
        cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = tarefa.IdUser()
        cmd.ExecuteNonQuery()
    End Function

    Public Shared Function BuscaListaTarefas(ByVal id As Integer) As Data.DataTable
        Dim sql As String = "SELECT IdTarefa, CASE Prioridade WHEN 0 THEN 'Baixa' WHEN 1 THEN 'Média' WHEN 2 THEN 'Alta' END as 'Prioridade', "
        sql &= "t.Descricao, DataConclusao, c.Descricao as 'Categoria', CASE Concluido WHEN 0 THEN 'Pendente' WHEN 1 THEN 'Concluido' END AS 'Concluido', "
        sql &= "Concluido as ValueConcluido FROM Tarefas t INNER JOIN Categorias c on c.IdCategoria = t.IdCategoria "
        sql &= "WHERE t.IdUser = " & id & " ORDER BY ValueConcluido, DataConclusao, Prioridade, c.Descricao "
        Dim cn As SqlConnection = GetConection()
        Dim tb As New Data.DataTable
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            tb.Load(cmd.ExecuteReader)
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return tb
    End Function

    Public Shared Function BuscaListaTarefasFiltradas(ByVal id As Integer, ByVal condicao As String) As Data.DataTable
        Dim sql As String = "SELECT IdTarefa, CASE Prioridade WHEN 0 THEN 'Baixa' WHEN 1 THEN 'Média' WHEN 2 THEN 'Alta' END as 'Prioridade', "
        sql &= "t.Descricao, DataConclusao, c.Descricao as 'Categoria', CASE Concluido WHEN 0 THEN 'Pendente' WHEN 1 THEN 'Concluido' END AS 'Concluido', "
        sql &= "Concluido as ValueConcluido FROM Tarefas t INNER JOIN Categorias c on c.IdCategoria = t.IdCategoria "
        sql &= "WHERE t.IdUser = " & id & condicao
        sql &= "ORDER BY ValueConcluido, DataConclusao, Prioridade, c.Descricao "
        Dim cn As SqlConnection = GetConection()
        Dim tb As New Data.DataTable
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        Try
            GC.Collect()
            GC.WaitForPendingFinalizers()
            GC.Collect()
            tb.Load(cmd.ExecuteReader)
            cn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return tb
    End Function

    Public Shared Function UpdateTarefa(ByVal tarefa As Tarefas)
        Dim sql As String = "UPDATE Tarefas SET Descricao = @Descricao, DataConclusao = @DataConclusao, Prioridade = @Prioridade, "
        sql &= "IdCategoria = @IdCategoria, IdUser = @IdUser WHERE IdTarefa = @IdTarefa"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        cmd.Parameters.Add("@Descricao", SqlDbType.VarChar).Value = tarefa.Descricao()
        cmd.Parameters.Add("@DataConclusao", SqlDbType.VarChar).Value = tarefa.DataConclusao()
        cmd.Parameters.Add("@Prioridade", SqlDbType.VarChar).Value = tarefa.Prioridade()
        cmd.Parameters.Add("@IdCategoria", SqlDbType.VarChar).Value = tarefa.IdCategoria()
        cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = tarefa.IdUser()
        cmd.Parameters.Add("@IdTarefa", SqlDbType.VarChar).Value = tarefa.IdTarefa()
        cmd.ExecuteNonQuery()
    End Function

    Public Shared Function DeleteTarefasByIdUser(ByVal idUser As Integer)
        Dim sql As String = "DELETE FROM Tarefas WHERE IdUser = @IdUser"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = idUser
        cmd.ExecuteNonQuery()
    End Function

    Public Shared Function DeleteTarefasByIdTarefa(ByVal idTarefa As Integer)
        Dim sql As String = "DELETE FROM Tarefas WHERE IdTarefa = @IdTarefa"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        cmd.Parameters.Add("@IdTarefa", SqlDbType.VarChar).Value = idTarefa
        cmd.ExecuteNonQuery()
    End Function

    Public Shared Function ConcluiTarefa(ByVal idTarefa As Integer)
        Dim sql As String = "UPDATE Tarefas SET Concluido = 1 WHERE IdTarefa = @IdTarefa"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        cmd.Parameters.Add("@IdTarefa", SqlDbType.VarChar).Value = idTarefa
        cmd.ExecuteNonQuery()
    End Function
End Class
