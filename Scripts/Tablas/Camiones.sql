create table Camiones(
IdCamion int primary key identity(1,1) not null,
Descripcion varchar(100),
Placas varchar(15),
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime
)