alter Procedure [dbo].[Sp_InsertaAlmacenDetalle]
@IdAlmacenDetalle int,
@IdAlmacenEncabezado int,
@IdLote int,
@Nivel varchar(1),
@PosicionColumna int,
@PosicionFila int,
@BaleID int
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
			 )
as source(IdAlmacenDetalle
		 ,IdAlmacenEncabezado
		 ,IdLote
		 ,Nivel
		 ,PosicionColumna
		 ,PosicionFila
		 ,BaleID)
on (target.IdAlmacenEncabezado = source.IdAlmacenEncabezado and 
	target.IdLote = source.IdLote and 
	target.Nivel = source.Nivel)
when matched then 
update set IdAlmacenEncabezado = source.IdAlmacenEncabezado,
		   IdLote = source.IdLote,
		   Nivel = source.Nivel,
		   PosicionColumna = source.PosicionColumna,
		   PosicionFila = source.PosicionFila,
		   BaleID = source.BaleID
when not matched then
insert(IdAlmacenEncabezado
	  ,IdLote
	  ,Nivel
	  --,PosicionColumna
	  --,PosicionFila
	  --,BaleID
	  )
values(source.IdAlmacenEncabezado
	  ,source.IdLote
	  ,source.Nivel
	  --,source.PosicionColumna
	  --,source.PosicionFila
	  --,source.BaleID
	  );
end