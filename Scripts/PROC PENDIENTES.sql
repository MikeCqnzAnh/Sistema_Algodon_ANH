CREATE TABLE MicConfigEnc(
	[IdModoEncabezado] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](30) NULL,
	[ModoComercializacion] [int] NULL,
	[IdEstatus] [int] NULL)
GO
CREATE TABLE MicConfigDet(
	[IdModoDetalle] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdModoEncabezado] [int] NULL,
	[Rango1] [decimal](6, 2) NULL,
	[Rango2] [decimal](6, 2) NULL,
	[Castigo] [decimal](6, 2) NULL,
	[IdEstatus] [int] NULL)
GO
CREATE procedure sp_InsertaMicConfEncabezado
@IdModoEncabezado int output,
@Descripcion varchar(30),
@ModoComercializacion int,
@IdEstatus int
as
begin
set nocount on
merge MicConfigEnc as target
using (select @IdModoEncabezado
			 ,@Descripcion
			 ,@ModoComercializacion
			 ,@IdEstatus) as source 
			 (IdModoEncabezado
			 ,Descripcion
			 ,ModoComercializacion
			 ,IdEstatus)
ON (target.IdModoEncabezado = source.IdModoEncabezado)
WHEN MATCHED THEN
UPDATE SET Descripcion = source.Descripcion,
		   ModoComercializacion = source.ModoComercializacion,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
INSERT (Descripcion,ModoComercializacion,IdEstatus)
VALUES (source.Descripcion,source.ModoComercializacion,source.IdEstatus);
SET @IdModoEncabezado = SCOPE_IDENTITY()
END
RETURN @IdModoEncabezado
GO
CREATE proc sp_InsertaMicConfDetalle
@IdModoDetalle int,
@IdModoEncabezado int,
@Rango1 decimal(6,2),
@Rango2 decimal(6,2),
@Castigo decimal(6,2),
@IdEstatus int
as
BEGIN
SET NOCOUNT ON
MERGE MicConfigDet AS TARGET
USING (SELECT @IdModoDetalle,@IdModoEncabezado,@Rango1,@Rango2,@Castigo,@IdEstatus) AS SOURCE (IdModoDetalle,IdModoEncabezado,Rango1,Rango2,Castigo,IdEstatus)
ON (TARGET.IdModoDetalle = SOURCE.IdModoDetalle)
WHEN MATCHED THEN
UPDATE SET 	IdModoEncabezado = SOURCE.IdModoEncabezado,
			Rango1 = SOURCE.Rango1,
			Rango2 = SOURCE.Rango2,
			Castigo = SOURCE.Castigo,
			IdEstatus = SOURCE.IdEstatus
WHEN NOT MATCHED THEN
        INSERT (IdModoEncabezado,Rango1,Rango2,Castigo,IdEstatus)
        VALUES (Source.IdModoEncabezado,Source.Rango1, Source.Rango2,Source.Castigo,Source.IdEstatus);
END
GO
CREATE Procedure Sp_ConsultaMicConfigEnc
as
select IdModoEncabezado,
	   Descripcion,
	   case 
			when ModoComercializacion = 1 then 'COMPRAS' 
			WHEN ModoComercializacion = 2 then 'VENTAS'
	   END AS TipoComercializacion,
	   ModoComercializacion,
	   IdEstatus
from MicConfigEnc
go
Create Procedure Sp_ConsultaMicConfigDet
@IdMicrosEncabezado int
as
Select IdModoDetalle,
	   IdModoEncabezado,
	   Rango1,
	   Rango2,
	   Castigo,
	   IdEstatus
From MicConfigDet
where IdModoEncabezado = @IdMicrosEncabezado