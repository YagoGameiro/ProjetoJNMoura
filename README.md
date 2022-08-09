# ProjetoJNMoura

Banco usado: Sql server

CREATE TABLE Usuarios
(
	IdUser INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	NomeCompleto VARCHAR(50)
)

CREATE TABLE Tarefas
(
	IdTarefa INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(30),
	DataCriacao DATE DEFAULT GETDATE(),
	DataConclusao DATETIME,
	Prioridade INT,  --Baixa = 0, Média = 1, Alta = 2
	Concluido INT DEFAULT 0, --0 Não concluido, 1 concluido
	IdCategoria INT NOT NULL FOREIGN KEY REFERENCES Categorias(IdCategoria),
	IdUser INT NOT NULL FOREIGN KEY REFERENCES Usuarios(IdUser)
)

CREATE TABLE Categorias
(
	IdCategoria INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	Descricao VARCHAR(30),
	IdUser INT FOREIGN KEY REFERENCES Usuarios(IdUser)
)

--Categorias genericas
INSERT INTO Categorias(Descricao) values ('Domestica')
INSERT INTO Categorias(Descricao) values ('Profissional')
INSERT INTO Categorias(Descricao) values ('Sem Categoria')

/*
EXEC sp_updateextendedproperty 
@name = N'MS_Description', @value = 'Baixa = 0, Média = 1, Alta = 2',
@level0type = N'Schema', @level0name = 'projetos', 
@level1type = N'Table',  @level1name = 'Tarefas', 
@level2type = N'Column', @level2name = 'Prioridade';

SELECT @@SERVERNAME as 'Server Name',@@SERVICENAME as 'Service Name'
*/

SELECT * FROM Usuarios

--DELETE FROM Usuarios

SELECT * FROM Usuarios WHERE NomeCompleto Like '%' ORDER BY NomeCompleto

SELECT * FROM Categorias

SELECT IdTarefa, CASE Prioridade WHEN 0 THEN 'Baixa' WHEN 1 THEN 'Média' WHEN 2 THEN 'Alta' END as 'Prioridade',
t.Descricao, DataConclusao, c.Descricao as 'Categoria', CASE Concluido WHEN 0 THEN 'Pendente' WHEN 1 THEN 'Concluido' END AS 'Concluido', 
Concluido as ValueConcluido FROM Tarefas t 
INNER JOIN Categorias c
on c.IdCategoria = t.IdCategoria
--WHERE IdUser = 17 
ORDER BY ValueConcluido, DataConclusao, Prioridade, c.Descricao 


