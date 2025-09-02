alter Procedure Sp_ConsultaEmbarqueParaSalida
@IdEmbarqueEncabezado int 
as
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
	  ,isnull(sp.EstatusSalida,0) as EstatusSalida
from EmbarqueEncabezado EE inner join Compradores CO on ee.idcomprador = co.IdComprador
						   left join SalidaPacasEncabezado sp on ee.IdEmbarqueEncabezado = sp.IdEmbarqueEncabezado
where ee.idEmbarqueEncabezado = @IdEmbarqueEncabezado and sp.EstatusSalida <> 1