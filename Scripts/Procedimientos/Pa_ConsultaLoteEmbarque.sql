alter Procedure Pa_ConsultaLoteEmbarque
@IdEmbarqueEnc int
as
Select IdEmbarqueDet,
	   IdEmbarqueEnc,
	   CantidadPacas,
	   NoContenedor,
	   NoLote,
	   PlacaCaja,
	   Fecha,
	   FechaActualizacion
from EmbarqueDet
where IdEmbarqueEnc = @IdEmbarqueEnc
