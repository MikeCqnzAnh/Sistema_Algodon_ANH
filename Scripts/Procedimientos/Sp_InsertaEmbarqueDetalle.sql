alter Procedure Sp_InsertaEmbarqueDetalle
@IdEmbarqueDetalle int,
@IdEmbarqueEncabezado int,
@IdComprador int,
@IdVentaEnc int,
@IdPlanta int,
@BaleID int,
@Kilos int,
@NoContenedor varchar(13),
@NoLote varchar(12),
@PlacaCaja varchar(13),
@EstatusEmbarque int,
@EstatusSalida int
as
begin
set nocount on
merge EmbarqueDetalle as target
using (select @IdEmbarqueDetalle
			 ,@IdEmbarqueEncabezado
			 ,@IdComprador
			 ,@IdVentaEnc
			 ,@IdPlanta
			 ,@BaleID
			 ,@Kilos
			 ,@NoContenedor
			 ,@NoLote
			 ,@PlacaCaja
			 ,@EstatusEmbarque
			 ,@EstatusSalida
		)
as Source(IdEmbarqueDetalle
			 ,IdEmbarqueEncabezado
			 ,IdComprador
			 ,IdVentaEnc
			 ,IdPlanta
			 ,BaleID
			 ,Kilos
			 ,NoContenedor
			 ,NoLote
			 ,PlacaCaja
			 ,EstatusEmbarque
			 ,EstatusSalida
		)
on (target.baleid = source.baleid and target.IdEmbarqueDetalle = source.IdEmbarqueDetalle)
when matched then
update set IdEmbarqueEncabezado = source.IdEmbarqueEncabezado
			 ,IdComprador = source.IdComprador
			 ,IdVentaEnc = source.IdVentaEnc
			 ,IdPlanta = source.IdPlanta
			 ,BaleID = source.BaleID
			 ,Kilos = source.Kilos
			 ,NoContenedor = source.NoContenedor
			 ,NoLote = Source.NoLote
			 ,PlacaCaja = Source.PlacaCaja
			 ,EstatusEmbarque = source.EstatusEmbarque
			 ,EstatusSalida = source.EstatusSalida
when not matched then 
insert(IdEmbarqueEncabezado
			 ,IdComprador
			 ,IdVentaEnc
			 ,IdPlanta
			 ,BaleID
			 ,Kilos
			 ,NoContenedor
			 ,NoLote
			 ,PlacaCaja
			 ,EstatusEmbarque
			 ,EstatusSalida)
values(source.IdEmbarqueEncabezado
			 ,source.IdComprador
			 ,source.IdVentaEnc
			 ,source.IdPlanta
			 ,source.BaleID
			 ,source.Kilos
			 ,source.NoContenedor
			 ,source.NoLote
			 ,source.PlacaCaja
			 ,source.EstatusEmbarque
			 ,source.EstatusSalida);
end