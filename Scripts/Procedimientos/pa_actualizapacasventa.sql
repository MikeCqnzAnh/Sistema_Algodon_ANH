create procedure pa_actualizapacasventa
@idproducciondetalle int,
@idventa int,
@baleid bigint,
@kilos decimal (10,4),
@libras decimal(10,4),
@quintales decimal(10,4),
@preciodlsventa decimal(18,4),
@precioclaseventa decimal(18,4),
@castigomicros float,
@castigouhml float,
@castigostrength float,
@castigouniformity float
as
update ProduccionDetalle 
set IdVentaEnc = @idventa,
	kilosventa = @kilos,
	librasventa = @libras,
	quintalesventa = @quintales,
	PrecioDlsventa = @preciodlsventa,
	PrecioClaseventa = @precioclaseventa,
	CastigoMicvta = @castigomicros,
	CastigoLargoFibravta = @castigouhml,
	CastigoResistenciaFibravta = @castigostrength,
	CastigoUIventa = @castigouniformity
where IdProduccionDetalle = @idproducciondetalle