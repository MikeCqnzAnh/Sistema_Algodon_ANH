update CalculoClasificacion
set UHML = uhml -convert(decimal(18,2),(UHML-convert(decimal(18,2),1.31)))
WHERE Idventaenc = 6 and UHML BETWEEN 1.33 AND 1.36

update HVIDETALLE
set UHML = uhml -convert(decimal(18,2),(UHML-convert(decimal(18,2),1.31)))
WHERE BaleID IN (SELECT BALEID FROM CalculoClasificacion WHERE Idventaenc = 6 and UHML BETWEEN 1.33 AND 1.36)


select baleid,uhml,uhml -convert(decimal(18,2),(UHML-convert(decimal(18,2),1.31))) from calculoclasificacion where Idventaenc = 6 and UHML BETWEEN 1.33 AND 1.36