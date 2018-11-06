create procedure sp_ConsultaPacasCalculoClasif
@IdPaquete int 
as
select a.BaleId,
	   a.Mic,
	   a.ColorGrade,
	   a.TrashId,
	   a.Clase,
	   a.UHML as LargoFibra,
	   a.Strength as ResistenciaFibra,
	   a.SCI,
	   a.FlagTerminado,
	   a.IdHviDetalle,
	   a.IdOrdenTrabajo
from [dbo].[CalculoClasificacion] a
where a.IdPaqueteEncabezado = @IdPaquete
order by a.BaleId asc