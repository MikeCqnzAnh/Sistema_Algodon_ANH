Create Procedure Sp_ExistePacaBodega
@IdAlmacenEncabezado int,
@Baleid int
as
if exists (select baleid from AlmacenDetalle where BaleID = @Baleid and IdAlmacenEncabezado = @IdAlmacenEncabezado)
	begin
		select IdAlmacenEncabezado
			  ,IdLote
			  ,Nivel
			  ,PosicionColumna
			  ,PosicionFila
			  ,EstatusAlmacen 
			  ,1 as existe
		from AlmacenDetalle 
		where IdAlmacenEncabezado = @IdAlmacenEncabezado and BaleID = @Baleid
	end
else
	begin 
		select IdAlmacenEncabezado
			  ,IdLote
			  ,Nivel
			  ,PosicionColumna
			  ,PosicionFila
			  ,EstatusAlmacen 
			  ,0 as existe
		from AlmacenDetalle 
		where IdAlmacenEncabezado = @IdAlmacenEncabezado and BaleID = @Baleid
	end
