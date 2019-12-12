ALTER procedure sp_ConsultaUltimoRango
as
select 
     ISNULL(MAX(a.RangoFin),0) as RangoFin
from [dbo].[OrdenTrabajo] a