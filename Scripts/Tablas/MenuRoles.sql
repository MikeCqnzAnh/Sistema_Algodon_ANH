Create table MenuRoles
(
IdMenuRoles int primary key identity(1,1),
Descripcion varchar(max),
IdPadre int,
IdEstatus bit
)
