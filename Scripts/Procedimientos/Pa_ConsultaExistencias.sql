Create Procedure Pa_ConsultaExistencias
as
select 
(select count(baleid) from calculoclasificacion) TotalProducidas, 
(select count(baleid) from hvidetalle where idcompraenc is null) as PacasSinComprar,
(select count(baleid) from hvidetalle where idcompraenc is not null) as PacasCompradas,
(select count(baleid) from calculoclasificacion where idventaenc is null) PacasSinVender, 
(select count(baleid) from calculoclasificacion where idventaenc is not null) as PacasVendidas, 
(select count(baleid) from calculoclasificacion where IdEmbarqueEncabezado is not null) as PacasEmbarque, 
(select count(baleid) from calculoclasificacion where IdSalidaEncabezado is not null) as PacasSalida,
(select count(baleid) from calculoclasificacion)-(select count(baleid) from calculoclasificacion where IdSalidaEncabezado is not null) as PacasExistencias