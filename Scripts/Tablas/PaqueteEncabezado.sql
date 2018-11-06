create table PaqueteEncabezado (
IdPaquete int not null primary key identity(1,1),
IdPlanta int,
IdClase int,
CantidadPacas int,
Descripcion varchar(20),
chkrevisado bit,
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime,
IdUsuarioActualizacion int,
FechaActualizacion datetime
)