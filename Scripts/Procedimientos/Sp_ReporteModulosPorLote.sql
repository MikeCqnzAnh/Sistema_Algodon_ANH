Create Procedure Sp_ReporteModulosPorLote
@IdOrdenTrabajo int
as
SELECT cli.IDCLIENTE,cli.NOMBRE,cli.TELEFONOFISICA,cli.TELEFONOMORAL,cli.IdTipoPersona , pla.Descripcion as Planta,OTr.Predio,OTr.RangoInicio,OTr.RangoFin,OTr.NumeroModulos,Col.Descripcion as Colonia,Vra.Descripcion as VariedadAlgodon,otd.IdBoleta,otr.IdOrdentrabajo,OTd.FlagRevisada
FROM CLIENTES cli inner join OrdenTrabajo OTr on cli.IdCliente = OTr.IdProductor
				  right join OrdenTrabajoDetalle OTd on otr.idplanta = otd.IdPlanta and otr.IdProductor = otd.IdProductor and otr.IdOrdenTrabajo = otd.idordentrabajo
				  inner join Plantas Pla on otr.idplanta = pla.IdPlanta
				  left join Colonias Col on Otr.IdColonia = Col.Idcolonia
				  left join VariedadesAlgodon Vra on Otr.IdVariedadAlgodon = Vra.IdVariedadAlgodon
where otr.IdOrdenTrabajo = @IdOrdenTrabajo