alter procedure sp_ConsultaLotes
@SuperficieContratada float = 0.00
as
select a.IdTierra,
       a.Lote,
	   a.SuperficieTotal,
	   a.SuperficieCultivable,
	   b.SuperficieRestante,
	   @SuperficieContratada as SuperficieContratada
from [dbo].[Tierras] a,
     [dbo].[TierraDetalle] b
where a.IdEstatus = 1
and   a.IdTierra = b.IdTierraEncabezado
and   b.SuperficieRestante > 0

