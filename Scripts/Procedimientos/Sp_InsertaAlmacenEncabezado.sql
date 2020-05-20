Create Procedure [dbo].[Sp_InsertaAlmacenEncabezado]
@IdAlmacenEncabezado int output,
@TipoAlmacen int,
@CantidadLotes int,
@CantidadNiveles int,
@Columnas int,
@Filas int,
@FechaAlta datetime
as
begin
set nocount on
merge AlmacenEncabezado as target
using (select @IdAlmacenEncabezado
			 ,@TipoAlmacen
			 ,@CantidadLotes
			 ,@CantidadNiveles
			 ,@Columnas
			 ,@Filas
			 ,@FechaAlta)
as source(IdAlmacenEncabezado
		 ,TipoAlmacen
		 ,CantidadLotes
		 ,CantidadNiveles
		 ,Columnas
		 ,Filas
		 ,FechaAlta)
on (target.IdAlmacenEncabezado = source.IdAlmacenEncabezado)
when matched then 
update set TipoAlmacen = source.TipoAlmacen,
		   CantidadLotes = source.CantidadLotes,
		   CantidadNiveles = source.CantidadNiveles,
		   Columnas = source.Columnas,
		   Filas = source.Filas,
		   FechaAlta = source.FechaAlta
when not matched then
insert(TipoAlmacen,CantidadLotes,CantidadNiveles,Columnas,Filas,FechaAlta)
values(source.TipoAlmacen,source.CantidadLotes,source.CantidadNiveles,source.Columnas,source.Filas,source.FechaAlta);
set @IdAlmacenEncabezado = SCOPE_IDENTITY()
end
return @IdAlmacenEncabezado