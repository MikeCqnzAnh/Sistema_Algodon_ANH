create table Usuarios
(
IdUsuario int primary key identity(1,1),
Nombre varchar(40),
Usuario varchar(15),
Clave varchar(10),
Tipo int,
ClaveAutorizacion int
)