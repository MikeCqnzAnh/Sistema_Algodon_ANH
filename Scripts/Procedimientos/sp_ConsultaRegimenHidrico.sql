create proc sp_ConsultaRegimenHidrico
as
select IdRegimen, 
	   Descripcion, 
	   IdEstatus 
from RegimenHidrico
where IdEstatus = 1