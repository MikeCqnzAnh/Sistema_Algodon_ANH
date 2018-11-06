create proc Sp_ConsultaExistenciaPacaEnPaquete
@NumPaca int 
as
SELECT IdPaqueteEncabezado FROM CalculoClasificacion WHERE baleid = @NumPaca UNION ALL 
SELECT 0 WHERE NOT EXISTS (SELECT IdPaqueteEncabezado FROM CalculoClasificacion WHERE baleid = @NumPaca) 