CREATE proc sp_ConsultaDetalleModoVenta
@IdModoEncabezado int
as
select md.IdModoDetalle,me.IdModoEncabezado,cc.idclasificacion, cc.clavecorta,cc.descripcion,md.Diferencial 
from ClasesClasificacion cc, ModosVentaEncabezado me, ModosVentaDetalle md 
where me.IdModoEncabezado = md.IdModoEncabezado and md.IdClasificacion = cc.IdClasificacion and me.IdModoEncabezado = @IdModoEncabezado