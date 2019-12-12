create proc Sp_LlenaComboRegimenHidrico
as
select IdRegimen
	  ,Descripcion
from RegimenHidrico
order by Descripcion