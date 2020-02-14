Alter Procedure Sp_ConsultaLargosFibraDetalle
@IdLargoFibraEncabezado int
as
Select IdModoDetalle,
	   IdModoEncabezado,
	   Rango1,
	   Rango2,
	   ColorGrade,
	   Castigo,
	   IdEstatus
From LargosFibraDetalle
where IdModoEncabezado = @IdLargoFibraEncabezado