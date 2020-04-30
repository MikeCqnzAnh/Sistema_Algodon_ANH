Create Procedure Sp_ConsultaPacasSalidas
--declare
@IdEmbarqueEncabezado int ,
@NoLote varchar(15) 
as
select IdEmbarqueEncabezado
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
from EmbarqueDetalle
where IdEmbarqueEncabezado = @IdEmbarqueEncabezado and NoLote = @NoLote --and estatussalida <> 1
order by BaleID
