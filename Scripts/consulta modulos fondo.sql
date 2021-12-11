--Create Procedure Sp_CursorResultadosProduccion
--as
if object_id('tempdb..##TablaTempModul1') is not null
  begin
    drop table ##TablaTempModul1	
  end
  create table ##TablaTempModul1(
		IdOrdenTrabajo int,
		IdProductor int,
		Nombre nvarchar(100),
		IdPlanta int,
		Predio NVARCHAR(30),
		Planta nvarchar(50),
		FechaEntProd DATETIME,
		FechaSalProd DATETIME,
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
@Predio AS NVARCHAR(30),
@FechaEntProd as datetime,
@FechaSalProd as datetime,
@CantidadModulos int,
@TotalHueso float = 0,
@TotalPluma float = 0,
@PorcentajePluma float = 0,
@PorcentajeSemilla float = 0,
@TotalSemilla float = 0,
@PorcentajeMerma float = 0,
@TotalMerma float = 0,
@TotalPacas int = 0
declare OrdenInfo cursor read_only  for select ord.IdOrdenTrabajo
											  ,cli.IdCliente
											  ,cli.nombre
											  ,Pla.IdPlanta as IdPlanta
											  ,pla.descripcion as Planta
											  ,ord.Predio 
											  ,(select min(fecha) from ProduccionDetalle where IdOrdenTrabajo = pro.IdOrdenTrabajo) as FechaEntProd 
											  ,(select max(fecha) from ProduccionDetalle where IdOrdenTrabajo = pro.IdOrdenTrabajo) as FechaSalProd
										from ordentrabajo ord inner join produccion pro on ord.idordentrabajo = pro.idordentrabajo inner join plantas pla on ord.IdPlanta = pla.IdPlanta 
															  inner join Clientes cli on pro.idcliente = cli.idcliente
										where ord.idordentrabajo in (select DISTINCT IDORDENTRABAJO from ordentrabajodetalle WHERE BRUTO IS NOT NULL AND BRUTO > 0 ) --and (select min(fecha) from ProduccionDetalle where IdOrdenTrabajo = pro.IdOrdenTrabajo) between '01/11/2021' and '30/11/2021' 
										order by ord.idordentrabajo
open OrdenInfo
fetch next from ordeninfo into @IdOrdenTrabajo,@IdProductor,@Nombre,@IdPlanta,@Planta,@Predio,@FechaEntProd,@FechaSalProd
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

		Insert into ##TablaTempModul1(IdOrdenTrabajo,IdProductor,Nombre,IdPlanta,Planta,Predio,FechaEntProd,FechaSalProd,CantidadModulos,TotalHueso,TotalPluma,PorcentajePluma,PorcentajeSemilla,TotalSemilla,PorcentajeMerma,TotalMerma,TotalPacas)
		VALUES (@IdOrdenTrabajo,@IdProductor,@Nombre,@IdPlanta,@Planta,@Predio,@FechaEntProd,@FechaSalProd,@CantidadModulos,@TotalHueso,@TotalPluma,@PorcentajePluma,@PorcentajeSemilla,@TotalSemilla,@PorcentajeMerma,@TotalMerma,@TotalPacas)

	fetch next from ordeninfo into @IdOrdenTrabajo,@IdProductor,@Nombre,@IdPlanta,@Planta,@Predio,@FechaEntProd,@FechaSalProd
end
close ordeninfo
deallocate ordeninfo

go
select * from ##TablaTempModul1 --where FechaEntProd between '01/11/2021' and '30/11/2021'
