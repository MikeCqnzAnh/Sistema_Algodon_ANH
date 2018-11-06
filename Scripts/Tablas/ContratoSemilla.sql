create table ContratoSemilla (
IdContratoSemilla int not null primary key identity(1,1),
Folio varchar(25),
Fecha datetime,
IdComprador int, 
Cantidad float,
PrecioTonelada float,
Testigo1 varchar(30),
Testigo2 varchar(30),
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime,
IdUsuarioActualizacion int,
FechaActualizacion datetime
)