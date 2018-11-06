create table Incidencias (
IdIncidencia int not null primary key identity(1,1),
IdTipo int,
Descripcion varchar(300),
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime
)