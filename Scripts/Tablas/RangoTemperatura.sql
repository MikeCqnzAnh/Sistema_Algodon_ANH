create table RangoTemperatura (
IdRango int not null primary key identity(1,1),
RangoInicial float,
RangoFinal float,
DentroLimite bit,
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime
)
