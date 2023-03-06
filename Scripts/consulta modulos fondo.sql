--Create Procedure Sp_CursorResultadosProduccion
--as
declare 
@fecent date = '01/01/2023',
@fecsal date = '31/01/2023'

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
										--where cast((select min(fecha) from ProduccionDetalle where IdOrdenTrabajo = pro.IdOrdenTrabajo) as date) between @fecent and @fecsal
										order by ord.idordentrabajo
open OrdenInfo
fetch next from ordeninfo into @IdOrdenTrabajo,@IdProductor,@Nombre,@IdPlanta,@Planta,@Predio,@FechaEntProd,@FechaSalProd
while @@FETCH_STATUS = 0
begin	
		set @CantidadModulos = (select COUNT(IdOrdenTrabajo) as CantidadModulos from [dbo].[OrdenTrabajoDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo and a.flagcancelada = 0 /*and CAST(FechaEntrada AS DATE) between @fecent and @fecsal*/)
		set @TotalHueso = (select sum(a.Total) as TotalHueso from [dbo].[OrdenTrabajoDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo and a.flagcancelada = 0 /*and CAST(FechaEntrada AS DATE) between @fecent and @fecsal*/)
		set @TotalPluma = (select SUM(a.Kilos) as TotalPluma from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo /*and CAST(Fecha AS DATE) between @fecent and @fecsal*/)
		set @PorcentajePluma = ROUND(@TotalPluma/@TotalHueso * 100,0)
		set @PorcentajeSemilla = ISNULL((select Semilla from [dbo].[Rendimientos] where Pluma = @PorcentajePluma),0)
		set @TotalSemilla = (@PorcentajeSemilla * @TotalPluma)/ @PorcentajePluma
		set @PorcentajeMerma = (100 - @PorcentajeSemilla - @PorcentajePluma)
		set @TotalMerma = (@TotalHueso - @TotalPluma - @TotalSemilla)
		set @TotalPacas = (select COUNT(foliocia) from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo /*and CAST(Fecha AS DATE) between @fecent and @fecsal*/)

		Insert into ##TablaTempModul1(IdOrdenTrabajo,IdProductor,Nombre,IdPlanta,Planta,Predio,FechaEntProd,FechaSalProd,CantidadModulos,TotalHueso,TotalPluma,PorcentajePluma,PorcentajeSemilla,TotalSemilla,PorcentajeMerma,TotalMerma,TotalPacas)
		VALUES (@IdOrdenTrabajo,@IdProductor,@Nombre,@IdPlanta,@Planta,@Predio,@FechaEntProd,@FechaSalProd,@CantidadModulos,@TotalHueso,@TotalPluma,@PorcentajePluma,@PorcentajeSemilla,@TotalSemilla,@PorcentajeMerma,@TotalMerma,@TotalPacas)

	fetch next from ordeninfo into @IdOrdenTrabajo,@IdProductor,@Nombre,@IdPlanta,@Planta,@Predio,@FechaEntProd,@FechaSalProd
end
close ordeninfo
deallocate ordeninfo;

select * from ##TablaTempModul1 where TotalPluma is not null order by fechaentprod; --and CAST(Fechaentprod AS DATE) between @fecent and @fecsal

--SELECT * FROM ORDENTRABAJODETALLE WHERE idordentrabajo = 1
--select IdOrdenTrabajo,count(FolioCIA) from producciondetalle where idplantaorigen = 1 and IdOrdenTrabajo not in(select ord.IdOrdenTrabajo											  
--										from ordentrabajo ord inner join produccion pro on ord.idordentrabajo = pro.idordentrabajo inner join plantas pla on ord.IdPlanta = pla.IdPlanta 
--															  left join Clientes cli on pro.idcliente = cli.idcliente
--										where ord.idordentrabajo in (select DISTINCT IDORDENTRABAJO from ordentrabajodetalle WHERE  IdPlantaOrigen = 1 and FlagCancelada = 0)) group by IdOrdenTrabajo order by IdOrdenTrabajo




--select IdPlanta,idordentrabajo from ordentrabajo where IdOrdenTrabajo in (1,259,268,272) order by IdOrdenTrabajo
--select IdPlanta,idordentrabajo,count(IdBoleta) from OrdenTrabajoDetalle where IdOrdenTrabajo in (1,259,268,272) group by IdPlanta,IdOrdenTrabajo order by IdOrdenTrabajo
--select IdPlantaOrigen,idproduccion,idordentrabajo from Produccion where IdOrdenTrabajo in (1,259,268,272)order by IdOrdenTrabajo
--select IdPlantaOrigen,COUNT(FolioCIA) from ProduccionDetalle group by IdPlantaOrigen order by IdOrdenTrabajo
--select IdPlantaOrigen,idordentrabajo,COUNT(BaleID) from hvidetalle  where IdOrdenTrabajo in (1,259,268,272) group by IdPlantaOrigen,IdOrdenTrabajo order by IdOrdenTrabajo

--update produccion
--set IdPlantaOrigen = 1
--where IdOrdenTrabajo in (272)

--update hvidetalle
--set idplantaorigen = 3
--where IdOrdenTrabajo in (259,268)

--select * from HVIEncabezado