-- SQL
-- DML e DDL

-- DDL - Data Definitio Language
-- CREATE
-- ALTER
-- DROP	

--DATABASE ou TABLES
-- DML - Data Manipulation Language
-- INSERT
-- DELETE
-- 

-- criar um banco de dados

create DATABASE atosUfn

-- criar uma tabela

create TABLE alunos
(
MATRICULA VARCHAR (12) PRIMARY KEY, -- PRIMARY KEY (O VALOR NÃO PODE SER REPETIR)
NOME VARCHAR (50) not null,
CURSO VARCHAR(20) not null,
TURNO VARCHAR(25),
IDADE INTEGER,
ESTADO VARCHAR(2)
)

-- remover uma tabela

DROP TABLE alunos

--alter
ALTER TABLE alunos ADD altura INTEGER
ALTER TABLE alunos DROP COLUMN idade

-------------------------------------------

create TABLE autores
(
id integer primary key identity, 
nome varchar(50) not null,
nacionalidade varchar(30)
)

create TABLE livros
(
id integer primary key identity,
titulo varchar(100) not null,
paginas integer,
fk_autor integer,
foreign key (fk_autor) references autores (id)
)

-- remover uma tabela
drop table livros
drop table autores