select a.cve_cli
	 , a.nombre
	 , d.nombre as porcuenta
	 , a.consec_paca
	 , a.consec_borr 
	 , sum(cast(c.bruto - c.tara as bigint)) as hueso
	 , b.cve_ordtrab
	 , e.cve_prod
	 , e.procesada
	 , e.cve_liq 
from clientes a inner join ordentrab b on a.cve_cli = b.cve_cli 
				left join boletas c on b.cve_ordtrab = c.cve_ordtrab and c.cancelada = 0 
				inner join porcuenta d on a.cve_porcta = d.cve_porcta 
				inner join produccion e on b.cve_ordtrab = e.cve_ordtrab 
				inner join detprod f on e.cve_prod = f.cve_prod 
where b.cve_planta = '00052' and e.cve_prod = '00005' and b.cve_planta = c.cve_planta and b.cve_planta = e.cve_planta and b.cve_planta = f.cve_planta 
group by a.cve_cli, a.nombre, d.nombre, a.consec_paca, a.consec_borr, e.cve_prod, e.procesada, b.cve_ordtrab, e.cve_liq

select * from PorCuenta
select * from ContratosAlgodon
select * from ContratosAlgodonBuyers
SELECT * FROM ContratosAlgodonDOC
select * from ContratosAlgodonLotes

select isnull(sum(cast(a.bruto - a.tara as bigint)),0) as total from boletas a where a.cve_planta = '00052' and a.cve_lote = '     '

select cve_lote from Boletas
select * from OrdenTrab

select * from PorCuenta where nombre in (select nombre from clientes)

select cl.Nombre, pc.Nombre, from Clientes cl inner join PorCuenta pc on cl.cve_cli = pc.cve_porcta

select a.procesada,a.cve_cli,b.nombre, b.consec_paca, c.nombre as porcta, a.cve_liq, isnull(a.reempaque,0) as reempaque, d.fecha 
from ordentrab a, clientes b, porcuenta c, produccion d 
where a.cve_ordtrab = d.cve_ordtrab and d.cve_prod = '00005' and a.cve_planta = d.cve_planta and a.cve_planta = '00052' and a.cve_cli = b.cve_cli and b.cve_porcta = c.cve_porcta


select count(c.consec_elsa) as pacas , sum(c.cant_kilos) as pluma, a.kilos_hueso as hueso, b.semilla, c.Tipo 
from ordentrab a, produccion b, detprod c 
where b.cve_planta = '00052' and a.cve_planta = b.cve_planta and a.cve_planta = c.cve_planta and a.cve_ordtrab = b.cve_ordtrab and b.cve_prod = c.cve_prod and c.tipo = 'P' and b.cve_prod = '00005' 
group by a.kilos_hueso, b.semilla, c.Tipo 
	union all 
	select count(c.consec_elsa) as pacas, sum(c.cant_kilos) as pluma, a.kilos_hueso as hueso, b.semilla, c.Tipo 
	from ordentrab a, produccion b, detprod c 
	where b.cve_planta = '00052' and a.cve_planta = b.cve_planta and a.cve_planta = c.cve_planta and a.cve_ordtrab = b.cve_ordtrab and b.cve_prod = c.cve_prod and c.tipo = 'B' and b.cve_prod = '00005' 
group by a.kilos_hueso,b.semilla, c.Tipo

select * from Produccion