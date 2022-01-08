alter Procedure Pa_ConsultaExistencias
as
select 
(select count(Foliocia) from ProduccionDetalle) TotalProducidas, 
(select count(baleid) from HviDetalle) TotalClasificadas, 
(select count(pd.foliocia) from ProduccionDetalle pd left join HviDetalle cc on pd.FolioCIA = cc.BaleID and pd.IdOrdenTrabajo = cc.IdOrdenTrabajo and pd.idplantaorigen = cc.idplantaorigen where cc.IdCompraEnc is null) as PacasSinComprar,
(select count(pd.foliocia) from ProduccionDetalle pd left join HviDetalle cc on pd.FolioCIA = cc.BaleID and pd.IdOrdenTrabajo = cc.IdOrdenTrabajo and pd.idplantaorigen = cc.idplantaorigen where cc.IdCompraEnc is not null) as PacasCompradas,
(select count(pd.foliocia) from ProduccionDetalle pd left join calculoclasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo = cc.idordentrabajo and pd.idplantaorigen = cc.idplantaorigen where cc.idventaenc is null) as PacasSinVender, 
(select count(pd.foliocia) from ProduccionDetalle pd left join calculoclasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo = cc.idordentrabajo and pd.idplantaorigen = cc.idplantaorigen where cc.idventaenc is not null) as PacasVendidas, 
(select count(pd.foliocia) from ProduccionDetalle pd left join calculoclasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo = cc.idordentrabajo and pd.idplantaorigen = cc.idplantaorigen where cc.IdEmbarqueEncabezado is not null) as PacasEmbarque, 
(select count(pd.foliocia) from ProduccionDetalle pd left join calculoclasificacion cc on pd.FolioCIA = cc.BaleID and pd.idordentrabajo = cc.idordentrabajo and pd.idplantaorigen = cc.idplantaorigen where cc.IdSalidaEncabezado is not null) as PacasSalida,
(select count(Foliocia) from ProduccionDetalle)-(select count(baleid) from calculoclasificacion where IdSalidaEncabezado is not null) as PacasExistencias