Create Procedure Sp_ConsultaAlmacenEncabezado
@IdAlmacenEncabezado int
as
if @IdAlmacenEncabezado > 0
	begin
		Select IdAlmacenEncabezado
			  ,TipoAlmacen
			  ,CantidadLotes
			  ,CantidadNiveles
			  ,Columnas
			  ,Filas
			  ,FechaAlta
		from   AlmacenEncabezado
		where IdAlmacenEncabezado = @IdAlmacenEncabezado
	end
else
	begin
		Select IdAlmacenEncabezado
			  ,TipoAlmacen
			  ,CantidadLotes
			  ,CantidadNiveles
			  ,Columnas
			  ,Filas
			  ,FechaAlta
		from   AlmacenEncabezado
	end	