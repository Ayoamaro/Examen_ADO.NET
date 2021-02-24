/* 1. Creación de la base de datos */
USE master;
go
CREATE DATABASE Concesionario
go
USE Concesionario;
go

/* 2. Creación de las tablas
    - Tabla tipo_vehiculo (tipo, descripcion) 
    - Tabla vehiculo (matricula, tipo, modelo, fecha, importe, pagado) */
CREATE TABLE  tipo_vehiculo (
	tipo CHAR(3) PRIMARY KEY, 
	descripcion CHAR(15)
)

CREATE TABLE vehiculo (
	matricula CHAR(8) PRIMARY KEY, 
	tipo CHAR(3), 
	modelo VARCHAR(100), 
	fecha DATE, 
	importe INT, 
	pagado TINYINT DEFAULT 0,
	FOREIGN KEY (tipo) REFERENCES tipo_vehiculo(tipo)
)


/* 3. Inserción de valores
    - 3 Tipos de vehículos
    - 4 vehículos */
INSERT INTO tipo_vehiculo VALUES ('SED','Sedan');
INSERT INTO tipo_vehiculo VALUES ('TOD','Todoterrono');
INSERT INTO tipo_vehiculo VALUES ('DEP','Deportivos');

select * from tipo_vehiculo;

INSERT INTO vehiculo VALUES ('E1598BZH','SED','Corrolla', '2019-05-14',20800,1);
INSERT INTO vehiculo VALUES ('E8954LUG','TOD','Rav4', '2019-02-08',28100,1);
INSERT INTO vehiculo VALUES ('E5567DZJ','TOD', 'Land Cruiser', '2019-05-06',40000,0);
INSERT INTO vehiculo VALUES ('E8867DJM','DEP','GT86', '2015-05-06',35000,1);

select * from vehiculo;


/* ---------------------- PROCEDIMIENTOS ALMACENADOS Y FUNCIONES EN MYSQL ---------------------- */

/*
1.- Crear un procedimiento almacenado que indicándole un tipo de vehículo. Muestre todos aquellos 
coches que contengan ese tipo.
*/
GO
CREATE PROCEDURE listavehiculos(@tipo CHAR(3))
AS
	SELECT vehiculo.matricula,vehiculo.tipo, vehiculo.modelo,vehiculo.fecha,vehiculo.importe, vehiculo.pagado
	FROM vehiculo  
	WHERE vehiculo.tipo=@tipo 
	ORDER BY vehiculo.fecha
GO

-- EJECUCIÓN
--EXEC listavehiculos 'TOD';


/*
4.- Crear una función que un tipo de vehículo nos devuelva en número de vehiculos totales
que sean de ese tipo.
*/
CREATE FUNCTION Numerovehiculosportipo(@tipo CHAR(3)) 
RETURNS INT
	BEGIN
	RETURN (SELECT COUNT(*) FROM vehiculo WHERE vehiculo.tipo=@tipo);
	END
GO

-- EJECUCIÓN
--SELECT dbo.Numerovehiculosportipo('TOD');