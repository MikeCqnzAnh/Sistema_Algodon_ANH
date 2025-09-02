alter proc sp_ConsultaModulosSinTara
as
select IdBoleta,NoTransporte,Bruto,Tara,Total as Neto,fechaentrada,fechasalida from OrdenTrabajoDetalle where bruto > 0 and tara = 0
union
select IdBoleta,NoTransporte,Bruto,Tara,Neto,FechaCreacion as fechasalida, fechaactualizacion as fechasalida from IncidenciasBoletasPorLotes where revisada = 0 and  bruto > 0 and tara = 0