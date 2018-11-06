create table Empleados
(IdEmpleado int not null primary key identity(1,1),
Nombre varchar(50),
IdPuesto int,
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime
)