create table LiquidacionesPorRomaneaje
(
IdLiquidacion int PRIMARY KEY IDENTITY (1,1),
IdOrdenTrabajo int,
IdCliente int,
Fecha datetime,
Comentarios varchar(100),
TotalHueso float,
TotalPluma float,
PorcentajePluma float,
PorcentajeSemilla float,
TotalSemilla float,
PorcentajeMerma float,
TotalMerma float,
TotalPacas int,
TotalBoletas int,
TotalBorregos int,
TotalPlumaBorregos float,
IdEstatus int,
IdUsuarioCreacion int,
FechaCreacion datetime,
IdUsuarioActualizacion int,
FechaActualizacion datetime
)