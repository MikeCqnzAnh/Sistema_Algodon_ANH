update HviDetalle
set Strength = Strength+(26-convert(int,Strength))
where Strength < 26 

update CalculoClasificacion
set Strength = Strength+(26-convert(int,Strength))
where Strength < 26 

select IdOrdenTrabajo,BaleID,Strength,Strength+(26-convert(int,Strength)) as StrengthRes from HviDetalle where IdOrdenTrabajo in(2,44,51,5,12,18,39,57) and Strength < 26 order by Strength
select IdOrdenTrabajo,BaleID,Strength,Strength+(26-convert(int,Strength)) as StrengthRes from CalculoClasificacion where IdOrdenTrabajo in(2,44,51,5,12,18,39,57) and Strength < 26 order by Strength