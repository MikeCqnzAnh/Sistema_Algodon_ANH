create table Compradores (
IdComprador int not null primary key identity(1,1),
Nombre varchar(100),
Rfc varchar(20),
Curp varchar(20),
Domicilio varchar(100),
IdEstado int,
IdMunicipio int,
Telefono varchar(15),
Correo varchar(50),
IdUsuarioCreacion int,
FechaCreacion datetime, 
IdEstatus int 
)