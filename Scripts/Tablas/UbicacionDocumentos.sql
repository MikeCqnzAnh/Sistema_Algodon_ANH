CREATE TABLE UbicacionDocumentos(
	[IdUbicacion] [int] IDENTITY(1,1) NOT NULL,
	[RutaPrincipal] [varchar](max) NULL,
	[NombreCarpetaRaiz] [varchar](50) NULL,
	[DocumentosProductores] [varchar](50) NULL,
	[DocumentosPersonales] [varchar](50) NULL,
	[DocumentosLotes] [varchar](50) NULL,
	[ContratosProductores] [varchar](50) NULL,
	[ContratosCompradores] [varchar](50) NULL,
	[Anexos] [varchar](50) NULL,
	[PreRegistro] [varchar](50) NULL,
	[ActaParticipacion] [varchar](50) NULL,
	[Temporadas] [varchar](50) NULL,
	[NombreAnual] [varchar](50) NULL)

