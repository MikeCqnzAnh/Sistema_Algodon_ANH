CREATE Procedure Sp_ConsultaOrdenEmbarqueEncabezadoporlote
@IdEmbarqueEncabezado int,
@NombreComprador varchar(30)
as
if @IdEmbarqueEncabezado <> 0 and @NombreComprador = ''
	begin
		select distinct ee.IdEmbarqueEncabezado,
			   ee.idcomprador,
			   co.Nombre,
			   isnull(se.NombreChofer ,'') as NombreChofer,
			   isnull(se.PlacaTractoCamion,'') as PlacaTractoCamion,
			   isnull(se.NoLicencia,'') as NoLicencia,
			   ed.NoLote,
			   ed.CantidadPacas
		from EmbarqueEncabezado ee inner join EmbarqueDet ed on ee.IdEmbarqueEncabezado = ed.IdEmbarqueEnc 
								   inner join Compradores co on ee.IdComprador = co.IdComprador
								   left join SalidaPacasEncabezado se on ee.IdEmbarqueEncabezado = se.IdEmbarqueEncabezado
		where ee.IdEmbarqueEncabezado = @IdEmbarqueEncabezado
		order by ee.IdEmbarqueEncabezado desc
	end
else if @IdEmbarqueEncabezado = 0 and @NombreComprador <> ''
	begin
		select distinct ee.IdEmbarqueEncabezado,
			   ee.idcomprador,
			   co.Nombre,
			   isnull(se.NombreChofer ,'') as NombreChofer,
			   isnull(se.PlacaTractoCamion,'') as PlacaTractoCamion,
			   isnull(se.NoLicencia,'') as NoLicencia,
			   ed.NoLote,
			   ed.CantidadPacas
		from EmbarqueEncabezado ee inner join EmbarqueDet ed on ee.IdEmbarqueEncabezado = ed.IdEmbarqueEnc 
								   inner join Compradores co on ee.IdComprador = co.IdComprador
								   left join SalidaPacasEncabezado se on ee.IdEmbarqueEncabezado = se.IdEmbarqueEncabezado
		where co.Nombre like '%'+@NombreComprador+'%'
		order by ee.IdEmbarqueEncabezado desc
	end
else 
	begin
		select distinct ee.IdEmbarqueEncabezado,
			   ee.idcomprador,
			   co.Nombre,
			   isnull(se.NombreChofer ,'') as NombreChofer,
			   isnull(se.PlacaTractoCamion,'') as PlacaTractoCamion,
			   isnull(se.NoLicencia,'') as NoLicencia,
			   ed.NoLote,
			   ed.CantidadPacas
		from EmbarqueEncabezado ee inner join EmbarqueDet ed on ee.IdEmbarqueEncabezado = ed.IdEmbarqueEnc 
								   inner join Compradores co on ee.IdComprador = co.IdComprador
								   left join SalidaPacasEncabezado se on ee.IdEmbarqueEncabezado = se.IdEmbarqueEncabezado
		order by ee.IdEmbarqueEncabezado desc
	end