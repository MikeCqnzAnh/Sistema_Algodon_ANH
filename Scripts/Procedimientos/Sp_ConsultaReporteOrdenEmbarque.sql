alter Procedure Sp_ConsultaReporteOrdenEmbarque
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
	  ,EE.Observaciones
	  ,ED.BaleID
	  ,ED.Kilos
	  ,ED.NoContenedor
	  ,ED.NoLote
	  ,@Habilitakilos as HabilitaKilos
from EmbarqueEncabezado EE inner join CalculoClasificacion ED on EE.IdEmbarqueEncabezado = ED.IdEmbarqueEncabezado 
														 inner join Compradores CO on ee.IdComprador = CO.IdComprador
where ee.IdEmbarqueEncabezado = @IdEmbarqueEncabezado and ed.NoLote = @NoLote
order by ED.BaleID