alter procedure sp_ActualizaEstatusCompraPaca
@IdProductor int ,
@IdPlanta int,
@BaleID int ,
@IdLiquidacion int,
@IdCompraEnc int,
@PrecioDls float,
@TipoCambio float,
@PrecioMxn float,
@CastigoResistenciaFibra float,
@CastigoMicros float,
@CastigoLargoFibra float,
@EstatusCompraUpdate int,
@EstatusCompraBusqueda int
as
update hd
set hd.estatuscompra = @EstatusCompraUpdate ,
	hd.IdCompraEnc =   case when @IdCompraEnc = 0 then NULL ELSE @IdCompraEnc END,
	hd.PrecioDls = case when @PrecioDls = 0 then NULL ELSE @PrecioDls END,
	hd.TipoCambio = case when @TipoCambio = 0 then NULL ELSE @TipoCambio END,
	hd.PrecioMxn = case when @PrecioMxn = 0 then NULL ELSE @TipoCambio END,
	hd.CastigoResistenciaFibraCompra =   case when @CastigoResistenciaFibra = 0 then NULL ELSE @CastigoResistenciaFibra END,
	hd.castigoMicCompra =   case when @CastigoMicros = 0 then NULL ELSE @CastigoMicros END,
	hd.CastigoLargoFibraCompra =   case when @CastigoLargoFibra = 0 then NULL ELSE @CastigoLargoFibra END
from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join HviDetalle hd 
		on pd.FolioCIA = hd.BaleID left join liquidacionesporromaneaje LR 
		on hd.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
where pr.IdCliente = @IdProductor and hd.FlagTerminado =1 and hd.EstatusCompra  = @EstatusCompraBusqueda and pd.FolioCIA = @BaleID and LR.IdLiquidacion = @IdLiquidacion and hd.IdPlantaOrigen = @IdPlanta 

go

alter Procedure Sp_ActualizaIdOrdenTrabajoPaqueteHVI
@IdPlanta int,
@BaleId int
as
update hvi
set hvi.IdOrdenTrabajo = pd.IdOrdenTrabajo,
	hvi.Kilos = pd.kilos,
	hvi.Quintales = (hvi.kilos /46.02),
	hvi.Grade = cc.clavecorta,
	hvi.EstatusCompra = 1,
	FlagTerminado = 1
from hvidetalle hvi inner join producciondetalle pd on hvi.idplantaorigen = pd.IdPlantaOrigen and hvi.BaleID = pd.FolioCIA
					left join GradosClasificacion Gc on hvi.ColorGrade = Gc.GradoColor and hvi.TrashID = Gc.TrashId
					left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
where hvi.IdPlantaOrigen = @IdPlanta and hvi.Baleid = @BaleId

go

alter Procedure Sp_CastigoLargoFibra
--declare
@LargoFibra  float
as
declare 
@Lenght int
set @Lenght =(select LenghtNDS from LargosFibraEquivalente where @LargoFibra >=  Rango1 and @LargoFibra <=  Rango2)

select Castigo 
from LargosDeFibra
where @Lenght between  Rango1 and Rango2

go

alter procedure Sp_CastigoUnidormidadCompras
@Uniformidad float
as
select castigo 
from uniformidadCompras 
where @Uniformidad between rango1 and  rango2

go

alter procedure Sp_CastigoUnidormidadVentas
@Uniformidad float
as
select castigo 
from uniformidadVentas
where @Uniformidad between rango1 and rango2

go

Alter procedure sp_ConContProd
@IdProductor int
as
select a.IdContratoAlgodon,
	   a.IdProductor,
	   a.Pacas,
	   a.SuperficieComprometida,
	   a.PrecioQuintal,
	   a.Puntos,
	   a.FechaLiquidacion,
	   a.Temporada,
	   a.IdModalidadCompra,
	   a.PrecioSM,
	   a.PrecioMP,
	   a.preciom,
	   a.PrecioSLMP,
	   a.PrecioSLM,
	   a.PrecioLMP,
	   a.PrecioLM,
	   a.PrecioSGO,
	   a.PrecioGO,
	   a.PrecioO,
	   a.FechaCreacion as Fecha
from [dbo].[ContratoCompra] a
where a.IdEstatus = 1
and a.IdProductor = @IdProductor

go

Alter procedure sp_ConLiqProd
--declare
@IdProductor int ,
@Seleccionar bit = 0 
as
select LR.IdLiquidacion,
	   lr.TotalHueso,
	   count(hvid.BaleID)as PacasCantidad,
	   count(case when hvid.EstatusCompra = 1 then hvid.BaleID end)  as PacasDisponibles,
	   count(case when hvid.EstatusCompra = 2 then hvid.BaleID end)  as PacasCompradas,
	   sum(pd.Kilos) as PesoPluma,
	   lr.TotalSemilla,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join HviDetalle hvid 
		on pd.FolioCIA = hvid.BaleID left join liquidacionesporromaneaje LR 
		on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
		where hvid.FlagTerminado = 1 and lr.IdCliente = @IdProductor 
		group by LR.IdLiquidacion,lr.TotalHueso, lr.TotalSemilla
		having   count(case when hvid.EstatusCompra = 2 then hvid.BaleID end) < Count(hvid.BaleID)

go

Alter procedure sp_ConLiqProdComprada 
--declare
@IdProductor int ,
@IdCompra int ,
@Seleccionar bit = 0 
as
select LR.IdLiquidacion,
	   lr.TotalHueso,
	   count(HVId.BaleID)as PacasCantidad,
	   count(case when HVId.EstatusCompra = 1 then HVId.BaleID end)  as PacasDisponibles,
	   count(case when HVId.EstatusCompra = 2 then HVId.BaleID end)  as PacasCompradas,
	   sum(pd.Kilos) as PesoPluma,
	   lr.TotalSemilla,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join HviDetalle HVId 
		on pd.FolioCIA = HVId.BaleID left join liquidacionesporromaneaje LR 
		on HVId.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta
		where HVId.FlagTerminado = 1 and lr.IdCliente = @IdProductor  and HVId.IdCompraEnc = @IdCompra
		group by LR.IdLiquidacion,lr.TotalHueso, lr.TotalSemilla
		having   count(case when HVId.EstatusCompra = 2 then HVId.BaleID end) > 0

go

Alter procedure sp_ConPacaComprada
--declare
@IdProductor int ,
@IdCompraEnc int ,
@Seleccionar bit = 0 
as
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   LR.IdLiquidacion,
	   Pl.Descripcion,
	   hvid.idplantaorigen,
	   hvid.BaleID,
	   pd.Kilos,
	   hvid.Grade,
	   HviD.quintales,
	   hvid.PrecioDls,
	   Hvid.TipoCambio,
	   Hvid.PrecioMxn,
	   ISNULL(HVID.CastigoUICompra,0) as CastigoUICompra,
	   ISNULL(hvid.castigoMicCompra,0) as castigoMicCompra,
	   ISNULL(hvid.CastigoResistenciaFibraCompra,0) as CastigoResistenciaFibraCompra,
	   ISNULL(hvid.CastigoLargoFibraCompra,0) as CastigoLargoFibraCompra,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd 
		on pr.IdProduccion = pd.IdProduccion left join HviDetalle hvid 
		on pd.FolioCIA = hvid.BaleID left join liquidacionesporromaneaje LR 
		on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo inner join Plantas Pl 
		on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra  = 2 and hvid.IdCompraEnc = @IdCompraEnc

go

Alter procedure sp_ConPacProdDetCla
--declare
@IdProductor int ,
@Seleccionar bit = 0 
as
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   HviD.IdPlantaOrigen,
	   hvid.BaleID,
	   pd.Kilos,
	   hvid.Grade,
	   HviD.quintales,
	   hvid.PrecioDls,
	   Hvid.TipoCambio,
	   Hvid.PrecioMxn,
	   hvid.UI as Uniformidad,
	   hvid.Mic as Micros,
	   hvid.Strength as Resistencia,
	   hvid.UHML as Largo,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       left join HviDetalle hvid on pd.FolioCIA = hvid.BaleID 
						   right join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta
		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra  = 1
		order by BaleID

go

Alter proc sp_consultaClasesCalculo
--DECLARE
@NumPaca int ,
@IdPlanta int,
@IdPaquete int
as
if @NumPaca = 0
	begin
		select
		     hd.[IdPlantaOrigen]
			,Hd.[LotID]
			,hd.[BaleID]
			,hd.[BaleGroup]
			,hd.[Operator]
			,hd.[Date]
			,hd.[Temperature]
			,hd.[Humidity]
			,hd.[Amount]
			,hd.[UHML]
			,hd.[UI]
			,hd.[Strength]
			,hd.[Elongation]
			,hd.[SFI]
			,hd.[Maturity]
			,Cc.ClaveCorta as Grade
			,hd.[Moist]
			,hd.[Mic]
			,hd.[Rd]
			,hd.[Plusb]
			,hd.[ColorGrade]
			,hd.[TrashCount]
			,hd.[TrashArea]
			,hd.[TrashID]
			,hd.[SCI]
			,hd.[Nep]
			,hd.[UV]
			,0 as FlagTerminado
			,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
  		where Pd.FolioCIA = @NumPaca and hd.IdPlantaOrigen = @IdPlanta
		order by BaleID asc
	end
--else if exists (select baleid from CalculoClasificacion where BaleId = @NumPaca and IdPlantaOrigen = @IdPlanta and IdPaqueteEncabezado = @IdPaquete)
--	begin
--		select 
--		     [IdPlantaOrigen]
--			,[LotID]
--			,[BaleID]
--			,[BaleGroup]
--			,[Operator]
--			,[Date]
--			,[Temperature]
--			,[Humidity]
--			,[Amount]
--			,[UHML]
--			,[UI]
--			,[Strength]
--			,[Elongation]
--			,[SFI]
--			,[Maturity]
--			,[Grade]
--			,[Moist]
--			,[Mic]
--			,[Rd]
--			,[Plusb]
--			,[ColorGrade]
--			,[TrashCount]
--			,[TrashArea]
--			,[TrashID]
--			,[SCI]
--			,[Nep]
--			,[UV]
--			,FlagTerminado
--			,IdHviDetalle 
--			,IdOrdenTrabajo
--		from CalculoClasificacion 
--		where  BaleId = @NumPaca and IdPlantaOrigen = @IdPlanta and IdPaqueteEncabezado = @IdPaquete
--	end
else
	begin
		select
		     Hd.[IdPlantaOrigen]
			,hd.[LotID]
			,hd.[BaleID]
			,hd.[BaleGroup]
			,hd.[Operator]
			,hd.[Date]
			,hd.[Temperature]
			,hd.[Humidity]
			,hd.[Amount]
			,hd.[UHML]
			,hd.[UI]
			,hd.[Strength]
			,hd.[Elongation]
			,hd.[SFI]
			,hd.[Maturity]
			,Cc.ClaveCorta as Grade
			,hd.[Moist]
			,hd.[Mic]
			,hd.[Rd]
			,hd.[Plusb]
			,hd.[ColorGrade]
			,hd.[TrashCount]
			,hd.[TrashArea]
			,hd.[TrashID]
			,hd.[SCI]
			,hd.[Nep]
			,hd.[UV]
			,0 as FlagTerminado
			,Pd.IdOrdenTrabajo
		from [dbo].[HVIDetalle] Hd inner join ProduccionDetalle Pd on Hd.BaleID = Pd.FolioCIA
						   inner join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
						   inner join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where Pd.FolioCIA = @NumPaca and hd.IdPlantaOrigen = @IdPlanta 
			order by BaleID asc
end

go

Alter procedure sp_ConsultaContratosDetalle
--declare
@IdContratoAlgodon int 
as
Declare @Lotes VARCHAR(100)
SELECT @Lotes = COALESCE(@Lotes + ', ', '') + Lote FROM [dbo].[ContratoCompraDetalle] a, [dbo].[Tierras] b,[dbo].[ContratoCompra] c where a.IdLote = b.IdTierra and a.IdContratoAlgodon = c.IdContratoAlgodon and a.IdContratoAlgodon = @IdContratoAlgodon
select a.IdContratoAlgodon,
	   b.IdCliente,
       b.Nombre,
	   b.RfcApoderado,
	   b.Rfc,
	   isnull(c.IdAsociacion,0) as IdAsociacion,
	   isnull(c.Descripcion,'') as Descripcion,
	   a.Pacas,
	   a.SuperficieComprometida,
	   isnull(@Lotes,'') as Lotes,
	   a.PrecioQuintal,
	   a.Puntos,
	   a.FechaLiquidacion,
	   a.Presidente,
	   a.IdModalidadCompra,
	   a.Temporada,
	   a.PrecioSM,
	   a.PrecioMP,
	   a.PrecioM,
	   a.PrecioSLMP,
	   a.PrecioSLM,
	   a.PrecioLMP,
	   a.PrecioLM,
	   a.PrecioSGO,
	   a.PrecioGO,
	   a.PrecioO,
	   a.IdEstatus
from [dbo].[ContratoCompra] a inner join  [dbo].[Clientes] b on a.IdProductor = b.IdCliente
							  left join  [dbo].[Asociaciones] c on b.IdCuentaDe = c.IdAsociacion
	
where a.IdContratoAlgodon = @IdContratoAlgodon
and   a.IdEstatus = 1

go

Alter procedure sp_ConsultaContratosDetalleEmpresa
--declare
@IdContratoAlgodon int 
as
Declare @Lotes VARCHAR(100)
SELECT @Lotes = COALESCE(@Lotes + ', ', '') + Lote FROM [dbo].[ContratoCompraDetalle] a, [dbo].[Tierras] b,[dbo].[ContratoCompra] c where a.IdLote = b.IdTierra and a.IdContratoAlgodon = c.IdContratoAlgodon and a.IdContratoAlgodon = @IdContratoAlgodon
select a.IdContratoAlgodon,
	   b.IdTipoPersona,
	   b.IdCliente,
       b.Nombre,
	   b.RfcApoderado,
	   b.Rfc,
	   b.CalleFisica,
	   b.NumeroFisica,
	   b.ColoniaFisica,
	   b.CalleMoral,
	   b.NumeroMoral,
	   b.ColoniaMoral,
	   b.IdTipoPersona,
	   isnull(c.IdAsociacion,0) as IdAsociacion,
	   isnull(c.Descripcion,'') as Descripcion,
	   a.Pacas,
	   a.SuperficieComprometida,
	   isnull(@Lotes,'') as Lotes,
	   a.PrecioQuintal,
	   a.Puntos,
	   a.FechaLiquidacion,
	   a.Presidente,
	   a.IdModalidadCompra,
	   a.Temporada,
	   a.PrecioSM,
	   a.PrecioMP,
	   a.PrecioM,
	   a.PrecioSLMP,
	   a.PrecioSLM,
	   a.PrecioLMP,
	   a.PrecioLM,
	   a.PrecioSGO,
	   a.PrecioGO,
	   a.PrecioO,
	   a.IdEstatus,
	   d.IdDatosEmpresa,
	   d.RazonSocial,
	   d.RFCEmpresa,
	   d.RepresentanteLegal,
	   d.RFCRepresentante,
	   d.Calle,
	   d.NumExt,
	   d.EntreCalle1,
	   d.EntreCalle2,
	   d.Referencia,
	   d.Poblacion,
	   d.Colonia,
	   d.CodigoPostal,
	   d.Pais,
	   d.Estado,
	   d.Municipio,
	   d.LugarExpedicion
from [dbo].[ContratoCompra] a inner join [dbo].[Clientes] b on a.IdProductor = b.IdCliente
							  left join [dbo].[Asociaciones] c	on b.IdCuentaDe = c.IdAsociacion
    ,[dbo].[DatosEmpresa] d
where a.IdContratoAlgodon = @IdContratoAlgodon
and   a.IdEstatus = 1

go

Alter proc sp_ConsultaDisponibilidadPacas
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

go

Alter procedure sp_ConsultaOrdenResumen
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
--CASE  when @PorcentajeSemilla > (select max(Semilla)as Semilla from Rendimientos) then (select max(Semilla)as Semilla from Rendimientos) 
--																							  when @PorcentajeSemilla < (select min(Semilla)as Semilla from Rendimientos) then (select min(Semilla)as Semilla from Rendimientos)
--																							  else @PorcentajeSemilla end ),0)
set @TotalSemilla = (@PorcentajeSemilla * @TotalPluma)/ @PorcentajePluma
set @PorcentajeMerma = (100 - @PorcentajeSemilla - @PorcentajePluma)
set @TotalMerma = (@TotalHueso - @TotalPluma - @TotalSemilla)
set @TotalPacas = (select COUNT(IdOrdenTrabajo) from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo)
set @TotalBorregos = (select COUNT(IdOrdenTrabajo) from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo and a.Kilos < 180)
set @TotalPlumaBorregos = ISNULL((select SUM(a.Kilos) from [dbo].[ProduccionDetalle] a where a.IdOrdenTrabajo = @IdOrdenTrabajo and a.Kilos < 180),0)

Insert into ##TablaTemp(TotalHueso,TotalPluma,PorcentajePluma,PorcentajeSemilla,TotalSemilla,PorcentajeMerma,TotalMerma,TotalPacas,TotalBorregos,TotalPlumaBorregos)
VALUES (@TotalHueso,@TotalPluma,@PorcentajePluma,@PorcentajeSemilla,@TotalSemilla,@PorcentajeMerma,@TotalMerma,@TotalPacas,@TotalBorregos,@TotalPlumaBorregos)
select*from ##TablaTemp

go

Alter proc sp_ConsultaOrdenTrabajoLiquidacion  
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
	 
go

Alter procedure sp_ConsultaPacasCalculoClasif
@IdPaquete int 
as
select   
		 a.[IdPlantaOrigen]
		,a.[LotID]
		,a.[BaleID]
		,a.[BaleGroup]
		,a.[Operator]
		,a.[Date]
		,a.[Temperature]
		,a.[Humidity]
		,a.[Amount]
		,a.[UHML]
		,a.[UI]
		,a.[Strength]
		,a.[Elongation]
		,a.[SFI]
		,a.[Maturity]
		,a.[Grade]
		,a.[Moist]
		,a.[Mic]
		,a.[Rd]
		,a.[Plusb]
		,a.[ColorGrade]
		,a.[TrashCount]
		,a.[TrashArea]
		,a.[TrashID]
		,a.[SCI]
		,a.[Nep]
		,a.[UV]
		,a.FlagTerminado
		,a.IdVentaEnc
		,a.IdOrdenTrabajo
from [dbo].[CalculoClasificacion] a
where a.IdPaqueteEncabezado = @IdPaquete 
order by a.BaleId asc

go

Alter procedure sp_ConsultaPacasComprasFiltro
--declare
@IdProductor int ,
@Seleccionar bit =0 ,
@PacaIni int,
@PacaFin int,
@Clase varchar(4)
as
if @Clase <> '' and @PacaIni > 0 and @PacaFin > 0
begin 
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   HviD.IdPlantaOrigen,
	   hvid.BaleID,
	   pd.Kilos,
	   Hvid.quintales,
	   hvid.Grade,
	   hvid.UI as Uniformidad,
	   hvid.Mic as Micros,
	   hvid.Strength as Resistencia,
	   hvid.UHML as Largo,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       left join HviDetalle hvid on pd.FolioCIA = hvid.BaleID 
						   right join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra = 1 and
			  hvid.BaleID between @PacaIni and @PacaFin and hvid.Grade = @Clase
end
else if @Clase = '' and @PacaIni > 0 and @PacaFin > 0
begin
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   HviD.IdPlantaOrigen,
	   hvid.BaleID,
	   pd.Kilos,
	   Hvid.quintales,
	   hvid.Grade,
	   hvid.UI as Uniformidad,
	   hvid.Mic as Micros,
	   hvid.Strength as Resistencia,
	   hvid.UHML as Largo,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       left join HviDetalle hvid on pd.FolioCIA = hvid.BaleID 
						   right join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra = 1 and
			  hvid.BaleID between @PacaIni and @PacaFin 
end
else if @Clase <> '' and @PacaIni = 0 and @PacaFin = 0
begin
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   HviD.IdPlantaOrigen,
	   hvid.BaleID,
	   pd.Kilos,
	   Hvid.quintales,
	   hvid.Grade,
	   hvid.UI as Uniformidad,
	   hvid.Mic as Micros,
	   hvid.Strength as Resistencia,
	   hvid.UHML as Largo,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       left join HviDetalle hvid on pd.FolioCIA = hvid.BaleID 
						   right join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra = 1 and hvid.Grade = @Clase
end
else if @Clase = '' and @PacaIni = 0 and @PacaFin = 0
begin
select pd.FolioCIA,
	   hvid.IdOrdenTrabajo,
	   isnull(LR.IdLiquidacion,0) as IdLiquidacion,
	   Pl.Descripcion,
	   HviD.IdPlantaOrigen,
	   hvid.BaleID,
	   pd.Kilos,
	   Hvid.quintales,
	   hvid.Grade,
	   hvid.UI as Uniformidad,
	   hvid.Mic as Micros,
	   hvid.Strength as Resistencia,
	   hvid.UHML as Largo,
	   @Seleccionar as Seleccionar
		from Produccion pr inner join ProduccionDetalle pd on pr.IdProduccion = pd.IdProduccion 
					       left join HviDetalle hvid on pd.FolioCIA = hvid.BaleID 
						   right join liquidacionesporromaneaje LR on hvid.IdOrdenTrabajo = lr.IdOrdenTrabajo 
						   inner join Plantas Pl on pd.IdPlantaOrigen = Pl.IdPlanta

		where pr.IdCliente = @IdProductor and hvid.FlagTerminado =1 and hvid.EstatusCompra = 1
end

go

Alter procedure Sp_ConsultaPacasFaltantes
@IdPlanta int ,
@RangoInicial int,
@RangoFinal int 
as
IF OBJECT_ID('tempdb..#Fuente') is not null
	begin
		DROP TABLE #Fuente
	end
		CREATE TABLE #Fuente (numero int)
	
--declare @RangoInicial int,@RangoFinal int
--set @RangoInicial = @PacaInicial
--set @RangoFinal = @PacaFinal
IF @RangoInicial > 0
	BEGIN 
		INSERT INTO #Fuente 
		select FolioCIA 
		from ProduccionDetalle 
		where FolioCIA >= @RangoInicial and FolioCIA <= @RangoFinal
		order by FolioCIA
	END
ELSE IF @RangoInicial > 0 AND @IdPlanta > 0
	BEGIN
		INSERT INTO #Fuente 
		select FolioCIA 
		from ProduccionDetalle 
		where FolioCIA >= @RangoInicial and FolioCIA <= @RangoFinal AND IdPlantaOrigen = @IdPlanta
		order by FolioCIA
	END
ELSE if @RangoInicial = 0 and @RangoFinal = 0 and @IdPlanta = 0
	BEGIN 
		INSERT INTO #Fuente 
		select FolioCIA 
		from ProduccionDetalle 
		order by FolioCIA
		 
		set @RangoInicial = (select min(numero) from #Fuente)
		set @RangoFinal = (select max(numero) from #Fuente)
	END
SET NOCOUNT ON
-- Creo mi tabla de soporte
IF OBJECT_ID('tempdb..#Rangos') is not null
	begin
		DROP TABLE #Rangos 
	end

		CREATE TABLE #Rangos (numero int)
	
INSERT INTO #Rangos values (@RangoInicial)
WHILE (SELECT ISNULL(MAX(numero),0) FROM #Rangos) < @RangoFinal
	BEGIN
		INSERT INTO #Rangos
		SELECT ISNULL(MAX(numero),0)+1 FROM #Rangos 
		CONTINUE
	END
SELECT #Rangos.numero FROM #Rangos FULL JOIN #Fuente ON #Rangos.numero = #Fuente.numero
WHERE #Fuente.numero IS NULL
order by numero

go

Alter procedure sp_ConsultaPaquetesHVIDet
--declare
@IdPaquete int
as
select a.IdHviEnc,
	   a.IdPlantaOrigen,
	   a.LotID,
       a.BaleID,
	   a.BaleGroup,
	   a.Operator,
	   a.[Date],
	   a.Temperature,
	   a.Humidity,
	   a.Amount,
	   a.UHML,
	   a.UI,
	   a.Strength,
	   a.Elongation,
	   a.SFI,
	   a.Maturity,
	   a.Grade,
	   a.Moist,
	   a.Mic,
	   a.Rd,
	   a.Plusb,
	   a.ColorGrade,
	   a.TrashCount,
	   a.TrashArea,
	   a.TrashID,
	   a.SCI,
	   a.Nep,
	   a.UV
from dbo.HVIDetalle a
where a.LotID = @IdPaquete 

go

Alter proc Sp_eliminaPacaSeleccionadaClasificacion
@IdPaquete int,
@BaleID int
as
delete CalculoClasificacion 
where IdPaqueteEncabezado = @IdPaquete and baleid = @baleid

go

Alter procedure [dbo].[sp_InsertarClasificacionPacas]
@IdCalculoClasificacion int,
@IdPaqueteEncabezado int,
@IdOrdenTrabajo int,
@IdPlantaOrigen int,
@LotID int,
@BaleID int ,
@BaleGroup varchar(5) ,
@Operator varchar(25) ,
@Date datetime ,
@Temperature float ,
@Humidity float ,
@Amount int ,
@UHML float ,
@UI float ,
@Strength float ,
@Elongation float ,
@SFI float ,
@Maturity float ,
@Grade varchar(6) ,
@Moist float ,
@Mic float ,
@Rd float ,
@Plusb float ,
@ColorGrade varchar(4) ,
@TrashCount int ,
@TrashArea float ,
@TrashID int ,
@SCI int ,
@Nep int ,
@UV float ,
@FlagTerminado bit,
@EstatusVenta int
as 
begin 
set nocount on
merge [dbo].[CalculoClasificacion] as target
  using (select @IdCalculoClasificacion,
				@IdPaqueteEncabezado,
				@IdOrdenTrabajo,
				@IdPlantaOrigen,
				@LotID,
				@BaleID  ,
				@BaleGroup  ,
				@Operator ,
				@Date  ,
				@Temperature  ,
				@Humidity  ,
				@Amount  ,
				@UHML  ,
				@UI  ,
				@Strength  ,
				@Elongation  ,
				@SFI  ,
				@Maturity  ,
				@Grade  ,
				@Moist  ,
				@Mic  ,
				@Rd  ,
				@Plusb  ,
				@ColorGrade  ,
				@TrashCount  ,
				@TrashArea  ,
				@TrashID  ,
				@SCI  ,
				@Nep  ,
				@UV  ,
				@FlagTerminado,
				@EstatusVenta) 
								AS SOURCE 
			   (IdCalculoClasificacion,
				IdPaqueteEncabezado,
				IdOrdenTrabajo,
				IdPlantaOrigen,
				LotID,
				BaleID  ,
				BaleGroup  ,
				Operator ,
				[Date]  ,
				Temperature  ,
				Humidity  ,
				Amount  ,
				UHML  ,
				UI  ,
				Strength  ,
				Elongation  ,
				SFI  ,
				Maturity  ,
				Grade  ,
				Moist  ,
				Mic  ,
				Rd  ,
				Plusb  ,
				ColorGrade  ,
				TrashCount  ,
				TrashArea  ,
				TrashID  ,
				SCI  ,
				Nep  ,
				UV  ,
				FlagTerminado,
				EstatusVenta)
ON (target.BaleId = SOURCE.BaleId and target.IdPaqueteEncabezado = SOURCE.IdPaqueteEncabezado and target.IdPlantaOrigen = SOURCE.IdPlantaOrigen)
WHEN MATCHED THEN
UPDATE SET 
				BaleGroup  = source.BaleGroup ,
				Operator = source.Operator ,
				[Date]  = source.[Date] ,
				Temperature  = source.Temperature ,
				Humidity  = source.Humidity ,
				Amount  = source.Amount ,
				UHML  = source.UHML ,
				UI  = source.UI ,
				Strength  = source.Strength ,
				Elongation  = source.Elongation ,
				SFI  = source.SFI ,
				Maturity  = source.Maturity ,
				Grade  = source.Grade ,
				Moist  = source.Moist ,
				Mic  = source.Mic ,
				Rd  = source.Rd ,
				Plusb  = source.Plusb ,
				ColorGrade  = source.ColorGrade ,
				TrashCount  = source.TrashCount ,
				TrashArea  = source.TrashArea ,
				TrashID  = source.TrashID ,
				SCI  = source.SCI ,
				Nep  = source.Nep ,
				UV  = source.UV ,
				FlagTerminado = 1 ,
				EstatusVenta = source.EstatusVenta

WHEN NOT MATCHED THEN
INSERT (IdPaqueteEncabezado
		,IdOrdenTrabajo
		,IdPlantaOrigen
		,LotID
		,BaleId
		,BaleGroup
		,Operator
		,[Date]
		,Temperature
		,Humidity
		,Amount
		,UHML
		,UI
		,Strength
		,Elongation
		,SFI
		,Maturity
		,Grade
		,Moist
		,Mic
		,Rd
		,Plusb
		,ColorGrade
		,TrashCount
		,TrashArea
		,TrashID
		,SCI
		,Nep
		,UV
		,flagterminado
		,EstatusVenta)
        VALUES 
		(source.IdPaqueteEncabezado
		,source.IdOrdenTrabajo
		,source.IdPlantaOrigen
		,source.LotID
		,source.BaleId
		,source.BaleGroup
		,source.Operator
		,source.[Date]
		,source.Temperature
		,source.Humidity
		,source.Amount
		,source.UHML
		,source.UI
		,source.Strength
		,source.Elongation
		,source.SFI
		,source.Maturity
		,source.Grade
		,source.Moist
		,source.Mic
		,source.Rd
		,source.Plusb
		,source.ColorGrade
		,source.TrashCount
		,source.TrashArea
		,source.TrashID
		,source.SCI
		,source.Nep
		,source.UV
		,1
		,source.EstatusVenta);		
END

go

Alter procedure sp_InsertarPaqueteEncabezado
@IdPaquete int output,
@LotID int ,
@IdPlanta int,
@IdComprador int,
@IdClase int,
@CantidadPacas int,
@Descripcion varchar(20),
@Entrega varchar(15),
@chkrevisado bit,
@IdEstatus int,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion  datetime
as
begin
set nocount on
merge [dbo].[PaqueteEncabezado] as target
using (select @IdPaquete,
			  @LotID,
			  @IdPlanta,
			  @IdComprador,
			  @IdClase,
			  @CantidadPacas,
			  @Descripcion,
			  @Entrega,
			  @chkrevisado,
			  @IdEstatus,
			  @IdUsuarioCreacion,
			  @FechaCreacion,
			  @IdUsuarioActualizacion,
			  @FechaActualizacion) 
as source (IdPaquete,
		   LotID,
		   IdPlanta,
		   IdComprador,
		   IdClase,
		   CantidadPacas,
		   Descripcion,
		   Entrega,
		   chkrevisado,
		   IdEstatus,
		   IdUsuarioCreacion,
		   FechaCreacion,
		   IdUsuarioActualizacion,
		   FechaActualizacion)
ON (target.IdPaquete = source.IdPaquete)
WHEN MATCHED THEN
UPDATE SET IdPlanta = source.IdPlanta,		
		   IdClase = source.IdClase,
		   IdComprador = source.IdComprador,
		   CantidadPacas = source.CantidadPacas,
		   Descripcion = source.Descripcion,
		   Entrega = source.Entrega,
		   chkrevisado = 1,
		   IdUsuarioActualizacion = source.IdUsuarioActualizacion,
		   FechaActualizacion = source.FechaActualizacion,
		   IdEstatus = source.IdEstatus
WHEN NOT MATCHED THEN
INSERT (LotID,
		IdPlanta,
		IdComprador,
		IdClase,
		CantidadPacas,
		Descripcion,
		Entrega,
		chkrevisado,
		IdEstatus,
		IdUsuarioCreacion,
		FechaCreacion,
		IdUsuarioActualizacion,
		FechaActualizacion)
VALUES (source.LotID,
		source.IdPlanta,
		source.IdComprador,
		source.IdClase,
		source.CantidadPacas,
		source.Descripcion,
		source.Entrega,
		1,
		source.IdEstatus,
		source.IdUsuarioCreacion,
		source.FechaCreacion,
		source.IdUsuarioActualizacion,
		source.FechaActualizacion);
SET @IdPaquete = SCOPE_IDENTITY()
END
RETURN @IdPaquete

go

Alter procedure sp_InsertarPaquetesHVIDet
@IdHviDet int,
@IdHviEnc int,
@IdPlantaOrigen int,
@LotID int,
@BaleID int,
@BaleGroup varchar(5),
@Operator varchar(25),
@Date datetime,
@Temperature float,
@Humidity float,
@Amount int, 
@UHML float,
@UI float,
@Strength float,
@Elongation float,
@SFI float,
@Maturity float,
@Grade varchar(6),
@Moist float,
@Mic float,
@Rd float,
@Plusb float,
@ColorGrade varchar(4),
@TrashCount int,
@TrashArea float,
@TrashID int,
@SCI int,
@Nep int,
@UV float
as 
begin 
set nocount on
merge [dbo].[HVIDetalle] as target
using (select @IdHviDet
			 ,@IdHviEnc
			 ,@IdPlantaOrigen
			 ,@LotID
			 ,@BaleID
			 ,@BaleGroup
			 ,@Operator
			 ,@Date
			 ,@Temperature
			 ,@Humidity
			 ,@Amount
			 ,@UHML
			 ,@UI
			 ,@Strength
			 ,@Elongation
			 ,@SFI
			 ,@Maturity
			 ,@Grade
			 ,@Moist
			 ,@Mic
			 ,@Rd
			 ,@Plusb
			 ,@ColorGrade
			 ,@TrashCount
			 ,@TrashArea
			 ,@TrashID
			 ,@SCI
			 ,@Nep
			 ,@UV) 
			 AS SOURCE (
			 IdHviDet
			,IdHviEnc
			,IdPlantaOrigen
			,LotID
			,BaleID
			,BaleGroup
			,Operator
			,[Date]
			,Temperature
			,Humidity
			,Amount
			,UHML
			,UI
			,Strength
			,Elongation
			,SFI
			,Maturity
			,Grade
			,Moist
			,Mic
			,Rd
			,Plusb
			,ColorGrade
			,TrashCount
			,TrashArea
			,TrashID
			,SCI
			,Nep
			,UV)
ON ((target.LotID = source.LotID and
	 target.BaleID = source.BaleID and
	 target.IdPlantaOrigen <> source.IdPlantaOrigen and 
	 target.[Date] <> source.[Date]) or 

	(target.LotID = source.LotID and
	 target.BaleID = source.BaleID and
	 target.IdPlantaOrigen = source.IdPlantaOrigen and 
	 target.[Date] <> source.[Date]) or

	 (target.LotID = source.LotID and
	 target.BaleID = source.BaleID and
	 target.IdPlantaOrigen <> source.IdPlantaOrigen and 
	 target.[Date] <> source.[Date]) or 

	 (target.LotID = source.LotID and
	 target.BaleID = source.BaleID and
	 target.IdPlantaOrigen = source.IdPlantaOrigen and 
	 target.[Date] = source.[Date]))
WHEN MATCHED THEN
UPDATE SET 
		   IdPlantaOrigen = source.IdPlantaOrigen,
		   LotID = source.LotID,
		   BaleID = source.BaleID,
		   BaleGroup = source.BaleGroup,
		   Operator = source.Operator,
		   [Date] = source.[Date],
		   Temperature = source.Temperature,
		   Humidity = source.Humidity,
		   Amount = source.Amount,
		   UHML = source.UHML,
		   UI = source.UI,
		   Strength = source.Strength,
		   Elongation = source.Elongation,
		   SFI = source.SFI,
		   Maturity = source.Maturity,
		   Grade = source.Grade,
		   Moist = source.Moist,
		   Mic = source.Mic,
		   Rd = source.Rd,
		   Plusb = source.Plusb,
		   ColorGrade = source.ColorGrade,
		   TrashCount = source.TrashCount,
		   TrashArea = source.TrashArea,
		   TrashID = source.TrashID,
		   SCI = source.SCI,
		   Nep = source.Nep,
		   UV = source.UV
WHEN NOT MATCHED THEN
INSERT (IdHviEnc
	   ,IdPlantaOrigen
	   ,LotID
	   ,BaleID
	   ,BaleGroup
	   ,Operator
	   ,[Date]
	   ,Temperature
	   ,Humidity
	   ,Amount
	   ,UHML
	   ,UI
	   ,Strength
	   ,Elongation
	   ,SFI
	   ,Maturity
	   ,Grade
	   ,Moist
	   ,Mic
	   ,Rd
	   ,Plusb
	   ,ColorGrade
	   ,TrashCount
	   ,TrashArea
	   ,TrashID
	   ,SCI
	   ,Nep
	   ,UV)
        VALUES (
		source.IdHviEnc
	   ,source.IdPlantaOrigen
	   ,source.LotID
	   ,source.BaleID
	   ,source.BaleGroup
	   ,source.Operator
	   ,source.[Date]
	   ,source.Temperature
	   ,source.Humidity
	   ,source.Amount
	   ,source.UHML
	   ,source.UI
	   ,source.Strength
	   ,source.Elongation
	   ,source.SFI
	   ,source.Maturity
	   ,source.Grade
	   ,source.Moist
	   ,source.Mic
	   ,source.Rd
	   ,source.Plusb
	   ,source.ColorGrade
	   ,source.TrashCount
	   ,source.TrashArea
	   ,source.TrashID
	   ,source.SCI
	   ,source.Nep
	   ,source.UV);		
END

go

alter procedure sp_InsertarProduccion
@IdProduccion int output,
@IdPlantaOrigen int,
@IdPlantaDestino int,
@IdOrdenTrabajo int,
@Tipo varchar(20),
@IdCliente int,
@Fecha datetime,
@IdEstatus int,
@TotalHueso float,
@Pacas int,
@PlumaPacas float,
@PlumaBorregos float,
@Pluma float,
@Semilla float,
@Merma float,
@Borra float,
@PorcentajePluma float,
@PorcentajeSemilla float,
@PorcentajeMerma float,
@IdUsuarioCreacion int,
@FechaCreacion datetime,
@IdUsuarioActualizacion int,
@FechaActualizacion datetime
as
begin
set nocount on
merge [dbo].[Produccion] as target
using (select @IdProduccion,@IdPlantaOrigen,@IdPlantaDestino,@IdOrdenTrabajo,@Tipo,@IdCliente,@Fecha,@IdEstatus,
@TotalHueso,
@Pacas,
@PlumaPacas,
@PlumaBorregos,
@Pluma,
@Semilla,
@Merma,
@Borra,
@PorcentajePluma,
@PorcentajeSemilla,
@PorcentajeMerma,@IdUsuarioCreacion,@FechaCreacion,@IdUsuarioActualizacion,@FechaActualizacion) as source (IdProduccion,IdPlantaOrigen,IdPlantaDestino,IdOrdenTrabajo,Tipo,IdCliente,Fecha,IdEstatus,
TotalHueso,
Pacas,
PlumaPacas,
PlumaBorregos,
Pluma,
Semilla,
Merma,
Borra,
PorcentajePluma,
PorcentajeSemilla,
PorcentajeMerma,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
ON (target.IdProduccion = source.IdProduccion)
WHEN MATCHED THEN
UPDATE SET 
			TotalHueso = source.TotalHueso,
			Pacas = source.Pacas,
			PlumaPacas = source.PlumaPacas,
			PlumaBorregos = source.PlumaBorregos,
			Pluma = source.Pluma,
			Semilla = source.Semilla,
			Merma = source.Merma,
			Borra = source.Borra,
			PorcentajePluma = source.PorcentajePluma,
			PorcentajeSemilla = source.PorcentajeSemilla,
			PorcentajeMerma = source.PorcentajeMerma,
		   IdUsuarioCreacion = source.IdUsuarioCreacion,
		   FechaCreacion = source.FechaCreacion
WHEN NOT MATCHED THEN
INSERT (IdPlantaOrigen,IdPlantaDestino,IdOrdenTrabajo,Tipo,IdCliente,Fecha,IdEstatus,
TotalHueso,
Pacas,
PlumaPacas,
PlumaBorregos,
Pluma,
Semilla,
Merma,
Borra,
PorcentajePluma,
PorcentajeSemilla,
PorcentajeMerma,IdUsuarioCreacion,FechaCreacion,IdUsuarioActualizacion,FechaActualizacion)
VALUES (source.IdPlantaOrigen,source.IdPlantaDestino,source.IdOrdenTrabajo,source.Tipo,source.IdCliente,source.Fecha,source.IdEstatus,
source.TotalHueso,
source.Pacas,
source.PlumaPacas,
source.PlumaBorregos,
source.Pluma,
source.Semilla,
source.Merma,
source.Borra,
source.PorcentajePluma,
source.PorcentajeSemilla,
source.PorcentajeMerma,source.IdUsuarioCreacion,source.FechaCreacion,source.IdUsuarioActualizacion,source.FechaActualizacion);
SET @IdProduccion = SCOPE_IDENTITY()
END
RETURN @IdProduccion

go

Alter procedure Sp_ReporteDetalladoPacas
@IdProductor int,
@IdPlanta int,
@IdClase int,
@IdOrdenProduccion int
as
if @IdProductor = 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
	end
if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor
	end
if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion > 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and pd.IdOrdenTrabajo = @IdOrdenProduccion
	end
if @IdProductor > 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion > 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and pd.IdOrdenTrabajo = @IdOrdenProduccion and pd.IdPlantaOrigen = @IdPlanta
	end
if @IdProductor > 0 and @IdPlanta > 0 and @IdClase > 0 and @IdOrdenProduccion > 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and pd.IdOrdenTrabajo = @IdOrdenProduccion and pd.IdPlantaOrigen = @IdPlanta and cc.IdClasificacion = @IdClase
	end
if @IdProductor > 0 and @IdPlanta = 0 and @IdClase > 0 and @IdOrdenProduccion = 0 
	begin
select isnull(pd.FolioCIA,0) as FolioCIA,
		isnull(pd.idordentrabajo, 0) as IdOrdenTrabajo,
		isnull(cl.Nombre,'') as Nombre,
		isnull(pd.IdPlantaOrigen,'') as Planta,
		isnull(((OT.PesoModulos/Pr.plumapacas)*pd.Kilos),0) as KilosHueso,
		isnull(pd.Kilos,0) as Kilos,
		isnull(ot.FechaCreacion,'') as Fecha,
		isnull(cc.ClaveCorta,'') as Clase,
		isnull(hd.Mic,0) as Mic,
		isnull(hd.UHML,0) as UHML,
		isnull(hd.Strength,0) as Strength
		from ProduccionDetalle pd left join HVIDetalle hd on pd.IdOrdenTrabajo = hd.idOrdentrabajo and pd.IdPlantaOrigen = hd.idplantaorigen and pd.FolioCIA = hd.BaleID
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join Plantas pl on hd.IdPlantaOrigen = pl.IdPlanta
							left join OrdenTrabajo OT on pr.IdOrdenTrabajo = OT.IdOrdenTrabajo
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and cc.IdClasificacion = @IdClase
	end

go

Alter procedure Sp_ReporteHviDetalle
--declare
@IdPaquete int,
@IdPlantaOrigen int 
as
select   b.IdPaquete
        ,b.IdPlanta
	    ,isnull(b.IdComprador,0) as IdComprador
		,isnull(d.Nombre,'') as Nombre
	    ,b.Descripcion
	    ,b.CantidadPacas
		,a.[BaleID]
		,a.[BaleGroup]
		,a.[Operator]
		,a.[Date]
		,a.[Temperature]
		,a.[Humidity]
		,a.[Amount]
		,a.[UHML]
		,a.[UI]
		,a.[Strength]
		,a.[Elongation]
		,a.[SFI]
		,a.[Maturity]
		,a.[Grade]
		,a.[Moist]
		,a.[Mic]
		,a.[Rd]
		,a.[Plusb]
		,a.[ColorGrade]
		,a.[TrashCount]
		,a.[TrashArea]
		,a.[TrashID]
		,a.[SCI]
		,a.[Nep]
		,a.[UV]
		,a.FlagTerminado
		,a.IdOrdenTrabajo
		,(Select top 1 colorgrade From CalculoClasificacion where IdPaquete = @IdPaquete and IdPlantaOrigen  = @IdplantaOrigen Group By colorgrade Having Count(*) > 1) as TrCntRep
		,(Select top 1 TrashID From CalculoClasificacion where IdPaquete = @IdPaquete and IdPlantaOrigen  = @IdplantaOrigen  Group By TrashID Having Count(*) > 1) as TrIDRep
from CalculoClasificacion a inner join PaqueteEncabezado b 
						 on a.IdPaqueteEncabezado = b.IdPaquete and a.IdPlantaOrigen = b.IdPlanta
						 inner join ClasesClasificacion c 
						 on b.IdClase = c.idClasificacion
							left join Compradores d 
						 on b.idComprador = d.IdComprador
where b.IdPaquete = @IdPaquete and b.IdPlanta = @IdPlantaOrigen
order by a.[BaleID]

go

Alter procedure Sp_ReportePacasPorClases
--declare
@IdProductor int,
@IdPlanta int ,
@IdClase int ,
@IdOrdenProduccion int
as
if @IdProductor = 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
		SELECT '' as NOMBRE,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen = PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		GROUP BY CC.CLAVECORTA,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end
else if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion = 0 
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen = PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion = 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and Pr.IdPlantaOrigen = @idplanta
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase > 0 and @IdOrdenProduccion = 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and Pr.IdPlantaOrigen = @idplanta and cc.IdClasificacion = @IdClase
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase > 0 and @IdOrdenProduccion > 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and pd.IdPlantaOrigen = @idplanta and cc.IdClasificacion = @IdClase and pr.IdOrdenTrabajo = @IdOrdenProduccion
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta = 0 and @IdClase = 0 and @IdOrdenProduccion > 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdOrdenTrabajo = @IdOrdenProduccion and pr.IdCliente = @IdProductor
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor = 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion = 0
	begin
		SELECT '' as NOMBRE,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdPlantaOrigen = @IdPlanta
		GROUP BY  CC.CLAVECORTA,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 
else if @IdProductor > 0 and @IdPlanta > 0 and @IdClase = 0 and @IdOrdenProduccion > 0
	begin
		SELECT cl.Nombre,isnull(CC.CLAVECORTA,'S/C') AS CLASE,COUNT(distinct(PD.FolioCIA)) AS PACAS,SUM(PD.Kilos) AS KILOS, SUM(PD.Kilos)/46.02 AS QUINTALES
		FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen= PD.IdPlantaOrigen
									left join Produccion Pr on pd.idproduccion = pr.idproduccion
									left join clientes cl on pr.IdCliente = cl.IdCliente
									left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
									left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
		where pr.IdCliente = @IdProductor and pd.IdPlantaOrigen = @idplanta and pr.IdOrdenTrabajo = @IdOrdenProduccion
		GROUP BY  CC.CLAVECORTA,cl.Nombre,CC.IdClasificacion	
	    ORDER BY CC.IdClasificacion	
	end 

go

Alter procedure Sp_ReporteRomaneajeDet
--declare
@IdOrdenTrabajo as int ,
@CheckStatus as bit 
as
select pd.IdOrdenTrabajo
	  ,pd.IdPlantaOrigen
	  ,pd.FolioCIA as EtiquetaPaca
	  ,pd.kilos 
	  ,HD.Temperature
	  ,HD.Humidity
	  ,HD.Amount
	  ,HD.UHML
	  ,HD.UI
	  ,HD.Strength
	  ,HD.Elongation
	  ,HD.SFI
	  ,HD.Maturity
	  ,isnull(CC.CLAVECORTA,'S/C') AS Grade
	  ,HD.Moist
	  ,HD.Mic
	  ,HD.Rd
	  ,HD.Plusb
	  ,HD.ColorGrade
	  ,HD.TrashCount
	  ,HD.TrashArea
	  ,HD.TrashID
	  ,HD.SCI
	  ,HD.Nep
	  ,HD.UV
	  ,@CheckStatus as CheckStatus
FROM HVIDetalle HD right JOIN PRODUCCIONDETALLE PD ON HD.BALEID = PD.FolioCIA AND HD.IdPlantaOrigen = PD.IdPlantaOrigen
							left join Produccion Pr on pd.idproduccion = pr.idproduccion
							left join clientes cl on pr.IdCliente = cl.IdCliente
							left join GradosClasificacion Gc on Hd.ColorGrade = Gc.GradoColor and Hd.TrashID = Gc.TrashId
							left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
where pd.IdOrdenTrabajo = @IdOrdenTrabajo
order by hd.BaleID

go
Alter proc sp_VerificaPacaPlanta 
--declare
@FolioCIA int ,
@IdPlantaOrigen int
as
if exists (select BaleID from HVIDetalle where IdPlantaOrigen = @IdPlantaOrigen and BaleID = @FolioCIA)
	begin
		Select 1 ExistePacaPlanta,IdPlantaOrigen from HVIDetalle where IdPlantaOrigen = @IdPlantaOrigen and BaleID = @FolioCIA 
	end
else
	begin
		select 0 ExistePacaPlanta, 0 as IdPlantaOrigen
	end
		
	 	