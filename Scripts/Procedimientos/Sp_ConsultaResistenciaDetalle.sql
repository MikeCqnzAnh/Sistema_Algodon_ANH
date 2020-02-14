Create Procedure Sp_ConsultaResistenciaDetalle
@IdResistenciaEncabezado int
as
Select IdModoDetalle,
	   IdModoEncabezado,
	   Rango1,
	   Rango2,
	   Castigo,
	   IdEstatus
From ResistenciaDetalle
where IdModoEncabezado = @IdResistenciaEncabezado