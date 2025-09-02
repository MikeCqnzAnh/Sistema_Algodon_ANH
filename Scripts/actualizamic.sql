----Create Procedure Pa_ActualizarMicVta
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.2,
@Rango1 decimal(18,2)=3.40,
@Rango2 decimal(18,2)=3.49
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.2,
@Rango1 decimal(18,2)=3.30,
@Rango2 decimal(18,2)=3.39
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.2,
@Rango1 decimal(18,2)=3.20,
@Rango2 decimal(18,2)=3.29
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.2,
@Rango1 decimal(18,2)=3.10,
@Rango2 decimal(18,2)=3.19
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.3,
@Rango1 decimal(18,2)=3.00,
@Rango2 decimal(18,2)=3.09
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.3,
@Rango1 decimal(18,2)=2.90,
@Rango2 decimal(18,2)=2.99
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.3,
@Rango1 decimal(18,2)=2.80,
@Rango2 decimal(18,2)=2.89
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.3,
@Rango1 decimal(18,2)=2.70,
@Rango2 decimal(18,2)=2.79
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.3,
@Rango1 decimal(18,2)=2.60,
@Rango2 decimal(18,2)=2.69
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.3,
@Rango1 decimal(18,2)=2.50,
@Rango2 decimal(18,2)=2.59
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.2,
@Rango1 decimal(18,2)=2.40,
@Rango2 decimal(18,2)=2.49
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.3,
@Rango1 decimal(18,2)=2.30,
@Rango2 decimal(18,2)=2.39
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.2,
@Rango1 decimal(18,2)=2.20,
@Rango2 decimal(18,2)=2.29
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=0.4,
@Rango1 decimal(18,2)=2.10,
@Rango2 decimal(18,2)=2.19
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=28,
@ValorN decimal(18,1)=0.2,
@Rango1 decimal(18,2)=2.52,
@Rango2 decimal(18,2)=2.53
--as
update hvidetalle 
set mic=mic+@ValorN
--select mic,mic+@ValorN from hvidetalle
where BaleID in (select baleid from calculoclasificacion where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set mic=mic+@ValorN
--select mic,mic+@ValorN from calculoclasificacion
where Cast(Round(mic,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go




























