alter Procedure Pa_ConsultaExistencias
as
select 
(select count(Foliocia) from ProduccionDetalle) TotalProducidas, 
(select count(baleid) from HviDetalle) TotalClasificadas, 
(select count(baleid) from hvidetalle where idcompraenc is null) as PacasSinComprar,
(select count(baleid) from hvidetalle where idcompraenc is not null) as PacasCompradas,
(select count(baleid) from calculoclasificacion where idventaenc is null) PacasSinVender, 
(select count(baleid) from calculoclasificacion where idventaenc is not null) as PacasVendidas, 
(select count(baleid) from calculoclasificacion where IdEmbarqueEncabezado is not null) as PacasEmbarque, 
(select count(baleid) from calculoclasificacion where IdSalidaEncabezado is not null) as PacasSalida,
(select count(Foliocia) from ProduccionDetalle)-(select count(baleid) from calculoclasificacion where IdSalidaEncabezado is not null) as PacasExistencias