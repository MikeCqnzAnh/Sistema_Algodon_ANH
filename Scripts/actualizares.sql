--Create Procedure Pa_ActualizarResVta
declare
@IdVenta int=32,
@ValorN decimal(18,1)=1,
@Rango1 decimal(18,2)=26.00,
@Rango2 decimal(18,2)=26.99
--as
update hvidetalle 
set Strength=Strength+@ValorN
where BaleID in (select baleid from calculoclasificacion where Cast(Round(Strength,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set Strength=Strength+@ValorN
where Cast(Round(Strength,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=1,
@Rango1 decimal(18,2)=25.00,
@Rango2 decimal(18,2)=25.99
--as
update hvidetalle 
set Strength=Strength+@ValorN
where BaleID in (select baleid from calculoclasificacion where Cast(Round(Strength,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set Strength=Strength+@ValorN
where Cast(Round(Strength,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=1,
@Rango1 decimal(18,2)=24.00,
@Rango2 decimal(18,2)=24.99
--as
update hvidetalle 
set Strength=Strength+@ValorN
where BaleID in (select baleid from calculoclasificacion where Cast(Round(Strength,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set Strength=Strength+@ValorN
where Cast(Round(Strength,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go
declare
@IdVenta int=32,
@ValorN decimal(18,1)=1,
@Rango1 decimal(18,2)=23.00,
@Rango2 decimal(18,2)=23.99
--as
update hvidetalle 
set Strength=Strength+@ValorN
where BaleID in (select baleid from calculoclasificacion where Cast(Round(Strength,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set Strength=Strength+@ValorN
where Cast(Round(Strength,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;
go





























