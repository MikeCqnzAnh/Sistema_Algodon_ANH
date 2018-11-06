create proc [dbo].[sp_ConsultaTierrasBusqueda]
@NombreLote as varchar(15)
as
select IdTierra
	  ,Lote
	  ,Colonia
	  ,Propietario
	  ,RegistroAlterno
	  ,SuperficieTotal
	  ,SuperficieCultivable
	  ,LatitudGrados
	  ,LatitudHoras
	  ,LatitudMinutos
	  ,LongitudGrados
	  ,LongitudHoras
	  ,LongitudMinutos
	  ,NumeroRpp
	  ,FolioRpp
	  ,LibroRpp
	  ,Fecha
	  ,TituloAgua
	  ,RegimenHidrico
	  ,FechaTituloAgua
	  ,IdEstatus
	  ,IdUsuarioCreacion
	  ,FechaCreacion 
from Tierras
where Lote like '%'+@NombreLote+'%'