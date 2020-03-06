Create Procedure Sp_ConsultaPaqueteEmbarcado
@Seleccionar bit = 0,
@IdEmbarqueEncabezado int
as
select cc.IdPaqueteEncabezado
	  ,COUNT(ED.BaleID) as Cantidad
	  ,SUM(ED.kilos) as Kilos
	  ,@Seleccionar as Seleccionar
from EmbarqueEncabezado EE inner join EmbarqueDetalle ED on EE.IdEmbarqueEncabezado = ED.IdEmbarqueEncabezado
						   inner join CalculoClasificacion CC on ED.IdVentaEnc = CC.IdVentaEnc and ED.BaleID = CC.BaleID
where EE.IdEmbarqueEncabezado = @IdEmbarqueEncabezado
group by cc.IdPaqueteEncabezado
order by cc.IdPaqueteEncabezado