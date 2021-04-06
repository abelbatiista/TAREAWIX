CREATE DATABASE TAREAIX
USE TAREAIX

CREATE TABLE persona
(
	id INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	cedula NVARCHAR(100) NOT NULL,
	nombre NVARCHAR(100) NOT NULL,
	apellido NVARCHAR(100) NOT NULL,
	telefono NVARCHAR(100) NOT NULL,
	correo NVARCHAR(100) NOT NULL,
	fecha NVARCHAR(100) NOT NULL,
	sangre NVARCHAR(100) NOT NULL,
	provincia NVARCHAR(100) NOT NULL,
	direccion NVARCHAR(100) NOT NULL,
	latitud NVARCHAR(100) NOT NULL,
	longitud NVARCHAR(100) NOT NULL,
	covid NVARCHAR(100) NOT NULL,
	justificacion NVARCHAR(100) NOT NULL
)

CREATE PROCEDURE insertar_persona
@cedula NVARCHAR(100),
@nombre NVARCHAR(100),
@apellido NVARCHAR(100),
@telefono NVARCHAR(100),
@correo NVARCHAR(100),
@fecha NVARCHAR(100),
@sangre NVARCHAR(100),
@provincia NVARCHAR(100),
@direccion NVARCHAR(100),
@latitud NVARCHAR(100),
@longitud NVARCHAR(100),
@covid NVARCHAR(100),
@justificacion NVARCHAR(100)
AS
	BEGIN
		INSERT INTO persona VALUES (@cedula, @nombre, @apellido, @telefono, @correo, @fecha, @sangre, @provincia, @direccion, @latitud, @longitud, @covid, @justificacion)
	END

SELECT * FROM persona