# Unico
Sistema desenvolvido com as praticas do Clean Arquiteture com as Camadas
 1 - API(EndPoints)
 2 - Application(Contato do externo com Interno, criando assim segurança)
 3 - Domain(Core do projeto, bem como dominio e base para repositorios)
 4 - Domain.Test( Implementacao de XUnit para cobertura de codigo e teste unitarios)
 5 - Infra.Data (Camada de acesso ao banco de dados)
 6 - Infra.Data.IoC( Injeção de dependencia)
 7 - WebUI (Camada Front-end)

 banco de dados criado uma tabela foi gerado com a connection string na qual deve ser mduada e direcionada com o banco local
 (O mesmo fica localizado na Camada 6 (Infra.Data.Ioc) 

 Script para criação da tabela no banco de dados:
 USE GRUPOUNICO
 
CREATE TABLE Tarefa
(
Id UNIQUEIDENTIFIER NOT NULL PRIMARY KEY,
Titulo VARCHAR(100) NOT NULL,
Descricao VARCHAR(MAX) NOT NULL,
DataVencimento DATETIME NOT NULL,
Status VARCHAR(10) NOT NULL
)

Foram feitas os testes unitarios para os metodos selecionados.
A cobertura está tanto para Controller quanto para a camada Application e Repository

