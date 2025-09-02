Create table EmbarqueDet
(
IdEmbarqueDet int identity(1,1) primary key,
IdEmbarqueEnc int,
CantidadPacas int,
NoContenedor Varchar(12),
NoLote varchar(15),
PlacaCaja varchar(13),
Fecha datetime,
FechaActualizacion datetime
)