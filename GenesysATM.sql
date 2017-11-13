USE master
GO
-- Creamos la base de datos.
CREATE DATABASE GENESYSATM
GO

USE GENESYSATM
GO
 --Creamos el esquema.
CREATE SCHEMA ATM
GO 

--==============================================================================
--Creamos la distintas tamblas de la base de datos:
-- 1) Clientes.
-- 2) TarjetasCliente. 
-- 3) TarjetasCredito.
-- 4) ServiciosCliente.
-- 5) ServicioPúblicos.
-- 6) Configuración.

--Clientes: 
CREATE TABLE ATM.Clientes (
	Id INT NOT NULL
	CONSTRAINT PK_Clientes_Id UNIQUE NONCLUSTERED,
	Nombres NVARCHAR (100) NOT NULL,
	Apellidos NVARCHAR(100) NOT NULL,
	Identidad CHAR (15) NOT NULL,
	Direccion NVARCHAR(2000) NOT NULL,
	Telefono CHAR (9) NOT NULL,
	Celular CHAR (9) NOT NULL,
)
GO

-- TarjetasCredito:
CREATE TABLE ATM.TarjetasCredito (
	Id INT NOT NULL
	CONSTRAINT PK_TarjetasCredito_Id PRIMARY KEY NONCLUSTERED,
	Descripcion NVARCHAR(100) NOT NULL,
	MontoMaximo DECIMAL(12,2) NOT NULL,
)
GO

drop table ATM.TarjetasCredito
-- ServiciosPúblicos
CREATE TABLE ATM.ServiciosPublicos (
	Id INT NOT NULL
	CONSTRAINT PK_ServiciosPublicos_Id PRIMARY KEY NONCLUSTERED,
	Descripcion NVARCHAR(100) NOT NULL,
)
GO


-- Configuración:
CREATE TABLE ATM.Configuracion (
	Id INT NOT NULL 
	CONSTRAINT PK_Configuracion_Id PRIMARY KEY NONCLUSTERED,
	AppKey NCHAR (10) NOT NULL,
	Valor NCHAR(100) NOT NULL,
	Descripcion TEXT NOT NULL
)
GO

-- TarjetasClientes:
CREATE TABLE ATM.TarjetasCliente (
	Numero CHAR (14) NOT NULL
	CONSTRAINT PK_TarjetasCliente_Numero PRIMARY KEY NONCLUSTERED,
	IdCliente INT NOT NULL
		CONSTRAINT FK_ATM_TarjetasCliente$TieneUn$ATM_Cliente
		FOREIGN KEY(IdCliente) REFERENCES ATM.Clientes(Id),
	IdTarjeta INT NOT NULL
		CONSTRAINT FK_ATM_TarjetasCliente$TieneUn$ATM_TarjetaCredito
		FOREIGN KEY(IdTarjeta) REFERENCES ATM.TarjetasCredito(Id),
	Saldo DECIMAL (12,2) NOT NULL,
	Pin INT NOT NULL
)
GO


-- ServiciosCliente:
CREATE TABLE ATM.ServiciosCliente (
	IdCliente INT NOT NULL
		CONSTRAINT FK_ATM_ServiciosCliente$TieneUn$ATM_Cliente
		FOREIGN KEY(IdCliente) REFERENCES ATM.Clientes(Id),
	IdServicio INT NOT NULL
		CONSTRAINT FK_ATM_ServiciosCliente$TieneUn$ATM_Servicios_Publicos
		FOREIGN KEY(IdServicio) REFERENCES ATM.ServiciosPublicos(Id),
	Saldo DECIMAL (12,2) NOT NULL
)
GO

--==============================================================================

-- Creamos los Check Constraint:
--							    Cuya funciones son definir el formato de datos a ingresar														 
--                              de los campos de las distintas tablas existentes.

-- No. 1) Campos de la tabla "Clientes".

ALTER TABLE ATM.Clientes WITH CHECK
ADD CONSTRAINT CK_Clientes_Identidad$FormatoParaIdentidad$
CHECK (Identidad LIKE  '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9][0-9]')
GO

ALTER TABLE ATM.Clientes WITH CHECK
ADD CONSTRAINT CK_Clientes_Telefono$FormatoParaTelefono$
CHECK (Telefono LIKE  '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
GO

ALTER TABLE ATM.Clientes WITH CHECK
ADD CONSTRAINT CK_Clientes_Celular$FormatoParaCelular$
CHECK (Celular LIKE  '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
GO

-- No. 2) Campos de la tabla "TarjetasCliente".

ALTER TABLE ATM.TarjetasCliente WITH CHECK
ADD CONSTRAINT CK_CTarjetasCliente_Numero$FormatoParaNumeroDeLaTarjeta$
CHECK (Numero LIKE  '[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]')
GO

ALTER TABLE ATM.TarjetasCliente WITH CHECK
ADD CONSTRAINT CK_CTarjetasCliente_Pin$FormatoParaPinCliente$
CHECK (Pin LIKE  '[0-9][0-9][0-9][0-9]')
GO

-- No. 3) Campos de la tabla "TarjetasCredito" : no es necesario alterar
--												 esta tabla.


-- No. 4) Campos de la tabla "ServiciosCliente" : no es necesario alterar
--												  esta tabla.


-- No. 5) Campos de la tabla "ServiciosPublicos" : no es necesario alterar
--												   esta tabla.

-- No. 5) Campos de la tabla "ServiciosPublicos"

--VAMOS A CREAR PROCEDIMIENTOS PARA PODER INSERTAR LOS REGISTROS.

--PROCEDIMIENTO PARA TABLA CLIENTES

CREATE PROCEDURE ATM.spInsertarClientes(
	@Id INT = NULL,
	@Nombres NVARCHAR(100) = NULL,
	@Apellidos NVARCHAR(100) = NULL,
	@Identidad CHAR(15) = NULL,
	@Direccion NVARCHAR(2000) = Null,
	@Telefono CHAR(9) = NULL,
	@Celular CHAR(9) = NULL
)
AS
BEGIN
	IF (@Id IS NULL) OR (@Nombres IS NULL) OR (@Apellidos IS NULL) OR (@Identidad IS NULL) OR
		(@Direccion IS NULL) OR (@Telefono IS NULL) OR (@Celular IS NULL) 
		BEGIN
			RAISERROR('HAY PARAMETROS QUE SON REQUERIDOS', 16, 1)
			RETURN 0
		END
	ELSE
		BEGIN
			INSERT INTO ATM.Clientes
			VALUES (@Id, @Nombres, @Apellidos, @Identidad, @Direccion, @Telefono, @Celular)
			RETURN 1
		END
END
GO

 
EXEC ATM.spInsertarClientes '120', 'Franklin Omar', 'Meza Enamorado', '0318-1992-00054', 'Barrio El Carmen', '2773-4270', '9453-4956'
SELECT * FROM ATM.Clientes

insert into ATM.ServiciosPublicos VALUES('10','Agua'),
('20','Energia Electrica'),('30','Bienes y muebles')
select *from ATM.ServiciosPublicos

insert into ATM.ServiciosCliente values('120','10','500'),
('120','20','500')
select *from ATM.ServiciosCliente

insert into ATM.TarjetasCredito values('1000','Tarjeta Platinum','120000.00'),
('1001','Tarjeta Credomatix','200000.00')
select *from ATM.TarjetasCredito

select *from ATM.TarjetasCliente
insert into ATM.TarjetasCliente VALUES('1234-5678-9101','120','1000','120000.00','1234'),
('9876-5432-1010','110','1001','200000.00','5678')



 insert into ATM.Configuracion VALUES('1010','MaxRetLemp','4000','Cantidad maxima de retiro en lempiras'),
 ('1020','MaxRetDol','200','Cantidad maxima de retiro en dolares'),
 ('1030','CantInten','3','Cantidade maxima de intentos que puede ingresar el usuario'),
 ('1040','CamDolar','23.6528','Tasa de cambio del dolar')
  SELECT *FROM ATM.Configuracion
  Go

CREATE PROCEDURE ATM.SP_modificarPin(
  @Numero CHAR(14),
  @Pin INT
  )
  AS 
	BEGIN
		Update ATM.TarjetasCliente SET Pin=@Pin WHERE Numero=@Numero
  END
  GO
  
  EXEC ATM.SP_modificarPin '1234-5678-9101','1215'
  SELECT *FROM ATM.TarjetasCliente
  GO

  DROP PROCEDURE ATM.SP_RetiroLemp
GO

  CREATE PROCEDURE ATM.SP_RetiroLemp(
  @Cantidad DECIMAL(12,2),
  @Pin INT
  )
  AS 
	BEGIN
		Update ATM.TarjetasCliente SET Saldo=(Saldo-@Cantidad) WHERE Pin=@Pin
  END
  GO
  
  EXEC ATM.SP_RetiroLemp '500','1215'
  SELECT *FROM ATM.TarjetasCliente
  GO