 CREATE TABLE Lotesenc(
	[idlote] [int] primary key IDENTITY(1,1) NOT NULL,
	[idcomprador] [int] NULL,
	[Nolote] [nvarchar](10) NULL,
	[ubicacion] [nvarchar](30) NULL,
	[observaciones] [nvarchar](100) NULL,
	[totalpacas] [int] NULL,
	[totalkilos] [decimal](12, 4) NULL,
	[fechacreacion] [datetime] NULL,
	[fechaactualizacion] [datetime] NULL,
	[Idestatus] [int] NULL)