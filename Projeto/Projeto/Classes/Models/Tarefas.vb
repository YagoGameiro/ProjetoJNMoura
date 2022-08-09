Public Class Tarefas
    Private Property _IdTarefa() As Integer
    Private Property _Descricao() As String
    Private Property _DataCriacao() As Date
    Private Property _DataConclusao() As Date
    Private Property _Prioridade() As Integer

    Private Property _Concluido() As Integer
    Private Property _IdCategoria() As Integer 'Classe Categorias
    Private Property _IdUser() As Integer 'Classe Usuarios

    Public Property IdTarefa() As Integer
        Get
            Return _IdTarefa
        End Get
        Set(value As Integer)
            _IdTarefa = value
        End Set
    End Property

    Public Property Descricao() As String
        Get
            Return _Descricao
        End Get
        Set(value As String)
            _Descricao = value
        End Set
    End Property

    Public Property DataCriacao() As Date
        Get
            Return _DataCriacao
        End Get
        Set(value As Date)
            _DataCriacao = value
        End Set
    End Property

    Public Property DataConclusao() As Date
        Get
            Return _DataConclusao
        End Get
        Set(value As Date)
            _DataConclusao = value
        End Set
    End Property

    Public Property Prioridade() As Integer
        Get
            Return _Prioridade
        End Get
        Set(value As Integer)
            _Prioridade = value
        End Set
    End Property

    Public Property Concluido() As Integer
        Get
            Return _Concluido
        End Get
        Set(value As Integer)
            _Concluido = value
        End Set
    End Property

    Public Property IdCategoria() As Integer
        Get
            Return _IdCategoria
        End Get
        Set(value As Integer)
            _IdCategoria = value
        End Set
    End Property

    Public Property IdUser() As Integer
        Get
            Return _IdUser
        End Get
        Set(value As Integer)
            _IdUser = value
        End Set
    End Property
End Class
