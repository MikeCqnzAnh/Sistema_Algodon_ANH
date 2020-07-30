ALTER procedure sp_ConsultaLoteAlmacen
@IdAlmacenEncabezado int ,
@IdLote int ,
@Nivel varchar(1)
as
select IdAlmacenDetalle
	  ,IdAlmacenEncabezado
	  ,IdLote
	  ,Nivel
	  ,PosicionColumna
	  ,PosicionFila
	  ,isnull(BaleID,0) as BaleiD
	  ,ISNULL(EstatusAlmacen,0) as EstatusAlmacen
from AlmacenDetalle
where IdAlmacenEncabezado = @IdAlmacenEncabezado and IdLote = @IdLote and Nivel = @Nivel
order by PosicionFila,PosicionColumna