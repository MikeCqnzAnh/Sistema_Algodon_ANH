Create table Almacen 
(
IdAlmacen int primary key identity(1,1),
Descripcion varchar(30),
IdTipoAlmacen int,
Calle varchar(50),
Numero varchar(7),
CodigoPostal varchar(8),
Colonia varchar(50),
Ciudad int,
Estado int,
Capacidad float
)