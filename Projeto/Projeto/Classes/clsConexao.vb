Imports System.Data.SqlClient

Public Class clsConexao
    Public Overloads Shared Function GetConection() As SqlConnection
        Dim strCn As String = "Data Source=LAPTOP-VFKDI358;Initial Catalog=projetos;Integrated Security=True"
        Dim cn As SqlConnection = New SqlConnection(strCn)
        Try
            cn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return cn
    End Function
End Class
