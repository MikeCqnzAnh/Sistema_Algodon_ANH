alter Procedure [dbo].[Sp_ConsultaAlmacenEncabezado]
@IdAlmacenEncabezado int,
@Descripcion varchar(20)
as
if @IdAlmacenEncabezado = 0 and @Descripcion <> ''
	begin
		Select IdAlmacenEncabezado
			  ,Descripcion 
			  ,TipoAlmacen
			  ,CantidadLotes
			  ,CantidadNiveles
			  ,Columnas
			  ,Filas
			  ,FechaAlta
		from   AlmacenEncabezado
		where Descripcion like '%'+@IdAlmacenEncabezado+'%'
	end
else if @IdAlmacenEncabezado > 0 and @Descripcion = ''
	begin
		Select IdAlmacenEncabezado
			  ,Descripcion 
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
			  ,Descripcion 
			  ,TipoAlmacen
			  ,CantidadLotes
			  ,CantidadNiveles
			  ,Columnas
			  ,Filas
			  ,FechaAlta
		from   AlmacenEncabezado
	end	