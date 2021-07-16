Create procedure Pa_InsertaEmbarqueDet
@IdEmbarqueDet int output,
@IdEmbarqueEnc int,
@CantidadPacas int,
@NoContenedor varchar(12),
@NoLote varchar(15),
@PlacaCaja varchar(13),
@fecha datetime,
@FechaActualizacion datetime
as
begin 
set nocount on
merge EmbarqueDet as target
using (select @IdEmbarqueDet
			 ,@IdEmbarqueEnc
			 ,@CantidadPacas
			 ,@NoContenedor
			 ,@NoLote
			 ,@PlacaCaja
			 ,@fecha
			 ,@FechaActualizacion)
as source (IdEmbarqueDet
		  ,IdEmbarqueEnc 
		  ,CantidadPacas 
		  ,NoContenedor 
		  ,NoLote 
		  ,PlacaCaja 
		  ,Fecha 
		  ,FechaActualizacion )
on (target.IdembarqueDet = source.IdembarqueDet)
when matched then
update set CantidadPacas = Source.CantidadPacas
		  ,NoContenedor = Source.NoContenedor
		  ,NoLote = Source.NoLote
		  ,PlacaCaja = Source.PlacaCaja
		  ,Fecha = Source.Fecha
		  ,FechaActualizacion = Source.FechaActualizacion
when not matched then
insert (IdEmbarqueEnc ,
			CantidadPacas ,
			NoContenedor ,
			NoLote ,
			PlacaCaja ,
			Fecha ,
			FechaActualizacion)
			values
			(
			Source.IdEmbarqueEnc
		   ,Source.CantidadPacas
		   ,Source.NoContenedor
		   ,Source.NoLote
		   ,Source.PlacaCaja
		   ,Source.Fecha
		   ,Source.FechaActualizacion
			);
	set @IdEmbarqueDet = SCOPE_IDENTITY()
end
return @IdEmbarqueDet