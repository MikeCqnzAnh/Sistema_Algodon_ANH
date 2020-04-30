Create Procedure Sp_ConsultaEmbarqueSalida
@IdEmbarqueEncabezado int,
@NombreComprador varchar(30)
as
if @IdEmbarqueEncabezado > 0 and @NombreComprador = ''
begin
	select ed.IdEmbarqueEncabezado
	  ,ed.IdComprador
	  ,co.Nombre
	  ,ee.NombreChofer
	  ,ee.Telefono
	  ,ee.PlacaTractoCamion
	  ,ee.NoLicencia
	  ,isnull(ed.IdSalidaEncabezado,0) as IdSalidaEncabezado
	  ,ed.NoLote
	  ,ed.NoContenedor 
	  ,ed.PlacaCaja
	  ,count(ed.IdEmbarqueDetalle) as NoPacas
	from EmbarqueDetalle ed inner join Compradores CO on ed.idcomprador = co.IdComprador
							inner join EmbarqueEncabezado ee on ed.IdEmbarqueEncabezado = ee.IdEmbarqueEncabezado
	where ed.EstatusSalida = 0 and ed.IdEmbarqueEncabezado = @IdEmbarqueEncabezado
	group by ed.IdSalidaEncabezado
		,ee.NombreChofer
		,ee.Telefono
		,ee.PlacaTractoCamion
		,ee.NoLicencia
		,ed.NoContenedor
	    ,ed.PlacaCaja
		,ed.IdComprador
		,CO.Nombre
		,ed.NoLote
		,ed.IdEmbarqueEncabezado
end
else if  @IdEmbarqueEncabezado = 0 and @NombreComprador <> ''
begin
	select ed.IdEmbarqueEncabezado
	  ,ed.IdComprador
	  ,co.Nombre
	  ,ee.NombreChofer
	  ,ee.Telefono
	  ,ee.PlacaTractoCamion
	  ,ee.NoLicencia
	  ,isnull(ed.IdSalidaEncabezado,0) as IdSalidaEncabezado
	  ,ed.NoLote
	  ,ed.NoContenedor 
	  ,ed.PlacaCaja
	  ,count(ed.IdEmbarqueDetalle) as NoPacas
	from EmbarqueDetalle ed inner join Compradores CO on ed.idcomprador = co.IdComprador
							inner join EmbarqueEncabezado ee on ed.IdEmbarqueEncabezado = ee.IdEmbarqueEncabezado
	where EstatusSalida = 0 and CO.Nombre like '%'+@NombreComprador+'%'
	group by ed.IdSalidaEncabezado
		,ee.NombreChofer
		,ee.Telefono
		,ee.PlacaTractoCamion
		,ee.NoLicencia
		,ed.NoContenedor
	    ,ed.PlacaCaja
		,ed.IdComprador
		,CO.Nombre
		,ed.NoLote
		,ed.IdEmbarqueEncabezado
end
else
begin
	select ed.IdEmbarqueEncabezado
	  ,ed.IdComprador
	  ,co.Nombre
	  ,ee.NombreChofer
	  ,ee.Telefono
	  ,ee.PlacaTractoCamion
	  ,ee.NoLicencia
	  ,isnull(ed.IdSalidaEncabezado,0) as IdSalidaEncabezado
	  ,ed.NoLote
	  ,ed.NoContenedor 
	  ,ed.PlacaCaja
	  ,count(ed.IdEmbarqueDetalle) as NoPacas
	from EmbarqueDetalle ed inner join Compradores CO on ed.idcomprador = co.IdComprador
							inner join EmbarqueEncabezado ee on ed.IdEmbarqueEncabezado = ee.IdEmbarqueEncabezado
	where ed.EstatusSalida = 0
	group by ed.IdSalidaEncabezado
		,ee.NombreChofer
		,ee.Telefono
		,ee.PlacaTractoCamion
		,ee.NoLicencia
		,ed.NoContenedor
	    ,ed.PlacaCaja
		,ed.IdComprador
		,CO.Nombre
		,ed.NoLote
		,ed.IdEmbarqueEncabezado
end