Create Procedure Sp_ConsultaTipoDeCambio
@IdMoneda int
as 
select TipoDeCambio from Moneda where idMoneda = 2 and IdEstatus = 1