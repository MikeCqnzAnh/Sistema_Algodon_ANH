Alter procedure sp_InsertarComprador
@IdComprador int output,
@Nombre varchar(100),
@Rfc varchar(20),
@Curp varchar(20),
@Domicilio varchar(100),
@IdEstado int,
@IdMunicipio int,
@Telefono varchar(15),
@Correo varchar(50),
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdEstatus int
as
begin
set nocount on
merge [dbo].[Compradores] as target
using (select @IdComprador
			 ,@Nombre
			 ,@Rfc
			 ,@Curp
			 ,@Domicilio
			 ,@IdEstado
			 ,@IdMunicipio
			 ,@Telefono
			 ,@Correo
			 ,@IdUsuarioCreacion
			 ,@FechaCreacion
			 ,@IdEstatus) AS SOURCE (
			  IdComprador
			 ,Nombre
			 ,Rfc
			 ,Curp
			 ,Domicilio
			 ,IdEstado
			 ,IdMunicipio
			 ,Telefono
			 ,Correo
			 ,IdUsuarioCreacion
			 ,FechaCreacion
			 ,IdEstatus)
ON (target.IdComprador = SOURCE.IdComprador)
WHEN MATCHED THEN
UPDATE SET Nombre = Source.Nombre,
		   Rfc = source.Rfc,
		   Curp = source.Curp,
		   Domicilio = source.Domicilio,
		   IdEstado = source.IdEstado,
		   IdMunicipio = source.IdMunicipio,
		   Telefono = source.Telefono,
		   Correo = source.Correo,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
		  INSERT (Nombre
				 ,Rfc
				 ,Curp
				 ,Domicilio
				 ,IdEstado
				 ,IdMunicipio
				 ,Telefono
				 ,Correo
				 ,IdUsuarioCreacion
				 ,FechaCreacion
				 ,IdEstatus)
          VALUES (source.Nombre
				 ,source.Rfc
				 ,source.Curp
				 ,source.Domicilio
				 ,source.IdEstado
				 ,source.IdMunicipio
				 ,source.Telefono
				 ,source.Correo
				 ,source.IdUsuarioCreacion
				 ,source.FechaCreacion
				 ,source.IdEstatus);
		  SET @IdComprador = SCOPE_IDENTITY()
		  END
RETURN @IdComprador