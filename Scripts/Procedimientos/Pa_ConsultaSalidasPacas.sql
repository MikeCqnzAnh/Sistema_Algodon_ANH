alter Procedure Pa_ConsultaSalidasPacas
@IdSalidaEncabezado int,
@NombreComprador varchar(20)
as
if @IdSalidaEncabezado > 0 and @NombreComprador = ''
begin
select sp.IdSalidaEncabezado
	  ,sp.IdEmbarqueEncabezado
	  ,em.IdComprador
	  ,co.Nombre
	  ,sp.NombreChofer
	  ,sp.PlacaTractoCamion 
	  ,sp.NoLicencia
	  ,sp.Telefono
	  ,sp.Destino
	  ,sp.FolioSalida
	  ,sp.NoFactura
	  ,sp.FechaSalida
	  ,sp.FechaEntrada
	  ,sp.Observaciones
	  ,sp.PesoBruto
	  ,sp.PesoTara
	  ,sp.PesoNeto
	  ,sp.EstatusSalida
from salidapacasencabezado sp inner join EmbarqueEncabezado em on sp.IdEmbarqueEncabezado = em.IdEmbarqueEncabezado
							  inner join Compradores co on em.IdComprador = co.IdComprador
where sp.IdSalidaEncabezado = @IdSalidaEncabezado
end
else if  @IdSalidaEncabezado = 0 and @NombreComprador <> ''
begin
select sp.IdSalidaEncabezado
	  ,sp.IdEmbarqueEncabezado
	  ,em.IdComprador
	  ,co.Nombre
	  ,sp.NombreChofer
	  ,sp.PlacaTractoCamion 
	  ,sp.NoLicencia
	  ,sp.Telefono
	  ,sp.Destino
	  ,sp.FolioSalida
	  ,sp.NoFactura
	  ,sp.FechaSalida
	  ,sp.FechaEntrada
	  ,sp.Observaciones
	  ,sp.PesoBruto
	  ,sp.PesoTara
	  ,sp.PesoNeto
	  ,sp.EstatusSalida
from salidapacasencabezado sp inner join EmbarqueEncabezado em on sp.IdEmbarqueEncabezado = em.IdEmbarqueEncabezado
							  inner join Compradores co on em.IdComprador = co.IdComprador
where co.Nombre like '%'+@NombreComprador+'%'
end
else 
begin
select sp.IdSalidaEncabezado
	  ,sp.IdEmbarqueEncabezado
	  ,em.IdComprador
	  ,co.Nombre
	  ,sp.NombreChofer
	  ,sp.PlacaTractoCamion 
	  ,sp.NoLicencia
	  ,sp.Telefono
	  ,sp.Destino
	  ,sp.FolioSalida
	  ,sp.NoFactura
	  ,sp.FechaSalida
	  ,sp.FechaEntrada
	  ,sp.Observaciones
	  ,sp.PesoBruto
	  ,sp.PesoTara
	  ,sp.PesoNeto
	  ,sp.EstatusSalida
from salidapacasencabezado sp inner join EmbarqueEncabezado em on sp.IdEmbarqueEncabezado = em.IdEmbarqueEncabezado
							  inner join Compradores co on em.IdComprador = co.IdComprador
end