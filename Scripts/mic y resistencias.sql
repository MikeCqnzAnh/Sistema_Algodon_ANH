update HviDetalle
set Strength = Strength+(26-convert(int,Strength))
where Strength < 26 

update CalculoClasificacion
set Strength = Strength+(26-convert(int,Strength))
where Strength < 26 

update HviDetalle
set mic = mic+(4-convert(int,mic))
where Mic >= 5 

update CalculoClasificacion
set mic = mic+(4-convert(int,mic))
where Mic >= 5 

select IdOrdenTrabajo,BaleID,Strength,Strength+(26-convert(int,Strength)) as StrengthRes from HviDetalle where Strength < 26 order by Strength
select IdOrdenTrabajo,BaleID,Strength,Strength+(26-convert(int,Strength)) as StrengthRes from CalculoClasificacion where Strength < 26 order by Strength

select IdOrdenTrabajo,BaleID,mic,mic+(4-convert(int,mic)) as MicRes from HviDetalle where Mic >= 5  order by Mic
select IdOrdenTrabajo,BaleID,mic,mic+(4-convert(int,mic)) as MicRes from CalculoClasificacion where Mic >= 5 and idpaqueteencabezado >= 41 order by Mic