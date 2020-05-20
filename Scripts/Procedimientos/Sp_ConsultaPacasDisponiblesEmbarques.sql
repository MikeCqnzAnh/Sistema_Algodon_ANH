CREATE Procedure Sp_ConsultaPacasDisponiblesEmbarques
--declare
@Seleccionar bit = 0 ,
@IdComprador int
as
select cc.IdPaqueteEncabezado
	  ,cc.IdVentaEnc
	  ,cc.IdPlantaOrigen
	  ,cc.BaleID
	  ,Pl.Descripcion
	  ,cc.Kilos
	  ,@Seleccionar as Seleccionar
from PaqueteEncabezado pe inner join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado and pe.IdPlanta = cc.idPlantaOrigen
						  inner join Plantas Pl on cc.IdPlantaOrigen = pl.IdPlanta
						  inner join ventapacas vp on cc.IdVentaenc = vp.Idventa  
where cc.EstatusVenta = 2 and vp.IdComprador = @IdComprador and cc.BaleID not in (select BaleID from EmbarqueDetalle where IdComprador = @IdComprador)
order by cc.IdPaqueteEncabezado, cc.BaleID
