Create Procedure Sp_InsertaSalidaPacas
@IdSalidaEncabezado int output,
@IdEmbarqueEncabezado int,
@NoLote varchar(15),
@PesoBruto float,
@PesoTara float,
@PesoNeto float,
@Destino varchar(150),
@FolioSalida int,
@NoFactura varchar(12),
@FechaEntrada datetime,
@FechaSalida datetime,
@Observaciones varchar(max),
@EstatusSalida int
as
begin
set nocount on
merge SalidaPacasEncabezado as target
using (select @IdSalidaEncabezado,
				@IdEmbarqueEncabezado,
				@NoLote,
				@PesoBruto,
				@PesoTara,
				@PesoNeto,
				@Destino,
				@FolioSalida,
				@NoFactura,
				@FechaEntrada,
				@FechaSalida,
				@Observaciones,
				@EstatusSalida)
as source (IdSalidaEncabezado,
			IdEmbarqueEncabezado,
			NoLote,
			PesoBruto,
			PesoTara,
			PesoNeto,
			Destino,
			FolioSalida,
			NoFactura,
			FechaEntrada,
			FechaSalida,
			Observaciones,
			EstatusSalida)
on (target.IdSalidaEncabezado = source.IdSalidaEncabezado)
when matched then
update set IdEmbarqueEncabezado = source.IdEmbarqueEncabezado
		  ,NoLote = source.NoLote
		  ,PesoBruto = source.PesoBruto
		  ,PesoTara = source.PesoTara
		  ,PesoNeto = source.PesoNeto
		  ,Destino = source.Destino
		  ,FolioSalida = source.FolioSalida
		  ,NoFactura = source.NoFactura
		  ,FechaSalida = source.FechaSalida
		  ,Observaciones = source.Observaciones
		  ,EstatusSalida = source.EstatusSalida
when not matched then
insert(IdEmbarqueEncabezado,
		NoLote,
		PesoBruto,
		PesoTara,
		PesoNeto,
		Destino,
		FolioSalida,
		NoFactura,
		FechaEntrada,
		Observaciones,
		EstatusSalida)
values (source.IdEmbarqueEncabezado
	   ,source.NoLote
	   ,source.PesoBruto
	   ,source.PesoTara
	   ,source.PesoNeto
	   ,source.Destino
	   ,source.FolioSalida
	   ,source.NoFactura
	   ,source.FechaEntrada
	   ,source.Observaciones
	   ,0);
set @IdSalidaEncabezado = SCOPE_IDENTITY()
end
return @IdSalidaEncabezado
