Create Procedure Sp_ExistePacaBodega
@IdAlmacenEncabezado int,
@Baleid int
as
select IdAlmacenEncabezado
	  ,IdLote
	  ,Nivel
	  ,PosicionColumna
	  ,PosicionFila
	  ,EstatusAlmacen 
	  ,0 as existe
from AlmacenDetalle 
where IdAlmacenEncabezado = @IdAlmacenEncabezado and BaleID = @Baleid