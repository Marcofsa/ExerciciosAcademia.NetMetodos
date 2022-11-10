
CREATE DATABASE Departamento_db


use Departamento_db


CREATE TABLE Departamento 
(
idDepartamento int not null identity,
nome varchar (50) not null,
localizacao varchar (50) not null,
orcamento varchar (50) not null,

primary key (idDepartamento)

);

CREATE TABLE Empregado
(
idEmpregado int not null,
nome varchar(50) not null,
idGerencia int null,
funcao varchar(50) null,
Departamento_idDepartamento int not null,
dataAdmissao date not null,
salario int null, 
comissaoVendas int null,

primary key (Departamento_idDepartamento),
index fk_Empregado_Departamento_idx (departamento_idDepartamento ASC),

CONSTRAINT fk_Empregado_Departamento
foreign key (Departamento_idDepartamento)
references Departamento
on delete no action
on update no action
);

INSERT INTO Departamento VALUES('Banco de Dados','Porto Alegre','2346');
INSERT INTO Departamento VALUES('Balconistas','Pelotas','10000');
INSERT INTO Departamento VALUES('Inteligência Artific','Pelotas','333');
INSERT INTO Departamento VALUES('Compiladores','Novo Hamburgo','5050');
INSERT INTO Departamento VALUES('Redes','Taquara','12122');
--------------------------------------------------------------------------------
INSERT INTO Empregado VALUES('Mariewa',NULL,'Gerente','1','2000-04-05','2300','0');
INSERT INTO Empregado VALUES('Zico','1','Operário','1','1999-08-13','100','0');
INSERT INTO Empregado VALUES('Lula',NULL,'Presidente','5','1950-01-01','10000','0');
INSERT INTO Empregado VALUES('Vera Fixer','5','Balconista','2','1999-05-05','3300','0');
INSERT INTO Empregado VALUES('Luana Pyovany',NULL,'Gerente','2','1998-06-23','2300','0');
INSERT INTO Empregado VALUES('Daniela Schicarelli',NULL,'Gerente','3','1999-10-10','2300','0');
INSERT INTO Empregado VALUES('Luize Altenhofen',NULL,'Gerente','4','1999-04-26','2300','0');
INSERT INTO Empregado VALUES('Helo Pinheiro',NULL,'Gerente','5','1997-09-25','2300','0');
INSERT INTO Empregado VALUES('Pelé','1','Operário','1','2000-09-09','100',NULL);
INSERT INTO Empregado VALUES('Romário','1','Operário','5','2001-12-25','100','0');
INSERT INTO Empregado VALUES('Malu Mader','5','Balconista','2','2001-10-20','3400','0');
INSERT INTO Empregado VALUES('Antônio Fagundes','7','Vendedor','3','2002-12-22','5000','10');
select *
from Departamento;

select Empregado.nome, Empregado.funcao
from Empregado
where Empregado.Departamento_idDepartamento > 3;

select Empregado.nome, Empregado.funcao
from Empregado
Where Empregado.funcao = 'Gerente';

select Departamento.nome, Departamento.orcamento * 12
from Departamento
where Departamento.orcamento >= 10000;

select Departamento.nome 'DEPARTAMENTO', Departamento.orcamento * 12 'ORÇAMENTO ANUAL'
from Departamento
where Departamento.orcamento > 5000;

select distinct Empregado.funcao
from Empregado;

select Empregado.nome 'NOME DO EMPREGADO', Empregado.funcao 'CARGO'
from Empregado
order by Empregado.nome;

select Empregado.nome 'NOME DO EMPREGADO', Empregado.funcao 'CARGO'
from Empregado
order by Empregado.nome desc;

select Empregado.nome, Empregado.salario
from Empregado
where Empregado.salario between 20 and 30;

select Empregado.nome, Empregado.Departamento_idDepartamento
from Empregado
where Empregado.Departamento_idDepartamento in (3,5);

select Empregado.nome, Empregado.funcao
from Empregado
where Empregado.nome like 'L%';

select Empregado.nome, Empregado.funcao
from Empregado
where Empregado.comissaoVendas is null;

select Empregado.nome, Empregado.funcao
from Empregado
where Empregado.comissaoVendas is null;

select Empregado.nome, Empregado.salario, Empregado.funcao
from Empregado
where Empregado.salario between 3400 and 5000
and Empregado.funcao = 'balconista';

select Empregado.nome, Empregado.salario, Empregado.funcao
from Empregado
where Empregado.salario between 3400 and 5000
or Empregado.funcao = 'balconista';

select lower (Empregado.nome)
from Empregado;

select SUBSTRING(Empregado.nome,1,5) from Empregado;

select AVG (Empregado.comissaoVendas) from Empregado;
select MIN (Empregado.comissaoVendas) from Empregado;
select MAX (Empregado.comissaoVendas) from Empregado;
select SUM (Empregado.comissaoVendas) from Empregado;

select Empregado.Departamento_idDepartamento, AVG(Empregado.comissaoVendas)
from Empregado
group by Empregado.Departamento_idDepartamento;

select Empregado.Departamento_idDepartamento, AVG(Empregado.comissaoVendas)
from Empregado
group by Empregado.Departamento_idDepartamento
having count(*) > 2;

select A.nome, A.funcao, B.nome
from Empregado as A, Departamento as B
where B.idDepartamento = A.Departamento_idDepartamento;

select A.idEmpregado, A.nome, A.funcao, B.nome 'CHEFE'
from Empregado A, Empregado B
where A.idGerencia = B.idEmpregado;

insert into Departamento (idDepartamento, nome, localizacao, orcamento) values ('70', 'PODRDUCAO', 'RIO DE JANEIRO', '1200');

update Empregado
set Empregado.salario = Empregado.salario * 1.2
where Empregado.salario < 1000;

delete from Empregado
where Empregado.salario > 5000;

select Empregado.nome, Empregado.funcao
from Empregado A
where 10000 in (select Departamento.orcamento
				from Departamento
				where Departamento.idDepartamento = A.Departamento_idDepartamento);

select Departamento.nome
from Departamento A
where EXISTS (select * from Empregado where Empregado.salario > 3000 and Empregado.Departamento_idDepartamento = A.idDepartamento);

-----------------
create login usuario with password='senha';
        create user usuario from login usuario;
        exec sp_addrolemember 'DB_DATAREADER', 'usuario';
        exec sp_addrolemember 'DB_DATAWRITER', 'usuario';


