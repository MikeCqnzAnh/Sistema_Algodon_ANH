CREATE TABLE [dbo].[Micros](
	IdMicro int primary key IDENTITY(1,1) NOT NULL,
	Rango1 decimal(6, 2) NULL,
	Rango2 decimal(6, 2) NULL,
	Castigo decimal(6, 2) NULL,
	IdEstatus int,
	IdUsuarioCreacion int,
	FechaCreacion Date) 