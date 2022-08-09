Imports System.Data.SqlClient
Imports Projeto.clsConexao
Imports Projeto.clsTarefas
Imports Projeto.clsCategoria

Public Class clsUsuarios
    Public Shared Function BuscaListaUsuarios() As Data.DataTable
        Dim sql As String = "SELECT * FROM Usuarios ORDER BY NomeCompleto"
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

    Public Shared Function VerificaUsuarioByNome(ByVal nome As String) As Boolean
        Dim sql As String = "SELECT 1 FROM Usuarios WHERE NomeCompleto = '" & nome & "'"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        dtr = cmd.ExecuteReader
        Try
            If dtr.HasRows Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Public Shared Function BuscaUsuarioByNome(ByVal nome As String) As Data.DataTable
        Dim sql As String = "SELECT * FROM Usuarios WHERE NomeCompleto = '" & nome & "'"
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

    Public Shared Function BuscaUsuarioById(ByVal id As Integer) As Data.DataTable
        Dim sql As String = "SELECT * FROM Usuarios WHERE NomeCompleto = " & id & ""
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

    Public Shared Function BuscaUsuariosEmAberto(ByVal nome As String) As Data.DataTable
        Dim sql As String = "SELECT * FROM Usuarios WHERE NomeCompleto Like '" & nome & "%' ORDER BY NomeCompleto"
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

    Public Shared Function InsereUsuario(ByVal nome As String)
        Dim sql As String = "INSERT INTO Usuarios(NomeCompleto) values (@Nome)"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nome
        cmd.ExecuteNonQuery()
    End Function

    Public Shared Function DeleteUsuarioByNome(ByVal nome As String)
        Dim sql As String = "DELETE FROM Usuarios WHERE NomeCompleto = @Nome"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        cmd.Parameters.Add("@Nome", SqlDbType.VarChar).Value = nome
        cmd.ExecuteNonQuery()
    End Function

    Public Shared Function DeleteUsuarioById(ByVal id As Integer)
        DeleteTarefasByIdUser(id)
        DeleteCategoriasByIdUser(id)

        Dim sql As String = "DELETE FROM Usuarios WHERE IdUser = @Id"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = id
        cmd.ExecuteNonQuery()
    End Function
End Class
