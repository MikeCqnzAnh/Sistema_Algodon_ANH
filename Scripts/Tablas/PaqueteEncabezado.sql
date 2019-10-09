create table PaqueteEncabezado (
IdPaquete int not null primary key identity(1,1),
IdPlanta int,
idComprador int,
IdClase int,
CantidadPacas int,
Descripcion varchar(20),
Entrega int,
chkrevisado bit,
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime,
IdUsuarioActualizacion int,
FechaActualizacion datetime
)