exec Sp_CursorResultadosProduccion

Create Procedure Sp_CursorResultadosProduccion
as
if object_id('tempdb..##TablaTempModulos') is not null
  begin
    drop table ##TablaTempModulos	
  end
  create table ##TablaTempModulos(
		IdOrdenTrabajo int,
		IdProductor int,
		Nombre nvarchar(100),
		IdPlanta int,
		Planta nvarchar(50),
		Fecha DATETIME,
		CantidadModulos int,
		TotalHueso float,
		TotalPluma float,
		PorcentajePluma float,
		PorcentajeSemilla float,
		TotalSemilla float,
		PorcentajeMerma float,
		TotalMerma float,
		TotalPacas int
		)
declare 
@IdOrdenTrabajo as int,
@IdProductor as int,
@Nombre nvarchar(100),
@IdPlanta int,
@Planta as  nvarchar(50),
@Fecha as datetime,
@CantidadModulos int,
@TotalHueso float = 0,
@TotalPluma float = 0,
@PorcentajePluma float = 0,
@PorcentajeSemilla float = 0,
@TotalSemilla float = 0,
@PorcentajeMerma float = 0,
@TotalMerma float = 0,
@TotalPacas int = 0
declare OrdenInfo cursor read_only  for select ord.IdOrdenTrabajo,cli.IdCliente,cli.nombre,Pla.IdPlanta as IdPlanta,pla.descripcion as Planta,(select min(fecha) from ProduccionDetalle where IdOrdenTrabajo = pro.IdOrdenTrabajo) as FechaProduccion 
										from ordentrabajo ord inner join produccion pro on ord.idordentrabajo = pro.idordentrabajo inner join plantas pla on ord.IdPlanta = pla.IdPlanta 
															  inner join Clientes cli on pro.idcliente = cli.idcliente
										where ord.idordentrabajo in (select DISTINCT IDORDENTRABAJO from ordentrabajodetalle WHERE BRUTO IS NOT NULL AND BRUTO > 0 )
										order by ord.idordentrabajo
open OrdenInfo
fetch next from ordeninfo into @IdOrdenTrabajo,@IdProductor,@Nombre,@IdPlanta,@Planta,@Fecha
while @@FETCH_STATUS = 0
begin	
		set @CantidadModulos = (select COUNT(IdOrdenTrabajo) as CantidadModulos from [dbo].[OrdenTrabajoDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo)
		set @TotalHueso = (select ISNULL(a.PesoModulos,0) as TotalHueso from [dbo].[OrdenTrabajo] a where a.IdOrdenTrabajo = @IdOrdenTrabajo)
		set @TotalPluma = (select SUM(a.Kilos) as TotalPluma from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo)
		set @PorcentajePluma = ROUND(@TotalPluma/@TotalHueso * 100,0)
		set @PorcentajeSemilla = ISNULL((select Semilla from [dbo].[Rendimientos] where Pluma = @PorcentajePluma),0)
		set @TotalSemilla = (@PorcentajeSemilla * @TotalPluma)/ @PorcentajePluma
		set @PorcentajeMerma = (100 - @PorcentajeSemilla - @PorcentajePluma)
		set @TotalMerma = (@TotalHueso - @TotalPluma - @TotalSemilla)
		set @TotalPacas = (select COUNT(IdOrdenTrabajo) from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo)

		Insert into ##TablaTempModulos(IdOrdenTrabajo,IdProductor,Nombre,IdPlanta,Planta,FECHA,CantidadModulos,TotalHueso,TotalPluma,PorcentajePluma,PorcentajeSemilla,TotalSemilla,PorcentajeMerma,TotalMerma,TotalPacas)
		VALUES (@IdOrdenTrabajo,@IdProductor,@Nombre,@IdPlanta,@Planta,@Fecha,@CantidadModulos,@TotalHueso,@TotalPluma,@PorcentajePluma,@PorcentajeSemilla,@TotalSemilla,@PorcentajeMerma,@TotalMerma,@TotalPacas)

	fetch next from ordeninfo into @IdOrdenTrabajo,@IdProductor,@Nombre,@IdPlanta,@Planta,@Fecha
end
close ordeninfo
deallocate ordeninfo

