CREATE Procedure Sp_ConsultaReporteOrdenEmbarque
@HabilitaKilos bit = 0,
@IdEmbarqueEncabezado int,
@NoLote varchar(12)
as
select ee.IdEmbarqueEncabezado
	  ,ee.IdComprador
	  ,CO.Nombre
	  ,ee.NombreChofer
	  ,ee.NoLicencia
	  ,ee.PlacaTractoCamion
	  ,EE.Fecha
	  ,eed.ObservacionLote as Observaciones
	  ,ED.BaleID
	  ,ED.Kilos
	  ,ED.NoContenedor
	  ,ED.NoLote
	  ,PL.Descripcion as Planta
	  ,@Habilitakilos as HabilitaKilos
from EmbarqueEncabezado EE inner join CalculoClasificacion ED on EE.IdEmbarqueEncabezado = ED.IdEmbarqueEncabezado 
														 inner join Compradores CO on ee.IdComprador = CO.IdComprador
														 inner join EmbarqueDet eed on eed.Idembarqueenc = ed.IdEmbarqueEncabezado and eed.nolote = ed.NoLote
														 inner join Plantas PL on ed.IdPlantaOrigen = PL.IdPlanta
where ee.IdEmbarqueEncabezado = @IdEmbarqueEncabezado and ed.NoLote = @NoLote
order by ED.BaleID