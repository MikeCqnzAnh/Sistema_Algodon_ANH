CREATE procedure sp_ConsultaOrdenTrabajo
--declare
@IdOrdenTrabajo int 
as
Declare @Modulos VARCHAR(MAX) = '' 
SELECT @Modulos =  @Modulos +'-' + convert(varchar(10),a.IdBoleta) from [dbo].[OrdenTrabajoDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo
SET @Modulos = SUBSTRING(@Modulos,2,LEN(@Modulos))
--SELECT @Modulos as 'Modulos'
select otr.IdPlanta as IdplantaOrigen,
	   cli.IdCliente,
	   Cli.Nombre,
	   @Modulos as Modulos,
	   otr.NumeroModulos	
from OrdenTrabajo OTR inner join Clientes Cli on otr.IdProductor = Cli.IdCliente
where OTR.IdOrdenTrabajo = @IdOrdenTrabajo					