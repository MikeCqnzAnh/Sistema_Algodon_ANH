insert into ParametrosContratoCompra
(
IdContratoCompra
)
select IdContratoAlgodon
from ContratoCompra

update PC
set   pc.IdContratoCompra = CC.IdContratoAlgodon 
	  ,pc.CheckMicros = 1
      ,pc.IdModoMicros = 1
      ,pc.CheckLargo = 1
      ,pc.IdModoLargoFibra = 1
      ,pc.CheckResistencia = 1
      ,pc.IdModoResistencia = 1
      ,pc.CheckUniformidad = 1
      ,pc.IdModoUniformidad = 1
      ,pc.CheckBark = 0
      ,pc.IdModoBark = 1
      ,pc.CheckBarkLevel1 = 0
      ,pc.CheckBarkLevel2 = 0
      ,pc.IdModoPrep = 2
      ,pc.CheckPrepLevel1 = 0
      ,pc.CheckPrepLevel2 = 0
      ,pc.IdModoOther = 3
      ,pc.CheckOtherLevel1 = 0
      ,pc.CheckOtherLevel2 = 0
      ,pc.IdModoPlastic = 4
      ,pc.CheckPlasticLevel1 = 0
      ,pc.CheckPlasticLevel2 = 0
from ContratoCompra CC LEFT JOIN ParametrosContratoCompra PC  ON CC.IdContratoAlgodon = PC.IDCONTRATOCOMPRA


SELECT * from ContratoCompra CC LEFT JOIN ParametrosContratoCompra PC  ON CC.IdContratoAlgodon = PC.IDCONTRATOCOMPRA

select * from ParametrosContratoCompra