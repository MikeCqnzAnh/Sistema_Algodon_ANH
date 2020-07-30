alter Procedure [dbo].[Sp_InsertaAlmacenDetalle]
@IdAlmacenDetalle int,
@IdAlmacenEncabezado int,
@IdLote int,
@Nivel varchar(1),
@PosicionColumna int,
@PosicionFila int,
@BaleID int,
@EstatusAlmacen int
as
begin
set nocount on
merge AlmacenDetalle as target
using (select @IdAlmacenDetalle
			 ,@IdAlmacenEncabezado
			 ,@IdLote
			 ,@Nivel
			 ,@PosicionColumna
			 ,@PosicionFila
			 ,@BaleID
			 ,@EstatusAlmacen
			 )
as source(IdAlmacenDetalle
		 ,IdAlmacenEncabezado
		 ,IdLote
		 ,Nivel
		 ,PosicionColumna
		 ,PosicionFila
		 ,BaleID
		 ,EstatusAlmacen)
on (target.IdAlmacenEncabezado = source.IdAlmacenEncabezado and 
	target.IdLote = source.IdLote and 
	target.Nivel = source.Nivel and
	target.PosicionColumna = source.PosicionColumna and
	target.PosicionFila = source.PosicionFila )
when matched then 
update set IdAlmacenEncabezado = source.IdAlmacenEncabezado,
		   IdLote = source.IdLote,
		   Nivel = source.Nivel,
		   PosicionColumna = source.PosicionColumna,
		   PosicionFila = source.PosicionFila
when not matched then
insert(IdAlmacenEncabezado
	  ,IdLote
	  ,Nivel
	  ,PosicionColumna
	  ,PosicionFila
	  ,BaleID
	  )
values(source.IdAlmacenEncabezado
	  ,source.IdLote
	  ,source.Nivel
	  ,source.PosicionColumna
	  ,source.PosicionFila
	  ,source.BaleID
	  );
end
