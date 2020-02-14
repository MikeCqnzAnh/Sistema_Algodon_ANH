Create Procedure Sp_ConsultaUniformidadDetalle
@IdUniformidadEncabezado int
as
Select IdModoDetalle,
	   IdModoEncabezado,
	   Rango1,
	   Rango2,
	   Castigo,
	   IdEstatus
From UniformidadDetalle
where IdModoEncabezado = @IdUniformidadEncabezado