create table OrdenTrabajo (
IdOrdenTrabajo int not null primary key identity(1,1),
IdPlanta int,
IdProductor int,
RangoInicio int,
RangoFin int,
NumeroModulos int,
PesoModulos float,
IdVariedadAlgodon int,
IdColonia int,
Predio varchar(30),
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime,
IdUsuarioActualizacion int,
FechaActualizacion datetime
)

