alter Procedure Sp_ConsultaEmbarqueSalidaSinSeleccionar
--declare
@IdEmbarqueEncabezado int,
@NombreComprador varchar(30),
@NoLote varchar(15)
as
if @IdEmbarqueEncabezado > 0 and @NoLote = '' and @NombreComprador = ''
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
	  ,count(ed.BaleID) as NoPacas
	from CalculoClasificacion ed inner join Compradores CO on ed.idcomprador = co.IdComprador
							inner join EmbarqueEncabezado ee on ed.IdEmbarqueEncabezado = ee.IdEmbarqueEncabezado
	where ed.EstatusSalida = 0 and ed.IdEmbarqueEncabezado = @IdEmbarqueEncabezado and ed.IdSalidaEncabezado is null
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
	order by ed.IdEmbarqueEncabezado
end
else if  @IdEmbarqueEncabezado = 0 and @NoLote <> '' and @NombreComprador = ''
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
	  ,count(ed.BaleID) as NoPacas
	from CalculoClasificacion ed inner join Compradores CO on ed.idcomprador = co.IdComprador
							inner join EmbarqueEncabezado ee on ed.IdEmbarqueEncabezado = ee.IdEmbarqueEncabezado and ed.IdSalidaEncabezado is null
	where EstatusSalida = 0 and ed.NoLote like '%'+@NoLote+'%' and ed.IdSalidaEncabezado is null
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
	order by ed.IdEmbarqueEncabezado
end
else if  @IdEmbarqueEncabezado = 0 and @NoLote = '' and @NombreComprador <> ''
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
	  ,count(ed.BaleID) as NoPacas
	from CalculoClasificacion ed inner join Compradores CO on ed.idcomprador = co.IdComprador
							inner join EmbarqueEncabezado ee on ed.IdEmbarqueEncabezado = ee.IdEmbarqueEncabezado and ed.IdSalidaEncabezado is null
	where EstatusSalida = 0 and co.Nombre like '%'+@NombreComprador+'%' and ed.IdSalidaEncabezado is null
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
	order by ed.IdEmbarqueEncabezado
end
if @IdEmbarqueEncabezado > 0 and @NoLote <> '' and @NombreComprador <> ''
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
	  ,count(ed.BaleID) as NoPacas
	from CalculoClasificacion ed inner join Compradores CO on ed.idcomprador = co.IdComprador
							inner join EmbarqueEncabezado ee on ed.IdEmbarqueEncabezado = ee.IdEmbarqueEncabezado
	where ed.EstatusSalida = 0 and ed.IdEmbarqueEncabezado = @IdEmbarqueEncabezado and ed.IdSalidaEncabezado is null and ed.NoLote like '%'+@NoLote+'%'
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
	order by ed.IdEmbarqueEncabezado
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
	  ,count(ed.BaleID) as NoPacas
	from CalculoClasificacion ed inner join Compradores CO on ed.idcomprador = co.IdComprador
							inner join EmbarqueEncabezado ee on ed.IdEmbarqueEncabezado = ee.IdEmbarqueEncabezado
	where ed.IdSalidaEncabezado is null
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
	order by ed.IdEmbarqueEncabezado
end