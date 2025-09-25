CREATE Procedure Sp_InsertarEmbarqueEncabezado
@IdEmbarqueEncabezado int output,
@IdComprador int,
@NombreChofer varchar(80),
@NoLicencia varchar(15),
@Telefono varchar(17),
@folio varchar(15),
@PlacaTractoCamion varchar(15),
@PlacaCaja varchar(15),
@destino varchar(80),
@Observaciones varchar(150),
@totalpacas int,
@totalkilos decimal(18,4),
@idestatus int,
@fechacreacion datetime,
@fechaactualizacion datetime
as
begin
set nocount on
merge EmbarqueEncabezado as target
using (select @IdEmbarqueEncabezado
			 ,@IdComprador
			 ,@NombreChofer
			 ,@NoLicencia 
			 ,@Telefono 
			 ,@folio 
			 ,@PlacaTractoCamion 
			 ,@PlacaCaja 
			 ,@destino 
			 ,@Observaciones 
			 ,@totalpacas 
			 ,@totalkilos 
			 ,@idestatus 
			 ,@fechacreacion 
			 ,@fechaactualizacion )
as Source(IdEmbarqueEncabezado
			 ,IdComprador
			 ,NombreChofer
			 ,NoLicencia 
			 ,Telefono 
			 ,folio 
			 ,PlacaTractoCamion 
			 ,PlacaCaja 
			 ,destino 
			 ,Observaciones 
			 ,totalpacas 
			 ,totalkilos 
			 ,idestatus 
			 ,fechacreacion 
			 ,fechaactualizacion)
on (target.IdEmbarqueEncabezado = source.IdEmbarqueEncabezado)
when matched then
update set IdComprador = source.IdComprador
			 ,NombreChofer = source.NombreChofer
			 ,NoLicencia = source.NoLicencia 
			 ,Telefono = source.Telefono 
			 ,folio = source.folio 
			 ,PlacaTractoCamion = source.PlacaTractoCamion 
			 ,PlacaCaja = source.PlacaCaja 
			 ,destino = source.destino 
			 ,Observaciones = source.Observaciones 
			 ,totalpacas = source.totalpacas 
			 ,totalkilos = source.totalkilos 
			 ,idestatus = source.idestatus 
			 ,fechaactualizacion = source.fechaactualizacion
when not matched then
	insert ( IdComprador
			 ,NombreChofer
			 ,NoLicencia 
			 ,Telefono 
			 ,folio 
			 ,PlacaTractoCamion 
			 ,PlacaCaja 
			 ,destino 
			 ,Observaciones 
			 ,totalpacas 
			 ,totalkilos 
			 ,idestatus 
			 ,fechacreacion 
			 ,fechaactualizacion)
	values
		(source.IdComprador
			 ,source.NombreChofer
			 ,source.NoLicencia 
			 ,source.Telefono 
			 ,source.folio 
			 ,source.PlacaTractoCamion 
			 ,source.PlacaCaja 
			 ,source.destino 
			 ,source.Observaciones 
			 ,source.totalpacas 
			 ,source.totalkilos 
			 ,source.idestatus 
			 ,source.fechacreacion 
			 ,source.fechaactualizacion);
set @IdEmbarqueEncabezado = SCOPE_IDENTITY()
end 
return @IdEmbarqueEncabezado
