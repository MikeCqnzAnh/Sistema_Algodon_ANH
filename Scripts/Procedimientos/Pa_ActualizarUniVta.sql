Create Procedure Pa_ActualizarUniVta
@IdVenta int,
@ValorN decimal(18,2),
@Rango1 decimal(18,2),
@Rango2 decimal(18,2)
as
update hvidetalle 
set UI=UI+(@ValorN-Cast(Round(UI,2,1) as decimal(18,2))) 
where BaleID in (select baleid from calculoclasificacion where Cast(Round(UI,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta);

update calculoclasificacion 
set UI=UI+(@ValorN-Cast(Round(UI,2,1) as decimal(18,2)))
where Cast(Round(UI,2,1) as decimal(18,2)) between @Rango1 and @Rango2 and IdVentaEnc = @IdVenta;