Create Procedure Sp_ConsultaClasesVenta
@IdPaquete int
as
select pe.idpaquete
	  ,pl.Descripcion as Planta
	  ,cc.Grade
	  ,pe.Descripcion
	  ,count(cc.BaleID) as Pacas
from PaqueteEncabezado pe inner join CalculoClasificacion cc on pe.IdPaquete = cc.IdPaqueteEncabezado and pe.IdPlanta = cc.IdPlantaOrigen
                          inner join plantas pl on pe.IdPlanta = pl.IdPlanta
where pe.idpaquete = @IdPaquete
group by pe.idpaquete,pl.Descripcion,cc.Grade,pe.Descripcion