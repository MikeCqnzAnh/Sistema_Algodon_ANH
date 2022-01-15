--update HviDetalle
--set Strength = Strength+(31-convert(int,Strength)),
--	SCI = round((-414.67 + 2.9 * Strength+(31-convert(int,Strength)) - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)
--where baleid in (select BaleID from CalculoClasificacion where idventaenc is null and  Strength > 32.99) 
--update CalculoClasificacion
--set Strength = Strength+(31-convert(int,Strength)),
--	SCI = round((-414.67 + 2.9 * Strength+(31-convert(int,Strength)) - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)
--where  idventaenc is null and  Strength > 23.99 and  Strength > 32.99
--update HviDetalle
--set mic = mic+(4-convert(int,mic))
--where Mic >= 5 

--update CalculoClasificacion
--set mic = mic+(4-convert(int,mic))
--where Mic >= 5 

select IdOrdenTrabajo,BaleID,Strength,Strength+(26-convert(int,Strength)) as StrengthRes,SCI,round((-414.67 + 2.9 * Strength+(26-convert(int,Strength)) - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)  as sci_n from HviDetalle where baleid in (select BaleID from CalculoClasificacion where idventaenc  is null and  Strength > 23.99 AND Strength < 26) order by Strength
select IdOrdenTrabajo,BaleID,Strength,Strength+(26-convert(int,Strength)) as StrengthRes,SCI,round((-414.67 + 2.9 * Strength+(26-convert(int,Strength)) - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)  as sci_n from CalculoClasificacion where idventaenc is null and Strength between 23.99 AND 26

select IdOrdenTrabajo,BaleID,Strength,Strength+(31-convert(int,Strength)) as StrengthRes,SCI,round((-414.67 + 2.9 * Strength+(31-convert(int,Strength)) - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)  as sci_n from HviDetalle where baleid in (select BaleID from CalculoClasificacion where idventaenc  is null and Strength between 32 AND 35) order by Strength
select IdOrdenTrabajo,BaleID,Strength,Strength+(31-convert(int,Strength)) as StrengthRes,SCI,round((-414.67 + 2.9 * Strength+(31-convert(int,Strength)) - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)  as sci_n from CalculoClasificacion where idventaenc is null and Strength between 32 AND 35

update HviDetalle
set Strength =Strength+(31-convert(int,Strength))
where  baleid in (select BaleID from CalculoClasificacion where idventaenc  is null and Strength between 32 AND 35) 

update CalculoClasificacion
set Strength =Strength+(31-convert(int,Strength))
where idventaenc  is null and Strength between 32 AND 35

update HviDetalle
set SCI = round((-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)
--where baleid in (select baleid from CalculoClasificacion where idventaenc  is null)

update CalculoClasificacion
set SCI = round((-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0)
--where idventaenc  is null 

select BaleID,strength,SCI,round((-414.67 + 2.9 * Strength - 9.32 * Mic + 49.17 * UHML + 4.74 * UI + 0.65 * RD + 0.36 * PLUSB),0) from calculoclasificacion where Strength > 100
select BaleID,strength,SCI from hvidetalle where baleid in (5205179719,
5205186697)
select BaleID,strength,SCI from calculoclasificacion where baleid in (5205179719,
5205186697)

update hvidetalle
set Strength = 31.1649442194318
where BaleID =5205179719
update calculoclasificacion 
set Strength = 31.1649442194318
where BaleID =5205179719

update hvidetalle
set Strength = 26.5205178639491
where BaleID =5205186697
update calculoclasificacion 
set Strength = 26.5205178639491
where BaleID =5205186697

--SELECT UHML,UHML+(1.05-convert(decimal,(UHML),2))FROM CalculoClasificacion WHERE IdVentaEnc = 7 AND UHML between 1.02 and 1.05
--select IdOrdenTrabajo,BaleID,mic,mic+(3.95-convert(decimal(18,2),mic)) as MicRes from HviDetalle where Mic >= 5  order by Mic
select IdOrdenTrabajo,BaleID,UHML,UHML+(1.09-convert(decimal(18,2),UHML)) as UHML_n from CalculoClasificacion where idventaenc = 7 and  UHML between 1.05 and 1.08
select IdOrdenTrabajo,BaleID,UHML,UHML+(1.09-convert(decimal(18,2),UHML)) as UHML_n from CalculoClasificacion where idventaenc = 7 and  UHML between 1.02 and 1.05

select IdOrdenTrabajo,BaleID,UHML,UHML-(convert(decimal(18,2),UHML)-1.31) as UHML_n from CalculoClasificacion where idventaenc = 7 and  UHML between 1.33 and 1.36
select IdOrdenTrabajo,BaleID,UHML,UHML-(convert(decimal(18,2),UHML)-1.31) as UHML_n from CalculoClasificacion where idventaenc = 7 and  UHML between 1.36 and 10

select IdOrdenTrabajo,BaleID,mic,mic+(3.95-convert(decimal(18,2),mic)) as MicRes from CalculoClasificacion where IdVentaEnc = 7 and mic between 3.30 and 3.50
select IdOrdenTrabajo,BaleID,mic,mic+(3.39-convert(decimal(18,2),mic)) as MicRes from CalculoClasificacion where IdVentaEnc = 7 and mic between 3.00 and 3.30
select IdOrdenTrabajo,BaleID,mic,mic+(3.12-convert(decimal(18,2),mic)) as MicRes from CalculoClasificacion where IdVentaEnc = 7 and mic between 2.70 and 3.00
select IdOrdenTrabajo,BaleID,mic,mic+(2.85-convert(decimal(18,2),mic)) as MicRes from CalculoClasificacion where IdVentaEnc = 7 and mic between 2.50 and 2.70
select IdOrdenTrabajo,BaleID,mic,mic+(2.73-convert(decimal(18,2),mic)) as MicRes from CalculoClasificacion where IdVentaEnc = 7 and mic between 0 and 2.50

select IdOrdenTrabajo,BaleID,UI,UI+(80.71-convert(decimal(18,2),UI)) as UIRes from CalculoClasificacion where IdVentaEnc = 7 and UI between 79 and 80
select IdOrdenTrabajo,BaleID,UI,UI+(79.25-convert(decimal(18,2),UI)) as UIRes from CalculoClasificacion where IdVentaEnc = 7 and UI between 78 and 79
select IdOrdenTrabajo,BaleID,UI,UI+(78.39-convert(decimal(18,2),UI)) as UIRes from CalculoClasificacion where IdVentaEnc = 7 and UI between 0 and 78

select IdOrdenTrabajo,BaleID,mic,mic+(3.92-convert(decimal(18,2),mic)) as MicRes from CalculoClasificacion where IdVentaEnc = 8 and mic between 3.30 and 3.50
select IdOrdenTrabajo,BaleID,mic,mic+(3.39-convert(decimal(18,2),mic)) as MicRes from CalculoClasificacion where IdVentaEnc = 8 and mic between 3.00 and 3.30
select IdOrdenTrabajo,BaleID,mic,mic+(3.08-convert(decimal(18,2),mic)) as MicRes from CalculoClasificacion where IdVentaEnc = 8 and mic between 2.70 and 3.00

select IdOrdenTrabajo,BaleID,UI,UI+(78.65-convert(decimal(18,2),UI)) as UIRes from CalculoClasificacion where IdVentaEnc = 8 and UI between 0 and 78

select mic,baleid from HviDetalle where (CAST(Mic AS nvarchar) not like '%.%')
select mic,baleid from CalculoClasificacion where (CAST(Mic AS nvarchar) not like '%.%')


