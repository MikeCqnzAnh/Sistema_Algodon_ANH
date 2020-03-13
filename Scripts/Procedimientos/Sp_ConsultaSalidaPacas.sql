alter Procedure Sp_ConsultaSalidaPacas
@IdSalidaPacas int,
@NombreComprador varchar(100)
as
if @IdSalidaPacas = 0 and @NombreComprador = ''
begin
select SP.IdSalidaEncabezado
	  ,ee.IdEmbarqueEncabezado
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
	  ,ee.Fecha
	  ,sp.NoLote
	  ,sp.PesoBruto
	  ,sp.PesoTara
	  ,sp.PesoNeto
	  ,sp.Destino
	  ,sp.NoFactura
	  ,sp.FechaEntrada
	  ,sp.FechaSalida
	  ,sp.Observaciones
	  ,sp.EstatusSalida
from SalidaPacasEncabezado SP inner join EmbarqueEncabezado EE on SP.IdEmbarqueEncabezado = EE.IdEmbarqueEncabezado
							  inner join Compradores CO on EE.IdComprador = CO.IdComprador
end
else if @IdSalidaPacas > 0 and @NombreComprador = ''
begin 
select SP.IdSalidaEncabezado
	  ,ee.IdEmbarqueEncabezado
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
	  ,ee.Fecha
	  ,sp.NoLote
	  ,sp.PesoBruto
	  ,sp.PesoTara
	  ,sp.PesoNeto
	  ,sp.Destino
	  ,sp.NoFactura
	  ,sp.FechaEntrada
	  ,sp.FechaSalida
	  ,sp.Observaciones
	  ,sp.EstatusSalida
from SalidaPacasEncabezado SP inner join EmbarqueEncabezado EE on SP.IdEmbarqueEncabezado = EE.IdEmbarqueEncabezado
							  inner join Compradores CO on EE.IdComprador = CO.IdComprador
where IdSalidaEncabezado = @IdSalidaPacas
end
else if @IdSalidaPacas = 0 and @NombreComprador <> ''
begin 
select SP.IdSalidaEncabezado
	  ,ee.IdEmbarqueEncabezado
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
	  ,ee.Fecha
	  ,sp.NoLote
	  ,sp.PesoBruto
	  ,sp.PesoTara
	  ,sp.PesoNeto
	  ,sp.Destino
	  ,sp.NoFactura
	  ,sp.FechaEntrada
	  ,sp.FechaSalida
	  ,sp.Observaciones
	  ,sp.EstatusSalida
from SalidaPacasEncabezado SP inner join EmbarqueEncabezado EE on SP.IdEmbarqueEncabezado = EE.IdEmbarqueEncabezado
							  inner join Compradores CO on EE.IdComprador = CO.IdComprador
where co.Nombre like '%'+@NombreComprador+'%'
end
else 
begin 
select SP.IdSalidaEncabezado
	  ,ee.IdEmbarqueEncabezado
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
	  ,ee.Fecha
	  ,sp.NoLote
	  ,sp.PesoBruto
	  ,sp.PesoTara
	  ,sp.PesoNeto
	  ,sp.Destino
	  ,sp.NoFactura
	  ,sp.FechaEntrada
	  ,sp.FechaSalida
	  ,sp.Observaciones
	  ,sp.EstatusSalida
from SalidaPacasEncabezado SP inner join EmbarqueEncabezado EE on SP.IdEmbarqueEncabezado = EE.IdEmbarqueEncabezado
							  inner join Compradores CO on EE.IdComprador = CO.IdComprador
where co.Nombre like '%'+@NombreComprador+'%' and IdSalidaEncabezado = @IdSalidaPacas
end