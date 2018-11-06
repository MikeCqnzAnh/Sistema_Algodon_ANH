create proc Sp_ConsultaIncidenciasBoletasPorLotes
as
select IdBoleta,NoTransporte,Bruto,Tara,Total from IncidenciasBoletasPorLotes where revisada = 0 and  bruto = 0 and tara > 0