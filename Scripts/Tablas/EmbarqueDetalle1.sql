CREATE TABLE [dbo].[EmbarqueDetalle1](
	[IdEmbarqueDetalle] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[IdEmbarqueEncabezado] [int] NULL,
	[IdSalidaEncabezado] [int] NULL,
	[IdComprador] [int] NULL,
	[IdVentaEnc] [int] NULL,
	[IdPlanta] [int] NULL,
	[BaleID] [int] NULL,
	[Kilos] [int] NULL,
	[NoContenedor] [varchar](12) NULL,
	[NoLote] [varchar](15) NULL,
	[PlacaCaja] [varchar](13) NULL,
	[EstatusEmbarque] [int] NULL,
	[EstatusSalida] [int] NULL) 


	insert into [EmbarqueDetalle1]
	(
	 
       [IdEmbarqueEncabezado]
      ,[IdSalidaEncabezado]
      ,[IdComprador]
      ,[IdVentaEnc]
      ,[IdPlanta]
      ,[BaleID]
      ,[Kilos]
      ,[NoContenedor]
      ,[NoLote]
      ,[EstatusEmbarque]
      ,[EstatusSalida]
	)
	select
       [IdEmbarqueEncabezado]
      ,[IdSalidaEncabezado]
      ,[IdComprador]
      ,[IdVentaEnc]
      ,[IdPlanta]
      ,[BaleID]
      ,[Kilos]
      ,[NoContenedor]
      ,[NoLote]
      ,[EstatusEmbarque]
      ,[EstatusSalida]
	  from [EmbarqueDetalle]

--truncate table [EmbarqueDetalle1]