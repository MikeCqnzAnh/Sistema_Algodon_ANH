Create Procedure Sp_ConsultaOrdenEmbarqueEncabezado
@IdEmbarqueEncabezado int,
@NombreComprador varchar(30)
as
if @IdEmbarqueEncabezado <> 0 and @NombreComprador = ''
	begin
		select ee.IdEmbarqueEncabezado
			  ,ee.IdComprador
			  ,co.Nombre
			  ,ee.NombreChofer
			  ,ee.PlacaTractoCamion
			  ,ee.NoLicencia
			  ,ee.CantidadCajas
			  ,ee.CantidadPacas 
		from EmbarqueEncabezado ee inner join compradores co 
		on ee.IdComprador = co.IdComprador
		where ee.IdEmbarqueEncabezado = @IdEmbarqueEncabezado
		order by ee.IdEmbarqueEncabezado
	end
else if @IdEmbarqueEncabezado = 0 and @NombreComprador <> ''
	begin
		select ee.IdEmbarqueEncabezado
			  ,ee.IdComprador
			  ,co.Nombre
			  ,ee.NombreChofer
			  ,ee.PlacaTractoCamion
			  ,ee.NoLicencia
			  ,ee.CantidadCajas
			  ,ee.CantidadPacas 
		from EmbarqueEncabezado ee inner join compradores co 
		on ee.IdComprador = co.IdComprador
		where co.Nombre like '%'+@NombreComprador+'%'
		order by ee.IdEmbarqueEncabezado
	end
else 
	begin
		select ee.IdEmbarqueEncabezado
			  ,ee.IdComprador
			  ,co.Nombre
			  ,ee.NombreChofer
			  ,ee.PlacaTractoCamion
			  ,ee.NoLicencia
			  ,ee.CantidadCajas
			  ,ee.CantidadPacas 
		from EmbarqueEncabezado ee inner join compradores co 
		on ee.IdComprador = co.IdComprador
		order by ee.IdEmbarqueEncabezado
	end