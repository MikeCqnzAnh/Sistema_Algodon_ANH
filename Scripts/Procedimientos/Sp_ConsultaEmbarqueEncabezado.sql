Create Procedure Sp_ConsultaEmbarqueEncabezado
--declare
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
where ee.idEmbarqueEncabezado = @IdEmbarqueEncabezado --and ee.IdEmbarqueEncabezado not in (select IdEmbarqueEncabezado from SalidaPacasEncabezado where EstatusSalida = 1)
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
where CO.Nombre like '%'+@NombreComprador+'%' --and ee.IdEmbarqueEncabezado not in (select IdEmbarqueEncabezado from SalidaPacasEncabezado where EstatusSalida = 1)
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
--where  ee.IdEmbarqueEncabezado not in (select IdEmbarqueEncabezado from SalidaPacasEncabezado where EstatusSalida = 1)
end