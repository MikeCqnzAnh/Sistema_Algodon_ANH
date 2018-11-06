create table Plantas (
IdPlanta int not null primary key identity(1,1),
Descripcion varchar(30),
Registro varchar(25),
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime
)