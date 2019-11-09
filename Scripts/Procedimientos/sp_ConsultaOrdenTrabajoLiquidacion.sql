CREATE proc sp_ConsultaOrdenTrabajoLiquidacion  
--declare
@IdOrdenTrabajo as int  = 1
as  
if exists (select idordentrabajo from LiquidacionesPorRomaneaje where IdOrdenTrabajo = @IdOrdenTrabajo)   
  select Pr.IdOrdenTrabajo,   
      Pr.IdPlantaOrigen,  
      lpr.IdLiquidacion,  
      cl.Nombre,  
      isnull(Aso.Descripcion,'') as PorCuenta,   
      lpr.Fecha,  
      lpr.Comentarios,  
      Pr.Tipo,  
      pr.TotalHueso,   
      Pr.Pacas,   
      Pr.PlumaPacas,  
      pr.PlumaBorregos,  
      pr.pluma,  
      pr.semilla,  
      pr.merma,  
      pr.borra,  
      pr.porcentajepluma,  
      pr.porcentajesemilla,  
      pr.porcentajemerma,  
      PR.IdCliente,   
     ISNULL(Aso.IdAsociacion,'' ) as IdPorCuenta  
  from LiquidacionesPorRomaneaje Lpr right join Produccion Pr  on Lpr.IdOrdenTrabajo = Pr.IdOrdenTrabajo  
             right join OrdenTrabajoDetalle Bo on Pr.IdOrdenTrabajo = Bo.IdOrdenTrabajo  
             right join Clientes Cl on pr.IdCliente = Cl.IdCliente  
             left join Asociaciones Aso on cl.IdCuentaDe = Aso.IdAsociacion  
  where Pr.IdOrdenTrabajo = @IdOrdenTrabajo  
  group by Pr.IdOrdenTrabajo,   
     Pr.IdPlantaOrigen,  
     lpr.IdLiquidacion,   
     Pr.Tipo,   
     PR.IdCliente,   
     Aso.IdAsociacion,   
     cl.Nombre,   
     Aso.Descripcion,  
     lpr.Fecha,  
     lpr.Comentarios,   
     Pr.totalhueso,  
     pr.pacas,  
     pr.plumapacas,  
     pr.plumaborregos,  
     pr.pluma,  
     pr.semilla,  
     pr.merma,   
     pr.borra,   
     pr.porcentajepluma,   
     pr.porcentajesemilla,  
     pr.porcentajemerma  
else  
  select Pr.IdOrdenTrabajo,   
      Pr.IdPlantaOrigen,  
      '' as IdLiquidacion,  
      cl.Nombre,  
      isnull(Aso.Descripcion,'') as PorCuenta,   
      GETDATE() as Fecha,  
      '' as Comentarios,   
      Pr.Tipo,  
      pr.TotalHueso,   
      Pr.Pacas,   
      Pr.PlumaPacas,  
      pr.PlumaBorregos,  
      pr.pluma,  
      pr.semilla,  
      pr.merma,  
      pr.borra,  
      pr.porcentajepluma,  
      pr.porcentajesemilla,  
      pr.porcentajemerma,  
      PR.IdCliente,   
     ISNULL(Aso.IdAsociacion,'' ) as IdPorCuenta  
  from Produccion Pr right join OrdenTrabajoDetalle Bo on Pr.IdOrdenTrabajo = Bo.IdOrdenTrabajo  
         right join Clientes Cl on pr.IdCliente = Cl.IdCliente  
         left join Asociaciones Aso on cl.IdCuentaDe = Aso.IdAsociacion  
  where Pr.IdOrdenTrabajo = @IdOrdenTrabajo  
  group by Pr.IdOrdenTrabajo,   
     Pr.IdPlantaOrigen,   
     Pr.Tipo,   
     PR.IdCliente,   
     Aso.IdAsociacion,   
     cl.Nombre,   
     Aso.Descripcion,   
     Pr.totalhueso,  
     pr.pacas,  
     pr.plumapacas,  
     pr.plumaborregos,  
     pr.pluma,  
     pr.semilla,  
     pr.merma,   
     pr.borra,   
     pr.porcentajepluma,   
     pr.porcentajesemilla,  
     pr.porcentajemerma