create proc [dbo].[sp_ConsultaClasesClasificacion]
@Diferencial int = 0,
@IdModoDetalle int = 0,
@IdModoEncabezado int = 0
as
select @IdModoDetalle,
	   @IdModoEncabezado,
	   IdClasificacion,
	   ClaveCorta,
	   Descripcion,
	   @Diferencial as Diferencial
from ClasesClasificacion 