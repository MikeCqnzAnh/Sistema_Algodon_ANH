Create Procedure Sp_InsertaEmbarqueDetalle
@IdEmbarqueDetalle int,
@IdEmbarqueEncabezado int,
@IdSalidaEncabezado int,
@IdComprador int,
@IdVentaEnc int,
@IdPlanta int,
@BaleID int,
@Kilos int,
@NoContenedor varchar(13),
@NoLote varchar(12),
@EstatusEmbarque int,
@EstatusSalida int
as
begin
set nocount on
merge EmbarqueDetalle as target
using (select @IdEmbarqueDetalle
			 ,@IdEmbarqueEncabezado
			 ,@IdSalidaEncabezado
			 ,@IdComprador
			 ,@IdVentaEnc
			 ,@IdPlanta
			 ,@BaleID
			 ,@Kilos
			 ,@NoContenedor
			 ,@NoLote
			 ,@EstatusEmbarque
			 ,@EstatusSalida
		)
as Source(IdEmbarqueDetalle
			 ,IdEmbarqueEncabezado
			 ,IdSalidaEncabezado
			 ,IdComprador
			 ,IdVentaEnc
			 ,IdPlanta
			 ,BaleID
			 ,Kilos
			 ,NoContenedor
			 ,NoLote
			 ,EstatusEmbarque
			 ,EstatusSalida
		)
on (target.baleid = source.baleid and target.IdEmbarqueDetalle = source.IdEmbarqueDetalle)
when matched then
update set IdEmbarqueEncabezado = source.IdEmbarqueEncabezado
			 ,IdSalidaEncabezado = source.IdSalidaEncabezado
			 ,IdComprador = source.IdComprador
			 ,IdVentaEnc = source.IdVentaEnc
			 ,IdPlanta = source.IdPlanta
			 ,BaleID = source.BaleID
			 ,Kilos = source.Kilos
			 ,NoContenedor = source.NoContenedor
			 ,NoLote = Source.NoLote
			 ,EstatusEmbarque = source.EstatusEmbarque
			 ,EstatusSalida = source.EstatusSalida
when not matched then 
insert(IdEmbarqueEncabezado
			 ,IdSalidaEncabezado
			 ,IdComprador
			 ,IdVentaEnc
			 ,IdPlanta
			 ,BaleID
			 ,Kilos
			 ,NoContenedor
			 ,NoLote
			 ,EstatusEmbarque
			 ,EstatusSalida)
values(source.IdEmbarqueEncabezado
			 ,source.IdSalidaEncabezado
			 ,source.IdComprador
			 ,source.IdVentaEnc
			 ,source.IdPlanta
			 ,source.BaleID
			 ,source.Kilos
			 ,source.NoContenedor
			 ,source.NoLote
			 ,source.EstatusEmbarque
			 ,source.EstatusSalida);
end