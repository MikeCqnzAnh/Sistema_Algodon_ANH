select * from salidapacasencabezado
select * from salidapacasencabezado1
--insert into salidapacasencabezado
select  ee.IdEmbarqueEncabezado
	   ,0 as IdCompradorPorCuentade
	   ,ee.nombrechofer
	   ,ee.PlacaTractoCamion
	   ,ee.NoLicencia 
	   ,ee.Telefono
	   ,spe.PesoBruto
	   ,spe.PesoTara
	   ,spe.PesoNeto
	   ,spe.Destino
	   ,spe.FolioSalida
	   ,spe.NoFactura
	   ,ee.NoContenedorCaja1 as NoContenedor
	   ,ee.PlacaCaja1 as PlacaCaja
	   ,spe.fechaentrada
	   ,spe.FechaSalida
	   ,spe.observaciones
	   ,spe.EstatusSalida
from SalidaPacasEncabezado1 spe inner join embarqueencabezado ee on spe.idembarqueencabezado = ee.IdEmbarqueEncabezado
order by spe.IdSalidaEncabezado