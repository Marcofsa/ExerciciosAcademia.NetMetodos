create database AtosEntity2
use AtosEntity2

create login AtosEntity2 with password='AtosEntity2';
create user AtosEntity2 from login AtosEntity2;
exec sp_addrolemember 'DB_DATAREADER', 'AtosEntity2';
exec sp_addrolemember 'DB_DATAWRITER', 'AtosEntity2';



create table Pessoas
(    id integer primary key identity,    
nome varchar(100) not null
)

create table Emails
(id integer primary key identity,    
email varchar(100) not null,   
fk_pessoa integer,   
foreign key (fk_pessoa) 
references Pessoas(id)
)


