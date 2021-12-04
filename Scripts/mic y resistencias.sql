update HviDetalle
set Strength = Strength+(26-convert(int,Strength)),
	SCI = round((-414.67 + 2.9 * Strength+(26-convert(int,Strength)) - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)
where baleid in (select BaleID from CalculoClasificacion where idventaenc is null and  Strength > 23.99 AND Strength < 26) 

update CalculoClasificacion
set Strength = Strength+(26-convert(int,Strength)),
	SCI = round((-414.67 + 2.9 * Strength+(26-convert(int,Strength)) - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)
where  idventaenc is null and  Strength > 23.99 AND Strength < 26

--update HviDetalle
--set mic = mic+(4-convert(int,mic))
--where Mic >= 5 

--update CalculoClasificacion
--set mic = mic+(4-convert(int,mic))
--where Mic >= 5 

select IdOrdenTrabajo,BaleID,Strength,Strength+(26-convert(int,Strength)) as StrengthRes,SCI,round((-414.67 + 2.9 * Strength+(26-convert(int,Strength)) - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)  as sci_n from HviDetalle where baleid in (select BaleID from CalculoClasificacion where idventaenc is null and  Strength > 23.99 AND Strength < 26) order by Strength
select IdOrdenTrabajo,BaleID,Strength,Strength+(26-convert(int,Strength)) as StrengthRes,SCI,round((-414.67 + 2.9 * Strength+(26-convert(int,Strength)) - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)  as sci_n from CalculoClasificacion where idventaenc is null and  Strength > 23.99 AND Strength < 26

--select BaleID from CalculoClasificacion where idventaenc is null and  Strength > 32.99

--select IdOrdenTrabajo,BaleID,mic,mic+(4-convert(int,mic)) as MicRes from HviDetalle where Mic >= 5  order by Mic
--select IdOrdenTrabajo,BaleID,mic,mic+(4-convert(int,mic)) as MicRes from CalculoClasificacion where Mic >= 5 and idpaqueteencabezado >= 41 order by Mic

