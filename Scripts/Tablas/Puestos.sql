create table Puestos(
IdPuesto int not null primary key identity(1,1),
Descripcion varchar(30),
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime
)