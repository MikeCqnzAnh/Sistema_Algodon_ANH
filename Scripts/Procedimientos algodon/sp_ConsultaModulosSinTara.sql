CREATE proc sp_ConsultaModulosSinTara
as
select IdBoleta,NoTransporte,Bruto,Tara,Total as Neto from OrdenTrabajoDetalle where bruto > 0 and tara = 0
union
select IdBoleta,NoTransporte,Bruto,Tara,Neto from IncidenciasBoletasPorLotes where revisada = 0 and  bruto > 0 and tara = 0