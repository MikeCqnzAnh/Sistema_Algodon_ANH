CREATE Procedure Pa_ConsultaPacasSeleccionadasSalidas
@Seleccionar bit = 0,
@IdSalidaEncabezado int
as
select cc.IdPaqueteEncabezado
	  ,cc.IdVentaEnc
	  ,cc.IdPlantaOrigen
	  ,cc.BaleID
	  ,cc.NoLote
	  ,Pl.Descripcion
	  ,cc.Kilos
	  ,@Seleccionar as Seleccionar
from PaqueteEncabezado pe inner join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado and pe.IdPlanta = cc.idPlantaOrigen
						  inner join Plantas Pl on cc.IdPlantaOrigen = pl.IdPlanta
						  inner join ventapacas vp on cc.IdVentaenc = vp.Idventa  
where cc.EstatusSalida = 1  and cc.IdSalidaEncabezado = @IdSalidaEncabezado