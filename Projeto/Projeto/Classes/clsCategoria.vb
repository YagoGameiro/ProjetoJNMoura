Imports System.Data.SqlClient
Imports Projeto.clsConexao

Public Class clsCategoria
    Public Shared Function BuscaCategorias(ByVal idUser As Integer) As Data.DataTable
        Dim sql As String = "SELECT * FROM Categorias WHERE IdUser = " & idUser & " OR IdUser IS NULL"
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

    Public Shared Function DescricaoCategoria(ByVal id As Integer) As String
        Dim sql As String = "SELECT Descricao FROM Categorias WHERE IdCategoria = " & id
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
        Return tb.Rows(0)("Descricao").ToString()
    End Function

    Public Shared Function ValidaCategoria(ByVal descricao As String) As Boolean
        Dim sql As String = "SELECT 1 FROM Categorias WHERE Descricao = '" & descricao & "'"
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

    Public Shared Function InsereCategoria(ByVal categoria As String, ByVal idUser As Integer)
        Dim sql As String = "INSERT INTO Categorias(Descricao, IdUser) values (@Categoria, @IdUser)"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        cmd.Parameters.Add("@Categoria", SqlDbType.VarChar).Value = categoria
        cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = idUser
        cmd.ExecuteNonQuery()
    End Function

    Public Shared Function BuscaCategoriaByDescricao(ByVal descricao As String) As Integer
        Dim sql As String = "SELECT IdCategoria FROM Categorias WHERE Descricao = '" & descricao & "'"
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
        Return tb.Rows(0)("IdCategoria")
    End Function

    Public Shared Function DeleteCategoriasByIdUser(ByVal idUser As Integer)
        Dim sql As String = "DELETE FROM Categorias WHERE IdUser = @IdUser"
        Dim dtr As SqlDataReader = Nothing
        Dim cn As SqlConnection = GetConection()
        Dim cmd As SqlCommand = New SqlCommand(sql, cn)
        cmd.Parameters.Add("@IdUser", SqlDbType.VarChar).Value = idUser
        cmd.ExecuteNonQuery()
    End Function
End Class
