CREATE Procedure Sp_ActualizaIdOrdenTrabajoPaqueteHVI
@IdPlanta int,
@BaleId int
as
update hvi
set hvi.IdOrdenTrabajo = pd.IdOrdenTrabajo,
	hvi.Kilos = pd.kilos,
	hvi.Grade = cc.clavecorta,
	hvi.EstatusCompra = 1,
	FlagTerminado = 1
from hvidetalle hvi inner join producciondetalle pd on hvi.idplantaorigen = pd.IdPlantaOrigen and hvi.BaleID = pd.FolioCIA
					left join GradosClasificacion Gc on hvi.ColorGrade = Gc.GradoColor and hvi.TrashID = Gc.TrashId
					left join ClasesClasificacion Cc on Gc.IdClase = Cc.IdClasificacion
where hvi.IdPlantaOrigen = @IdPlanta and hvi.Baleid = @BaleId

GO
CREATE Procedure Sp_ReporteDetalladoPacas
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

GO
ALTER Procedure Sp_ReporteRomaneajeDet
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
GO
ALTER proc Sp_eliminaPacaSeleccionadaClasificacion
@IdPaquete int,
@BaleID int
as
delete CalculoClasificacion 
where IdPaqueteEncabezado = @IdPaquete and baleid = @baleid
GO
ALTER procedure sp_ConsultaPacasCalculoClasif
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
GO
ALTER procedure sp_ConsultaPaquetesHVIDet
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
GO
ALTER procedure [dbo].[sp_InsertarClasificacionPacas]
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
GO
ALTER procedure sp_InsertarPaqueteEncabezado
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
GO
ALTER procedure sp_InsertarPaquetesHVIDet
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
GO
ALTER proc sp_VerificaPacaPlanta 
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
GO
ALTER proc sp_consultaClasesCalculo
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
alter Procedure Sp_ReportePacasPorClases
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
