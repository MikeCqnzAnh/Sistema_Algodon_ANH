Create Procedure Pa_DeleteFactura
@UUID as varchar(36)
as
declare 
@IdFactura integer = (select IdFactura from FacturasEncabezado where UUID = @UUID)

delete from FacturasEncabezado where IdFactura = @IdFactura