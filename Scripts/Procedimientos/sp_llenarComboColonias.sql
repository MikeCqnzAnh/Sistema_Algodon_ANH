create proc sp_llenarComboColonias
as
select IdColonia
	  ,Descripcion
from Colonias
Order by Descripcion