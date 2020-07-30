Create Procedure Sp_ActualizaAlmacenDetalle
@IdAlmacenEncabezado int,
@IdLote int,
@Nivel varchar(1),
@PosicionColumna int,
@PosicionFila int,
@BaleID int,
@EstatusAlmacen int
as
update AlmacenDetalle
set baleid = @BaleID,
	EstatusAlmacen = @EstatusAlmacen
where IdAlmacenEncabezado = @IdAlmacenEncabezado and 
	  IdLote = @IdLote and
	  Nivel = @Nivel and
	  PosicionColumna = @PosicionColumna and
	  PosicionFila = @PosicionFila