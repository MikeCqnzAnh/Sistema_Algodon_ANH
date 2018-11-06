create table IncidenciaCamiones
(
IdIncidenciaCamion int not null primary key identity(1,1),
IdBoleta int,
NoTransporte int,
Bruto float,
Tara float,
Neto float,
TipoFlete int,
FechaCreacion datetime
)