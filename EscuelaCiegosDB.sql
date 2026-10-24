-- DESAFIO 3
-- Carlos Ernesto Moreno Carballo MC261192
-- DB Educación Especializada para Ciegos

USE master;
GO
DROP DATABASE IF EXISTS EscuelaCiegosDB
GO
CREATE DATABASE EscuelaCiegosDB
GO

------------
-- TABLAS --
------------
USE EscuelaCiegosDB
GO

CREATE TABLE Materia
(
CodMateria INT IDENTITY(1,1) PRIMARY KEY,
NombreMateria VARCHAR(100) NOT NULL, -- Lectura, Braille, Movilidad, Etc.
)
GO

CREATE TABLE Nivel
(
CodNivel INT IDENTITY(1,1) PRIMARY KEY,
NombreNivel VARCHAR(50) NOT NULL, -- Basico, Intermedio, Avanzado
CodMateria INT NOT NULL,
CONSTRAINT FK_NivelMateria FOREIGN KEY(CodMateria) REFERENCES Materia(CodMateria)
)
GO

CREATE TABLE Estudiante
(
Carnet VARCHAR(5) NOT NULL PRIMARY KEY,
Nombre VARCHAR(50) NOT NULL,
PrimerApellido VARCHAR(50) NOT NULL,
SegundoApellido VARCHAR(50) NULL,
CodNivel INT NOT NULL,
CONSTRAINT FK_NivelEstudiante FOREIGN KEY(CodNivel) REFERENCES Nivel(CodNivel)
)

------------------------
-- INSERCION DE DATOS --
------------------------
USE EscuelaCiegosDB
GO

INSERT INTO Materia(NombreMateria) VALUES ('Sistema Braille');
INSERT INTO Materia(NombreMateria) VALUES ('Informatica');
INSERT INTO Materia(NombreMateria) VALUES ('Orientacion y Movilidad');
INSERT INTO Materia(NombreMateria) VALUES ('Actividades de la Vida Diaria');
INSERT INTO Materia(NombreMateria) VALUES ('Psicomotricidad');
GO

INSERT INTO Nivel(NombreNivel, CodMateria) VALUES ('Nivel Basico', 1);
INSERT INTO Nivel(NombreNivel, CodMateria) VALUES ('Nivel Intermedio', 2);
INSERT INTO Nivel(NombreNivel, CodMateria) VALUES ('Nivel Avanzado', 3);
GO

INSERT INTO Estudiante(Carnet, Nombre, PrimerApellido, SegundoApellido, CodNivel)
VALUES ('MC001', 'Carlos Ernesto', 'Moreno', 'Carballo', 1)
INSERT INTO Estudiante(Carnet, Nombre, PrimerApellido, SegundoApellido, CodNivel)
VALUES ('CG002', 'Katherine Lourdes', 'Cortez', 'Guerra', 2)
INSERT INTO Estudiante(Carnet, Nombre, PrimerApellido, SegundoApellido, CodNivel)
VALUES ('PM003', 'Alessandra Daniella', 'Paredes', 'Moreno', 3)
GO

---------------
-- VISTA DGV --
---------------
USE EscuelaCiegosDB
GO

SELECT
e.Carnet AS 'Carnet',
e.Nombre AS 'Nombres',
e.PrimerApellido + ' ' + ISNULL(e.SegundoApellido, ' ') AS 'Apelldios',
n.NombreNivel AS 'Nivel',
m.NombreMateria AS 'Materia'
FROM Estudiante e
INNER JOIN Nivel n ON e.CodNivel = n.CodNivel
INNER JOIN Materia m ON n.CodMateria = m.CodMateria
GO