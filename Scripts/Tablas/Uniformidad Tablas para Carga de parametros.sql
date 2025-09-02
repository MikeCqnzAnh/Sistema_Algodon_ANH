Create table UniformidadCompras
(
IdUniformidadCompra int primary key identity(1,1),
Rango1 float,
Rango2 float,
Castigo float
)

go

Create table UniformidadVentas
(
IdUniformidadVentas int primary key identity(1,1),
Rango1 float,
Rango2 float,
Castigo float
)
go
insert into UniformidadCompras (rango1,rango2,castigo) values
(0,77.9,1.05),
(78,78.9,0.6),
(79,79.9,0.5),
(80,100,0)

go 
insert into UniformidadVentas (rango1,rango2,castigo) values
(0,77.9,1.05),
(78,78.9,0.6),
(79,79.9,0.5),
(80,100,0)