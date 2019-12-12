create procedure sp_ConsultaContratosSemillaDet
--declare
@IdContratoSemilla int --= 1
as
select a.IdContratoSemilla,
	   a.Folio,
	   a.Fecha,
	   a.IdComprador,
	   a.Cantidad,
	   a.PrecioTonelada,
	   a.Testigo1,
	   a.Testigo2,
	   a.IdEstatus
from [dbo].[ContratoSemilla] a
where a.IdEstatus = 1
and   a.IdContratoSemilla = @IdContratoSemilla