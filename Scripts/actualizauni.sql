--Create Procedure Pa_ActualizarUniVta
declare
@IdVenta int=32,
@ValorN decimal(18,1)=1.0,
@Rango1 decimal(18,2)=79.00,
@Rango2 decimal(18,2)=79.99
--as
update hvidetalle 
set UI=UI+@ValorN
where BaleID in (select baleid from calculoclasificacion where Cast(Round(UI,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set UI=UI+@ValorN
where Cast(Round(UI,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=1.0,
@Rango1 decimal(18,2)=78.00,
@Rango2 decimal(18,2)=78.99
--as
update hvidetalle 
set UI=UI+@ValorN
where BaleID in (select baleid from calculoclasificacion where Cast(Round(UI,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set UI=UI+@ValorN
where Cast(Round(UI,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=1.0,
@Rango1 decimal(18,2)=0.00,
@Rango2 decimal(18,2)=77.99
--as
update hvidetalle 
set UI=UI+@ValorN
where BaleID in (select baleid from calculoclasificacion where Cast(Round(UI,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set UI=UI+@ValorN
where Cast(Round(UI,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go























