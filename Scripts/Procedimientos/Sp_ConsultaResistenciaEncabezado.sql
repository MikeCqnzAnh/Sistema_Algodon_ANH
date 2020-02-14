Create Procedure Sp_ConsultaResistenciaEncabezado
as
select IdModoEncabezado,
	   Descripcion,
	   ModoComercializacion,
	   IdEstatus
from ResistenciaEncabezado