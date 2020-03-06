CREATE Procedure Sp_ConsultaPacasDisponiblesEmbarques
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
from CalculoClasificacion cc inner join Plantas Pl on cc.IdPlantaOrigen = pl.IdPlanta
							 inner join VentaPacas Vp on cc.IdVentaEnc = Vp.IdVenta 	 
where cc.EstatusVenta = 2 and vp.IdComprador = @IdComprador and cc.BaleID not in (select BaleID from EmbarqueDetalle where IdComprador = @IdComprador)
order by cc.IdPaqueteEncabezado, cc.BaleID