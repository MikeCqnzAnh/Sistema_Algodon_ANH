Create Procedure Sp_ConsultaCompradorSalidas
--declare
@Nombre varchar(30) 
as
if @Nombre <> '' 
begin
select idcomprador,Nombre 
from Compradores 
where Nombre like '%'+@Nombre+'%' and IdComprador in (select distinct IdComprador from SalidaPacasEncabezado sp inner join  EmbarqueEncabezado ee on sp.IdEmbarqueEncabezado = ee.IdEmbarqueEncabezado where sp.EstatusSalida = 1 )
end
else
begin
select idcomprador,Nombre 
from Compradores 
where IdComprador in (select distinct IdComprador from SalidaPacasEncabezado sp inner join  EmbarqueEncabezado ee on sp.IdEmbarqueEncabezado = ee.IdEmbarqueEncabezado where sp.EstatusSalida = 1 )
end

