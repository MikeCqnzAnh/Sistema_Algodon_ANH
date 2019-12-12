Alter proc sp_ConsultaDisponibilidadPacasVentas
as
select (select count(isnull(BaleID,0)) 
		from  CalculoClasificacion  
		where isnull(EstatusVenta,0) = 1) as 'Disponibles',
		 
	   (select isnull(SUM(Kilos),0) 
	    from CalculoClasificacion  
		where  isnull(EstatusVenta,0) = 2) as 'Kilos Comprados',

	  (select count(isnull(BaleID,0)) 
	   from  CalculoClasificacion  
	   where  isnull(EstatusVenta,0) = 2) as 'Vendidas',

	  (select count(isnull(BaleID,0)) 
	   from CalculoClasificacion  
	   where isnull(EstatusVenta,0) = 3) as 'Devolucion',

	  (select count(isnull(BaleID,0)) 
	   from CalculoClasificacion  
	   where isnull(EstatusVenta,0) = 0) as 'Sin Clasificar'
