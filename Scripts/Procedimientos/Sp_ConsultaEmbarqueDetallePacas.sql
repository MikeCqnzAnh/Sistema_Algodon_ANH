alter Procedure Sp_ConsultaEmbarqueDetallePacas
@Seleccionar bit = 0,
@IdEmbarqueEncabezado int
as
select ED.IdEmbarqueDetalle
	  ,ED.IdEmbarqueEncabezado
	  ,CC.IdPaqueteEncabezado
	  ,ED.IdSalidaEncabezado
	  ,ED.IdComprador
	  ,ED.IdVentaEnc
	  ,ED.IdPlanta
	  ,ED.BaleID
	  ,ED.Kilos
	  ,ED.NoContenedor
	  ,ED.NoLote
	  ,ED.EstatusEmbarque
	  ,ED.EstatusSalida
	  ,@Seleccionar as Seleccionar
from EmbarqueDetalle ED inner join CalculoClasificacion CC 
on ED.IdVentaEnc = CC.IdVentaEnc and ED.BaleID = CC.BaleID
where IdEmbarqueEncabezado = @IdEmbarqueEncabezado
order by cc.IdPaqueteEncabezado,ED.BaleID