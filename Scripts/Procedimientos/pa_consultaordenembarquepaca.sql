create procedure pa_consultaordenembarquepaca
@busqueda varchar(30)
as
begin
select ee.IdEmbarqueEncabezado,
	   ee.IdComprador,
	   cp.Nombre,
	   ee.NombreChofer,
	   ee.NoLicencia,
	   ee.Telefono,
	   ee.folio,
	   ee.PlacaTractoCamion,
	   ee.placacaja,
	   ee.destino,
	   ee.Observaciones,
	   ee.totalpacas,
	   ee.totalkilos,
	   ee.idestatus,
	   case 
			when ee.idestatus = 0 then 'Inactivo'
			when ee.idestatus = 1 then 'Activo'
		end as Estatus,
	   ee.fechacreacion,
	   ee.fechaactualizacion
from EmbarqueEncabezado ee inner join Compradores cp on ee.IdComprador = cp.IdComprador
where -- Buscar por idlote si el valor es numérico
        (TRY_CAST(@busqueda AS INT) IS NOT NULL 
         AND ee.IdEmbarqueEncabezado = TRY_CAST(@busqueda AS INT))
        OR
        -- Buscar por idcomprador si es numérico
        (TRY_CAST(@busqueda AS INT) IS NOT NULL 
         AND ee.idcomprador = TRY_CAST(@busqueda AS INT))
        OR
        -- Buscar por nombre si es texto
        (cp.Nombre LIKE '%' + @busqueda + '%')		
end 