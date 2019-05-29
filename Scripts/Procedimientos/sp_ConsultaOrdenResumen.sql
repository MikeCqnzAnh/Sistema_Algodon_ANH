create procedure sp_ConsultaOrdenResumen
--declare
@IdOrdenTrabajo int 
as
if object_id('tempdb..##TablaTemp') is not null
  begin
    drop table ##TablaTemp
  end
else
begin
create table ##TablaTemp(
TotalHueso float,
TotalPluma float,
PorcentajePluma float,
PorcentajeSemilla float,
TotalSemilla float,
PorcentajeMerma float,
TotalMerma float,
TotalPacas int,
TotalBorregos int,
TotalPlumaBorregos float
)
end
declare
@TotalHueso float = 0,
@TotalPluma float = 0,
@PorcentajePluma float = 0,
@PorcentajeSemilla float = 0,
@TotalSemilla float = 0,
@PorcentajeMerma float = 0,
@TotalMerma float = 0,
@TotalPacas int = 0,
@TotalBorregos int = 0,
@TotalPlumaBorregos float = 0
set @TotalHueso = (select ISNULL(a.PesoModulos,0) as TotalHueso from [dbo].[OrdenTrabajo] a where a.IdOrdenTrabajo = @IdOrdenTrabajo)
set @TotalPluma = (select SUM(a.Kilos) as TotalPluma from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo)
set @PorcentajePluma = ROUND(@TotalPluma/@TotalHueso * 100,0)
set @PorcentajeSemilla = ISNULL((select Semilla from [dbo].[Rendimientos] where Pluma = @PorcentajePluma),0)
set @TotalSemilla = (@PorcentajeSemilla * @TotalPluma)/ @PorcentajePluma
set @PorcentajeMerma = (100 - @PorcentajeSemilla - @PorcentajePluma)
set @TotalMerma = (@TotalHueso - @TotalPluma - @TotalSemilla)
set @TotalPacas = (select COUNT(IdOrdenTrabajo) from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo)
set @TotalBorregos = (select COUNT(IdOrdenTrabajo) from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo and a.Kilos < 180)
set @TotalPlumaBorregos = ISNULL((select SUM(a.Kilos) from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo and a.Kilos < 180),0)

Insert into ##TablaTemp(TotalHueso,TotalPluma,PorcentajePluma,PorcentajeSemilla,TotalSemilla,PorcentajeMerma,TotalMerma,TotalPacas,TotalBorregos,TotalPlumaBorregos)
VALUES (@TotalHueso,@TotalPluma,@PorcentajePluma,@PorcentajeSemilla,@TotalSemilla,@PorcentajeMerma,@TotalMerma,@TotalPacas,@TotalBorregos,@TotalPlumaBorregos)
select*from ##TablaTemp

