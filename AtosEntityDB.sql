create database AtosEntity1;

create login AtosEntity1 with password='AtosEntity1';
create user AtosEntity1 from login AtosEntity1;

exec sp_addrolemember 'DB_DATAREADER', 'AtosEntity1';
exec sp_addrolemember 'DB_DATAWRITER', 'AtosEntity1';

--Add-Migration Initial