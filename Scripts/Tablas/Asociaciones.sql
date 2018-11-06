create table Asociaciones(
IdAsociacion int not null primary key identity(1,1),
Descripcion varchar(100) not null,
IdEstatus int not null,
IdUsuarioCreacion int not null,
FechaCreacion datetime not null
)