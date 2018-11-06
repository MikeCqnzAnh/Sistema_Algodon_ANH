create table BoletasPorOrden(
IdBoleta int not null primary key identity(1,1),
IdOrdenTrabajo int,
IdPlanta int,
FechaOrden datetime,
Bruto float,
Tara float,
Total float,
IdProductor int,
IdBodega int,
NoTransporte int,
FlagCancelada bit,
FlagRevisada bit,
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime,
IdUsuarioActualizacion int,
FechaActualizacion datetime
)