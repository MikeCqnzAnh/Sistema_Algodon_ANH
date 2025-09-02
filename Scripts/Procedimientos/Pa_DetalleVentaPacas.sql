Create Procedure Pa_DetalleVentaPacas
@IdVenta int
as 
select BaleID
	  ,Grade
	  ,round(kilos,2) as Kilos
	  ,Quintales
	  ,isnull(CastigoUIVenta,0) as 'Castigo UI'
	  ,isnull(CastigoResistenciaFibraVenta,0) as 'Castigo RF'
	  ,isnull(castigoMicVenta,0) as 'Castigo Mic'
	  ,isnull(CastigoLargoFibraVenta,0) as 'Castigo LF'
	  ,isnull(CastigoBarkLevel1Venta,0) as 'Bark Level 1'
	  ,isnull(CastigoBarkLevel2Venta,0) as 'Bark Level 2'
	  ,isnull(CastigoPrepLevel1Venta,0) as 'Prep Level 1'
	  ,isnull(CastigoPrepLevel2Venta,0) as 'Prep Level 2'
	  ,isnull(CastigoOtherLevel1Venta,0) as 'Other Level 1'
	  ,isnull(CastigoOtherLevel2Venta,0) as 'Other Level 2'
	  ,isnull(CastigoPlasticLevel1Venta,0) as 'Plastic Level 1'
	  ,isnull(CastigoPlasticLevel2Venta,0) as 'Plastic Level 2'
	  ,PrecioClase as 'Precio'
	  ,PrecioDls as 'Importe Dls'
from calculoclasificacion where IdVentaEnc = @IdVenta
order by baleid,grade