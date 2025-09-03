create procedure pa_actualizapacascompra
@idproducciondetalle int,
@idcompra int,
@baleid bigint,
@kilos decimal (10,4),
@libras decimal(10,4),
@quintales decimal(10,4),
@preciodlscompra decimal(18,4),
@precioclasecompra decimal(18,4),
@castigomicros float,
@castigouhml float,
@castigostrength float,
@castigouniformity float
as
update ProduccionDetalle 
set IdCompraenc = @idcompra,
	kiloscompra = @kilos,
	librascompra = @libras,
	quintalescompra = @quintales,
	PrecioDlscompra = @preciodlscompra,
	PrecioClasecompra = @precioclasecompra,
	CastigoMicCpa = @castigomicros,
	CastigoLargoFibraCpa = @castigouhml,
	CastigoResistenciaFibraCpa = @castigostrength,
	CastigoUICompra = @castigouniformity
where IdProduccionDetalle = @idproducciondetalle