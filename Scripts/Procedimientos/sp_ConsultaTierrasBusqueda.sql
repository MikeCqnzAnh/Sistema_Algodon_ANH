Create Procedure [dbo].[sp_ConsultaTierrasBusqueda]
@NombreLote as varchar(15)
as
select ti.IdTierra
	  ,ti.Lote
	  ,co.Descripcion
	  ,cl.Nombre
	  ,ti.RegistroAlterno
	  ,ti.SuperficieTotal
	  ,ti.SuperficieCultivable
	  ,ti.LatitudGrados
	  ,ti.LatitudHoras
	  ,ti.LatitudMinutos
	  ,ti.LongitudGrados
	  ,ti.LongitudHoras
	  ,ti.LongitudMinutos
	  ,ti.NumeroRpp
	  ,ti.FolioRpp
	  ,ti.LibroRpp
	  ,ti.Fecha
	  ,ti.TituloAgua
	  ,ti.RegimenHidrico
	  ,ti.FechaTituloAgua
	  ,ti.IdEstatus
	  ,ti.IdUsuarioCreacion
	  ,ti.FechaCreacion 
from Tierras ti inner join clientes cl on
	   ti.Propietario = cl.idcliente
				inner join Colonias co on
	   ti.Colonia = co.IdColonia
where Lote like '%'+@NombreLote+'%'