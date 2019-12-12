Create Procedure Sp_CastigoResistenciaFibra
@ResistenciaFibra as float
as
select castigo
from ResistenciaFibra
where @ResistenciaFibra between rango1 and Rango2