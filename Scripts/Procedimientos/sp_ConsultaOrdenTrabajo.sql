CREATE procedure sp_ConsultaOrdenTrabajo
@IdOrdenTrabajo int
as
Declare @Modulos VARCHAR(MAX) = '' 
SELECT @Modulos =  @Modulos +'-' + convert(varchar(10),a.IdBoleta) from [dbo].[OrdenTrabajoDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo
SET @Modulos = SUBSTRING(@Modulos,2,LEN(@Modulos))
--SELECT @Modulos as 'Modulos'
select a.IdPlanta as IdPlantaOrigen,
       b.IdCliente,
	   b.Nombre,
	   @Modulos as Modulos,
	   a.NumeroModulos
from [dbo].[OrdenTrabajo] a,
     [dbo].[Clientes] b	
where a.IdOrdenTrabajo = @IdOrdenTrabajo
and   a.IdProductor = b.IdCliente
