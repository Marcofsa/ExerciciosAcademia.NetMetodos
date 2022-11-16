create database aula

use aula

create table pessoas
(
    id integer primary key identity,
    nome varchar(50) not null,
    peso float
)

create login usuarioAtos with password= 'senha';
create user usuarioAtos from login usuarioAtos

exec sp_addrolemember 'DB_DATAREADER', 'usuarioAtos';
exec sp_addrolemember 'DB_DATAWRITER', 'usuarioAtos';

select * from pessoas
or 1=1;delete from pessoas where id = 2;


--drop table pessoas