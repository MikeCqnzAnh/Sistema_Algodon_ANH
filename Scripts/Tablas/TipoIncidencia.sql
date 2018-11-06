create table TipoIncidencia(
IdTipoIncidencia int not null primary key identity(1,1),
Descripcion varchar(50),
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime
)