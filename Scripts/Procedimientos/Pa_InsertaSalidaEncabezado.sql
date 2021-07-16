Create procedure Pa_InsertaSalidaEncabezado
@IdSalidaEncabezado int output,
@IdEmbarqueEncabezado int,
@NoLote varchar(15),
@PesoBruto float,
@PesoTara float,
@PesoNeto float,
@Destino varchar(150),
@NoFactura varchar(12),
@FolioSalida int,
@FechaEntrada datetime,
@FechaSalida datetime,
@Observaciones varchar(max),
@EstatusSalida int
as
begin 
set nocount on
merge salidapacasencabezado as target
using (select @IdSalidaEncabezado
			 ,@IdEmbarqueEncabezado
			 ,@NoLote
			 ,@PesoBruto
			 ,@PesoTara
			 ,@PesoNeto
			 ,@Destino
			 ,@NoFactura
			 ,@FolioSalida
			 ,@FechaEntrada
			 ,@FechaSalida
			 ,@Observaciones
			 ,@EstatusSalida)
as source (IdSalidaEncabezado
		  ,IdEmbarqueEncabezado 
		  ,NoLote 
		  ,PesoBruto
		  ,PesoTara 
		  ,PesoNeto 
		  ,Destino 
		  ,FolioSalida
		  ,NoFactura
		  ,FechaEntrada
		  ,FechaSalida
		  ,Observaciones
		  ,EstatusSalida)
on (target.IdSalidaEncabezado = source.IdSalidaEncabezado)
when matched then
update set IdEmbarqueEncabezado  = Source.IdEmbarqueEncabezado
		  ,NoLote  = Source.NoLote
		  ,PesoBruto = Source.PesoBruto
		  ,PesoTara  = Source.PesoTara
		  ,PesoNeto  = Source.PesoNeto
		  ,Destino  = Source.Destino
		  ,FolioSalida = Source.FolioSalida
		  ,NoFactura = Source.NoFactura		  
		  ,FechaSalida = Source.FechaSalida
		  ,Observaciones = Source.Observaciones
		  ,EstatusSalida = Source.EstatusSalida
when not matched then
insert (IdEmbarqueEncabezado ,
			NoLote ,
			PesoBruto ,
			PesoTara ,
			PesoNeto ,
			Destino ,
			FolioSalida,
			NoFactura,
			FechaSalida,
			Observaciones,
			EstatusSalida
			)
			values
			(
			Source.IdEmbarqueEncabezado ,
			Source.NoLote ,
			Source.PesoBruto ,
			Source.PesoTara ,
			Source.PesoNeto ,
			Source.Destino ,
			Source.FolioSalida,
			Source.NoFactura,
			Source.FechaSalida,
			Source.Observaciones,
			Source.EstatusSalida			
			);
	set @IdSalidaEncabezado = SCOPE_IDENTITY()
end
return @IdSalidaEncabezado