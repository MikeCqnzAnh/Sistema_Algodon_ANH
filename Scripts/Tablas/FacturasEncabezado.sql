Create table FacturasEncabezado
(
IdFactura int primary key identity(1,1),
IdIntegracionCompra int,
IdCompra int,
Emisor varchar(max),
RFC varchar(13),
UUID varchar(36),
FEcha datetime,
TotalToneladas decimal,
TotalPacas int,
subtotal decimal,
total decimal,
moneda varchar(3),
tipocambio decimal,
sello varchar(345),
ruta varchar(max),
FechaCreacion datetime,
FechaActualizacion datetime
)