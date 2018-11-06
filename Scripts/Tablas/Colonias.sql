create table Colonias (
IdColonia int not null primary key identity(1,1),
Descripcion varchar(30),
NoPacas int,
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime
)