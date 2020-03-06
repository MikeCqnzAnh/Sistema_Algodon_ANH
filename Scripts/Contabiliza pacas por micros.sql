SELECT count(BaleID) FROM CalculoClasificacion WHERE IdVentaEnc = 18 group by baleid,Mic having round(Mic,4,1) between (select rango1 from Micros) and (select rango2 from Micros)


    select COUNT(*) as cantidad_registros, rango_Tabla
    from (
    select case  
        when mic between 0.00 and 2.49 then '0.00 and 2.49'
		when mic between 2.50 and 2.59 then '2.50 and 2.59'
		when mic between 2.60 and 2.69 then '2.60 and 2.69'
		when mic between 2.70 and 2.79 then '2.70 and 2.79'
		when mic between 2.80 and 2.89 then '2.80 and 2.89'
		when mic between 2.90 and 2.99 then '2.90 and 2.99'
		when mic between 3.00 and 3.09 then '3.00 and 3.09'
		when mic between 3.10 and 3.19 then '3.10 and 3.19'
		when mic between 3.20 and 3.29 then '3.20 and 3.29'
		when mic between 3.30 and 3.39 then '3.30 and 3.39'
		when mic between 3.40 and 3.49 then '3.40 and 3.49'
		when mic between 3.50 and 4.99 then '3.50 and 4.99'
		when mic between 5.00 and 5.29 then '5.00 and 5.29'
        when mic between 5.30 and 10.99 then '5.30 and 10.99' end as rango_Tabla,
		mic
      from (

    select round(mic,2,1) as mic
    from CalculoClasificacion
	 WHERE IdVentaEnc = 18) res) tabla
    group by rango_Tabla order by rango_Tabla;

	select * from CalculoClasificacion where IdVentaEnc = 18 order by Mic