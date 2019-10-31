CREATE proc Sp_ConsultaExistenciaPacaEnPaquete
@NumPaca int 
as
SELECT LotID FROM CalculoClasificacion WHERE baleid = @NumPaca UNION ALL 
SELECT 0 WHERE NOT EXISTS (SELECT LotID FROM CalculoClasificacion WHERE baleid = @NumPaca) 