alter Procedure Sp_CastigoResistenciaFibra
@IdModoEncabezado int,
@ResistenciaFibra as float
as
select castigo
from ResistenciaDetalle
where @ResistenciaFibra between rango1 and Rango2 and IdModoEncabezado = @IdModoEncabezado