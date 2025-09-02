Create table UniformidadDetalle
(
IdModoDetalle int identity(1,1) primary key,
IdModoEncabezado int,
Rango1 decimal(6,2),
Rango2 decimal(6,2),
Castigo decimal(6,2),
IdEstatus int
)