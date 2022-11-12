CREATE DATABASE glicemia_db

use glicemia_db

go
---------------------------------------------------------------------------------
SELECT name
FROM sys.databases;  

go
---------------------------------------------------------------------------------
use [glicemia_db];
---------------------------------------------------------------------------------
CREATE TABLE Paciente (
  idPaciente INT NOT NULL,
  nome VARCHAR(45) NOT NULL,
  email VARCHAR(45) NOT NULL,
  
  PRIMARY KEY (idPaciente)
);
---------------------------------------------------------------------------------
INSERT INTO Paciente VALUES('1','Alexandre Zamberlan','alexz@ufn.edu.br');
INSERT INTO Paciente VALUES('2','Eduardo Palharini','eduardo@ufn.edu.br');
INSERT INTO Paciente VALUES('3','Flavia Falotico','flavinha@ufn.edu.br');
---------------------------------------------------------------------------------
select * 
from Paciente;
---------------------------------------------------------------------------------
CREATE TABLE MedidaGlicemia (
  idMedidaGlicemia INT NOT NULL,
  valorGlicemia INT NOT NULL,
  dataMedida DATE NOT NULL,
  idPaciente INT NOT NULL,
  
  PRIMARY KEY (idMedidaGlicemia),
  INDEX fk_Paciente_MedidaGlicemia_idx (idPaciente ASC),
  
  CONSTRAINT fk_Paciente_MedidaGlicemia
    FOREIGN KEY (idPaciente)
    REFERENCES Paciente (idPaciente)
    ON DELETE NO ACTION
    ON UPDATE NO ACTION
);

---------------------------------------------------------------------------------
INSERT INTO MedidaGlicemia VALUES('10','159','2022-06-10','1');
INSERT INTO MedidaGlicemia VALUES('11','121','2022-06-11','1');
INSERT INTO MedidaGlicemia VALUES('12','98','2022-06-12','1');
INSERT INTO MedidaGlicemia VALUES('13','119','2022-06-13','1');
INSERT INTO MedidaGlicemia VALUES('14','109','2022-06-14','1');
---------------------------------------------------------------------------------
INSERT INTO MedidaGlicemia VALUES('15','89','2022-06-10','2');
INSERT INTO MedidaGlicemia VALUES('16','91','2022-06-11','2');
INSERT INTO MedidaGlicemia VALUES('17','98','2022-06-12','2');
INSERT INTO MedidaGlicemia VALUES('18','83','2022-06-13','2');
INSERT INTO MedidaGlicemia VALUES('19','100','2022-06-14','2');
---------------------------------------------------------------------------------
select *
from [MedidaGlicemia];

---------------------------------------------------------------------------------

create login usuario with password='senha';
create user usuario from login usuario;
exec sp_addrolemember 'DB_DATAREADER', 'usuario';
exec sp_addrolemember 'DB_DATAWRITER', 'usuario';