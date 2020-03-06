Create Procedure Sp_InsertarEmbarqueEncabezado
@IdEmbarqueEncabezado int output,
@IdComprador int,
@NombreChofer varchar(80),
@PlacaTractoCamion varchar(15),
@NoLicencia varchar(15),
@NoLote1 varchar(15),
@NoLote2 varchar(15),
@Telefono varchar(13),
@CantidadCajas int,
@NoContenedorCaja1 varchar(13),
@PlacaCaja1 varchar(13),
@NoContenedorCaja2 varchar(13),
@PlacaCaja2 varchar(13),
@CantidadPacas int,
@Fecha datetime,
@Observaciones varchar(300)
as
begin
set nocount on
merge EmbarqueEncabezado as target
using (select @IdEmbarqueEncabezado
			 ,@IdComprador
			 ,@NombreChofer
			 ,@PlacaTractoCamion
			 ,@NoLicencia
			 ,@NoLote1
			 ,@NoLote2
			 ,@Telefono
			 ,@CantidadCajas
			 ,@NoContenedorCaja1
			 ,@PlacaCaja1
			 ,@NoContenedorCaja2
			 ,@PlacaCaja2
			 ,@CantidadPacas
			 ,@Fecha
			 ,@Observaciones)
as Source(IdEmbarqueEncabezado
		,IdComprador
		,NombreChofer
		,PlacaTractoCamion
		,NoLicencia
		,NoLote1
		,NoLote2
		,Telefono
		,CantidadCajas
		,NoContenedorCaja1
		,PlacaCaja1
		,NoContenedorCaja2
		,PlacaCaja2
		,CantidadPacas
		,Fecha
		,Observaciones)
on (target.IdEmbarqueEncabezado = source.IdEmbarqueEncabezado)
when matched then
update set IdComprador = source.IdComprador
		,NombreChofer = source.NombreChofer
		,PlacaTractoCamion = source.PlacaTractoCamion
		,NoLicencia = source.NoLicencia
		,NoLote1 = source.NoLote1
		,NoLote2 = source.NoLote2
		,Telefono = source.Telefono
		,CantidadCajas = source.CantidadCajas
		,NoContenedorCaja1 = source.NoContenedorCaja1
		,PlacaCaja1 = source.PlacaCaja1
		,NoContenedorCaja2 = source.NoContenedorCaja2
		,PlacaCaja2 = source.PlacaCaja2
		,CantidadPacas = source.CantidadPacas
		,Observaciones = source.Observaciones
when not matched then
	insert ( IdComprador
		,NombreChofer
		,PlacaTractoCamion
		,NoLicencia
		,NoLote1
		,NoLote2
		,Telefono
		,CantidadCajas
		,NoContenedorCaja1
		,PlacaCaja1
		,NoContenedorCaja2
		,PlacaCaja2
		,CantidadPacas
		,Fecha
		,Observaciones)
	values
		(source.IdComprador
		,source.NombreChofer
		,source.PlacaTractoCamion
		,source.NoLicencia
		,source.NoLote1
		,source.NoLote2
		,source.Telefono
		,source.CantidadCajas
		,source.NoContenedorCaja1
		,source.PlacaCaja1
		,source.NoContenedorCaja2
		,source.PlacaCaja2
		,source.CantidadPacas
		,source.Fecha
		,source.Observaciones);
set @IdEmbarqueEncabezado = SCOPE_IDENTITY()
end 
return @IdEmbarqueEncabezado