Create Procedure Sp_ConsultaMicrosDetalle
@IdMicrosEncabezado int
as
Select IdModoDetalle,
	   IdModoEncabezado,
	   Rango1,
	   Rango2,
	   Castigo,
	   IdEstatus
From MicrosDetalle
where IdModoEncabezado = @IdMicrosEncabezado