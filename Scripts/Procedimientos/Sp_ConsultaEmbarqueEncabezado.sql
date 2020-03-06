CREATE Procedure Sp_ConsultaEmbarqueEncabezado
@IdEmbarqueEncabezado int,
@NombreComprador varchar(30)
as
if @IdEmbarqueEncabezado > 0 and @NombreComprador = ''
begin
Select ee.IdEmbarqueEncabezado
	  ,ee.IdComprador
	  ,CO.Nombre
	  ,ee.NombreChofer
	  ,ee.PlacaTractoCamion
	  ,ee.NoLicencia
	  ,ee.NoLote1
	  ,ee.NoLote2
	  ,ee.Telefono
	  ,ee.CantidadCajas
	  ,ee.NoContenedorCaja1
	  ,ee.PlacaCaja1
	  ,ee.NoContenedorCaja2
	  ,ee.PlacaCaja2
	  ,ee.CantidadPacas
	  ,ee.Fecha
	  ,ee.Observaciones 
from EmbarqueEncabezado EE inner join Compradores CO on ee.idcomprador = co.IdComprador
where ee.idEmbarqueEncabezado = @IdEmbarqueEncabezado
end
else if  @IdEmbarqueEncabezado = 0 and @NombreComprador <> ''
begin
Select ee.IdEmbarqueEncabezado
	  ,ee.IdComprador
	  ,CO.Nombre
	  ,ee.NombreChofer
	  ,ee.PlacaTractoCamion
	  ,ee.NoLicencia
	  ,ee.NoLote1
	  ,ee.NoLote2
	  ,ee.Telefono
	  ,ee.CantidadCajas
	  ,ee.NoContenedorCaja1
	  ,ee.PlacaCaja1
	  ,ee.NoContenedorCaja2
	  ,ee.PlacaCaja2
	  ,ee.CantidadPacas
	  ,ee.Fecha
	  ,ee.Observaciones 
from EmbarqueEncabezado EE inner join Compradores CO on ee.idcomprador = co.IdComprador
where CO.Nombre like '%'+@NombreComprador+'%'
end
else
begin
Select ee.IdEmbarqueEncabezado
	  ,ee.IdComprador
	  ,CO.Nombre
	  ,ee.NombreChofer
	  ,ee.PlacaTractoCamion
	  ,ee.NoLicencia
	  ,ee.NoLote1
	  ,ee.NoLote2
	  ,ee.Telefono
	  ,ee.CantidadCajas
	  ,ee.NoContenedorCaja1
	  ,ee.PlacaCaja1
	  ,ee.NoContenedorCaja2
	  ,ee.PlacaCaja2
	  ,ee.CantidadPacas
	  ,ee.Fecha
	  ,ee.Observaciones 
from EmbarqueEncabezado EE inner join Compradores CO on ee.idcomprador = co.IdComprador
end