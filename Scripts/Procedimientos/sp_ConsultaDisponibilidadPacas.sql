CREATE proc sp_ConsultaDisponibilidadPacas
--declare
@IdProductor int
as
select (select count(isnull(pd.FolioCIA,0)) 
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join hvidetalle hvid 
		on pd.FolioCIA = hvid.BaleID 
		where pr.IdCliente = @IdProductor and isnull(hvid.EstatusCompra,0) = 1) as 'Disponibles',
		 
	   (select isnull(SUM(pd.KILOS),0) 
	    from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join hvidetalle hvid 
		on pd.FolioCIA = hvid.BaleID 
		where pr.IdCliente = @IdProductor and isnull(hvid.EstatusCompra,0) = 2) as 'Kilos Comprados',

	  (select count(isnull(pd.FolioCIA,0)) 
	   from Produccion pr inner join ProduccionDetalle pd 
	   on pr.IdProduccion = pd.IdProduccion left join hvidetalle hvid 
	   on pd.FolioCIA = hvid.BaleID 
	   where pr.IdCliente = @IdProductor and isnull(hvid.EstatusCompra,0) = 2) as 'Compradas',

	  (select count(isnull(pd.FolioCIA,0)) 
	   from Produccion pr inner join ProduccionDetalle pd 
	   on pr.IdProduccion = pd.IdProduccion left join hvidetalle hvid 
	   on pd.FolioCIA = hvid.BaleID 
	   where pr.IdCliente = @IdProductor and isnull(hvid.EstatusCompra,0) = 3) as 'Devolucion',

	  (select count(isnull(pd.FolioCIA,0)) 
	   from Produccion pr inner join ProduccionDetalle pd 
	   on pr.IdProduccion = pd.IdProduccion left join hvidetalle hvid 
	   on pd.FolioCIA = hvid.BaleID 
	   where pr.IdCliente = @IdProductor and isnull(hvid.EstatusCompra,0) = 0) as 'Sin Clasificar'
